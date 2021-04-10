using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace eco.Interfaces
{
    public interface ISpecification<T>
    {
        //ISpecification, BaseSpecification, SpecificationEvaluator
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
    }
}
