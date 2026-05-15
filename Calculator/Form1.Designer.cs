namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlWeight = new System.Windows.Forms.Panel();
            this.lblWeight = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.pnlSize = new System.Windows.Forms.Panel();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pbBox = new System.Windows.Forms.PictureBox();
            this.pbSize = new System.Windows.Forms.PictureBox();
            this.pbWeight = new System.Windows.Forms.PictureBox();
            this.pnlWeight.SuspendLayout();
            this.pnlSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(132, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "КАЛЬКУЛЯТОР ПЕРЕСЫЛКИ";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(132, 41);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(241, 16);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Укажите параметры вашей посылки";
            this.lblSubtitle.Click += new System.EventHandler(this.lblSubtitle_Click);
            // 
            // pnlWeight
            // 
            this.pnlWeight.BackColor = System.Drawing.Color.White;
            this.pnlWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWeight.Controls.Add(this.pbWeight);
            this.pnlWeight.Controls.Add(this.tbWeight);
            this.pnlWeight.Controls.Add(this.lblWeight);
            this.pnlWeight.Location = new System.Drawing.Point(12, 91);
            this.pnlWeight.Name = "pnlWeight";
            this.pnlWeight.Size = new System.Drawing.Size(385, 87);
            this.pnlWeight.TabIndex = 2;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(91, 19);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(116, 16);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Введите вес (кг):";
            // 
            // tbWeight
            // 
            this.tbWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWeight.Location = new System.Drawing.Point(94, 50);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(192, 22);
            this.tbWeight.TabIndex = 1;
            // 
            // pnlSize
            // 
            this.pnlSize.BackColor = System.Drawing.Color.White;
            this.pnlSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSize.Controls.Add(this.pbSize);
            this.pnlSize.Controls.Add(this.lblX2);
            this.pnlSize.Controls.Add(this.lblX1);
            this.pnlSize.Controls.Add(this.tbHeight);
            this.pnlSize.Controls.Add(this.tbWidth);
            this.pnlSize.Controls.Add(this.tbLength);
            this.pnlSize.Controls.Add(this.lblHeight);
            this.pnlSize.Controls.Add(this.lblWidth);
            this.pnlSize.Controls.Add(this.lblLength);
            this.pnlSize.Controls.Add(this.lblSize);
            this.pnlSize.Location = new System.Drawing.Point(12, 199);
            this.pnlSize.Name = "pnlSize";
            this.pnlSize.Size = new System.Drawing.Size(385, 157);
            this.pnlSize.TabIndex = 3;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(91, 24);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(154, 16);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Введите размеры (см):";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(57, 74);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(48, 16);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Длина";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(147, 74);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(58, 16);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Ширина";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(252, 74);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(55, 16);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Высота";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(60, 105);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(63, 22);
            this.tbLength.TabIndex = 4;
            this.tbLength.TextChanged += new System.EventHandler(this.tbLength_TextChanged);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(150, 105);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(79, 22);
            this.tbWidth.TabIndex = 5;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(255, 105);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(72, 22);
            this.tbHeight.TabIndex = 6;
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(129, 111);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(14, 16);
            this.lblX1.TabIndex = 7;
            this.lblX1.Text = "×";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(235, 111);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(14, 16);
            this.lblX2.TabIndex = 8;
            this.lblX2.Text = "×";
            this.lblX2.Click += new System.EventHandler(this.lblX2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(91, 375);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(238, 52);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Рассчитать стоимость";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // pbBox
            // 
            this.pbBox.Image = global::Calculator.Properties.Resources.box;
            this.pbBox.Location = new System.Drawing.Point(12, 8);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(114, 68);
            this.pbBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBox.TabIndex = 10;
            this.pbBox.TabStop = false;
            // 
            // pbSize
            // 
            this.pbSize.BackColor = System.Drawing.Color.Transparent;
            this.pbSize.Image = global::Calculator.Properties.Resources.куб;
            this.pbSize.Location = new System.Drawing.Point(19, 15);
            this.pbSize.Name = "pbSize";
            this.pbSize.Size = new System.Drawing.Size(66, 56);
            this.pbSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSize.TabIndex = 12;
            this.pbSize.TabStop = false;
            // 
            // pbWeight
            // 
            this.pbWeight.BackColor = System.Drawing.Color.Transparent;
            this.pbWeight.Image = global::Calculator.Properties.Resources.весы;
            this.pbWeight.Location = new System.Drawing.Point(19, 19);
            this.pbWeight.Name = "pbWeight";
            this.pbWeight.Size = new System.Drawing.Size(57, 49);
            this.pbWeight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWeight.TabIndex = 11;
            this.pbWeight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 453);
            this.Controls.Add(this.pbBox);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pnlSize);
            this.Controls.Add(this.pnlWeight);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры отправления";
            this.pnlWeight.ResumeLayout(false);
            this.pnlWeight.PerformLayout();
            this.pnlSize.ResumeLayout(false);
            this.pnlSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlWeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Panel pnlSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox pbBox;
        private System.Windows.Forms.PictureBox pbWeight;
        private System.Windows.Forms.PictureBox pbSize;
    }
}

