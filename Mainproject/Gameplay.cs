namespace Mainproject
{
    public class Gameplay
    {
        //Check if the answer provided by the user is correct
        public static bool AnswerCheck(string input, Champion input2)
        {
            if (input == input2.Name)
            {
                clueCount = 0;
                return true;
            }
            else
            {
                return false; 
            }
        }
        //variable to keep track of the clues given
        public static int clueCount = 0;

        //Give clues based on clueCount
        public static void GiveClue(Champion input)
        {
            switch (clueCount)
            {
                case 0:
                    MessageBox.Show($"This champion is {input.Gender}.");
                    break;
                case 1:
                    MessageBox.Show($"This champion is played {input.Position}.");
                    break;
                case 2:
                    MessageBox.Show($"This champion is {input.Species}.");
                    break;
                case 3:
                    MessageBox.Show($"This champion uses {input.Resource}.");
                    break;
                case 4:
                    MessageBox.Show($"This champion is {input.RangeType}.");
                    break;
                case 5:
                    MessageBox.Show($"This champion is from {input.Region}.");
                    break;
                default:
                    MessageBox.Show("You allready recieved all the clues, if you want to see all the previous hints press Show Hints button,  good luck!");
                    break;
            }
            clueCount++;
        }
        //all hints button giving previus clues
        public static void GivePreviousClues(Champion input)
        {
            switch (clueCount)
            {
                case 0:
                    MessageBox.Show($"You haven't used any hints yet");
                    break;
                case 1:
                    MessageBox.Show($"This champion is {input.Gender}");
                    break;
                case 2:
                    MessageBox.Show($"This champion is {input.Gender} and is played {input.Position}.");
                    break;
                case 3:
                    MessageBox.Show($"This champion is {input.Gender} and is played {input.Position}. \nThey are {input.Species}.");
                    break;
                case 4:
                    MessageBox.Show($"This champion is {input.Gender} and is played {input.Position}. \nThey are {input.Species} and they use {input.Resource}.");
                    break;
                case 5:
                    MessageBox.Show($"This champion is {input.Gender} and is played {input.Position}. \nThey are {input.Species} and they use {input.Resource}. \nThey are {input.RangeType}");
                    break;
               
                default:
                    MessageBox.Show($"This champion is {input.Gender} and is played {input.Position}. \nThey are {input.Species} and they use {input.Resource}. \nThey are {input.RangeType} and they are from {input.Region}");
                    break;
            }
        }
    }
}
