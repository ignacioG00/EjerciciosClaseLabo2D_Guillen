using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01_HolaWinForm
{
    public partial class FrmMsj : Form
    {
        private FrmMsj()
        {
            InitializeComponent();
        }

        public FrmMsj(string nombre, string apellido):this()
        {
            lbl_Mensaje.Text = $"Soy {nombre} {apellido}.";
        }
        public FrmMsj(string nombre, string apellido, string materia) : this()
        {
            lbl_Mensaje.Text = $"Soy {nombre} {apellido} y mi materia favorita es {materia}";
        }
    }
}
