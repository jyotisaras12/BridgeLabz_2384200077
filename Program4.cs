using System;
class HotelBooking{
    //declaring fields
    public string GuestName { get; set; }
    public string RoomType { get; set; }
    public int Nights { get; set; }

    //default constructor
    public HotelBooking(){
        GuestName = "Aman";
        RoomType = "Standard";
        Nights = 1;
    }

    //parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights){
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    //copy constructor
    public HotelBooking(HotelBooking booking){
        GuestName = booking.GuestName;
        RoomType = booking.RoomType;
        Nights = booking.Nights;
    }

    //method to calculate the total price based on room type and nights
    public double CalculateTotalPrice(){
        double pricePerNight;
		switch (RoomType){
            case "Standard":
                pricePerNight = 1000;
                break;
            case "Deluxe":
                pricePerNight = 2000;
                break;
            case "Suite":
                pricePerNight = 3500;
                break;
            default:
                pricePerNight = 4000; //for unknown room types
                break;
        }
        return pricePerNight * Nights;
    }

    //method to display booking details
    public void DisplayBookingInfo(){
        Console.WriteLine("Guest Name: {0}\nRoom Type: {1}\nNights: {2}\nTotal Price: {3}", GuestName, RoomType, Nights, CalculateTotalPrice());
    }
}

class Program4{
    static void Main(string[] args){
        //using the default constructor
        HotelBooking booking1 = new HotelBooking();
        Console.WriteLine("Booking 1:");
        booking1.DisplayBookingInfo();

        //using the parameterized constructor
        HotelBooking booking2 = new HotelBooking("Vishi", "Deluxe", 2);
        Console.WriteLine("Booking 2:");
        booking2.DisplayBookingInfo();

        //using the copy constructor
        HotelBooking booking3 = new HotelBooking(booking2);
        Console.WriteLine("Booking 3 (copy of booking 2):");
        booking3.DisplayBookingInfo();
    }
}
