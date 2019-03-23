using SharpDX.DirectInput;
using System;
using System.Threading;

namespace BuzzerCommander.Util
{
    // Adapted from: codereview.stackexchange.com/questions/68711/joystick-helper-class
    public class BuzzerService
    {
        private DirectInput _DirectInput;
        private Joystick _Joystick;
        private Thread _PollingThread;

        public BuzzerService()
        {
            // Initialize DirectInput
            _DirectInput = new DirectInput();
        }

        public void StartCapture()
        {
            // Look for a Joystick
            Guid joystickGuid = Guid.Empty;
            foreach (var deviceInstance in _DirectInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
            {
                joystickGuid = deviceInstance.InstanceGuid;
            }

            // Initialize the joystick
            _Joystick = new Joystick(_DirectInput, joystickGuid);
            _Joystick.Properties.BufferSize = 128;
            _Joystick.Acquire();
            _PollingThread = new Thread(new ThreadStart(PollBuzzer));
            _PollingThread.Start();

            // Spin for a while waiting for the started thread to become alive
            while (!_PollingThread.IsAlive) ;
        }

        public void StopCapture()
        {
            if (_PollingThread != null)
            {
                _PollingThread.Abort();
                _PollingThread.Join();
            }

            if (_Joystick != null)
            {
                _Joystick.Dispose();
            }
        }

        public void PollBuzzer()
        {
            while (true)
            {
                _Joystick.Poll();
                JoystickUpdate[] datas = _Joystick.GetBufferedData();
                foreach (JoystickUpdate state in datas)
                {
                    if (state.Offset >= JoystickOffset.Buttons0 && state.Offset <= JoystickOffset.Buttons127)
                    {
                        if (state.Value == 128)
                        {
                            BuzzerButtonPressedEventArgs args = new BuzzerButtonPressedEventArgs();
                            if (state.Offset == JoystickOffset.Buttons10)
                            {
                                args.Buzzer = Buzzer.BuzzerA;
                            }
                            else if (state.Offset == JoystickOffset.Buttons11)
                            {
                                args.Buzzer = Buzzer.BuzzerB;
                            }
                            args.TimeStamp = DateTime.Now;
                            OnBuzzerPressed(args);
                        }
                    }
                }
                Thread.Sleep(10);
            }
        }

        public event EventHandler<BuzzerButtonPressedEventArgs> BuzzerPressed;
        protected virtual void OnBuzzerPressed(BuzzerButtonPressedEventArgs e)
        {
            BuzzerPressed?.Invoke(this, e);
        }
    }

    public class BuzzerButtonPressedEventArgs : EventArgs
    {
        public Buzzer Buzzer { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public enum Buzzer
    {
        None,
        BuzzerA,
        BuzzerB
    }
}