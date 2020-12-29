using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows;
namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        //Commands
        string loop = "c";
        string blue = "d";

        public MainWindow()
        {
            InitializeComponent();
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowLogic mwl = new MainWindowLogic();
        }

        public SerialPort serialPort = new SerialPort();

        //  private MainWindow mainWindow = new MainWindow();
        
        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String portName = CommPortNumber.Text;
                serialPort.PortName = portName;
                serialPort.BaudRate = 9600;
                serialPort.Open();
                status.Text = "Arduino Connected";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Needs a valid port name, or there is a bad connection. " + ex.Message);
            }
        }

        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                serialPort.Close();
                status.Text = "Disconnected";
            }
            catch
            {
                MessageBox.Show("Error closing Serial Port");
            }
        }

        private void OnButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                serialPort.Write("1");
                offButton.Visibility = Visibility.Visible;

                onButton.Visibility = Visibility.Collapsed;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OffButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                serialPort.Write("0");
                offButton.Visibility = Visibility.Collapsed;
                onButton.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Loop_Click(object sender, RoutedEventArgs e)
        {
            StopLooping.Visibility = Visibility.Visible;
            Loop_LED();
            Loop.Visibility = Visibility.Collapsed;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            BlueButtonOff.Visibility = Visibility.Visible;
            Click_Blue();
            BlueButton.Visibility = Visibility.Collapsed;
        }

        private void Blue_Click_Off(object sender, RoutedEventArgs e)
        {
            BlueButtonOff.Visibility = Visibility.Collapsed;
            BlueButton.Visibility = Visibility.Visible;
            serialPort.Write("x");   // turn the LED off
        }

        private void StopLooping_Click(object sender, RoutedEventArgs e)
        {
            StopLooping.Visibility = Visibility.Collapsed;
            Loop.Visibility = Visibility.Visible;
            serialPort.Write("x");   // turn the LED off
        }
        
        private void Loop_LED()
        {
            string SerialMessage = loop;
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.Open();
                    serialPort.Write(SerialMessage);
                    serialPort.Close();
                }
                catch
                {
                    MessageBox.Show("Error: fix your shit");
                }
            }
            else
            {
                serialPort.Write(SerialMessage);
            }
        }
        private void Click_Blue()
        {
            string SerialMessage = blue;

            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.Open();
                    serialPort.Write(SerialMessage);
                    serialPort.Close();
                }
                catch
                {
                    MessageBox.Show("Error: fix your shit");
                }
            }
            else
            {
                serialPort.Write(SerialMessage);
            }
        }
    }
}
