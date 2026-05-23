namespace Calculator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblResultSub = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblSizeValue = new System.Windows.Forms.Label();
            this.lblSizeResult = new System.Windows.Forms.Label();
            this.lblWeightValue = new System.Windows.Forms.Label();
            this.lblWeightResult = new System.Windows.Forms.Label();
            this.pnlFormula = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbMoney = new System.Windows.Forms.PictureBox();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlFormula.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultTitle.Location = new System.Drawing.Point(99, 27);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(267, 22);
            this.lblResultTitle.TabIndex = 0;
            this.lblResultTitle.Text = "СТОИМОСТЬ ПЕРЕСЫЛКИ";
            // 
            // lblResultSub
            // 
            this.lblResultSub.AutoSize = true;
            this.lblResultSub.Location = new System.Drawing.Point(100, 49);
            this.lblResultSub.Name = "lblResultSub";
            this.lblResultSub.Size = new System.Drawing.Size(143, 16);
            this.lblResultSub.TabIndex = 1;
            this.lblResultSub.Text = "Результаты расчёта";
            this.lblResultSub.Click += new System.EventHandler(this.lblResultSub_Click);
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.LightBlue;
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.pictureBox2);
            this.pnlData.Controls.Add(this.pictureBox3);
            this.pnlData.Controls.Add(this.lblSizeValue);
            this.pnlData.Controls.Add(this.lblSizeResult);
            this.pnlData.Controls.Add(this.lblWeightValue);
            this.pnlData.Controls.Add(this.lblWeightResult);
            this.pnlData.Location = new System.Drawing.Point(12, 90);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(385, 100);
            this.pnlData.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Calculator.Properties.Resources.весы;
            this.pictureBox2.Location = new System.Drawing.Point(32, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Calculator.Properties.Resources.куб;
            this.pictureBox3.Location = new System.Drawing.Point(32, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // lblSizeValue
            // 
            this.lblSizeValue.AutoSize = true;
            this.lblSizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSizeValue.Location = new System.Drawing.Point(205, 55);
            this.lblSizeValue.Name = "lblSizeValue";
            this.lblSizeValue.Size = new System.Drawing.Size(113, 18);
            this.lblSizeValue.TabIndex = 3;
            this.lblSizeValue.Text = "40 × 30 × 20 см";
            this.lblSizeValue.Click += new System.EventHandler(this.lblSizeValue_Click);
            // 
            // lblSizeResult
            // 
            this.lblSizeResult.AutoSize = true;
            this.lblSizeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSizeResult.Location = new System.Drawing.Point(95, 51);
            this.lblSizeResult.Name = "lblSizeResult";
            this.lblSizeResult.Size = new System.Drawing.Size(92, 22);
            this.lblSizeResult.TabIndex = 2;
            this.lblSizeResult.Text = "Размеры:";
            // 
            // lblWeightValue
            // 
            this.lblWeightValue.AutoSize = true;
            this.lblWeightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeightValue.Location = new System.Drawing.Point(205, 20);
            this.lblWeightValue.Name = "lblWeightValue";
            this.lblWeightValue.Size = new System.Drawing.Size(34, 18);
            this.lblWeightValue.TabIndex = 1;
            this.lblWeightValue.Text = "5 кг";
            // 
            // lblWeightResult
            // 
            this.lblWeightResult.AutoSize = true;
            this.lblWeightResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeightResult.Location = new System.Drawing.Point(95, 16);
            this.lblWeightResult.Name = "lblWeightResult";
            this.lblWeightResult.Size = new System.Drawing.Size(46, 22);
            this.lblWeightResult.TabIndex = 0;
            this.lblWeightResult.Text = "Вес:";
            // 
            // pnlFormula
            // 
            this.pnlFormula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormula.Controls.Add(this.pnlTotal);
            this.pnlFormula.Controls.Add(this.label4);
            this.pnlFormula.Controls.Add(this.lblX1);
            this.pnlFormula.Controls.Add(this.label3);
            this.pnlFormula.Controls.Add(this.label2);
            this.pnlFormula.Controls.Add(this.label1);
            this.pnlFormula.Controls.Add(this.lblFormula);
            this.pnlFormula.Location = new System.Drawing.Point(12, 196);
            this.pnlFormula.Name = "pnlFormula";
            this.pnlFormula.Size = new System.Drawing.Size(385, 219);
            this.pnlFormula.TabIndex = 4;
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotal.Controls.Add(this.pictureBox1);
            this.pnlTotal.Controls.Add(this.lblPrice);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Location = new System.Drawing.Point(3, 89);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(377, 125);
            this.pnlTotal.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator.Properties.Resources.стоимость2;
            this.pictureBox1.Location = new System.Drawing.Point(264, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(36, 50);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(87, 54);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "0 ₽";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotal.Location = new System.Drawing.Point(3, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(232, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "ИТОГОВАЯ СТОИМОСТЬ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(86, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "0 кг × 120 ₽/кг + 300 ₽ = 300 ₽";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX1.Location = new System.Drawing.Point(235, 46);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(17, 18);
            this.lblX1.TabIndex = 8;
            this.lblX1.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(255, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Страховка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(128, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Коэффициент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вес";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.BackColor = System.Drawing.SystemColors.Control;
            this.lblFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormula.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFormula.Location = new System.Drawing.Point(22, 11);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(174, 22);
            this.lblFormula.TabIndex = 0;
            this.lblFormula.Text = "Формула расчёта";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(38, 433);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(121, 39);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Новый расчёт";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(251, 433);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbMoney
            // 
            this.pbMoney.Image = global::Calculator.Properties.Resources.money;
            this.pbMoney.Location = new System.Drawing.Point(12, 12);
            this.pbMoney.Name = "pbMoney";
            this.pbMoney.Size = new System.Drawing.Size(67, 63);
            this.pbMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMoney.TabIndex = 2;
            this.pbMoney.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 484);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pnlFormula);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pbMoney);
            this.Controls.Add(this.lblResultSub);
            this.Controls.Add(this.lblResultTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(427, 531);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стоимость пересылки";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlFormula.ResumeLayout(false);
            this.pnlFormula.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblResultSub;
        private System.Windows.Forms.PictureBox pbMoney;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label lblWeightResult;
        private System.Windows.Forms.Label lblWeightValue;
        private System.Windows.Forms.Label lblSizeValue;
        private System.Windows.Forms.Label lblSizeResult;
        private System.Windows.Forms.Panel pnlFormula;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
