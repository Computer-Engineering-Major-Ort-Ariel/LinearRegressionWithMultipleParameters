class Program
{
  //sizes
  //bedrooms
  //floors
  //years
  static double[][] x = [];
  //prices
  static double[] y = [];

  static void Main()
  {
    var lines = File
      .ReadAllLines("houses.txt")
      .Select(line => line
        .Split(',')
        .Select(item => double.Parse(item))
        .ToArray()
      )
      .ToArray();

    y = lines.Select(line => line[^1]).ToArray();

    x = Enumerable
      .Range(0, lines[0].Length - 1)
      .Select(columnI =>
        lines.Select(line => line[columnI]).ToArray()
      )
      .ToArray();

    Console.WriteLine(x[0][13]);


    for (int houseI = 13; houseI < 20; houseI++)
    {
      Console.Write(
        "size (sqft): " + x[0][houseI] +
        ", floors: " + x[1][houseI] +
        ", bedrooms: " + x[2][houseI] +
        ", age: " + x[3][houseI]);
      Console.WriteLine(", PRICE (1000$): " + y[houseI]);
    }
  }
}