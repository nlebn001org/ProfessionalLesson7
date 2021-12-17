namespace Reflector
{
    partial class FormCheck
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.cbMethod = new System.Windows.Forms.CheckBox();
            this.cbProperties = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWithAttributes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(51, 98);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(40, 19);
            this.cbAll.TabIndex = 1;
            this.cbAll.Text = "All";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbMethod
            // 
            this.cbMethod.AutoSize = true;
            this.cbMethod.Location = new System.Drawing.Point(51, 123);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(73, 19);
            this.cbMethod.TabIndex = 2;
            this.cbMethod.Text = "Methods";
            this.cbMethod.UseVisualStyleBackColor = true;
            // 
            // cbProperties
            // 
            this.cbProperties.AutoSize = true;
            this.cbProperties.Location = new System.Drawing.Point(51, 148);
            this.cbProperties.Name = "cbProperties";
            this.cbProperties.Size = new System.Drawing.Size(69, 19);
            this.cbProperties.TabIndex = 3;
            this.cbProperties.Text = "Prpertes";
            this.cbProperties.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose which types will be shown";
            // 
            // cbWithAttributes
            // 
            this.cbWithAttributes.AutoSize = true;
            this.cbWithAttributes.Location = new System.Drawing.Point(51, 173);
            this.cbWithAttributes.Name = "cbWithAttributes";
            this.cbWithAttributes.Size = new System.Drawing.Size(106, 19);
            this.cbWithAttributes.TabIndex = 5;
            this.cbWithAttributes.Text = "With Attributes";
            this.cbWithAttributes.UseVisualStyleBackColor = true;
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 288);
            this.Controls.Add(this.cbWithAttributes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProperties);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.button1);
            this.Name = "FormCheck";
            this.Text = "Choose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.CheckBox cbMethod;
        private System.Windows.Forms.CheckBox cbProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbWithAttributes;
    }
}