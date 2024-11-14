class Program
{
  //sizes
  //bedrooms
  //floors
  //years
  static double[][] x = default!;

  //prices
  static double[] y = default!;

  static int m = default!;

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

    m = y.Length;
  }
}