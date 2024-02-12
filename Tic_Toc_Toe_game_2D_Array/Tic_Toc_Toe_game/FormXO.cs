using System.Reflection;

namespace Tic_Toc_Toe_game
{
    public partial class FormXO : Form
    {
        //private System.Windows.Forms.Button[,] _buttonArray;

        private Button[,] buttonArray = new Button[3, 3];

        bool turn = true; //true = X's turn, false = 0's turn
        int turnCount = 0; //this counts the number of passed turns
        bool winner = false;
        public FormXO()
        {
            InitializeComponent();
            buttonArray = new Button[3, 3];
            buttonArray = new Button[,] { { a1,a2,a3},
                                        {b1,b2,b3 },
                                        {c1,c2,c3 } };
        }
        public void button_function(object Osender, EventArgs Eevent)
        {
            try
            {
                Button b = (Button)Osender; //here we take the properties of the button clicked
                if (turn == true) // if turn is true, this means it is X's turn , so we write  "X"in the button.
                    b.Text = "X";
                else b.Text = "O"; //otherwise , we write "O"
                turn = !turn; //this switches turns from X to O and Vice versa
                turnCount++;
                b.Enabled = false; // the button becomes disabeled so that we can't change it anymore
                Check(); //verifying if there is any winner
            }
            catch { }
        }

        public void Check()
        {
            foreach (Button b in buttonArray)
            {
                //Horizontal
                if (buttonArray[0, 0].Text != "" && (buttonArray[0, 0].Text == buttonArray[0, 1].Text) && (buttonArray[0, 1].Text == buttonArray[0, 2].Text)) //a1,a2,a3
                    winner = true;
                else if (buttonArray[1, 0].Text != "" && (buttonArray[1, 0].Text == buttonArray[1, 1].Text) && (buttonArray[1, 1].Text == buttonArray[1, 2].Text)) //b1,b2,b3
                    winner = true;
               // else if (buttonArray[2, 0].Text != "" && (buttonArray[2, 0].Text == buttonArray[2, 1].Text) && (buttonArray[2, 1].Text == buttonArray[2, 2].Text)) //c1,c2,c3
                 //   winner = true;
                //Vertical
                if (buttonArray[1, 0].Text != "" && (buttonArray[0, 0].Text == buttonArray[1, 0].Text) && (buttonArray[1, 0].Text == buttonArray[2, 0].Text)) //a1,b1,c1
                    winner = true;
                else if (buttonArray[1, 1].Text != "" && (buttonArray[0, 1].Text == buttonArray[1, 1].Text) && (buttonArray[1, 1].Text == buttonArray[2, 1].Text)) //a2,b2,c2
                    winner = true;
                else if (buttonArray[1, 2].Text != "" && (buttonArray[0, 2].Text == buttonArray[1, 2].Text) && (buttonArray[1, 2].Text == buttonArray[2, 2].Text)) //a3,b3,c3
                    winner = true;
                //Diagonal
                if (buttonArray[0, 0].Text != "" && (buttonArray[0, 0].Text == buttonArray[1, 1].Text) && (buttonArray[1, 1].Text == buttonArray[2, 2].Text)) //a1,b2,c3
                    winner = true;
                else if (buttonArray[0, 2].Text != "" && (buttonArray[0, 2].Text == buttonArray[1, 1].Text) && (buttonArray[1, 1].Text == buttonArray[2, 0].Text)) //a3,b2,c1
                    winner = true;
            }
            IsWinning();
        }
        public void IsWinning()
        {
            if (winner)
            {
                string w = "";
                if (turn)
                    w = "O";
                else w = "X";
                MessageBox.Show("The winner is " + w + "! Click OK to retart the game.");
                restart();
            }
            else if (turnCount == 9)
            {
                MessageBox.Show("It's a draw! Click OK to restart the game.");
                restart();
            }
        }
        public void restart()
        {
            winner = false;
            turnCount = 0;
            turn = true;

            foreach (Control b in Controls.OfType<Button>())
            {
                b.Text = "";
                b.Enabled = true;


            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            button_function(sender, e);
        }
        private void a2_Click(object sender, EventArgs e)
        {
            button_function(sender, e);
        }

        private void a3_Click(object sender, EventArgs e)
        {
            button_function(sender, e);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            button_function(sender, e);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            button_function(sender, e);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            button_function(sender, e);
        }

        private void c1_Click(object sender, EventArgs e)
        {
            button_function(sender, e);
        }

        private void c2_Click(object sender, EventArgs e)
        {
            button_function(sender, e);
        }

        private void c3_Click(object sender, EventArgs e)
        {
            button_function(sender, e);
        }

        private void FormXO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}