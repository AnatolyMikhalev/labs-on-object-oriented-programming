namespace _1
{
    partial class CreateFigures
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.LineButton = new System.Windows.Forms.RadioButton();
            this.RectangleButton = new System.Windows.Forms.RadioButton();
            this.CircleButton = new System.Windows.Forms.RadioButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Radius = new System.Windows.Forms.TextBox();
            this.X1coord = new System.Windows.Forms.TextBox();
            this.Y1coord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X2coord = new System.Windows.Forms.TextBox();
            this.Y2coord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateSetButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.textBoxDX = new System.Windows.Forms.TextBox();
            this.textBoxDY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dxcoord = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CreateRandomButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.Window;
            this.picture.Location = new System.Drawing.Point(194, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(742, 505);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // LineButton
            // 
            this.LineButton.AutoSize = true;
            this.LineButton.Location = new System.Drawing.Point(12, 12);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(57, 17);
            this.LineButton.TabIndex = 1;
            this.LineButton.TabStop = true;
            this.LineButton.Text = "Линия";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.CheckedChanged += new System.EventHandler(this.CheckedFigures);
            // 
            // RectangleButton
            // 
            this.RectangleButton.AutoSize = true;
            this.RectangleButton.Location = new System.Drawing.Point(12, 35);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(105, 17);
            this.RectangleButton.TabIndex = 2;
            this.RectangleButton.TabStop = true;
            this.RectangleButton.Text = "Прямоугольник";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.CheckedChanged += new System.EventHandler(this.CheckedFigures);
            // 
            // CircleButton
            // 
            this.CircleButton.AutoSize = true;
            this.CircleButton.Location = new System.Drawing.Point(12, 58);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(48, 17);
            this.CircleButton.TabIndex = 3;
            this.CircleButton.TabStop = true;
            this.CircleButton.Text = "Круг";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.CheckedChanged += new System.EventHandler(this.CheckedFigures);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 91);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(176, 95);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 13;
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(12, 270);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(48, 20);
            this.Radius.TabIndex = 18;
            // 
            // X1coord
            // 
            this.X1coord.Location = new System.Drawing.Point(12, 192);
            this.X1coord.Name = "X1coord";
            this.X1coord.Size = new System.Drawing.Size(48, 20);
            this.X1coord.TabIndex = 19;
            // 
            // Y1coord
            // 
            this.Y1coord.Location = new System.Drawing.Point(93, 192);
            this.Y1coord.Name = "Y1coord";
            this.Y1coord.Size = new System.Drawing.Size(48, 20);
            this.Y1coord.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Y";
            // 
            // X2coord
            // 
            this.X2coord.Location = new System.Drawing.Point(12, 218);
            this.X2coord.Name = "X2coord";
            this.X2coord.Size = new System.Drawing.Size(48, 20);
            this.X2coord.TabIndex = 25;
            // 
            // Y2coord
            // 
            this.Y2coord.Location = new System.Drawing.Point(93, 218);
            this.Y2coord.Name = "Y2coord";
            this.Y2coord.Size = new System.Drawing.Size(48, 20);
            this.Y2coord.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Y2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Радиус";
            // 
            // CreateSetButton
            // 
            this.CreateSetButton.Location = new System.Drawing.Point(12, 296);
            this.CreateSetButton.Name = "CreateSetButton";
            this.CreateSetButton.Size = new System.Drawing.Size(85, 23);
            this.CreateSetButton.TabIndex = 30;
            this.CreateSetButton.Text = "Создать";
            this.CreateSetButton.UseVisualStyleBackColor = true;
            this.CreateSetButton.Click += new System.EventHandler(this.CreateSetButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(103, 354);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(85, 23);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(12, 325);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(85, 23);
            this.MoveButton.TabIndex = 32;
            this.MoveButton.Text = "Переместить";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // textBoxDX
            // 
            this.textBoxDX.Location = new System.Drawing.Point(12, 244);
            this.textBoxDX.Name = "textBoxDX";
            this.textBoxDX.Size = new System.Drawing.Size(48, 20);
            this.textBoxDX.TabIndex = 33;
            // 
            // textBoxDY
            // 
            this.textBoxDY.Location = new System.Drawing.Point(93, 244);
            this.textBoxDY.Name = "textBoxDY";
            this.textBoxDY.Size = new System.Drawing.Size(48, 20);
            this.textBoxDY.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "ΔY";
            // 
            // dxcoord
            // 
            this.dxcoord.AutoSize = true;
            this.dxcoord.Location = new System.Drawing.Point(67, 247);
            this.dxcoord.Name = "dxcoord";
            this.dxcoord.Size = new System.Drawing.Size(21, 13);
            this.dxcoord.TabIndex = 36;
            this.dxcoord.Text = "ΔX";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 354);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(85, 23);
            this.RemoveButton.TabIndex = 37;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // CreateRandomButton
            // 
            this.CreateRandomButton.Location = new System.Drawing.Point(103, 296);
            this.CreateRandomButton.Name = "CreateRandomButton";
            this.CreateRandomButton.Size = new System.Drawing.Size(85, 52);
            this.CreateRandomButton.TabIndex = 38;
            this.CreateRandomButton.Text = "Создать случайно";
            this.CreateRandomButton.UseVisualStyleBackColor = true;
            this.CreateRandomButton.Click += new System.EventHandler(this.CreateRandomButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "label7";
            // 
            // CreateFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 529);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CreateRandomButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.dxcoord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDY);
            this.Controls.Add(this.textBoxDX);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CreateSetButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Y2coord);
            this.Controls.Add(this.X2coord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y1coord);
            this.Controls.Add(this.X1coord);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateFigures";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.RadioButton LineButton;
        private System.Windows.Forms.RadioButton RectangleButton;
        private System.Windows.Forms.RadioButton CircleButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.TextBox X1coord;
        private System.Windows.Forms.TextBox Y1coord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox X2coord;
        private System.Windows.Forms.TextBox Y2coord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CreateSetButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.TextBox textBoxDX;
        private System.Windows.Forms.TextBox textBoxDY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dxcoord;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CreateRandomButton;
        private System.Windows.Forms.Label label7;
    }
}

