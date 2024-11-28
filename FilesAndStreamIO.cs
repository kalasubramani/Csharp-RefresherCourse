

//file class
string path = @"C:\Users\kalay\.net\ConsoleApp1\ConsoleApp1\t1.txt";

//check if file exists in path
Console.WriteLine($"Does the file exist? - {File.Exists(path)}");

//create new file and add contents
string path1 = @"C:\Users\kalay\.net\ConsoleApp1\ConsoleApp1\t2.txt";
StreamWriter streamWriter= File.CreateText(path1);
streamWriter.WriteLine("We are creating a new file via c#");
streamWriter.WriteLine("We are using the Stream Writer class");
streamWriter.Flush();
streamWriter.Close();
Console.WriteLine("File created. You can check the path mentioned and verify it.");


//directory class
//check if a directory exists
string path2 = @"C:\Users\kalay\.net\ConsoleApp1\ConsoleApp1";
Console.WriteLine($"Does the directory exists ? {Directory.Exists(path2)}");

var files = Directory.EnumerateFiles(path2);
foreach (var f in files)
    Console.WriteLine(path.Length+f.Substring(path.Length+1));


    //Stream reader
    StreamReader streamreader = File.OpenText(path1);
if(!(StreamReader == null))
{
    string line;
    
    while((line = StreamReader.ReadLine())!=null)
        Console.WriteLine(line);
}