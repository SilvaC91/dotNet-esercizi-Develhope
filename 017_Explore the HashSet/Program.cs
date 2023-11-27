/*
Create a HashSet<string>. Explore what happens when you add unique values to it. 
Does a HashSet consider strings with different capitalisations unique?
*/


HashSet<string> myHashSet = new HashSet<string>();

myHashSet.Add("dog");
myHashSet.Add("dog");
myHashSet.Add("Dog");

foreach(string str in myHashSet){
    Console.WriteLine(str);
}

/*
output is:
dog
Dog

so HashSet is case sensitive
*/
