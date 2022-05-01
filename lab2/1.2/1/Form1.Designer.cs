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
            this.Line = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.DataObjects = new System.Windows.Forms.ListBox();
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.Window;
            this.picture.Location = new System.Drawing.Point(202, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(734, 505);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(12, 12);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(57, 17);
            this.Line.TabIndex = 1;
            this.Line.TabStop = true;
            this.Line.Text = "Линия";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.CheckedChanged += new System.EventHandler(this.CheckedFigures);
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(12, 35);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(105, 17);
            this.Rectangle.TabIndex = 2;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Прямоугольник";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.CheckedChanged += new System.EventHandler(this.CheckedFigures);
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(12, 58);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(48, 17);
            this.Circle.TabIndex = 3;
            this.Circle.TabStop = true;
            this.Circle.Text = "Круг";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.CheckedChanged += new System.EventHandler(this.CheckedFigures);
            // 
            // DataObjects
            // 
            this.DataObjects.FormattingEnabled = true;
            this.DataObjects.Location = new System.Drawing.Point(-4, 91);
            this.DataObjects.Name = "DataObjects";
            this.DataObjects.Size = new System.Drawing.Size(200, 95);
            this.DataObjects.Sorted = true;
            this.DataObjects.TabIndex = 13;
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(12, 244);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(97, 20);
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
            this.label6.Location = new System.Drawing.Point(115, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Радиус";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 270);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(85, 23);
            this.CreateButton.TabIndex = 30;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.BuildFigures);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 299);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(85, 23);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CreateFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 529);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CreateButton);
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
            this.Controls.Add(this.DataObjects);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Line);
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
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.ListBox DataObjects;
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
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

