Mostly all need to log long running console apps or any other windows services,usually using extra third party but not customizable,here a simple way which gives all flexibility.
Just take the code & run...you will understand easily everything & extend whatever the way you wanted
Below output is produced from same code.

This is just simple console.writelinePrint
Here showing how to write to logfile using same console.writeline() itself without any extra code even on existing project in 2 types
Type1:Attaching stremwriter to logfile & console.out functionality & customizing.In between  Console.SetOut(...)  & logFileWriter.Close() all will be  printed on cosnole & logfile
Type2:Using static methods MultiTextWriter.Start(logFilePath: logFilePath) & Stop(),in betweeen whatever comes all will be printed on cosnole & logfile

Type1:Starts here.Attaching stremwriter to logfile & console.out functionality & customizing.In between  Console.SetOut(...)  & logFileWriter.Close() all will be  printed on cosnole & logfile
Hello, this message will be written to both the console and the log file.
1
2
3

Type2:Using static methods MultiTextWriter.Start(logFilePath: logFilePath) & Stop(),in betweeen whatever comes all will be printed on cosnole & logfile.Here to make it clear 2 times start() & stop() shown,you can use any number of times
Hello, World! this will be printed only once on screen ,not on any file
Hello, this message will be written to both the console and the log file.
5
6
6
7 this wont be printed on log file
8 this wont be printed on log file
9 this wont be printed on log file
Hello,again printing on both started.
11
12.
13
14
