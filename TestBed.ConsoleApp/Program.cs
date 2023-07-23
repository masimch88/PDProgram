using TestBed.ConsoleApp.TreeStructure;

namespace TestBed.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleStringTreeExample();
          
        }

        public static void SimpleStringTreeExample()
        {
            var rootNode = new TreeNode<string>() { Data = "ROOT"};
            var accomodatationNode = rootNode.AddNode("Accomodation");
            var rentNode = accomodatationNode.AddNode("Rent");
            var furnitureNode = accomodatationNode.AddNode("Furniture");
            var chairsNode = furnitureNode.AddNode("Chairs");
            var bedsNode = furnitureNode.AddNode("Beds");
            var tablesNode = furnitureNode.AddNode("Tables");

            var foodNode = rootNode.AddNode("Food");
            var rawNode = foodNode.AddNode("Raw");
            var cerealsNode = rawNode.AddNode("Cereals");
            var lintleNode = rawNode.AddNode("Lintles");
            var redBeansNode = lintleNode.AddNode("Red Beans");
            var gramNode = lintleNode.AddNode("Grams");
            var chickPeasNode = lintleNode.AddNode("Chick Peas");
            var spices = rawNode.AddNode("Spices");
            var readyNode = foodNode.AddNode("Ready");
            var fruitNode = readyNode.AddNode("Fruit");
            var nutsNode = readyNode.AddNode("Nuts");
            var bakeryNode = readyNode.AddNode("Bakery");
            var biscuitsNode = bakeryNode.AddNode("Biscuit");
            var breadNode = bakeryNode.AddNode("Bread");

            var energyNode = rootNode.AddNode("Energy");
            var gasNode = energyNode.AddNode("Gas");
            var elelctricNode = energyNode.AddNode("Electric");


            energyNode.MoveTo(chickPeasNode);

            Display(rootNode);
        }

        
        

        public static void Display<T>(TreeNode<T> root, int level = 0)
        {
            string indent = string.Empty.PadLeft(level * 2, ' ');
            Console.WriteLine("{0}{1}", indent, root.Data);

            foreach (var childNode in root.Nodes)
            {
                Display(childNode, level + 1);
            }
        }
    }
}

/*
Accomodation
	Rent
	Furniture
		Chairs
		Beds
		Tables
Food
	Raw
		Searals
		Lentils
			Red beans
			Garam
			Chick Peas
		Spicies
	Ready
		Fruit
		Nuts
		Bakery
			Biscuits
			Breads
Energy
	Gas
	Electric
		
 */