using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021C4 RID: 8644
[bmq("1.0.1.11_Cv16", "9.9.9.9", "cv16", false)]
public sealed class avf : fg
{
	// Token: 0x0600C9DF RID: 51679 RVA: 0x00476EB0 File Offset: 0x004750B0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cv16_l2") + ".uzl");
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
