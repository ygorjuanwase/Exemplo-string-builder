using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploStringBuilder
{
    public partial class Exemplo02 : Form
    {
        public Exemplo02()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1\t\t\tQboa\t\t\tR$ 20,00");
            sb.AppendLine("1\t\t\tAmaciante\t\tR$ 15,69");
            sb.AppendLine("1\t\t\tSopa\t\t\tR$ 5,60");
            sb.AppendLine("1\t\t\tBolo de Cenoura\t\tR$ 9,45");
            txtResultado.Text = sb.ToString();

            string texto = @"
1          Qboa               R$ 20,00
2          Amaciante          R$ 15,69
3          Sopa               R$ 5,60
4          Bolo de Cenoura    R$ 9,45";
            txtResultado.Text = texto;
        }
    }
}
