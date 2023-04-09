using SocketProgram.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace SocketProgram
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

        private static List<StreamWriter> writers = new List<StreamWriter>();

        private static Brain brain = new Brain();

        private static Thread acceptThread;
        private static Thread connectedThread;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = brain;
            acceptThread = new Thread(() => StartListening(ipAddress, port));
            acceptThread.Start();
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
            brain.IsLambOn = !brain.IsLambOn;
            UpdateClients(lambMessage, brain.IsLambOn.ToString());
        }

        //Click function for changing the number value with button
        private void RandomNumberClick(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            brain.Number = random.Next();
            UpdateClients(numberMessage, brain.Number.ToString());
        }

        //Function to start listening the clients
        private static void StartListening(string ipAddress, int port)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse(ipAddress), port);
            tcpListener.Start();

            while (true)
            {
                Socket clientSocket = tcpListener.AcceptSocket();
                connectedThread = new Thread(() => HandleClient(clientSocket));
                connectedThread.Start();
            }
        }

        //Handle Clients function
        private static void HandleClient(Socket clientSocket)
        {
            var stream = new NetworkStream(clientSocket);
            var writer = new StreamWriter(stream);
            var reader = new StreamReader(stream);

            writers.Add(writer);

            writer.WriteLine($"message={firstMessage};lamb={brain.IsLambOn};number={brain.Number}");
            writer.Flush();

            while (true)
            {
                try
                {
                    string message = reader.ReadLine();

                    if (message != null && message.Length > 0)
                    {
                        var dict = message.Split(';').ToDictionary(x => x.Split('=')[0].Trim(), y => y.Split('=')[1].Trim());

                        switch (dict["message"])
                        {
                            case lambMessage:
                                brain.IsLambOn = !brain.IsLambOn;
                                UpdateClients(lambMessage, brain.IsLambOn.ToString());
                                break;
                            case numberMessage:
                                Random random = new Random();
                                brain.Number = random.Next();
                                UpdateClients(numberMessage, brain.Number.ToString());
                                break;
                        }
                    }
                }
                catch (Exception)
                {
                    writers.Remove(writer);
                    break;
                }
            }
        }

        // function to update client's values
        private static void UpdateClients(string message, string value)
        {
            foreach (var writer in writers)
            {
                writer.WriteLine($"message={message};lamb={value};number={brain.Number}");
                writer.Flush();
            }
        }

        // updating the random number value when user updates input
        private void TxtboxUpdated(object sender, TextChangedEventArgs e)
        {
            int intValue;
            if (int.TryParse(RndmTxtBx.Text, out intValue))
            {
                brain.Number = intValue;
                UpdateClients(numberMessage, brain.Number.ToString());
            }
        }

        // Regex validation for non-numeric inputs
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
