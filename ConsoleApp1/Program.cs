var dates = new DateTime[]
{
    new DateTime(Random.Shared.NextInt64(minValue : 1000000000, maxValue : DateTime.MaxValue.Ticks)),
    new DateTime(Random.Shared.NextInt64(minValue : 1000000000, maxValue : DateTime.MaxValue.Ticks)),
    new DateTime(Random.Shared.NextInt64(minValue : 1000000000, maxValue : DateTime.MaxValue.Ticks)),
    new DateTime(Random.Shared.NextInt64(minValue: 1000000000, maxValue: DateTime.MaxValue.Ticks)),
    new DateTime(Random.Shared.NextInt64(minValue: 1000000000, maxValue: DateTime.MaxValue.Ticks)),
};

var x = dates.OrderByDescending(x => x);

foreach (var y in x)
    Console.WriteLine(y.ToString());