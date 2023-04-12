using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Eazy;
using LeetCode.Medium;

var str = "/a/./b/../../c/";

var dec = new SimplifyPath_71();
Console.WriteLine(dec.SimplifyPath(str));
