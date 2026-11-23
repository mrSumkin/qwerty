using System;

// Token: 0x02000806 RID: 2054
public sealed class dpc : el4
{
	// Token: 0x060033D9 RID: 13273 RVA: 0x001422F8 File Offset: 0x001404F8
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x060033DA RID: 13274 RVA: 0x00142304 File Offset: 0x00140504
	public override string a4()
	{
		return "GC_Gypsy";
	}

	// Token: 0x060033DB RID: 13275 RVA: 0x0014230C File Offset: 0x0014050C
	public override string a5()
	{
		return "Coral";
	}

	// Token: 0x060033DC RID: 13276 RVA: 0x00142314 File Offset: 0x00140514
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && A_0.r().GetPrimitivePropertyValue<bool>("frag_gc_gypsy", new bool?(false)).Value;
	}

	// Token: 0x060033DD RID: 13277 RVA: 0x00142358 File Offset: 0x00140558
	public override bool fl()
	{
		return true;
	}

	// Token: 0x060033DE RID: 13278 RVA: 0x0014235C File Offset: 0x0014055C
	public override double ke()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("gp_crp", new bool?(false)).Value)
		{
			return 1.0;
		}
		return 0.25;
	}

	// Token: 0x060033DF RID: 13279 RVA: 0x001423B8 File Offset: 0x001405B8
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(30.0));
	}

	// Token: 0x060033E0 RID: 13280 RVA: 0x001423D0 File Offset: 0x001405D0
	protected override bool oe()
	{
		return true;
	}

	// Token: 0x060033E1 RID: 13281 RVA: 0x001423D8 File Offset: 0x001405D8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		if (A_0.r().GetPrimitivePropertyValue<bool>("gp_crp", new bool?(false)).Value)
		{
			A_0.r()["npc_gc_gypsy_recheck"] = true;
		}
		A_0.r()["npc_gc_gypsy_askedLocationSouls"] = false;
	}

	// Token: 0x060033E2 RID: 13282 RVA: 0x00142440 File Offset: 0x00140640
	public dpc() : base(new string[]
	{
		ega.aj,
		ega.av,
		ega.ac,
		ega.af,
		ega.bv,
		ega.ag,
		ega.z
	})
	{
	}
}
