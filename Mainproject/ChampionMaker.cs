using Microsoft.VisualBasic.FileIO;


namespace Mainproject
{
    public partial class ChampionMake
    {
        public static List<Champion> championsList = new List<Champion>();

        //Get random champion from the list of champions

        public static Champion GetRandomItem(List<Champion> list)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, list.Count);

            return list[randomIndex];
        }
        
        //read from a csv file containing information about champions and make champions
        public static void ChampionMaker()
        {
            //csv filepath please make sure it's correct or the program will not work
            string filePath = @"D:\Champions.csv";

            
            if (File.Exists(filePath))
            {

                using (TextFieldParser parser = new TextFieldParser(filePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");


                    parser.ReadLine();

                    while (!parser.EndOfData)
                    {

                        string[] fields = parser.ReadFields();


                        if (fields.Length >= 7)
                        {
                            Champion champion = new Champion
                            {
                                Name = fields[0],
                                Gender = fields[1],
                                Position = fields[2],
                                Species = fields[3],
                                Resource = fields[4],
                                RangeType = fields[5],
                                Region = fields[6],
                            };

                            championsList.Add(champion);
                        }
                        else
                        {
                            MessageBox.Show("Invalid data in CSV file please make sure the.");
                        }
                    }
                }
            }
        }

    }   
}
