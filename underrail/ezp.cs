using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F8E RID: 8078
[ayj("HealingSalveConsumption")]
public sealed class ezp : awn
{
	// Token: 0x0600BDA2 RID: 48546 RVA: 0x00417E80 File Offset: 0x00416080
	public override string y8()
	{
		return "Лечебная мазь";
	}

	// Token: 0x0600BDA3 RID: 48547 RVA: 0x00417E88 File Offset: 0x00416088
	public override string os()
	{
		return "HealingSalveConsumption";
	}

	// Token: 0x0600BDA4 RID: 48548 RVA: 0x00417E90 File Offset: 0x00416090
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BDA5 RID: 48549 RVA: 0x00417E94 File Offset: 0x00416094
	public ezp()
	{
		this.d = new List<string>();
		this.d.Add(d7f.h);
	}

	// Token: 0x0600BDA6 RID: 48550 RVA: 0x00417EB8 File Offset: 0x004160B8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BDA7 RID: 48551 RVA: 0x00417EBC File Offset: 0x004160BC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BDA8 RID: 48552 RVA: 0x00417EC4 File Offset: 0x004160C4
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/HealingSalve", new object[]
		{
			ezp.b(A_0),
			ezp.a(A_0),
			l4.a(ezp.c, false),
			d2o.a,
			l4.a(d2o.b, false)
		});
	}

	// Token: 0x0600BDA9 RID: 48553 RVA: 0x00417F28 File Offset: 0x00416128
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_0 != null && A_0.b8() is e3q)
		{
			int healingCooldown = euf.b().HealingCooldown;
			if (healingCooldown > 0)
			{
				list.Add(new cfd(d7f.h, d0u.b * healingCooldown, false, false));
			}
		}
		else
		{
			list.Add(d7f.j);
		}
		return list;
	}

	// Token: 0x0600BDAA RID: 48554 RVA: 0x00417F90 File Offset: 0x00416190
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600BDAB RID: 48555 RVA: 0x00417F98 File Offset: 0x00416198
	public static int b(cnm A_0)
	{
		return c2h.a((A_0 != null) ? A_0.b8() : null, ezp.a);
	}

	// Token: 0x0600BDAC RID: 48556 RVA: 0x00417FB8 File Offset: 0x004161B8
	public new static int a(cnm A_0)
	{
		return c2h.a((A_0 != null) ? A_0.b8() : null, ezp.b);
	}

	// Token: 0x0400442F RID: 17455
	public new static readonly int a = 100;

	// Token: 0x04004430 RID: 17456
	public static readonly int b = 25;

	// Token: 0x04004431 RID: 17457
	public static readonly int c = 2;

	// Token: 0x04004432 RID: 17458
	private List<string> d;
}
