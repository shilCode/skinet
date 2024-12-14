using System;
using System.Linq.Expressions;
using Core.Interfaces;

namespace Core.Specification;

public class BaseSpecification<T>(Expression<Func<T, bool>>? criteria) : ISpecification<T>
{
    protected BaseSpecification() : this(null) { }
    public Expression<Func<T, bool>>? Criteria => criteria;

    public Expression<Func<T, object>>? OrderBy { get; private set; }

    public Expression<Func<T, object>>? OrderByDesc { get; private set; }
    protected void AddOrderBy(Expression<Func<T, Object>> orderByExpression)
    {
        OrderBy = orderByExpression;
    }
    protected void AddOrderByDesc(Expression<Func<T, Object>> orderByDescExpression)
    {
        OrderByDesc = orderByDescExpression;
    }
}
