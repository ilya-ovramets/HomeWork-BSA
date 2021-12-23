// TODO: implement class Vehicle.
//       Properties: Id (string), VehicleType (VehicleType), Balance (decimal).
//       The format of the identifier is explained in the description of the home task.
//       Id and VehicleType should not be able for changing.
//       The Balance should be able to change only in the CoolParking.BL project.
//       The type of constructor is shown in the tests and the constructor should have a validation, which also is clear from the tests.
//       Static method GenerateRandomRegistrationPlateNumber should return a randomly generated unique identifier.
using System;


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

        static string GenerateRandomRegistrationPlateNumber()
        {
            Random rand = new Random();
            string number = "ХХ-YYYY-XX";
            string result = "";
            for (int i = 0; i < number.Length; i++)
            {
                if(number[i] == '-')
                {
                    result += '-';
                    continue;
                }               
                if (number[i] == 'X')
                {
                    result += Convert.ToChar(rand.Next(65,90));
                }
                if (number[i] == 'Y')
                {
                    result += rand.Next(0,9).ToString();
                }
            }
            return number;
        }
    }
}