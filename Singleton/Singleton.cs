/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program {
  static void Main() {
      
    Console.WriteLine(Singleton.Instance == null);
    
    return;
  }
}

class Singleton{

    public static Singleton Instance{
        get{
            if(Instance == null){
                Instance = new Singleton();
            }
            return Instance;
        }
        set{
            Instance = value;
        }
    }
    private Singleton() {}
}
