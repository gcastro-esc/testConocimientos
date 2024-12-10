using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testConocimientos
{
    public partial class frmCulturaGeneral : Form
    {
        //Variables Globales
        int puntos = 0, cantidadRespuestas=0;

        public frmCulturaGeneral()
        {
            InitializeComponent();
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            //Inicializar variable puntos
            puntos = 0;
            
            //Pregunta # 1
            lblResultado1.Visible = true;
            if (cbRespuesta1.SelectedIndex == 1) //Depende de la posicion de la resp correcta
            {
                lblResultado1.Text = "Respuesta correcta!";
                lblResultado1.ForeColor = Color.Green;  //Texto en color verde
                puntos = puntos + 10;   //Valor de cada respuesta correcta 
            }
            else
            {
                lblResultado1.Text = "Respuesta Incorrecta :( ";
                lblResultado1.ForeColor = Color.Red;    //Texto en color rojo
            }

            //Pregunta # 2
            lblResultado2.Visible = true;
            if (cbRespuesta2.SelectedIndex == 3)
            {
                lblResultado2.Text = "Respuesta correcta!";
                lblResultado2.ForeColor = Color.Green;  
                puntos = puntos + 10;
            }
            else
            {
                lblResultado2.Text = "Respuesta Incorrecta :( ";
                lblResultado2.ForeColor = Color.Red; 
            }

            //Pregunta # 3
            lblResultado3.Visible = true;
            if (cbRespuesta3.SelectedIndex == 2)
            {
                lblResultado3.Text = "Respuesta correcta!";
                lblResultado3.ForeColor = Color.Green;
                puntos = puntos + 10;
            }
            else
            {
                lblResultado3.Text = "Respuesta Incorrecta :( ";
                lblResultado3.ForeColor = Color.Red;
            }

            //Pregunta # 4
            lblResultado4.Visible = true;
            if (cbRespuesta4.SelectedIndex == 1)
            {
                lblResultado4.Text = "Respuesta correcta!";
                lblResultado4.ForeColor = Color.Green;
                puntos = puntos + 10;
            }
            else
            {
                lblResultado4.Text = "Respuesta Incorrecta :( ";
                lblResultado4.ForeColor = Color.Red;
            }

            //Pregunta # 5
            lblResultado5.Visible = true;
            if (cbRespuesta5.SelectedIndex == 0)
            {
                lblResultado5.Text = "Respuesta correcta!";
                lblResultado5.ForeColor = Color.Green;
                puntos = puntos + 10;
            }
            else
            {
                lblResultado5.Text = "Respuesta Incorrecta :( ";
                lblResultado5.ForeColor = Color.Red;
            }

            //Pregunta # 6
            lblResultado6.Visible = true;
            if (cbRespuesta6.SelectedIndex == 2)
            {
                lblResultado6.Text = "Respuesta correcta!";
                lblResultado6.ForeColor = Color.Green;
                puntos = puntos + 10;
            }
            else
            {
                lblResultado6.Text = "Respuesta Incorrecta :( ";
                lblResultado6.ForeColor = Color.Red;
            }

            //Pregunta # 7
            lblResultado7.Visible = true;
            if (cbRespuesta7.SelectedIndex == 2)
            {
                lblResultado7.Text = "Respuesta correcta!";
                lblResultado7.ForeColor = Color.Green;
                puntos = puntos + 10;
            }
            else
            {
                lblResultado7.Text = "Respuesta Incorrecta :( ";
                lblResultado7.ForeColor = Color.Red;
            }

            //Pregunta # 8
            lblResultado8.Visible = true;
            if (cbRespuesta8.SelectedIndex == 0)
            {
                lblResultado8.Text = "Respuesta correcta!";
                lblResultado8.ForeColor = Color.Green;
                puntos = puntos + 10;
            }
            else
            {
                lblResultado8.Text = "Respuesta Incorrecta :( ";
                lblResultado8.ForeColor = Color.Red;
            }

            //Pregunta # 9
            lblResultado9.Visible = true;
            if (cbRespuesta9.SelectedIndex == 1)
            {
                lblResultado9.Text = "Respuesta correcta!";
                lblResultado9.ForeColor = Color.Green;
                puntos = puntos + 10;
            }
            else
            {
                lblResultado9.Text = "Respuesta Incorrecta :( ";
                lblResultado9.ForeColor = Color.Red;
            }

            //Pregunta # 10
            lblResultado10.Visible = true;
            if (cbRespuesta10.SelectedIndex == 0)
            {
                lblResultado10.Text = "Respuesta correcta!";
                lblResultado10.ForeColor = Color.Green;
                puntos = puntos + 10;
            }
            else
            {
                lblResultado10.Text = "Respuesta Incorrecta :( ";
                lblResultado10.ForeColor = Color.Red;
            }

            //Mostrar progressBar
            progressBar.Visible = true;
            for (int i = 0; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(30);
                progressBar.Value = i;
            }
            progressBar.Visible = false;
            MessageBox.Show("Cuestionario calificado!", "Hecho! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //Mostrar puntaje total
            lblPuntaje.Visible = true;
            lblPuntaje.Text = "Puntaje Obtenido \n" + puntos;
            if (puntos > 50)
            {
                lblPuntaje.ForeColor = Color.Blue;
            }
            else
            {
                lblPuntaje.ForeColor = Color.Red;
            }

            //Deshabilitar combos y boton
            cbRespuesta1.Enabled = false;
            cbRespuesta2.Enabled = false;
            cbRespuesta3.Enabled = false;
            cbRespuesta4.Enabled = false;
            cbRespuesta5.Enabled = false;
            cbRespuesta6.Enabled = false;
            cbRespuesta7.Enabled = false;
            cbRespuesta8.Enabled = false;
            cbRespuesta9.Enabled = false;
            cbRespuesta10.Enabled = false;
            btnCalificar.Enabled = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Boton Comenzar (reinicia el form a su estado original)
            cbRespuesta1.SelectedIndex = -1;
            cbRespuesta1.Enabled = true;
            cbRespuesta2.SelectedIndex = -1;
            cbRespuesta2.Enabled = true;
            cbRespuesta3.SelectedIndex = -1;
            cbRespuesta3.Enabled = true;
            cbRespuesta4.SelectedIndex = -1;
            cbRespuesta4.Enabled = true;
            cbRespuesta5.SelectedIndex = -1;
            cbRespuesta5.Enabled = true;
            cbRespuesta6.SelectedIndex = -1;
            cbRespuesta6.Enabled = true;
            cbRespuesta7.SelectedIndex = -1;
            cbRespuesta7.Enabled = true;
            cbRespuesta8.SelectedIndex = -1;
            cbRespuesta8.Enabled = true;
            cbRespuesta9.SelectedIndex = -1;
            cbRespuesta9.Enabled = true;
            cbRespuesta10.SelectedIndex = -1;
            cbRespuesta10.Enabled = true;
            lblResultado1.Visible = false;
            lblResultado2.Visible = false;
            lblResultado3.Visible = false;
            lblResultado4.Visible = false;
            lblResultado5.Visible = false;
            lblResultado6.Visible = false;
            lblResultado7.Visible = false;
            lblResultado8.Visible = false;
            lblResultado9.Visible = false;
            lblResultado10.Visible = false;
            lblPuntaje.Visible = false;
            btnCalificar.Enabled = true;
        }
    }
}
