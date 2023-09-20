using System.Windows.Forms;
using Test.Entities;

namespace Test
{
    partial class Form1:Form
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
            this.btnApply = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.listPrinters = new System.Windows.Forms.CheckedListBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ButtonSaveItem = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonSaveCategory = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ValueTotal = new System.Windows.Forms.Label();
            this.ValueTax = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.AddOrder = new System.Windows.Forms.Button();
            this.listItems = new System.Windows.Forms.DataGridView();
            this.listCateogries = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTextNotes = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboAssignToUser = new System.Windows.Forms.ComboBox();
            this.tbNotes = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewNotes = new System.Windows.Forms.DataGridView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCateogries)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(375, 958);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(340, 54);
            this.btnApply.TabIndex = 16;
            this.btnApply.Text = "Apply Printers";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 1077);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.listPrinters);
            this.tabPage1.Controls.Add(this.btnApply);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.ButtonSaveItem);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ButtonSaveCategory);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.AddOrder);
            this.tabPage1.Controls.Add(this.listItems);
            this.tabPage1.Controls.Add(this.listCateogries);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1156, 1044);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order Test";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(772, 958);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(340, 54);
            this.button4.TabIndex = 37;
            this.button4.Text = "Delete Order";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.AllowUserToAddRows = false;
            this.listView1.AllowUserToDeleteRows = false;
            this.listView1.AllowUserToOrderColumns = true;
            this.listView1.AllowUserToResizeColumns = false;
            this.listView1.AllowUserToResizeRows = false;
            this.listView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.listView1.ColumnHeadersHeight = 34;
            this.listView1.Location = new System.Drawing.Point(782, 643);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.RowHeadersWidth = 62;
            this.listView1.Size = new System.Drawing.Size(330, 304);
            this.listView1.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(776, 597);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 29);
            this.label14.TabIndex = 35;
            this.label14.Text = "Orders";
            // 
            // listPrinters
            // 
            this.listPrinters.CheckOnClick = true;
            this.listPrinters.FormattingEnabled = true;
            this.listPrinters.Items.AddRange(new object[] {
            "PT100",
            "PT101",
            "PT102"});
            this.listPrinters.Location = new System.Drawing.Point(375, 643);
            this.listPrinters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listPrinters.Name = "listPrinters";
            this.listPrinters.Size = new System.Drawing.Size(336, 303);
            this.listPrinters.TabIndex = 33;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(966, 258);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(162, 24);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Order Without Tax";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(782, 258);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 24);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Order With Tax";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ButtonSaveItem
            // 
            this.ButtonSaveItem.Location = new System.Drawing.Point(486, 571);
            this.ButtonSaveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSaveItem.Name = "ButtonSaveItem";
            this.ButtonSaveItem.Size = new System.Drawing.Size(153, 35);
            this.ButtonSaveItem.TabIndex = 30;
            this.ButtonSaveItem.Text = "Insert";
            this.ButtonSaveItem.UseVisualStyleBackColor = true;
            this.ButtonSaveItem.Click += new System.EventHandler(this.ButtonSaveItem_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(486, 503);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 36);
            this.textBox3.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 512);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Price";
            // 
            // ButtonSaveCategory
            // 
            this.ButtonSaveCategory.Location = new System.Drawing.Point(81, 571);
            this.ButtonSaveCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSaveCategory.Name = "ButtonSaveCategory";
            this.ButtonSaveCategory.Size = new System.Drawing.Size(153, 35);
            this.ButtonSaveCategory.TabIndex = 27;
            this.ButtonSaveCategory.Text = "Insert";
            this.ButtonSaveCategory.UseVisualStyleBackColor = true;
            this.ButtonSaveCategory.Click += new System.EventHandler(this.ButtonSaveCategory_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(488, 452);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 36);
            this.textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 502);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 36);
            this.textBox1.TabIndex = 25;
            this.textBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 462);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 448);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Category Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(782, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(357, 231);
            this.dataGridView1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ValueTotal);
            this.panel1.Controls.Add(this.ValueTax);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.Tax);
            this.panel1.Location = new System.Drawing.Point(782, 303);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 191);
            this.panel1.TabIndex = 21;
            // 
            // ValueTotal
            // 
            this.ValueTotal.AutoSize = true;
            this.ValueTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueTotal.ForeColor = System.Drawing.Color.Red;
            this.ValueTotal.Location = new System.Drawing.Point(224, 89);
            this.ValueTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueTotal.Name = "ValueTotal";
            this.ValueTotal.Size = new System.Drawing.Size(68, 24);
            this.ValueTotal.TabIndex = 3;
            this.ValueTotal.Text = "0.000";
            // 
            // ValueTax
            // 
            this.ValueTax.AutoSize = true;
            this.ValueTax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueTax.ForeColor = System.Drawing.Color.Red;
            this.ValueTax.Location = new System.Drawing.Point(224, 51);
            this.ValueTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueTax.Name = "ValueTax";
            this.ValueTax.Size = new System.Drawing.Size(68, 24);
            this.ValueTax.TabIndex = 2;
            this.ValueTax.Text = "0.000";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(26, 94);
            this.Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(108, 20);
            this.Total.TabIndex = 1;
            this.Total.Text = "Total Amount:";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(27, 55);
            this.Tax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(114, 20);
            this.Tax.TabIndex = 0;
            this.Tax.Text = "Total Tax (5%):";
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(988, 505);
            this.AddOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(153, 35);
            this.AddOrder.TabIndex = 20;
            this.AddOrder.Text = "Order";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // listItems
            // 
            this.listItems.AllowUserToResizeColumns = false;
            this.listItems.AllowUserToResizeRows = false;
            this.listItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.listItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listItems.Location = new System.Drawing.Point(375, 9);
            this.listItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listItems.Name = "listItems";
            this.listItems.RowHeadersWidth = 62;
            this.listItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listItems.Size = new System.Drawing.Size(336, 424);
            this.listItems.TabIndex = 19;
            this.listItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listItems_CellContentClick);
            // 
            // listCateogries
            // 
            this.listCateogries.AllowUserToResizeColumns = false;
            this.listCateogries.AllowUserToResizeRows = false;
            this.listCateogries.BackgroundColor = System.Drawing.SystemColors.Window;
            this.listCateogries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listCateogries.Location = new System.Drawing.Point(12, 9);
            this.listCateogries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listCateogries.MultiSelect = false;
            this.listCateogries.Name = "listCateogries";
            this.listCateogries.RowHeadersWidth = 62;
            this.listCateogries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listCateogries.Size = new System.Drawing.Size(324, 424);
            this.listCateogries.TabIndex = 18;
            this.listCateogries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listCateogries_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnSaveNote);
            this.tabPage2.Controls.Add(this.btnClearAll);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cboAssignToUser);
            this.tabPage2.Controls.Add(this.tbNotes);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.listViewNotes);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1156, 1044);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notes Test";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(342, 460);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 11;
            this.button5.Text = "Deselect";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTextNotes);
            this.groupBox1.Controls.Add(this.labelNotes);
            this.groupBox1.Controls.Add(this.btnAddNewUser);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbImage);
            this.groupBox1.Location = new System.Drawing.Point(26, 505);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(428, 394);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New User";
            // 
            // tbTextNotes
            // 
            this.tbTextNotes.Location = new System.Drawing.Point(102, 285);
            this.tbTextNotes.Name = "tbTextNotes";
            this.tbTextNotes.Size = new System.Drawing.Size(296, 26);
            this.tbTextNotes.TabIndex = 21;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(16, 291);
            this.labelNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(51, 20);
            this.labelNotes.TabIndex = 20;
            this.labelNotes.Text = "Notes";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddNewUser.Location = new System.Drawing.Point(1, 344);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(428, 35);
            this.btnAddNewUser.TabIndex = 10;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 235);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(104, 229);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(298, 26);
            this.tbEmail.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 178);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(102, 174);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(298, 26);
            this.tbPassword.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 125);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(102, 120);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(298, 26);
            this.tbUsername.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(315, 62);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 35);
            this.button7.TabIndex = 10;
            this.button7.Text = "Browse";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Image";
            // 
            // tbImage
            // 
            this.tbImage.Location = new System.Drawing.Point(75, 65);
            this.tbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbImage.Name = "tbImage";
            this.tbImage.ReadOnly = true;
            this.tbImage.Size = new System.Drawing.Size(229, 26);
            this.tbImage.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(618, 51);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "Edit/Add Note";
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Location = new System.Drawing.Point(997, 475);
            this.btnSaveNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(112, 35);
            this.btnSaveNote.TabIndex = 6;
            this.btnSaveNote.Text = "Save Note";
            this.btnSaveNote.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.LightCoral;
            this.btnClearAll.Location = new System.Drawing.Point(27, 460);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(112, 35);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(619, 475);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Assigned To User";
            // 
            // cboAssignToUser
            // 
            this.cboAssignToUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssignToUser.FormattingEnabled = true;
            this.cboAssignToUser.Location = new System.Drawing.Point(795, 475);
            this.cboAssignToUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboAssignToUser.Name = "cboAssignToUser";
            this.cboAssignToUser.Size = new System.Drawing.Size(170, 28);
            this.cboAssignToUser.TabIndex = 3;
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(622, 100);
            this.tbNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(487, 341);
            this.tbNotes.TabIndex = 2;
            this.tbNotes.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Notes List";
            // 
            // listViewNotes
            // 
            this.listViewNotes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.listViewNotes.ColumnHeadersHeight = 34;
            this.listViewNotes.Location = new System.Drawing.Point(28, 100);
            this.listViewNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewNotes.Name = "listViewNotes";
            this.listViewNotes.RowHeadersWidth = 62;
            this.listViewNotes.Size = new System.Drawing.Size(426, 341);
            this.listViewNotes.TabIndex = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Note";
            this.columnHeader1.Width = 178;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Assigned User";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.Width = 39;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Amount";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Number of Items";
            this.columnHeader5.Width = 93;
            // 
            // itemName
            // 
            this.itemName.MinimumWidth = 8;
            this.itemName.Name = "itemName";
            this.itemName.Width = 150;
            // 
            // price
            // 
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 1008);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCateogries)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckedListBox listPrinters;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button ButtonSaveItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonSaveCategory;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ValueTotal;
        private System.Windows.Forms.Label ValueTax;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.DataGridView listItems;
        private System.Windows.Forms.DataGridView listCateogries;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboAssignToUser;
        private System.Windows.Forms.RichTextBox tbNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView listViewNotes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private TextBox tbTextNotes;
    }
}

