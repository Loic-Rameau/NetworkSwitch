using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkSwitch
{
    public partial class Form1 : Form
    {

        public Profiles profiles;
        private Profile currentProfile = new Profile();
        private Profile tmpProfile = new Profile();

        public Form1()
        {
            try
            {
                profiles = Profiles.Unserialize();
            } catch (Exception) {
                profiles = new Profiles();
            }
            InitializeComponent();
            ProfilecomboBox.DisplayMember = "Name";
            ProfilecomboBox.Items.AddRange(profiles.Items.ToArray());
            NICcomboBox1.Items.AddRange(getNics());
        }

        string[] getNics()
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            List<string> nics = new List<string>();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    nics.Add(objMO["Caption"].ToString());
                }
            }

            return nics.ToArray();
        }

        void refreshStatus()
        {
            string ip = GetLocalIPAddress();
            IPNetwork local = IPNetwork.Parse(ip);
            if (this.currentProfile != null)
            {
                StatusIPLabel2.Text = this.currentProfile.Address.ToString();
                StatusMaskLabel.Text = this.currentProfile.Network.Netmask.ToString();
                StatusNetworkLabel.Text = this.currentProfile.Network.ToString();
                StatusGatewayLabel.Text = this.currentProfile.GateWay.ToString();
            }
            else
            {
                StatusIPLabel2.Text = ip;
                StatusMaskLabel.Text = local.Netmask.ToString();
                StatusNetworkLabel.Text = local.ToString();
                //StatusGatewayLabel.Text = 
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            profiles.Serialize();
        }

        private void MasktextBox1_TextChanged(object sender, EventArgs e)
        {
            this.tmpProfile = new Profile();
            string ip = AddresstextBox1.Text.Trim();
            Regex r = new Regex(@"^(?<Ip>\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})\/(?<Mask>\d{1,2})$", RegexOptions.Compiled);
            Regex r2 = new Regex(@"^(?<Ip>\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})$", RegexOptions.Compiled);
            try
            {
                if(r.IsMatch(ip))
                {
                    GroupCollection groups = r.Match(ip).Groups;
                    if (groups.Count > 1)
                        this.tmpProfile.Address = IPAddress.Parse(groups[r.GroupNumberFromName("Ip")].Value);
                }
                else if (r2.IsMatch(ip))
                {
                    GroupCollection groups = r.Match(ip).Groups;
                    this.tmpProfile.Address = IPAddress.Parse(groups[r.GroupNumberFromName("Ip")].Value);
                }
            }
            catch (Exception) { }
            try
            {
                this.tmpProfile.Name = ProfiletextBox.Text;
            }
            catch (Exception) { } 
            try
            {
                this.tmpProfile.GateWay = IPAddress.Parse(GateWaytextBox1.Text);
            }
            catch (Exception) { } 
            try
            {
                if(r.IsMatch(ip))
                    this.tmpProfile.Network = IPNetwork.Parse(ip);
                else  if (r2.IsMatch(ip))
                    this.tmpProfile.Network = IPNetwork.Parse(ip + "/25");
            }
            catch (Exception) { }
            if (this.tmpProfile.Network != null && this.tmpProfile.Address != null && this.tmpProfile.GateWay != null && this.tmpProfile.Name.Trim().Length != 0)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
            this.refreshlabel(true);

        }
        void refreshlabel(bool fromTmp)
        {
            Profile profile;
            if (fromTmp)
            {
                profile = tmpProfile;
            }
            else
            {
                profile = currentProfile;
            }
            try
            {
                Addresslabel5.Text = profile.Address.ToString();
            }
            catch (Exception) { }
            try
            {
                Masklabel7.Text = profile.Network.Netmask.ToString();
            }
            catch (Exception) { }
            try
            {
                Reseauxlabel9.Text = profile.Network.ToString();
            }
            catch (Exception) { }
            try
            {
                GateWaylabel9.Text = profile.GateWay.ToString();
            }
            catch (Exception) { }
            groupBox2.Text = String.Format("Previsualisation {0}", profile.Name);
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (profiles.Items.Where((Profile pro) => { return pro.Name == tmpProfile.Name; }).Count() > 0)
            {
                Profile profile = profiles.Items.Where((Profile pro) => { return pro.Name == tmpProfile.Name; }).First();
                profile.Address = tmpProfile.Address;
                profile.GateWay = tmpProfile.GateWay;
                profile.Network = tmpProfile.Network;
            }
            else
            {
                profiles.Items.Add(tmpProfile);
                ProfilecomboBox.Items.Add(tmpProfile);
            }
            currentProfile = tmpProfile;
            tmpProfile = new Profile();
            this.apply();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentProfile = tmpProfile;
            this.apply();
        }

        void apply()
        {
            if (this.currentProfile != null)
            {
                this.setIP(this.currentProfile.Address.ToString(), this.currentProfile.Network.Netmask.ToString());
                this.setGateway(this.currentProfile.GateWay.ToString());
                this.refreshStatus();
            }
        }

        void setIP(string ip_address, string subnet_mask)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].Equals(NICcomboBox1.SelectedItem as string))
                    {
                        try
                        {
                            uint setIP = (uint)objMO.InvokeMethod("EnableStatic", new object[] { new string[] { ip_address }, new string[] { subnet_mask } });
                            Console.WriteLine(setIP);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }

        void setGateway(string gateway)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].Equals(NICcomboBox1.SelectedItem as string))
                    {
                        try
                        {
                            ManagementBaseObject setGateway;
                            ManagementBaseObject newGateway =
                                objMO.GetMethodParameters("SetGateways");

                            newGateway["DefaultIPGateway"] = new string[] { gateway };
                            newGateway["GatewayCostMetric"] = new int[] { 1 };

                            setGateway = objMO.InvokeMethod("SetGateways", newGateway, null);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.apply();
        }

        private void ProfilecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profile profile = ProfilecomboBox.SelectedItem as Profile;
            if (profile != null)
            {
                this.currentProfile = profile;
                this.refreshlabel(false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                profiles.Items.Remove(currentProfile);
                ProfilecomboBox.Items.Remove(currentProfile);
                currentProfile = null;
            }
            catch (Exception) { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].Equals(NICcomboBox1.SelectedItem as string))
                    {
                        try
                        {
                            var ndns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                            ndns["DNSServerSearchOrder"] = null;
                            var enableDhcp = objMO.InvokeMethod("EnableDHCP", null, null);
                            var setDns = objMO.InvokeMethod("SetDNSServerSearchOrder", ndns, null);
                        }
                        catch (Exception) { }
                    }
                }
            }
            this.currentProfile = null;
            this.refreshStatus();
         }
    }
}
