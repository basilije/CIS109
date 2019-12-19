/* Vasilije Mehandzic
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * Project 13: Final Project - IoT Clock
 * based on and https://www.hackster.io/4803/i2c-port-expander-sample-0a6d4f, https://github.com/dvwl/WIN10_LCD1602_I2C and https://docs.microsoft.com/en-us/samples/microsoft/windows-iotcore-samples/i2cportexpander/ 
*/

using System;
using System.Diagnostics;
using Windows.UI.Xaml.Controls;
using Windows.ApplicationModel.Core;


namespace IoTClock
{

    public sealed partial class MainPage : Page
    {
        public bool exceptioned = false;
        private I2C_TO_LCD MY_LCD = new I2C_TO_LCD();

        public MainPage()
        {
            this.InitializeComponent();
            MainLoop();
        }

        private async void MainLoop()
        {
            try
            {
                await MY_LCD.Init();

                while (!MY_LCD.exceptioned && !exceptioned)
                    MY_LCD.SendTwoStringRows(DateTime.Now.ToString("ddd  MMM/yyyy/dd| hh:mm:ss.ff tt ").Split('|'));
            }
            catch (Exception e)
            {
                Debug.WriteLine("EXCEPTION! MainLoop: " + e.Message);
                exceptioned = true;
            }

            CoreApplication.Exit();
        }
    }
}

