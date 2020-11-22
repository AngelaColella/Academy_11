using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Lambda
{
    public delegate bool FilterInt(int i);
    // dichiaro un delegate che punta ad un metodo che filtra degli interi 
    public delegate bool MyDelegate(int i, int j);
    public delegate bool NewDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // costruisco una lista di interi 
            FilterInt filterOdd = new FilterInt(IsOdd);
            // costruisco un delegate con dentro l'indirizzo di IsOdd
            List<int> result = FilterInts(lst, filterOdd);
            List<int> result2 = FilterInts(lst, IsEven);
            // questa seconda riga va bene comunque perchè il compilatore capisce che deve passare il delegate e non il metodo
            List<int> result3 = FilterInts(lst, i => (i % 2) == 1);
            // lambda expression 

            MyDelegate lambda = (i, j) =>
            {
                if (i > j)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            NewDelegate newLambda = () => { return true; };

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsOdd(int x)
        {
            return (x % 2) == 1; // ritorna true se il numero è dispari
        }

        public static bool IsEven(int x)
        {
            return (x % 2) == 0; // ritorna true se il numero è pari
        }

        public static List<int> FilterInts(List<int> inputList, FilterInt filter)
        // prende la lista di interi, li scorre e a ciascuno applica un filtro per decidere se farà parte della nuova lista o no
        // restituisce la nuova lista. 
        {
            List<int> resultList = new List<int>();
            foreach (var item in inputList) // scorro gli elementi della lista in input
            {
                if (filter(item)) // sto invocando il metodo isOdd passandogli ogni volta l'item della lista, cioè un numero int
                {
                    resultList.Add(item);
                }
            }
            return resultList;
        }
    }
}
