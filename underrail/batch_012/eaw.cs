using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021BE RID: 8638
[bmq("1.0.1.11_Rc2", "9.9.9.9", "Rc2", false)]
public sealed class eaw : fg
{
	// Token: 0x0600C9D3 RID: 51667 RVA: 0x00476C28 File Offset: 0x00474E28
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "Rc2_l5") + ".uzl");
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
