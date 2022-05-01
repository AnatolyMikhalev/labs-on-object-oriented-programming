namespace lab5
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
            this.BoxButton = new System.Windows.Forms.RadioButton();
            this.CircleButton = new System.Windows.Forms.RadioButton();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CreateRandomButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EllipseButton = new System.Windows.Forms.RadioButton();
            this.RombButton = new System.Windows.Forms.RadioButton();
            this.RectangleButton = new System.Windows.Forms.RadioButton();
            this.RotateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.Window;
            this.picture.Location = new System.Drawing.Point(194, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(742, 538);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // LineButton
            // 
            this.LineButton.AutoCheck = false;
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
            // BoxButton
            // 
            this.BoxButton.AutoSize = true;
            this.BoxButton.Location = new System.Drawing.Point(12, 35);
            this.BoxButton.Name = "BoxButton";
            this.BoxButton.Size = new System.Drawing.Size(67, 17);
            this.BoxButton.TabIndex = 2;
            this.BoxButton.TabStop = true;
            this.BoxButton.Text = "Квадрат";
            this.BoxButton.UseVisualStyleBackColor = true;
            this.BoxButton.CheckedChanged += new System.EventHandler(this.CheckedFigures);
            // 
            // CircleButton
            // 
            this.CircleButton.AutoSize = true;
            this.CircleButton.Location = new System.Drawing.Point(12, 81);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(48, 17);
            this.CircleButton.TabIndex = 3;
            this.CircleButton.TabStop = true;
            this.CircleButton.Text = "Круг";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.CheckedChanged += new System.EventHandler(this.CheckedFigures);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 452);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(85, 23);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(12, 353);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(85, 64);
            this.MoveButton.TabIndex = 32;
            this.MoveButton.Text = "Переместить В новую базовую точку";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 423);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(85, 23);
            this.RemoveButton.TabIndex = 37;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CreateRandomButton
            // 
            this.CreateRandomButton.Location = new System.Drawing.Point(12, 295);
            this.CreateRandomButton.Name = "CreateRandomButton";
            this.CreateRandomButton.Size = new System.Drawing.Size(85, 23);
            this.CreateRandomButton.TabIndex = 38;
            this.CreateRandomButton.Text = "Создать";
            this.CreateRandomButton.UseVisualStyleBackColor = true;
            this.CreateRandomButton.Click += new System.EventHandler(this.CreateRandomButton_Click);
            // 
            // label7
            // 
            // EllipseButton
            // 
            this.EllipseButton.AutoSize = true;
            this.EllipseButton.Location = new System.Drawing.Point(12, 127);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(62, 17);
            this.EllipseButton.TabIndex = 50;
            this.EllipseButton.TabStop = true;
            this.EllipseButton.Text = "Эллипс";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.CheckedChanged += new System.EventHandler(this.CheckedFigures);
            // 
            // RombButton
            // 
            this.RombButton.AutoSize = true;
            this.RombButton.Location = new System.Drawing.Point(12, 104);
            this.RombButton.Name = "RombButton";
            this.RombButton.Size = new System.Drawing.Size(52, 17);
            this.RombButton.TabIndex = 51;
            this.RombButton.TabStop = true;
            this.RombButton.Text = "Ромб";
            this.RombButton.UseVisualStyleBackColor = true;
            this.RombButton.CheckedChanged += new System.EventHandler(this.CheckedFigures);
            // 
            // RectangleButton
            // 
            this.RectangleButton.AutoSize = true;
            this.RectangleButton.Location = new System.Drawing.Point(12, 58);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(105, 17);
            this.RectangleButton.TabIndex = 52;
            this.RectangleButton.TabStop = true;
            this.RectangleButton.Text = "Прямоугольник";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.CheckedChanged += new System.EventHandler(this.CheckedFigures);
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(12, 481);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(85, 41);
            this.RotateButton.TabIndex = 53;
            this.RotateButton.Text = "Поворот эллипсов";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 54;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Y:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 150);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 58;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Все фигуры";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(12, 324);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(85, 23);
            this.buttonShow.TabIndex = 59;
            this.buttonShow.Text = "Отобразить";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // CreateFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 579);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.RombButton);
            this.Controls.Add(this.EllipseButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CreateRandomButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.BoxButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateFigures";
            this.Load += new System.EventHandler(this.CreateFigures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.RadioButton LineButton;
        private System.Windows.Forms.RadioButton BoxButton;
        private System.Windows.Forms.RadioButton CircleButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CreateRandomButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton EllipseButton;
        private System.Windows.Forms.RadioButton RombButton;
        private System.Windows.Forms.RadioButton RectangleButton;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonShow;
    }
}

