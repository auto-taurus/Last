
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;

namespace Auto.Commons.Extensions.EfCore {
    public static class DbContextExtensions {
        private static DbCommand CreateCommand(DatabaseFacade facade, string sql, out DbConnection connection, params object[] parameters) {
            var conn = facade.GetDbConnection();
            connection = conn;
            conn.Open();
            var cmd = conn.CreateCommand();
            //if (facade.IsSqlServer()) {
            cmd.CommandText = sql;
            cmd.Parameters.AddRange(parameters);
            //}
            return cmd;
        }

        public static DataTable SqlQuery(this DatabaseFacade facade, string sql, params object[] parameters) {
            var command = CreateCommand(facade, sql, out DbConnection conn, parameters);
            var reader = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            conn.Close();
            return dt;
        }

        public static List<T> SqlQuery<T>(this DatabaseFacade facade, string sql, params object[] parameters) where T : class, new() {
            var dt = SqlQuery(facade, sql, parameters);
            return dt.ToList<T>();
        }

        public static List<T> ToList<T>(this DataTable dt) where T : class, new() {
            var propertyInfos = typeof(T).GetProperties();
            var list = new List<T>();
            foreach (DataRow row in dt.Rows) {
                var t = new T();
                foreach (PropertyInfo p in propertyInfos) {
                    if (dt.Columns.IndexOf(p.Name) != -1 && row[p.Name] != DBNull.Value) {
                        var value = row[p.Name];
                        var types = value.GetType().ToString().ToLower();
                        if (types == "System.Int64".ToLower()) {
                            value = Convert.ToInt32(value);
                        }
                        p.SetValue(t, value, null);
                    }
                }
                list.Add(t);
            }
            return list;
        }

    }
}
