using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class MainWindowLogic
    {
        public List<String> Finish = new List<string>();

        public SerialPort serialPort = new SerialPort();

        private MainWindow mainWindow = new MainWindow();

        private void PopulateFinish()
        {
            Finish.Add("No Finish");
            Finish.Add("Chrome");
            Finish.Add("Nickel");
        }

        //public static void Connect_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        String portName = mainWindow.comportno.Text;
        //        serialPort.PortName = portName;
        //        serialPort.BaudRate = 9600;
        //        serialPort.Open();
        //        mainWindow.status.Text = "Arduino Connected";
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Error: Needs a valid port name, or there is a bad connection");
        //    }
            
        //}

        //public static void Disconnect_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        serialPort.Close();
        //        mainWindow.status.Text = "Disconnected";
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Error closing Serial Port");
        //    }
        //}

        //public static void OnButton_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        serialPort.Write("1");
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public static void OffButton_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        serialPort.Write("0");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
