// See https://aka.ms/new-console-template for more information


using System.ComponentModel;
using CarLib.model;

Car c = new Car();
c.PropertyChanging+= delegate(object? sender, PropertyChangingEventArgs eventArgs)
{
    if (eventArgs.PropertyName == "RegNo")
    {
        Console.WriteLine("I am in");
    }

};

c.RegNo = "123456";


List<String> list = new List<String>();
for (int i = 0; i < 11; i++)
{
    list.Add("Course" + i);

}
TeacherValidator.ValidateCourses(list);


