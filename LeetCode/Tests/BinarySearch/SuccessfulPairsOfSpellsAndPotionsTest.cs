namespace Tests.BinarySearch;

[TestFixture]
public class SuccessfulPairsOfSpellsAndPotionsTest
{
    [TestCase(new[]{5, 1, 3}, new[]{1, 2, 3, 4, 5}, 7, new[]{4, 0, 3})]
    [TestCase(new[]{3, 1, 2}, new[]{8, 5, 8}, 16, new[]{2, 0, 2})]
    [TestCase(new[]{15,8,19}, new[]{38,36,23}, 328, new[]{3,0,3})]
    public void Test(int[] spells, int[] potions, long success, int[] expected)
    {
        // Arrange
        SuccessfulPairsOfSpellsAndPotions solution = new(); 

        // Act
        var result = solution.SuccessfulPairs(spells, potions, success);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
    
    [Test]
    public void TestFile()
    {
        // Arrange
        SuccessfulPairsOfSpellsAndPotions solution = new();
        var spells = File.ReadAllText("BinarySearch/SuccessfulPairsOfSpellsAndPotionsTestCase/spells.txt")
            .Split(',').Select(int.Parse).ToArray();
        var potions = File.ReadAllText("BinarySearch/SuccessfulPairsOfSpellsAndPotionsTestCase/potions.txt")
            .Split(',').Select(int.Parse).ToArray();
        var expected = File.ReadAllText("BinarySearch/SuccessfulPairsOfSpellsAndPotionsTestCase/expected.txt")
            .Split(',').Select(int.Parse).ToArray();
        var success = long.Parse(File.ReadAllText("BinarySearch/SuccessfulPairsOfSpellsAndPotionsTestCase/success.txt"));

        // Act
        var result = solution.SuccessfulPairs(spells, potions, success);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}