public class Brightservices{
    static void Main(string [] args){
        Cadbatch cad = new Cadbatch();
        cad.cadabout();
        cad.cadtime();
        cad.cadcourse();


        
        Aibatch ai = new Aibatch();
        ai.aiabout();
        ai.aitime();
        ai.aicourse(); 

        Console.WriteLine();

        Studentscad stdcad = new Studentscad();
        stdcad.std1();

        Console.WriteLine("________________________________________________");

         Console.WriteLine();

         Studentsai stdai = new Studentsai();
        stdai.std1();

        Console.WriteLine("________________________________________________");
    }
    
}
