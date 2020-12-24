using System;

namespace OpenDataWrapper
{
    /// <summary>
    /// Mobility request builder.
    /// </summary>
    public class RequestBuilder
    {
        private string _representationType;
        private string[] _stationTypes;
        private string[] _dataTypes;
        private DateTime? _from;
        private DateTime? _to;
        private int? _offset;
        private int? _limit;
        private string _select;
        private WhereClause _whereClause;

        public RequestBuilder UseRepresentationType(string representationType)
        {
            _representationType = representationType;
            return this;
        }

        public RequestBuilder UseStationTypes(params string[] stationTypes)
        {
            _stationTypes = stationTypes;
            return this;
        }

        public RequestBuilder UseDataTypes(params string[] dataTypes)
        {
            _dataTypes = dataTypes;
            return this;
        }

        public RequestBuilder From(DateTime? from)
        {
            _from = from;
            return this;
        }

        public RequestBuilder To(DateTime? to)
        {
            _to = to;
            return this;
        }

        public RequestBuilder WithOffset(int? offset)
        {
            _offset = offset;
            return this;
        }

        public RequestBuilder WithLimit(int? limit)
        {
            _limit = limit;
            return this;
        }

        public RequestBuilder Select(string select)
        {
            _select = select;
            return this;
        }

        public RequestBuilder Where(WhereClause whereClause)
        {
            _whereClause = whereClause;
            return this;
        }

        public RequestBase Get()
        {
            return RequestBase.Create(
                _representationType,
                _stationTypes,
                _dataTypes,
                _select,
                _whereClause,
                _offset,
                _limit);
        }
    }
}
