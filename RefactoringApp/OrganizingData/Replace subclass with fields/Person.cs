namespace RefactoringApp.OrganizingData.Replace_subclass_with_fields
{
    public abstract class Person
    {
        public abstract bool IsMale();
        public abstract char GetCode();

    }

    //public class Male : Person
    //{
    //    public override bool IsMale()
    //    {
    //        return true;
    //    }

    //    public override char GetCode()
    //    {
    //        return 'M';
    //    }
    //}

    //public class Female : Person
    //{
    //    public override bool IsMale()
    //    {
    //        return false;
    //    }

    //    public override char GetCode()
    //    {
    //        return 'F';
    //    }
    //}

    public class Male : PersonRefactoring
    {
        public Male():base(true, 'M')
        {
            
        }
    }

    public class Female : PersonRefactoring
    {
        public Female():base(false, 'M')
        {
            
        }
    }

    public abstract class PersonRefactoring
    {
        private bool _isMale;
        private char _code;

        public PersonRefactoring(bool isMale, char code)
        {
            _isMale = isMale;
            _code = code;
        }
        public static Male CreateMale()
        {
            return new Male();
        }

        public static Female CreateFemale()
        {
            return new Female();
        }

        public  bool IsMale()
        {
            return _isMale;
        }

        public  char GetCode()
        {
            return _code;
        }
    }
}
