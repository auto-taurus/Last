using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Auto.Commons.Extensions.Predicate {
    /// <summary>
    /// LINKS：https://github.com/luancarloswd/predicate-extensions-core
    /// GIT：https://github.com/luancarloswd/predicate-extensions-core.git
    /// </summary>
    public static class Predicate {
        public static Expression<Func<T, bool>> Begin<T>(bool value = false) {
            if (value)
                return parameter => true;

            return parameter => false;
        }

        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> left,
            Expression<Func<T, bool>> right) =>
            CombineLambdas(left, right, ExpressionType.AndAlso);

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> left,
            Expression<Func<T, bool>> right) => CombineLambdas(left, right, ExpressionType.OrElse);

        private static Expression<Func<T, bool>> CombineLambdas<T>(this Expression<Func<T, bool>> left,
            Expression<Func<T, bool>> right, ExpressionType expressionType) {
            if (left == null || IsExpressionBodyConstant(left))
                return right;

            if (right == null)
                return left;

            var p = left.Parameters[0];
            var visitor = new SubstituteParameterVisitor();
            visitor.Sub[right.Parameters[0]] = p;

            Expression body = Expression.MakeBinary(expressionType, left.Body, visitor.Visit(right.Body));
            return Expression.Lambda<Func<T, bool>>(body, p);
        }
        private static bool IsExpressionBodyConstant<T>(Expression<Func<T, bool>> left) =>
            left.Body.NodeType == ExpressionType.Constant;
    }
    internal class SubstituteParameterVisitor : ExpressionVisitor {
        public readonly Dictionary<Expression, Expression> Sub = new Dictionary<Expression, Expression>();

        protected override Expression VisitParameter(ParameterExpression node) =>
            Sub.TryGetValue(node, out var newValue) ? newValue : node;
    }
}
