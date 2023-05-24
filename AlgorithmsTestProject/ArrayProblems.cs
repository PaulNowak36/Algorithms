using Microsoft.VisualBasic;

namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        if (xs.Length != ys.Length) return false;

        else if (xs.Equals(ys)) return true;

        else return false;
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {
        var newValue = xs[a];
        xs[a] = xs[b];
        xs[b] = newValue;

    }

    public static T FirstElement<T>(T[] xs)
    {
        return xs[0];
    }

    public static T LastElement<T>(T[] xs)
    {
        return xs[xs.Length - 1];
    }

    public static T MiddleElement<T>(T[] xs)
    {
        
        return xs[xs.Length / 2];
    }

    public static void Reverse<T>(T[] xs)
    {
        Array.Reverse(xs);

    }

    public static int CountElement<T>(T[] xs, T element)
    {
        return Count(xs, x => x.Equals(element));
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        string concat = string.Join(",", xs);
        return concat;
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        var r = 0;
        for (var i = 0; i < xs.Length; ++i)
        {
            if (predicate(xs[i]))
                r++;
        }
        return r;
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        throw new NotImplementedException();
    }
}