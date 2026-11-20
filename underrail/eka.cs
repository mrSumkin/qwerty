using System;

// Token: 0x020004C4 RID: 1220
public sealed class eka : cc8
{
	// Token: 0x06001F19 RID: 7961 RVA: 0x000AC2CC File Offset: 0x000AA4CC
	public dnh as6(string A_0, int A_1, bool A_2)
	{
		dou dou = new dou();
		dou.a(A_0);
		dou.a(A_1);
		dou.b(A_2);
		return dou;
	}

	// Token: 0x06001F1A RID: 7962 RVA: 0x000AC2E8 File Offset: 0x000AA4E8
	public esc as7(string A_0, int A_1)
	{
		ete ete = new ete();
		ete.a(A_0);
		ete.a(A_1);
		return ete;
	}

	// Token: 0x06001F1B RID: 7963 RVA: 0x000AC300 File Offset: 0x000AA500
	public esc as8(object A_0)
	{
		mk mk = new mk();
		mk.GiveTo = bvl.d;
		coh coh = A_0 as coh;
		if (coh != null)
		{
			mk.StaticItems.z3(coh.fy(), true);
		}
		b6e b6e = new b6e();
		b6e.a(mk);
		return b6e;
	}

	// Token: 0x06001F1C RID: 7964 RVA: 0x000AC348 File Offset: 0x000AA548
	public esc as9(string A_0, Guid? A_1, int A_2, bool A_3, bool A_4, Guid? A_5, bool A_6)
	{
		b50 b = new b50();
		b.a(A_1);
		b.a(A_0);
		b.a(A_2);
		b.c(A_3);
		b.b(A_4);
		b.b(A_5);
		b.a(A_6);
		return b;
	}
}
