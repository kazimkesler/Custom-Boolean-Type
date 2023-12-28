using Core.Results.Abstract;
using Newtonsoft.Json;

namespace UI
{
    internal class Program
    {
        static Result Check()
        {
            Console.WriteLine("Run");
            return Result.OkWithMessage("run");
        }

        static void Main(string[] args)
        {
            //Non-Generic(with null data property)

            Result resultnongeneric = Result.Ok(); // Create OK result
            bool boolean = Result.Ok();
            bool boolean1 = !Result.NotFound();
            Result and1 = Result.NotFound() && Result.BadRequest(); //return first wrong object, short-circuit
            Result and2 = Result.NotFound() && Check();//return first wrong object, short-circuit
            Result and3 = Result.Ok() && Result.NotFound();//return first wrong object, short-circuit
            Result and4 = Result.Ok() && Result.Created();//return Success object, short-circuit

            //Generic, Auto Type Inference(with generic data property)

            var data = DateTime.Now;
            Result resultgeneric = Result.Ok(data); // Create OK result with data
            bool boolean2 = Result.Ok("data");
            bool boolean3 = !Result.NotFound();
            Result or1 = Result.NotFound() || Result.BadRequest(); //return Error object, short-circuit
            Result or2 = Result.NotFound() || Result.Ok();//return first right object, short-circuit
            Result or3 = Result.Ok(data) || Result.NotFound();//return first right object, short-circuit
            Result or4 = Result.Created(data) || Result.Ok();//return first right object, short-circuit

            Console.WriteLine(JsonConvert.SerializeObject(resultnongeneric));//with the same properties(with null data property)
            Console.WriteLine(JsonConvert.SerializeObject(resultgeneric));//with the same properties(with data property)
        }
    }
}