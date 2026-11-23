using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021C2 RID: 8642
[bmq("1.0.1.11_Fo2", "9.9.9.9", "Fo2", false)]
public sealed class dff : fg
{
	// Token: 0x0600C9DB RID: 51675 RVA: 0x00476DD8 File Offset: 0x00474FD8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "Fo2_l3") + ".uzl");
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
