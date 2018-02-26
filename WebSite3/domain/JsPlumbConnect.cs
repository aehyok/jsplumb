namespace EPMS.Domain.Workflow
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
		public string SourceId { get; set; }

		/// <summary>
		/// 连接线终点块id
		/// </summary>
		public string TargetId { get; set; }
		
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
