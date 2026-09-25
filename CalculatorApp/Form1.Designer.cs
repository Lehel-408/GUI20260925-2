namespace CalculatorApp
{
    partial class Calculator
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
            btnDelete = new Button();
            label1 = new Label();
            txtBoxNum1 = new TextBox();
            txtBoxNum2 = new TextBox();
            label2 = new Label();
            txtBoxEredmeny = new TextBox();
            label3 = new Label();
            btnSum = new Button();
            btnMult = new Button();
            btnSub = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(75, 214);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 23);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Torles";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "1. Adat";
            // 
            // txtBoxNum1
            // 
            txtBoxNum1.Location = new Point(26, 41);
            txtBoxNum1.Name = "txtBoxNum1";
            txtBoxNum1.Size = new Size(100, 23);
            txtBoxNum1.TabIndex = 2;
            // 
            // txtBoxNum2
            // 
            txtBoxNum2.Location = new Point(151, 41);
            txtBoxNum2.Name = "txtBoxNum2";
            txtBoxNum2.Size = new Size(100, 23);
            txtBoxNum2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 23);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "2. Adat";
            // 
            // txtBoxEredmeny
            // 
            txtBoxEredmeny.Location = new Point(88, 98);
            txtBoxEredmeny.Name = "txtBoxEredmeny";
            txtBoxEredmeny.Size = new Size(100, 23);
            txtBoxEredmeny.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 80);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Eredmeny";
            // 
            // btnSum
            // 
            btnSum.Location = new Point(26, 156);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(100, 23);
            btnSum.TabIndex = 7;
            btnSum.Text = "Osszeadas";
            btnSum.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(26, 185);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(100, 23);
            btnMult.TabIndex = 8;
            btnMult.Text = "Szorzas";
            btnMult.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(151, 156);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(100, 23);
            btnSub.TabIndex = 9;
            btnSub.Text = "Kivonas";
            btnSub.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(151, 185);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(100, 23);
            btnDiv.TabIndex = 10;
            btnDiv.Text = "Osztas";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 245);
            Controls.Add(btnDiv);
            Controls.Add(btnSub);
            Controls.Add(btnMult);
            Controls.Add(btnSum);
            Controls.Add(txtBoxEredmeny);
            Controls.Add(label3);
            Controls.Add(txtBoxNum2);
            Controls.Add(label2);
            Controls.Add(txtBoxNum1);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Label label1;
        private TextBox txtBoxNum1;
        private TextBox txtBoxNum2;
        private Label label2;
        private TextBox txtBoxEredmeny;
        private Label label3;
        private Button btnSum;
        private Button btnMult;
        private Button btnSub;
        private Button btnDiv;
    }
}
