namespace RfoApp
{
    partial class ingresoForm
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
            this.ingresoUsuarioLabel = new System.Windows.Forms.Label();
            this.ingresoPasswordLabel = new System.Windows.Forms.Label();
            this.ingresoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ingresoPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ingresoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ingresoUsuarioLabel
            // 
            this.ingresoUsuarioLabel.AutoSize = true;
            this.ingresoUsuarioLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoUsuarioLabel.Location = new System.Drawing.Point(151, 157);
            this.ingresoUsuarioLabel.Name = "ingresoUsuarioLabel";
            this.ingresoUsuarioLabel.Size = new System.Drawing.Size(89, 22);
            this.ingresoUsuarioLabel.TabIndex = 0;
            this.ingresoUsuarioLabel.Text = "Usuario:";
            // 
            // ingresoPasswordLabel
            // 
            this.ingresoPasswordLabel.AutoSize = true;
            this.ingresoPasswordLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoPasswordLabel.Location = new System.Drawing.Point(115, 242);
            this.ingresoPasswordLabel.Name = "ingresoPasswordLabel";
            this.ingresoPasswordLabel.Size = new System.Drawing.Size(125, 22);
            this.ingresoPasswordLabel.TabIndex = 1;
            this.ingresoPasswordLabel.Text = "Contraseña:";
            // 
            // ingresoUsuarioTextBox
            // 
            this.ingresoUsuarioTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoUsuarioTextBox.Location = new System.Drawing.Point(247, 154);
            this.ingresoUsuarioTextBox.MaxLength = 30;
            this.ingresoUsuarioTextBox.Name = "ingresoUsuarioTextBox";
            this.ingresoUsuarioTextBox.Size = new System.Drawing.Size(320, 29);
            this.ingresoUsuarioTextBox.TabIndex = 2;
            this.ingresoUsuarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ingresoPasswordTextBox
            // 
            this.ingresoPasswordTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoPasswordTextBox.Location = new System.Drawing.Point(247, 242);
            this.ingresoPasswordTextBox.MaxLength = 12;
            this.ingresoPasswordTextBox.Name = "ingresoPasswordTextBox";
            this.ingresoPasswordTextBox.PasswordChar = '*';
            this.ingresoPasswordTextBox.Size = new System.Drawing.Size(320, 29);
            this.ingresoPasswordTextBox.TabIndex = 3;
            this.ingresoPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ingresoButton
            // 
            this.ingresoButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoButton.Location = new System.Drawing.Point(353, 332);
            this.ingresoButton.Name = "ingresoButton";
            this.ingresoButton.Size = new System.Drawing.Size(109, 39);
            this.ingresoButton.TabIndex = 4;
            this.ingresoButton.Text = "Ingresar";
            this.ingresoButton.UseVisualStyleBackColor = true;
            this.ingresoButton.Click += new System.EventHandler(this.ingresoButton_Click);
            // 
            // ingresoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.ingresoButton);
            this.Controls.Add(this.ingresoPasswordTextBox);
            this.Controls.Add(this.ingresoUsuarioTextBox);
            this.Controls.Add(this.ingresoPasswordLabel);
            this.Controls.Add(this.ingresoUsuarioLabel);
            this.MaximizeBox = false;
            this.Name = "ingresoForm";
            this.ShowIcon = false;
            this.Text = "RegioFrio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ingresoUsuarioLabel;
        private System.Windows.Forms.Label ingresoPasswordLabel;
        private System.Windows.Forms.TextBox ingresoUsuarioTextBox;
        private System.Windows.Forms.TextBox ingresoPasswordTextBox;
        private System.Windows.Forms.Button ingresoButton;
    }
}

