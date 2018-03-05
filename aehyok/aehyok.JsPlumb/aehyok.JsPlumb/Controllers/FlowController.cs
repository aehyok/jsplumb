using aehyok.JsPlumb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace aehyok.JsPlumb.Controllers
{
    public class FlowController : Controller
    {
        // GET: Flow
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ajax()
        {
            string str = Request.Form["data"];
            string filePath = Server.MapPath("~") + "\\json" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".json";
            WriteToFile(filePath, str, false);

            return Content(filePath);
        }


        public static void WriteToFile(string name, string content, bool isCover)
        {
            FileStream fileStream = null;
            try
            {
                if (!isCover && System.IO.File.Exists(name))
                {
                    fileStream = new FileStream(name, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fileStream, Encoding.UTF8);
                    sw.WriteLine(content);
                    sw.Flush();
                    sw.Close();
                }
                else
                {
                    System.IO.File.WriteAllText(name, content, Encoding.UTF8);
                }
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }

        public ActionResult FlowChart()
        {
            string path = Request.QueryString["path"];// Request["path"];
            StreamReader sr = new StreamReader(path);
            string jsonText = sr.ReadToEnd();

            List<JsPlumbConnect> list = new JavaScriptSerializer().Deserialize<List<JsPlumbConnect>>(jsonText.Split('&')[0]);
            List<JsPlumbBlock> blocks = new JavaScriptSerializer().Deserialize<List<JsPlumbBlock>>(jsonText.Split('&')[1]);
            string htmlText = "";
            string conn = "";
            string script = "";
            if (blocks.Count > 0)
            {
                foreach (JsPlumbBlock block in blocks)
                {
                    if (block.BlockContent == "开始" || block.BlockContent == "结束")
                        htmlText += "<div class='node radius' id='" + block.BlockId + "'style='left:" + block.BlockX + "px;top:" + block.BlockY + "px;background-color: #485FA5;' onclick='FlowStateCirculate_Click(this)' >" + block.BlockContent + "</div>";
                    else
                        htmlText += "<div class='node' id='" + block.BlockId + "'style='left:" + block.BlockX + "px;top:" + block.BlockY + "px;background-color: #485FA5;' onclick='FlowStateCirculate_Click(this)' >" + block.BlockContent + "</div>";
                }

                foreach (JsPlumbConnect jsplum in list)
                {
                    if (jsplum.ConnectText == null)
                        conn +=
                            "jsPlumb.bind(\"connection\",function (connInfo, originalEvent) {	connInfo.connection.setLabel(\" \")});";
                    else
                        conn +=
                          "jsPlumb.bind(\"connection\",function (connInfo, originalEvent) {	connInfo.connection.setLabel(\"<span onmouseover='FlowActionClick()' style='display:block;padding:10px;opacity: 0.9;height:auto;background-color:white;text-align:center;font-size:12px;color:black;border-radius:0.5em;'>" + jsplum.ConnectText + "</span>\")});";
                    conn += "jsPlumb.connect({ source: \"" + jsplum.PageSourceId + "\", target: \"" + jsplum.PageTargetId +
                            "\" ,anchors:[\"" + jsplum.SourceAnchor + "\",\"" + jsplum.TargetAnchor + "\"]},flowConnector);";

                }
                //Literal1.Text = htmlText;
                script = "jsPlumb.ready(function () {" + conn + "});";
            }
            ViewData["HtmlText"] = htmlText;
            ViewData["JavaScript"] = script;
            
            return View();
        }
    }
}