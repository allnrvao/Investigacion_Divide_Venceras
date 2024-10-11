using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraExpresiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la expresión ingresada por el usuario
                string expresion = txtExpresion.Text;

                // Evaluar la expresión usando DataTable
                double resultado = EvaluarExpresion(expresion);

                // Mostrar el resultado en el Label
                lblResultado.Text = "Resultado: " + resultado.ToString();
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostrar un mensaje
                MessageBox.Show("Error en la expresión: " + ex.Message);
            }
        }
        // Método para evaluar la expresión matemática
        private double EvaluarExpresion(string expresion)
        {
            // Usamos DataTable para evaluar la expresión
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expresion);

            // Usamos Compute para realizar el cálculo
            DataRow row = table.NewRow();
            table.Rows.Add(row);

            // Convertimos el resultado en un valor numérico (double)
            double resultado = double.Parse((string)row["expression"]);

            return resultado;
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
    
}
