namespace Dice_Simulator
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int rolls = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);

            picDie1.Image = GetDieImage(die1);
            picDie2.Image = GetDieImage(die2);

            rolls++;
            lblResult.Text = die1 + " and " + die2;
            lblRolls.Text = rolls.ToString();
        }

        private Image GetDieImage(int value)
        {
            switch (value)
            {
                case 1: return Properties.Resources.Die1;
                case 2: return Properties.Resources.Die2;
                case 3: return Properties.Resources.Die3;
                case 4: return Properties.Resources.Die4;
                case 5: return Properties.Resources.Die5;
                default: return Properties.Resources.Die6;
            }
        }
    }
}