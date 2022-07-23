using AddBinary;

var result1 = BruteForce.AddBinary("11", "1");
Console.WriteLine("[{0}]", string.Join(", ", result1));

var result2 = BruteForce.AddBinary("1010", "1011");
Console.WriteLine("[{0}]", string.Join(", ", result2));