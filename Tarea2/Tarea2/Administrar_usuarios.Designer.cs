namespace Tarea2
{
    partial class Administrar_usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BotonBorrar = new Button();
            BotonEditar = new Button();
            BotonSuspender = new Button();
            listBoxUsuarios = new ListBox();
            tabPage2 = new TabPage();
            botonAgregar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(19, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(901, 467);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSteelBlue;
            tabPage1.Controls.Add(BotonBorrar);
            tabPage1.Controls.Add(BotonEditar);
            tabPage1.Controls.Add(BotonSuspender);
            tabPage1.Controls.Add(listBoxUsuarios);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(893, 434);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listado";
            // 
            // BotonBorrar
            // 
            BotonBorrar.BackColor = Color.Red;
            BotonBorrar.Location = new Point(608, 368);
            BotonBorrar.Name = "BotonBorrar";
            BotonBorrar.Size = new Size(170, 63);
            BotonBorrar.TabIndex = 3;
            BotonBorrar.Text = "Borrar";
            BotonBorrar.UseVisualStyleBackColor = false;
            BotonBorrar.Click += BotonBorrar_Click;
            // 
            // BotonEditar
            // 
            BotonEditar.BackColor = Color.Red;
            BotonEditar.Location = new Point(328, 365);
            BotonEditar.Name = "BotonEditar";
            BotonEditar.Size = new Size(170, 63);
            BotonEditar.TabIndex = 2;
            BotonEditar.Text = "Editar";
            BotonEditar.UseVisualStyleBackColor = false;
            BotonEditar.Click += BotonEditar_Click;
            // 
            // BotonSuspender
            // 
            BotonSuspender.BackColor = Color.Red;
            BotonSuspender.Location = new Point(6, 365);
            BotonSuspender.Name = "BotonSuspender";
            BotonSuspender.Size = new Size(170, 63);
            BotonSuspender.TabIndex = 1;
            BotonSuspender.Text = "Suspender";
            BotonSuspender.UseVisualStyleBackColor = false;
            BotonSuspender.Click += BotonSuspender_Click;
            // 
            // listBoxUsuarios
            // 
            listBoxUsuarios.BackColor = SystemColors.InactiveCaption;
            listBoxUsuarios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxUsuarios.FormattingEnabled = true;
            listBoxUsuarios.ItemHeight = 28;
            listBoxUsuarios.Location = new Point(6, 6);
            listBoxUsuarios.Name = "listBoxUsuarios";
            listBoxUsuarios.Size = new Size(881, 340);
            listBoxUsuarios.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.GradientActiveCaption;
            tabPage2.Controls.Add(botonAgregar);
            tabPage2.Controls.Add(txtNombre);
            tabPage2.Controls.Add(lblNombre);
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(893, 434);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Agregar";
            // 
            // botonAgregar
            // 
            botonAgregar.BackColor = Color.LimeGreen;
            botonAgregar.Location = new Point(33, 109);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(214, 70);
            botonAgregar.TabIndex = 2;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = false;
            botonAgregar.Click += botonAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(854, 34);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // Administrar_usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(946, 527);
            Controls.Add(tabControl1);
            Name = "Administrar_usuarios";
            Text = "Administrar_usuarios";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BotonSuspender;
        private ListBox listBoxUsuarios;
        private Label lblNombre;
        private Button botonAgregar;
        private TextBox txtNombre;
        private Button BotonBorrar;
        private Button BotonEditar;
    }
}