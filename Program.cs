﻿using System;

// class Abi{
//     static void Main(string [] args){
//         Console.WriteLine("added value is");
//         Beaut her = new Beaut();
//         her.g();

//     }
// }

// public class Beaut{
//     int a=20;
//     int b=90;
//     int c;

//     public Beaut(){
//         c = a + b;
//     }
//  public void g(){
//         Console.WriteLine(c);
//         if (c>100){
//           Console.WriteLine("its greater than 100");
//         }
//         else{
//           Console.WriteLine("its less than 100");
//         }
        
//     }
// }



//using string


// class Abu{

//   static void Main(string [] args) {
//     Console.WriteLine("abu is a");
//     Stoic tt=new Stoic();
//     tt.pers();
//     tt.pers2();

//   }
// }


// public class Stoic {
//   string abu="goddess";

//   public void pers(){
//     Console.WriteLine(abu);
//   }

//   public void pers2(){
//     Console.WriteLine("a born " + abu);
//   }

// }


// class Abi{
//     static void Main(string [] args){
//         Console.WriteLine("added value is");
//         Beaut her = new Beaut();
//         her.g();
//         her.booboo();

//     }
// }

// public class Beaut{
//     int a=20;
//     int b=90;
//     int c;

//     public Beaut(){
//         c = a + b;
//     }
//  public void g(){
//         Console.WriteLine(c);
//         if (c>100){
//           Console.WriteLine("its greater than 100");
//         }
//         else{
//           Console.WriteLine("its less than 100");
//         }
        
//     }

// public void booboo(){
//     do{
//         Console.WriteLine(c);
//         c++;
//     }
//     while(c<120);
// }
// }

// class arithmetic{
//      static void Main(string [] args){
//          Function aa = new Function();
//          aa.ll();
//          aa.mm();
//          aa.oo();
//      }
//  }

//  public class Function {
//      public void ll(){
//      int a=20;
//      int b=10;
//      int add=a+b;
//      Console.WriteLine("added value is "+add);
//      int sub=a-b;
//      Console.WriteLine("subracted value is "+sub);
//      int mul=a*b;
//      Console.WriteLine("product value is "+mul);
//      int div=a/b;
//      Console.WriteLine("divided value is "+div);
//      int mod=a%b;
//      Console.WriteLine("modulus value is "+mod);
//  }

//  public void mm(){
//     int x=100;
//     int y=110;
//     if(x==y){
//         Console.WriteLine("x is equals to y");
//      }
//     else{
//         if(x>y){
//           Console.WriteLine("x is greater than y");  
//         }

//         else if(y>x){
//             Console.WriteLine("x is less than y");
//         }
//         else{
//             Console.WriteLine("x is not equals to y");
//         }
//     }
//  }

//  public void oo(){
//     var l=78;
// var output1=(40<=l && l<=69)? "wrong" :(76<=l && l<=100) ? "correct" : "none";
// Console.WriteLine(output1);
// }
//  }


public class Inheritance{
    public string you="you don't need anyone";
}
public class Lolo:Inheritance{
    public string me="be in the delulu";
}

class Test{
    public static void Main(string[] args){
        Lolo p=new Lolo();

        Console.WriteLine("delulu:"+p.you);
        Console.WriteLine("solulu:"+p.me);
    }
}