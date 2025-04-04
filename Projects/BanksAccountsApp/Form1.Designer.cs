
namespace BanksAccountsApp
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
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAcoountsGrid = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            CreateAccountBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAcoountsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(99, 38);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 382);
            label2.Name = "label2";
            label2.Size = new Size(116, 38);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(117, 71);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(242, 43);
            OwnerTxt.TabIndex = 2;
            OwnerTxt.TextChanged += textBox1_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(154, 377);
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(178, 43);
            AmountNum.TabIndex = 3;
            // 
            // BankAcoountsGrid
            // 
            BankAcoountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAcoountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAcoountsGrid.Location = new Point(394, 71);
            BankAcoountsGrid.Name = "BankAcoountsGrid";
            BankAcoountsGrid.RowHeadersWidth = 51;
            BankAcoountsGrid.Size = new Size(489, 215);
            BankAcoountsGrid.TabIndex = 4;
            BankAcoountsGrid.CellContentClick += BankAcoountsGrid_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(428, 320);
            button1.Name = "button1";
            button1.Size = new Size(164, 65);
            button1.TabIndex = 5;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(622, 320);
            button2.Name = "button2";
            button2.Size = new Size(183, 65);
            button2.TabIndex = 6;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(76, 162);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(242, 48);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 701);
            Controls.Add(CreateAccountBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BankAcoountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAcoountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAcoountsGrid;
        private Button button1;
        private Button button2;
        private Button CreateAccountBtn;
    }
}
