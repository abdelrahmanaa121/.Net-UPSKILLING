using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace extension
{
    internal static class Extensions
    {
        public static int GetAge(this DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;
            if (birthdate.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
        public static double AvgOfEvenNumbers(this List<int> num)
        {
            if (num == null || num.Count == 0)
            {
                return 0;
            }
            int sum = 0;
            int count = 0;
            foreach (var n in num)
            {
                if ( n % 2 == 0)
                {
                    sum += n;
                    count++;
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return (double)sum / count;
        }
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source,int page,int pagesize)
        {
            if (source == null) return Enumerable.Empty<T>();
            if (page < 1) page = 1;
            return source.Skip((page - 1) * pagesize).Take(pagesize);
        }
        public static string ToJson<T>(this T obj)
        {
            if (obj == null) return "null";
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(obj, options);           
        }
    }
}
