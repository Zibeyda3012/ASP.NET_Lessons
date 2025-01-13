using System.Net;

namespace ASP_Lesson1_Introduction;

public class Webhost
{
    private short _port;
    private HttpListener _listener;

    public Webhost(short port)
    {
        _port = port;
    }

    public void Run()
    {
        _listener = new HttpListener();
        _listener.Prefixes.Add($"http://localhost:{_port}/");
        _listener.Start();
        Console.WriteLine($"Http server started on {_port}");

        while ( true )
        {
            HttpListenerContext context = _listener.GetContext();

            Task.Run(() =>
            {
                HandlerRequest(context );
            });
        }
    }

    private void HandlerRequest(HttpListenerContext context)
    {
        HttpListenerRequest request = context.Request;
        HttpListenerResponse response = context.Response;   

        var writer = new StreamWriter(response.OutputStream);
        
        var str = request.RawUrl;
        var path = str.Substring(1);

        Console.WriteLine(path);

        if (path == "")
            path = "index";

        if (!Path.HasExtension(path))
            path += ".html";

        var fileName = "../../../Views/" + path;

        try
        {
            if (File.Exists(fileName))
            {
                response.StatusCode = 200;
                response.ContentType = "text/html";
                var text = File.ReadAllText(fileName);
                writer.Write(text);
            }

            else
            {
                response.StatusCode = 200;
                var text = File.ReadAllText("../../../Views/404.html");
                writer.Write(text);
            }
        }
        catch (Exception ex)
        {
            response.StatusCode = 500;
            writer.Write(ex.ToString());
        }

        finally
        {
            writer.Dispose();
        }

    




    }
}
