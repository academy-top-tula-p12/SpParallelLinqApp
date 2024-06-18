using System.Threading.Channels;

List<object> numbers = new() { "0", 1, 2, 3, 4, 5, 10, "20", 30, 11, 12, 13, 40, "50" };

var sqrs = numbers.AsParallel()
                  .Select(x => (int)x * (int)x);

try
{
    sqrs.ForAll(e => Console.Write($"{e} "));
}
catch(AggregateException ex)
{
    foreach(var x in ex.InnerExceptions)
        Console.WriteLine($"\n{x.Message}");
}