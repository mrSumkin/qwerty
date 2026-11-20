using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F94 RID: 8084
[ayj("SupersoldierDrugConsumation")]
public sealed class en4 : awn
{
	// Token: 0x0600BDD8 RID: 48600 RVA: 0x00418268 File Offset: 0x00416468
	public override string y8()
	{
		return "Сыворотка сверхсолдата";
	}

	// Token: 0x0600BDD9 RID: 48601 RVA: 0x00418270 File Offset: 0x00416470
	public override string os()
	{
		return "SupersoldierDrugConsumation";
	}

	// Token: 0x0600BDDA RID: 48602 RVA: 0x00418278 File Offset: 0x00416478
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BDDB RID: 48603 RVA: 0x0041827C File Offset: 0x0041647C
	public en4()
	{
		this.d = new List<string>();
		this.d.Add(en4.c);
	}

	// Token: 0x0600BDDC RID: 48604 RVA: 0x004182A0 File Offset: 0x004164A0
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600BDDD RID: 48605 RVA: 0x004182A8 File Offset: 0x004164A8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BDDE RID: 48606 RVA: 0x004182AC File Offset: 0x004164AC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BDDF RID: 48607 RVA: 0x004182B0 File Offset: 0x004164B0
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/SupersoldierDrug", new object[]
		{
			kd.a,
			(int)(kd.b * 100f),
			l4.a(en4.a, false)
		});
	}

	// Token: 0x0600BDE0 RID: 48608 RVA: 0x004182FC File Offset: 0x004164FC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(en4.c, en4.b * d0u.b, false, false)
		};
	}

	// Token: 0x04004440 RID: 17472
	public new static readonly int a = 4;

	// Token: 0x04004441 RID: 17473
	public static readonly int b = 8;

	// Token: 0x04004442 RID: 17474
	public static readonly string c = "SupersoldierDrug";

	// Token: 0x04004443 RID: 17475
	private List<string> d;
}
