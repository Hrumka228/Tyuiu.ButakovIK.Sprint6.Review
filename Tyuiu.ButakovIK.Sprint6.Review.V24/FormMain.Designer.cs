
namespace Tyuiu.ButakovIK.Sprint6.Review.V24
{
    partial class FormMain
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
            this.groupBoxOutput_BIK = new System.Windows.Forms.GroupBox();
            this.buttonDone_BIK = new System.Windows.Forms.Button();
            this.textBoxResult_BIK = new System.Windows.Forms.TextBox();
            this.groupBoxInput_BIK = new System.Windows.Forms.GroupBox();
            this.buttonMatrix_BIK = new System.Windows.Forms.Button();
            this.groupBoxElements_BIK = new System.Windows.Forms.GroupBox();
            this.labelSelectRow_BIK = new System.Windows.Forms.Label();
            this.labelEndStopElemRows_BIK = new System.Windows.Forms.Label();
            this.labelStartElemColumns_BIK = new System.Windows.Forms.Label();
            this.textBoxSelectRow_BIK = new System.Windows.Forms.TextBox();
            this.textBoxStopElemRows_BIK = new System.Windows.Forms.TextBox();
            this.textBoxStartElemColumns_BIK = new System.Windows.Forms.TextBox();
            this.groupBoxMatrix_BIK = new System.Windows.Forms.GroupBox();
            this.labelColumns_BIK = new System.Windows.Forms.Label();
            this.labelRows_BIK = new System.Windows.Forms.Label();
            this.textBoxColumns_BIK = new System.Windows.Forms.TextBox();
            this.textBoxRows_BIK = new System.Windows.Forms.TextBox();
            this.groupBoxRange_BIK = new System.Windows.Forms.GroupBox();
            this.labelStopRange_BIK = new System.Windows.Forms.Label();
            this.labelStartRange_BIK = new System.Windows.Forms.Label();
            this.textBoxStopRange_BIK = new System.Windows.Forms.TextBox();
            this.textBoxStartRange_BIK = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_BIK = new System.Windows.Forms.DataGridView();
            this.labelResult_BIK = new System.Windows.Forms.Label();
            this.groupBoxOutput_BIK.SuspendLayout();
            this.groupBoxInput_BIK.SuspendLayout();
            this.groupBoxElements_BIK.SuspendLayout();
            this.groupBoxMatrix_BIK.SuspendLayout();
            this.groupBoxRange_BIK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BIK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOutput_BIK
            // 
            this.groupBoxOutput_BIK.Controls.Add(this.labelResult_BIK);
            this.groupBoxOutput_BIK.Controls.Add(this.buttonDone_BIK);
            this.groupBoxOutput_BIK.Controls.Add(this.textBoxResult_BIK);
            this.groupBoxOutput_BIK.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxOutput_BIK.Location = new System.Drawing.Point(700, 0);
            this.groupBoxOutput_BIK.Name = "groupBoxOutput_BIK";
            this.groupBoxOutput_BIK.Size = new System.Drawing.Size(200, 482);
            this.groupBoxOutput_BIK.TabIndex = 2;
            this.groupBoxOutput_BIK.TabStop = false;
            this.groupBoxOutput_BIK.Text = "Вывод данных:";
            // 
            // buttonDone_BIK
            // 
            this.buttonDone_BIK.Location = new System.Drawing.Point(51, 418);
            this.buttonDone_BIK.Name = "buttonDone_BIK";
            this.buttonDone_BIK.Size = new System.Drawing.Size(100, 32);
            this.buttonDone_BIK.TabIndex = 1;
            this.buttonDone_BIK.Text = "Выполнить";
            this.buttonDone_BIK.UseVisualStyleBackColor = true;
            this.buttonDone_BIK.Click += new System.EventHandler(this.buttonDone_BIK_Click);
            // 
            // textBoxResult_BIK
            // 
            this.textBoxResult_BIK.Location = new System.Drawing.Point(51, 391);
            this.textBoxResult_BIK.Name = "textBoxResult_BIK";
            this.textBoxResult_BIK.ReadOnly = true;
            this.textBoxResult_BIK.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_BIK.TabIndex = 0;
            // 
            // groupBoxInput_BIK
            // 
            this.groupBoxInput_BIK.Controls.Add(this.buttonMatrix_BIK);
            this.groupBoxInput_BIK.Controls.Add(this.groupBoxElements_BIK);
            this.groupBoxInput_BIK.Controls.Add(this.groupBoxMatrix_BIK);
            this.groupBoxInput_BIK.Controls.Add(this.groupBoxRange_BIK);
            this.groupBoxInput_BIK.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInput_BIK.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_BIK.Name = "groupBoxInput_BIK";
            this.groupBoxInput_BIK.Size = new System.Drawing.Size(194, 482);
            this.groupBoxInput_BIK.TabIndex = 0;
            this.groupBoxInput_BIK.TabStop = false;
            this.groupBoxInput_BIK.Text = "Ввод данных:";
            // 
            // buttonMatrix_BIK
            // 
            this.buttonMatrix_BIK.Location = new System.Drawing.Point(125, 374);
            this.buttonMatrix_BIK.Name = "buttonMatrix_BIK";
            this.buttonMatrix_BIK.Size = new System.Drawing.Size(65, 53);
            this.buttonMatrix_BIK.TabIndex = 2;
            this.buttonMatrix_BIK.Text = "Создать матрицу";
            this.buttonMatrix_BIK.UseVisualStyleBackColor = true;
            this.buttonMatrix_BIK.Click += new System.EventHandler(this.buttonMatrix_BIK_Click_1);
            // 
            // groupBoxElements_BIK
            // 
            this.groupBoxElements_BIK.Controls.Add(this.labelSelectRow_BIK);
            this.groupBoxElements_BIK.Controls.Add(this.labelEndStopElemRows_BIK);
            this.groupBoxElements_BIK.Controls.Add(this.labelStartElemColumns_BIK);
            this.groupBoxElements_BIK.Controls.Add(this.textBoxSelectRow_BIK);
            this.groupBoxElements_BIK.Controls.Add(this.textBoxStopElemRows_BIK);
            this.groupBoxElements_BIK.Controls.Add(this.textBoxStartElemColumns_BIK);
            this.groupBoxElements_BIK.Location = new System.Drawing.Point(6, 323);
            this.groupBoxElements_BIK.Name = "groupBoxElements_BIK";
            this.groupBoxElements_BIK.Size = new System.Drawing.Size(115, 138);
            this.groupBoxElements_BIK.TabIndex = 1;
            this.groupBoxElements_BIK.TabStop = false;
            this.groupBoxElements_BIK.Text = "Элементы:";
            // 
            // labelSelectRow_BIK
            // 
            this.labelSelectRow_BIK.AutoSize = true;
            this.labelSelectRow_BIK.Location = new System.Drawing.Point(3, 95);
            this.labelSelectRow_BIK.Name = "labelSelectRow_BIK";
            this.labelSelectRow_BIK.Size = new System.Drawing.Size(81, 13);
            this.labelSelectRow_BIK.TabIndex = 8;
            this.labelSelectRow_BIK.Text = "Выбор строки:";
            // 
            // labelEndStopElemRows_BIK
            // 
            this.labelEndStopElemRows_BIK.AutoSize = true;
            this.labelEndStopElemRows_BIK.Location = new System.Drawing.Point(3, 56);
            this.labelEndStopElemRows_BIK.Name = "labelEndStopElemRows_BIK";
            this.labelEndStopElemRows_BIK.Size = new System.Drawing.Size(110, 13);
            this.labelEndStopElemRows_BIK.TabIndex = 7;
            this.labelEndStopElemRows_BIK.Text = "Последний столбец:";
            // 
            // labelStartElemColumns_BIK
            // 
            this.labelStartElemColumns_BIK.AutoSize = true;
            this.labelStartElemColumns_BIK.Location = new System.Drawing.Point(3, 17);
            this.labelStartElemColumns_BIK.Name = "labelStartElemColumns_BIK";
            this.labelStartElemColumns_BIK.Size = new System.Drawing.Size(94, 13);
            this.labelStartElemColumns_BIK.TabIndex = 6;
            this.labelStartElemColumns_BIK.Text = "Первый столбец:";
            // 
            // textBoxSelectRow_BIK
            // 
            this.textBoxSelectRow_BIK.Location = new System.Drawing.Point(6, 111);
            this.textBoxSelectRow_BIK.Name = "textBoxSelectRow_BIK";
            this.textBoxSelectRow_BIK.Size = new System.Drawing.Size(80, 20);
            this.textBoxSelectRow_BIK.TabIndex = 6;
            // 
            // textBoxStopElemRows_BIK
            // 
            this.textBoxStopElemRows_BIK.Location = new System.Drawing.Point(6, 72);
            this.textBoxStopElemRows_BIK.Name = "textBoxStopElemRows_BIK";
            this.textBoxStopElemRows_BIK.Size = new System.Drawing.Size(80, 20);
            this.textBoxStopElemRows_BIK.TabIndex = 5;
            // 
            // textBoxStartElemColumns_BIK
            // 
            this.textBoxStartElemColumns_BIK.Location = new System.Drawing.Point(7, 33);
            this.textBoxStartElemColumns_BIK.Name = "textBoxStartElemColumns_BIK";
            this.textBoxStartElemColumns_BIK.Size = new System.Drawing.Size(80, 20);
            this.textBoxStartElemColumns_BIK.TabIndex = 4;
            // 
            // groupBoxMatrix_BIK
            // 
            this.groupBoxMatrix_BIK.Controls.Add(this.labelColumns_BIK);
            this.groupBoxMatrix_BIK.Controls.Add(this.labelRows_BIK);
            this.groupBoxMatrix_BIK.Controls.Add(this.textBoxColumns_BIK);
            this.groupBoxMatrix_BIK.Controls.Add(this.textBoxRows_BIK);
            this.groupBoxMatrix_BIK.Location = new System.Drawing.Point(6, 189);
            this.groupBoxMatrix_BIK.Name = "groupBoxMatrix_BIK";
            this.groupBoxMatrix_BIK.Size = new System.Drawing.Size(182, 102);
            this.groupBoxMatrix_BIK.TabIndex = 1;
            this.groupBoxMatrix_BIK.TabStop = false;
            this.groupBoxMatrix_BIK.Text = "Матрица:";
            // 
            // labelColumns_BIK
            // 
            this.labelColumns_BIK.AutoSize = true;
            this.labelColumns_BIK.Location = new System.Drawing.Point(3, 60);
            this.labelColumns_BIK.Name = "labelColumns_BIK";
            this.labelColumns_BIK.Size = new System.Drawing.Size(119, 13);
            this.labelColumns_BIK.TabIndex = 5;
            this.labelColumns_BIK.Text = "Количество столбцов:";
            // 
            // labelRows_BIK
            // 
            this.labelRows_BIK.AutoSize = true;
            this.labelRows_BIK.Location = new System.Drawing.Point(3, 16);
            this.labelRows_BIK.Name = "labelRows_BIK";
            this.labelRows_BIK.Size = new System.Drawing.Size(101, 13);
            this.labelRows_BIK.TabIndex = 4;
            this.labelRows_BIK.Text = "Количество строк:";
            // 
            // textBoxColumns_BIK
            // 
            this.textBoxColumns_BIK.Location = new System.Drawing.Point(6, 76);
            this.textBoxColumns_BIK.Name = "textBoxColumns_BIK";
            this.textBoxColumns_BIK.Size = new System.Drawing.Size(80, 20);
            this.textBoxColumns_BIK.TabIndex = 3;
            // 
            // textBoxRows_BIK
            // 
            this.textBoxRows_BIK.Location = new System.Drawing.Point(6, 32);
            this.textBoxRows_BIK.Name = "textBoxRows_BIK";
            this.textBoxRows_BIK.Size = new System.Drawing.Size(80, 20);
            this.textBoxRows_BIK.TabIndex = 2;
            // 
            // groupBoxRange_BIK
            // 
            this.groupBoxRange_BIK.Controls.Add(this.labelStopRange_BIK);
            this.groupBoxRange_BIK.Controls.Add(this.labelStartRange_BIK);
            this.groupBoxRange_BIK.Controls.Add(this.textBoxStopRange_BIK);
            this.groupBoxRange_BIK.Controls.Add(this.textBoxStartRange_BIK);
            this.groupBoxRange_BIK.Location = new System.Drawing.Point(6, 59);
            this.groupBoxRange_BIK.Name = "groupBoxRange_BIK";
            this.groupBoxRange_BIK.Size = new System.Drawing.Size(182, 102);
            this.groupBoxRange_BIK.TabIndex = 0;
            this.groupBoxRange_BIK.TabStop = false;
            this.groupBoxRange_BIK.Text = "Диапазон:";
            // 
            // labelStopRange_BIK
            // 
            this.labelStopRange_BIK.AutoSize = true;
            this.labelStopRange_BIK.Location = new System.Drawing.Point(6, 60);
            this.labelStopRange_BIK.Name = "labelStopRange_BIK";
            this.labelStopRange_BIK.Size = new System.Drawing.Size(98, 13);
            this.labelStopRange_BIK.TabIndex = 3;
            this.labelStopRange_BIK.Text = "Конец диапазона:";
            // 
            // labelStartRange_BIK
            // 
            this.labelStartRange_BIK.AutoSize = true;
            this.labelStartRange_BIK.Location = new System.Drawing.Point(6, 16);
            this.labelStartRange_BIK.Name = "labelStartRange_BIK";
            this.labelStartRange_BIK.Size = new System.Drawing.Size(104, 13);
            this.labelStartRange_BIK.TabIndex = 2;
            this.labelStartRange_BIK.Text = "Начало диапазона:";
            // 
            // textBoxStopRange_BIK
            // 
            this.textBoxStopRange_BIK.Location = new System.Drawing.Point(9, 76);
            this.textBoxStopRange_BIK.Name = "textBoxStopRange_BIK";
            this.textBoxStopRange_BIK.Size = new System.Drawing.Size(80, 20);
            this.textBoxStopRange_BIK.TabIndex = 1;
            // 
            // textBoxStartRange_BIK
            // 
            this.textBoxStartRange_BIK.Location = new System.Drawing.Point(9, 32);
            this.textBoxStartRange_BIK.Name = "textBoxStartRange_BIK";
            this.textBoxStartRange_BIK.Size = new System.Drawing.Size(80, 20);
            this.textBoxStartRange_BIK.TabIndex = 0;
            // 
            // dataGridViewMatrix_BIK
            // 
            this.dataGridViewMatrix_BIK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_BIK.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_BIK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrix_BIK.Location = new System.Drawing.Point(194, 0);
            this.dataGridViewMatrix_BIK.Name = "dataGridViewMatrix_BIK";
            this.dataGridViewMatrix_BIK.RowHeadersVisible = false;
            this.dataGridViewMatrix_BIK.RowHeadersWidth = 20;
            this.dataGridViewMatrix_BIK.Size = new System.Drawing.Size(506, 482);
            this.dataGridViewMatrix_BIK.TabIndex = 3;
            // 
            // labelResult_BIK
            // 
            this.labelResult_BIK.AutoSize = true;
            this.labelResult_BIK.Location = new System.Drawing.Point(51, 372);
            this.labelResult_BIK.Name = "labelResult_BIK";
            this.labelResult_BIK.Size = new System.Drawing.Size(62, 13);
            this.labelResult_BIK.TabIndex = 2;
            this.labelResult_BIK.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 482);
            this.Controls.Add(this.dataGridViewMatrix_BIK);
            this.Controls.Add(this.groupBoxOutput_BIK);
            this.Controls.Add(this.groupBoxInput_BIK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Ревью | Вариант 24 | Бутаков И. К.";
            this.groupBoxOutput_BIK.ResumeLayout(false);
            this.groupBoxOutput_BIK.PerformLayout();
            this.groupBoxInput_BIK.ResumeLayout(false);
            this.groupBoxElements_BIK.ResumeLayout(false);
            this.groupBoxElements_BIK.PerformLayout();
            this.groupBoxMatrix_BIK.ResumeLayout(false);
            this.groupBoxMatrix_BIK.PerformLayout();
            this.groupBoxRange_BIK.ResumeLayout(false);
            this.groupBoxRange_BIK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BIK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxOutput_BIK;
        private System.Windows.Forms.Button buttonDone_BIK;
        private System.Windows.Forms.TextBox textBoxResult_BIK;
        private System.Windows.Forms.GroupBox groupBoxInput_BIK;
        private System.Windows.Forms.Button buttonMatrix_BIK;
        private System.Windows.Forms.GroupBox groupBoxElements_BIK;
        private System.Windows.Forms.Label labelSelectRow_BIK;
        private System.Windows.Forms.Label labelEndStopElemRows_BIK;
        private System.Windows.Forms.Label labelStartElemColumns_BIK;
        private System.Windows.Forms.TextBox textBoxSelectRow_BIK;
        private System.Windows.Forms.TextBox textBoxStopElemRows_BIK;
        private System.Windows.Forms.TextBox textBoxStartElemColumns_BIK;
        private System.Windows.Forms.GroupBox groupBoxMatrix_BIK;
        private System.Windows.Forms.Label labelColumns_BIK;
        private System.Windows.Forms.Label labelRows_BIK;
        private System.Windows.Forms.TextBox textBoxColumns_BIK;
        private System.Windows.Forms.TextBox textBoxRows_BIK;
        private System.Windows.Forms.GroupBox groupBoxRange_BIK;
        private System.Windows.Forms.Label labelStopRange_BIK;
        private System.Windows.Forms.Label labelStartRange_BIK;
        private System.Windows.Forms.TextBox textBoxStopRange_BIK;
        private System.Windows.Forms.TextBox textBoxStartRange_BIK;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_BIK;
        private System.Windows.Forms.Label labelResult_BIK;
    }
}
