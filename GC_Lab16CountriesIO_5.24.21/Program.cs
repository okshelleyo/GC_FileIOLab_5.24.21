using System;
using System.Collections.Generic;
using System.IO;

namespace GC_Lab16CountriesIO_5._24._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Countries Maintenance Application!");

            List<Countries> countriesList = Countries.GetCountries();
            CountriesTextFile accessTextFile = new CountriesTextFile(countriesList);
            CountriesApp menu = new CountriesApp(accessTextFile);


            bool keepPlaying = true;

            while (keepPlaying)
            {
                menu.CountriesMenu();

            }



        }


    }
}
