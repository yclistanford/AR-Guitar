using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Linq;

public class Controller : MonoBehaviour
{

    private Rigidbody rb;
    private TcpClient socketConnection;
    private Thread clientReceiveThread;
    private float x, y, z;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // ListenForData();
        ConnectToTcpServer();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movement = new Vector3(x + (float)0.08, y - (float)0.69, z  + (float)0.42);
        rb.MovePosition(movement);
        Debug.Log("Updated.");
        Debug.Log(x);
        Debug.Log(y);

        if (Input.GetKey("up"))
        {
            movement = new Vector3(0.0f, 2.0f, 0.0f);
            rb.AddForce(movement);

        }
    }


    /// <summary> 	

    /// Setup socket connection. 	

    /// </summary> 	

    private void ConnectToTcpServer()
    {

        try
        {

            clientReceiveThread = new Thread(new ThreadStart(ListenForData));

            clientReceiveThread.IsBackground = true;

            clientReceiveThread.Start();

        }

        catch (Exception e)
        {

            Debug.Log("On client connect exception " + e);

        }

    }

    /// <summary> 	

    /// Runs in background clientReceiveThread; Listens for incomming data. 	

    /// </summary>     

    private void ListenForData()
    {

        try
        {

            socketConnection = new TcpClient("10.34.160.167", 8081);

            Byte[] bytes = new Byte[1024];

            while (true)
            {

                // Get a stream object for reading 				

                using (NetworkStream stream = socketConnection.GetStream())
                {

                    byte[] myWriteBuffer = Encoding.ASCII.GetBytes("GET / HTTP/1.1\nHost: 10.34.160.167:8081\n\n");
                    stream.Write(myWriteBuffer, 0, myWriteBuffer.Length);

                    int length;

                    // Read incomming stream into byte arrary. 					

                    while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {

                        var incommingData = new byte[length];

                        Array.Copy(bytes, 0, incommingData, 0, length);

                        // Convert byte array to string message. 						

                        string serverMessage = Encoding.ASCII.GetString(incommingData);

                        Debug.Log("server message received as: " + serverMessage);

                        string[] split = serverMessage.Split('/');
                        if (split.Length < 3)
                            continue;
                     
                        string xyz = split[split.Length-2];
                        
                        string[] xyz_array = xyz.Split(',');
                        if (xyz_array.Length != 3)
                            continue;
                        //Debug.Log(xyz);

                        x = float.Parse(xyz_array[0]);
                        y = float.Parse(xyz_array[1]);
                        z = float.Parse(xyz_array[2]);

                    }

                }

            }

        }

        catch (SocketException socketException)
        {

            Debug.Log("Socket exception: " + socketException);

        }

    }
}
