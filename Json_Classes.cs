
using System.Text.Json.Serialization;

class Course
{
    public int _courseID;
    public string? _courseName;//? - marks that the filed is nullable
    public double _rating = 1;

    [JsonPropertyName("courseID")]
    public int CourseID
    {
        //use expression body definitions
        get => _courseID;
        set => _courseID = value;
    }

    [JsonPropertyName("courseName")]
    public string? CourseName
    {
        get => _courseName;
        set => _courseName = value;
    }

    [JsonPropertyName("rating")]
    public double Rating
    {
        get => _rating;
        set
        {
            if (value > 0 && value < 5)
                _rating = value;
        }
    }

    [JsonPropertyName("students")]
    public List<Student> Students { get; set; }

    public override string ToString() => $"Course ID {_courseID} Course Name {_courseName} Rating {_rating}\n";
}

class Student
{
    private string _studentID;
    private int _hoursWatched;

    [JsonPropertyName("studentID")]
    public string StudentID
    {
        get => _studentID;
        set => _studentID = value;
    }

    [JsonPropertyName("hoursWatched")]
    public int HoursWatched
    {
        get => _hoursWatched;   
        set => _hoursWatched = value;
    }

    public override string ToString()
    {
        return $"Student ID: {_studentID} Hours Watched: {_hoursWatched}";
    }
}

