using System;

// Token: 0x020007D0 RID: 2000
public sealed class agp : cm9
{
	// Token: 0x06003224 RID: 12836 RVA: 0x00134BE4 File Offset: 0x00132DE4
	public double ot()
	{
		return 500.0;
	}

	// Token: 0x06003225 RID: 12837 RVA: 0x00134BF0 File Offset: 0x00132DF0
	public void ou(cnk A_0)
	{
		if (A_0 != null && A_0.aqu() != null)
		{
			bv9 bv = A_0.aqu().ac() as bv9;
			if (bv != null)
			{
				h? h = bv.a(asp.bh, asp.a);
				h h2 = h.a;
				if (h.GetValueOrDefault() == h2 & h != null)
				{
					A_0.aqz().atd("jy_garrenAbramShowdown", true);
					A_0.aqz().atd("deliverTradingDocs", true);
				}
			}
		}
	}
}
