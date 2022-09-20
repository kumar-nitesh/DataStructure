using BinaryTree;

BinaryTree.BinaryTree binaryTree = new BinaryTree.BinaryTree();
SimpleBinaryTree.Create(binaryTree);

//SampleTree.Traversal();
//Console.WriteLine("Height of the Binary Tree : " + SampleTree.Height());
//Console.WriteLine("Size of the Binary Tree : " + SampleTree.Size());
//Console.WriteLine("Min of the Binary Tree : " + SampleTree.Minimum());
//Console.WriteLine("Max of the Binary Tree : " + SampleTree.Maximum());
//Console.WriteLine("Level Order of the Binary Tree : ");
//SampleTree.LevelOrder();
Console.WriteLine("Left View of the Binary Tree : ");
SampleTree.LeftView();
Console.WriteLine("Right View of the Binary Tree : ");
SampleTree.RightView();
//Console.WriteLine("Top View of the Binary Tree : ");
//SampleTree.TopView();
//Console.WriteLine("Bottom View of the Binary Tree : ");
//SampleTree.BottomView();