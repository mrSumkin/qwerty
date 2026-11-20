using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F8B RID: 8075
[ayj("StatBoosterConsumation")]
public sealed class d7d : awn
{
	// Token: 0x0600BD7C RID: 48508 RVA: 0x00417B44 File Offset: 0x00415D44
	public override string y8()
	{
		return "Усилитель параметра";
	}

	// Token: 0x0600BD7D RID: 48509 RVA: 0x00417B4C File Offset: 0x00415D4C
	public override string os()
	{
		return "StatBoosterConsumation";
	}

	// Token: 0x0600BD7E RID: 48510 RVA: 0x00417B54 File Offset: 0x00415D54
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD7F RID: 48511 RVA: 0x00417B58 File Offset: 0x00415D58
	public d7d()
	{
		this.b = new List<string>();
		this.b.Add(d7d.a);
	}

	// Token: 0x0600BD80 RID: 48512 RVA: 0x00417B7C File Offset: 0x00415D7C
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600BD81 RID: 48513 RVA: 0x00417B84 File Offset: 0x00415D84
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD82 RID: 48514 RVA: 0x00417B88 File Offset: 0x00415D88
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD83 RID: 48515 RVA: 0x00417B90 File Offset: 0x00415D90
	public override string bo(cnm A_0)
	{
		coh coh = A_0.b9() as coh;
		if (coh == null)
		{
			return null;
		}
		string classPropertyValue = coh.Definition.a7().GetClassPropertyValue<string>("StatToBoost");
		if (string.IsNullOrEmpty(classPropertyValue))
		{
			return null;
		}
		return qv.a("Items\\Consumables/StatBooster", new object[]
		{
			classPropertyValue
		});
	}

	// Token: 0x0600BD84 RID: 48516 RVA: 0x00417BE8 File Offset: 0x00415DE8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7d.a, 60000, false, false)
		};
	}

	// Token: 0x04004427 RID: 17447
	public new static readonly string a = "StatBooster";

	// Token: 0x04004428 RID: 17448
	private List<string> b;
}
