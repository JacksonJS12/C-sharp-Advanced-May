using System;

namespace P08.Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine().Split();
            var fullName = $"{personInfo[0]} {personInfo[1]}";
            var address = $"{personInfo[2]}";
            var city = $"{personInfo[3]}";

            var nameAndBeer = Console.ReadLine().Split();
            var name = nameAndBeer[0];
            var numberOfLitters = int.Parse(nameAndBeer[1]);
            var isDrunken = nameAndBeer[2] == "drunk" == true;

            var nameAndBank = Console.ReadLine().Split();
            var nameFromBank = nameAndBank[0];
            var accountBalance = double.Parse(nameAndBank[1]);
            var bankName = nameAndBank[2];

            Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>(fullName, address, city);
            Threeuple<string, int, bool> secondTuple = new Threeuple<string, int, bool>(name, numberOfLitters, isDrunken);
            Threeuple<string, double, string> thirdTuple = new Threeuple<string, double, string>(nameFromBank, accountBalance, bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
