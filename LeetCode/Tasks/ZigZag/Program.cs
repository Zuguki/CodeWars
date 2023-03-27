using System;
using System.Text;

// Input: PAYPALISHIRING, 3
// Example
// P   A   H   N
// A P L S I I G
// Y   I   R

// Output: PAHNAPLSIIGYIR

// Input: PAYPALISHIRING, 5
// Example
// P       H 
// A     S I
// Y   I   R
// P L     I G
// A       N

// Output: PHASIYIRPLIGAN

// Algorythm
// 0   0   0 
// 1 1 1 1 1
// 2   2   2

Console.ReadLine();

public class Solution
{
    private string[] _strings;
    private bool _goToBottom = true;
    private int _rowsCounter;

    public string Convert(string str, int numRows)
    {
        if (numRows == 1)
            return str;
        
        _strings = new string[str.Length < numRows ? str.Length : numRows];
        foreach (var symbol in str)
            _strings[GetNextIndex(numRows)] += symbol;

        var sb = new StringBuilder();
        foreach (var value in _strings)
            sb.Append(value);

        return sb.ToString();
    }

    private int GetNextIndex(int numRows)
    {
        _goToBottom = TryChangeDirection(numRows);
        _rowsCounter += _goToBottom ? 1 : -1;
        return _rowsCounter - 1;
    }

    private bool TryChangeDirection(int numRows)
    {
        var direction = _goToBottom;
        if (_rowsCounter is 0 or 1)
            direction = true;
        else if (_rowsCounter == numRows)
            direction = false;

        return direction;
    }
}
