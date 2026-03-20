using Blackjack_Dealer_Training.GameLogic;

namespace Blackjack_Dealer_Training
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Card card = new(Rank.ACE, Suit.HEARTS);

            label1.Text = card.value.ToString();

            Player player = new Player();

            label2.Text = player.name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
