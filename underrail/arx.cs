using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021C3 RID: 8643
[bmq("1.0.1.11_StationAlpha-Level8", "9.9.9.9", "StationAlpha-Level8", false)]
public sealed class arx : fg
{
	// Token: 0x0600C9DD RID: 51677 RVA: 0x00476E44 File Offset: 0x00475044
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "StationAlpha-Level8_l4") + ".uzl");
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
