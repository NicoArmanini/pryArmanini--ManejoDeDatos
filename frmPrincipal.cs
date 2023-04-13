using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryArmanini__ManejoDeDatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //sacar datos de un archivo


            //ABRIR O CREAR UN ARCHIVO
           // StreamWriter manejoArchivo = new StreamWriter("LIBRO1.txt");

            StreamReader leerArchivo = new StreamReader("LIBRO1.txt");

            while (leerArchivo.EndOfStream == false)
            {
               
                lblDatos.Text += leerArchivo.ReadLine() + "/n";
                //lblDatos.Text = lblDatos.Text + leerArchivo.ReadLine();
                //es lo mismo que lo de arriba
            }

            leerArchivo.Close();
           // manejoArchivo.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            StreamReader leerArchivo = new StreamReader("LIBRO1.txt");

            while (leerArchivo.EndOfStream == false)
            {
                string auxiliar = leerArchivo.ReadLine();
                //buscar dentro del stream / texto
                if (auxiliar.Contains(txtDatoABuscar.Text))
                {
                    lblDatos.Text = "Encntrado";
                    lblDatos.Text += auxiliar;
                    break;
                }
                else
                {
                    lblDatos.Text = "NO PASA NARANJA";
                }
            }

            leerArchivo.Close();
            
        }
    }
}
