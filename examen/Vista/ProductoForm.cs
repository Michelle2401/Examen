using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }

        ProductoDatos proDatos = new ProductoDatos();
        Producto producto = new Producto();
        string tipoOperacion = string.Empty;

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            LlenarProductos();
        }

        private async void LlenarProductos()
        {
            ProductodataGridView.DataSource = await proDatos.DevolverListaAsync();
        }
        private void HabilitarControles()
        {
            CodigotextBox.Enabled = true;
            DescripciontextBox.Enabled = true;
            PreciotextBox.Enabled = true;

        }
        private void LimpiarControles()
        {
            CodigotextBox.Clear();
            DescripciontextBox.Clear();
            PreciotextBox.Clear();

        }
        private void DeshabilitarControles()
        {
            CodigotextBox.Enabled = false;
            DescripciontextBox.Enabled = false;
            PreciotextBox.Enabled = false;

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Nuevo";
            HabilitarControles();

        }

        private async void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodigotextBox.Text))
            {
                errorProvider1.SetError(CodigotextBox, "Ingrese el codigo");
                CodigotextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "Ingrese una descripcion");
                DescripciontextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(PreciotextBox.Text))
            {
                errorProvider1.SetError(PreciotextBox, "Ingrese el precio");
                PreciotextBox.Focus();
                return;
            }
            producto.Codigo = Convert.ToInt32(CodigotextBox.Text);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Precio = Convert.ToDecimal(PreciotextBox.Text);

            if (tipoOperacion == "Nuevo")
            {
                bool inserto = await proDatos.InsertarAsync(producto);
                if (inserto)
                {
                    LlenarProductos();
                    LimpiarControles();
                    DeshabilitarControles();
                    MessageBox.Show("Producto Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto no se puede guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (tipoOperacion == "Modificar")
            {
                bool modifico = await proDatos.ActualizarAsync(producto);
                if (modifico)
                {
                    LlenarProductos();
                    LimpiarControles();
                    DeshabilitarControles();
                    MessageBox.Show("Producto Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto no se puede guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            if (ProductodataGridView.SelectedRows.Count > 0)
            {
                tipoOperacion = "Modificar";
                HabilitarControles();
                CodigotextBox.ReadOnly = true;
                CodigotextBox.Text = ProductodataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripciontextBox.Text = ProductodataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                PreciotextBox.Text = ProductodataGridView.CurrentRow.Cells["Precio"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
