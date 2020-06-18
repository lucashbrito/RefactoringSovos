using System;

namespace RefactoringApp.Making_Methods_Calls_Simpler.Add_Parameter
{
    public class AddParameter
    {
        public void Original()
        {
            var batch = new Batch();

            batch.DeleteBatch(1, DateTime.Now);
        }

        public void Refactored()
        {
            var batch = new Batch();

            batch.DeleteBatch(1, DateTime.Now, 2);
        }
    }

    public class Batch
    {
        public void DeleteBatch(int batchId, DateTime date)
        {
            Console.WriteLine("Old method");
        }

        public void DeleteBatch(int batchId, DateTime date, int userId)
        {
            Console.WriteLine("New method");
        }
    }
}
