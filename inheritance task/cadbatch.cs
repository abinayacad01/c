public class  Cadbatch{
    public void cadabout(){
        Console.WriteLine("");
        Console.WriteLine("This is cloud applicant developing course.");
        Console.WriteLine("");
        Console.WriteLine("classes are taken by mr.karthick");
        Console.WriteLine("________________________________________________");
      }

    public void cadtime(){
        Console.WriteLine("");
        Console.WriteLine("cad is morning batch");
        Console.WriteLine("");
        Console.WriteLine("It is 4 hrs duration");
        Console.WriteLine("");
        Console.WriteLine("It starts from 2 pm to 6 pm");
        Console.WriteLine("________________________________________________");
    }
    
    public void cadcourse(){
        string[] cadcourses = {"Html","Css","Js","C#",".net"};
        Console.WriteLine("");
        Console.WriteLine("The courses provided in cad batch : ");
        Console.WriteLine("");
        foreach (string course in cadcourses)
            {
                Console.WriteLine("- " + course);
            }
        Console.WriteLine("________________________________________________");
    }
}