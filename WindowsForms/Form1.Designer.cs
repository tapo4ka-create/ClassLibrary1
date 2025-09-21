namespace WindowsForms
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textminExperience = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listOutput = new System.Windows.Forms.ListBox();
            this.numExperience = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(595, 21);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить\r\n";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(76, 415);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(108, 23);
            this.buttonShowAll.TabIndex = 1;
            this.buttonShowAll.Text = "Показать всех";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(210, 76);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(155, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(379, 76);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(162, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(210, 415);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(108, 23);
            this.buttonGroup.TabIndex = 4;
            this.buttonGroup.Text = "Группировать";
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(210, 130);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(155, 23);
            this.buttonFind.TabIndex = 5;
            this.buttonFind.Text = "Найти по стажу";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(637, 415);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button7_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(76, 24);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 7;
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(210, 24);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(155, 20);
            this.textSubject.TabIndex = 8;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(76, 76);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 9;
            // 
            // textminExperience
            // 
            this.textminExperience.Location = new System.Drawing.Point(76, 130);
            this.textminExperience.Name = "textminExperience";
            this.textminExperience.Size = new System.Drawing.Size(100, 20);
            this.textminExperience.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Предмет";
            // 
            // listOutput
            // 
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(76, 159);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(669, 238);
            this.listOutput.TabIndex = 13;
            // 
            // numExperience
            // 
            this.numExperience.Location = new System.Drawing.Point(385, 24);
            this.numExperience.Name = "numExperience";
            this.numExperience.Size = new System.Drawing.Size(156, 20);
            this.numExperience.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Стаж";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Мин. стаж";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numExperience);
            this.Controls.Add(this.listOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textminExperience);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textminExperience;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.NumericUpDown numExperience;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

