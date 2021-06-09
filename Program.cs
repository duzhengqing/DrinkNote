using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMessageDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var i = 1;
            while (true)
            {
                var hour = DateTime.Now.Hour;
                if (hour>9 && hour<23)
                {
                    Console.WriteLine($"第{i}次提醒，当前时间：{DateTime.Now}");
                    await MessageSend.PostAsync(i,"小宝贝");
                    Thread.Sleep(1000 * 60 * 60 * 2);
                    i++;
                }
                
            }
           
            
        }
    }
}
