using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SimplePerfChart
{
    public partial class FrmTestingForm : Form
    {
        private object valueGenSync = new object();
        private Random randGen = new Random();

        private int valueGenFrom = 200;
        private int valueGenTo = 1000;
        private int valueGenTimerFrom = 100;
        private int valueGenTimerTo = 125;
        
        public FrmTestingForm() {
            InitializeComponent();

            this.Font = SystemInformation.MenuFont;

            
            // Apply default Properties
            perfChart.TimerInterval = 16;

            
        }



        private void chkBxTimerEnabled_CheckedChanged(object sender, EventArgs e) {
            if (chkBxTimerEnabled.Checked && !bgWrkTimer.IsBusy) {
                RunTimer();
            }
        }

        private void RunTimer() {
            int waitFor = randGen.Next(valueGenTimerFrom, valueGenTimerTo);////?????????????????///////
            bgWrkTimer.RunWorkerAsync(waitFor);
        }

        private void bgWrkTimer_DoWork(object sender, DoWorkEventArgs e) {
            Thread.Sleep(Convert.ToInt32(e.Argument));
            
        }
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////
        private void bgWrkTimer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            float genValue = randGen.Next(valueGenFrom, valueGenTo);
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            perfChart.AddValue(genValue);

            if (chkBxTimerEnabled.Checked)
            {
                //Simply restart, if still enabled
                RunTimer();
            }
        }

        //private void cmbBxBorder_SelectedIndexChanged(object sender, EventArgs e) {
        //    perfChart.BorderStyle = (Border3DStyle)Enum.Parse(
        //        typeof(Border3DStyle), cmbBxBorder.SelectedItem.ToString()
        //    );
        //}

        //private void cmbBxScaleMode_SelectedIndexChanged(object sender, EventArgs e) {
        //    perfChart.ScaleMode = (SpPerfChart.ScaleMode)Enum.Parse(
        //        typeof(SpPerfChart.ScaleMode), cmbBxScaleMode.SelectedItem.ToString()
        //    );
        //}

        //private void cmbBxTimerMode_SelectedIndexChanged(object sender, EventArgs e) {
        //    perfChart.TimerMode = (SpPerfChart.TimerMode)Enum.Parse(
        //        typeof(SpPerfChart.TimerMode), cmbBxTimerMode.SelectedItem.ToString()
        //    );
        //}


        private void btnApply_Click(object sender, EventArgs e) {
            

            valueGenTimerFrom = 100;
            valueGenTimerTo = 125;
            //if (valueGenTimerTo < valueGenTimerFrom) {
            //    valueGenTimerTo = valueGenTimerFrom;
            //    numUpDnToInterval.Value = valueGenTimerTo;
            //}
        }

        private void btnClear_Click(object sender, EventArgs e) {
            perfChart.Clear();
                    }

        private void perfChart_Load(object sender, EventArgs e)
        {

        }
    }
}