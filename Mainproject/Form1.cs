using System.Diagnostics.Eventing.Reader;

namespace Mainproject
{
    public partial class Form1 : Form
    {
        private Champion currentChampion;

        public Form1()
        {
            InitializeComponent();
        }

        //Start the game button
        private void startGameButton_Click(object sender, EventArgs e)
        {
            IntroLabel.Hide();
            StartGameButton.Hide();
            GuessBox.Show();
            guessBoxInstruction.Show();
            SubmitButton.Show();
            HintButton.Show();
            AllHintsbutton.Show();
            ReturnToStart.Show();
            currentChampion = ChampionMake.GetRandomItem(ChampionMake.championsList);
        }

        //Application lunch 
        private void Form1_Load(object sender, EventArgs e)
        {
            GuessBox.Hide();
            guessBoxInstruction.Hide();
            SubmitButton.Hide();
            ChampionListDataGrid.Hide();
            HintButton.Hide();
            AllHintsbutton.Hide();
            ReturnToStart.Hide();
            ChampionMake.ChampionMaker();
            ChampionListDataGrid.DataSource = ChampionMake.championsList;
        }

        //submitbutton during the gameplay
        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (Gameplay.AnswerCheck(GuessBox.Text.ToUpper(), currentChampion))
            {
                MessageBox.Show($"Congratulations the champion was {currentChampion.Name},  You Won!");
                IntroLabel.Show();
                StartGameButton.Show();
                guessBoxInstruction.Hide();
                SubmitButton.Hide();
                GuessBox.Hide();
                HintButton.Hide();
                AllHintsbutton.Hide();
                ReturnToStart.Hide();
            }

            else
            {
                MessageBox.Show("You are incorrect!");
            }
            GuessBox.Clear();
        }
        //show datagrid containing all possible champions
        private void ChampionListButton_Click(object sender, EventArgs e)
        {
            ChampionListDataGrid.Visible = !ChampionListDataGrid.Visible;
        }
        //button that gives hints
        private void HintButton_Click(object sender, EventArgs e)
        {
            Gameplay.GiveClue(currentChampion);
        }
        //button that shows previous hints
        private void AllHintsbutton_Click(object sender, EventArgs e)
        {
            Gameplay.GivePreviousClues(currentChampion);
        }

        private void ReturnToStart_Click(object sender, EventArgs e)
        {
            IntroLabel.Show();
            StartGameButton.Show();
            guessBoxInstruction.Hide();
            SubmitButton.Hide();
            GuessBox.Hide();
            HintButton.Hide();
            AllHintsbutton.Hide();
            ReturnToStart.Hide();

        }
    }
}