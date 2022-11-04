namespace Vista
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoUsuariotextBox = new System.Windows.Forms.TextBox();
            this.Clavetext = new System.Windows.Forms.TextBox();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // CodigoUsuariotextBox
            // 
            this.CodigoUsuariotextBox.Location = new System.Drawing.Point(97, 40);
            this.CodigoUsuariotextBox.Name = "CodigoUsuariotextBox";
            this.CodigoUsuariotextBox.Size = new System.Drawing.Size(168, 23);
            this.CodigoUsuariotextBox.TabIndex = 2;
            // 
            // Clavetext
            // 
            this.Clavetext.Location = new System.Drawing.Point(97, 103);
            this.Clavetext.Name = "Clavetext";
            this.Clavetext.PasswordChar = '*';
            this.Clavetext.Size = new System.Drawing.Size(168, 23);
            this.Clavetext.TabIndex = 3;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Image = global::Vista.Properties.Resources.aceptar;
            this.Aceptarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aceptarbutton.Location = new System.Drawing.Point(40, 188);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(81, 35);
            this.Aceptarbutton.TabIndex = 4;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = global::Vista.Properties.Resources.cancelar;
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.Location = new System.Drawing.Point(200, 188);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(85, 35);
            this.Cancelarbutton.TabIndex = 5;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.iniciar_sesion__1_;
            this.pictureBox1.Location = new System.Drawing.Point(322, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.Aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton;
            this.ClientSize = new System.Drawing.Size(462, 239);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.Clavetext);
            this.Controls.Add(this.CodigoUsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CodigoUsuariotextBox;
        private TextBox Clavetext;
        private Button Aceptarbutton;
        private Button Cancelarbutton;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox1;
    }
}