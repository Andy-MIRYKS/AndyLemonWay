using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using System.Xml;


namespace ASPNETWebService
{
    /// <summary>
    /// Description résumée de WebService1
    /// </summary>
    [WebService(Namespace = "http://AndyLemonway/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod(Description = "The  service takes input an integer N, and return"
            + "the Nth value in the Fibonacci Fibonacci sequence.")]
        public int FibonacciService(int N)
        {
            if (N < 1 || N > 100)
                return -1;

            int Nth = 0;
            int x   = 1;
            for (int i = 0; i < N; i++)
            {
                int tempo = Nth;
                Nth = x;
                x = tempo + x;
            }
            return Nth;
        }


        //Modification du web.config pour le paramere d'entree 
        //Je développe comme cela car dans ce cadre la SECURITE est "négligeable"
        [WebMethod(Description = "The  service takes input a string xml and returns" 
            +"the json form of the xml string, It will return \"Bad Xml format\" if the input string"
            +"is not a  well-formed xml")]
        public string XmlToJsonService(string Xml)
        {
            string str_Json = "";

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(Xml);
                str_Json = JsonConvert.SerializeXmlNode(doc);
            }
            catch(XmlException ex)
            {
                str_Json = "Bad Xml format \n"; //+ ex;
            }

            return str_Json;
        }
    }
}
