using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausaufgaben_06._09._2016
{
  class Program
  {
    static void Main(string[] args)
    {
      //Definition der Variabelen
      string txtVar;
      int intVar;
      double dblVar;
      float fltVar;
      char chrVar;
      bool bolVar;

      //Zuweisen eines Wertes
      txtVar = "Das ist ein Text";
      intVar = 2016;
      dblVar = 25.43;
      chrVar = 'Z';
      fltVar = 772.2f;
      bolVar = true;

      //Ausgabe (Als String)
      //Die Methode [variabele].toString() wandelt eine beliebige Variabele in einen String um
      Console.WriteLine(txtVar);
      Console.WriteLine(intVar.ToString());
      Console.WriteLine(dblVar.ToString());
      Console.WriteLine(chrVar.ToString());
      Console.WriteLine(fltVar.ToString());
      Console.WriteLine(bolVar.ToString());

      //Jetzt werden mit '+' Strings(Zeichenketten) aneinander gehangen
      Console.WriteLine("Das ist der Text: " + txtVar + ". Und das ist eine Ganzzahl: " + intVar.ToString());

      //Das ist das gleiche wie oben, nur mit Platzhaltern anstelle von den Variabelen 
      Console.WriteLine("Das ist der Text: {0}. Und das ist ne Ganzzahl: {1}.", txtVar, intVar);

      //Übung 3
      int iValue = 17;
      double dWert = 3.3;
      //iValue = dWert; Diese Zeile funktioniert nicht, da man keine Gleitkommazahl in eine Int schreiben kann
      dWert = iValue;

      string strText = "hallo";
      char chrZeichen = 'x';
      //strText = chrZeichen; Zeile geht nicht, dar die Hochkomma nicht akzeptiert werden
      //chrZeichen = strText; Zeile geht nich, da man nich mehrere zeichen in ein Char setzen kann

      double dblKomma = 2.3;
      float fltEKomma = 4.6f;
      dblKomma = fltEKomma;
      //fltEKomma = dblKomma; Diese Zeile funktioniert nicht, da die Float das "F-Suffix" hinter sich hat

      //Dieser Befehl wartet, bis man die Enter-Taste drückt
      Console.ReadLine();
    }
  }
}
