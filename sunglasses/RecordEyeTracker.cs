using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Sunglasses.EyetrackerDataController;
using Sunglasses.TimeSiries;

namespace GameEyeFilter
{
    public class RecordEyeTracker
    {
        private Stopwatch stopwatch = null;
        private EyeTrackerController eye_tracker_controller = null;

        public RecordEyeTracker()
        {
            this.eye_tracker_controller = new EyeTrackerController();
        }

        public void StartRecording()
        {
            this.stopwatch = new Stopwatch();
            this.stopwatch.Start();
            this.eye_tracker_controller.TobiiEyexStart();
            this.eye_tracker_controller.AddVisionDataListener();
        }

        public Point GetPosition()
        {
            return new Point((int)this.eye_tracker_controller.x, (int)this.eye_tracker_controller.y);
        }

        public string GetRecordingStringTime()
        {
            if (this.stopwatch == null)
            {
                return "";
            }
            return this.stopwatch.Elapsed.ToString();
        }

        public long GetRecordingLongTime()
        {
            if (this.stopwatch == null)
            {
                return 0;
            }
            return this.stopwatch.ElapsedMilliseconds;
        }

        public Size GetMonitorSize()
        {
            return new Size((int)this.eye_tracker_controller.monitor_width, 
                (int)this.eye_tracker_controller.monitor_height);
        }

        public void StopRecording()
        {
            this.eye_tracker_controller.TobiiEyexDispose();
            this.stopwatch.Stop();
            this.stopwatch.Reset();
            this.stopwatch = null;
        }
    }
}
