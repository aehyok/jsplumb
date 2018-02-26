using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using EAF.Common;
//using EAF.Utility.Web;
using System.Web.Script.Serialization;

public partial class prototype_project_reply_ajax : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        {
            string str = Request.Form["id"];
            string filePath = Server.MapPath("~/prototype/project-reply") + "\\json" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".json";
            WriteToFile(filePath, str, false);
            //Response.Redirect("show-flowChart.aspx?path=" + filePath);
            Response.Write(filePath);
        }
    }
	public static void WriteToFile(string name, string content, bool isCover)
	{
		FileStream fs = null;
		try
		{
			if (!isCover && File.Exists(name))
			{
				fs = new FileStream(name, FileMode.Append, FileAccess.Write);
				StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
				sw.WriteLine(content);
				sw.Flush();
				sw.Close();
			}
			else
			{
				File.WriteAllText(name, content, Encoding.UTF8);
			}
		}
		finally
		{
			if (fs != null)
			{
				fs.Close();
			}
		}

	}

}