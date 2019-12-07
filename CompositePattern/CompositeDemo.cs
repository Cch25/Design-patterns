using CompositePattern.DataManager;
using DesignPatterns.Composite;
using DesignPatterns.Composite.Leaf;
using System.Collections.Generic;

namespace CompositePattern
{
    public class CompositeDemo
    {
        public void Build()
        {
            List<RootObject> model = DataManagerHelper.ParseJson();
            PopulateTreeStruture(model);
        }
        public void PopulateTreeStruture(List<RootObject> model)
        {
            Composite root = new Composite(">>Explorer<<");
            foreach (RootObject node in model)
            {
                Composite newFolder = new Composite(node.fileName);
                PopulateTreeRecursive(newFolder, node.folders);
                root.AddComponent(newFolder);
            }
            root.Display(1);
        }

        private void PopulateTreeRecursive(Composite root, List<Folder> node)
        {
            if (node.Count > 0)
            {
                foreach (Folder folder in node)
                {
                    if (folder.folders.Count == 0) //I'm a leaf
                    {
                        root.AddComponent(new Leafs($"{folder.fileName}"));
                    }
                    if (folder.folders.Count > 0) //I'm a root
                    {
                        Composite folderInstance = root.AddComponent(new Composite($"{folder.fileName}")) as Composite;
                        PopulateTreeRecursive(folderInstance, folder.folders);
                    }
                }
            }
        }
    }
}
