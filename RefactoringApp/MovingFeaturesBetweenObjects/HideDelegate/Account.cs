using System;
using System.Collections.Generic;

namespace RefactoringApp.MovingFeaturesBetweenObjects.HideDelegate
{
    class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }

        public Account()
        {
            Id = Guid.NewGuid();
            Name = "Test";
            Product = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Test Product"
            };
        }
    }
}
