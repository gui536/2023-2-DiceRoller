namespace DiceRoller;

public partial class MainPage : ContentPage
{
    int numSides = 6;

    public MainPage()
    {
        InitializeComponent();
        sidesPicker.SelectedIndex = 0;
    }

    public class Dice
    {
        public Dice() { }
        public Dice(int numSides)
        {
            this.numSides = numSides;
        }
        private int numSides;

        public int RollDice()
        {
            int random = new Random().Next(1, numSides + 1);
            return random;
        }
    }

    public void OnRollClicked(object sender, EventArgs e)
    {
        numSides = Convert.ToInt32(sidesPicker.SelectedItem.ToString());
        Dice dice = new Dice(numSides);
        labelNumber.Text = dice.RollDice().ToString();
    }
}

