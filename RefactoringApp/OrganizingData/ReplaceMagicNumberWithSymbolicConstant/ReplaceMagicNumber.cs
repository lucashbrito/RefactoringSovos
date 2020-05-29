using System;

namespace RefactoringApp.OrganizingData.ReplaceMagicNumberWithSymbolicConstant
{
    class ReplaceMagicNumber
    {
        private const int TRANSMISSION_USER_ID = -3;

        public void AutomaticTransmission()
        {
            ExecuteAction("Transmit", -3);
        }

        public void AutomaticTransmission_Refactored()
        {
            var action = "Transmit";

            ExecuteAction(action, TRANSMISSION_USER_ID);
        }

        public void ExecuteAction(string action, int accountId)
        {
            Console.WriteLine("Transmitted");
        }
    }
}
