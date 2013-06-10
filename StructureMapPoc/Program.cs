using System;
using vSol.CQRS.Commands;
using Diary.CQRS.Commands;

namespace StructureMapPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // #1 - Implementation is vSol.CQRS framework assembly.....
                Console.WriteLine("Sending [RemoveItemCommand]...");
                var retVal = ServiceLocator.CommandBus.Send(new RemoveItemCommand(Guid.NewGuid(), -1));

                if (string.Compare(retVal.ErrorCode, "0") == 0)
                    Console.WriteLine("\t[RemoveItemCommand] executed successfully.");
                else
                    Console.WriteLine("\tFailed to execute [RemoveItemCommand]!");

                // #2 - Implementation is Diary.CQRS implementation assembly..... 
                Console.WriteLine("\n\nSending [CreateItemCommand]...");
                retVal = ServiceLocator.CommandBus.Send(new Diary.CQRS.Commands.CreateItemCommand(Guid.NewGuid(), -1, "Title", "Description", DateTime.Now));
                
                if (string.Compare(retVal.ErrorCode, "0") == 0)
                    Console.WriteLine("\t[CreateItemCommand] executed successfully...");
                else
                    Console.WriteLine("\tFailed to execute [CreateItemCommand]!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }       
            Console.Read();
        }
    }
}