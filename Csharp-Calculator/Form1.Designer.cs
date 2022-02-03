
namespace Csharp_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(39, 40);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(184, 23);
            this.txtInput.TabIndex = 0;
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(148, 92);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(75, 23);
            this.btnSubtraction.TabIndex = 1;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(39, 92);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 2;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(148, 149);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(39, 149);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplication.TabIndex = 7;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(39, 197);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(184, 27);
            this.btnEqual.TabIndex = 8;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 250);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnEqual;
    }
}

