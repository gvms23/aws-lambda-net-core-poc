using Amazon.Lambda.Core;
using System.Linq;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace FunctionCalculadora
{
    public class Function
    {
        
        public object FunctionHandler(string request, ILambdaContext context)
        {
            string result = request.Split(',').Sum(int.Parse).ToString();

            return new
            {
                result,
                context = System.Text.Json.JsonSerializer.Serialize(context)
            };
        }
    }
}
