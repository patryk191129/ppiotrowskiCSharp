using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2
{
    class HTTPServer
    {
        
        Thread _serverThread;

        int _serverPort;
        string _directory;
        bool _serverStarted = false;


        ~HTTPServer()
        {
            _serverStarted = false;
        }

        public void StopServer()
        {
            _serverStarted = false;
            _serverThread = null;
        }


        private string ReturnPage(string filename)
        {
            try
            {
                StreamReader sr = null;
                if (filename == "/")
                    sr = new StreamReader(_directory + filename + "index.html");
                else               
                    sr = new StreamReader(_directory+filename);

                return sr.ReadToEnd();
            }
            catch(Exception e)
            {
                return "<html><head></head><body>Error 404</body></html>";
            }
        }

        public void HTTPThread()
        {
            HttpListener _httpListener = null;
            try
            {
                _httpListener = new HttpListener();
                _httpListener.Prefixes.Add("http://localhost:" + _serverPort + "/");
                _httpListener.Start();
                _serverStarted = true;

                while (_serverStarted)
                {
                    HttpListenerContext context = _httpListener.GetContext();
                    HttpListenerRequest request = context.Request;


                    string msg = ReturnPage(request.RawUrl);
                    context.Response.ContentLength64 = Encoding.UTF8.GetByteCount(msg);
                    context.Response.StatusCode = (int)HttpStatusCode.OK;

                    using (Stream stream = context.Response.OutputStream)
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            writer.Write(msg);
                        }
                    }
                }
                _httpListener.Stop();
            }
            catch(WebException e)
            {
                Console.WriteLine(e.Status);
                _httpListener.Stop();
            }
            catch(HttpListenerException e)
            {
                Console.WriteLine("Port jest zajety");
            }
        }


        public void InitializeServer(int _serverPort, string _directory)
        {
            this._serverPort = _serverPort;
            this._directory = _directory;

            if(_serverThread == null)
            {
                _serverThread = new Thread(this.HTTPThread);
                _serverThread.Start();
            }

        }

    }
}
