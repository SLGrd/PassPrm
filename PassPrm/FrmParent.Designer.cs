namespace PassPrm
{
    partial class FrmParent
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblParm1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParm1 = new System.Windows.Forms.TextBox();
            this.txtParm2 = new System.Windows.Forms.TextBox();
            this.btnCallForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParm3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParm4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTexto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(30, 76);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(735, 67);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParm1
            // 
            this.lblParm1.AutoSize = true;
            this.lblParm1.Location = new System.Drawing.Point(30, 186);
            this.lblParm1.Name = "lblParm1";
            this.lblParm1.Size = new System.Drawing.Size(70, 13);
            this.lblParm1.TabIndex = 1;
            this.lblParm1.Text = "Parametro 1 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parametro 2 :";
            // 
            // txtParm1
            // 
            this.txtParm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParm1.Location = new System.Drawing.Point(125, 181);
            this.txtParm1.Name = "txtParm1";
            this.txtParm1.Size = new System.Drawing.Size(274, 22);
            this.txtParm1.TabIndex = 0;
            // 
            // txtParm2
            // 
            this.txtParm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParm2.Location = new System.Drawing.Point(125, 216);
            this.txtParm2.Name = "txtParm2";
            this.txtParm2.Size = new System.Drawing.Size(274, 22);
            this.txtParm2.TabIndex = 1;
            // 
            // btnCallForm
            // 
            this.btnCallForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCallForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCallForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallForm.ForeColor = System.Drawing.Color.Maroon;
            this.btnCallForm.Location = new System.Drawing.Point(281, 26);
            this.btnCallForm.Name = "btnCallForm";
            this.btnCallForm.Size = new System.Drawing.Size(237, 35);
            this.btnCallForm.TabIndex = 4;
            this.btnCallForm.Text = "Chamar Formulario Child";
            this.btnCallForm.UseVisualStyleBackColor = false;
            this.btnCallForm.Click += new System.EventHandler(this.BtnCallForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(337, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "P A R E N T";
            // 
            // txtParm3
            // 
            this.txtParm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParm3.Location = new System.Drawing.Point(125, 251);
            this.txtParm3.Name = "txtParm3";
            this.txtParm3.Size = new System.Drawing.Size(274, 22);
            this.txtParm3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parametro 3 :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(800, 1);
            this.label4.TabIndex = 7;
            // 
            // txtParm4
            // 
            this.txtParm4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParm4.Location = new System.Drawing.Point(125, 286);
            this.txtParm4.Name = "txtParm4";
            this.txtParm4.Size = new System.Drawing.Size(274, 22);
            this.txtParm4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Parametro 4 :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCallForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 10;
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtParm4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtParm3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParm2);
            this.Controls.Add(this.txtParm1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblParm1);
            this.Controls.Add(this.lblTexto);
            this.Name = "FrmParent";
            this.Text = "Form Principal - Parent";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblParm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParm1;
        private System.Windows.Forms.TextBox txtParm2;
        private System.Windows.Forms.Button btnCallForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParm3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParm4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}

