using System;
using RefactoringApp.OrganizingData.Replace_type_code_with_subclasses;

namespace RefactoringApp.OrganizingData.Replace_type_code_with_state_strategy
{
    // You have a type code that affects the behavior of a class, but you cannot use subclassing.
    public class Car
    {
        private TypeCar _type;

        public Car(TypeCar type)
        {
            _type = type;
        }

        public virtual TypeCar GetType() => _type;

        public double Price()
        {
            switch (GetType())
            {
                case TypeCar.Fiat:
                    return 13;
                case TypeCar.Bmw:
                    return 23;
                case TypeCar.Honda:
                    return 17;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void SetType(TypeCar type) => _type = type;
    }
}
