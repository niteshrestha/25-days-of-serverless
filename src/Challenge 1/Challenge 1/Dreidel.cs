using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Challenge_1
{
    public static class Dreidel
    {
        [FunctionName("Dreidel")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            Random rnd = new Random();

            string[] dreidelOutput = { "נ(Nun)", "ג(Gimmel)", "ה(Hay)", "ש(Shin)" };

            return (ActionResult)new OkObjectResult(dreidelOutput[rnd.Next(0, 3)]);
        }
    }
}
