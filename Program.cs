using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int timeForABreak = int.Parse(Console.ReadLine());
        double cardPrice = double.Parse(Console.ReadLine());
        double adventurePrice = double.Parse(Console.ReadLine());
        double coffeePrice = double.Parse(Console.ReadLine());

        double moneyForCard = cardPrice * 3;
        double moneyForadventure = adventurePrice * 2;
        double totalMoney = moneyForCard + moneyForadventure + coffeePrice;
        double totalTime = timeForABreak - 5 - 6 - 4;

        Console.WriteLine("{0:f2}", totalMoney);
        Console.WriteLine(totalTime);
    }
}

