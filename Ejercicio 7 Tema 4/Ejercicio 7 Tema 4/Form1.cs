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
            int menor = num2;
            //!? Cambiamos el operador de comparación
            if (num1 <= num2)
            {
                menor = num1;
            }
            return menor;
        }
        //Una función que calcule el MCD.
        int calculaMCD(int num1, int num2)
        {
            int mcd = 0;

            //!? Cambiamos el segundo parámetro por num2
            int menor = calculaMenor(num1, num2);

            int mayor = num1;
            if (menor == num1)
            {
                mayor = num2;
            }
            //!? Cambiamos i < menor por i <= menor,
            //!? ya que se tiene que valorar hasta el menor incluido
            for (int i = 1; i <= menor; i++)
            {
                //!? Cambiamos el || por && porque tiene que ser divisible
                //!? entre ambos (mayor y menor)
                if (menor % i == 0 && mayor % i == 0)
                {
                    mcd = i;
                }
            }
            return mcd;
        }
        private void mcdBtn_Click(object sender, EventArgs e)
        {
            int num1RMB2324;
            int num2RMB2324;
            int resultado;

            num1RMB2324 = int.Parse(txtNum1.Text);
            num2RMB2324 = int.Parse(txtNum2.Text);

            //!? Cambiamos el segundo argumento por la segunda variable
            resultado = calculaMCD(num1RMB2324, num2RMB2324);

            MessageBox.Show("El MCD de " + num1RMB2324 + " y " + num2RMB2324 + " es " + resultado);
        }
    }
}
