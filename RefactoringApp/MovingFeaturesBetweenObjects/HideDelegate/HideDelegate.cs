using System;

namespace RefactoringApp.MovingFeaturesBetweenObjects.HideDelegate
{
    class HideDelegate
    {
        public void GetAccountProductsOriginal(Guid accountId)
        {
            var account = new Account();
            var product = new Product();

            var accountProduct = product.GetAccountProduct(account.Id);

            accountProduct.ShowName();
        }

        public void GetAccountProductsHideDelegate(Guid accountId)
        {
            var account = new Account();

            account.Product.ShowName();
        }
    }
}
