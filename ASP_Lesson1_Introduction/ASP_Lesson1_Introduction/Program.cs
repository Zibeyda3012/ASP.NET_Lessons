
using ASP_Lesson1_Introduction;
using System.Net;
using System.Text;


#region HttpListener

//HttpListener listener = new HttpListener();

//listener.Prefixes.Add("http://localhost:27001/");
//listener.Start();

//Console.WriteLine("I am listening");

//while (true)
//{
//    HttpListenerContext context = listener.GetContext();
//    Console.WriteLine("Request handle");
//    context.Response.OutputStream.Write(Encoding.UTF8.GetBytes("Hello world"));
//    context.Response.Close();   
//}

#endregion


Webhost myHost = new(27001);
myHost.Run();