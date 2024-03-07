using System;

namespace Ejercicio_10_11_dgv_13_2_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {




            if (string.IsNullOrWhiteSpace(txt_Nombre.Text) || string.IsNullOrWhiteSpace(txt_Correo.Text))

            {
                MessageBox.Show("Debe llenar los campos antes de agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else

            {


                dgv_datos.Rows.Add(txt_Nombre.Text, txt_Correo.Text);
                txt_Nombre.Clear();
                txt_Correo.Clear();
                txt_Nombre.Focus();
            }



        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_datos.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int fila;
                fila = dgv_datos.CurrentRow.Index;
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea eliminar este registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    dgv_datos.Rows.RemoveAt(fila);
                    MessageBox.Show("Registro eliminado");

                }
            }



        }


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Correo.Clear();
            dgv_datos.Rows.Clear();
        }




    }
}