namespace GameEyeFilter
{
    partial class DetailAndSetting
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
            this.components = new System.ComponentModel.Container();
            this.filter_size_label = new System.Windows.Forms.Label();
            this.filter_size_value_label = new System.Windows.Forms.Label();
            this.record_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.stopwatch_label_timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.save_file_path_textbox = new System.Windows.Forms.TextBox();
            this.file_path_setting_button = new System.Windows.Forms.Button();
            this.position_update_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // filter_size_label
            // 
            this.filter_size_label.AutoSize = true;
            this.filter_size_label.Location = new System.Drawing.Point(12, 19);
            this.filter_size_label.Name = "filter_size_label";
            this.filter_size_label.Size = new System.Drawing.Size(149, 12);
            this.filter_size_label.TabIndex = 0;
            this.filter_size_label.Text = "フィルタサイズ（width×height）";
            // 
            // filter_size_value_label
            // 
            this.filter_size_value_label.AutoSize = true;
            this.filter_size_value_label.Location = new System.Drawing.Point(176, 19);
            this.filter_size_value_label.Name = "filter_size_value_label";
            this.filter_size_value_label.Size = new System.Drawing.Size(61, 12);
            this.filter_size_value_label.TabIndex = 1;
            this.filter_size_value_label.Text = "500 × 300";
            // 
            // record_button
            // 
            this.record_button.Enabled = false;
            this.record_button.ForeColor = System.Drawing.Color.Red;
            this.record_button.Location = new System.Drawing.Point(88, 121);
            this.record_button.Name = "record_button";
            this.record_button.Size = new System.Drawing.Size(73, 23);
            this.record_button.TabIndex = 7;
            this.record_button.Text = "● REC";
            this.record_button.UseVisualStyleBackColor = true;
            this.record_button.Click += new System.EventHandler(this.record_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(208, 121);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(62, 23);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.time_label.Location = new System.Drawing.Point(105, 88);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(151, 19);
            this.time_label.TabIndex = 9;
            this.time_label.Text = "00:00:00.0000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "保存先ファイルパス（空の場合は保存されない）";
            // 
            // save_file_path_textbox
            // 
            this.save_file_path_textbox.Location = new System.Drawing.Point(14, 60);
            this.save_file_path_textbox.Name = "save_file_path_textbox";
            this.save_file_path_textbox.ReadOnly = true;
            this.save_file_path_textbox.Size = new System.Drawing.Size(298, 19);
            this.save_file_path_textbox.TabIndex = 11;
            // 
            // file_path_setting_button
            // 
            this.file_path_setting_button.Location = new System.Drawing.Point(318, 58);
            this.file_path_setting_button.Name = "file_path_setting_button";
            this.file_path_setting_button.Size = new System.Drawing.Size(59, 23);
            this.file_path_setting_button.TabIndex = 12;
            this.file_path_setting_button.Text = "設定";
            this.file_path_setting_button.UseVisualStyleBackColor = true;
            this.file_path_setting_button.Click += new System.EventHandler(this.file_path_setting_button_Click);
            // 
            // position_update_timer
            // 
            this.position_update_timer.Tick += new System.EventHandler(this.position_update_timer_Tick);
            // 
            // DetailAndSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 163);
            this.Controls.Add(this.file_path_setting_button);
            this.Controls.Add(this.save_file_path_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.record_button);
            this.Controls.Add(this.filter_size_value_label);
            this.Controls.Add(this.filter_size_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetailAndSetting";
            this.Text = "詳細・設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filter_size_label;
        private System.Windows.Forms.Label filter_size_value_label;
        private System.Windows.Forms.Button record_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Timer stopwatch_label_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox save_file_path_textbox;
        private System.Windows.Forms.Button file_path_setting_button;
        private System.Windows.Forms.Timer position_update_timer;
    }
}