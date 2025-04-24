namespace Tests.Trie;

[TestFixture]
public class SearchSuggestionsSystemTest
{
    private readonly Dictionary<int, List<List<string>>> _suggestions = new()
    {
        {
            1, [
                new List<string> { "mobile", "moneypot", "monitor" },
                new List<string> { "mobile", "moneypot", "monitor" },
                new List<string> { "mouse", "mousepad" },
                new List<string> { "mouse", "mousepad" },
                new List<string> { "mouse", "mousepad" }
            ]
        },
        {
            2, [
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" }
            ]
        }
    };
    [TestCase<string[], string, int>(["mobile","mouse","moneypot","monitor","mousepad"], "mouse", 1)]
    [TestCase<string[], string, int>(["havana"], "havana", 2)]
    public void Test(string[] products, string searchWord, int expected)
    {
        // Arrange
        var solution = new SearchSuggestionsSystem();
        var suggestion = _suggestions[expected];

        // Act
        var result = solution.SuggestedProducts(products, searchWord);

        // Assert
        result.Should().BeEquivalentTo(suggestion);
    }    
}