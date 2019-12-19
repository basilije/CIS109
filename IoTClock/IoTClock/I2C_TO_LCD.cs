using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Devices.I2c;

namespace IoTClock
{
    public class I2C_TO_LCD
    {
        //commands
        private const int RETURN_HOME = 0x02;
        private const int GO_TO_SECOND_ROW = 0xC0;

        // flags for display on/off
        private const int DISPLAY_CONTROL = 0x08;
        private const int DISPLAY_ON = 0x04;

        // flags for backlight
        private int BACKLIGHT = 0x00;
        private const int BACKLIGHT_ON = 0x08;

        // flags for bit mode
        private const int MODE_8_BIT = 0x03;
        private const int MODE_4_BIT = 0x02;

        private const int SLAVE_ADDRESS = 0x27; // slave address is 0x27 on a I2C LCD
        private I2cDevice I2C; // I2C Device declaration
        private int DisplayControl = 0;
        public bool exceptioned = false;
        private const int PIN_LOW = 0xFB;

        public void DelayMicroseconds(int uS)
        {
            var tick_to_reach = DateTime.UtcNow.Ticks + uS * 1200;  // 1.2GHz Raspi3 Clock
            while (DateTime.UtcNow.Ticks < tick_to_reach) { }
        }

        public I2C_TO_LCD()
        { }

        public async Task Init()
        {
            try
            {
                var dis = await DeviceInformation.FindAllAsync(I2cDevice.GetDeviceSelector());  // Find the I2C bus controller device
                I2C = await I2cDevice.FromIdAsync(dis[0].Id, new I2cConnectionSettings(SLAVE_ADDRESS) { BusSpeed = I2cBusSpeed.FastMode });  // Create an I2cDevice with our selected bus controller and I2C settings (the bus speed also could be I2cBusSpeed.StandardMode)

                BothToLow();

                // start in 8bit mode, try to set 4 bit mode:
                // Figure 24 https://www.sparkfun.com/datasheets/LCD/HD44780.pdf
                Initial4bits(MODE_8_BIT, 410); // wait min 4.1ms
                Initial4bits(MODE_8_BIT, 410); // wait min 4.1ms
                Initial4bits(MODE_8_BIT, 10); // wait min 0.1ms
                Initial4bits(MODE_4_BIT, 10); // wait min 0.1ms

                BacklightOFF();
                DisplayOff();
                DisplayOn();
                BacklightON();
                ReturnHome();
            }
            catch (Exception e)
            {
                Debug.WriteLine("EXCEPTION! Init: " + e.Message);
                exceptioned = true;
            }
        }

        private void WriteToI2C(int to_write, int delay = 0)
        {
            try
            {
                I2C.Write(new byte[] { (byte)to_write });
                DelayMicroseconds(delay);
            }
            catch (Exception e)
            {
                Debug.WriteLine("EXCEPTION! WriteToI2C: " + e.Message);
            }
        }

        // Facilitate the 4 bit hex string of Figure 24 of https://www.sparkfun.com/datasheets/LCD/HD44780.pdf
        private void Initial4bits(byte message, int delay = 0)
        {
            WriteToI2C(message << 4 | BACKLIGHT, 300);          // valid data comes first
            WriteToI2C(message << 4 | BACKLIGHT | 0x04, 300);  // Enable pin HIGH 
            WriteToI2C(message << 4 & PIN_LOW | BACKLIGHT);    // Enable pin LOW
            DelayMicroseconds(delay);
        }

        // Writing to the LCD 4 bits at a time (4 bit mode), P0 of the I2C expander (PCF8574T) is connected to registerSelect
        // Send to I2C while toggling the En Pin of the LCD or P2 of the I2C expander, datasheet: http://www.ti.com/lit/ds/symlink/pcf8574.pdf
        private void Write4bits(byte message, bool registerSelect)
        {
            if (registerSelect)   // registerSelect = TRUE write data to LCD (display text on LCD) ... need to get P0 of I2C Device high
            {
                WriteToI2C(message | 0x01 | BACKLIGHT);      // valid data comes first, registerSelect is high
                WriteToI2C(message | 0x05 | BACKLIGHT);      // enable pin HIGH
            }
            else  // registerSelect = FALSE command to LCD (instruction to LCD) ... need to get P0 of I2C Device low 
            {
                WriteToI2C(message | BACKLIGHT);            // valid data comes first
                WriteToI2C(message | 0x04 | BACKLIGHT);     // enable Pin HIGH                
            }

            WriteToI2C(message & PIN_LOW | BACKLIGHT);  // enable pin LOW
        }

        private void Send4bits(byte message, bool registerSelect)
        {
            Write4bits((byte)((byte)((message >> 4) & 0x0F) << 4), registerSelect);  // higher hex digit
            Write4bits((byte)(message << 4), registerSelect);  // lower hex digit
        }

        private void SendCommand(int message)
        {
            Send4bits((byte)message, false); // false - it is a command
        }

        private void SendString(string text)
        {
            var data = Encoding.UTF8.GetBytes(text);

            foreach (byte ch in data)
                Send4bits(ch, true);  // true - it is a data
        }


        private void BothToLow()
        {   // during second start there is a problem, so it is needed to repeat the commands
            try
            {
                WriteToI2C(SLAVE_ADDRESS);
                WriteToI2C(0x00);
            }
            catch (Exception e)
            {
                Debug.WriteLine("EXCEPTION! BothToLow: " + e.Message);
                try
                {
                    Initial4bits(MODE_8_BIT); // first set to 8bit
                    BothToLow(); // then repeat everything
                }
                catch { }
            }
        }

        public void SendTwoStringRows(string[] two_rows_string)
        {
            SendString(two_rows_string[0]);
            SendCommand(GO_TO_SECOND_ROW);
            SendString(two_rows_string[1]);
        }

        private void BacklightON()
        {
            BACKLIGHT |= BACKLIGHT_ON;
        }

        private void BacklightOFF()
        {
            BACKLIGHT &= ~(BACKLIGHT_ON);
        }

        private void DisplayOn()
        {
            DisplayControl |= DISPLAY_ON;
            SendCommand(DISPLAY_CONTROL | DisplayControl);
        }

        private void DisplayOff()
        {
            DisplayControl &= ~DISPLAY_ON;
            SendCommand(DISPLAY_CONTROL | DisplayControl);
        }

        private void ReturnHome()
        {
            SendCommand(RETURN_HOME);
        }

    }
}
