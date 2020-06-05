using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringApp.SimplifyingConditionalExpressions.RemoveControlFlag
{
    class RemoveControlFlag
    {
        public void ControlFlag()
        {
            var value = new Random().Next(0, 250);
            var found = false;
            for (int i = 0; i <= 100; i++)
            {
                if (value == i)
                {
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine(value);
            }
        }

        public void ControlFlagRefactored()
        {
            var value = new Random().Next(0, 250);
            for (int i = 0; i <= 100; i++)
            {
                if (value == i)
                {
                    Console.WriteLine(value);
                    break;
                }
            }
        }
    }
}
