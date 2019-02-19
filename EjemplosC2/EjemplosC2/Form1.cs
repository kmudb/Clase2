using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DECLARACIÓN VARIABLES GLOBALES
        int edad;//numero entero sin decimal
        string nombre_completo;//cadena de caracteres
        DateTime fecha_nacimiento;//fechas dia/mes/año
        Boolean sexo_M,sexo_F; //valor verdadero y falso
        decimal salario;//numeros decimales.

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            //DECLARACIÓN VARIABLES LOCALES
            string msg;
            string sexo="";

            //ASIGNACIÓN DE VALORES DESDE FORM
            edad = int.Parse(nudedad.Value.ToString());
            nombre_completo = txtnombre.Text;
            fecha_nacimiento = dtpfecha.Value;
            if (rbfem.Checked == true)
            {
                sexo = "Femenino";
            }
            if (rbmas.Checked == true)
            {
                sexo = "Masculino";
            }
            salario = decimal.Parse(mtbsueldo.Text);

            msg = "El empleado:" + nombre_completo + " ha sido ingresado exitosamente, con los siguientes datos:\n";
            msg += "Edad:"+ edad.ToString()+"\n";
            msg += "Fecha de nacimiento:" + fecha_nacimiento.ToShortDateString().ToString()+"\n";
            msg += "Sexo:" + sexo + "\n";
            msg += "Sueldo:" + salario.ToString() + "\n";

            MessageBox.Show(msg);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
