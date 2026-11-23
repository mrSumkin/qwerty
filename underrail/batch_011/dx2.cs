using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F30 RID: 7984
[ayj("Frighten")]
public sealed class dx2 : ce5
{
	// Token: 0x0600B911 RID: 47377 RVA: 0x00410FF8 File Offset: 0x0040F1F8
	public override string y8()
	{
		return "Напугать";
	}

	// Token: 0x0600B912 RID: 47378 RVA: 0x00411000 File Offset: 0x0040F200
	public override string os()
	{
		return "Frighten";
	}

	// Token: 0x0600B913 RID: 47379 RVA: 0x00411008 File Offset: 0x0040F208
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B914 RID: 47380 RVA: 0x0041100C File Offset: 0x0040F20C
	public override PsiSchool ch()
	{
		return PsiSchool.ThoughtControl;
	}

	// Token: 0x0600B915 RID: 47381 RVA: 0x00411010 File Offset: 0x0040F210
	public override int ci()
	{
		return 2;
	}

	// Token: 0x0600B916 RID: 47382 RVA: 0x00411014 File Offset: 0x0040F214
	public dx2()
	{
		this.e = new List<string>
		{
			d7f.b,
			dx2.a
		};
	}

	// Token: 0x0600B917 RID: 47383 RVA: 0x00411048 File Offset: 0x0040F248
	public override SpellTargetType bn(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return SpellTargetType.DiscoveredPenetrableSpot;
		}
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B918 RID: 47384 RVA: 0x0041107C File Offset: 0x0040F27C
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600B919 RID: 47385 RVA: 0x00411088 File Offset: 0x0040F288
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(dx2.a, 40000, false, false));
		return list;
	}

	// Token: 0x0600B91A RID: 47386 RVA: 0x004110D4 File Offset: 0x0040F2D4
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/Frighten", new object[]
		{
			l4.a((double)dx2.c)
		});
	}

	// Token: 0x0600B91B RID: 47387 RVA: 0x004110FC File Offset: 0x0040F2FC
	protected override int hi(cnm A_0)
	{
		return 15;
	}

	// Token: 0x0600B91C RID: 47388 RVA: 0x00411100 File Offset: 0x0040F300
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B91D RID: 47389 RVA: 0x00411108 File Offset: 0x0040F308
	protected override float f0(cnm A_0)
	{
		return 5f;
	}

	// Token: 0x0600B91E RID: 47390 RVA: 0x00411110 File Offset: 0x0040F310
	protected override float cj(cnm A_0)
	{
		return 40f;
	}

	// Token: 0x0600B91F RID: 47391 RVA: 0x00411118 File Offset: 0x0040F318
	protected override int d2(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return bgo.b;
		}
		return 0;
	}

	// Token: 0x0600B920 RID: 47392 RVA: 0x00411150 File Offset: 0x0040F350
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(30, new Type[]
			{
				typeof(dql)
			})
		};
	}

	// Token: 0x0600B921 RID: 47393 RVA: 0x004111A4 File Offset: 0x0040F3A4
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x0400435D RID: 17245
	public new static readonly string a = "Psi.Frighten";

	// Token: 0x0400435E RID: 17246
	private const int b = 40000;

	// Token: 0x0400435F RID: 17247
	public static readonly int c = d0u.b * 4;

	// Token: 0x04004360 RID: 17248
	public static readonly int d = d0u.b;

	// Token: 0x04004361 RID: 17249
	private new List<string> e;
}
