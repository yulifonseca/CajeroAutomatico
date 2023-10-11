namespace CajeroAutomatico
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnsalir1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btndepo = new System.Windows.Forms.Button();
            this.btnretiro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdepositos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtretiro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir1
            // 
            this.btnsalir1.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir1.ForeColor = System.Drawing.Color.Red;
            this.btnsalir1.Location = new System.Drawing.Point(454, 437);
            this.btnsalir1.Name = "btnsalir1";
            this.btnsalir1.Size = new System.Drawing.Size(75, 36);
            this.btnsalir1.TabIndex = 8;
            this.btnsalir1.Text = "Regresar";
            this.btnsalir1.UseVisualStyleBackColor = false;
            this.btnsalir1.Click += new System.EventHandler(this.btnsalir1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(123, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione la acción que desea realizar";
            // 
            // btndepo
            // 
            this.btndepo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndepo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndepo.Location = new System.Drawing.Point(332, 177);
            this.btndepo.Name = "btndepo";
            this.btndepo.Size = new System.Drawing.Size(117, 42);
            this.btndepo.TabIndex = 10;
            this.btndepo.Text = "DEPOSITAR";
            this.btndepo.UseVisualStyleBackColor = false;
            this.btndepo.Click += new System.EventHandler(this.btndepo_Click);
            // 
            // btnretiro
            // 
            this.btnretiro.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnretiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretiro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnretiro.Location = new System.Drawing.Point(332, 274);
            this.btnretiro.Name = "btnretiro";
            this.btnretiro.Size = new System.Drawing.Size(117, 42);
            this.btnretiro.TabIndex = 11;
            this.btnretiro.Text = "RETIRAR";
            this.btnretiro.UseVisualStyleBackColor = false;
            this.btnretiro.Click += new System.EventHandler(this.btnretiro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(123, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese el monto que desea depositar";
            // 
            // txtdepositos
            // 
            this.txtdepositos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtdepositos.Location = new System.Drawing.Point(97, 177);
            this.txtdepositos.Multiline = true;
            this.txtdepositos.Name = "txtdepositos";
            this.txtdepositos.Size = new System.Drawing.Size(171, 42);
            this.txtdepositos.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(134, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese el monto que desea retirar";
            // 
            // txtretiro
            // 
            this.txtretiro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtretiro.Location = new System.Drawing.Point(97, 274);
            this.txtretiro.Multiline = true;
            this.txtretiro.Name = "txtretiro";
            this.txtretiro.Size = new System.Drawing.Size(171, 42);
            this.txtretiro.TabIndex = 12;
            this.txtretiro.TextChanged += new System.EventHandler(this.txtretiro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(93, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Saldo:";
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblsaldo.Font = new System.Drawing.Font("Ebrima", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaldo.ForeColor = System.Drawing.Color.White;
            this.lblsaldo.Location = new System.Drawing.Point(156, 98);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(81, 21);
            this.lblsaldo.TabIndex = 15;
            this.lblsaldo.Text = "₡ 100000";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 485);
            this.Controls.Add(this.btnretiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtretiro);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.txtdepositos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndepo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndepo;
        private System.Windows.Forms.Button btnretiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdepositos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtretiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsaldo;
    }
}