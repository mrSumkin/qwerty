using System;
using System.Diagnostics;

// Token: 0x020021B0 RID: 8624
[bmq("1.0.1.11_CC16_Tunneler", "1.0.1.11", "cc16", false)]
public sealed class cqa : fg
{
	// Token: 0x0600C9B6 RID: 51638 RVA: 0x00475CAC File Offset: 0x00473EAC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("94a7f948-a029-4021-9eb2-daf0fcec544a"), A_1.n("cc16")).ao() as c5x;
			if (c5x != null && c5x.y8() != "Tunneler")
			{
				c5x.q("Tunneler");
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
