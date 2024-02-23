public class  Aibatch{
    public void aiabout(){
        Console.WriteLine("");
        Console.WriteLine("This is artificial intelligence course.");
        Console.WriteLine("");
        Console.WriteLine("classes are taken by mr.karthick");
        Console.WriteLine("________________________________________________");
      }

    public void aitime(){
        Console.WriteLine("");
        Console.WriteLine("cad is evening batch");
        Console.WriteLine("");
        Console.WriteLine("It is 4 hrs duration");
        Console.WriteLine("");
        Console.WriteLine("It starts from 9.30 am to 1.30 pm");
        Console.WriteLine("________________________________________________");
    }
    
    public void aicourse(){
        string[] aicourses = {"C","C++","Python","Java","Sql"};
        Console.WriteLine("");
        Console.WriteLine("The courses provided in cad batch : ");
        Console.WriteLine("");
        foreach (string course in aicourses)
            {
                Console.WriteLine("- " + course);
            }
        Console.WriteLine("________________________________________________");
    }
}
