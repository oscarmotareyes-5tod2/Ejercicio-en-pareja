namespace Ejercicio_en_pareja
{
    partial class Interfaz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbFormulario = new GroupBox();
            cmbGenero = new ComboBox();
            bLimpiar = new Button();
            bGuardar = new Button();
            dtpFecha = new DateTimePicker();
            txbSalario = new TextBox();
            txbCargo = new TextBox();
            txbEmail = new TextBox();
            txbTelefono = new TextBox();
            txbDireccion = new TextBox();
            txbApellido = new TextBox();
            txbNombre = new TextBox();
            LGenero = new Label();
            LFecha = new Label();
            Lcargo = new Label();
            LEmail = new Label();
            LTelefono = new Label();
            LSalario = new Label();
            LDireccion = new Label();
            LApellido = new Label();
            LNombre = new Label();
            txbID = new TextBox();
            LID = new Label();
            bCerrar = new Button();
            bAbril = new Button();
            openFileDialog1 = new OpenFileDialog();
            dgvEmpleados = new DataGridView();
            gbFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // gbFormulario
            // 
            gbFormulario.BackColor = SystemColors.ButtonHighlight;
            gbFormulario.Controls.Add(cmbGenero);
            gbFormulario.Controls.Add(bLimpiar);
            gbFormulario.Controls.Add(bGuardar);
            gbFormulario.Controls.Add(dtpFecha);
            gbFormulario.Controls.Add(txbSalario);
            gbFormulario.Controls.Add(txbCargo);
            gbFormulario.Controls.Add(txbEmail);
            gbFormulario.Controls.Add(txbTelefono);
            gbFormulario.Controls.Add(txbDireccion);
            gbFormulario.Controls.Add(txbApellido);
            gbFormulario.Controls.Add(txbNombre);
            gbFormulario.Controls.Add(LGenero);
            gbFormulario.Controls.Add(LFecha);
            gbFormulario.Controls.Add(Lcargo);
            gbFormulario.Controls.Add(LEmail);
            gbFormulario.Controls.Add(LTelefono);
            gbFormulario.Controls.Add(LSalario);
            gbFormulario.Controls.Add(LDireccion);
            gbFormulario.Controls.Add(LApellido);
            gbFormulario.Controls.Add(LNombre);
            gbFormulario.Controls.Add(txbID);
            gbFormulario.Controls.Add(LID);
            gbFormulario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFormulario.ForeColor = SystemColors.ActiveCaptionText;
            gbFormulario.Location = new Point(202, 31);
            gbFormulario.Name = "gbFormulario";
            gbFormulario.Size = new Size(314, 366);
            gbFormulario.TabIndex = 0;
            gbFormulario.TabStop = false;
            gbFormulario.Text = "Formulario";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(107, 299);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 23);
            cmbGenero.TabIndex = 22;
            // 
            // bLimpiar
            // 
            bLimpiar.ForeColor = SystemColors.ButtonHighlight;
            bLimpiar.Location = new Point(193, 340);
            bLimpiar.Name = "bLimpiar";
            bLimpiar.Size = new Size(75, 23);
            bLimpiar.TabIndex = 21;
            bLimpiar.Text = "Limpiar";
            bLimpiar.UseVisualStyleBackColor = true;
            bLimpiar.Click += bLimpiar_Click;
            // 
            // bGuardar
            // 
            bGuardar.ForeColor = SystemColors.ButtonHighlight;
            bGuardar.Location = new Point(47, 340);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(75, 23);
            bGuardar.TabIndex = 1;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(107, 270);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 20;
            // 
            // txbSalario
            // 
            txbSalario.Location = new Point(107, 241);
            txbSalario.Name = "txbSalario";
            txbSalario.Size = new Size(100, 23);
            txbSalario.TabIndex = 18;
            // 
            // txbCargo
            // 
            txbCargo.Location = new Point(107, 215);
            txbCargo.Name = "txbCargo";
            txbCargo.Size = new Size(100, 23);
            txbCargo.TabIndex = 17;
            txbCargo.TextChanged += txbCargo_TextChanged;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(107, 186);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(100, 23);
            txbEmail.TabIndex = 16;
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(107, 156);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(100, 23);
            txbTelefono.TabIndex = 15;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(107, 127);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(100, 23);
            txbDireccion.TabIndex = 14;
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(107, 96);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(100, 23);
            txbApellido.TabIndex = 13;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(107, 65);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 12;
            // 
            // LGenero
            // 
            LGenero.AutoSize = true;
            LGenero.Location = new Point(5, 298);
            LGenero.Name = "LGenero";
            LGenero.Size = new Size(45, 15);
            LGenero.TabIndex = 11;
            LGenero.Text = "Genero";
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Location = new Point(5, 273);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(96, 15);
            LFecha.TabIndex = 10;
            LFecha.Text = "Fecha de Ingreso";
            // 
            // Lcargo
            // 
            Lcargo.AutoSize = true;
            Lcargo.Location = new Point(5, 218);
            Lcargo.Name = "Lcargo";
            Lcargo.Size = new Size(39, 15);
            Lcargo.TabIndex = 9;
            Lcargo.Text = "Cargo";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new Point(5, 189);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(36, 15);
            LEmail.TabIndex = 8;
            LEmail.Text = "Email";
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(5, 159);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(53, 15);
            LTelefono.TabIndex = 7;
            LTelefono.Text = "Teléfono";
            // 
            // LSalario
            // 
            LSalario.AutoSize = true;
            LSalario.Location = new Point(5, 244);
            LSalario.Name = "LSalario";
            LSalario.Size = new Size(42, 15);
            LSalario.TabIndex = 6;
            LSalario.Text = "Salario";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Location = new Point(5, 130);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(57, 15);
            LDireccion.TabIndex = 5;
            LDireccion.Text = "Dirección";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(5, 99);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 4;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(5, 68);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 3;
            LNombre.Text = "Nombre";
            // 
            // txbID
            // 
            txbID.Location = new Point(107, 33);
            txbID.Name = "txbID";
            txbID.Size = new Size(100, 23);
            txbID.TabIndex = 23;
            txbID.KeyPress += txbID_KeyPress;
            // 
            // LID
            // 
            LID.AutoSize = true;
            LID.Location = new Point(5, 36);
            LID.Name = "LID";
            LID.Size = new Size(18, 15);
            LID.TabIndex = 1;
            LID.Text = "ID";
            // 
            // bCerrar
            // 
            bCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bCerrar.ForeColor = SystemColors.ButtonHighlight;
            bCerrar.Location = new Point(697, 415);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(75, 23);
            bCerrar.TabIndex = 22;
            bCerrar.Text = "Cerrar";
            bCerrar.UseVisualStyleBackColor = true;
            bCerrar.Click += bCerrar_Click;
            // 
            // bAbril
            // 
            bAbril.BackColor = SystemColors.ButtonHighlight;
            bAbril.Location = new Point(558, 185);
            bAbril.Name = "bAbril";
            bAbril.Size = new Size(123, 31);
            bAbril.TabIndex = 0;
            bAbril.Text = "Buscar Archivo";
            bAbril.UseVisualStyleBackColor = false;
            bAbril.Click += bAbrir_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(129, 415);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(468, 141);
            dgvEmpleados.TabIndex = 23;
            dgvEmpleados.Visible = false;
            // 
            // Interfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEmpleados);
            Controls.Add(bAbril);
            Controls.Add(bCerrar);
            Controls.Add(gbFormulario);
            Name = "Interfaz";
            Text = "Form1";
            Load += Form1_Load;
            gbFormulario.ResumeLayout(false);
            gbFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFormulario;
        private TextBox txbID;
        private Label LID;
        private Label LGenero;
        private Label LFecha;
        private Label Lcargo;
        private Label LEmail;
        private Label LTelefono;
        private Label LSalario;
        private Label LDireccion;
        private Label LApellido;
        private Label LNombre;
        private TextBox txbSalario;
        private TextBox txbCargo;
        private TextBox txbEmail;
        private TextBox txbTelefono;
        private TextBox txbDireccion;
        private TextBox txbApellido;
        private TextBox txbNombre;
        private DateTimePicker dtpFecha;
        private Button bLimpiar;
        private Button bGuardar;
        private Button bCerrar;
        private ComboBox cmbGenero;
        private Button bAbril;
        private OpenFileDialog openFileDialog1;
        private DataGridView dgvEmpleados;
    }
}
