using System;
using NDesk.Options;
using System.Reflection;

namespace BeanCounter
{
    public static class Program
    {
        static OptionSet _options;
        static bool showHelp = false;
        static bool showVersion = false;
        static bool verbose = false;

        public static void Main(string[] args)
        {
            _options = new OptionSet() {
                {   "h|?|help",
                    "Print this help text and exit",
                    x => showHelp = true },
                {   "v|version",
                    "Print version and exit",
                    x => showVersion = true },
                {   "verbose",
                    "Print extra information with some subcommands",
                    x => verbose = true },
            };

            var args2 = _options.Parse(args);

            try
            {
                if (showHelp || args.Length < 1)
                {
                    ShowUsage();
                    return;
                }

                if (showVersion)
                {
                    ShowVersion();
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.Write("There was an internal error");
                if (verbose)
                {
                    Console.WriteLine(":");
                    Console.WriteLine(ex.ToString());
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        
        static void ShowVersion()
        {
            var assembly = typeof(Program).Assembly;
            var version = assembly.GetName().Version.ToString();
            Console.WriteLine("BeanCounter version {0}", version);
        }

        static void ShowUsage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("    BeanCounter [options]");
            Console.WriteLine();

            _options.WriteOptionDescriptions(Console.Out);
        }
    }
}

