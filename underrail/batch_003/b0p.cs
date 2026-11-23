using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F85 RID: 8069
[ayj("FoodConsumation")]
public sealed class b0p : awn
{
	// Token: 0x0600BD45 RID: 48453 RVA: 0x0041778C File Offset: 0x0041598C
	public override string y8()
	{
		return "Food";
	}

	// Token: 0x0600BD46 RID: 48454 RVA: 0x00417794 File Offset: 0x00415994
	public override string os()
	{
		return "FoodConsumation";
	}

	// Token: 0x0600BD47 RID: 48455 RVA: 0x0041779C File Offset: 0x0041599C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD48 RID: 48456 RVA: 0x004177A0 File Offset: 0x004159A0
	public b0p()
	{
		this.b = new List<string>();
		this.b.Add("foodConsumation");
	}

	// Token: 0x0600BD49 RID: 48457 RVA: 0x004177C4 File Offset: 0x004159C4
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD4A RID: 48458 RVA: 0x004177C8 File Offset: 0x004159C8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD4B RID: 48459 RVA: 0x004177D0 File Offset: 0x004159D0
	public override string bo(cnm A_0)
	{
		coh coh = A_0.b9() as coh;
		if (coh != null && coh.Definition != null)
		{
			string classPropertyValue = coh.Definition.a7().GetClassPropertyValue<string>("foodCode");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				return qv.b("Items\\Food/" + classPropertyValue) + " " + qv.b("Items\\Food/base");
			}
		}
		return "";
	}

	// Token: 0x0600BD4C RID: 48460 RVA: 0x00417848 File Offset: 0x00415A48
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("foodConsumation", 5000, false, false)
		};
	}

	// Token: 0x0600BD4D RID: 48461 RVA: 0x00417868 File Offset: 0x00415A68
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600BD4E RID: 48462 RVA: 0x00417870 File Offset: 0x00415A70
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && !A_0.b8().IsInCombat;
	}

	// Token: 0x0600BD4F RID: 48463 RVA: 0x00417890 File Offset: 0x00415A90
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400441A RID: 17434
	private new const string a = "foodConsumation";

	// Token: 0x0400441B RID: 17435
	private List<string> b;
}
