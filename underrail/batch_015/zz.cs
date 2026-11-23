using System;
using System.Diagnostics;
using System.IO;

// Token: 0x02002177 RID: 8567
[bmq("1.0.3.7_Up10", "1.0.3.7", "up10", true)]
public sealed class zz : fg
{
	// Token: 0x0600C939 RID: 51513 RVA: 0x004717C4 File Offset: 0x0046F9C4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "up10_L2_AlwaysImported") + ".uzl");
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
