//namespace BanksAccountsApp
//{
//    public partial class Form1 : Form

//    {

//        public Form1()
//        {
//            InitializeComponent();

//            BankAccountsApp bankaccount1 = new BankAccountsApp();
//            bankaccount1.Owner = "Aaqib Ahmed Khan";
//            bankaccount1.AccountNumber = Guid.NewGuid();
//            bankaccount1.Balance = 250;

//            BankAccountsApp bankaccount2 = new BankAccountsApp();
//            bankaccount2.Owner = "Ahmed";
//            bankaccount2.AccountNumber = Guid.NewGuid();
//            bankaccount2.Balance = 120;

//            BankAccountsApp bankaccount3 = new BankAccountsApp();
//            bankaccount3.Owner = "Usman";
//            bankaccount3.AccountNumber = Guid.NewGuid();
//            bankaccount3.Balance = 150;

//            List<BankAccountsApp> bankAccounts = new List<BankAccountsApp>();
//            bankAccounts.Add(bankaccount1);
//            bankAccounts.Add(bankaccount2);
//            bankAccounts.Add(bankaccount3);

//            BankAcoountsGrid.DataSource = bankAccounts;

//        }
//        private void textBox1_TextChanged(object sender, EventArgs e)

//        {

//        }



//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
//        {

//        }

//        private void label2_Click(object sender, EventArgs e)
//        {

//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void button4_Click(object sender, EventArgs e)
//        {

//        }

//        private void button3_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}

namespace BanksAccountsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initialize bank accounts
            BankAccountsApp bankaccount1 = new BankAccountsApp();
            bankaccount1.Owner = "Aaqib Ahmed Khan";
            bankaccount1.AccountNumber = Guid.NewGuid();
            bankaccount1.Balance = 250;

            BankAccountsApp bankaccount2 = new BankAccountsApp();
            bankaccount2.Owner = "Ahmed";
            bankaccount2.AccountNumber = Guid.NewGuid();
            bankaccount2.Balance = 120;

            BankAccountsApp bankaccount3 = new BankAccountsApp();
            bankaccount3.Owner = "Usman";
            bankaccount3.AccountNumber = Guid.NewGuid();
            bankaccount3.Balance = 150;

            // Add accounts to the list
            List<BankAccountsApp> bankAccounts = new List<BankAccountsApp>
            {
                bankaccount1,
                bankaccount2,
                bankaccount3
            };

            // Bind the list to the DataGridView
            BankAcoountsGrid.DataSource = bankAccounts;
        }

        // Clean up unused event handlers if they aren't needed
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Add logic here if needed
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Handle Create Account button click
        }

        private void BankAcoountsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
