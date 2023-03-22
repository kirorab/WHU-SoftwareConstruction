using System;

namespace Alarm
{
    public class AlarmRing
    {
        void TickHandle()
        {
            Console.WriteLine("Tick");
        }
        void AlarmHandle()
        {
            Console.WriteLine("Alarm");
        }
        public void Ring()
        {
            Alarm alarm = new Alarm();
            alarm.SendAlarmMessage += AlarmHandle;
            alarm.SendTickMessage += TickHandle;
            alarm.Ring();
        }
    }
}