// TODO: implement the ParkingService class from the IParkingService interface.
//       For try to add a vehicle on full parking InvalidOperationException should be thrown.
//       For try to remove vehicle with a negative balance (debt) InvalidOperationException should be thrown.
//       Other validation rules and constructor format went from tests.
//       Other implementation details are up to you, they just have to match the interface requirements
//       and tests, for example, in ParkingServiceTests you can find the necessary constructor format and validation rules.
using CoolParking.BL.Interfaces;
using CoolParking.BL.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CoolParking.BL
{
    public class ParkingService : IParkingService
    {
        List<Vehicle> VehiclColecrion = new List<Vehicle>();
        TimerServices timerServicesStart;
        TimerServices timerServicesEnd;
        LogService logService;

        public ParkingService(ITimerService timerServiceStart, ITimerService timerServiceEnd,ILogService logService) 
        {
            this.timerServicesStart = (TimerServices)timerServiceStart;
            this.timerServicesEnd = (TimerServices)timerServiceEnd;
            this.logService = (LogService)logService;
        }


        public void AddVehicle(Vehicle vehicle)
        {
            VehiclColecrion.Add(vehicle);
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetBalance()
        {
            throw new System.NotImplementedException();
        }

        public int GetCapacity()
        {
            throw new System.NotImplementedException();
        }

        public int GetFreePlaces()
        {
            throw new System.NotImplementedException();
        }

        public TransactionInfo[] GetLastParkingTransactions()
        {
            throw new System.NotImplementedException();
        }

        //Comlated
        public ReadOnlyCollection<Vehicle> GetVehicles()
        {
            return new ReadOnlyCollection<Vehicle>(VehiclColecrion);
        }

        public string ReadFromLog()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveVehicle(string vehicleId)
        {
            for (int i = 0; i < VehiclColecrion.Count; i++)
            {
                if(VehiclColecrion[i].Id == vehicleId)
                {
                    VehiclColecrion.RemoveAt(i);
                    break;
                }
            }
        }

        public void TopUpVehicle(string vehicleId, decimal sum)
        {
            for (int i = 0; i < VehiclColecrion.Count; i++)
            {
                if (VehiclColecrion[i].Id == vehicleId)
                {
                    VehiclColecrion[i].Balance+= sum;
                    break;
                }
            }
        }
    }
}