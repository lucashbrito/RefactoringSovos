using System;

namespace RefactoringApp.Making_Methods_Calls_Simpler.Remove_Parameter
{
    class RemoveParameter
    {
        public void Original()
        {
            var batch = new Batch();

            batch.DeleteBatch(1, DateTime.Now);
        }

        public void Refactored()
        {
            var batch = new Batch
            {
                Batch_Id = 1
            };

            batch.DeleteBatch(DateTime.Now);
        }
    }

    public class Batch
    {
        public int Batch_Id { get; set; }
        public void DeleteBatch(int batchId, DateTime date)
        {
            Console.WriteLine("Old method");
        }

        public void DeleteBatch(DateTime date)
        {
            Console.WriteLine($"New method getting Batch_Id from object - {Batch_Id}");
        }
    }
}
