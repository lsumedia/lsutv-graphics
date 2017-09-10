using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svt.Caspar;
using Svt.Network;

namespace LSUTVGraphicsControl {
    public partial class Form1 : Form {

        private delegate void UpdateGUI(object parameter);

        CasparDevice caspar_ = new CasparDevice();
        CasparCGDataCollection cgData = new CasparCGDataCollection();

        public Form1() {
            InitializeComponent();

            this.initFieldsData();

            //Caspar connection events handlers
            caspar_.Connected += new EventHandler<NetworkEventArgs>(caspar__Connected);
            caspar_.FailedConnect += new EventHandler<NetworkEventArgs>(caspar__FailedConnected);
            caspar_.Disconnected += new EventHandler<NetworkEventArgs>(caspar__Disconnected);

            disableControls();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label1_Click_1(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void tabPage1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void connectServerBtn_Click(object sender, EventArgs e) {
            connectServerBtn.Enabled = false;

            if (!caspar_.IsConnected) {
                caspar_.Settings.Hostname = this.serverAddressField.Text; // Properties.Settings.Default.Hostname;
                caspar_.Settings.Port = 5250;
                caspar_.Connect();
            } else {
                caspar_.Disconnect();
            }
        }

        private void initFieldsData() {
            this.serverAddressField.Text = Properties.Settings.Default.Hostname;
        }

        //caspar event - connected
        void caspar__Connected(object sender, NetworkEventArgs e) {
            if (InvokeRequired)
                BeginInvoke(new UpdateGUI(OnCasparConnected), e);
            else
                OnCasparConnected(e);
        }
        void OnCasparConnected(object param) {
            connectServerBtn.Enabled = true;
            updateConnectButtonText();

            caspar_.RefreshMediafiles();
            caspar_.RefreshDatalist();

            NetworkEventArgs e = (NetworkEventArgs)param;
            statusStrip1.BackColor = Color.LightGreen;
            toolStripStatusLabel1.Text = "Connected to " + caspar_.Settings.Hostname; // Properties.Settings.Default.Hostname;

            enableControls();
        }



        //caspar event - failed connect
        void caspar__FailedConnected(object sender, NetworkEventArgs e) {
            if (InvokeRequired)
                BeginInvoke(new UpdateGUI(OnCasparFailedConnect), e);
            else
                OnCasparFailedConnect(e);
        }
        void OnCasparFailedConnect(object param) {
            connectServerBtn.Enabled = true;
            updateConnectButtonText();

            NetworkEventArgs e = (NetworkEventArgs)param;
            statusStrip1.BackColor = Color.LightCoral;
            toolStripStatusLabel1.Text = "Failed to connect to " + caspar_.Settings.Hostname; // Properties.Settings.Default.Hostname;

            disableControls();
        }

        //caspar event - disconnected
        void caspar__Disconnected(object sender, NetworkEventArgs e) {
            if (InvokeRequired)
                BeginInvoke(new UpdateGUI(OnCasparDisconnected), e);
            else
                OnCasparDisconnected(e);
        }
        void OnCasparDisconnected(object param) {
            connectServerBtn.Enabled = true;
            updateConnectButtonText();

            NetworkEventArgs e = (NetworkEventArgs)param;
            statusStrip1.BackColor = Color.LightCoral;
            toolStripStatusLabel1.Text = "Disconnected from " + caspar_.Settings.Hostname; // Properties.Settings.Default.Hostname;

            disableControls();
        }

        // update text on button
        private void updateConnectButtonText() {
            if (!caspar_.IsConnected) {
                connectServerBtn.Text = "Connect";// to " + Properties.Settings.Default.Hostname;
            } else {
                connectServerBtn.Text = "Disconnect"; // from " + Properties.Settings.Default.Hostname;
            }
        }

        void enableControls() {
            tabControl1.Enabled = true;
        }

        void disableControls() {
            tabControl1.Enabled = false;
        }

        private void clearChannelBtn_Click(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("Clear on: " + Properties.Settings.Default.CasparChannel);
            try {
                this.caspar_.Channels[Properties.Settings.Default.CasparChannel].CG.Clear();
                this.caspar_.Channels[Properties.Settings.Default.CasparChannel].Clear();
            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        void hideAll() {

            this.caspar_.Channels[Properties.Settings.Default.CasparChannel].CG.Stop(Properties.Settings.Default.GraphicsLayerCountdown);
        }

        private void dissolveGraphicsBtn_Click(object sender, EventArgs e) {
            hideAll();
        }

        private Int32 getProgramStartTime() {
            DateTime value = programStartField.Value.ToUniversalTime();
            Int32 unixTimestamp = (Int32)(value.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            return unixTimestamp;
        }

        private void showTitleCardBtn_Click(object sender, EventArgs e) {
            cgData.Clear();
            cgData.SetData("ProgramTitle", programTitleField.Text);
            cgData.SetData("ProgramStartTime", getProgramStartTime().ToString());
            this.caspar_.Channels[Properties.Settings.Default.CasparChannel].CG.Add(Properties.Settings.Default.GraphicsLayerCountdown, "COUNTDOWN_FS.XFL", true, cgData);
        }

        private void showCountdownL3Btn_Click(object sender, EventArgs e) {
            cgData.Clear();
            cgData.SetData("ProgramTitle", programTitleField.Text);
            cgData.SetData("ProgramStartTime", getProgramStartTime().ToString());
            this.caspar_.Channels[Properties.Settings.Default.CasparChannel].CG.Add(Properties.Settings.Default.GraphicsLayerCountdown, "COUNTDOWN_L3.XFL", true, cgData);
        }
    }
}
