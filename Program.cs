
using System.Text.Json;
using LearningApp;

string path = @"C:\Users\kalay\.net\ConsoleApp1\ConsoleApp1\courses.json";

StreamReader streamReader = File.OpenText(path);

string jsonObj = streamReader.ReadToEnd(); //reads all chars in file as a string

//Console.WriteLine(jsonObj);

List<Course> courses = new List<Course>();
courses=JsonSerializer.Deserialize<List<Course>>(jsonObj);


foreach (Course course in courses)
    Console.WriteLine(course);