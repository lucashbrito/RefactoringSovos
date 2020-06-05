using System;

namespace RefactoringApp.SimplifyingConditionalExpressions.ConsolidateDuplicateConditionalFragments
{
    public class ConsolidateDuplicateConditionalFragments
    {
        public void DuplicateConditional()
        {
            var value = new Random().Next(0, 10);
            if (Validation(value))
            {
                DoThis();
                Console.WriteLine(value * 100);
                DoThat();
            }
            else
            {
                DoThis();
                Console.WriteLine(value * 12);
                DoThat();
            }
        }

        public void DuplicateConditionalRefactored()
        {
            var value = new Random().Next(0, 10);
            
            DoThis();
            
            if (Validation(value))
            {
                Console.WriteLine(value * 100);
            }
            else
            {
                Console.WriteLine(value * 12);
            }

            DoThat();
        }

        public bool Validation(int value)
        {
            return value >= 5;
        }

        public void DoThis()
        {

        }

        public void DoThat()
        {

        }
    }
}
