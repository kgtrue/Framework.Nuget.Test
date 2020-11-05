using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Nuget.Test
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var caller = new Caller();
            await caller.PrintPersonsToConsole();
        }
    }
}
