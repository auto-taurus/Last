using System;
using System.Security.Cryptography;
using System.Text;

namespace Auto.Commons {
    public class Tools {
        public static string Md5(string input) {
            using (var md5 = MD5.Create()) {
                var result = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
                var strResult = BitConverter.ToString(result);
                return strResult.Replace("-", "");
            }
        }
    }
}
