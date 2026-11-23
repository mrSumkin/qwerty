using System;
using System.Diagnostics;
using System.IO;

// Token: 0x0200217C RID: 8572
[bmq("1.0.3.6_Fo3_AlwaysImport", "9.9.9.9", "fo3", false)]
public sealed class b7s : fg
{
	// Token: 0x0600C943 RID: 51523 RVA: 0x00471C24 File Offset: 0x0046FE24
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "fo3_L2_AlwaysImport") + ".uzl");
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
