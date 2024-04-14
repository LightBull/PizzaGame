using System.ComponentModel.DataAnnotations;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace PizzaGame
{
    public partial class FrmMain : Form
    {
        private enum Player
        {
            A = 0,
            B = 1
        }

        private int numPizzeOrig { get; set; }
        private Player? lastPlayer { get; set; }
        private Player? currentPlayer { get; set; }
        private int pizzeRemaining { get; set; }
        private bool firstRun { get; set; }
        private int[] options { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            ucPopUp.FinishedChoice += UcPopUp_FinishedChoice; ;  
        }

        private void UcPopUp_FinishedChoice(object? sender, EventArgs e)
        {
            ucPopUp.Visible = false;
            if (firstRun) { firstRun = false; }

            pizzeRemaining -= ucPopUp.Choosed;

            txtBox.Text += $"{Environment.NewLine}Il giocatore {ucPopUp.PlayerName} decide di mangiare {ucPopUp.Choosed} (rimangono {pizzeRemaining} pizze sul tavolo)";

            options = [1, 2, 3];

            options = options.Where(a => a != ucPopUp.Choosed).ToArray();

            lastPlayer = currentPlayer;

            Run();
        }

        private void tbnGeneraPizze_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            txtNumPizze.Text = rand.Next(10, 100).ToString();
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameA.Text) ||
                string.IsNullOrWhiteSpace(txtNameB.Text))
            {
                MessageBox.Show("Inserire i nomi dei giocatori!", "ATTENZIONE", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumPizze.Text))
            {
                MessageBox.Show("Generare il numero casuale di pizze!", "ATTENZIONE", MessageBoxButtons.OK);
                return;
            }

            SetGame(true);

            numPizzeOrig = Convert.ToInt32(txtNumPizze.Text);
            pizzeRemaining = numPizzeOrig;

            options = [1, 2, 3];

            firstRun = true;

            Run();
        }

        private void SetGame(bool start)
        {
            txtNameA.Enabled = !start;
            txtNameB.Enabled = !start;
            btnAvvia.Enabled = !start;
            btnGeneraPizze.Enabled = !start;
        }

        private Player NextPlayer()
        {
            if (lastPlayer == null)
            {
                return Player.A;
            }

            return lastPlayer == Player.A ? Player.B : Player.A;
        }

        private string GetPlayerName(Player p)
        {
            return p switch
            {
                Player.A => txtNameA.Text,
                Player.B => txtNameB.Text,
                _ => ""
            };
        }

        private void Run()
        {
            currentPlayer = NextPlayer();
            if (firstRun)
            {
                txtBox.Text = $"Gioco iniziato, con {pizzeRemaining} pizze da mangiare";
                SetQuestion();
            }
            else
            {
                if (pizzeRemaining == 1 && ucPopUp.Choosed == 1)
                {
                    txtBox.Text += $"{Environment.NewLine}Il giocatore {GetPlayerName(NextPlayer())} salta il turno e vince il gioco!";
                    txtBox.Text += $"{Environment.NewLine}Gioco terminato";

                    End();
                }
                else
                {
                    Contiue();

                    if (options.Count() == 1 && options[0] == pizzeRemaining)
                    {
                        txtBox.Text += $"{Environment.NewLine}Il giocatore {GetPlayerName(NextPlayer())} ha perso!";
                        txtBox.Text += $"{Environment.NewLine}Gioco terminato";

                        End();
                    }
                    else
                    {
                        SetQuestion();
                    }                    
                }
            }
        }

        private void End()
        {
            txtNameA.Text = "";
            txtNameB.Text = "";
            txtNumPizze.Text = "";
            SetGame(false);
        }

        private void SetQuestion()
        {
            ucPopUp.PlayerName = currentPlayer == Player.A ? txtNameA.Text : txtNameB.Text;
            ucPopUp.Options = options;
            ucPopUp.PizzeRemaining = pizzeRemaining;
            ucPopUp.Visible = true;
        }

        private void Contiue()
        {
            var checkedOptions = new List<int>();

            foreach (var item in options)
            {
                if (pizzeRemaining >= item)
                {
                    checkedOptions.Add(item);
                }
            }

            options = checkedOptions.ToArray();
        }
    }
}
