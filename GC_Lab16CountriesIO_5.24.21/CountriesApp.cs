using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab16CountriesIO_5._24._21
{
    class CountriesApp
    {
        //displays a menu and responds to user choices

        public CountriesTextFile AccessTextFile { get; set; }
        

        public CountriesApp(CountriesTextFile accessTextFile)
        {
            AccessTextFile = accessTextFile;        
        }

        public void CountriesMenu()
        {                   
            MenuOptions();
            int userMenuSelection = UserMenuSelection();
            Console.WriteLine();
                                              
            switch (userMenuSelection)
            {
                case 1:
                    AccessTextFile.PrintCountriesList();
                    break;
                case 2:
                    AccessTextFile.AddToCountriesList();
                    break;
                case 3:
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
            }               
                
        }

        public void MenuOptions()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("Option 1 - See the list of countries");
            Console.WriteLine("Option 2 - Add a country");
            Console.WriteLine("Option 3 - Exit the program");
        }

        public int UserMenuSelection()
        {
            Console.Write("Enter menu number: ");

            int userSelection;

            while (!int.TryParse(Console.ReadLine(), out userSelection) || userSelection < 0 || userSelection > 3)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine();
                MenuOptions();
                Console.Write("Enter menu number: ");
                Console.WriteLine();
            }

            return userSelection;
        }       

      
    }

    

}
