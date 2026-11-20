using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021B5 RID: 8629
[bmq("1.0.1.11_Cc_ph", "9.9.9.9", "cc_ph", false)]
public sealed class eid : fg
{
	// Token: 0x0600C9C0 RID: 51648 RVA: 0x00476354 File Offset: 0x00474554
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cc_ph_l4") + ".uzl");
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
