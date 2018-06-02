using System;	

public class Usage {
    public static void Main() {
        string[] parameters = new string[]{'Equidae','fast','plains','medium'};
	string[] animals = DBClass.Query("SELECT animals FROM animaldata WHERE (Family = @0 AND speed = @1 AND habitat = @2 AND size = @3)", parameters);
	foreach (string animal in animals) {
	    Console.WriteLine(animal);
	}
    }
}
