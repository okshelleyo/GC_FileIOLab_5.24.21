using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GC_Lab16CountriesIO_5._24._21
{
    class CountriesTextFile
    {
        //one method that allows you to read a list of countries
        //another method that allows you to write a list of countries to a file
        //allow you to store the countries text file 

        public List<Countries> CountriesList;

        public CountriesTextFile (List<Countries> countriesList)
        {
            CountriesList = countriesList;
            CreateCountriesList(CountriesList);
                              
        }

        public void CreateCountriesList(List<Countries> countries)
        {
            StreamWriter writer = new StreamWriter("../../../countries.txt");
            foreach (Countries country in countries)
            {
                writer.WriteLine($"{country.Name}|{country.Bird}|{country.Capitals}|{country.Export}|");
            }
            writer.Close();
        }

        public void PrintCountriesList() //option 1 
        {
            List<Countries> countries = new List<Countries>();
            StreamReader reader = new StreamReader("../../../countries.txt");
            
            string line = reader.ReadLine();

            while (line != null)
            {
               string [] propertiesSplit = line.Split('|');

                countries.Add(new Countries(propertiesSplit[0], propertiesSplit[1], propertiesSplit[2], propertiesSplit[3]));
                line = reader.ReadLine();
            }
            reader.Close();

            foreach (Countries country in countries)
            {
                Console.WriteLine(country);
            }

        }


        public void AddToCountriesList() // option 2
        {
            
            string[] country = new string[4];
            
            Console.WriteLine("Let's add a country to the list");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Bird: ");
            string bird = Console.ReadLine();
            Console.Write("Capital: ");
            string capital = Console.ReadLine();
            Console.Write("Export: ");
            string export = Console.ReadLine();
            Console.WriteLine();

            Countries newCountry = new Countries(name, bird, capital, export);
            CountriesList.Add(newCountry);


            using (StreamWriter writer = File.AppendText("../../../countries.txt"))
            {
                writer.WriteLine($"{name}|{bird}|{capital}|{export}|");
            }

            Console.WriteLine("Country has been added!");
            Console.WriteLine();
        }


    }

    


}
