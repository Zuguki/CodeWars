using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Eazy;
using LeetCode.Medium;

var str = "/a/./b/../../c/";
var pushed = new[] {1,2,3,4,5};
var popped = new[] {4,3,5,1,2};

var dec = new ValidateStackSequences_946();
Console.WriteLine(dec.ValidateStackSequences(pushed, popped));
