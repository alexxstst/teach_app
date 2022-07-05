namespace Teach.App.Trees;

public class TreeNode
{
	public List<TreeNode> Childs { get; } = new();
	public string Name { get; set; }
	public int TotalChildNodeCounter => Childs.Count + Childs.Sum(c => c.TotalChildNodeCounter);

	public override string ToString()
	{
		return $"Узел {Name}, Count: {Childs.Count}";
	}
}