// Please write a class in the language of your choice that contains the following two public methods:

// aboveBelow
// accepts two arguments
// An unsorted collection of integers (the list)
// an integer (the comparison value)
// returns a hash/object/map/etc. with the keys "above" and "below" with the corresponding count of integers from the list that are above or below the comparison value

// Example usage:
// input: [1, 5, 2, 1, 10], 6
// output: { "above": 1, "below": 4 }


// stringRotation
// accepts two arguments
// a string (the original string)
// a positive integer (the rotation amount)
// returns a new string, rotating the characters in the original string to the right by the rotation amount and have the overflow appear at the beginning

// Example usage:
// input: "MyString", 2
// output: "ngMyStri"

var aboveBelowResult = Rts.AboveBelow([ 3, 7, 2, 5, 3, 11, 9, 13], 2);
Console.WriteLine($"Above: {aboveBelowResult["above"]}, Below: {aboveBelowResult["below"]}");

var origStr = "Brandon";
var stringRotationResult = Rts.StringRotation(origStr, 3);
Console.WriteLine($"Original string: {origStr}, Rotated string: {stringRotationResult}");

class Rts {

    /// <summary>
    /// Counts the number of integers in a list that are above and below a specified comparison value.
    /// </summary>
    /// <param name="numbers">The list of integers to analyze.</param>
    /// <param name="comparisonValue">The integer value to compare against.</param>
    /// <returns>A dictionary with keys "above" and "below" and their corresponding counts.</returns>
    public static Dictionary<string, int> AboveBelow(List<int> numbers, int comparisonValue)
    {
        Dictionary<string, int> counts = new()
        {
            { "above", 0 },
            { "below", 0}
        };

        numbers.ForEach(number => {
            if (number > comparisonValue) 
            {
                counts["above"]++;
            }
            else if (number < comparisonValue)
            {
                counts["below"]++;
            }
        });

        return counts;
    }

    /// <summary>
    /// Rotates the characters in a string to the right by the specified amount, with overflow appearing at the beginning.
    /// </summary>
    /// <param name="original">The original string to rotate.</param>
    /// <param name="rotationAmount">The positive integer amount to rotate the string.</param>
    /// <returns>A new string with the characters rotated to the right by the rotation amount.</returns>
    public static string? StringRotation(string origStr, int rotationAmt)
    {
        if (String.IsNullOrEmpty(origStr)) return origStr;

        int origLength = origStr.Length;
        rotationAmt = Math.Abs(rotationAmt) % origLength;
        
        string rotated = origStr[(origLength - rotationAmt)..] + origStr[..(origLength - rotationAmt)];
        return rotated;
    }
}

