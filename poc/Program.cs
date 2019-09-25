using System;
using System.IO;
using System.Collections.Generic;

using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization.NodeDeserializers;


namespace poc
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new StringReader(@"---
                test:
                  inp1: 3
                  inp2: 4");

            var deserializer = new DeserializerBuilder()
                // .WithNamingConvention(new CamelCaseNamingConvention())
                .Build();

            var order = deserializer.Deserialize<Dictionary<object,object>>(input);

            Console.WriteLine((((Dictionary<object,object>)order["test"])["inp1"] as ScalarWrapper).Value);
        }
    }
}
