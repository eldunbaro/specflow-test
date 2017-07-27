using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string accessKey = "AKIAIP7GFUE2MSO6BDDQ";
            string secretKey = "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";
            var client = new AmazonDynamoDBClient(accessKey, secretKey, Amazon.RegionEndpoint.EUWest2);
            var table = Table.LoadTable(client, "Calculation");
            Document document = new Document();
            document["CalculationId"] = Guid.NewGuid().ToString();
            document["CalculationDate"] = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");   // "2017-07-26T17:54:00";
            table.PutItem(document);
        }
    }
}
