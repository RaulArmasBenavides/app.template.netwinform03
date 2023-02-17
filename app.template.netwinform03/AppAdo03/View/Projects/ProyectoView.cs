using ERPNETv1.Controller;
using ERPNETv1.Entity;
using System;
using System.Windows.Forms;

namespace CapaUI.View
{
    public partial class ProyectoView : Form
    {
        public ProyectoView()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            listaProyectos();
        }
        ProyectoBll opro = new ProyectoBll();
        Proyecto pro;

        private void listaProyectos()
        {
            dgvProyecto.DataSource = opro.ProyectoListar();
        }

        private void ProyectoView_Load(object sender, EventArgs e)
        {
            try
            {
                cargaCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargaCombos()
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            procesar(1);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            procesar(2);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            procesar(3);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
        }


        private void procesar(int opcion)
        {
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        opro.ProyectoAdicionar(leeProyecto());
                        msg = "Proyecto registrado con exito";
                        break;
                    case 2:
                        opro.ProyectoActualizar(leeProyecto());
                        msg = "Proyecto actualizado con exito";
                        break;
                    case 3:
                        opro.ProyectoEliminar(leeProyecto());
                        msg = "Proyecto eliminado con exito";
                        break;
                    case 4:
                        consultarProyecto();
                        return;
                }
                MessageBox.Show(msg, "exito");
                listaProyectos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }

        private void consultarProyecto()
        {
            pro = opro.ProyectoBuscar(txtCodigo.Text);
            if (pro != null)
            {
                //txtNombre.Text = pro.NombreProyecto;
                //cboProveedor.SelectedValue = pro.IdProveedor;
                //cboCategoria.SelectedValue = pro.IdCategoria;
                //txtPrecio.Text = pro.Precio.ToString();
                //numCantidad.Value = pro.Stock;
            }
            else
            {
                MessageBox.Show("Proyecto no existe", "aviso");
                txtCodigo.SelectAll();
                txtCodigo.Focus();
            }
        }

        private Proyecto leeProyecto()
        {
            //crear objeto pro
            pro = new Proyecto()
            {
                idProyecto = int.Parse(txtCodigo.Text),

                monto = Convert.ToDecimal(txtMonto.Text)
                //NombreProyecto=txtNombre.Text,
                //IdProveedor=(int)cboProveedor.SelectedValue,
                //IdCategoria=(int)cboCategoria.SelectedValue,
                //Precio=decimal.Parse(txtPrecio.Text),
                //Stock=(int)numCantidad.Value
            };
            return pro;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProyecto.Rows.Count > 0)
                {
                    ImpresionExcel();
                }
                else
                {
                    MessageBox.Show("No existen detalles para exportar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al exportar a Excel " + ex.Message, "error");
            }
        }

        private void ImpresionExcel()
        {
            //dgvProyecto.SelectAll();
            //DataObject copydata = dgvProyecto.GetClipboardContent();
            //if (copydata != null) Clipboard.SetDataObject(copydata);
            //Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            //xlapp.Visible = true;
            //Microsoft.Office.Interop.Excel.Workbook xlWbook;
            //Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            //object miseddata = System.Reflection.Missing.Value;
            //xlWbook = xlapp.Workbooks.Add(miseddata);

            //xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            //Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            //xlr.Select();

            //xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
