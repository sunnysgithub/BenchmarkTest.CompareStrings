# String Comparison Types Benchmark Test

A simple benchmark test to compare the different comparison types of strings.

## Run

Run benchmark by your own

```terminal
    $ dotnet run -p BenchmarkTest.CompareStrings.csproj -c Release
```

## Results

|                    Method |       Mean |     Error |    StdDev | Allocated |
|-------------------------- |-----------:|----------:|----------:|----------:|
|       StringContainsStart |   9.545 ns | 0.0465 ns | 0.0412 ns |         - |
|         StringContainsEnd | 667.414 ns | 2.9984 ns | 2.6580 ns |         - |
|         RegexIsMatchStart |  90.543 ns | 0.6134 ns | 0.5438 ns |         - |
|           RegexIsMatchEnd | 791.708 ns | 5.2943 ns | 4.9523 ns |         - |
| CompiledRegexIsMatchStart |  44.792 ns | 0.2423 ns | 0.2148 ns |         - |
|   CompiledRegexIsMatchEnd | 482.058 ns | 1.3081 ns | 1.2236 ns |         - |

## Lesson Learned 

As always in life - it depends.