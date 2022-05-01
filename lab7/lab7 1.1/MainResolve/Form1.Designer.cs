
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ycoord = new System.Windows.Forms.TextBox();
            this.Xcoord = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonShow1 = new System.Windows.Forms.Button();
            this.DeleteButton1 = new System.Windows.Forms.Button();
            this.buttonMove1 = new System.Windows.Forms.Button();
            this.ClearButton1 = new System.Windows.Forms.Button();
            this.buttonCreate1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Y1coord = new System.Windows.Forms.TextBox();
            this.X1coord = new System.Windows.Forms.TextBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.buttonCreateMass = new System.Windows.Forms.Button();
            this.buttonCreateMass1 = new System.Windows.Forms.Button();
            this.buttonCreateRandomFigure = new System.Windows.Forms.Button();
            this.buttonCreateRandomFigure1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 512);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 23);
            this.DeleteButton.TabIndex = 76;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(12, 454);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(85, 23);
            this.buttonMove.TabIndex = 71;
            this.buttonMove.Text = "Переместить";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 483);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(85, 23);
            this.ClearButton.TabIndex = 70;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 235);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(85, 50);
            this.buttonCreate.TabIndex = 69;
            this.buttonCreate.Text = "Создать пустой массив";
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
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.Window;
            this.picture.Location = new System.Drawing.Point(123, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(355, 555);
            this.picture.TabIndex = 54;
            this.picture.TabStop = false;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(12, 425);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(85, 23);
            this.buttonShow.TabIndex = 88;
            this.buttonShow.Text = "Отобразить";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonShow1
            // 
            this.buttonShow1.Location = new System.Drawing.Point(499, 425);
            this.buttonShow1.Name = "buttonShow1";
            this.buttonShow1.Size = new System.Drawing.Size(85, 23);
            this.buttonShow1.TabIndex = 106;
            this.buttonShow1.Text = "Отобразить";
            this.buttonShow1.UseVisualStyleBackColor = true;
            this.buttonShow1.Click += new System.EventHandler(this.buttonShow1_Click);
            // 
            // DeleteButton1
            // 
            this.DeleteButton1.Location = new System.Drawing.Point(499, 512);
            this.DeleteButton1.Name = "DeleteButton1";
            this.DeleteButton1.Size = new System.Drawing.Size(85, 23);
            this.DeleteButton1.TabIndex = 101;
            this.DeleteButton1.Text = "Удалить";
            this.DeleteButton1.UseVisualStyleBackColor = true;
            this.DeleteButton1.Click += new System.EventHandler(this.DeleteButton1_Click);
            // 
            // buttonMove1
            // 
            this.buttonMove1.Location = new System.Drawing.Point(499, 454);
            this.buttonMove1.Name = "buttonMove1";
            this.buttonMove1.Size = new System.Drawing.Size(85, 23);
            this.buttonMove1.TabIndex = 100;
            this.buttonMove1.Text = "Переместить";
            this.buttonMove1.UseVisualStyleBackColor = true;
            this.buttonMove1.Click += new System.EventHandler(this.buttonMove1_Click);
            // 
            // ClearButton1
            // 
            this.ClearButton1.Location = new System.Drawing.Point(499, 483);
            this.ClearButton1.Name = "ClearButton1";
            this.ClearButton1.Size = new System.Drawing.Size(85, 23);
            this.ClearButton1.TabIndex = 99;
            this.ClearButton1.Text = "Очистить";
            this.ClearButton1.UseVisualStyleBackColor = true;
            this.ClearButton1.Click += new System.EventHandler(this.ClearButton1_Click);
            // 
            // buttonCreate1
            // 
            this.buttonCreate1.Location = new System.Drawing.Point(499, 235);
            this.buttonCreate1.Name = "buttonCreate1";
            this.buttonCreate1.Size = new System.Drawing.Size(85, 50);
            this.buttonCreate1.TabIndex = 98;
            this.buttonCreate1.Text = "Создать пустой массив";
            this.buttonCreate1.UseVisualStyleBackColor = true;
            this.buttonCreate1.Click += new System.EventHandler(this.buttonCreate1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "X";
            // 
            // Y1coord
            // 
            this.Y1coord.Location = new System.Drawing.Point(499, 209);
            this.Y1coord.Name = "Y1coord";
            this.Y1coord.Size = new System.Drawing.Size(48, 20);
            this.Y1coord.TabIndex = 95;
            // 
            // X1coord
            // 
            this.X1coord.Location = new System.Drawing.Point(499, 183);
            this.X1coord.Name = "X1coord";
            this.X1coord.Size = new System.Drawing.Size(48, 20);
            this.X1coord.TabIndex = 94;
            // 
            // picture1
            // 
            this.picture1.BackColor = System.Drawing.SystemColors.Window;
            this.picture1.Location = new System.Drawing.Point(610, 12);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(372, 555);
            this.picture1.TabIndex = 90;
            this.picture1.TabStop = false;
            // 
            // buttonCreateMass
            // 
            this.buttonCreateMass.Location = new System.Drawing.Point(12, 291);
            this.buttonCreateMass.Name = "buttonCreateMass";
            this.buttonCreateMass.Size = new System.Drawing.Size(85, 61);
            this.buttonCreateMass.TabIndex = 107;
            this.buttonCreateMass.Text = "Создать массив из 21 фигуры";
            this.buttonCreateMass.UseVisualStyleBackColor = true;
            this.buttonCreateMass.Click += new System.EventHandler(this.buttonCreateMass_Click);
            // 
            // buttonCreateMass1
            // 
            this.buttonCreateMass1.Location = new System.Drawing.Point(499, 291);
            this.buttonCreateMass1.Name = "buttonCreateMass1";
            this.buttonCreateMass1.Size = new System.Drawing.Size(85, 61);
            this.buttonCreateMass1.TabIndex = 108;
            this.buttonCreateMass1.Text = "Создать массив из 21 фигуры";
            this.buttonCreateMass1.UseVisualStyleBackColor = true;
            this.buttonCreateMass1.Click += new System.EventHandler(this.buttonCreateMass1_Click);
            // 
            // buttonCreateRandomFigure
            // 
            this.buttonCreateRandomFigure.Location = new System.Drawing.Point(12, 358);
            this.buttonCreateRandomFigure.Name = "buttonCreateRandomFigure";
            this.buttonCreateRandomFigure.Size = new System.Drawing.Size(85, 61);
            this.buttonCreateRandomFigure.TabIndex = 109;
            this.buttonCreateRandomFigure.Text = "Добваить случайную фигуру";
            this.buttonCreateRandomFigure.UseVisualStyleBackColor = true;
            this.buttonCreateRandomFigure.Click += new System.EventHandler(this.buttonCreateRandomFigure_Click);
            // 
            // buttonCreateRandomFigure1
            // 
            this.buttonCreateRandomFigure1.Location = new System.Drawing.Point(499, 358);
            this.buttonCreateRandomFigure1.Name = "buttonCreateRandomFigure1";
            this.buttonCreateRandomFigure1.Size = new System.Drawing.Size(85, 61);
            this.buttonCreateRandomFigure1.TabIndex = 110;
            this.buttonCreateRandomFigure1.Text = "Добваить случайную фигуру";
            this.buttonCreateRandomFigure1.UseVisualStyleBackColor = true;
            this.buttonCreateRandomFigure1.Click += new System.EventHandler(this.buttonCreateRandomFigure1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 579);
            this.Controls.Add(this.buttonCreateRandomFigure1);
            this.Controls.Add(this.buttonCreateRandomFigure);
            this.Controls.Add(this.buttonCreateMass1);
            this.Controls.Add(this.buttonCreateMass);
            this.Controls.Add(this.buttonShow1);
            this.Controls.Add(this.DeleteButton1);
            this.Controls.Add(this.buttonMove1);
            this.Controls.Add(this.ClearButton1);
            this.Controls.Add(this.buttonCreate1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Y1coord);
            this.Controls.Add(this.X1coord);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ycoord);
            this.Controls.Add(this.Xcoord);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ycoord;
        private System.Windows.Forms.TextBox Xcoord;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonShow1;
        private System.Windows.Forms.Button DeleteButton1;
        private System.Windows.Forms.Button buttonMove1;
        private System.Windows.Forms.Button ClearButton1;
        private System.Windows.Forms.Button buttonCreate1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Y1coord;
        private System.Windows.Forms.TextBox X1coord;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Button buttonCreateMass;
        private System.Windows.Forms.Button buttonCreateMass1;
        private System.Windows.Forms.Button buttonCreateRandomFigure;
        private System.Windows.Forms.Button buttonCreateRandomFigure1;
    }
}

