using System;
using System.Windows.Forms;

namespace Ejercicio01_HolaWinForm
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
            cb_Materias.SelectedIndex = 0;
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Saludar_Click(object sender, EventArgs e)
        {
            FrmMsj msj = new FrmMsj(this.txt_Nombre.Text, this.txt_Apellido.Text,this.cb_Materias.Text);
            if (String.IsNullOrWhiteSpace(this.txt_Nombre.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos: \n Nombre.","", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txt_Apellido.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos: \n Apellido.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                this.Hide();
                msj.Show();
            }
        }

        private void txt_Apellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
