// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

class Search
{
    static void Main(string[] args) 
    {
        Console.WriteLine("検索内容");
        string words = Console.ReadLine().ToString();
        //Console.WriteLine(words);
        var f = new OFile();
        f.Root = Directory.GetCurrentDirectory();
        var file = new FileInfo(f.Root);
        //Console.WriteLine(file.Exists);
        try
        {
            using (var reader = new StreamReader(f.Root)) 
            {
                var rgx = new Regex(".*" + words + ".*");
                var match = rgx.Match(reader.ReadToEnd());
                Console.WriteLine(match.Success ? match.Value : "見つかりません。");
            }
        }
        catch(FileNotFoundException) 
        {
            Console.WriteLine("data.txtが見つかりませんでした。");
        }
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
