
using LearningApp;

//Inheritance

//Person person = new Person("Mark", "Brown", 25);
//Console.WriteLine(person.GetDetails());

Instructor instructor = new Instructor("Maggie", "Harrington", 31,3.9,15);
//instructor.setRating(4);
//instructor.setNumberOfStudents(10);
Console.WriteLine(instructor.GetDetails());

//Polymorphism
Student student = new Student("Dave", "Smith", 17,
    new string[] { "AWS Solution Architect", "C# Programming", "Full Stack Web Development - PERN stack" },
    new string[] { "C# Programming", "Full Stack Web Development - PERN stack" });

if (student.GetCourseList() != null)
    foreach (string course in student.GetCourseList())
        Console.WriteLine(course);
else Console.WriteLine("No courses have been taken up by the student");

string[]? wishList = student.GetCourseWishList();
if (wishList != null)
    foreach (string course in wishList)
        Console.WriteLine(course);
else Console.WriteLine("There are no courses in the wishlist.");

Console.WriteLine("--Student Details--\n"+student.GetDetails());

//overriding ToString()
Console.WriteLine(student.ToString());

//strucute type
VideoDetails videoDetails = new VideoDetails(1080,1920,4790);
Console.WriteLine(videoDetails.DisplayVideoDetails());


//enums
Course crs = new Course(1, "Python programming", 4.4, CourseCategory.Software);
Console.WriteLine(crs.GetCourseDetails());