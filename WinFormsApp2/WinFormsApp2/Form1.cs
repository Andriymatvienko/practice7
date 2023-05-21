namespace WinFormsApp2
{
    public partial class FrmMass : Form
    {
        private int[,] A;
        private int n, m;
        private float summ, sr;
        private int nn;
        public FrmMass()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtn.Text = "";
            txtm.Text = "";
            txtRez.Text = "";
            dgvMass.Rows.Clear();
            dgvMass.Columns.Clear();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            
            int n, m, nn = 0;
            float summ=0, sr = 0;
            
            n=int.Parse(txtn.Text);
            m= int.Parse(txtm.Text);
            int[,] A = new int[n, m];
            Random rnd= new Random();
            for(int i =0; i<=n-1;i++)
            {
                for (int j=0; j<=m-1; j++) {
                    A[i,j] = rnd.Next(-50,50);}
            }
            dgvMass.RowCount = n; dgvMass.ColumnCount=m;
            for(int i=0;i<=n-1;i++) {
            for (int j=0; j<=m-1;j++)
                {
                    dgvMass.Rows[i].Cells[j].Value = A[i,j];
                }
                    }
            for (int j=0;j<=m-1;j++)
            {
                dgvMass.Columns[j].Width = 50;

            }
            for(int i=0;i<=n-1;i++)
            {
                for(int j=0; j <= m - 1; j++)
                {
                    if (A[i, j]>0)
                    {
                        summ = summ + A[i,j];
                        nn += 1;
                    }
                }
            }
            sr = summ / nn;
            txtRez.Text = "Среднее арифметическое: " + Math.Round(sr, 5).ToString() + Environment.NewLine + "Количество положительных элементов: " + nn.ToString();
        }

        private void txtRez_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}