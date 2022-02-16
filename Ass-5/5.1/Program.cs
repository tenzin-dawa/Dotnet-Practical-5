using System;
using System.Collections.Generic;
using System.Text;
class Program 
{
    static void Main(string[] args) 
    {
        Indica i = new Indica("PETROL",4,"GJ 01 AB 1031", VehicleInterface.Renttype.DAY,9,5, new DateOnly(2022,01,02));
        Qualis q = new Qualis("CNG",8,"DL 02 CD 1009", VehicleInterface.Renttype.KILOMETER,5,7, new DateOnly(2021,12,15));
        DavidHarley dh1 = new DavidHarley("PETROL",2,"MH 03 EF 1010",VehicleInterface.Renttype.DAY,2,10,new DateOnly(2022,02,14));
        DavidHarley dh2 = new DavidHarley("DIESEL",4,"UK 04 GH 1010",VehicleInterface.Renttype.KILOMETER,2,8,new DateOnly(2022,02,01));
        MBenz mb = new MBenz("PETROL",4, "KA 05 IJ 2510", VehicleInterface.Renttype.KILOMETER,4,15, new DateOnly(2022,01,14));
        RentedVehicle<VehicleInterface> RentedVehicle = new RentedVehicle<VehicleInterface>();

        RentedVehicle.AddVehicle(i);
        RentedVehicle.AddVehicle(q);
        RentedVehicle.AddVehicle(dh1);
        RentedVehicle.AddVehicle(dh2);
        RentedVehicle.AddVehicle(mb);

        RentedVehicle.GiveForRent(i, new DateOnly(2022,01,10), new DateOnly(2022,01,31),250);
        RentedVehicle.GiveForRent(mb, new DateOnly(2022,03,09), new DateOnly(2022,03,31),500);
        RentedVehicle.GiveForRent(dh1, new DateOnly(2022,04,15), new DateOnly(2022,04,25),400);

        Console.Write("\nCar Details of David Harley : ");
        dh1.getData();
        Console.Write($"\nTOTAL RENT PER DAY : {RentedVehicle.CalculateTotalRentToday(dh1, 67):C2}");
        Console.Write("\n***************************************************");
        Console.Write("\n\nNUMBER OF VEHICLES RENTED :");
        RentedVehicle.GetCheckListRentedAndAvailableVehicle();
        Console.Write("\n***************************************************");
        Console.Write("\n\nAVAILABILITY OF VEHICLES BEFORE 12 MAR 2022 :");
        RentedVehicle.ShowAvailabilityForBookingForGivendateByDate(new DateOnly(2022,03,12));
    }
}
internal interface VehicleInterface 
{
    internal decimal CalculateRent(int usageUNITS);
    internal void getData();
    internal DateOnly getLastMaintenanceDate();
    internal enum Renttype
    {
        KILOMETER,DAY
    }
}
internal class Indica : VehicleInterface 
{
    internal int age, rentperunit, totalseats;
    internal string? type, numberplate;
    internal VehicleInterface.Renttype renttype;
    internal DateOnly lastmaintenancedate;
    internal Indica(string type, int totalseats, string numberplate,VehicleInterface.Renttype rentType, int age, int rentperunit, DateOnly lastmaintenancedate) 
    {
        this.type = type;
        this.totalseats = totalseats;
        this.rentperunit = rentperunit;
        this.age = age;
        this.numberplate = numberplate;
        renttype = rentType;
        this.lastmaintenancedate = lastmaintenancedate;
    }
    public decimal CalculateRent(int UNITS) 
    {
        return (decimal)rentperunit*UNITS;
    }
    public void getData()
    {
        Console.Write("\nBrand : Indica \n");
        Console.Write($"Fuel Type : {type}\n");
        Console.Write($"Total no. of seats : {totalseats}\n");
        Console.Write($"Rent per unit : {rentperunit}\n");
        Console.Write($"Age of car : {age}\n");
        Console.Write($"Number Plate : {numberplate}\n");
    }
    public DateOnly getLastMaintenanceDate() 
    {
        return lastmaintenancedate;
    }
}
internal class Qualis : VehicleInterface 
{
    internal int age, rentperunit, totalseats;
    internal string? type, numberplate;
    internal VehicleInterface.Renttype renttype;
    internal DateOnly lastmaintenancedate;
    internal Qualis(string type, int totalseats, string numberplate,VehicleInterface.Renttype rentType, int age, int rentperunit, DateOnly lastmaintenancedate) 
    {
        this.type = type;
        this.totalseats = totalseats;
        this.rentperunit = rentperunit;
        this.age = age;
        this.numberplate = numberplate;
        renttype = rentType;
        this.lastmaintenancedate = lastmaintenancedate;
    }
    public decimal CalculateRent(int UNITS) 
    {
        return (decimal)rentperunit*UNITS;
    }
    public void getData()
    {
        Console.Write("\nBrand : Qualis \n");
        Console.Write($"Fuel Type : {type}\n");
        Console.Write($"Total no. of seats : {totalseats}\n");
        Console.Write($"Rent per unit : {rentperunit}\n");
        Console.Write($"Age of car : {age}\n");
        Console.Write($"Number Plate : {numberplate}\n");
    }
    public DateOnly getLastMaintenanceDate() 
    {
        return lastmaintenancedate;
    }
}
internal class DavidHarley : VehicleInterface 
{
    internal int age, rentperunit, totalseats;
    internal string? type, numberplate;
    internal VehicleInterface.Renttype renttype;
    internal DateOnly lastmaintenancedate;
    internal DavidHarley(string type, int totalseats, string numberplate,VehicleInterface.Renttype rentType, int age, int rentperunit, DateOnly lastmaintenancedate) 
    {
        this.type = type;
        this.totalseats = totalseats;
        this.rentperunit = rentperunit;
        this.age = age;
        this.numberplate = numberplate;
        renttype = rentType;
        this.lastmaintenancedate = lastmaintenancedate;
    }
    public decimal CalculateRent(int UNITS) 
    {
        return (decimal)rentperunit*UNITS;
    }
    public void getData()
    {
        Console.Write("\nBrand : David Harley \n");
        Console.Write($"Fuel Type : {type}\n");
        Console.Write($"Total no. of seats : {totalseats}\n");
        Console.Write($"Rent per unit : {rentperunit}\n");
        Console.Write($"Age of car : {age}\n");
        Console.Write($"Number Plate : {numberplate}\n");
    }
    public DateOnly getLastMaintenanceDate() 
    {
        return lastmaintenancedate;
    }
}
internal class MBenz : VehicleInterface 
{
    internal int age, rentperunit, totalseats;
    internal string? type, numberplate;
    internal VehicleInterface.Renttype renttype;
    internal DateOnly lastmaintenancedate;
    internal MBenz(string type, int totalseats, string numberplate,VehicleInterface.Renttype rentType, int age, int rentperunit, DateOnly lastmaintenancedate) 
    {
        this.type = type;
        this.totalseats = totalseats;
        this.rentperunit = rentperunit;
        this.age = age;
        this.numberplate = numberplate;
        renttype = rentType;
        this.lastmaintenancedate = lastmaintenancedate;
    }
    public decimal CalculateRent(int UNITS) 
    {
        return (decimal)rentperunit*UNITS;
    }
    public void getData()
    {
        Console.Write("\nBrand : Mercedes Benz \n");
        Console.Write($"Fuel Type : {type}\n");
        Console.Write($"Total no. of seats : {totalseats}\n");
        Console.Write($"Rent per unit : {rentperunit}\n");
        Console.Write($"Age of car : {age}\n");
        Console.Write($"Number Plate : {numberplate}\n");
    }
    public DateOnly getLastMaintenanceDate() 
    {
        return lastmaintenancedate;
    }
}
public class TypeOfCar <T> 
{
    internal T CarObject;
    internal int UNITS;
    internal decimal AdvancePayment;
    internal DateOnly InitialDate,FinalDate;
    internal TypeOfCar(T CarObject) 
    {
        this.CarObject = CarObject;
    }
    internal TypeOfCar(T CarObject, DateOnly InitialDate,DateOnly FinalDate, decimal AdvancePayment) 
    {
        this.CarObject = CarObject;
        this.AdvancePayment=AdvancePayment;
        this.InitialDate = InitialDate;
        this.FinalDate = FinalDate;
    }
    internal int CalculateDays() 
    {
        int day = FinalDate.Day - InitialDate.Day;
        int month = FinalDate.Month - InitialDate.Month;
        int year = FinalDate.Year - InitialDate.Year;
        return day + month + year;
    }
}
internal class RentedVehicle <T> 
{
    List<TypeOfCar<T>> VehicleList;
    internal RentedVehicle() 
    {
        VehicleList = new List<TypeOfCar<T>>();
    }
    internal void AddVehicle(T CarObject) 
    {
        TypeOfCar<T> c = new TypeOfCar<T>(CarObject);
    }
    internal void GiveForRent(T CarObject, DateOnly InitialDate, DateOnly FinalDate, decimal AdvancePay) 
    {
        TypeOfCar<T> c = new TypeOfCar<T>(CarObject, InitialDate, FinalDate, AdvancePay);
        VehicleList.Add(c);
    }
    internal decimal CalculateRent(T CarObject, int UNITS) 
    {
        foreach(TypeOfCar<T> c in VehicleList) 
        {
            if(c.CarObject!.Equals(CarObject)) 
            {
                c.UNITS = UNITS;
                return ((VehicleInterface)CarObject).CalculateRent(UNITS) - c.AdvancePayment;
            }
        }
        return 0;
    }
    internal decimal CalculateTotalRentToday(T CarObject, int UNITSCOVERED) 
    {
        foreach(TypeOfCar<T> c in VehicleList) 
        {
            if(c.CarObject!.Equals(CarObject)) 
            {
                return (((VehicleInterface)CarObject).CalculateRent(UNITSCOVERED) - c.AdvancePayment)/c.CalculateDays();
            }
        }
        return 0;
    }
    internal void GetCheckListRentedAndAvailableVehicle() 
    {
        foreach(TypeOfCar<T> c in VehicleList) 
        {
            ((VehicleInterface)c.CarObject!).getData();
            Console.Write($"\nTAKEN ON RENT FROM {c.InitialDate} TO {c.FinalDate}\n");
        }
    }
    internal bool GetCheckListVehiclesInMaintenance(T CarObject) 
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        foreach(TypeOfCar<T> c in VehicleList) 
        {
            VehicleInterface car = ((VehicleInterface)c.CarObject!);
            if(c.CarObject!.Equals(CarObject) && car.getLastMaintenanceDate().CompareTo(today) > 0)
                return true;
        }
        return false;
    }
    internal void
    ShowAvailabilityForBookingForGivendateByDate(DateOnly date) 
    {
    Console.Write($"\n\nVEHICLES AVAILABLE ON : {date}");
    foreach(TypeOfCar<T> c in VehicleList) 
    {
        if(c.InitialDate.CompareTo(date) > 0) 
        {
            ((VehicleInterface)c.CarObject!).getData();
        }
    }
}
}
