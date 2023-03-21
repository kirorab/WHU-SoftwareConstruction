using System;
using System.Threading;

namespace Alarm
{
    public delegate void AlarmActionHandle();
    public class Alarm
    {
        public event AlarmActionHandle SendAlarmMessage;
        public event AlarmActionHandle SendTickMessage;

        public void Ring()
        {
            // send tick and alarm every second
            while (true)
            {
                if (SendAlarmMessage == null)
                {
                    throw new NullReferenceException("Don't have any AlarmActionHandle");
                }
                if (SendTickMessage == null)
                {
                    throw new NullReferenceException("Don't have any AlarmActionHandle");
                }
                SendTickMessage();
                SendAlarmMessage();
                Thread.Sleep(1000);
            }
        }
    }
}