using System;
using System.Collections.Generic;

namespace RefactoringApp.OrganizingData.ChangeBidirectionalAssociationToUnidirectional
{
    class UnidirectionalAssociation
    {
        public void UndirectionalAssociationExample()
        {
            var customer = new CustomerRefactored
            {
                DiscountPercentage = 0.1,
                Name = "Customer"
            };

            var order = new OrderRefactored
            {
                GrossPrice = 100
            };

            customer.AddOrder(order);

            Console.WriteLine(order.GetDiscountedPrice(customer));
        }
    }

    class OrderRefactored
    {
        public double GrossPrice { get; set; }

        public double GetDiscountedPrice(CustomerRefactored customer)
        {
            return GrossPrice * (1 - customer.DiscountPercentage);
        }
    }

    class CustomerRefactored
    {
        public string Name { get; set; }
        public IList<OrderRefactored> Orders { get; set; }
        public double DiscountPercentage { get; set; }

        public CustomerRefactored()
        {
            Orders = new List<OrderRefactored>();
        }

        public void AddOrder(OrderRefactored order)
        {
            Orders.Add(order);
        }
    }
}
