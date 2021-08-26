namespace FitnessTracker
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
            this.showCaptureRects = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Panel();
            this.bb = new System.Windows.Forms.Button();
            this.sb = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.co = new System.Windows.Forms.Button();
            this.mp = new System.Windows.Forms.Button();
            this.result_text_box = new System.Windows.Forms.TextBox();
            this.ep = new System.Windows.Forms.Button();
            this.capture_right_button = new System.Windows.Forms.Button();
            this.capture_left_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.capture_height = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.capture_width = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.right_y = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.left_y = new System.Windows.Forms.TextBox();
            this.right_x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.left_x = new System.Windows.Forms.TextBox();
            this.settings_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flopStartX = new System.Windows.Forms.TextBox();
            this.flopStartY = new System.Windows.Forms.TextBox();
            this.showFlopRects = new System.Windows.Forms.Button();
            this.captureFlop = new System.Windows.Forms.Button();
            this.flopTextBox = new System.Windows.Forms.TextBox();
            this.flopWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flopHeight = new System.Windows.Forms.TextBox();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // showCaptureRects
            // 
            this.showCaptureRects.Location = new System.Drawing.Point(326, 66);
            this.showCaptureRects.Name = "showCaptureRects";
            this.showCaptureRects.Size = new System.Drawing.Size(99, 37);
            this.showCaptureRects.TabIndex = 0;
            this.showCaptureRects.Text = "Границы";
            this.showCaptureRects.UseVisualStyleBackColor = true;
            this.showCaptureRects.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Settings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Settings.Controls.Add(this.bb);
            this.Settings.Controls.Add(this.sb);
            this.Settings.Controls.Add(this.btn);
            this.Settings.Controls.Add(this.co);
            this.Settings.Controls.Add(this.mp);
            this.Settings.Controls.Add(this.result_text_box);
            this.Settings.Controls.Add(this.ep);
            this.Settings.Controls.Add(this.capture_right_button);
            this.Settings.Controls.Add(this.capture_left_button);
            this.Settings.Controls.Add(this.button2);
            this.Settings.Controls.Add(this.capture_height);
            this.Settings.Controls.Add(this.label8);
            this.Settings.Controls.Add(this.capture_width);
            this.Settings.Controls.Add(this.label7);
            this.Settings.Controls.Add(this.right_y);
            this.Settings.Controls.Add(this.label5);
            this.Settings.Controls.Add(this.left_y);
            this.Settings.Controls.Add(this.right_x);
            this.Settings.Controls.Add(this.label3);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Controls.Add(this.left_x);
            this.Settings.Controls.Add(this.settings_label);
            this.Settings.Controls.Add(this.showCaptureRects);
            this.Settings.Location = new System.Drawing.Point(1, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(690, 153);
            this.Settings.TabIndex = 1;
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(636, 93);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(44, 23);
            this.bb.TabIndex = 30;
            this.bb.Text = "BB";
            this.bb.UseVisualStyleBackColor = true;
            this.bb.Click += new System.EventHandler(this.bb_Click);
            // 
            // sb
            // 
            this.sb.Location = new System.Drawing.Point(586, 93);
            this.sb.Name = "sb";
            this.sb.Size = new System.Drawing.Size(44, 23);
            this.sb.TabIndex = 29;
            this.sb.Text = "SB";
            this.sb.UseVisualStyleBackColor = true;
            this.sb.Click += new System.EventHandler(this.sb_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(536, 95);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(44, 23);
            this.btn.TabIndex = 28;
            this.btn.Text = "BTN";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // co
            // 
            this.co.Location = new System.Drawing.Point(636, 66);
            this.co.Name = "co";
            this.co.Size = new System.Drawing.Size(44, 23);
            this.co.TabIndex = 27;
            this.co.Text = "CO";
            this.co.UseVisualStyleBackColor = true;
            this.co.Click += new System.EventHandler(this.co_Click);
            // 
            // mp
            // 
            this.mp.Location = new System.Drawing.Point(586, 66);
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(44, 23);
            this.mp.TabIndex = 26;
            this.mp.Text = "MP";
            this.mp.UseVisualStyleBackColor = true;
            this.mp.Click += new System.EventHandler(this.mp_Click);
            // 
            // result_text_box
            // 
            this.result_text_box.Location = new System.Drawing.Point(536, 122);
            this.result_text_box.Name = "result_text_box";
            this.result_text_box.Size = new System.Drawing.Size(144, 20);
            this.result_text_box.TabIndex = 25;
            // 
            // ep
            // 
            this.ep.Location = new System.Drawing.Point(536, 66);
            this.ep.Name = "ep";
            this.ep.Size = new System.Drawing.Size(44, 23);
            this.ep.TabIndex = 24;
            this.ep.Text = "EP";
            this.ep.UseVisualStyleBackColor = true;
            this.ep.Click += new System.EventHandler(this.ep_Click);
            // 
            // capture_right_button
            // 
            this.capture_right_button.Location = new System.Drawing.Point(431, 107);
            this.capture_right_button.Name = "capture_right_button";
            this.capture_right_button.Size = new System.Drawing.Size(99, 35);
            this.capture_right_button.TabIndex = 23;
            this.capture_right_button.Text = "Захват";
            this.capture_right_button.UseVisualStyleBackColor = true;
            this.capture_right_button.Click += new System.EventHandler(this.capture_right_button_Click);
            // 
            // capture_left_button
            // 
            this.capture_left_button.Location = new System.Drawing.Point(431, 66);
            this.capture_left_button.Name = "capture_left_button";
            this.capture_left_button.Size = new System.Drawing.Size(99, 35);
            this.capture_left_button.TabIndex = 22;
            this.capture_left_button.Text = "Захват";
            this.capture_left_button.UseVisualStyleBackColor = true;
            this.capture_left_button.Click += new System.EventHandler(this.capture_left_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Границы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // capture_height
            // 
            this.capture_height.Location = new System.Drawing.Point(128, 43);
            this.capture_height.Name = "capture_height";
            this.capture_height.Size = new System.Drawing.Size(100, 20);
            this.capture_height.TabIndex = 15;
            this.capture_height.Text = "60";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Высота захвата";
            // 
            // capture_width
            // 
            this.capture_width.Location = new System.Drawing.Point(19, 43);
            this.capture_width.Name = "capture_width";
            this.capture_width.Size = new System.Drawing.Size(100, 20);
            this.capture_width.TabIndex = 13;
            this.capture_width.Text = "114";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ширина захвата";
            // 
            // right_y
            // 
            this.right_y.Location = new System.Drawing.Point(220, 122);
            this.right_y.Name = "right_y";
            this.right_y.Size = new System.Drawing.Size(100, 20);
            this.right_y.TabIndex = 11;
            this.right_y.Text = "388";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "y-координата";
            // 
            // left_y
            // 
            this.left_y.Location = new System.Drawing.Point(220, 81);
            this.left_y.Name = "left_y";
            this.left_y.Size = new System.Drawing.Size(100, 20);
            this.left_y.TabIndex = 8;
            this.left_y.Text = "388";
            // 
            // right_x
            // 
            this.right_x.Location = new System.Drawing.Point(112, 122);
            this.right_x.Name = "right_x";
            this.right_x.Size = new System.Drawing.Size(100, 20);
            this.right_x.TabIndex = 7;
            this.right_x.Text = "1265";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "x-координата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Правый стол";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Левый стол";
            // 
            // left_x
            // 
            this.left_x.Location = new System.Drawing.Point(112, 81);
            this.left_x.Name = "left_x";
            this.left_x.Size = new System.Drawing.Size(100, 20);
            this.left_x.TabIndex = 2;
            this.left_x.Text = "380";
            // 
            // settings_label
            // 
            this.settings_label.AutoSize = true;
            this.settings_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings_label.Location = new System.Drawing.Point(15, 11);
            this.settings_label.Name = "settings_label";
            this.settings_label.Size = new System.Drawing.Size(88, 16);
            this.settings_label.TabIndex = 1;
            this.settings_label.Text = "Настройки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Флоп";
            // 
            // flopStartX
            // 
            this.flopStartX.Location = new System.Drawing.Point(115, 169);
            this.flopStartX.Name = "flopStartX";
            this.flopStartX.Size = new System.Drawing.Size(100, 20);
            this.flopStartX.TabIndex = 31;
            this.flopStartX.Text = "292";
            // 
            // flopStartY
            // 
            this.flopStartY.Location = new System.Drawing.Point(223, 169);
            this.flopStartY.Name = "flopStartY";
            this.flopStartY.Size = new System.Drawing.Size(100, 20);
            this.flopStartY.TabIndex = 31;
            this.flopStartY.Text = "230";
            // 
            // showFlopRects
            // 
            this.showFlopRects.Location = new System.Drawing.Point(329, 152);
            this.showFlopRects.Name = "showFlopRects";
            this.showFlopRects.Size = new System.Drawing.Size(99, 37);
            this.showFlopRects.TabIndex = 31;
            this.showFlopRects.Text = "Границы";
            this.showFlopRects.UseVisualStyleBackColor = true;
            this.showFlopRects.Click += new System.EventHandler(this.showFlopRects_Click);
            // 
            // captureFlop
            // 
            this.captureFlop.Location = new System.Drawing.Point(434, 153);
            this.captureFlop.Name = "captureFlop";
            this.captureFlop.Size = new System.Drawing.Size(99, 35);
            this.captureFlop.TabIndex = 31;
            this.captureFlop.Text = "Захват";
            this.captureFlop.UseVisualStyleBackColor = true;
            this.captureFlop.Click += new System.EventHandler(this.captureFlop_Click);
            // 
            // flopTextBox
            // 
            this.flopTextBox.Location = new System.Drawing.Point(539, 165);
            this.flopTextBox.Name = "flopTextBox";
            this.flopTextBox.Size = new System.Drawing.Size(144, 20);
            this.flopTextBox.TabIndex = 31;
            // 
            // flopWidth
            // 
            this.flopWidth.Location = new System.Drawing.Point(21, 207);
            this.flopWidth.Name = "flopWidth";
            this.flopWidth.Size = new System.Drawing.Size(100, 20);
            this.flopWidth.TabIndex = 31;
            this.flopWidth.Text = "185";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ширина захвата";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Высота захвата";
            // 
            // flopHeight
            // 
            this.flopHeight.Location = new System.Drawing.Point(131, 207);
            this.flopHeight.Name = "flopHeight";
            this.flopHeight.Size = new System.Drawing.Size(100, 20);
            this.flopHeight.TabIndex = 31;
            this.flopHeight.Text = "60";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 262);
            this.Controls.Add(this.flopHeight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flopWidth);
            this.Controls.Add(this.flopTextBox);
            this.Controls.Add(this.captureFlop);
            this.Controls.Add(this.showFlopRects);
            this.Controls.Add(this.flopStartY);
            this.Controls.Add(this.flopStartX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showCaptureRects;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox left_x;
        private System.Windows.Forms.Label settings_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox capture_height;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox capture_width;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox right_y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox left_y;
        private System.Windows.Forms.TextBox right_x;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button capture_left_button;
        private System.Windows.Forms.Button capture_right_button;
        private System.Windows.Forms.Button bb;
        private System.Windows.Forms.Button sb;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button co;
        private System.Windows.Forms.Button mp;
        private System.Windows.Forms.TextBox result_text_box;
        private System.Windows.Forms.Button ep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox flopStartX;
        private System.Windows.Forms.TextBox flopStartY;
        private System.Windows.Forms.Button showFlopRects;
        private System.Windows.Forms.Button captureFlop;
        private System.Windows.Forms.TextBox flopTextBox;
        private System.Windows.Forms.TextBox flopWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox flopHeight;
    }
}

