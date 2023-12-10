using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Una función para saber el número menor.
        int calculaMenor(int num1, int num2)
        {
            int res = num2;
            if (num1 <= num2)
            {
                res = num1;
            }
            return res;
        }
        //Una función que calcule el MCD.
        int calculaMCD(int num1, int num2)
        {
            int mcd = 1;

            int menor = calculaMenor(num1, num2);

            int mayor = num1;
            if (menor == num1)
            {
                mayor = num2;
            }
            for (int i = 1; i <= menor; i++)
            {
                if (menor % i == 0 && mayor % i == 0)
                {
                    mcd = i;
                }
            }
            return mcd;
        }
        private void mcdBtn_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int resultado;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);

            resultado = calculaMCD(num1, num2);

            MessageBox.Show("El MCD de " + num1 + " y " + num2 + " es " + resultado);
        }
    }
}
