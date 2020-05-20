using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringApp.MovingFeaturesBetweenObjects.RemoveMiddleMan
{
    class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Product GetAccountProduct(Guid accountId)
        {
            return new Product
            {
                Id = Guid.NewGuid(),
                Name = "Test Product"
            };
        }

        public void ShowName()
        {
            Console.WriteLine(Name);
        }
    }
}
