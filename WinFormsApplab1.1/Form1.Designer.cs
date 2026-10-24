namespace WinFormsApplab1._1
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
            txtNumber = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lblResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(93, 102);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 27);
            txtNumber.TabIndex = 0;
            txtNumber.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(293, 59);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 1;
            button1.Text = "Sum of Digits";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(268, 128);
            button2.Name = "button2";
            button2.Size = new Size(165, 29);
            button2.TabIndex = 2;
            button2.Text = "Count Even Numbers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(447, 102);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 3;
            lblResult.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 99);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Button button1;
        private Button button2;
        private Label lblResult;
        private Label label1;
    }
}
