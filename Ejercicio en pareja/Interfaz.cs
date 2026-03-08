using System.Text.RegularExpressions;

namespace Ejercicio_en_pareja
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void txbCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bCerrar.BackColor = Color.Red;
            bGuardar.BackColor = Color.Green;
            bLimpiar.BackColor = Color.Blue;

            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("Femenino");

            dgvEmpleados.ColumnCount = 10;
            dgvEmpleados.Columns[0].Name = "ID";
            dgvEmpleados.Columns[1].Name = "Nombre";
            dgvEmpleados.Columns[2].Name = "Apellidos";
            dgvEmpleados.Columns[3].Name = "Dirección";
            dgvEmpleados.Columns[4].Name = "Teléfono";
            dgvEmpleados.Columns[5].Name = "Email";
            dgvEmpleados.Columns[6].Name = "Cargo";
            dgvEmpleados.Columns[7].Name = "Salario";
            dgvEmpleados.Columns[8].Name = "Fecha Ingreso";
            dgvEmpleados.Columns[9].Name = "Género";

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Deseas salir del programa?",
                "Confirmación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelaste la acción");
            }
        }

        private bool EsEmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w+$");
        }

        private bool EsIDvalido(string ID)
        {
            return Regex.IsMatch(ID, @"^\d+$");
        }
        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }


        private bool EsTelefonoValido(string telefono)
        {
            return Regex.IsMatch(telefono, @"^\+?[\d-]{7,15}$");
        }

        private bool EsSalarioValido(string salario)
        {
            return decimal.TryParse(salario, out decimal s) && s > 0;
        }

        
        private bool CamposVacios()
        {
            foreach (Control c in this.gbFormulario.Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text))
                    return true;
            }
            return false;
        }


        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsIDvalido(txbID.Text))
            {
                MessageBox.Show("Ese ID no es valido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsTelefonoValido(txbTelefono.Text))
            {
                MessageBox.Show("Teléfono no válido (7–15 dígitos).", "Error");
                return;
            }

            if (!EsEmailValido(txbEmail.Text))
            {
                MessageBox.Show("Email no válido.", "Error");
                return;
            }           

            if (!EsSalarioValido(txbSalario.Text))
            {
                MessageBox.Show("Salario no válido.", "Error");
                return;
            }


            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivos de texto (*.txt)|*.txt";
            guardar.Title = "Guardar datos del empleado";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(guardar.FileName))
                    {
                        sw.WriteLine(
                          "ID".PadRight(5) +
                          "Nombre".PadRight(15) +
                          "Apellidos".PadRight(15) +
                          "Direccion".PadRight(20) +
                          "Telefono".PadRight(15) +
                          "Email".PadRight(25) +
                          "Cargo".PadRight(15) +
                          "Salario".PadRight(10) +
                          "Fecha".PadRight(20) +
                          "Genero".PadRight(10)
                        );

                        string linea =
                        txbID.Text.PadRight(5) +
                        txbNombre.Text.PadRight(15) +
                        txbApellido.Text.PadRight(15) +
                        txbDireccion.Text.PadRight(20) +
                        txbTelefono.Text.PadRight(15) +
                        txbEmail.Text.PadRight(25) +
                        txbCargo.Text.PadRight(15) +
                        txbSalario.Text.PadRight(10) +
                        dtpFecha.Text.PadRight(20) +
                        cmbGenero.SelectedItem.ToString().PadRight(10);

                        sw.WriteLine(linea);

                    }


                    MessageBox.Show("Datos guardados correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

      

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            foreach (Control c in gbFormulario.Controls)
            {
                if (c is TextBox)
                    c.Text = "";

                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;

                else if (c is DateTimePicker)
                    ((DateTimePicker)c).Value = DateTime.Now;

            }
        }

        private void bAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Title = "Abrir archivo de empleados";
            abrir.Filter = "Archivos de texto (*.txt)|*.txt";
            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string contenido = File.ReadAllText(abrir.FileName);

                    
                    MessageBox.Show(contenido, $"Contenido del archivo");

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }


    }
}