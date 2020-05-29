using System;
using System.Collections.Generic;

namespace RefactoringApp.OrganizingData.ChangeBidirectionalAssociationToUnidirectional
{
    class BidirectionalAssociation
    {
        public void BidirectionalAssociationExample()
        {
            var customer = new Customer
            {
                DiscountPercentage = 0.1,
                Name = "Customer"
            };

            var order = new Order
            {
                GrossPrice = 100,
                Customer = customer
            };

            customer.AddOrder(order);

            Console.WriteLine(order.GetDiscountedPrice());
        }
    }

    class Order
    {
        public Customer Customer { get; set; }
        public double GrossPrice { get; set; }

        public void SetCustomer(Customer customer)
        {
            Customer = customer;
        }

        public double GetDiscountedPrice()
        {
            return GrossPrice * (1 - Customer.DiscountPercentage);
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public IList<Order> Orders { get; set; }
        public double DiscountPercentage { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}
