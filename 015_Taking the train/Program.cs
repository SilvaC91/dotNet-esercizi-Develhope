/*
Create a console application that uses a LinkedList to represent a train route with various stations.
Add and remove stations, and display the route. Can you make the train station into a class?
*/


using _015_Taking_the_train;

LinkedList<TrainStation> trainRoute_Como_to_Milan = new LinkedList<TrainStation>();

TrainStation s1 = new TrainStation("Como S. Giovanni");
TrainStation s2 = new TrainStation("Camerlata");
TrainStation s3 = new TrainStation("Seregno");
TrainStation s4 = new TrainStation("Monza");
TrainStation s5 = new TrainStation("Milano Centrale");


trainRoute_Como_to_Milan.AddFirst(s5);
trainRoute_Como_to_Milan.AddFirst(s4);
trainRoute_Como_to_Milan.AddFirst(s3);
trainRoute_Como_to_Milan.AddFirst(s2);
trainRoute_Como_to_Milan.AddFirst(s1);

Console.WriteLine("Train route from Como to Milan:");
foreach(TrainStation station in trainRoute_Como_to_Milan){
    Console.WriteLine(station.name);
}

trainRoute_Como_to_Milan.Remove(s4);

Console.WriteLine("\nModified train route from Como to Milan:");
foreach(TrainStation station in trainRoute_Como_to_Milan){
    Console.WriteLine(station.name);
}


