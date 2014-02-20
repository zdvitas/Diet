namespace Diet
{
    partial class form_add_dish
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_kkal_total = new System.Windows.Forms.TextBox();
            this.text_carbo_total = new System.Windows.Forms.TextBox();
            this.text_prot_total = new System.Windows.Forms.TextBox();
            this.text_fats_total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_mas = new System.Windows.Forms.Label();
            this.text_mas = new System.Windows.Forms.NumericUpDown();
            this.btn_select = new System.Windows.Forms.Button();
            this.text_kkal = new System.Windows.Forms.TextBox();
            this.label_kkal = new System.Windows.Forms.Label();
            this.text_carbo = new System.Windows.Forms.TextBox();
            this.label_carbo = new System.Windows.Forms.Label();
            this.text_prot = new System.Windows.Forms.TextBox();
            this.label_prot = new System.Windows.Forms.Label();
            this.text_fats = new System.Windows.Forms.TextBox();
            this.label_fats = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_mas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_kkal_total);
            this.groupBox1.Controls.Add(this.text_carbo_total);
            this.groupBox1.Controls.Add(this.text_prot_total);
            this.groupBox1.Controls.Add(this.text_fats_total);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_mas);
            this.groupBox1.Controls.Add(this.text_mas);
            this.groupBox1.Controls.Add(this.btn_select);
            this.groupBox1.Controls.Add(this.text_kkal);
            this.groupBox1.Controls.Add(this.label_kkal);
            this.groupBox1.Controls.Add(this.text_carbo);
            this.groupBox1.Controls.Add(this.label_carbo);
            this.groupBox1.Controls.Add(this.text_prot);
            this.groupBox1.Controls.Add(this.label_prot);
            this.groupBox1.Controls.Add(this.text_fats);
            this.groupBox1.Controls.Add(this.label_fats);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1034, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Продукты";
            // 
            // text_kkal_total
            // 
            this.text_kkal_total.Location = new System.Drawing.Point(676, 108);
            this.text_kkal_total.Name = "text_kkal_total";
            this.text_kkal_total.Size = new System.Drawing.Size(100, 23);
            this.text_kkal_total.TabIndex = 17;
            // 
            // text_carbo_total
            // 
            this.text_carbo_total.Location = new System.Drawing.Point(544, 108);
            this.text_carbo_total.Name = "text_carbo_total";
            this.text_carbo_total.Size = new System.Drawing.Size(100, 23);
            this.text_carbo_total.TabIndex = 16;
            // 
            // text_prot_total
            // 
            this.text_prot_total.Location = new System.Drawing.Point(412, 108);
            this.text_prot_total.Name = "text_prot_total";
            this.text_prot_total.Size = new System.Drawing.Size(100, 23);
            this.text_prot_total.TabIndex = 15;
            // 
            // text_fats_total
            // 
            this.text_fats_total.Location = new System.Drawing.Point(279, 108);
            this.text_fats_total.Name = "text_fats_total";
            this.text_fats_total.Size = new System.Drawing.Size(100, 23);
            this.text_fats_total.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Итого:";
            // 
            // label_mas
            // 
            this.label_mas.AutoSize = true;
            this.label_mas.Location = new System.Drawing.Point(801, 65);
            this.label_mas.Name = "label_mas";
            this.label_mas.Size = new System.Drawing.Size(76, 17);
            this.label_mas.TabIndex = 12;
            this.label_mas.Text = "Масса(гр.)";
            // 
            // text_mas
            // 
            this.text_mas.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.text_mas.Location = new System.Drawing.Point(804, 86);
            this.text_mas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.text_mas.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.text_mas.Name = "text_mas";
            this.text_mas.Size = new System.Drawing.Size(86, 23);
            this.text_mas.TabIndex = 11;
            this.text_mas.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.text_mas.ValueChanged += new System.EventHandler(this.text_mas_ValueChanged);
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
            this.btn_select.Location = new System.Drawing.Point(912, 74);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(102, 44);
            this.btn_select.TabIndex = 10;
            this.btn_select.Text = "Добавить";
            this.btn_select.UseVisualStyleBackColor = true;
            // 
            // text_kkal
            // 
            this.text_kkal.Location = new System.Drawing.Point(676, 65);
            this.text_kkal.Name = "text_kkal";
            this.text_kkal.Size = new System.Drawing.Size(100, 23);
            this.text_kkal.TabIndex = 9;
            // 
            // label_kkal
            // 
            this.label_kkal.AutoSize = true;
            this.label_kkal.Location = new System.Drawing.Point(673, 33);
            this.label_kkal.Name = "label_kkal";
            this.label_kkal.Size = new System.Drawing.Size(40, 17);
            this.label_kkal.TabIndex = 8;
            this.label_kkal.Text = "Ккал";
            // 
            // text_carbo
            // 
            this.text_carbo.Location = new System.Drawing.Point(544, 65);
            this.text_carbo.Name = "text_carbo";
            this.text_carbo.Size = new System.Drawing.Size(100, 23);
            this.text_carbo.TabIndex = 7;
            // 
            // label_carbo
            // 
            this.label_carbo.AutoSize = true;
            this.label_carbo.Location = new System.Drawing.Point(541, 33);
            this.label_carbo.Name = "label_carbo";
            this.label_carbo.Size = new System.Drawing.Size(71, 17);
            this.label_carbo.TabIndex = 6;
            this.label_carbo.Text = "Углеводы";
            // 
            // text_prot
            // 
            this.text_prot.Location = new System.Drawing.Point(412, 65);
            this.text_prot.Name = "text_prot";
            this.text_prot.Size = new System.Drawing.Size(100, 23);
            this.text_prot.TabIndex = 5;
            // 
            // label_prot
            // 
            this.label_prot.AutoSize = true;
            this.label_prot.Location = new System.Drawing.Point(409, 33);
            this.label_prot.Name = "label_prot";
            this.label_prot.Size = new System.Drawing.Size(48, 17);
            this.label_prot.TabIndex = 4;
            this.label_prot.Text = "Белки";
            // 
            // text_fats
            // 
            this.text_fats.Location = new System.Drawing.Point(279, 65);
            this.text_fats.Name = "text_fats";
            this.text_fats.Size = new System.Drawing.Size(100, 23);
            this.text_fats.TabIndex = 3;
            // 
            // label_fats
            // 
            this.label_fats.AutoSize = true;
            this.label_fats.Location = new System.Drawing.Point(276, 33);
            this.label_fats.Name = "label_fats";
            this.label_fats.Size = new System.Drawing.Size(47, 17);
            this.label_fats.TabIndex = 2;
            this.label_fats.Text = "Жиры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите продукт";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(13, 65);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // form_add_dish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 483);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_add_dish";
            this.Text = "Добавить рецепт";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_mas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_kkal_total;
        private System.Windows.Forms.TextBox text_carbo_total;
        private System.Windows.Forms.TextBox text_prot_total;
        private System.Windows.Forms.TextBox text_fats_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_mas;
        private System.Windows.Forms.NumericUpDown text_mas;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox text_kkal;
        private System.Windows.Forms.Label label_kkal;
        private System.Windows.Forms.TextBox text_carbo;
        private System.Windows.Forms.Label label_carbo;
        private System.Windows.Forms.TextBox text_prot;
        private System.Windows.Forms.Label label_prot;
        private System.Windows.Forms.TextBox text_fats;
        private System.Windows.Forms.Label label_fats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}