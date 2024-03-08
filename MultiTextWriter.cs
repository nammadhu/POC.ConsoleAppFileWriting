using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//testing
namespace POC.ConsoleAppFileWriting
    {

   

    class MultiTextWriter : TextWriter
        {
        private readonly TextWriter consoleWriter;
        private readonly TextWriter fileWriter;

        public MultiTextWriter(TextWriter consoleWriter, TextWriter fileWriter)
            {
            this.consoleWriter = consoleWriter;
            this.fileWriter = fileWriter;
            }

        public override void Write(char value)
            {
            //if (!string.IsNullOrEmpty(value))
            //    value = DateTime.Now.ToString() + ":" + value;
            consoleWriter.Write(value);
            if (((System.IO.FileStream)((System.IO.StreamWriter)fileWriter).BaseStream).CanWrite)
                fileWriter.Write(value);
            }

        public override void Write(string value)
            {
            //if(!string.IsNullOrEmpty(value))
            //value = DateTime.Now.ToString("yyyyMMddTHHmmss") + ":" + value;
            consoleWriter.Write(value);
            if (((System.IO.FileStream)((System.IO.StreamWriter)fileWriter).BaseStream).CanWrite)
                fileWriter.Write(value);
            }

        public override Encoding Encoding => consoleWriter.Encoding;
        }

    public class MultiTextWriterExtension
        {
        static StreamWriter logFileWriter;
        public static void Start(string logFilePath)
            {
            if (logFilePath == "log.txt")
                logFilePath = $"log{DateTime.Now:yyyy-MM-dd-T-HH-mm-ss}.txt";

            // Set up the StreamWriter to write to the log file
            logFileWriter = new StreamWriter(logFilePath, true);
            logFileWriter.AutoFlush = true;

            // Create a MultiTextWriter and set it as the output for the console
            Console.SetOut(new MultiTextWriter(Console.Out, logFileWriter));
            }

        public static void Stop()
            {
            logFileWriter.Close();
            }
        }
    }
