using System;
using System.Windows.Forms;

namespace TCPDeviceTester
{
	/// <summary>
    /// TreeNode that holds object.
    /// </summary>
	public class DataTreeNode : TreeNode
	{
		object data;

		public DataTreeNode( object data ) : base ( data.ToString() )
		{
			this.data = data;
		}
    
		public object Data
		{
			get { return data; }
		}
	}
}
