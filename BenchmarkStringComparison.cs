using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;

namespace BenchmarkTest.CompareStrings;

[MemoryDiagnoser(false)]
public class BenchmarkStringComparison
{
    private string hay = "avocados, bananas, mangos, melons, peaches, pineapples";
    private string needle = "peaches";

    private Regex regex;
    private Regex compiledRegex;

    [GlobalSetup]
    public void Setup()
    {
        regex = new Regex(needle);
        compiledRegex = new Regex(needle, RegexOptions.Compiled);
    }
    
    [Benchmark]
    public bool StringContains() => hay.Contains(needle);

    [Benchmark]
    public bool RegexIsMatch() => regex.IsMatch(hay);
    
    [Benchmark]
    public bool CompiledRegexIsMatch() => compiledRegex.IsMatch(hay);
}