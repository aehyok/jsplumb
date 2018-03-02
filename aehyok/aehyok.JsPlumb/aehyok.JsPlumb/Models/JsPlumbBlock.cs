using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aehyok.JsPlumb.Models
{
    public class JsPlumbBlock
    {
        /// <summary>
        /// 块Id
        /// </summary>
        public string BlockId { get; set; }

        /// <summary>
        /// 块显示内容
        /// </summary>
        public string BlockContent { get; set; }

        /// <summary>
        /// 块X坐标
        /// </summary>
        public int BlockX { get; set; }

        /// <summary>
        /// 块Y坐标
        /// </summary>
        public int BlockY { get; set; }
    }
}