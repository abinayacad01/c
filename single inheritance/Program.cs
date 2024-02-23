using System;
    public class Nothing{
    public void nothing1(){
        Console.WriteLine("this is nothing");
    }
} 
public class Bunk : Nothing{
    public void nothing2(){
        Console.WriteLine("this is also nothing");
    }
}

class Program{
    static void Main(string[] args){
        Bunk nthg = new Bunk();

        nthg.nothing1();
        nthg.nothing2();
    }
}