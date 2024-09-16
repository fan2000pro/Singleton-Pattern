using System;
using System.Collections.Generic;
using System.Linq;

public class Ser
{
    private static Lazy<Ser> ex = new Lazy<Ser>(() => new Ser());
    private HashSet<string> ser;
    private Ser()
    {
        ser = new HashSet<string>();
    }
    public static Ser Example => ex.Value;
    public bool AddSer(string serAddress)
    {
        if (string.IsNullOrEmpty(serAddress) || (!serAddress.StartsWith("http://") && !serAddress.StartsWith("https://")))
        {
            return false;
        }
        return ser.Add(serAddress);
    }
    public IEnumerable<string> GetHttpSer()
    {
        return ser.Where(ser => ser.StartsWith("http://")).ToList();
    }
    public IEnumerable<string> GetHttpsSer()
    {
        return ser.Where(ser => ser.StartsWith("https://")).ToList();
    }
}
class Program
{
    static void Main()
    {
        var ser = Ser.Example;
        bool added1 = ser.AddSer("ww7.141592653589793238462643383279502884197169399375105820974944592.com");
        bool added2 = ser.AddSer("http://www.dotcom.com/");
        bool added3 = ser.AddSer("https://rkn.gov.ru/");
        bool added4 = ser.AddSer("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        Console.WriteLine($"Added ww7.141592653589793238462643383279502884197169399375105820974944592.com: {added1}");
        Console.WriteLine($"Added http://www.dotcom.com/: {added2}");
        Console.WriteLine($"Added https://rkn.gov.ru/: {added3}");
        Console.WriteLine($"Added https://www.youtube.com/watch?v=dQw4w9WgXcQ: {added4}");
        var httpSer = ser.GetHttpSer();
        var httpsSer = ser.GetHttpsSer();
        Console.WriteLine("HTTP Servers:");
        foreach (var server in httpSer)
        {
            Console.WriteLine(server);
        }
        Console.WriteLine("HTTPS Servers:");
        foreach (var server in httpsSer)
        {
            Console.WriteLine(server);
        }
    }
}