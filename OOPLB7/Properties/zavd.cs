using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OOPLB7
{
    class zavd
    {
        protected double x = 3.7156;
        protected double y = 3.034;
        protected double z = 0.756;

        public zavd()
        {
            this.x = Convert.ToDouble(Interaction.InputBox("Введіть число х:", "Введення"));
            this.y = Convert.ToDouble(Interaction.InputBox("Введіть число y:", "Введення"));
            this.z = Convert.ToDouble(Interaction.InputBox("Введіть число z:", "Введення"));
        }

        public zavd(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        protected double zavd1()
        {
            double num_1 = (x - y) / ((x * y) + z);
            return num_1;
        }
    }
}
