using System;

namespace RefactoringApp.OrganizingData.Replace_type_code_with_subclasses
{
    // You have an immutable type code that affects the behavior of a class. 
    public enum TypeCar
    {
        Fiat = 0,
        Bmw = 1,
        Honda = 2
    }

    public class Car
    {
        private TypeCar _type;
        public Car(TypeCar type)
        {
            _type = type;
        }

        public virtual TypeCar GetType()
        {
            return _type;
        }
    }

    public abstract class CarRefactoring
    {
        private TypeCar _type;

        protected CarRefactoring(TypeCar type)
        {
            _type = type;
        }

        public static CarRefactoring Create(TypeCar type)
        {
            try
            {
                return (CarRefactoring)Activator.CreateInstance(Type.GetType($"RefactoringApp.OrganizingData.Replace_type_code_with_subclasses.{type}"), new object[] { type });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public abstract TypeCar GetType();
    }

    public class Fiat : CarRefactoring
    {
        private Fiat(TypeCar type) : base(type)
        {
        }

        public override TypeCar GetType()
        {
            return TypeCar.Fiat;
        }
    }

    public class Bmw : CarRefactoring
    {
        private Bmw(TypeCar type) : base(type)
        {
        }

        public override TypeCar GetType()
        {
            return TypeCar.Bmw;
        }
    }

    public class Honda : CarRefactoring
    {
        private Honda(TypeCar type) : base(type)
        {
        }

        public override TypeCar GetType()
        {
            return TypeCar.Honda;
        }
    }

    public class Run
    {
        void Main()
        {
            Console.WriteLine(CarRefactoring.Create(TypeCar.Fiat).GetType());
            Console.WriteLine(CarRefactoring.Create(TypeCar.Bmw).GetType());
            Console.WriteLine(CarRefactoring.Create(TypeCar.Honda).GetType());
        }

    }

}
