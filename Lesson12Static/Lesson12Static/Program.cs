using System;

public class ApplicationSettings
{
    public static string BaseDir;
    public static string GetRelativeDir() 
    {
        return "q"; 
    }
}

static class SimpleClass
{
    static readonly long baseline;

    static SimpleClass()
    {
        baseline = DateTime.Now.Ticks;
    }

    public static long getBaseline()
    {
        return baseline;
    }


}

namespace Lesson12Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //ApplicationSettings as = new ApplicationSettings();

            Console.WriteLine(ApplicationSettings.GetRelativeDir());

            //SimpleClass sc = new SimpleClass();

            Console.WriteLine(SimpleClass.getBaseline());

            //Console.WriteLine("Hello World!");
        }
    }
}
