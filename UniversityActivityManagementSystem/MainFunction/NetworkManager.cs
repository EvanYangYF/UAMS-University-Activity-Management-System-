using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Timers;
using UniversityActivityManagementSystem;

public sealed class NetworkManager
{
    private static readonly Lazy<NetworkManager> instance = new Lazy<NetworkManager>(() => new NetworkManager());
    private System.Timers.Timer networkCheckTimer;

    public static NetworkManager Instance => instance.Value;

    private NetworkManager()
    {
        networkCheckTimer = new System.Timers.Timer(500); // 每0.5秒检查一次网络
        networkCheckTimer.Elapsed += OnNetworkCheckEvent;
        networkCheckTimer.AutoReset = true;
    }

    public void StartMonitoring()
    {
        networkCheckTimer.Start();
    }

    public void StopMonitoring()
    {
        networkCheckTimer.Stop();
    }

    private void OnNetworkCheckEvent(object source, ElapsedEventArgs e)
    {
        CheckNetworkConnection();
    }

    public void CheckNetworkConnection() // 修改为 public
    {
        if (!IsNetworkAvailable())
        {
            networkCheckTimer.Stop(); // 暂停定时器
            DialogResult result;
            do
            {
                using (var dialog = new WrongNetwork_Form())
                {
                    result = dialog.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                        return;
                    }
                }
            } while (!IsNetworkAvailable());

            networkCheckTimer.Start(); // 恢复定时器
        }
    }

    private bool IsNetworkAvailable()
    {
        try
        {
            using (var client = new System.Net.WebClient())
            using (var stream = client.OpenRead("http://www.baidu.com"))
            {
                return true;
            }
        }
        catch
        {
            return false;
        }
    }
}
