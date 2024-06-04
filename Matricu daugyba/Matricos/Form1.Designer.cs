namespace Matricos
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            MatrixA = new FlowLayoutPanel();
            MatrixB = new FlowLayoutPanel();
            label3 = new Label();
            MatrixRez = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            txtX1 = new TextBox();
            txtY1 = new TextBox();
            label4 = new Label();
            txtY2 = new TextBox();
            label5 = new Label();
            txtX2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(482, 3);
            label1.Name = "label1";
            label1.Size = new Size(251, 41);
            label1.TabIndex = 0;
            label1.Text = "Matricų daugyba";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(307, 74);
            label2.Name = "label2";
            label2.Size = new Size(52, 37);
            label2.TabIndex = 1;
            label2.Text = "X1:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkKhaki;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(915, 68);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(203, 52);
            button1.TabIndex = 5;
            button1.Text = "Sukurti matricas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MatrixA
            // 
            MatrixA.Location = new Point(136, 199);
            MatrixA.Margin = new Padding(3, 4, 3, 4);
            MatrixA.Name = "MatrixA";
            MatrixA.Size = new Size(363, 305);
            MatrixA.TabIndex = 6;
            // 
            // MatrixB
            // 
            MatrixB.Location = new Point(708, 199);
            MatrixB.Margin = new Padding(3, 4, 3, 4);
            MatrixB.Name = "MatrixB";
            MatrixB.Size = new Size(361, 305);
            MatrixB.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(444, 596);
            label3.Name = "label3";
            label3.Size = new Size(299, 41);
            label3.TabIndex = 9;
            label3.Text = "Atsakymų matrica C:";
            // 
            // MatrixRez
            // 
            MatrixRez.Location = new Point(444, 641);
            MatrixRez.Margin = new Padding(3, 4, 3, 4);
            MatrixRez.Name = "MatrixRez";
            MatrixRez.Size = new Size(361, 305);
            MatrixRez.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkKhaki;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(515, 501);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(154, 78);
            button2.TabIndex = 10;
            button2.Text = "Atlikti daugybą";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkKhaki;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(915, 851);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(154, 95);
            button3.TabIndex = 11;
            button3.Text = "Ištrinti viską";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtX1
            // 
            txtX1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtX1.Location = new Point(374, 73);
            txtX1.Margin = new Padding(3, 4, 3, 4);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(51, 42);
            txtX1.TabIndex = 12;
            txtX1.TextChanged += txtX1_TextChanged;
            txtX1.KeyPress += txtX1_KeyPress;
            // 
            // txtY1
            // 
            txtY1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtY1.Location = new Point(501, 72);
            txtY1.Margin = new Padding(3, 4, 3, 4);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(51, 42);
            txtY1.TabIndex = 14;
            txtY1.KeyPress += txtY1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(444, 75);
            label4.Name = "label4";
            label4.Size = new Size(51, 37);
            label4.TabIndex = 13;
            label4.Text = "Y1:";
            // 
            // txtY2
            // 
            txtY2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtY2.Location = new Point(775, 71);
            txtY2.Margin = new Padding(3, 4, 3, 4);
            txtY2.Name = "txtY2";
            txtY2.Size = new Size(51, 42);
            txtY2.TabIndex = 18;
            txtY2.KeyPress += txtY2_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(714, 74);
            label5.Name = "label5";
            label5.Size = new Size(55, 37);
            label5.TabIndex = 17;
            label5.Text = "Y2:";
            // 
            // txtX2
            // 
            txtX2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtX2.Location = new Point(643, 72);
            txtX2.Margin = new Padding(3, 4, 3, 4);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(51, 42);
            txtX2.TabIndex = 16;
            txtX2.TextChanged += txtX2_TextChanged;
            txtX2.KeyPress += txtX2_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(581, 74);
            label6.Name = "label6";
            label6.Size = new Size(56, 37);
            label6.TabIndex = 15;
            label6.Text = "X2:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(136, 136);
            label7.Name = "label7";
            label7.Size = new Size(157, 41);
            label7.TabIndex = 21;
            label7.Text = "Matrica A:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(708, 136);
            label8.Name = "label8";
            label8.Size = new Size(155, 41);
            label8.TabIndex = 22;
            label8.Text = "Matrica B:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 100F, FontStyle.Regular, GraphicsUnit.Pixel);
            label9.Location = new Point(537, 298);
            label9.MaximumSize = new Size(100, 100);
            label9.MinimumSize = new Size(100, 100);
            label9.Name = "label9";
            label9.Size = new Size(100, 100);
            label9.TabIndex = 23;
            label9.Text = "X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1167, 981);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtY2);
            Controls.Add(label5);
            Controls.Add(txtX2);
            Controls.Add(label6);
            Controls.Add(txtY1);
            Controls.Add(label4);
            Controls.Add(txtX1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(MatrixRez);
            Controls.Add(label3);
            Controls.Add(MatrixB);
            Controls.Add(MatrixA);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1185, 1102);
            MinimumSize = new Size(1185, 1028);
            Name = "Form1";
            Text = "Matricos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private FlowLayoutPanel MatrixA;
        private FlowLayoutPanel MatrixB;
        private Label label3;
        private FlowLayoutPanel MatrixRez;
        private Button button2;
        private Button button3;
        private TextBox txtX1;
        private TextBox txtY1;
        private Label label4;
        private TextBox txtY2;
        private Label label5;
        private TextBox txtX2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
