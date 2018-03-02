using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aehyok.JsPlumb.Models
{
    /// <summary>
    /// JsPlumb连线类
    /// </summary>
    public class JsPlumbConnect
    {
        /// <summary>
        /// 连接线id
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// 连接线起点块id
        /// </summary>
        public string PageSourceId { get; set; }

        /// <summary>
        /// 连接线终点块id
        /// </summary>
        public string PageTargetId { get; set; }

        /// <summary>
        /// 连接线起点块内容
        /// </summary>
        public string SourceText { get; set; }

        /// <summary>
        /// 连接线终点块内容
        /// </summary>
        public string TargetText { get; set; }

        /// <summary>
        /// 起点块位置
        /// </summary>
        public string SourceAnchor { get; set; }

        /// <summary>
        /// 终点块位置
        /// </summary>
        public string TargetAnchor { get; set; }

        /// <summary>
        /// 连接线内容
        /// </summary>
        public string ConnectText { get; set; }
    }
}