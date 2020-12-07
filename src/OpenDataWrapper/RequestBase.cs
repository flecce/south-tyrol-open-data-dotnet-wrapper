using System;

namespace OpenDataWrapper
{
    public class RequestBase
    {
        public string RepresentationType { get; private set; }
        public string[] StationTypes { get; private set; }
        public string[] DataTypes { get; private set; }
        public DateTime? From { get; private set; }
        public DateTime? To { get; private set; }
        public int? Offset { get; private set; }
        public int? Limit { get; private set; }
        public string Select { get; private set; }
        public WhereClause Where { get; private set; }

        public static RequestBase Create(
            string representationType,
            string[] stationTypes,
            string[] dataTypes = null,
            string select = null,
            WhereClause where = null,
            int offset = 0,
            int limit = 200)
        {
            return new RequestBase
            {
                RepresentationType = representationType,
                StationTypes = stationTypes,
                DataTypes = dataTypes,
                Select = select,
                Where = where,
                Offset = offset,
                Limit = limit
            };
        }
    }

    public class WhereClause
    {
        public IExpression LogicalOperation { get; set; }

        public WhereClause(IExpression logicalOperation)
        {
            LogicalOperation = logicalOperation;
        }

        public override string ToString()
        {
            return LogicalOperation.ToString();
        }
    }

    public interface IExpression
    {
    }

    public class FilterTriple : IExpression
    {
        public string Alias { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }

        public FilterTriple(string alias, string op, string value)
        {
            Alias = alias;
            Operator = op;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Alias}.{Operator}.{Value}";
        }
    }

    public abstract class LogicalExpression : IExpression
    {
        protected abstract string Symbol { get; }
        public IExpression LeftExpr { get; set; }
        public IExpression RightExpr { get; set; }

        public LogicalExpression(IExpression left, IExpression right)
        {
            LeftExpr = left;
            RightExpr = right;
        }

        public override string ToString()
        {
            return $"{Symbol}({LeftExpr},{RightExpr})";
        }
    }

    public class AndElse : LogicalExpression
    {
        protected override string Symbol => "and";

        public AndElse(IExpression left, IExpression right) : base(left, right)
        {
        }
    }

    public class OrElse : LogicalExpression
    {
        protected override string Symbol => "or";

        public OrElse(IExpression left, IExpression right) : base(left, right)
        {
        }
    }
}
