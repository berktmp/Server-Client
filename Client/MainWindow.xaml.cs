using SocketProgram.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Net.Sockets;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Variable Definitions
        private const string firstMessage = "FirstValues";
        private const string lambMessage = "ToggleLamb";
        private const string numberMessage = "ChangeNumber";
        private const string ipAddress = "127.0.0.5";
        private const int port = 5000;

        private readonly ConnectThread _connectThread;
        public delegate void LambHandler(Boolean durum);
        static LambHandler lamb_handler;
        public delegate void NumberHandler(int sayi);
        static NumberHandler number_handler;
        Brain brain = new Brain();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = brain;
            _connectThread = new ConnectThread(ipAddress, port);
            _connectThread.Connect();
            lamb_handler = ToggleLamb;
            number_handler = ChangeNumber;
        }
        // Function for moving the window
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }

        }

        //Click function for toggling the lamb situation with button
        private void ToggleLambClick(object sender, RoutedEventArgs e)
        {
            _connectThread.SendNewValue(lambMessage);
        }

        //Click function for changing the number value with button
        private void ChangeNumberClick(object sender, RoutedEventArgs e)
        {
            _connectThread.SendNewValue(numberMessage);
        }

        // Toggle lamb situation for the current window
        public void ToggleLamb(bool value)
        {
            brain.IsLambOn = value;    
        }

        // Change number value for the current window
        public void ChangeNumber(int value)
        {
            brain.Number = value;
        }

        //Connection Class definition
        public class ConnectThread
        {
            private readonly string _ipAddress;
            private readonly int _port;
            private TcpClient _tcpClient;
            private NetworkStream _networkStream;
            private StreamReader _streamReader;
            private StreamWriter _streamWriter;
            private Thread _thread;

            //Constructor
            public ConnectThread(string ipAddress, int port)
            {
                _ipAddress = ipAddress;
                _port = port;
                _thread = new Thread(Connect);
            }

            public void Connect()
            {
                //Trying to connect the server thread
                try
                {
                    _tcpClient = new TcpClient(_ipAddress, _port);
                    _networkStream = _tcpClient.GetStream();
                    _streamReader = new StreamReader(_networkStream);
                    _streamWriter = new StreamWriter(_networkStream);

                    _thread.Interrupt();
                    _thread = new Thread(ReadValues);
                    _thread.Start();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not Connect!!");
                }
            }

            //Function to read received valued if there is any 
            public void ReadValues()
            {
                while (true)
                {
                    try
                    {
                        string text = _streamReader.ReadLine();
                        
                        if (text.Length > 0)
                        {
                            // putting into pieces according to ";" value
                            Dictionary<string, string> dict = text.Split(';')
                                .Select(item => item.Split('='))
                                .ToDictionary(key => key[0].Trim(), value => value[1].Trim());
                            string mesaj = dict["message"];

                            // If the first Values from the server received
                            if (mesaj == firstMessage)
                            {
                                bool lambValue = bool.Parse(dict["lamb"]);
                                int number = int.Parse(dict["number"]);

                                lamb_handler(lambValue);
                                number_handler(number);
                               
                                _streamReader.DiscardBufferedData();
                                text = "";
                                
                            }
                            else if (mesaj == lambMessage) // If only lamb value changed and client informed
                            {
                                bool lambValue = bool.Parse(dict["lamb"]);
                                lamb_handler(lambValue);

                                text = "";
                            }
                            else if (mesaj == numberMessage) // If only number value changed and client informed
                            {
                                int number = int.Parse(dict["number"]);
                                number_handler(number);
                                text = "";
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        System.Windows.MessageBox.Show("Error Reading Values" + e.Message);
                    }
                }
            }

            // Function to Send new values if anything updated from current window 
            public void SendNewValue(string message)
            {
                var dictionary = new Dictionary<string, string>
                {
                 { "message", message }
                 };

                var serializedDictionary = string.Join(";", dictionary.Select(pair => $"{pair.Key}={pair.Value}"));
                _streamWriter.WriteLine(serializedDictionary);
                _streamWriter.Flush();
            }
        }
    }
}
