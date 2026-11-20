using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200182A RID: 6186
[ayj("EnergySiphon")]
public sealed class w : c0z, bix
{
	// Token: 0x060083C0 RID: 33728 RVA: 0x0036F6D8 File Offset: 0x0036D8D8
	public override string y8()
	{
		return "Вытягивание энергии";
	}

	// Token: 0x060083C1 RID: 33729 RVA: 0x0036F6E0 File Offset: 0x0036D8E0
	public override string os()
	{
		return "EnergySiphon";
	}

	// Token: 0x060083C2 RID: 33730 RVA: 0x0036F6E8 File Offset: 0x0036D8E8
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x060083C3 RID: 33731 RVA: 0x0036F6EC File Offset: 0x0036D8EC
	public override int bh()
	{
		return 1;
	}

	// Token: 0x060083C4 RID: 33732 RVA: 0x0036F6F0 File Offset: 0x0036D8F0
	public override bool hl()
	{
		return true;
	}

	// Token: 0x060083C5 RID: 33733 RVA: 0x0036F6F4 File Offset: 0x0036D8F4
	public override IList<string> bi()
	{
		return new List<string>
		{
			w.h
		};
	}

	// Token: 0x060083C6 RID: 33734 RVA: 0x0036F708 File Offset: 0x0036D908
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x060083C7 RID: 33735 RVA: 0x0036F714 File Offset: 0x0036D914
	public override bool bk()
	{
		return true;
	}

	// Token: 0x060083C8 RID: 33736 RVA: 0x0036F718 File Offset: 0x0036D918
	public override a3b bl(cnm A_0, efk A_1)
	{
		return new a3b
		{
			c = c0e.j,
			d = new int?(65)
		};
	}

	// Token: 0x060083C9 RID: 33737 RVA: 0x0036F738 File Offset: 0x0036D938
	public override string bm(cnm A_0)
	{
		return "Abilities.59";
	}

	// Token: 0x060083CA RID: 33738 RVA: 0x0036F740 File Offset: 0x0036D940
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x060083CB RID: 33739 RVA: 0x0036F744 File Offset: 0x0036D944
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/EnergySiphon", new object[]
		{
			w.b,
			w.c,
			Convert.ToInt32(w.d * 100.0),
			Convert.ToInt32(w.e * 100.0),
			w.f.a(true),
			Convert.ToInt32(w.g * 100.0),
			w.a
		});
	}

	// Token: 0x060083CC RID: 33740 RVA: 0x0036F7F0 File Offset: 0x0036D9F0
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x060083CD RID: 33741 RVA: 0x0036F7FC File Offset: 0x0036D9FC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(w.h, w.i * d0u.b, false, false)
		};
	}

	// Token: 0x060083CE RID: 33742 RVA: 0x0036F824 File Offset: 0x0036DA24
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().Battery >= (double)w.a && A_0.b8().Offense.u().TypedDefinition != null) && A_0.b8().Offense.u().TypedDefinition.e(this.TechnicalName);
	}

	// Token: 0x060083CF RID: 33743 RVA: 0x0036F8C4 File Offset: 0x0036DAC4
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x060083D0 RID: 33744 RVA: 0x0036F8CC File Offset: 0x0036DACC
	protected override int hi(cnm A_0)
	{
		return w.j;
	}

	// Token: 0x060083D1 RID: 33745 RVA: 0x0036F8D4 File Offset: 0x0036DAD4
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x060083D2 RID: 33746 RVA: 0x0036F8E0 File Offset: 0x0036DAE0
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		cmn a_ = new cmn();
		return euf.a(A_0.b8(), A_1, a_, 1.0, null);
	}

	// Token: 0x04003297 RID: 12951
	public new static readonly int a = 10;

	// Token: 0x04003298 RID: 12952
	public static readonly int b = 50;

	// Token: 0x04003299 RID: 12953
	public static readonly int c = 100;

	// Token: 0x0400329A RID: 12954
	public static readonly double d = 0.8;

	// Token: 0x0400329B RID: 12955
	public new static readonly double e = 0.6;

	// Token: 0x0400329C RID: 12956
	public static readonly a1q f = new a1q(DamageType.Electricity, 50, 100);

	// Token: 0x0400329D RID: 12957
	public new static readonly double g = 0.8;

	// Token: 0x0400329E RID: 12958
	public new static readonly string h = "EnergySiphon";

	// Token: 0x0400329F RID: 12959
	public new static readonly int i = 8;

	// Token: 0x040032A0 RID: 12960
	public new static readonly int j = 20;
}
