using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;

namespace BenchmarkTest.CompareStrings;

[MemoryDiagnoser(false)]
public class BenchmarkStringComparison
{
    private const string hayWithNeedleAtTheStart = "apples Cumin coconut sugar creamy cauliflower alfredo sauce pineapple salsa dark and stormy Italian pepperoncini mint lime taco salsa blueberry chia seed jam shaved almonds Bolivian rainbow pepper ultimate vegan chia seeds pumpkin candy cane winter sesame soba noodles balsamic vinaigrette street style Thai basil tacos basil coconut rice toasted hazelnuts lime mango crisp. Chinese five-spice powder red amazon pepper ginger tofu almond milk miso dressing red pepper smoky maple tempeh glaze cool cucumbers Thai super chili burritos cherry bomb. Indian spiced lemonade zest leek lavender lemonade bento box cocoa roasted brussel sprouts black bean wraps raspberries matcha zesty tofu pad thai lemon red lentil soup picnic salad.";
    private const string hayWithNeedleAtTheEnd = "Cumin coconut sugar creamy cauliflower alfredo sauce pineapple salsa dark and stormy Italian pepperoncini mint lime taco salsa blueberry chia seed jam shaved almonds Bolivian rainbow pepper ultimate vegan chia seeds pumpkin candy cane winter sesame soba noodles balsamic vinaigrette street style Thai basil tacos basil coconut rice toasted hazelnuts lime mango crisp. Chinese five-spice powder red amazon pepper ginger tofu almond milk miso dressing red pepper smoky maple tempeh glaze cool cucumbers Thai super chili burritos cherry bomb. Indian spiced lemonade zest leek lavender lemonade bento box cocoa roasted brussel sprouts black bean wraps raspberries matcha zesty tofu pad thai lemon red lentil soup picnic salad apples.";
    private string needle = "apples";

    private Regex regex;
    private Regex compiledRegex;

    [GlobalSetup]
    public void Setup()
    {
        regex = new Regex(needle);
        compiledRegex = new Regex(needle, RegexOptions.Compiled);
    }
    
    [Benchmark]
    public bool StringContainsStart() => hayWithNeedleAtTheStart.Contains(needle);
    
    [Benchmark]
    public bool StringContainsEnd() => hayWithNeedleAtTheEnd.Contains(needle);

    [Benchmark]
    public bool RegexIsMatchStart() => regex.IsMatch(hayWithNeedleAtTheStart);

    [Benchmark]
    public bool RegexIsMatchEnd() => regex.IsMatch(hayWithNeedleAtTheEnd);
    
    [Benchmark]
    public bool CompiledRegexIsMatchStart() => compiledRegex.IsMatch(hayWithNeedleAtTheStart);
    
    [Benchmark]
    public bool CompiledRegexIsMatchEnd() => compiledRegex.IsMatch(hayWithNeedleAtTheEnd);
}