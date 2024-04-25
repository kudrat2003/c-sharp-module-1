using CSharpModule.KichikShahzoda;


var testCases = int.Parse(Console.ReadLine() ?? "0");

while(testCases-- > 0)
{   
    var crossingNumber = 0;


    var coordinates = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    
    var prince = new Point (coordinates[0], coordinates[1]);
    var princess = new Point (coordinates[2], coordinates[3]);

    var planetNumber = int.Parse(Console.ReadLine() ?? "0");
    
    while(planetNumber-- > 0)
    {
         var planetData = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    
        var centre = new Point (planetData[0], coordinates[1]);
        var planet = new Circle(centre, planetData[2]);

        var princeIn = planet.IsIn(prince);
        var princessIn = planet.IsIn(princess);

        if (princeIn != princessIn)
        crossingNumber++;
    
    }
    Console.WriteLine($"Number of crossings : {crossingNumber}");
}
