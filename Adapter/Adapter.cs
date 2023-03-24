/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program {
  static void Main() {
    AdapterTomada adapter = new AdapterTomada();
    Client client = new Client(adapter);
    client.ligar("string");
    
    return;
  }
}

class Client : ITomadaTresPinos{
    
    public AdapterTomada Adapter {get;set;}
    public Client(AdapterTomada adapter){
        Adapter = adapter;
    }
    
    public void ligar(string energia){
        Adapter.ligar(energia); // call the adapter to implement the modifications
    }
}

interface ITomadaTresPinos{
    void ligar(string energia);
}

class AdapterTomada : ITomadaTresPinos{
    public AdapterTomada(){}
    
    public void ligar(string energia){
        // adaptations stuff
        TomadaDoisPinos whatweNeed = new TomadaDoisPinos();
        whatweNeed.ligar("string");
    }
}

class TomadaDoisPinos{
    public TomadaDoisPinos(){}
    
    public void ligar(string energia){
        // actual code we need
    }
}