﻿// TODO: implement the LogService class from the ILogService interface.
//       One explicit requirement - for the read method, if the file is not found, an InvalidOperationException should be thrown
//       Other implementation details are up to you, they just have to match the interface requirements
//       and tests, for example, in LogServiceTests you can find the necessary constructor format.
using CoolParking.BL.Interfaces;

namespace CoolParking.BL
{
    public class LogService : ILogService
    {
        public string puch;

        public LogService(string puch)
        {
            this.puch = puch;
        }

        public string LogPath => throw new System.NotImplementedException();

        public string Read()
        {
            throw new System.NotImplementedException();
        }

        public void Write(string logInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}
