// TODO: implement class TimerService from the ITimerService interface.
//       Service have to be just wrapper on System Timers.
using CoolParking.BL.Interfaces;
using System.Threading;
using System.Timers;

namespace CoolParking.BL
{
    public class TimerServices : ITimerService
    {
        public double Interval { get; set; }

        public Thread t1;
        System.Timers.Timer aTimer;

        public event ElapsedEventHandler Elapsed;

        public void Dispose()
        {
            
        }

        public void Start()
        {
            aTimer = new System.Timers.Timer(Interval);
            aTimer.Enabled = true;
            Elapsed += OnTimedEvent;
            aTimer.Elapsed += Elapsed;
        }

        public void Stop()
        {
            aTimer.Stop();
            aTimer.Dispose();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Dispose();
        }
    }
}