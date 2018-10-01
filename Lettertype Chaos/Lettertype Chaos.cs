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

        Random Random = new Random();
        List<Font> Fonts = new List<Font>();

        private void Convert_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Input.Text.Length; i++)
            {
                Input.Select(i, 1);
                Input.SelectionFont = Fonts[Random.Next(i, Fonts.Count)];                
            }
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
