namespace Diet
{
    partial class form_login
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 186);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пользователь";
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_close.Image = global::Diet.Properties.Resources.btn_1;
            this.btn_close.Location = new System.Drawing.Point(261, 175);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(102, 44);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Закрыть";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_select_MouseDown);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_select_MouseLeave);
            this.btn_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_select_MouseMove);
            // 
            // btn_change
            // 
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_change.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_change.Image = global::Diet.Properties.Resources.btn_1;
            this.btn_change.Location = new System.Drawing.Point(261, 127);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(102, 44);
            this.btn_change.TabIndex = 4;
            this.btn_change.Text = "Изменить";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            this.btn_change.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_select_MouseDown);
            this.btn_change.MouseLeave += new System.EventHandler(this.btn_select_MouseLeave);
            this.btn_change.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_select_MouseMove);
            // 
            // btn_new
            // 
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_new.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_new.Image = global::Diet.Properties.Resources.btn_1;
            this.btn_new.Location = new System.Drawing.Point(261, 79);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(102, 44);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "Новый";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            this.btn_new.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_select_MouseDown);
            this.btn_new.MouseLeave += new System.EventHandler(this.btn_select_MouseLeave);
            this.btn_new.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_select_MouseMove);
            // 
            // btn_select
            // 
            this.btn_select.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_select.FlatAppearance.BorderSize = 0;
            this.btn_select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_select.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_select.Image = global::Diet.Properties.Resources.btn_1;
            this.btn_select.Location = new System.Drawing.Point(261, 29);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(102, 44);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "Выбрать";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            this.btn_select.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_select_MouseDown);
            this.btn_select.MouseLeave += new System.EventHandler(this.btn_select_MouseLeave);
            this.btn_select.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_select_MouseMove);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 238);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите  профиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_close;
    }
}

