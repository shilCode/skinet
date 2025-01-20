using System;
using Core.Entities;

namespace Core.Specification;

public class ProductSpecification : BaseSpecification<Product>
{
    public ProductSpecification(ProductSpecParam specParam) : base(
        x => (specParam.Brands.Count == 0 || specParam.Brands.Contains(x.Brand)) &&
        (specParam.Types.Count == 0 || specParam.Types.Contains(x.Type))
    )
    {
        switch (specParam.Sort)
        {
            
            case "priceAsc":
                AddOrderBy(x=>x.Price);
                break;
            case "priceDesc":
                AddOrderByDesc(x=>x.Price);
                break;
            default:
                AddOrderBy(x=>x.Name);
                break;
        }
    }
}
