namespace WinFormsApp1
{
    partial class Form1
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
            this.btnSeleccioonaXml = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtRutaFitxer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeleccioonaXml
            // 
            this.btnSeleccioonaXml.Location = new System.Drawing.Point(259, 92);
            this.btnSeleccioonaXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccioonaXml.Name = "btnSeleccioonaXml";
            this.btnSeleccioonaXml.Size = new System.Drawing.Size(119, 28);
            this.btnSeleccioonaXml.TabIndex = 0;
            this.btnSeleccioonaXml.Text = "Selecciona XML";
            this.btnSeleccioonaXml.UseVisualStyleBackColor = true;
            this.btnSeleccioonaXml.Click += new System.EventHandler(this.Enter_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtRutaFitxer
            // 
            this.txtRutaFitxer.Enabled = false;
            this.txtRutaFitxer.Location = new System.Drawing.Point(21, 48);
            this.txtRutaFitxer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRutaFitxer.Name = "txtRutaFitxer";
            this.txtRutaFitxer.Size = new System.Drawing.Size(355, 23);
            this.txtRutaFitxer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "BulkData";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 129);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRutaFitxer);
            this.Controls.Add(this.btnSeleccioonaXml);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSeleccioonaXml;
        private OpenFileDialog openFileDialog1;
        private TextBox txtRutaFitxer;
        private Label label1;
    }
}