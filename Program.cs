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
  static int n = default!;

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

    x = (double[][])lines.Select(line => line[..^1]);
    y = (double[])lines.Select(line => line[^1]);

    m = x.Length;
    n = y.Length;
  }
}