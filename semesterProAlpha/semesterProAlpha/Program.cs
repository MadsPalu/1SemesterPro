// Test Member class
using semesterProAlpha.Models;
using semesterProAlpha.Services;

var member = new Member("John Doe", "12345678", "123 Main St");
Console.WriteLine("Member Test:");
Console.WriteLine(member);

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

// Test GenericRepo
var memberRepo = new GenericRepo<Member>("test.json", m => m.MemberNumber);
memberRepo.Add(member);
Console.WriteLine("\nGenericRepo Test:");
Console.WriteLine("Added member: " + memberRepo.Get(member.MemberNumber));

Console.WriteLine("\nAll tests completed successfully.");