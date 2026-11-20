using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F95 RID: 8085
[ayj("RegenerativeMixture")]
public sealed class a2s : awn
{
	// Token: 0x0600BDE2 RID: 48610 RVA: 0x00418338 File Offset: 0x00416538
	public override string y8()
	{
		return "Регенеративная смесь";
	}

	// Token: 0x0600BDE3 RID: 48611 RVA: 0x00418340 File Offset: 0x00416540
	public override string os()
	{
		return "RegenerativeMixture";
	}

	// Token: 0x0600BDE4 RID: 48612 RVA: 0x00418348 File Offset: 0x00416548
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BDE6 RID: 48614 RVA: 0x00418354 File Offset: 0x00416554
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BDE7 RID: 48615 RVA: 0x00418358 File Offset: 0x00416558
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BDE8 RID: 48616 RVA: 0x0041835C File Offset: 0x0041655C
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/RegenerativeMixture", new object[]
		{
			a2s.a(A_0),
			l4.a(a2s.a, false)
		});
	}

	// Token: 0x0600BDE9 RID: 48617 RVA: 0x00418390 File Offset: 0x00416590
	public new static int a(cnm A_0)
	{
		int num = a2s.b;
		if (A_0 != null && A_0.b8() is e3q)
		{
			num = (int)((float)num * euf.b().HealingModifier);
		}
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<yn>())
		{
			num = (int)((double)num * (1.0 + yn.a + (double)A_0.b8().GetSpecializationValue<aog>(true) * aog.a));
		}
		return num;
	}

	// Token: 0x04004444 RID: 17476
	public new static readonly int a = 6;

	// Token: 0x04004445 RID: 17477
	public static readonly int b = 40;
}
