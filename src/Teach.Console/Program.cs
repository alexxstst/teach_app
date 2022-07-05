using Teach.App.Trees;

namespace Teach.App;

class Progran
{
	public static int Main(string[] args)
	{
		var rootNode = new TreeNode { Name = "Театр" };

		var scene = new TreeNode { Name = "Сцена" };
		scene.Childs.Add(new TreeNode { Name = "Клоун1" });
		scene.Childs.Add(new TreeNode { Name = "Клоун2" });

		rootNode.Childs.Add(scene);
		var parter = new TreeNode { Name = "Партер" };
		rootNode.Childs.Add(parter);
		rootNode.Childs.Add(new TreeNode { Name = "Общий зал" });
		var sortir = new TreeNode { Name = "Сортир" };
		var bomg = new TreeNode { Name = "Бомж" };
		var msg = new TreeNode { Name = "Мешок с глазами" };
		msg.Childs.Add(new TreeNode { Name = "Кнопка" });
		bomg.Childs.Add(msg);
		sortir.Childs.Add(bomg);
		rootNode.Childs.Add(sortir);
		
		Console.WriteLine("Количество дочерних узлов: " 
								 + rootNode.NodeSum() 
								 + " TT: " + rootNode.TotalChildNodeCounter);

		return 0;
	}
}