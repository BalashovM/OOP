using Bank;
using System;
using System.IO;
using System.Linq;

namespace HW03
{
    public class Program
    {
        static void Main(string[] args)
        {
            var utils = new Util();

            var testString = "Hello, i can revers this phrase!";
            Console.WriteLine(testString);
            Console.WriteLine($"Result: {utils.StringReverse(testString)}");

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Starting parser service");
            Console.WriteLine("Extract email from file");
            var path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..", "TextExample.txt"));
            var parser = new TextFileParser(path, '&');
            parser.CreateEmailList("ExampleResult.txt");

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Create bank account");
            BankAccount accountSource = new BankAccount(1000.0m, BankAccountType.Payment);
            Console.WriteLine(accountSource.ToString());
            Console.WriteLine();

            BankAccount accountDest = new BankAccount(0m, BankAccountType.Saving);
            Console.WriteLine(accountDest.ToString());
            Console.WriteLine();

            Console.WriteLine("Start operation transfer between accounts");
            Console.ReadKey();
            var accountTransfer = new BankAccountOperation();
            while (!accountTransfer.Transfer(accountSource, accountDest, 2000.0m))
            {
                var accountCashIn = new BankAccountOperation();
                accountCashIn.CashIn(accountSource, 100.0m);
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine(accountSource.ToString());
            Console.WriteLine();
            Console.WriteLine(accountDest.ToString());

            Console.ReadKey();
        }

    }
}
