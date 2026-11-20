using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021CF RID: 8655
[bmq("1.0.3.4_Cc_abandoned_Rift", "1.0.3.4", "cc_abandoned", true)]
public sealed class cel : fg
{
	// Token: 0x0600C9F5 RID: 51701 RVA: 0x004777D0 File Offset: 0x004759D0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cc_abandoned_l4") + ".uzl");
			A_1.a(a_, 1, null);
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
