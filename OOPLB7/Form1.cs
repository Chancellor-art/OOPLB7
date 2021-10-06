using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OOPLB7
{
    public partial class Lebediuk : Form
    {
        public Lebediuk()
        {
            InitializeComponent();
        }

        static bool InputDouble(ref double a, string b)
        {
            string s;
            s = a.ToString();
            Povtor:
            s = Interaction.InputBox(b, "Введення", s);
            try
            {
                a = Convert.ToDouble(s);
            }
            catch (System.FormatException)
            {
                if(MessageBox.Show("Ви ввели не число.\nБажаєте повторити?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            goto Povtor;
                else
                    return false;
            }
            return true;
        }

        static bool InputInt(ref int a, string b)
        {
            string s;
            s = a.ToString();
        Povtor:
            s = Interaction.InputBox(b, "Введення", s);
            try
            {
                a = Convert.ToInt32(s);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("Ви ввели не число.\nБажаєте повторити?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto Povtor;
                else
                    return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = 3.7156;
            double y = 3.034;
            double z = 0.756;
            if (!InputDouble(ref x, "Введіть значення x")) return;
            if (!InputDouble(ref y, "Введіть значення y")) return;
            if (!InputDouble(ref z, "Введіть значення z")) return;
            double rez = (x - y) / ((x - y) + z);
            MessageBox.Show($"x = {x}\ny = {y}\nz = {z}\nrezultat = {rez}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x1 = 5;
            double y1 = 0;
            if (!InputDouble(ref x1, "Введіть значення x")) return;
            if (Math.Abs(x1) >= 5) y1 = Math.Pow(1.3, 2 + x1) * Math.Pow(x1, 2);
            else if (-1 <= x1 && x1 <= 1) y1 = Math.Log10(x1 - 1);
            else if(1 < Math.Abs(x1) && Math.Abs(x1) < 5) y1 = Math.Cos(Math.Abs(x1 - 1));
            MessageBox.Show($"x = {x1}\ny = {y1}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y;
            double dx = 1;
            double xp = 1;
            int n = 5;
            string rez = "";
            if (!InputDouble(ref dx, "Введіть початок проміжку")) return;
            if (!InputDouble(ref xp, "Введіть крок")) return;
            if (!InputInt(ref n, "Введіть кількість точок")) return;
            rez = "функція:\n x\t y";
            for (int i = 0; i < n; i++)
            {
                x = xp + i * dx;
                y = (Math.Pow(x, 3) - 3) / 3 * Math.Log10(x);
                rez += $"\n{x} \t{y}";
            }
            MessageBox.Show(rez, "Rezult", MessageBoxButtons.OK);
        }
    }
}
