using System;
namespace Attendance.Tracking{
class Attendance1{
static void Main(){
string title = "The Attendance for Today";
//string date = "04/11/2024";
DateTime date = new DateTime(2024,11,4);
string[] listofstudents = {"Satya", "Bhargav"};
System.Console.WriteLine(title);
System.Console.WriteLine(date);
//System.Console.WriteLine(listofstudents);
foreach (string element in listofstudents)
{
    Console.Write(element);
}


}
}
}