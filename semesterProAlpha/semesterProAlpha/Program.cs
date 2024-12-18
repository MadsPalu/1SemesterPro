using semester1Website.Models;
using semester1Website.Services;
using semesterProAlpha.Models;

Console.WriteLine("json file path:");
Console.WriteLine($"Using file path: {Path.GetFullPath(RepoInitializer.memberRepo.JsonHandler.FilePath)}");
Console.WriteLine("BoatRepo counter:");
Console.WriteLine(RepoInitializer.boatRepo.JsonHandler.Counter);
Console.WriteLine("MemberRepo counter:");
Console.WriteLine(RepoInitializer.memberRepo.JsonHandler.Counter);


// Test Member class
var member1 = new Member("John Doe", "12345678", "123 Main St");
var member2 = new Member("Jane Smith", "87654321", "456 Elm St");
var member3 = new Member("Alice Johnson", "55566677", "789 Oak Ave");
Console.WriteLine("\nMember Test:");
Console.WriteLine(member1);
Console.WriteLine(member2);
Console.WriteLine(member3);

// Test MotorBoat class
var motorBoat = new MotorBoat("Speedster", "Model X", 2020, "10x3x2", "V8", 300, 50.5);
Console.WriteLine("\nMotorBoat Test:");
Console.WriteLine(motorBoat);

// Test RowBoat class
var rowBoat = new RowBoat("RowMaster", "Model Y", 2015, "8x2x1", 4, 2);
Console.WriteLine("\nRowBoat Test:");
Console.WriteLine(rowBoat);

// Test SailBoat class
var sailBoat = new SailBoat("WindRider", "Model Z", 2018, "12x4x3", 3, 5.5);
Console.WriteLine("\nSailBoat Test:");
Console.WriteLine(sailBoat);

// Test ChairMan class
var chairman = new ChairMan(1, "Chairman Name");
Console.WriteLine("\nChairMan Test:");
Console.WriteLine(chairman.GetChairmanInfo());

// Test Event class
var event1 = new Event("2024-01-01", "Test Event", "Description", "Location");
Event.AddEvent(event1);
Console.WriteLine("\nEvent Test:");
Console.WriteLine($"Event: {event1.Title} on {event1.Date} at {event1.Location}");

// Test GenericRepo med medlemmer
var memberRepo = new GenericRepo<Member>("memberData.json", m => m.MemberNumber);
memberRepo.Add(member1);
memberRepo.Add(member2);
memberRepo.Add(member3);
Console.WriteLine("\nGenericRepo Test - Medlemmer:");
Console.WriteLine("Added members:");
Console.WriteLine(memberRepo.Get(member1.MemberNumber));
Console.WriteLine(memberRepo.Get(member2.MemberNumber));
Console.WriteLine(memberRepo.Get(member3.MemberNumber));

// Test GenericRepo med både
var boatRepo = new GenericRepo<Boat>("boatData.json", b => b.Id);
boatRepo.Add(motorBoat);
boatRepo.Add(rowBoat);
boatRepo.Add(sailBoat);
Console.WriteLine("\nGenericRepo Test - Både:");
Console.WriteLine("Added boats:");
Console.WriteLine(boatRepo.Get(motorBoat.Id));
Console.WriteLine(boatRepo.Get(rowBoat.Id));
Console.WriteLine(boatRepo.Get(sailBoat.Id));

// Test Booking class
var booking1 = new Booking(motorBoat.Id, DateTime.Now, DateTime.Now.AddHours(2));
var booking2 = new Booking(rowBoat.Id, DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddHours(3));
var booking3 = new Booking(sailBoat.Id, DateTime.Now.AddDays(2), DateTime.Now.AddDays(2).AddHours(4));
Console.WriteLine("\nBooking Test:");
Console.WriteLine(booking1);
Console.WriteLine(booking2);
Console.WriteLine(booking3);

// Test BookingRepo
var bookingRepo = new BookingRepo();
bookingRepo.Lavbooking(booking1);
bookingRepo.Lavbooking(booking2);
bookingRepo.Lavbooking(booking3);
Console.WriteLine("\nBookingRepo Test:");
Console.WriteLine("All bookings:");
foreach (var booking in bookingRepo.HentAlleBookinger())
{
    Console.WriteLine(booking);
}

Console.WriteLine("\nAlle tests blev kørt.");
