namespace Teach.App.Trees;

public static class TreeExtension
{
	//тут должен быть метод, который ищет узел в дереве и возвращает его
	public static TreeNode FindNode(this TreeNode node, string nodeName)
	{
		return null;
	}
	
	//тут должен быть метод, который ищет узел в дереве и возвращает его родителя
	public static TreeNode FindNodeParent(this TreeNode node, string nodeName)
	{
		
		return null;
	}

	//тут должен быть метод, который добавляет узел в дочерние, к указанному узлу
	public static TreeNode AddToChildNodes(this TreeNode node, string parentNodeName, string childNodeName)
	{
		return null;
	}

	//тут должен быть метод, который удаляет узел из дочерних у указанного узла
	public static TreeNode RemoveFromChildNodes(this TreeNode node, string parentNodeName, string childNodeName)
	{
		return null;
	}
	
	public static int NodeSum(this TreeNode node)
	{
		var stackNodes = new Queue<TreeNode>(node.Childs);
		var counter = stackNodes.Count;
		while (stackNodes.Count > 0)
		{
			var currentNode = stackNodes.Dequeue();
			foreach (var chlidNode in currentNode.Childs)
			{
				stackNodes.Enqueue(chlidNode);
				++counter;
			}
		}

		return counter;
	}

}