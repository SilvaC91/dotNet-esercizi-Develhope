/* An ArrayList is an interesting data collection. It allows any object to be added. 
Create a console app where you make an ArrayList. Try adding numbers and text, then add anything you want. 
Try printing the contents out to the console. Do you notice anything about how items are printed. */

using System.Collections;

ArrayList things = new ArrayList();

things.Add(1);
things.Add("Text");
things.Add(true);

foreach(var thing in things){
    Console.WriteLine(thing);
}