namespace EPMS.Domain.Workflow
{
	/// <summary>
	/// JsPlumb流程图中的块定义类（用于序列化）
	/// </summary>
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
