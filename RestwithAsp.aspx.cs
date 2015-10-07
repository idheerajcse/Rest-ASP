using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Data;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
 



public partial class proxy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        if (Request.QueryString["url"] != null && Request.QueryString["type"] !=null)
        {
            string url = Request.QueryString["url"].ToString().Trim();
            string type = Request.QueryString["type"].ToString().Trim();
   
            string sBaseUrl = "http://122.169.249.115:8080/_vti_bin/Listdata.svc/" + url;
           
            //string sBaseUrl =" https://netpeacho365.sharepoint.com/sites/BrandingPOC1/_api/Web/Lists/GetByTitle('UserInfo')/Items";
            if (sBaseUrl != "")
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sBaseUrl);
                request.Method = type;
                request.UnsafeAuthenticatedConnectionSharing = true;
                request.Headers["Authorization"] = "Bearer 00000003-0000-0ff1-ce00-000000000000";
               // request.Headers["Accept"] = "application/json;odata=verbose";
                request.Accept = "application/json";
                request.ContentType = "application/atom+json; charset=utf-8";
               
              //  request.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream"); 
                
               
                request.PreAuthenticate = true;
                
              

                request.Credentials = CredentialCache.DefaultNetworkCredentials;
               // request.Credentials = new NetworkCredential("dkumar@netpeach.com", "sdsdsdsdg");
                

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                
                StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8);
                Response.Write(reader.ReadToEnd());
               
                //System.Web.Script.Serialization.JavaScriptSerializer scr = new System.Web.Script.Serialization.JavaScriptSerializer();
                //string str = scr.Serialize(response);
                //Response.Write(str);
                //string json = JsonConvert.SerializeObject(reader.ReadToEnd(), Formatting.Indented);

                
               
                
                //Console.WriteLine(json);
                
                

                
                
                //string result = reader.ReadToEnd();
               // System.Diagnostics.Debug.WriteLine(result);

            }
            else
            {
               
            }
        
        }
