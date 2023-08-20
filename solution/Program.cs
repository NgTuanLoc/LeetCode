// See https://aka.ms/new-console-template for more information
using solution.Sequences;

Console.Clear();

// var test = new int[] { -2, 3, -4 };
// var test = new int[] { -2, 3, -4 };
var test = new int[] { 2, 3, -2, 4 };

Console.WriteLine(SolutionSequences.MaxProductSubArray(test));