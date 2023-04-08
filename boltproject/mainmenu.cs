using System;
using System.Collections.Generic;
using System.IO;
class Program

{
    class Person
    {
        public string Surname
        { get; set; }

        public string Name
        { get; set; }

        public string ID
        { get; set; }

        public int BirthYear
        { get; set; }
    }





    class Item
    {
        public string ItemName
        { get; set; }

        public int ItemID
        { get; set; }

        public int ItemP
        { get; set; }

    }





    static void Main()
    {

        List<Person> persons = new List<Person>();
        List<Person> ascpersons = new List<Person>();
        List<Item> items = new List<Item>();
        List<Item> ascitems = new List<Item>();

        bool exit = false;
        while (!exit)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bolt áttekíntése");
            Console.WriteLine();
            Console.WriteLine("1.Dolgozok hozzáadása");
            Console.WriteLine();
            Console.WriteLine("2.Dolgozok listája");
            Console.WriteLine();
            Console.WriteLine("3.Raktár felöltése");
            Console.WriteLine();
            Console.WriteLine("4.Raktár listája");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'exit' a kilépéshez");
            Console.Write("Írd be a megfelelő sorszámot vagy az 'exit' szót: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Felakarsz venni új dolgozot? y/n?");
                    string valasz = Console.ReadLine();
                    if (valasz == "y")
                    {
                        do
                        {
                            Console.Write("Adja meg a dolgozó vezetéknevét!: ");
                            string surname = Console.ReadLine();


                            Console.Write("Adja meg a dolgozó keresztnevét!:");
                            string name = Console.ReadLine();


                            Console.Write("Adja meg a dolgozó azonosítószámát!:");
                            string id = Console.ReadLine();

                            Console.Write("Adja meg a dolgozó születési évét!");
                            int birthYear;
                            int.TryParse(Console.ReadLine(), out birthYear);
                            Console.WriteLine("Felakarsz venni új dolgozot? y/n?");
                            valasz = Console.ReadLine();
                            Person person = new Person
                            {
                                Name = name,
                                Surname = surname,
                                ID = id,
                                BirthYear = birthYear
                            };
                            persons.Add(person);
                            ascpersons.Add(person);





                        }
                        while (valasz != "n");
                        break;
                    }
                    break;


                case "2":
                    Console.Clear();
                    Console.WriteLine("Dolgozok listája");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    foreach (Person person in persons)
                    {
                        Console.WriteLine($"Vezetéknév: {person.Surname}, Keresztnév: {person.Name}, Azonosítószám:{person.ID}, Születési év: {person.BirthYear}");
                    }




                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Nyomd meg az 1-est a kilépéshez.");
                    Console.WriteLine();
                    Console.WriteLine("Nyomd meg a 2-est születési dátum alapján való nővekvő sorrendbe helyezéshez.");
                    Console.WriteLine();
                    Console.WriteLine("Nyomd meg a 3-ast hogy kimentsd egy .txt-be a dolgozok információját.");
                    string option = Console.ReadLine();
                    int option0 = Convert.ToInt32(option);
                    if (option0 == 1)
                    { break; }
                    if (option0 == 2)
                    {
                        Console.Clear();
                        ascpersons.Sort((p1, p2) => p1.BirthYear.CompareTo(p2.BirthYear));

                        string result1 = "Születési év alapján való nővekvő sorrend:";
                        Console.WriteLine(result1);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();



                        foreach (var person in ascpersons)
                        {
                            Console.WriteLine($"Vezetéknév: {person.Surname}, Keresztnév: {person.Name}, Azonosítószám: {person.ID}, Születési év: {person.BirthYear}");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Nyomj 'Enter' - t a folytatáshoz...");
                        Console.ReadKey();

                    }
                    if (option0 == 3)
                    {
                        Console.Clear();
                        string printed = null;
                        foreach (var person in persons)
                        {
                            printed += $"Vezetéknév: {person.Surname}, Keresztnév: {person.Name}, Azonosítószám: {person.ID},  Születési év: {person.BirthYear}\n";
                        }


                        string directory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
                        string filePath = Path.Combine(directory, "dolgozok.txt");
                        File.WriteAllText(filePath, printed);
                        Console.WriteLine("Nyomj 'Enter' - t a folytatáshoz...");
                        Console.ReadKey();
                    }


                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Raktár felöltése");
                    Console.WriteLine();
                    Console.WriteLine("Szeretnél új terméket hozzáadni a raktárhoz? y/n?");
                    string valasz2 = Console.ReadLine();
                    if (valasz2 == "y")
                    {
                        do
                        {
                            Console.Write("Adja meg a termék nevét!: ");
                            string itemName = Console.ReadLine();

                            Console.Write("Adja meg a termék azonosítóját!: ");
                            int itemID;
                            int.TryParse(Console.ReadLine(), out itemID);

                            Console.Write("Adja meg a termék árát!:");
                            int itemP;
                            int.TryParse(Console.ReadLine(), out itemP);

                            Console.WriteLine("Szeretnél új terméket hozzáadni a raktárhoz? y/n?");
                            valasz2 = Console.ReadLine();
                            Item item = new Item
                            {
                                ItemName = itemName,
                                ItemID = itemID,
                                ItemP = itemP
                            };
                            items.Add(item);
                            ascitems.Add(item);
                        } while (valasz2 != "n");
                    }
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Raktár listája");
                    Console.WriteLine();
                    foreach (Item item in items)
                    {
                        Console.WriteLine($"Árucikk neve: {item.ItemName}, Azonosító: {item.ItemID}, Darabszám: {item.ItemP}");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Nyomd meg az 1-est a kilépéshez.");
                    Console.WriteLine("Nyomd meg a 2-est az ár alapján való nővekvő sorrendbe helyezéshez.");
                    Console.WriteLine("Nyomd meg a 3-ast hogy kimentsd egy .txt-be az árucikkek információját.");
                    string option2 = Console.ReadLine();
                    int option1 = Convert.ToInt32(option2);

                    if (option1 == 1)
                    {
                        break;
                    }
                    if (option1 == 2)
                    {
                        Console.Clear();
                        ascitems.Sort((i1, i2) => i1.ItemP.CompareTo(i2.ItemP));

                        string result = "Ár alapján való nővekvő sorrend:\n";
                        foreach (var item in ascitems)
                        {
                            result += $"Árucikk neve: {item.ItemName}, Azonosító: {item.ItemID}, Darabszám: {item.ItemP}\n";
                        }

                        Console.WriteLine(result);
                        Console.WriteLine("Nyomj 'Enter' - t a folytatáshoz...");
                        Console.ReadKey();
                    }
                    if (option1 == 3)
                    {
                        string printed = null;
                        foreach (var item in items)
                        {
                            printed += $"Árucikk neve: {item.ItemName}, Azonosító: {item.ItemID}, Darabszám: {item.ItemP}\n";
                        }
                        Console.Clear();
                        string directory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
                        string filePath = Path.Combine(directory, "raktár.txt");
                        File.WriteAllText(filePath, printed);
                        Console.WriteLine("Nyomj 'Enter' - t a folytatáshoz...");
                        Console.ReadKey();
                    }
                    break;

                case "exit":
                    exit = true;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Érvénytelen választás! Nyomj 'Enter'-t a folytatáshoz...");
                    Console.ReadLine();
                    break;
            }
        }
    }

}
