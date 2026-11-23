using System;
using System.Linq;

// Token: 0x020007D8 RID: 2008
public static class bjv
{
	// Token: 0x0600324A RID: 12874 RVA: 0x00137780 File Offset: 0x00135980
	public static void a(cyt A_0, string A_1)
	{
		if (A_0.v() != null && !A_0.v().Dead && A_0.v().b() != null && A_0.v().b().j == cgy.b && Enumerable.FirstOrDefault<coh>(A_0.v().Bag.b("plot.xpbl_navcom")) != null)
		{
			A_0.r()[A_1] = true;
			bfq bfq = new bfq();
			bfq.b("navcom");
			bfq.c("NavcomIncomingCall");
			bfq.a(c9z.b);
			bfq.a(1f);
			bfq.a(bvl.d);
			bfq.ym(A_0.v().b(), null, null);
			a72 a = new a72();
			a.b("interfacing\\xpbl\\navcom");
			a.d("navcom");
			a.c("Navcom");
			a.ym(A_0.v().b(), null, null);
		}
	}
}
