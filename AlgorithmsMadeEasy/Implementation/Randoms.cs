using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsMadeEasy.Implementation
{
    public class Randoms
    {
        public IEnumerable<int> MyFilter(IEnumerable<int> arrayList)
        {

            // var csvString = new Func<IEnumerable<int>, string>(values => string.Join(",", values.Select(x => x.ToString()).ToArray()));
            // var sampleResult = new Func<IEnumerable<int>, IEnumerable<int>>(value => value.Where(c => c % 2 == 0).Select(x => x * x).Where(v => v < 50));

            // return sampleResult(arrayList);

            // //var result = new Func<IEnumerable<int>, int>(values => values.TakeWhile(x => x > 1).Count());
            // var result = new Func<IEnumerable<int>, int>(values => Convert.ToInt32(values.TakeWhile(x => x > 1)));

            // int c = 0;
            // foreach (var item in values)
            // {
                
            //     if (item >= 1)
            //     {
            //         c +1;
            //     }
            //     return c;
            // }

            IEnumerable<int> evenNumbers = arrayList.Where(c => c%2 == 0).Select(x => x*x).Where(v => v < 50);
            Console.WriteLine(evenNumbers);
            return evenNumbers;
            
        }

        public class Person
        {
            public string Name, Email;
            public Person(string name, string email)
            {
                Name = name;
                Email = email;
            }
        }

        public class Record
        {
            public string Mail, SkyeId;
            public Record(string mail, string skyeId)
            {
                Mail = mail;
                SkyeId = skyeId;
            }
        }

        public void Aggregate()
        {
            var numbers = Enumerable.Range(1,10);
            var result = numbers.Aggregate((p,x) => p+x);
            Console.WriteLine(result);

            var words = new [] {"one","two","three"};
            var res = words.Aggregate("hello",(p, x) => p + "," + x);
            Console.WriteLine(res);

           
        }

        public void LinqResult()
        {
            var people = new Person[]
            {
                new Person("Uche", "uche@yahoo.com"),
                new Person("Imoh", "imoh@yahoo.com")
            };

            var record = new Record[]
            {
                new Record("uche@yahoo.com", "ucheI"),
                new Record("imoh@yahoo.com", "ImohO")
            };

            // var query = people.Join(record, 
            //     x => x.Email,
            //     y => y.Mail,
            //     (people,record) => new { people.Name, record.SkyeId }
            //     );
            //query.ToList().ForEach(i => Console.WriteLine($"Name: {i.Name}, SkyeId: {i.SkyeId}")); 

            //get the cube of each number between 1-50
            int count = 50;
            var numbers = Enumerable.Range(1,count);
            var result = new int[count];

            numbers.AsParallel().ForAll(x => {
                int newvalue = x * x * x;
                result[x - 1] = newvalue;
            });

            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }

        }
        
    }
}