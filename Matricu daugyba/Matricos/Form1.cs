using TextBox = System.Windows.Forms.TextBox;

namespace Matricos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(269, 333);
        }
        private void GenerateMatrices()
        {
            int x1, x2, y1, y2;
            if (!int.TryParse(txtX1.Text, out x1) || !int.TryParse(txtX2.Text, out x2) ||
                !int.TryParse(txtY1.Text, out y1) || !int.TryParse(txtY2.Text, out y2))
            {
                MessageBox.Show("Ne visi teksto laukai pilni.");
                return;
            }

            if (x1 > 5 || x2 > 5 || y1 > 5 || y2 > 5)
            {
                MessageBox.Show("Didziausias didziausia matrica yra 5x5.");
                return;
            }

            if (y1 != x2)
            {
                MessageBox.Show("y1 ir x2 turi buti vienodi.");
                return;
            }

            Size = new Size(875, 391);

            GenerateMatrix(MatrixA, "Matrica A", x1, y1);
            GenerateMatrix(MatrixB, "Matrica B", x2, y2);
        }

        private void GenerateMatrix(FlowLayoutPanel matrixPanel, string name, int rows, int cols)
        {
            Label matrixLabel = new Label
            {
                Size = new Size(100, 30),
                Text = name,
                BackColor = Color.Snow,
                ForeColor = Color.DarkSlateGray,
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold)
            };
            matrixPanel.Controls.Add(matrixLabel);
            matrixPanel.SetFlowBreak(matrixLabel, true);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    TextBox textBox = new TextBox
                    {
                        Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold),
                        Size = new Size(40, 20),
                        Name = $"{name}_{i}_{j}"
                    };
                    matrixPanel.Controls.Add(textBox);

                    if (j + 1 == cols)
                    {
                        matrixPanel.SetFlowBreak(textBox, true);
                    }
                }
            }

            Random num = new Random();
            foreach (Control c in matrixPanel.Controls)
            {
                if (c is TextBox value)
                {
                    value.Text = num.Next(1, 100).ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatrixA.Controls.Clear();
            MatrixB.Controls.Clear();
            GenerateMatrices();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Size = new Size(877, 619);
            int x1, x2, y1, y2;

            if (!int.TryParse(txtX1.Text, out x1) || !int.TryParse(txtX2.Text, out x2) ||
                !int.TryParse(txtY1.Text, out y1) || !int.TryParse(txtY2.Text, out y2))
            {
                MessageBox.Show("Ne visi laukeliai uzpildyti.");
                return;
            }

            int[,] aMatrix = GetMatrixValues(MatrixA, x1, y1);
            int[,] bMatrix = GetMatrixValues(MatrixB, x2, y2);

            try
            {
                Calculations calc = new Calculations(aMatrix, bMatrix);
                int[,] result = calc.Multiply();

                DisplayResultMatrix(result);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int[,] GetMatrixValues(FlowLayoutPanel matrixPanel, int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int index = 0;

            foreach (Control control in matrixPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    int value;
                    if (int.TryParse(textBox.Text, out value))
                    {
                        matrix[index / cols, index % cols] = value;
                    }
                    index++;
                }
            }

            return matrix;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearText(MatrixA);
            clearText(MatrixB);
            clearText(MatrixRez);
            txtX1.Text = "";
            txtX2.Text = "";
            txtY1.Text = "";
            txtY2.Text = "";
        }
        private void clearText(Panel PanelID)
        {
            foreach (Control c in PanelID.Controls)
            {
                if (c is TextBox)
                {
                    if (c is TextBox matrixTextBox)
                    {
                        matrixTextBox.Text = "";
                    }
                }
            }
        }
        private void DisplayResultMatrix(int[,] result)
        {
            MatrixRez.Controls.Clear();

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    TextBox textBox = new TextBox
                    {
                        Size = new Size(55, 30),
                        Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold),
                        Name = $"MatrixC_{i}_{j}",
                        Text = result[i, j].ToString(),
                        ReadOnly = true
                    };
                    MatrixRez.Controls.Add(textBox);

                    if (j + 1 == result.GetLength(1))
                    {
                        MatrixRez.SetFlowBreak(textBox, true);
                    }
                }
            }
        }
        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
