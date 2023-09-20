using LeanTask.Application.Specifications.Base;
using LeanTask.Domain.Entities.Catalog;

namespace LeanTask.Application.Specifications.Catalog
{
    public class BrandFilterSpecification : LeanSpecification<Brand>
    {
        public BrandFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Name.Contains(searchString) || p.Description.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}
