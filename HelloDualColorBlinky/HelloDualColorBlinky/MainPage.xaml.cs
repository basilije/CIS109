using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Gpio;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloDualColorBlinky
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private const int LED_PIN_1 = 17, LED_PIN_2 = 18;
        private GpioPin pin1, pin2;
        private GpioPinValue pinValue1, pinValue2;
        private DispatcherTimer timer1, timer2;
        private SolidColorBrush redBrush = new SolidColorBrush(Windows.UI.Colors.Red);
        private SolidColorBrush grayBrush = new SolidColorBrush(Windows.UI.Colors.LightGray);
        private SolidColorBrush greenBrush = new SolidColorBrush(Windows.UI.Colors.Green);
        private SolidColorBrush foo;


        public MainPage()
        {
            this.InitializeComponent();

            timer1 = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(2000)
            };
            timer1.Tick += Timer_Tick1;

            timer2 = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(1500)
            };
            timer2.Tick += Timer_Tick2;

            InitGPIO();
            if (pin1 != null)
            {
                timer1.Start();
            }
            if (pin2 != null)
            {
                timer2.Start();
            }
        }



        private void InitGPIO()
        {
            var gpio = GpioController.GetDefault();

            // Show an error if there is no GPIO controller
            if (gpio == null)
            {
                pin1 = null;
                GpioStatus.Text = "There is no GPIO controller on this device.";
                return;
            }

            pin1 = gpio.OpenPin(LED_PIN_1);
            pinValue1 = GpioPinValue.Low;
            pin1.Write(pinValue1);
            pin1.SetDriveMode(GpioPinDriveMode.Output);

            pin2 = gpio.OpenPin(LED_PIN_2);
            pinValue2 = GpioPinValue.Low;
            pin2.Write(pinValue2);
            pin2.SetDriveMode(GpioPinDriveMode.Output);

            GpioStatus.Text = "GPIO pin initialized correctly.";

        }

        private void Timer_Tick1(object sender, object e)
        {
            if (pinValue1 == GpioPinValue.High)
            {
                pinValue1 = GpioPinValue.Low;
                pin1.Write(pinValue1);
                if (pinValue2 == GpioPinValue.Low)
                {
                    LED.Fill = grayBrush;
                    foo = grayBrush;
                }
                else
                {
                    LED.Fill = greenBrush;
                    foo = greenBrush;
                }
                  
            }
            else
            {
                pinValue1 = GpioPinValue.High;
                pin1.Write(pinValue1);
                LED.Fill = redBrush;
                foo = redBrush;
            }
        }

        private void Timer_Tick2(object sender, object e)
        {
            if (pinValue2 == GpioPinValue.High)
            {
                pinValue2 = GpioPinValue.Low;
                pin2.Write(pinValue2);
                if (pinValue1 == GpioPinValue.Low)
                {
                    LED.Fill = grayBrush;
                    foo = grayBrush;
                }
            }
            else
            {
                if (pinValue1 == GpioPinValue.Low)
                {
                    pinValue2 = GpioPinValue.High;
                    pin2.Write(pinValue2);
                    LED.Fill = greenBrush;
                    foo = greenBrush;
                }
            }
        }

    }
}
