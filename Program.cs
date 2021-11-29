using System.Text.Json;
using System.Collections.Immutable;

JsonSerializer.Deserialize<ImmutableList<string>>("[]");
System.Console.WriteLine("Done");