using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace myip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(IPLabel.Text);
        }
        private void initNetworkAdapterBox()
        {
            NetworkInterface[] NetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface NetworkIntf in NetworkInterfaces)
            {
                IPInterfaceProperties IPInterfaceProperties = NetworkIntf.GetIPProperties();
                UnicastIPAddressInformationCollection UnicastIPAddressInformationCollection = IPInterfaceProperties.UnicastAddresses;
                foreach (UnicastIPAddressInformation UnicastIPAddressInformation in UnicastIPAddressInformationCollection)
                {
                    if (UnicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork
                        && NetworkIntf.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                        )
                    {
                        networkAdapterComboBox.Items.Add(NetworkIntf.Name);
                    }
                }
            }
        }
        private string getIP(string adapterName)
        {
            string ipAddr = null;
            NetworkInterface[] NetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface NetworkIntf in NetworkInterfaces)
            {
                if(NetworkIntf.Name == adapterName)
                {
                    IPInterfaceProperties IPInterfaceProperties = NetworkIntf.GetIPProperties();
                    UnicastIPAddressInformationCollection UnicastIPAddressInformationCollection = IPInterfaceProperties.UnicastAddresses;
                    foreach (UnicastIPAddressInformation UnicastIPAddressInformation in UnicastIPAddressInformationCollection)
                    {
                        if (UnicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork
                            && NetworkIntf.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                            )
                        {
                            ipAddr = UnicastIPAddressInformation.Address.ToString();
                            break;
                        }
                    }
                    break;
                }
            }
            return ipAddr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initNetworkAdapterBox();
            if(networkAdapterComboBox.Items.Count > 0)
            {
                networkAdapterComboBox.SelectedIndex = 0;
            }
            refreshIP();
        }

        private void networkAdapterComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            refreshIP();
        }
        private void refreshIP()
        {
            string adapter = networkAdapterComboBox.Text;
            string ipAddr = getIP(adapter);
            IPLabel.Text = ipAddr;
        }
    }
}
