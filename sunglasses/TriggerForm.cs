using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEyeFilter
{
    public partial class TriggerForm : Form
    {
        DetailAndSetting detail_and_setting = null;
        Boolean trigger_flag = false;
        public TriggerForm(DetailAndSetting detail_and_setting)
        {
            this.detail_and_setting = detail_and_setting;
            InitializeComponent();
        }

        private void torigger_switch_button_Click(object sender, EventArgs e)
        {
            if (this.trigger_flag)
            {
                this.trigger_flag = false;
                this.trigger_label.Text = "Trigger off";
                this.trigger_label.ForeColor = Color.Black;
            }
            else
            {
                this.trigger_flag = true;
                this.trigger_label.Text = "Trigger on";
                this.trigger_label.ForeColor = Color.Red;
            }

            this.detail_and_setting.UpdateTriggerFlag(this.trigger_flag);
        }
    }
}
