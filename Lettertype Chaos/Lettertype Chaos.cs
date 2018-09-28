using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lettertype_Chaos
{
    public partial class LettertypeChaos : Form
    {
        public LettertypeChaos()
        {
            InitializeComponent();

            foreach (FontFamily f in System.Drawing.FontFamily.Families)
            {
                Fonts.Add(new Font(f.Name, 13));
            }
        }

        string InputString;
        Random Random = new Random();
        List<Font> Fonts = new List<Font>();

        private void Convert_Click(object sender, EventArgs e)
        {
            InputString = Input.Text;

            foreach (var Character in InputString)
            {
                Font = Fonts[Random.Next(0, Fonts.Count)];
            }

            Output.Text = InputString;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            Input.Text = "Schrijf hier de tekst die je wilt transformeren!";

            if (e.KeyCode == Keys.Enter)
            {
                Input.Text = String.Empty;
            }
        }
    }
}
