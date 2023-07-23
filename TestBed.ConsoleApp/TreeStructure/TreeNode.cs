namespace TestBed.ConsoleApp.TreeStructure;

using System;
using System.Collections.Generic;


public interface IObjectCloner<T>
{
    T? Clone(T? source);
}

public class TreeNode<T>
{
    private class _NoCloner : IObjectCloner<T>
    {
        public T? Clone(T? source) => source;
    }

    private readonly _NoCloner _noCloner = new ();

    private readonly List<TreeNode<T>> _nodes = new();

    public T? Data { get; set; }

    public TreeNode<T>? Parent { get; private set; }

    public TreeNode<T>[] Nodes => _nodes.ToArray();

    public TreeNode<T> AddNode(T? data)
    {
        var childNode = new TreeNode<T> { Data = data, Parent = this };
        _nodes.Add(childNode);

        return childNode;
    }

    public void MoveTo(TreeNode<T> targetParent)
    {
        Parent?._nodes.Remove(this);
        Parent = targetParent;
        targetParent?._nodes.Add(this);
    }

    public TreeNode<T> CopyTo(TreeNode<T> target, IObjectCloner<T>? dataCloner = null)
    {
        throw new NotImplementedException();

        if (target is null)
        {
            throw new ArgumentNullException(nameof(target));
        }

        var cloner = dataCloner ?? _noCloner;

        var cloneOfData = cloner.Clone(Data);
        
        return target.AddNode(cloneOfData);

        // TODO: do the same for children
    }

}
