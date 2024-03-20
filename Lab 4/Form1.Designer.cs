
namespace Lab_4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtColumnIndex = new System.Windows.Forms.TextBox();
            this.btnShowColumn = new System.Windows.Forms.Button();
            this.btnShowFifthRow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTransformedArray = new System.Windows.Forms.Label();
            this.lblSumAfterLastZero = new System.Windows.Forms.Label();
            this.lblPositiveCount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1082, 621);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtColumnIndex);
            this.tabPage1.Controls.Add(this.btnShowColumn);
            this.tabPage1.Controls.Add(this.btnShowFifthRow);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.lblTransformedArray);
            this.tabPage1.Controls.Add(this.lblSumAfterLastZero);
            this.tabPage1.Controls.Add(this.lblPositiveCount);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtArray);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1074, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtColumnIndex
            // 
            this.txtColumnIndex.Location = new System.Drawing.Point(772, 392);
            this.txtColumnIndex.Name = "txtColumnIndex";
            this.txtColumnIndex.Size = new System.Drawing.Size(100, 20);
            this.txtColumnIndex.TabIndex = 11;
            // 
            // btnShowColumn
            // 
            this.btnShowColumn.Location = new System.Drawing.Point(627, 530);
            this.btnShowColumn.Name = "btnShowColumn";
            this.btnShowColumn.Size = new System.Drawing.Size(75, 23);
            this.btnShowColumn.TabIndex = 10;
            this.btnShowColumn.Text = "button3";
            this.btnShowColumn.UseVisualStyleBackColor = true;
            this.btnShowColumn.Click += new System.EventHandler(this.btnShowColumn_Click);
            // 
            // btnShowFifthRow
            // 
            this.btnShowFifthRow.Location = new System.Drawing.Point(533, 530);
            this.btnShowFifthRow.Name = "btnShowFifthRow";
            this.btnShowFifthRow.Size = new System.Drawing.Size(75, 23);
            this.btnShowFifthRow.TabIndex = 9;
            this.btnShowFifthRow.Text = "button2";
            this.btnShowFifthRow.UseVisualStyleBackColor = true;
            this.btnShowFifthRow.Click += new System.EventHandler(this.btnShowFifthRow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(494, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // lblTransformedArray
            // 
            this.lblTransformedArray.AutoSize = true;
            this.lblTransformedArray.Location = new System.Drawing.Point(179, 484);
            this.lblTransformedArray.Name = "lblTransformedArray";
            this.lblTransformedArray.Size = new System.Drawing.Size(35, 13);
            this.lblTransformedArray.TabIndex = 5;
            this.lblTransformedArray.Text = "label3";
            // 
            // lblSumAfterLastZero
            // 
            this.lblSumAfterLastZero.AutoSize = true;
            this.lblSumAfterLastZero.Location = new System.Drawing.Point(179, 454);
            this.lblSumAfterLastZero.Name = "lblSumAfterLastZero";
            this.lblSumAfterLastZero.Size = new System.Drawing.Size(35, 13);
            this.lblSumAfterLastZero.TabIndex = 4;
            this.lblSumAfterLastZero.Text = "label2";
            // 
            // lblPositiveCount
            // 
            this.lblPositiveCount.AutoSize = true;
            this.lblPositiveCount.Location = new System.Drawing.Point(179, 416);
            this.lblPositiveCount.Name = "lblPositiveCount";
            this.lblPositiveCount.Size = new System.Drawing.Size(35, 13);
            this.lblPositiveCount.TabIndex = 3;
            this.lblPositiveCount.Text = "label1";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 454);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "button1";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.buttonCalculate_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(708, 322);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(46, 409);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(103, 20);
            this.txtArray.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1074, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 633);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Button buttonCalculate_Click;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTransformedArray;
        private System.Windows.Forms.Label lblSumAfterLastZero;
        private System.Windows.Forms.Label lblPositiveCount;
        private System.Windows.Forms.Button btnShowColumn;
        private System.Windows.Forms.Button btnShowFifthRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtColumnIndex;
    }
}

