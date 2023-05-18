namespace ProjecteXML
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
            txtXML = new TextBox();
            btnCarregar = new Button();
            lblIntrodueix = new Label();
            SuspendLayout();
            // 
            // txtXML
            // 
            txtXML.Location = new Point(12, 101);
            txtXML.Name = "txtXML";
            txtXML.Size = new Size(551, 27);
            txtXML.TabIndex = 0;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(12, 151);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(94, 29);
            btnCarregar.TabIndex = 1;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // lblIntrodueix
            // 
            lblIntrodueix.AutoSize = true;
            lblIntrodueix.Location = new Point(12, 42);
            lblIntrodueix.Name = "lblIntrodueix";
            lblIntrodueix.Size = new Size(105, 20);
            lblIntrodueix.TabIndex = 2;
            lblIntrodueix.Text = "IntrodueixXML";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 201);
            Controls.Add(lblIntrodueix);
            Controls.Add(btnCarregar);
            Controls.Add(txtXML);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtXML;
        private Button btnCarregar;
        private Label lblIntrodueix;
    }
}