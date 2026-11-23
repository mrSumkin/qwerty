using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F42 RID: 8002
[ayj("TechnomedicExoskeletonRegenerativeInjection")]
public sealed class a0k : c0z
{
	// Token: 0x0600BA60 RID: 47712 RVA: 0x00412C74 File Offset: 0x00410E74
	public override string y8()
	{
		return "Парафиброзная регенеративная инъекция";
	}

	// Token: 0x0600BA61 RID: 47713 RVA: 0x00412C7C File Offset: 0x00410E7C
	public override string os()
	{
		return "TechnomedicExoskeletonRegenerativeInjection";
	}

	// Token: 0x0600BA62 RID: 47714 RVA: 0x00412C84 File Offset: 0x00410E84
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BA63 RID: 47715 RVA: 0x00412C88 File Offset: 0x00410E88
	public override int e8()
	{
		return 11;
	}

	// Token: 0x0600BA64 RID: 47716 RVA: 0x00412C8C File Offset: 0x00410E8C
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600BA65 RID: 47717 RVA: 0x00412C90 File Offset: 0x00410E90
	public override IList<string> bi()
	{
		return this.h;
	}

	// Token: 0x0600BA66 RID: 47718 RVA: 0x00412C98 File Offset: 0x00410E98
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeSpell);
	}

	// Token: 0x0600BA67 RID: 47719 RVA: 0x00412CA0 File Offset: 0x00410EA0
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600BA68 RID: 47720 RVA: 0x00412CA4 File Offset: 0x00410EA4
	public a0k()
	{
		this.h = new List<string>();
		this.h.Add("SAt.TechnomedicExoskeletonRegenerativeInjection");
	}

	// Token: 0x0600BA69 RID: 47721 RVA: 0x00412CC8 File Offset: 0x00410EC8
	public override a3b bl(cnm A_0, efk A_1)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8() == A_1)
		{
			return new a3b
			{
				c = c0e.t,
				a = c0e.d
			};
		}
		return new a3b
		{
			c = c0e.u,
			a = c0e.d
		};
	}

	// Token: 0x0600BA6A RID: 47722 RVA: 0x00412D2C File Offset: 0x00410F2C
	public override string bm(cnm A_0)
	{
		return "Abilities.111";
	}

	// Token: 0x0600BA6B RID: 47723 RVA: 0x00412D34 File Offset: 0x00410F34
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.LivingCreature;
	}

	// Token: 0x0600BA6C RID: 47724 RVA: 0x00412D38 File Offset: 0x00410F38
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600BA6D RID: 47725 RVA: 0x00412D44 File Offset: 0x00410F44
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/TechnomedicExoskeletonRegenerativeInjection", new object[]
		{
			a0k.a(A_0),
			a0k.g.ToString("P0"),
			l4.a(a0k.e, false),
			a0k.d
		});
	}

	// Token: 0x0600BA6E RID: 47726 RVA: 0x00412DA0 File Offset: 0x00410FA0
	public new static int a(cnm A_0)
	{
		int num = a0k.f;
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

	// Token: 0x0600BA6F RID: 47727 RVA: 0x00412E28 File Offset: 0x00411028
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SAt.TechnomedicExoskeletonRegenerativeInjection", a0k.b, false, false)
		};
	}

	// Token: 0x0600BA70 RID: 47728 RVA: 0x00412E4C File Offset: 0x0041104C
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 == null || A_0.b8() == null || A_0.b8().Gear.l().Item == null)
		{
			return false;
		}
		if (A_0.b8().Gear.l().Item.Battery < (double)a0k.d)
		{
			return false;
		}
		IEnumerable<coh> enumerable = A_0.b8().Bag.b("med.parafibroticRegenerationCatalyst");
		return enumerable != null && Enumerable.FirstOrDefault<coh>(enumerable) != null;
	}

	// Token: 0x0600BA71 RID: 47729 RVA: 0x00412EE4 File Offset: 0x004110E4
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600BA72 RID: 47730 RVA: 0x00412EE8 File Offset: 0x004110E8
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600BA73 RID: 47731 RVA: 0x00412EF0 File Offset: 0x004110F0
	protected override int hi(cnm A_0)
	{
		return a0k.c;
	}

	// Token: 0x0600BA74 RID: 47732 RVA: 0x00412EF8 File Offset: 0x004110F8
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x040043A9 RID: 17321
	private new const string a = "SAt.TechnomedicExoskeletonRegenerativeInjection";

	// Token: 0x040043AA RID: 17322
	public static readonly int b = d0u.b * 10;

	// Token: 0x040043AB RID: 17323
	public static readonly int c = 10;

	// Token: 0x040043AC RID: 17324
	public static readonly int d = 50;

	// Token: 0x040043AD RID: 17325
	public new static readonly int e = 8;

	// Token: 0x040043AE RID: 17326
	public static readonly int f = 25;

	// Token: 0x040043AF RID: 17327
	public new static readonly double g = 0.15;

	// Token: 0x040043B0 RID: 17328
	private new List<string> h;
}
