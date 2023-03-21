using System;

namespace Alarm
{
    public class AlarmRing
    {
        void tickHandle()
        {
            Console.WriteLine("Tick");
        }
        void alarmHandle()
        {
            Console.WriteLine("Alarm");
        }
        public void Ring()
        {
            Alarm alarm = new Alarm();
            alarm.SendAlarmMessage += alarmHandle;
            alarm.SendTickMessage += tickHandle;
            alarm.Ring();
        }
    }
}