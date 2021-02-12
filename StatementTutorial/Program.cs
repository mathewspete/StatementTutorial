using System;

namespace StatementTutorial {
    class Program {
        static void Main(string[] args) {

            {
                //    // Console.WriteLine("Hello World!");

                //    // Console.WriteLine("Enter a integer");
                //    // var aNbr = Console.ReadLine();
                //    ////  if (decimal.TryParse(, )
                //    // var nbr = Convert.ToInt32(aNbr);
                //    // if (nbr%2 == 0 ) {
                //    //     Console.WriteLine($"The number {nbr} is even.");
                //    // } else {
                //    //     Console.WriteLine($"The number {nbr} is odd.");
                //    // }




                //    //var ints = new[] { 77, 32, 94, 46, 28 };


                //    //for (var idx = 0; idx<ints.Length; idx++) {
                //    //    Console.WriteLine($"idx is {idx} and ints[idx] is {ints[idx]}.");
                //    //}


                //    var ints1 = new[] { 20, 49, 94, 91, 64, 92, 26, 37, 45, 49 };
                //    var ints2 = new[] { 611, 589, 466, 792, 876, 752, 270, 166, 357 };
                //    var ints3 = new[] { 2155, 5622, 2974, 2563, 8201, 6627, 3380, 2551 };

                //    //Console.WriteLine($"ints1 includes {ints1.Length} values.");
                //    //Console.WriteLine();

                //    //var SumE = 0;
                //    //var total1 = 0;
                //    //for(var idx = 0; idx<ints1.Length; idx++) {
                //    //    Console.WriteLine($"inst1[{idx}] value is {ints1[idx]}." );
                //    //    total1 += ints1[idx];
                //    //    if (ints1[idx] % 2 == 0) {
                //    //        SumE += ints1[idx];
                //    //    }

                //    //}
                //    //Console.WriteLine($"The sum of ints1 is {total1}.");
                //    //Console.WriteLine($"The sum of the even numbers is {SumE}");
                //    //Console.WriteLine();


                //    //Console.WriteLine($"ints2 includes {ints2.Length} values.");

                //    //SumE = 0;
                //    //var total2 = 0;
                //    //for (var idx = 0; idx < ints2.Length; idx++) {
                //    //    Console.WriteLine($"inst2[{idx}] value is {ints2[idx]}.");
                //    //    total2 += ints2[idx];
                //    //    if (ints2[idx]%2!=0) {
                //    //        SumE += ints2[idx];}

                //    //}
                //    //Console.WriteLine($"The sum of ints2 is {total2}.");
                //    //Console.WriteLine($"The sum of the odd numbers is {SumE}");
                //    //Console.WriteLine();


                //    //Console.WriteLine($"ints3 includes {ints3.Length} values.");

                //    //SumE = 0;
                //    //var total3 = 0;
                //    //for (var idx = 0; idx < ints3.Length; idx++) {
                //    //    Console.WriteLine($"inst3[{idx}] value is {ints3[idx]}.");
                //    //    total3 += ints3[idx];
                //    //    if (ints3[idx]%2==0) {
                //    //        SumE += ints3[idx];}

                //    //}
                //    //Console.WriteLine($"The sum of ints3 is {total3}.");
                //    //Console.WriteLine($"The sum of the even numbers is {SumE}");
                //    //Console.WriteLine();


                //    ////////////////////////////////////
                //    /// FOREACH                     ///
                //    /// //////////////////////////////
                //    /// 


                //    var sum = 0;
                //    foreach (var i in ints1) {
                //        sum += i;
                //    }
                //    Console.WriteLine($"Sum = {sum}");

                //    sum = 0;
                //    foreach (var anInt in ints2) {
                //        if (anInt % 3 == 0) {
                //            sum += anInt;
                //        }
                //    }
                //    Console.WriteLine($"Sum = {sum}");


                //    var thriller = new Song {
                //        Title = "Thriller",
                //        Artist = "Michael Jackson",
                //        Genre = "Disco",
                //        Released = new DateTime(1984, 1, 23),
                //        Platinum = true
                //    };

                //    var thunderstruck = new Song {
                //        Title = "Thunderstruck",
                //        Artist = "AC/DC",
                //        Genre = "Rock",
                //        Released = new DateTime(1990, 9, 10),
                //        Platinum = true
                //    };

                //    var wastedOnTheWay = new Song {
                //        Title = "Wasted on the Way",
                //        Artist = "Crosby, Stills, & Nash",
                //        Genre = "Folk",
                //        Released = new DateTime(1982, 12, 31),
                //        Platinum = false
                //    };

                //    var songs = new Song[] { thriller, thunderstruck, wastedOnTheWay };

                //    foreach (var song in songs) {
                //        Console.WriteLine($"{song.Title}");
                //    }

                //    foreach (var plat in songs) {
                //        if (plat.Platinum == true) {
                //            Console.WriteLine($"{plat.Title}");
                //        }
                //    }

            }



            /////////////////////////
            ///   WhiLe           ///
            /////////////////////////

            {
                //var counter = 1;
                //while(counter <= 25) {
                //    if(counter%2!=0) {
                //        var cubed = counter * counter * counter;
                //        Console.WriteLine($"{counter} cubed is {cubed}.");
                //    }
                //    counter++;
                //}

            }

            /////////////////////////
            ///   Switch          ///
            /////////////////////////


            { 
                {
                    // Old Method, but more versatility
                    /*
                    var stateCode = "OH";
                    var stateName = "";

                    switch (stateCode) {
                        default: stateName = "Not Found"; 
                            break;
                        case "OH":  stateName = "Ohio"; 
                            break;
                        case "IN": stateName = "Indiana"; 
                            break;
                        case "KY": stateName = "Kentucky"; 
                            break;
                    
                    }

                    Console.WriteLine($"StateCode {stateCode} matches with {stateName}.");
                    */
                }

                {
                    // Newer Method, but limited.

                    //var stateCode = "OH";
                    //var stateName = stateCode switch {
                    //    "OH" => "Ohio",
                    //    "IN" => "Indiana",
                    //    "KY" => "Kentucky",
                    //    _ => "Not Found"
                    //};

                }

            }

            /////////////////////////
            ///   Ternary         ///
            /////////////////////////


            {

                var TrafficLight = "red";
                var command = (TrafficLight == "red") ? "stop" : "go";
                Console.WriteLine($"{TrafficLight} means {command}");

            }

            for(var i=1; i<31; i++) {
                var x = "";
                   x = (i % 15 == 0) ? "FIZZBUZZ" : x = (i % 5 == 0) ? "Buzz" : x = (i % 3 == 0) ? "Fizz" : i.ToString();
                Console.WriteLine(x);
            }




        }

        
    }
}
