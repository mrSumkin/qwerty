using System;
using System.Diagnostics;

// Token: 0x020021E5 RID: 8677
[bmq("1.0.0.9_Ojy_U2Locker", "1.0.0.9", "ojy-u2", false)]
public sealed class ezg : fg
{
	// Token: 0x0600CA23 RID: 51747 RVA: 0x00478BC0 File Offset: 0x00476DC0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("ccf0e506-f970-47fd-afea-1c65330bcebc"), A_1.n("ojy-u2")).ao() as c5x;
			if (c5x != null)
			{
				if (c5x.x)
				{
					c5x.x = false;
					c5x.ah();
					c5x.@as();
				}
				if (c5x.VisualPriority == 0)
				{
					c5x.VisualPriority = 1;
					c5x.ah();
					c5x.@as();
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
