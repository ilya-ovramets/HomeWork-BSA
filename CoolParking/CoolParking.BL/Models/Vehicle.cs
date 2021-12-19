// TODO: implement class Vehicle.
//       Properties: Id (string), VehicleType (VehicleType), Balance (decimal).
//       The format of the identifier is explained in the description of the home task.
//       Id and VehicleType should not be able for changing.
//       The Balance should be able to change only in the CoolParking.BL project.
//       The type of constructor is shown in the tests and the constructor should have a validation, which also is clear from the tests.
//       Static method GenerateRandomRegistrationPlateNumber should return a randomly generated unique identifier.

namespace CoolParking.BL.Models
{
    public class Vehicle
    {
        public readonly string Id;
        public readonly VehicleType VehicleType;
        public decimal Balance;

        public Vehicle(string Id, VehicleType VehicleType, decimal Balance)
        {
            this.Id = Id;
            this.VehicleType = VehicleType;
            this.Balance = Balance;
        }
    }
}