namespace Teach.App.Trees;

public static class TreeExtension
{
	//тут должен быть метод, который ищет узел в дереве и возвращает его
	public static bool FindNode(this TreeNode node, string nodeName)
	{
		var stackNodes = new Queue<TreeNode>();
		if (node.Name == nodeName)
			return true;

		foreach (var chlidNode in node.Childs)
			stackNodes.Enqueue(chlidNode);

		while (stackNodes.Count > 0)
		{
			var currentNode = stackNodes.Dequeue();

			if (currentNode.Name == nodeName)
			{
				return true;
			}

			foreach (var chlidNode in currentNode.Childs)
				stackNodes.Enqueue(chlidNode);
		}

		return false;
	}
	
	//тут должен быть метод, который ищет узел в дереве и возвращает его родителя
	public static TreeNode FindNodeParent(this TreeNode node, string nodeName)
	{

		var stackNodes = new Queue<TreeNode>();
		var parentNode = node;
		if (node.Name == nodeName)
			Console.WriteLine("Нет родительского элемента");

		foreach (var chlidNode in node.Childs)
			stackNodes.Enqueue(chlidNode);

		while (stackNodes.Count > 0)
		{
			var currentNode = stackNodes.Dequeue();

			if (currentNode.Name == nodeName)
			{
				return parentNode;
			}

			foreach (var chlidNode in currentNode.Childs)
			{
				parentNode = currentNode;
				stackNodes.Enqueue(chlidNode);
			}

		}
		return null;
	}

	//тут должен быть метод, который добавляет узел в дочерние, к указанному узлу
	public static TreeNode AddToChildNodes(this TreeNode node, string parentNodeName, string childNodeName)
	{
		var stackNodes = new Queue<TreeNode>();
		var child = new TreeNode { Name = childNodeName };

		if (node.Name == parentNodeName)
			node.Childs.Add(new TreeNode { Name = childNodeName });

		foreach (var chlidNode in node.Childs)
			stackNodes.Enqueue(chlidNode);

		while (stackNodes.Count > 0)
		{
			var currentNode = stackNodes.Dequeue();

			if (currentNode.Name == parentNodeName)
			{
				return child;
			}

			foreach (var chlidNode in currentNode.Childs)
			{
				stackNodes.Enqueue(chlidNode);
				child.Childs.Add(chlidNode);
			}

		}

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