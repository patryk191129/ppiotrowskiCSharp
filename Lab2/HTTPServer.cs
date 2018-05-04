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
        Form1 _form1;
        HttpListener _httpListener;

        int _serverPort;
        string _directory;
        bool _serverStarted = false;
        


        ~HTTPServer()
        {
            _serverStarted = false;
        }

        public HTTPServer(Form1 _form1)
        {
            this._form1 = _form1;
        }

        public void StopServer()
        {
            _serverStarted = false;
            _httpListener.Close();

            if (_serverThread != null)
            {
                _serverThread.Abort();
                _serverThread = null;
            }
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
                   

                UpdateServerLog(DateTime.Now.ToString("HH:mm:ss") + " Loaded page " + filename + ".");
                return sr.ReadToEnd();
            }
            catch(Exception e)
            {
                if(filename != "/favicon.ico")
                    UpdateServerLog(DateTime.Now.ToString("HH:mm:ss") + " Error 404: Failed to load page" + filename + ".");

                    return "<html><head></head><body>Error 404</body></html>";
            }
        }

        public void HTTPThread()
        {
            try
            {
                _httpListener = new HttpListener();
                _httpListener.Prefixes.Add("http://localhost:" + _serverPort + "/");
                _httpListener.Start();
                _serverStarted = true;

                UpdateServerLog("Server started, port " + _serverPort+".");

                while (_serverStarted)
                {
                    try
                    {
                        HttpListenerContext context = _httpListener.GetContext();
                        HttpListenerRequest request = context.Request;
                        string msg = ReturnPage(request.RawUrl);
                        context.Response.ContentLength64 = Encoding.UTF8.GetByteCount(msg);
                        context.Response.StatusCode = (int)HttpStatusCode.OK;


                        /*if(request.RawUrl == "/wyjatek.html")                            
                        {
                            msg = null;
                        }*/

                            using (Stream stream = context.Response.OutputStream)
                            {
                                using (StreamWriter writer = new StreamWriter(stream))
                                {
                                    writer.Write(msg);
                                }
                            }
                        
                    }
                    catch
                    {
                        UpdateServerLog("Server has been stopped.");
                    }

                }
                _httpListener.Stop();
            }
            catch(WebException e)
            {
                Console.WriteLine(e.Status);
                _httpListener.Stop();
                UpdateServerLog("Unexpected server error.");
            }
            catch(HttpListenerException e)
            {
                UpdateServerLog("Error - port "+_serverPort+" already in use.");
            }
        }


        public void InitializeServer(int _serverPort, string _directory)
        {
            this._serverPort = _serverPort;
            this._directory = _directory;

            if (_serverThread == null)
            {
                _serverThread = new Thread(this.HTTPThread);
                _serverThread.Start();
            }
            else
                UpdateServerLog("Error - server is already running in previous port.");

        }


        private void UpdateServerLog(string serverLogInfo)
        {
            if(_form1 != null)
                _form1.UpdateServerLog(serverLogInfo);
        }

    }
}
