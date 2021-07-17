using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Core.Entities.Concrete;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserAddTest();
            //CarTest();
            //RentalTest();
        }

        //private static void UserAddTest()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());

        //    var result = userManager.Add(new User
        //    {
        //        FirstName = "Veli",
        //        LastName = "Değirmen",
        //        Email = "veli@gmail.com",
        //        Password = "12345678"
        //    });
        //}

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            { CarId = 2, CustomerId = 2, RentDate = new DateTime(2021, 7, 03) });
            Console.WriteLine(result.Message);
        }

        /*
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName);
            }
        }
        */
    }
}
