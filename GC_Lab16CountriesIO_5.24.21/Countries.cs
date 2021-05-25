using System.Collections.Generic;


namespace GC_Lab16CountriesIO_5._24._21
{
    class Countries
    {
        //has four properties & ability to delete a country (extra)

        public string Name { get; set; }
        public string Bird { get; set; }
        public string Capitals { get; set; }
        public string Export { get; set; }

        public Countries() { }

        public Countries(string name, string bird, string capitals, string export)
        {
            Name = name;
            Bird = bird;
            Capitals = capitals;
            Export = export;
        }


        public static List<Countries> GetCountries()
        {
            List<Countries> countries = new List<Countries>()
            {
                new Countries("Belize", "Keel-billed Toucan", "Belmopan", "Sugar"),
                new Countries("Finland", "Whooper Swan", "Mariehamn", "Paper"),
                new Countries("Taiwan", "Taiwan Blue Magpie", "Taipei", "Electronics"),
                new Countries("Morocco", "Moussier’s Redstarts", "Rabat", "Petroleum")
            };

            return countries;

        }

        public override string ToString()
        {
            string returnStatement = $"Country: {Name}\nNational Bird: {Bird}\nCapital: {Capitals}\nBiggest Export: {Export}\n";
            return returnStatement;
        }

    }
}
