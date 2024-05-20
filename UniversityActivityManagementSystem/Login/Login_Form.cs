using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityActivityManagementSystem
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();

            PublicClass.IpAddress = GetIpAddress();
        }

        DataOperator dataoper = new DataOperator();

        public bool VerifyInput()
        {
            if (KeanMail_TextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter your KeanMail", "Login Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KeanMail_TextBox.Focus();
                return false;
            }
            else if (!(Regex.IsMatch(KeanMail_TextBox.Text, @"^[^@]+@kean\.edu$")||KeanMail_TextBox.Text == "manager"))
            {
                MessageBox.Show("Illegal KeanMail", "Login Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KeanMail_TextBox.Focus();
                return false;
            }
            else if (Password_TextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter your password", "Login Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Password_TextBox.Focus();
                return false;
            }

            return true;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
            IP_Label.Text = "IP: " + PublicClass.IpAddress;
            if (PublicClass.IpAddress == "Wrong Network")
            {
                WrongNetwork_Form wrongNetworkForm = new WrongNetwork_Form();
                wrongNetworkForm.Show();
            }
        }

        private void SignIn_Button_Click(object sender, EventArgs e)
        {
            if (VerifyInput())
            {
                string sql = "select count(*) from tb_User where KeanMail='" + KeanMail_TextBox.Text.Trim()
                    + "' and Pwd='" + Password_TextBox.Text.Trim() + "'";
                int num = dataoper.ExecSQL(sql);
                if (num == 1)
                {
                    PublicClass.loginKeanMail = KeanMail_TextBox.Text.Trim();
                    if (AL_CheckBox.Checked)
                    {
                        dataoper.ExecSQLResult("update tb_User set Remember=1 where KeanMail='" + KeanMail_TextBox.Text.Trim()+"'");
                        dataoper.ExecSQLResult("update tb_User set AutoLogin=1 where KeanMail='" + KeanMail_TextBox.Text.Trim()+"'");
                        dataoper.ExecSQLResult("update tb_User set IP='" + PublicClass.IpAddress + "' where KeanMail='" + KeanMail_TextBox.Text.Trim()+"'");
                    }
                    else if (RP_CheckBox.Checked)
                    {
                        dataoper.ExecSQLResult("update tb_User set Remember=1 where KeanMail='" + KeanMail_TextBox.Text.Trim() + "'");
                        dataoper.ExecSQLResult("update tb_User set AutoLogin=0 where KeanMail='" + KeanMail_TextBox.Text.Trim() + "'");
                        dataoper.ExecSQLResult("update tb_User set IP='" + PublicClass.IpAddress + "' where KeanMail='" + KeanMail_TextBox.Text.Trim() + "'");
                    }
                    else
                    {
                        dataoper.ExecSQLResult("update tb_User set Remember=0 where KeanMail='" + KeanMail_TextBox.Text.Trim() + "'");
                        dataoper.ExecSQLResult("update tb_User set AutoLogin=0 where KeanMail='" + KeanMail_TextBox.Text.Trim() + "'");
                        dataoper.ExecSQLResult("update tb_User set IP=0 where KeanMail='" + KeanMail_TextBox.Text.Trim()+"'");
                    }
                    String CategoryJudgeSQL = "select Category from tb_User where KeanMail ='" + KeanMail_TextBox.Text.Trim()+"'";
                    DataSet ds = dataoper.GetDataSet(CategoryJudgeSQL);
                    if (ds.Tables[0].Rows[0][0].ToString() == "student")
                    {
                        Main_Form_Student mainForm = new Main_Form_Student();
                        mainForm.Show();
                        this.Visible = false;
                    }
                    else if (ds.Tables[0].Rows[0][0].ToString() == "professor")
                    {
                        Main_Form_Professor mainForm = new Main_Form_Professor();
                        mainForm.Show();
                        this.Visible = false;
                    }
                    else if (ds.Tables[0].Rows[0][0].ToString() == "manager")
                    {
                        Main_Form_Manager mainForm = new Main_Form_Manager();
                        mainForm.Show();
                        this.Visible = false;
                    }

                }
                else
                {
                    MessageBox.Show("The entered username or password is incorrect!", "Login Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Password_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SignIn_Button_Click(sender, e);
            }
        }

        private void KeanMail_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(KeanMail_TextBox.Text.Trim()))
            {
                string sql = "select Pwd,Remember,AutoLogin,IP from tb_User where KeanMail='" + KeanMail_TextBox.Text.Trim()+ "'";

                DataSet ds = dataoper.GetDataSet(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToInt32(ds.Tables[0].Rows[0][1]) == 1 && ds.Tables[0].Rows[0][3].ToString() == PublicClass.IpAddress)
                    {
                        RP_CheckBox.Checked = true;
                        Password_TextBox.Text = ds.Tables[0].Rows[0][0].ToString();
                        if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1)
                        {
                            AL_CheckBox.Checked = true;
                            SignIn_Button_Click(sender, e);
                        }
                    }
                }
            }


        }

        private static string GetIpAddress()
        {
            string ipAddress = string.Empty;

            try
            {
                // 获取所有网络接口
                NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

                foreach (NetworkInterface networkInterface in networkInterfaces)
                {
                    if (networkInterface.Description.Contains("VMware") || networkInterface.Description.Contains("VirtualBox") || networkInterface.Description.Contains("Hyper-V"))
                    {
                        continue;
                    }

                    // 过滤掉非活动的网络接口
                    if (networkInterface.OperationalStatus == OperationalStatus.Up)
                    {
                        //// 获取网络接口的 IP 属性
                        //IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();

                        // // 获取 IPv4 地址
                        // foreach (UnicastIPAddressInformation ipAddressInfo in ipProperties.UnicastAddresses)
                        // {
                        // if (ipAddressInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        // {
                        // ipAddress = ipAddressInfo.Address.ToString();
                        // return ipAddress;
                        // }
                        // }
                        var ipProps = networkInterface.GetIPProperties();

                        var gateway = ipProps.GatewayAddresses
                        .FirstOrDefault(g => g.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                        if (gateway != null)
                        {
                            return $"{networkInterface.GetIPProperties().UnicastAddresses.FirstOrDefault(ua => ua.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).Address}";
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                return "Network Error";
            }

            return "Wrong Network";
        }

        private void KeanMail_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '\r' || e.KeyChar == '\b')
            {
                e.Handled = false; // 允许这些键的输入
            }
            else
            {
                e.Handled = true; // 禁止其他键的输入
            }

            // 如果按下的是回车键
            if (e.KeyChar == '\r')
            {
                Password_TextBox.Focus(); // 将焦点移动到 Password_TextBox
            }
        }

        private void AL_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AL_CheckBox.Checked)
            {
                RP_CheckBox.Checked = true;
            }
            else
            {
                RP_CheckBox.Checked = false;
            }
        }
    }
}

