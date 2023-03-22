using System;
using System.Threading;

namespace Alarm
{
    public delegate void AlarmActionHandle();
    public class Alarm
    {
        public event AlarmActionHandle SendAlarmMessage;
        public event AlarmActionHandle SendTickMessage;

        public void Tick()
        {
            while (true)
            {
                if (SendTickMessage == null)
                {
                    throw new NullReferenceException("Don't have any AlarmActionHandle");
                }
                SendTickMessage();
                Thread.Sleep(1000);
            }
        }
        
        
        public void Ring()
        {
            if (SendAlarmMessage == null)
                {
                    throw new NullReferenceException("Don't have any AlarmActionHandle");
                }
            SendAlarmMessage();
        }
    }
}