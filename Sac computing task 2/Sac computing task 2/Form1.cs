namespace Sac_computing_task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //asking the user to select a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                float total = 0f;

                foreach(string line in lines)
                {
                    //reading the columns of the csv file
                    List<string> fields = line.Split(',').ToList();
                    float profit;
                    float colPurchasePrice = float.Parse(fields[4]);
                    string colSalePrice = fields[5];

                    if(float.TryParse(colSalePrice, out float _salePrice))
                    {
                        profit = _salePrice - colPurchasePrice;
                    }
                    else
                    {
                        profit = colPurchasePrice * -1;
                    }
                    total += profit;

                    fields.Add(profit.ToString());

                    dgvSales.Rows.Add(fields.ToArray());



                        //setting the label to the profit
                        lblProfitTotal.Text = $"Total Profit is {colProfit}";

                }
            }
        }
    }
}