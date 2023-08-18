using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregamos la Referencia a la clase operativa
using libOpeUniversidad;
namespace appPractica1
{
    public partial class frmUniversidad : Form
    {
        public frmUniversidad()
        {
            InitializeComponent();
        }

        #region Metodos Propios
        private void Mensaje(string Texto)
        {
            this.txtMsj.Text = Texto;
        }

        private void llenarCombo()
        {
            this.cmbTipoEst.Items.Add("Seleccione Tipo De Estudiante"); // index = 0
            this.cmbTipoEst.Items.Add("PreGrado"); // index = 1
            this.cmbTipoEst.Items.Add("PostGrado"); // index = 2
            this.cmbTipoEst.SelectedIndex = 0;
        }

        private void Limpiar()
        {
            this.cmbTipoEst.SelectedIndex = 0;
            this.txtMsj.Text = String.Empty;
            this.txtCarnet.Text = String.Empty;
            this.txtNombre.Text = String.Empty;
            this.txtPromedio.Text = String.Empty;
            this.txtNroCred.Text = String.Empty;
            this.txtVrCred.Text = String.Empty;
            this.txtDscto.Text = String.Empty;
            this.txtVrPagar.Text = String.Empty;
            this.gpbRpta.Visible = false;
            this.cmbTipoEst.Focus();

        }
        #endregion

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmUniversidad_Load(object sender, EventArgs e)
        {
            llenarCombo();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int cod, tipoE;
            string nombre;
            float notaP;

            try
            {  //Captura de datos de entrada
                tipoE = this.cmbTipoEst.SelectedIndex;
                if(tipoE <= 0)
                {
                    Mensaje("Tipo De Estudiante No Valido");
                    this.cmbTipoEst.Focus();
                    return;
                }
                cod = Convert.ToInt16(this.txtCarnet.Text);
                nombre = this.txtNombre.Text.Trim();
                notaP = Convert.ToSingle(this.txtPromedio.Text);
                // Crear el objeto
                clsOpeUniversidad OP = new clsOpeUniversidad();
                // Enviar informacion al objeto
                OP.TipoEstudiante = tipoE;
                OP.Promedio = notaP;
                //Invocar el metodo y tipo del error
                if(! OP.hallarPago())
                {
                    Mensaje(OP.Error);
                    OP = null;
                    return;
                }
                //Recuperar informacion 
                this.txtNroCred.Text = OP.NumCreditos.ToString();
                this.txtVrCred.Text = OP.ValorCred.ToString();
                this.txtDscto.Text = OP.Descuento.ToString();
                this.txtVrPagar.Text = OP.ValorPago.ToString();
                OP = null;
                this.gpbRpta.Visible = true;   
            }
            catch (Exception ex)
            {
                Mensaje(ex.Message);
            }
        }
    }
}

