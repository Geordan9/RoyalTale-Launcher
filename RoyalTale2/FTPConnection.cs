﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyalTale2
{
    class FTPConnection
    {
    public string[] GetFileList()
    {
        string[] downloadFiles;
        StringBuilder result = new StringBuilder();
        WebResponse response = null;
        StreamReader reader = null;
        try
        {
            FtpWebRequest reqFTP;
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://100.2.188.147:10666/"));
            reqFTP.UseBinary = true;
            reqFTP.Credentials = new NetworkCredential("Public", "latale");
            reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
            reqFTP.Proxy = null;
            reqFTP.KeepAlive = false;
            reqFTP.UsePassive = true;
            response = reqFTP.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            string line = reader.ReadLine();
            while (line != null)
            {
                        result.Append(line);
                        result.Append("\n");
                        line = reader.ReadLine();
            }
            // to remove the trailing '\n'
            result.Remove(result.ToString().LastIndexOf('\n'), 1);
            return result.ToString().Split('\n');
        }
        catch (Exception ex)
        {
            if (reader != null)
            {
                reader.Close();
            }
            if (response != null)
            {
                response.Close();
            }
            downloadFiles = null;
            return downloadFiles;
        }
    }

        public void Download(string file, string destination)
        {
            try
            {
                string uri = "ftp://100.2.188.147:10666/" + file;
                Uri serverUri = new Uri(uri);
                if (serverUri.Scheme != Uri.UriSchemeFtp)
                {
                    return;
                }
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://100.2.188.147:10666/" + file));
                reqFTP.Credentials = new NetworkCredential("Public", "latale");
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Proxy = null;
                reqFTP.UsePassive = true;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream responseStream = response.GetResponseStream();
                FileStream writeStream = new FileStream(destination + "\\" + file, FileMode.Create);

                int Length = 2048;
                Byte[] buffer = new Byte[Length];
                int bytesRead = responseStream.Read(buffer, 0, Length);
                while (bytesRead > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                    bytesRead = responseStream.Read(buffer, 0, Length);
                }
                writeStream.Close();
                response.Close();
            }
            catch (WebException wEx)
            {
                MessageBox.Show(wEx.Message, "Download Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Download Error");
            }

        }
    }
}