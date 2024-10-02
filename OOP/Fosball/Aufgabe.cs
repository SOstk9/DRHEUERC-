using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Fosball
{
    public class Aufgabe
    {
//        Aufgabe Fußball-Simulator
//Erstellen Sie zuerst ein Klassendiagramm für die Aufgabe!
//Es gibt 11 Spieler, mit den Eigenschaften name, alter, stärke, torschuss, motivation und
//tore.Stärke, Torschuss, Motivation sind Werte von 1 (schlecht) bis 10 (super). Bei den
//Spielern gibt es noch einen Sonderling, den Torwart. Als zusätzliche Eigenschaft hat er
//reaktion, damit wird später entschieden, ob er die Torschüsse hält oder nicht.Der
//Torwart ist ein Spezialfall eines Spielers.
//Der Spieler erhält zwei Methoden AddTor() und SchiesstAufTor(). Die Methode
//AddTor() erhöht die Anzahl der Tore, wenn der Spieler ein Tor geschossen hat.Die
//Methode SchiesstAufTor() ermittelt die Torschussqualität. Es wird eine zufällige Zahl im
//Bereich von 1-10 gewählt, die abhängig von der Torschussqualität des Spielers ist.
//Verwenden Sie für die Methode SchiesstAufTor() die Implementierung aus der
//beiliegenden Datei.
//Der Torwart erhält eine Methode HältDenSchuss(), welcher die Torschussqualität eines
//Spielers übergeben wird.Die Methode entscheidet, ob der abgegebene Torschuss pariert
//oder durchgelassen wird (ebenfalls mit einem zufälligen Ausgang).
//Verwenden Sie für die Methode HältDenSchuss() die Implementierung aus der
//beiliegenden Datei.
//Neben den Spielern haben wir einen Trainer mit den Eigenschaften name, alter und
//erfahrung.
//Alle Objekte haben Methoden zum Lesen ihrer eigenen Attribute (z.B.GetName,
//GetAlter, GetTore, GetMotivation, GetStärke, GetReaktion, GetErfahrung, usw.)
//Die Konstruktoren sind wie folgt aufgebaut:
//public Spieler(string name, int alter, int stärke, int torschuss,
//        int motivation)
//public Torwart(string name, int alter, int stärke, int torschuss,
//int motivation, int reaktion)
//public Trainer(string name, int alter, int erfahrung)
//Eine Mannschaft ist eine Klasse mit den Eigenschaften name, trainer, torwart und
//spieler(als Array). Es gibt wieder einen Konstruktor(siehe Aufruf Seite 3) und die GetMethoden für die Eigenschaften.Zusätzlich besitzt die Klasse Mannschaft die Methoden
//GetStärke() und GetMotivation(), die die durchschnittliche Stärke, bzw.Motivation der
//Mannschaft als Zahlenwert wiedergibt. D.h.Die Methoden addieren die Werte der
//Spieler zu einer Summe auf und liefern den Mittelwert zurück.
//Zuletzt gibt es eine Methode GetKader() die wie folgt implementiert wird:
//OOP Vererbung 02.10.2024
//Seite 2 von 3
//public Spieler[] GetKader()
//        {
//            return spieler;
//        }
//        Ein Spiel zwischen zwei Mannschaften hat folgende Attribute: nameHeimMannschaft, 
//nameGastMannschaft, punkteHeim, punkteGast.Zudem einen Konstruktor sowie fünf
//Get-Methoden :
//string GetHeimMannschaft()
//string GetGastMannschaft()
//int GetHeimPunkte()
//int GetGastPunkte()
//string GetErgebnisText()
//Die Methode GetErgebnisText() gibt die Namen und die Punkte aus.
//Die Methode StarteSpiel() finden Sie in der beiliegenden Datei.
//Nachdem Sie Klassen erzeugt haben, legen Sie im Hauptprogramm zwei Mannschaften
//wie folgt an(vollständig in der Textdatei) :
//// Mannschaft 1
//Trainer trainer1 = new Trainer("Juergen Klinsmann", 34, 9);
//        Torwart torwart1 = new Torwart("J. Lehmann", 36, 8, 1, 9, 7);
//        Spieler[] spieler1 = new Spieler[10];
//        spieler1[0] = new Spieler("P. Lahm", 23, 9, 5, 9);
//...
//Mannschaft m1 = new Mannschaft("Deutschland WM 2006", trainer1,
//torwart1, spieler1);
//        // Mannschaft 2
//        Trainer trainer2 = new Trainer("Carlos Alberto Parreira", 50, 3);
//        Torwart torwart2 = new Torwart("Dida", 25, 9, 1, 6, 8);
//        Spieler[] spieler2 = new Spieler[10];
//        spieler2[0] = new Spieler("Cafu", 33, 8, 4, 6);
//...
//Mannschaft m2 = new Mannschaft("Brasilien WM 2006", trainer2,
//torwart2, spieler2);
//        Starten Sie anschließend ein Spiel zwischen diesen Mannschaften wie folgt(kann
//        ebenfalls der Textdatei entnommen werden):
//Spiel spiel = new Spiel();
//        Console.WriteLine("-----------------------------------");
//Console.WriteLine("Start des Spiels zwischen");
//Console.WriteLine();
//Console.WriteLine(m1.GetName());
//Console.WriteLine(" Trainer: " + m1.GetTrainer().GetName());
//Console.WriteLine();
//OOP Vererbung 02.10.2024
//Seite 3 von 3
//Console.WriteLine(" und");
//Console.WriteLine();
//Console.WriteLine(m2.GetName());
//Console.WriteLine(" Trainer: " + m2.GetTrainer().GetName());
//Console.WriteLine("-----------------------------------");
//spiel.StarteSpiel(m1, m2);
//Console.WriteLine();
//Console.WriteLine("-----------------------------------");
//Console.WriteLine(spiel.GetErgebnisText());
//Console.WriteLine("-----------------------------------");
    }
}