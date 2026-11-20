using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021D0 RID: 8656
[bmq("1.0.3.4_Jy7_Rift", "1.0.3.4", "jy7", true)]
public sealed class as2 : fg
{
	// Token: 0x0600C9F7 RID: 51703 RVA: 0x00477838 File Offset: 0x00475A38
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "jy7_l2") + ".uzl");
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
