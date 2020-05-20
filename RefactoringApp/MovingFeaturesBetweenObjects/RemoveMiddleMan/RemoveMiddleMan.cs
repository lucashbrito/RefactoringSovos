using System;

namespace RefactoringApp.MovingFeaturesBetweenObjects.RemoveMiddleMan
{
    class RemoveMiddleMan
    {
        public void GetAccountProductsHideDelegate(Guid accountId)
        {
            var account = new Account();

            account.Product.ShowName();
        }

        public void GetAccountProductsRemoveMiddleMan(Guid accountId)
        {
            var account = new Account();
            var product = new Product();

            var accountProduct = product.GetAccountProduct(account.Id);

            accountProduct.ShowName();
        }
    }
}
