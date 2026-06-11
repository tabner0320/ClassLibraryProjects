using UtilityLibraries;

namespace StringLibraryTest;

public class UnitTest1
{
    [Fact]
    public void TestStartsWithUpper()
    {
        string[] words = ["Alphabet", "Zebra", "ABC", "Αθήνα", "Москва"];

        foreach (var word in words)
        {
            Assert.True(word.StartsWithUpper());
        }
    }

    [Fact]
    public void TestDoesNotStartWithUpper()
    {
        string[] words = ["alphabet", "zebra", "abc", "1234", ".", ";", " "];

        foreach (var word in words)
        {
            Assert.False(word.StartsWithUpper());
        }
    }

    [Fact]
    public void DirectCallWithNullOrEmpty()
    {
        string?[] words = [string.Empty, null];

        foreach (var word in words)
        {
            Assert.False(StringLibrary.StartsWithUpper(word));
        }
    }
}