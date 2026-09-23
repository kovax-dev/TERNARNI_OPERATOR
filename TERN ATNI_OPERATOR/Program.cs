//Pretvorite sljedeće if-else izraze u ternarni operator:
//if (age > 18) { beverage = "Beer"; }
//else { beverage = "Juice"; }

//if (year < 2100) { result += 153.3; }
//else { result -= year; }

//Odgovorite na pitanje kojeg tipa su varijable age, beverage, year i result.

//DZ možete riješiti na papiru (pa poslikati), tekstualno (word, notepad) ili kao programsko rješenje. Rok je do srijede u ponoć!

namespace TERN_ATNI_OPERATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            string beverage = age > 18 ? "Beer" : "Juice";
            int year = 2025;
            double result = 0;
            result = year < 2100 ? result + 153.3 : result - year;
        }
    }
}
