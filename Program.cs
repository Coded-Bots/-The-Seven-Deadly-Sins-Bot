using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SimpleClient;

namespace SimpleCSharp
{
    class Program
    {
        public static List<List<T>> Split<T>(List<T> collection, int size)
        {
            var chunks = new List<List<T>>();
            var chunkCount = collection.Count() / size;

            if (collection.Count % size > 0)
                chunkCount++;

            for (var i = 0; i < chunkCount; i++)
                chunks.Add(collection.Skip(i * size).Take(size).ToList());

            return chunks;
        }
        public static void prelogin(string accs)
        {
            Thread.Sleep(new Random().Next(0, 5000));
            //Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
            //var w = new work();
            try
            {
                //Console.WriteLine(accs);
                //w.setAccount(accs);
                //w.dowork(true);
            }
            catch (Exception exception)
            {
                //Console.WriteLine(exception.ToString());
                // w.netClient.Disconnect();
            }
        }
        private static void DoWork(string accs)
        {
            //await prelogin(acc);
            //Thread.Sleep(new Random().Next(0, 5000));
            //Console.WriteLine("retrieved {0}", acc);
            //Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
            var w = new work();
            try
            {
                //Console.WriteLine(accs);
                w.setAccount(accs);
                w.dowork(true);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                Console.WriteLine("{0}", accs);
                //w.netClient.Disconnect();
            }
            finally
            {
                //w.netClient.Dispose();
                //w.Dispose();
            }
        }
        static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                if (true)
                {
                    var v = new work();
                    v.setAccount("4B5752A56DA641BF97DDD2EC8DF517FA,6BF90FDBD3954C03A0E7249B63B4666A,A560F5EB86264E798B66F582470BB573");//ipad
                   //v.setAccount("041234E133174D4A92454A36F17E1380,DED5C3BCCDCE443D9D1BF8671D6CE418,3FB33BC4C76C498788A93F2A39559007");
                    v.dowork(true);
                    Console.ReadLine();
                }
                /*
                //Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                
                 var v = new work();
                v.setAccount("4B5752A56DA641BF97DDD2EC8DF517FA,6BF90FDBD3954C03A0E7249B63B4666A,A560F5EB86264E798B66F582470BB573");
                v.dowork(true);
                //Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                Console.ReadLine();
                */
                while (true)
                {
                    //try
                    //{
                    var w = new work();
                    w.dowork();
                    //}
                    //catch (Exception exception)
                    //{
                    //Console.WriteLine(exception.ToString());
                    Console.WriteLine("[-] having error...");
                    Thread.Sleep(2000);
                    continue;
                    //}
                }
            }
            else
            {
                List<Task> tasks = new List<Task> { };
                List<string> accounts = db.ReadData();
                Console.WriteLine("[+] found {0} accounts", accounts.Count);
                //Parallel.ForEach(accounts, new ParallelOptions { MaxDegreeOfParallelism = 50 },taskOption => prelogin(taskOption));
                 if (false)
                { 
                    var maxThreads = 75;
                                   var q = new ConcurrentQueue<string>(accounts);
                    for (int n = 0; n < maxThreads; n++)
                    {
                        tasks.Add(Task.Run(async () =>
                        {
                            while (q.TryDequeue(out string accs))
                            {
                            //await prelogin(acc);
                            //Thread.Sleep(new Random().Next(0, 5000));
                            //Console.WriteLine("retrieved {0}", acc);
                            //Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                            var w = new work();
                                try
                                {
                                //Console.WriteLine(accs);
                                w.setAccount(accs);
                                    w.dowork(true);
                                }
                                catch (Exception exception)
                                {
                                //Console.WriteLine(exception.ToString());
                                Console.WriteLine("fuck {0}", accs);
                                    w.netClient.Disconnect();
                                }
                                finally
                                {
                                //w.netClient.Dispose();
                                w.Dispose();
                                }
                            }
                        }));
                    }
                    await Task.WhenAll(tasks);
                }
                Console.WriteLine("Parallel calculation ");
                Parallel.ForEach(accounts, new ParallelOptions { MaxDegreeOfParallelism = 50}, (x =>
                {
                    DoWork(x);
                }));
                Console.WriteLine("[+] daily login done!");
            }
        }
    }
}
