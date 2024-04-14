using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaGame
{
    public partial class ucPopUp : UserControl
    {
        public event EventHandler FinishedChoice;
        public int Choosed { get; set; }
        public string PlayerName { get; set; } = "";
        public int[] Options { get; set; }
        public int PizzeRemaining { get; set; }
        private RadioButton[] rbs { get; set; }
        private const string messaggioDefaultTurno = "È IL TURNO DEL GIOCATORE";
        private const string question = " ,QUANTE NE VUOI MANGIARE?";

        public ucPopUp()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                InitializeComponent();
                rbs = [rb1, rb2, rb3];
                Options = [];
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            Choosed = Convert.ToInt32(rbs.Where(a => a.Checked).FirstOrDefault()?.Text);
            FinishedChoice?.Invoke(this, EventArgs.Empty);
        }

        private void ucPopUp_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                lblTurno.Text = $"{messaggioDefaultTurno} {PlayerName}";
                lblQuestion.Text = $"RIMANGONO {PizzeRemaining} PIZZE{question}";

                foreach (var item in Options)
                {
                    rbs[item - 1].Enabled = true;
                }

                var initSelected = rbs.Where(a => a.Enabled).FirstOrDefault();
                if (initSelected != null) { initSelected.Checked = true; }
            }
            else
            {
                if (rbs != null)
                {
                    rbs.ToList().ForEach(a => { a.Enabled = false; });
                }
            }
        }
    }
}
