// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

class Search
{
    static void Main(string[] args) 
    {
        Console.WriteLine("検索内容");
        string words = Console.ReadLine().ToString();
        //Console.WriteLine(words);
        Console.WriteLine(Directory.GetCurrentDirectory());
        var f = new OFile();
        f.Root = Directory.GetCurrentDirectory();
        var file = new FileInfo(f.Root);
        Console.WriteLine(file.Exists);
        //try
       // {
       //     using(var reader=new StreamReader()) { }
        //}
    }
}

internal class OFile 
{
    private string _Path;
    public string Root
    {
        internal set 
        {
            this._Path = value+@"\data.txt";      
        }
        get 
        { 
            return this._Path; 
        }
    }
}
