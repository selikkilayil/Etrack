using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace Core
{
    public interface ISpecification<T>
    {
        IEnumerable<Expression<Func<T, bool>>> WhereExpressions { get; }
        IEnumerable<string> IncludeStrings { get; }
        
        //IEnumerable<IIncludeAggregator> IncludeAggregators { get; }

        //[TupleElementNames(new[] { "KeySelector", "OrderType" })]
        //IEnumerable<(Expression<Func<T, object>> KeySelector, OrderTypeEnum OrderType)> OrderExpressions { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
        bool CacheEnabled { get; }
        string? CacheKey { get; }
    }
}
