using System;
using System.Diagnostics;

// Token: 0x020020AD RID: 8365
[bmq("1.2.0.0_Xpbl_Ojyc_VehicleDriverProtectionFix", "1.2.0.0", "xpbl_ojyc2,xpbl_ojyc3", true)]
public sealed class d9v : fg
{
	// Token: 0x0600C7CB RID: 51147 RVA: 0x00466468 File Offset: 0x00464668
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (b0b b0b in A_1.n(A_1.y8()).Entities)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && c5x.h.b.aa().Vehicle != null)
				{
					bfe.a(c5x, false);
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
