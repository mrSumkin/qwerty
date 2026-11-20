using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021BF RID: 8639
[bmq("1.0.1.11_Lup-a3", "9.9.9.9", "lup-a3", false)]
public sealed class amq : fg
{
	// Token: 0x0600C9D5 RID: 51669 RVA: 0x00476C94 File Offset: 0x00474E94
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "lup-a3_l2") + ".uzl");
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
