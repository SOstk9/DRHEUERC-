using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace SimpleList
{
    public class Menge<T> where T: IComparable
    {
        Element<T> first;
        Element<T> last;
        Element<T> element;


        public Menge()
        {
        
        }

        public void Add(Element<T> item)
        {
            Element<T> eintrag = item;
            
            while (eintrag != null)
            {
                if (first != item || last != item)
                {
                    if (first == null)
                    {
                        first = item;
                        last = item;
                    }
                    else
                    {
                        last.Next = item;
                        last = item;
                    }
                }
                else
                {
                    throw new Exception("Element ist bereits vorhanden!");
                }
                eintrag = eintrag.Next;
            }
            
        }



        public void DeleteList()
        {
            Element<T> neu = first;
            while (neu != null)
            {

                neu = null;
                neu = neu.Next;

            }

        }

        public bool SearchList(T suchText)
        {
            Element<T> neu = first;
            while (neu != null)
            {
                if (neu.First.CompareTo(suchText) == 0)
                {
                    Console.WriteLine("Ist in der Liste vorhanden!");
                    return true;
                }
                neu = neu.Next;
            }
            return false;

        }

        public void ListeAusgeben()
        {
            Element<T> erster = first;

            while (erster != null)
            {
                Console.WriteLine(erster.First);
                erster = erster.Next;

            }

        }

        public Element<T>[] CreateArrayFromList()
        {
            int counter = 0;

            Element<T> zaehler = first;
            while (zaehler != null)
            {
                counter++;
                zaehler = zaehler.Next;
            }

            Element<T>[] array = new Element<T>[counter];
            zaehler = first;

            for (int i = 0; i < counter; i++)
            {
                array[i] = zaehler;
                zaehler = zaehler.Next;
            }
            return array;

        }
        public void AnzahlListeAusgeben()
        {
            int counter = 0;

            Element<T> zaehler = first;
            while (zaehler != null)
            {
                counter++;
                zaehler = zaehler.Next;
            }
            Console.WriteLine(counter);
        }

        public void MengeHinzufügen(Menge<T> item)
        {

                this.Add(item.first);   
                       

        }
    }
    }
