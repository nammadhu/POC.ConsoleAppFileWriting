namespace POC.ConsoleAppFileWriting
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("This is just simple console.writelinePrint");
            Console.WriteLine("Here showing how to write to logfile using same console.writeline() itself without any extra code even on existing project in 2 types");
            Console.WriteLine("Type1:Attaching stremwriter to logfile & console.out functionality & customizing.In between  Console.SetOut(...)  & logFileWriter.Close() all will be  printed on cosnole & logfile");
            Console.WriteLine("Type2:Using static methods MultiTextWriter.Start(logFilePath: logFilePath) & Stop(),in betweeen whatever comes all will be printed on cosnole & logfile");
            Console.WriteLine();
            Console.WriteLine("Type1:Starts here.Attaching stremwriter to logfile & console.out functionality & customizing.In between  Console.SetOut(...)  & logFileWriter.Close() all will be  printed on cosnole & logfile");
            string logFilePath0 = "log.txt";
            StreamWriter logFileWriter = new StreamWriter(logFilePath0, true);
            logFileWriter.AutoFlush = true;

            // Create a MultiTextWriter and set it as the output for the console
            Console.SetOut(new MultiTextWriter(Console.Out, logFileWriter));

            // Your application code with existing Console.WriteLine statements
            Console.WriteLine("Hello, this message will be written to both the console and the log file.");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            logFileWriter.Close();

            Console.WriteLine();
            Console.WriteLine("Type2:Using static methods MultiTextWriter.Start(logFilePath: logFilePath) & Stop(),in betweeen whatever comes all will be printed on cosnole & logfile.Here to make it clear 2 times start() & stop() shown,you can use any number of times");
            Console.WriteLine("Hello, World! this will be printed only once on screen ,not on any file");
            var logFilePath = "log1.txt";
            MultiTextWriterExtension.Start(logFilePath: logFilePath);
            Console.WriteLine("Hello, this message will be written to both the console and the log file.");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("6");
            MultiTextWriterExtension.Stop();
            Console.WriteLine("7 this wont be printed on log file");
            Console.WriteLine("8 this wont be printed on log file");
            Console.WriteLine("9 this wont be printed on log file");
            MultiTextWriterExtension.Start(logFilePath: logFilePath);
            Console.WriteLine("Hello,again printing on both started.");
            Console.WriteLine("11");
            Console.WriteLine("12.");
            Console.WriteLine("13");
            MultiTextWriterExtension.Stop();
            Console.WriteLine("14");
            Console.WriteLine("15");
            Console.ReadLine();
            }
        }
    }
