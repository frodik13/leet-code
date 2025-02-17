namespace Tests.Backtracking;

[TestFixture]
public class LetterCombinationsOfPhoneNumberTest
{
    [TestCase<string, string[]>("23", ["ad","ae","af","bd","be","bf","cd","ce","cf"])]
    [TestCase<string, string[]>("", [])]
    [TestCase<string, string[]>("2", ["a","b","c"])]
    public void Test(string digits, string[] expected)
    {
        // Arrange
        LetterCombinationsOfPhoneNumber solution = new();
        var expectedList = expected.ToList();
        
        // Act
        var result = solution.LetterCombinations(digits);

        // Assert
        result.Should().BeEquivalentTo(expectedList);
    }
}