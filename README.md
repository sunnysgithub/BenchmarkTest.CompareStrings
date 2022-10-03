# String Comparison Types Benchmark Test

A simple benchmark test to compare the different comparison types of strings.

## Run

Run benchmark by your own

```terminal
    $ dotnet run -p BenchmarkTest.CompareStrings.csproj -c Release
```

## Results

|               Method |      Mean |    Error |   StdDev | Allocated |
|--------------------- |----------:|---------:|---------:|----------:|
|       StringContains |  15.65 ns | 0.080 ns | 0.067 ns |         - |
|         RegexIsMatch | 120.85 ns | 0.505 ns | 0.394 ns |         - |
| CompiledRegexIsMatch |  58.87 ns | 0.861 ns | 0.719 ns |         - |