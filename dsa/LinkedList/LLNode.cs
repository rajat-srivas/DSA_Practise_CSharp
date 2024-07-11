namespace dsa.LinkedList
{
	public class LLNode
	{
		public int Data { get; set; }

		public LLNode Next { get; set; }

		public LLNode(int d)
		{
			Data = d;
			Next = null;
		}
	}
}
