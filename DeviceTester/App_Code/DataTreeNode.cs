using System;
using System.Windows.Forms;

namespace TCPDeviceTester
{
	/* Object saklayacak olan TreeNode Class */
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
