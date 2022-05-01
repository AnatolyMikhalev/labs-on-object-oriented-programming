
namespace MainResolve
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
            this.RotateButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.RadioButton();
            this.RombButton = new System.Windows.Forms.RadioButton();
            this.EllipseButton = new System.Windows.Forms.RadioButton();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ycoord = new System.Windows.Forms.TextBox();
            this.Xcoord = new System.Windows.Forms.TextBox();
            this.CircleButton = new System.Windows.Forms.RadioButton();
            this.BoxButton = new System.Windows.Forms.RadioButton();
            this.LineButton = new System.Windows.Forms.RadioButton();
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.AllFiguresButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(12, 396);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(85, 41);
            this.RotateButton.TabIndex = 87;
            this.RotateButton.Text = "Поворот эллипсов";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.AutoSize = true;
            this.RectangleButton.Location = new System.Drawing.Point(12, 81);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(105, 17);
            this.RectangleButton.TabIndex = 86;
            this.RectangleButton.Text = "Прямоугольник";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.CheckedChanged += new System.EventHandler(this.Figure_Selection);
            // 
            // RombButton
            // 
            this.RombButton.AutoSize = true;
            this.RombButton.Location = new System.Drawing.Point(12, 150);
            this.RombButton.Name = "RombButton";
            this.RombButton.Size = new System.Drawing.Size(52, 17);
            this.RombButton.TabIndex = 85;
            this.RombButton.Text = "Ромб";
            this.RombButton.UseVisualStyleBackColor = true;
            this.RombButton.CheckedChanged += new System.EventHandler(this.Figure_Selection);
            // 
            // EllipseButton
            // 
            this.EllipseButton.AutoSize = true;
            this.EllipseButton.Location = new System.Drawing.Point(12, 127);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(62, 17);
            this.EllipseButton.TabIndex = 84;
            this.EllipseButton.Text = "Эллипс";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.CheckedChanged += new System.EventHandler(this.Figure_Selection);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 367);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 23);
            this.DeleteButton.TabIndex = 76;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(12, 309);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(85, 23);
            this.buttonMove.TabIndex = 71;
            this.buttonMove.Text = "Переместить";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 338);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(85, 23);
            this.ClearButton.TabIndex = 70;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 251);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(85, 23);
            this.buttonCreate.TabIndex = 69;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "X";
            // 
            // Ycoord
            // 
            this.Ycoord.Location = new System.Drawing.Point(12, 209);
            this.Ycoord.Name = "Ycoord";
            this.Ycoord.Size = new System.Drawing.Size(48, 20);
            this.Ycoord.TabIndex = 61;
            // 
            // Xcoord
            // 
            this.Xcoord.Location = new System.Drawing.Point(12, 183);
            this.Xcoord.Name = "Xcoord";
            this.Xcoord.Size = new System.Drawing.Size(48, 20);
            this.Xcoord.TabIndex = 60;
            // 
            // CircleButton
            // 
            this.CircleButton.AutoSize = true;
            this.CircleButton.Location = new System.Drawing.Point(12, 104);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(48, 17);
            this.CircleButton.TabIndex = 57;
            this.CircleButton.Text = "Круг";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.CheckedChanged += new System.EventHandler(this.Figure_Selection);
            // 
            // BoxButton
            // 
            this.BoxButton.AutoSize = true;
            this.BoxButton.Location = new System.Drawing.Point(12, 58);
            this.BoxButton.Name = "BoxButton";
            this.BoxButton.Size = new System.Drawing.Size(67, 17);
            this.BoxButton.TabIndex = 56;
            this.BoxButton.Text = "Квадрат";
            this.BoxButton.UseVisualStyleBackColor = true;
            this.BoxButton.CheckedChanged += new System.EventHandler(this.Figure_Selection);
            // 
            // LineButton
            // 
            this.LineButton.AutoSize = true;
            this.LineButton.Location = new System.Drawing.Point(12, 35);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(57, 17);
            this.LineButton.TabIndex = 55;
            this.LineButton.Text = "Линия";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.CheckedChanged += new System.EventHandler(this.Figure_Selection);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.Window;
            this.picture.Location = new System.Drawing.Point(123, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(859, 555);
            this.picture.TabIndex = 54;
            this.picture.TabStop = false;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(12, 280);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(85, 23);
            this.buttonShow.TabIndex = 88;
            this.buttonShow.Text = "Отобразить";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // AllFiguresButton
            // 
            this.AllFiguresButton.AutoSize = true;
            this.AllFiguresButton.Location = new System.Drawing.Point(12, 12);
            this.AllFiguresButton.Name = "AllFiguresButton";
            this.AllFiguresButton.Size = new System.Drawing.Size(85, 17);
            this.AllFiguresButton.TabIndex = 89;
            this.AllFiguresButton.Text = "Все фигуры";
            this.AllFiguresButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 579);
            this.Controls.Add(this.AllFiguresButton);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.RombButton);
            this.Controls.Add(this.EllipseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ycoord);
            this.Controls.Add(this.Xcoord);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.BoxButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.RadioButton RectangleButton;
        private System.Windows.Forms.RadioButton RombButton;
        private System.Windows.Forms.RadioButton EllipseButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ycoord;
        private System.Windows.Forms.TextBox Xcoord;
        private System.Windows.Forms.RadioButton CircleButton;
        private System.Windows.Forms.RadioButton BoxButton;
        private System.Windows.Forms.RadioButton LineButton;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.RadioButton AllFiguresButton;
    }
}

