namespace Vista
{
    partial class ProductoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.ProductodataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Enabled = false;
            this.CodigotextBox.Location = new System.Drawing.Point(108, 32);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(178, 25);
            this.CodigotextBox.TabIndex = 2;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Enabled = false;
            this.DescripciontextBox.Location = new System.Drawing.Point(108, 88);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(178, 25);
            this.DescripciontextBox.TabIndex = 3;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Enabled = false;
            this.PreciotextBox.Location = new System.Drawing.Point(108, 149);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(178, 25);
            this.PreciotextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(190, 203);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 23);
            this.Modificarbutton.TabIndex = 18;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(352, 203);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton.TabIndex = 17;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(109, 203);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 16;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(271, 203);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 15;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // ProductodataGridView
            // 
            this.ProductodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductodataGridView.Location = new System.Drawing.Point(-1, 260);
            this.ProductodataGridView.Name = "ProductodataGridView";
            this.ProductodataGridView.RowTemplate.Height = 25;
            this.ProductodataGridView.Size = new System.Drawing.Size(539, 164);
            this.ProductodataGridView.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 436);
            this.Controls.Add(this.ProductodataGridView);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ProductoForm";
            this.Text = "ProductoForm";
            this.Load += new System.EventHandler(this.ProductoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CodigotextBox;
        private TextBox DescripciontextBox;
        private TextBox PreciotextBox;
        private Label label3;
        private Button Modificarbutton;
        private Button Cancelarbutton;
        private Button Nuevobutton;
        private Button Guardarbutton;
        private DataGridView ProductodataGridView;
        private ErrorProvider errorProvider1;
    }
}