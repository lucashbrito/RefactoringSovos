using System;

namespace RefactoringApp.OrganizingData.EncapsulateField
{
    class EncapsulateField
    {
        public void GetFieldValue()
        {
            var product = new Product
            {
                Name = "test"
            };

            Console.WriteLine(product.Name);
        }

        public void GetFieldValueRefactored()
        {
            var product = new Product
            {
                Name = "test"
            };

            Console.WriteLine(product.GetName());
        }
    }

    class Product
    {
        public string Name { get; set; }

        public string GetName()
        {
            return Name;
        }
    }
}
