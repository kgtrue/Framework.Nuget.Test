using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Nuget.Test
{
    public class Caller
    {
        public async Task PrintPersonsToConsole()
        {
            var serviceClient = new  NetCore.Nuget.Test.ApiAsyncEndpoint();

            var persons = await serviceClient.GetPersonsAsObj(30);
            foreach (var person in persons)
            {
                await Console.Out.WriteLineAsync(person.Name);
            }
        }
    }
}
