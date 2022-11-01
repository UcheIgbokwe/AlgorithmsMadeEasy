using System;
using System.Collections.Generic;
using AlgorithmsMadeEasy.Implementation;
using System.Threading.Tasks;
using Websocket.Client;
using System.Threading;

namespace AlgorithmsMadeEasy
{
    public class Program2
    {
        static void Main(string[] args)
        {
            #region LongestPrefix

            LongestCommonPrefix classFile = new LongestCommonPrefix();
            string[] sampleWords = new string[3] { "fly", "flask", "fletcher" };
            var longestPrefix = classFile.LongestPrefix(sampleWords);

            Console.WriteLine($"LongestPrefix = {longestPrefix}");
            #endregion

            #region LongestSubarray

            LongestSubarray classFile2 = new LongestSubarray();
            int[] sampleNumbers = new int[3] { 1, 2, 3 };
            var longestSubarray = classFile2.LongSubarray(sampleNumbers, 1);

            Console.WriteLine($"LongestSubarray = {longestSubarray}");
            #endregion

            #region FindingDuplicate

            FindingDuplicate classFile3 = new FindingDuplicate();
            int[] numberArray = new int[7] { 6, 2, 3, 1, 5, 7, 3 };
            var foundDuplicate = classFile3.findDuplicate(numberArray);

            //Console.WriteLine($"Duplicate number is = {foundDuplicate}");
            #endregion

            #region BillDivision

            BillDivision classFile4 = new BillDivision();
            List<int> billl = new List<int> { 3, 10, 2, 9};
            classFile4.BonAppetit(billl, 1, 7);

            // string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            // int n = Convert.ToInt32(firstMultipleInput[0]);
            // int k = Convert.ToInt32(firstMultipleInput[1]);
            // List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
            // int b = Convert.ToInt32(Console.ReadLine().Trim());
            // classFile4.BonAppetit(bill, k, b);

            #endregion

            var exitEvent = new ManualResetEvent(false);
            var url = new Uri("ws://machinestream.herokuapp.com/ws");

            using (var client = new WebsocketClient(url))
            {
                client.ReconnectTimeout = TimeSpan.FromSeconds(60);
                client.ReconnectionHappened.Subscribe(info =>
                    Console.WriteLine($"Reconnection happened, type: {info.Type}"));

                client.MessageReceived.Subscribe(msg => Console.WriteLine($"Message received: {msg}"));
                client.Start();

                Task.Run(() => client.Send("{ message }"));

                exitEvent.WaitOne();
            }

            // #region Print Next number using Recurssion

            // Recursion classFile4 = new Recursion();
            // classFile4.PrintNext(1);

            // #endregion

            // #region Print Max Number

            // JobCityTest classFile5 = new();
            // int [] listOfQu = { 2,5,4,6,8 };
            // var result = JobCityTest.FindMaxx(listOfQu ,3);

            // Console.WriteLine($"Jobcity number is = {result}");

            // #endregion
        }
    }
}