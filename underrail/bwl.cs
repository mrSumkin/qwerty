using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021BD RID: 8637
[bmq("1.0.1.11_Cv-dc", "9.9.9.9", "Cv-dc", false)]
public sealed class bwl : fg
{
	// Token: 0x0600C9D1 RID: 51665 RVA: 0x00476BBC File Offset: 0x00474DBC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "Cv-dc_l2") + ".uzl");
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
