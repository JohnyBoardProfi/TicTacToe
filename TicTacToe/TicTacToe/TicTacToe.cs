using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        char player = 'o';
        byte move = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }        

        private void newGameToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            player = '0';
            move = 0;
            Tyle(ref b1);
            Tyle(ref b2);
            Tyle(ref b3);
            Tyle(ref b4);
            Tyle(ref b5);
            Tyle(ref b6);
            Tyle(ref b7);
            Tyle(ref b8);
            Tyle(ref b9);
            tlpField.Enabled = true;
        }

        public void Tyle(ref Button b)
        {
            b.Enabled = true;
            b.Text = "";
            b.BackColor = Color.White;
        }

        private void button_Click(object sender, System.EventArgs e)
        {
            Button b = sender as Button;
            b.Enabled = false;
            b.BackColor = Color.Aqua;
            player = player == '0' ? 'X' : '0';
            b.Text = player == '0' ? "0" : "X";
            Victory();
            move++;
        }  

        public void Victory()
        {
            if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") || (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") || (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") || (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") || (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") || (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") || (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") || (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
            {
                MessageBox.Show($"{player.ToString().ToUpper()} wins");
                tlpField.Enabled = false;
            }
            else if (move == 8)
            {
                MessageBox.Show("Draw score");
            }
        }
    }
}