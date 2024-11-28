
using System.Text.Json;


string path = @"C:\Users\kalay\.net\ConsoleApp1\ConsoleApp1\courses.json";

StreamReader streamReader = File.OpenText(path);

string jsonObj = streamReader.ReadToEnd(); //reads all chars in file as a string

//Console.WriteLine(jsonObj);

List<Course> courses = new List<Course>();
//add null gorgiving operator to suppress nullable warnings
//deserializer - maps JSON obj to respective getter setter in given class
//must have - get&set , properties with same casing as in JSON attributes
//if not mention JSON attribute names
courses=JsonSerializer.Deserialize<List<Course>>(jsonObj)!;


foreach (Course course in courses) { 
    Console.WriteLine(course);
    if (course.Students != null) { 
        Console.WriteLine("Student Details");
        Console.WriteLine("===============");
        foreach (Student student in course.Students) 
            Console.WriteLine(student);
    }
}