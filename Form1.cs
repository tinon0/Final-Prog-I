using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autos
{
    public partial class Form1 : Form
    {
        List<Auto> listaautos;
        AutoService service;
        private bool esNuevo = false;
        public Form1()
        {
            InitializeComponent();
            listaautos = new List<Auto>();
            service = new AutoService();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Habilitar(true);
            CargarComboMarca(cboMarca, "Marcas");
            CargarComboColor(cboColor, "Colores");
            CargarLista(lstAutos, "Autos");
            cboColor.SelectedValue = -1;
            cboMarca.SelectedValue = -1;
        }

        private void CargarLista(ListBox lista, string nombreTabla)
        {
            listaautos.Clear();
            lista.Items.Clear();
            listaautos = service.getLista();
            lista.Items.AddRange(listaautos.ToArray());
        }

        private void CargarComboColor(ComboBox combo, string nombreTabla)
        {
            DataTable table = service.getComboColores();
            combo.DataSource = table;
            combo.ValueMember = table.Columns[0].ColumnName;
            combo.DisplayMember = table.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboMarca(ComboBox combo, string nombreTabla)
        {
            DataTable table = service.getComboMarcas();
            combo.DataSource = table;
            combo.ValueMember = table.Columns[0].ColumnName;
            combo.DisplayMember = table.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Habilitar(bool v)
        {
            grpAutos.Enabled = !v;
            lstAutos.Enabled = v;
            btnSalir.Enabled = v;
            btnNuevo.Enabled = v;
            btnBorrar.Enabled = !v;
            btnCancelar.Visible = !v;
            btnEditar.Enabled = !v;
            btnGuardar.Enabled = !v;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            btnGuardar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
            grpAutos.Enabled = true;
            btnNuevo.Enabled = false;
            LimpiarCampos();
            cboColor.SelectedValue = -1;
            cboMarca.SelectedValue = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Auto oAuto = new Auto();
                oAuto.Patente = Convert.ToString(txtPatente.Text);
                oAuto.Marca = Convert.ToInt32(cboMarca.SelectedValue);
                oAuto.Modelo = Convert.ToInt32(txtModelo.Text);
                oAuto.Color = Convert.ToInt32(cboColor.SelectedValue);
                oAuto.Precio = Convert.ToDouble(txtPrecio.Text);

                if (esNuevo)
                {
                    if (Existe(oAuto.Patente))
                    {
                        MessageBox.Show("Auto ya existente");
                        return;
                    }
                }

                bool ok = service.Guardar(oAuto, esNuevo);
                MessageBox.Show("Auto guardado con éxito!");
                Habilitar(true);
                LimpiarCampos();
                CargarLista(lstAutos, "Autos");
            }
        }

        private void LimpiarCampos()
        {
            foreach (Control control in grpAutos.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedItem = -1;
                }
            }
        }

        private bool Existe(string patente)
        {
            bool encontro = false;
            for (int i = 0; i < listaautos.Count; i++)
            {
                if (listaautos[i].Patente == patente)
                {
                    encontro = true;
                    break;
                }
            }
            return encontro;
        }

        private bool ValidarDatos()
        {
            if (txtPatente.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una patente");
                txtPatente.Focus();
                return false;
            }
            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir una marca");
                return false;
            }
            if (txtModelo.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un año de modelo");
                txtModelo.Focus();
                return false;
            }
            if (cboColor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un color");
                return false;
            }
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un precio");
                txtPrecio.Focus();
                return false;
            }
            if (!int.TryParse(txtModelo.Text, out int ses))
            {
                MessageBox.Show("Debe ingresar numeros en el Modelo");
                txtModelo.Text = string.Empty;
                return false;
            }
            if (!double.TryParse(txtPrecio.Text, out double sas))
            {
                MessageBox.Show("Debe ingresar numeros en el Precio");
                txtPrecio.Text = string.Empty;
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Habilitar(true);
            cboColor.SelectedValue = -1;
            cboMarca.SelectedValue = -1;
        }

        private void lstAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lstAutos.SelectedIndex;
            if (selected != -1)
            {
                Auto oAuto = listaautos[selected];
                txtPatente.Text = oAuto.Patente;
                cboMarca.SelectedValue = oAuto.Marca;
                txtModelo.Text = oAuto.Modelo.ToString();
                cboColor.SelectedValue = oAuto.Color;
                txtPrecio.Text = oAuto.Precio.ToString();

                btnBorrar.Enabled = true;
                btnEditar.Enabled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int index = lstAutos.SelectedIndex;
            if (MessageBox.Show("Desea eliminar este Auto?", "Borrasion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (service.Borrar(listaautos[index].Patente))
                {
                    MessageBox.Show("Se ha eliminado el auto correctamente");
                    Habilitar(true);
                    LimpiarCampos();
                    CargarLista(lstAutos, "Autos");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grpAutos.Enabled = true;
            esNuevo = false;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            lstAutos.Enabled = false;
            btnEditar.Enabled = false;
        }

    }
}
