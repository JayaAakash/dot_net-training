using System;
using System.Linq;

namespace linq_to_sql
{
    class Program
    {
        static DataClasses1DataContext hdc = new DataClasses1DataContext();
        static void Main(string[] args)
        {
            var client = hdc.clients.ToList();
            foreach (var item in client)
            {
                Console.WriteLine($"client name :{item.cname}, client ID: {item.cname}, client address: {item.address}");
            }
            Console.ReadLine();
        }
    }
}
