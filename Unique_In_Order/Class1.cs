using System.Collections.Generic;
using System.Linq;

namespace Unique_In_Order;
 
 public static class Class1
 {
     public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
     {
         var enumerable = iterable as T[] ?? iterable.ToArray();
         return enumerable
             .Where((item, index) => index == 0 || !item!.Equals(enumerable[index - 1]));
     }
 }