using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021C1 RID: 8641
[bmq("1.0.1.11_Wa-mf", "9.9.9.9", "wa-mf", false)]
public sealed class ctq : fg
{
	// Token: 0x0600C9D9 RID: 51673 RVA: 0x00476D6C File Offset: 0x00474F6C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "wa-mf_l2") + ".uzl");
			A_1.a(a_, aju.x, null);
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
