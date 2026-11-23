using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021C0 RID: 8640
[bmq("1.0.1.11_Up-tch", "9.9.9.9", "up-tch", false)]
public sealed class yi : fg
{
	// Token: 0x0600C9D7 RID: 51671 RVA: 0x00476D00 File Offset: 0x00474F00
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "up-tch_l2") + ".uzl");
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
