using System.Collections.Generic;
using System.Linq;

namespace CodaWars._6kuy;
 
 public static class UniqueInOrder
 {
     public static IEnumerable<T> Unique<T>(IEnumerable<T> iterable)
     {
         var enumerable = iterable as T[] ?? iterable.ToArray();
         return enumerable
             .Where((item, index) => index == 0 || !item!.Equals(enumerable[index - 1]));
     }
 }