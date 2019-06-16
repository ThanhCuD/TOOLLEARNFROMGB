namespace TOOL
{
    partial class TOOL
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
            this.rtbXml = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameOfClass = new System.Windows.Forms.TextBox();
            this.btGenXML = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbXml
            // 
            this.rtbXml.Location = new System.Drawing.Point(724, 58);
            this.rtbXml.Name = "rtbXml";
            this.rtbXml.Size = new System.Drawing.Size(513, 290);
            this.rtbXml.TabIndex = 9;
            this.rtbXml.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name Of Class";
            // 
            // txtNameOfClass
            // 
            this.txtNameOfClass.Location = new System.Drawing.Point(105, 23);
            this.txtNameOfClass.Name = "txtNameOfClass";
            this.txtNameOfClass.Size = new System.Drawing.Size(283, 20);
            this.txtNameOfClass.TabIndex = 7;
            // 
            // btGenXML
            // 
            this.btGenXML.Location = new System.Drawing.Point(724, 29);
            this.btGenXML.Name = "btGenXML";
            this.btGenXML.Size = new System.Drawing.Size(75, 23);
            this.btGenXML.TabIndex = 6;
            this.btGenXML.Text = "GenXML";
            this.btGenXML.UseVisualStyleBackColor = true;
            this.btGenXML.Click += new System.EventHandler(this.btGenXML_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(678, 290);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // TOOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 358);
            this.Controls.Add(this.rtbXml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameOfClass);
            this.Controls.Add(this.btGenXML);
            this.Controls.Add(this.richTextBox1);
            this.Name = "TOOL";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameOfClass;
        private System.Windows.Forms.Button btGenXML;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

