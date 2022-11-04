namespace Vista
{
    partial class Userforms
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.CorreotextBox = new System.Windows.Forms.TextBox();
            this.RolcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UsuariosdataGridView = new System.Windows.Forms.DataGridView();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Enabled = false;
            this.CodigotextBox.Location = new System.Drawing.Point(71, 17);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(265, 23);
            this.CodigotextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Clave";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Enabled = false;
            this.NombretextBox.Location = new System.Drawing.Point(71, 66);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(265, 23);
            this.NombretextBox.TabIndex = 5;
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Enabled = false;
            this.ClavetextBox.Location = new System.Drawing.Point(71, 113);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.Size = new System.Drawing.Size(265, 23);
            this.ClavetextBox.TabIndex = 6;
            // 
            // CorreotextBox
            // 
            this.CorreotextBox.Enabled = false;
            this.CorreotextBox.Location = new System.Drawing.Point(71, 162);
            this.CorreotextBox.Name = "CorreotextBox";
            this.CorreotextBox.Size = new System.Drawing.Size(265, 23);
            this.CorreotextBox.TabIndex = 7;
            // 
            // RolcomboBox
            // 
            this.RolcomboBox.FormattingEnabled = true;
            this.RolcomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuarios"});
            this.RolcomboBox.Location = new System.Drawing.Point(71, 218);
            this.RolcomboBox.Name = "RolcomboBox";
            this.RolcomboBox.Size = new System.Drawing.Size(121, 23);
            this.RolcomboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rol";
            // 
            // UsuariosdataGridView
            // 
            this.UsuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosdataGridView.Location = new System.Drawing.Point(15, 278);
            this.UsuariosdataGridView.Name = "UsuariosdataGridView";
            this.UsuariosdataGridView.RowTemplate.Height = 25;
            this.UsuariosdataGridView.Size = new System.Drawing.Size(734, 160);
            this.UsuariosdataGridView.TabIndex = 10;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(390, 230);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(228, 230);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(471, 230);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton.TabIndex = 13;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(309, 230);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 23);
            this.Modificarbutton.TabIndex = 14;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Userforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.UsuariosdataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RolcomboBox);
            this.Controls.Add(this.CorreotextBox);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.label1);
            this.Name = "Userforms";
            this.Text = "Userforms";
            this.Load += new System.EventHandler(this.Userforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox CodigotextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NombretextBox;
        private TextBox ClavetextBox;
        private TextBox CorreotextBox;
        private ComboBox RolcomboBox;
        private Label label5;
        private DataGridView UsuariosdataGridView;
        private Button Guardarbutton;
        private Button Nuevobutton;
        private Button Cancelarbutton;
        private Button Modificarbutton;
        private ErrorProvider errorProvider1;
    }
}