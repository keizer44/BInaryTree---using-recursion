using MyBinaryTree;

Tree tree = new(9);
// Original tree
tree.Add(tree.Root,5);
tree.Add(tree.Root,11);
tree.Add(tree.Root,3);
tree.Add(tree.Root,7);


// Added
tree.Add(tree.Root, 6);
tree.Add(tree.Root,8);
tree.Add(tree.Root, 12);
tree.Add(tree.Root, 15);
tree.Add(tree.Root, 18);
tree.Add(tree.Root, 4);
tree.Add(tree.Root,14);

tree.Show(tree.Root);

Console.WriteLine("-----------------");
tree.Delete(tree.Root, 12);

tree.Show(tree.Root);

int a = 5;