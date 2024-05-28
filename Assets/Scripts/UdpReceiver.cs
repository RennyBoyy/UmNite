using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class UdpReceiver : MonoBehaviour
{
    private UdpClient udpClient;
    private IPEndPoint remoteEndPoint;
    private string receivedData;

    // Public field to reference the cursor object
    public GameObject cursorObject;

    void Start()
    {
        udpClient = new UdpClient(5052);
        remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
        udpClient.BeginReceive(new AsyncCallback(OnUdpData), udpClient);
    }

    private void OnUdpData(IAsyncResult result)
    {
        byte[] data = udpClient.EndReceive(result, ref remoteEndPoint);
        receivedData = Encoding.UTF8.GetString(data);
        udpClient.BeginReceive(new AsyncCallback(OnUdpData), udpClient);
    }

    void Update()
    {
        if (!string.IsNullOrEmpty(receivedData))
        {
            string[] positions = receivedData.Split(',');
            if (positions.Length >= 3)
            {
                float x = float.Parse(positions[0]) / 1280.0f * Screen.width;
                float y = float.Parse(positions[1]) / 720.0f * Screen.height;
                cursorObject.transform.position = new Vector3(x, y, 0);
            }
        }
    }

    void OnApplicationQuit()
    {
        udpClient.Close();
    }
}
