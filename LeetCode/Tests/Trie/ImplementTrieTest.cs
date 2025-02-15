using System;

namespace Tests.Trie;

[TestFixture]
public class ImplementTrieTest
{
    [Test]
    public void Test()
    {
        // Arrange
        ImplementTrie solution = new();
        var expected1 = true;
        var expected2 = false;
        var expected3 = true;
        var expected4 = true;

        // Act
        solution.Insert("apple");
        var result1 = solution.Search("apple");
        var result2 = solution.Search("app");
        var result3 = solution.StartsWith("app");
        solution.Insert("app");
        var result4 = solution.Search("app");

        // Assert
        expected1.Should().Be(result1);
        expected2.Should().Be(result2);
        expected3.Should().Be(result3);
        expected4.Should().Be(result4);
    }
}