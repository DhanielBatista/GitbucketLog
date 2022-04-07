using BitbucketLog;
using System.Net;
using System.Text;

if (string.IsNullOrEmpty(args[0]))
{
    Console.WriteLine("You forgot to define the file path as a parameter.");
    return;
}
var fileLines = File.ReadLines(args[0]);
if (fileLines.Count() <= 0)
{
    Console.WriteLine("file don't has content");
    return;
}

foreach (var line in fileLines)

{
    var myReq = (HttpWebRequest)WebRequest.Create("https://api.bitbucket.org/2.0/users/"+line);
    myReq.Method = "GET";
    var response = myReq.GetResponse();
    var stringResponse = Utils.GetStringFromStream(Encoding.UTF8, response.GetResponseStream());
    File.AppendAllText("log-bitbucket.txt", stringResponse+"\n\n");
    Thread.Sleep(5000);
}