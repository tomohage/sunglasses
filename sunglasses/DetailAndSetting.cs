using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunglasses;
using Sunglasses.TimeSiries;

namespace GameEyeFilter
{
    public partial class DetailAndSetting : Form
    {
        private bool is_recording = false;
        RecordEyeTracker record_eye_tracker = null;
        TimeSiriesIO time_siries_io = null;
        TriggerForm trigger_form = null;
        Boolean trigger_flag = false;

        public DetailAndSetting()
        {
            InitializeComponent();

            this.trigger_form = new TriggerForm(this);
            this.trigger_form.Show();

            this.record_eye_tracker = new RecordEyeTracker();
            this.time_siries_io = new TimeSiriesIO();
            Size monitor_size = getDisplaySizeByScreen();
            this.filter_size_value_label.Text = monitor_size.Width.ToString() + " × " + monitor_size.Height.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void record_button_Click(object sender, EventArgs e)
        {
            if (is_recording)
            {
                this.is_recording = false;
                this.stopwatch_label_timer.Enabled = false;
                this.stopwatch_label_timer.Stop();
                this.record_button.Text = "● REC";
                this.cancel_button.Enabled = true;

                this.record_eye_tracker.StopRecording();

                this.time_siries_io.CloseOutput();
                this.position_update_timer.Enabled = false;
                this.position_update_timer.Stop();
            }
            else
            {
                this.is_recording = true;
                this.stopwatch_label_timer.Enabled = true;
                this.stopwatch_label_timer.Start();
                this.record_button.Text = "■ Stop";
                this.cancel_button.Enabled = false;

                this.record_eye_tracker.StartRecording();
                this.time_siries_io.StartOutput(this.save_file_path_textbox.Text, 
                    this.record_eye_tracker.GetMonitorSize());

                this.position_update_timer.Enabled = true;
                this.position_update_timer.Start();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void file_path_setting_button_Click(object sender, EventArgs e)
        {
            string output_file_path = FileIO.FilePathDialog();
            this.save_file_path_textbox.Text = output_file_path;
            if (this.save_file_path_textbox.Text != "")
            {
                this.record_button.Enabled = true;
            }
        }

        private void position_update_timer_Tick(object sender, EventArgs e)
        {
            this.time_label.Text = this.record_eye_tracker.GetRecordingStringTime();

            Point point = this.record_eye_tracker.GetPosition();
            double now_time = this.record_eye_tracker.GetRecordingLongTime();

            if (this.time_siries_io != null)
            {
                this.time_siries_io.WriteEyePosition(now_time, point, this.trigger_flag);
            }

        }

        public void UpdateTriggerFlag(Boolean trigger_flag)
        {
            this.trigger_flag = trigger_flag;
        }

        private Size getDisplaySizeByScreen()
        {
            return new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }
    }
}
