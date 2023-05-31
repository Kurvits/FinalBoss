using System.Runtime.CompilerServices;

namespace FinalBoss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            //kutsume WhereLINQ meetodi välja
            AllAndAnyLINQ();
            GroupJoinLINQ();
            TextToFile();
            PuramiidLINQ();

            string ch = Console.ReadLine();

            switch (ch)
            {
                case "1":
                    Console.WriteLine("");
                    break;

                case "2":
                    Console.WriteLine("");
                    break;

                case "3":
                    Console.WriteLine("");
                    break;

                case "4":
                    Console.WriteLine();
                    break;
            }

            
        }

        public static void AllAndAnyLINQ()
        {
            Console.WriteLine("All LINQ");

            bool areAllPeopleTeenagers = PeopleList.peoples
                .All(x => x.Age > 18);
            //k]ik PeopleList-i all olevad isikud peavad olema alla 18 a vanused

            Console.WriteLine(areAllPeopleTeenagers);

            Console.WriteLine("Any LINQ");
            bool isAnyPersonTeenager = PeopleList.peoples
                .Any(x => x.Age > 18);
            //kasvõi üks  andmerida vastab tingimustele, siis tuelb vastus
            Console.WriteLine(isAnyPersonTeenager);
        }

        public static void GroupJoinLINQ()
        {
            Console.BackgroundColor = ConsoleColor.Black;

            var groupJoin = GenderList.genderList
                .GroupJoin(PeopleList.peoples,
                p => p.Id,
                g => g.GenderId,
                (p, peopleGroup) => new
                {
                    Humans = peopleGroup,
                    GenderFullName = p.Sex
                });

            foreach (var people in groupJoin)
            {
                Console.WriteLine(people.GenderFullName);

                foreach (var name in people.Humans)
                {
                    Console.WriteLine(name.Name);
                }
            }
        }

        private static void PuramiidLINQ()
        {
            int i, j, rows;

            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    //Console.Write("{0} ", t++);
                    Console.Write("*"); //kui paned selle, siis saad püramiidi
                }
                Console.Write("\n");

            }
        }

        public static void TextToFile()
        {
            Console.WriteLine("Kui url on vale, siis annab" +
                   "veateate. Kui on õige, siis ütleb, " +
                   "et kõik on korras");
            Console.WriteLine("Kui on ]ige, siis loob faili " +
                "koos sinu sisestatud tekstiga");
            //kasutada if ja else

            string wrongPath = "V:/Users/Õpilane/Desktop/FileToDesktop.txt";
            string wrightPath = "C:/Users/Õpilane/Desktop/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");
            }
        }
    }
}



       