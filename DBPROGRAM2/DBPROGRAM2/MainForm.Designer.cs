namespace DBPROGRAM2
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Region = new System.Windows.Forms.TextBox();
            this.Population = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.TextBox();
            this.Capital = new System.Windows.Forms.TextBox();
            this.ShowCountryData = new System.Windows.Forms.Button();
            this.AddCountry = new System.Windows.Forms.Button();
            this.CodeCountry = new System.Windows.Forms.TextBox();
            this.CountryName = new System.Windows.Forms.TextBox();
            this.SearchCountry = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowAll = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.ShowAll);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Region);
            this.panel1.Controls.Add(this.Population);
            this.panel1.Controls.Add(this.Area);
            this.panel1.Controls.Add(this.Capital);
            this.panel1.Controls.Add(this.ShowCountryData);
            this.panel1.Controls.Add(this.AddCountry);
            this.panel1.Controls.Add(this.CodeCountry);
            this.panel1.Controls.Add(this.CountryName);
            this.panel1.Controls.Add(this.SearchCountry);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 486);
            this.panel1.TabIndex = 1;
            // 
            // Region
            // 
            this.Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Region.Location = new System.Drawing.Point(12, 361);
            this.Region.Multiline = true;
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(233, 45);
            this.Region.TabIndex = 14;
            this.Region.Enter += new System.EventHandler(this.Region_Enter);
            this.Region.Leave += new System.EventHandler(this.Region_Leave);
            // 
            // Population
            // 
            this.Population.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Population.Location = new System.Drawing.Point(12, 310);
            this.Population.Multiline = true;
            this.Population.Name = "Population";
            this.Population.Size = new System.Drawing.Size(233, 45);
            this.Population.TabIndex = 13;
            this.Population.Enter += new System.EventHandler(this.Population_Enter);
            this.Population.Leave += new System.EventHandler(this.Population_Leave);
            // 
            // Area
            // 
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Area.Location = new System.Drawing.Point(12, 259);
            this.Area.Multiline = true;
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(233, 45);
            this.Area.TabIndex = 12;
            this.Area.Enter += new System.EventHandler(this.Area_Enter);
            this.Area.Leave += new System.EventHandler(this.Area_Leave);
            // 
            // Capital
            // 
            this.Capital.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capital.Location = new System.Drawing.Point(12, 208);
            this.Capital.Multiline = true;
            this.Capital.Name = "Capital";
            this.Capital.Size = new System.Drawing.Size(233, 45);
            this.Capital.TabIndex = 11;
            this.Capital.Enter += new System.EventHandler(this.Capital_Enter);
            this.Capital.Leave += new System.EventHandler(this.Capital_Leave);
            // 
            // ShowCountryData
            // 
            this.ShowCountryData.Location = new System.Drawing.Point(251, 412);
            this.ShowCountryData.Name = "ShowCountryData";
            this.ShowCountryData.Size = new System.Drawing.Size(150, 50);
            this.ShowCountryData.TabIndex = 10;
            this.ShowCountryData.Text = "ShowCountryData";
            this.ShowCountryData.UseVisualStyleBackColor = true;
            this.ShowCountryData.Click += new System.EventHandler(this.ShowCountryData_Click);
            // 
            // AddCountry
            // 
            this.AddCountry.Location = new System.Drawing.Point(12, 412);
            this.AddCountry.Name = "AddCountry";
            this.AddCountry.Size = new System.Drawing.Size(112, 50);
            this.AddCountry.TabIndex = 9;
            this.AddCountry.Text = "Add_Country_in_DB";
            this.AddCountry.UseVisualStyleBackColor = true;
            this.AddCountry.Click += new System.EventHandler(this.AddCountry_Click);
            // 
            // CodeCountry
            // 
            this.CodeCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeCountry.Location = new System.Drawing.Point(12, 157);
            this.CodeCountry.Multiline = true;
            this.CodeCountry.Name = "CodeCountry";
            this.CodeCountry.Size = new System.Drawing.Size(233, 45);
            this.CodeCountry.TabIndex = 8;
            this.CodeCountry.Enter += new System.EventHandler(this.CodeCountry_Enter);
            this.CodeCountry.Leave += new System.EventHandler(this.CodeCountry_Leave);
            // 
            // CountryName
            // 
            this.CountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryName.Location = new System.Drawing.Point(12, 106);
            this.CountryName.Multiline = true;
            this.CountryName.Name = "CountryName";
            this.CountryName.Size = new System.Drawing.Size(233, 45);
            this.CountryName.TabIndex = 7;
            this.CountryName.Enter += new System.EventHandler(this.CountryName_Enter);
            this.CountryName.Leave += new System.EventHandler(this.CountryName_Leave);
            // 
            // SearchCountry
            // 
            this.SearchCountry.Location = new System.Drawing.Point(130, 412);
            this.SearchCountry.Name = "SearchCountry";
            this.SearchCountry.Size = new System.Drawing.Size(115, 50);
            this.SearchCountry.TabIndex = 1;
            this.SearchCountry.Text = "Search_Contry_internet";
            this.SearchCountry.UseVisualStyleBackColor = true;
            this.SearchCountry.Click += new System.EventHandler(this.SearchCountry_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 100);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(803, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 24);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "ГЛАВНЫЙ ЭКРАН";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            this.dataGridView1.Location = new System.Drawing.Point(251, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 303);
            this.dataGridView1.TabIndex = 15;
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(407, 412);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(140, 50);
            this.ShowAll.TabIndex = 16;
            this.ShowAll.Text = "ShowAllCountry";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 486);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchCountry;
        private System.Windows.Forms.TextBox CountryName;
        private System.Windows.Forms.TextBox CodeCountry;
        private System.Windows.Forms.Button ShowCountryData;
        private System.Windows.Forms.Button AddCountry;
        private System.Windows.Forms.TextBox Region;
        private System.Windows.Forms.TextBox Population;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.TextBox Capital;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}