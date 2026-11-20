using System;
using System.Runtime.Serialization;

// Token: 0x02000C89 RID: 3209
[eiz("PIDLE")]
[Serializable]
public sealed class a6m : d4
{
	// Token: 0x060048B3 RID: 18611 RVA: 0x001DAAE0 File Offset: 0x001D8CE0
	private a6m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060048B4 RID: 18612 RVA: 0x001DAAEC File Offset: 0x001D8CEC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060048B5 RID: 18613 RVA: 0x001DAAF8 File Offset: 0x001D8CF8
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(5.0);
	}

	// Token: 0x060048B6 RID: 18614 RVA: 0x001DAB08 File Offset: 0x001D8D08
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(5.0);
	}

	// Token: 0x060048B7 RID: 18615 RVA: 0x001DAB18 File Offset: 0x001D8D18
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(2.0);
	}

	// Token: 0x060048B8 RID: 18616 RVA: 0x001DAB28 File Offset: 0x001D8D28
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(2.0);
	}

	// Token: 0x060048B9 RID: 18617 RVA: 0x001DAB38 File Offset: 0x001D8D38
	public a6m() : base(a6m.a)
	{
	}

	// Token: 0x060048BA RID: 18618 RVA: 0x001DAB48 File Offset: 0x001D8D48
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0) && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value;
	}

	// Token: 0x060048BB RID: 18619 RVA: 0x001DAB8C File Offset: 0x001D8D8C
	protected override void gg(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<int>("faction_xpbl_pirates_totalPiratesKilled", new int?(0)).Value < 50)
		{
			qj qj = new qj();
			qj.a("Pirates");
			qj.ym(A_0.v().b(), null, null);
			eaq eaq = new eaq();
			eaq.b(asp.fr);
			eaq.a(asp.f5);
			eaq.a(h.a);
			eaq.a(true);
			eaq.ym(null, null, null);
			if (!A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_expedition_cutCommunication", new bool?(false)).Value)
			{
				cky cky = (A_0.ac() as bv9).abu(asp.a, asp.f5);
				if (cky != null && cky.a != h.a)
				{
					A_0.r()["interfacing_xpbl_navcom_campAttackCall"] = true;
					bjv.a(A_0, "interfacing_xpbl_navcom_piratesAttackCall");
				}
			}
			c88 a_ = new c88(false);
			A_0.b(a_);
		}
	}

	// Token: 0x04001CC0 RID: 7360
	public new static readonly string a = "lemurianPirateInvasion";
}
