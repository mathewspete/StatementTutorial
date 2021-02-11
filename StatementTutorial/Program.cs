using System;

namespace StatementTutorial {
    class Program {
        static void Main(string[] args) {
           // Console.WriteLine("Hello World!");

           // Console.WriteLine("Enter a integer");
           // var aNbr = Console.ReadLine();
           ////  if (decimal.TryParse(, )
           // var nbr = Convert.ToInt32(aNbr);
           // if (nbr%2 == 0 ) {
           //     Console.WriteLine($"The number {nbr} is even.");
           // } else {
           //     Console.WriteLine($"The number {nbr} is odd.");
           // }




            var ints = new[] { 77, 32, 94, 46, 28 };
            for(var idx=0; idx<ints.Length; idx++) {
                Console.WriteLine($"|idx| is {idx} and |ints[idx]| is {ints[idx]}.");
            }
        }
    }
}
