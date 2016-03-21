namespace GameEyeFilter
{
    partial class TriggerForm
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
            this.trigger_switch_button = new System.Windows.Forms.Button();
            this.trigger_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trigger_switch_button
            // 
            this.trigger_switch_button.Location = new System.Drawing.Point(52, 88);
            this.trigger_switch_button.Name = "trigger_switch_button";
            this.trigger_switch_button.Size = new System.Drawing.Size(98, 47);
            this.trigger_switch_button.TabIndex = 0;
            this.trigger_switch_button.Text = "切り替え";
            this.trigger_switch_button.UseVisualStyleBackColor = true;
            this.trigger_switch_button.Click += new System.EventHandler(this.torigger_switch_button_Click);
            // 
            // trigger_label
            // 
            this.trigger_label.AutoSize = true;
            this.trigger_label.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.trigger_label.Location = new System.Drawing.Point(12, 36);
            this.trigger_label.Name = "trigger_label";
            this.trigger_label.Size = new System.Drawing.Size(155, 33);
            this.trigger_label.TabIndex = 1;
            this.trigger_label.Text = "Trigger off";
            // 
            // TriggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 162);
            this.Controls.Add(this.trigger_label);
            this.Controls.Add(this.trigger_switch_button);
            this.Name = "TriggerForm";
            this.Text = "Torigger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button trigger_switch_button;
        private System.Windows.Forms.Label trigger_label;
    }
}