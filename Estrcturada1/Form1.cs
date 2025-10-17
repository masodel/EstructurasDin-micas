using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrcturada1
{
    public partial class FrmPilaM : Form
    {
        int cont = 0;
        int num1 = 0;
        int num2 = 0;

        Stack<int> pila = new Stack<int>();
        public FrmPilaM()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(tbAgregar.Text);
            pila.Push(edad);
            cont++;
            Mostrar();
        }

        private void Mostrar()
        {
            string msn = "";

            foreach (int edad in pila)
            {
                msn += " " + edad + " |";
            }

            lblEdades.Text = msn;

            tbAgregar.Clear();
            tbAgregar.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                pila.Pop();
                Mostrar();
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
                MessageBox.Show("Elemento en la cima: " + pila.Peek());

            else
                MessageBox.Show("La pila está vacía.");
        }

        private void ordenar()
        {
            Stack<int> pilaAux = new Stack<int>();

            while (pila.Count > 0)
            {
                int temp = pila.Pop();

                while (pilaAux.Count > 0 && pilaAux.Peek() > temp)
                {
                    pila.Push(pilaAux.Pop());
                }

                pilaAux.Push(temp);
            }
            pila = pilaAux;

            string msn = "";

            foreach (int edad in pila)
            {
                msn += " " + edad + " |";
            }

            lblEdades2.Text = msn;

            tbAgregar.Clear();
            tbAgregar.Focus();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ordenar();
        }
    }
}
