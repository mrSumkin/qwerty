using System;
using System.Diagnostics;
using System.IO;

// Token: 0x02002178 RID: 8568
[bmq("1.0.3.7_Tch_PhysLabElectroShelves_AlwaysImport", "1.0.3.7", "tch-labphy", true)]
public sealed class dde : fg
{
	// Token: 0x0600C93B RID: 51515 RVA: 0x00471830 File Offset: 0x0046FA30
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "tch-labpsy_L2_AlwaysImported") + ".uzl");
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
