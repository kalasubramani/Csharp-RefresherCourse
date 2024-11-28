

//anonymous fn
//function delegate
Func<int,int,int> Add =(int x, int y) => { return (x + y); };
Console.WriteLine("function delegate "+Add(1, 2));


//Predicate delegate
Console.WriteLine("--Predicate delegate--");
List<int> list = new List<int>() {1,2,3,4,5 };
//define predicate
//create a lambda tat points to an anonymous fn
Predicate<int> DisplayRange = (int x) => { bool v = x < 3; return v; };
List<int> filteredList = list.FindAll(DisplayRange);

foreach(int x in filteredList)
    Console.WriteLine(x);

//Anonymous TYpes"
Console.WriteLine("--Anonymous TYpes");
var course = new { courseId = 76, CourseName = "Python programming", CourseRating = 3.9 };
Console.WriteLine(course);
Console.WriteLine(course.CourseName);