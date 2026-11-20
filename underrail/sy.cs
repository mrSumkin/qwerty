using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001F45 RID: 8005
[ayj("SoldierExoskeletonWristbladeStab")]
public sealed class sy : c0z, bix
{
	// Token: 0x0600BA9E RID: 47774 RVA: 0x00413394 File Offset: 0x00411594
	public override string y8()
	{
		return "Встроенный наручный клинок";
	}

	// Token: 0x0600BA9F RID: 47775 RVA: 0x0041339C File Offset: 0x0041159C
	public override string os()
	{
		return "SoldierExoskeletonWristbladeStab";
	}

	// Token: 0x0600BAA0 RID: 47776 RVA: 0x004133A4 File Offset: 0x004115A4
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600BAA1 RID: 47777 RVA: 0x004133A8 File Offset: 0x004115A8
	public override int e8()
	{
		return 10;
	}

	// Token: 0x0600BAA2 RID: 47778 RVA: 0x004133AC File Offset: 0x004115AC
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600BAA3 RID: 47779 RVA: 0x004133B0 File Offset: 0x004115B0
	public override IList<string> bi()
	{
		return this.h;
	}

	// Token: 0x0600BAA4 RID: 47780 RVA: 0x004133B8 File Offset: 0x004115B8
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600BAA5 RID: 47781 RVA: 0x004133C4 File Offset: 0x004115C4
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600BAA6 RID: 47782 RVA: 0x004133C8 File Offset: 0x004115C8
	public sy()
	{
		this.h = new List<string>();
		this.h.Add(d7f.a);
		this.h.Add("SAt.SoldierExoskeletonWristbladeStab");
	}

	// Token: 0x0600BAA7 RID: 47783 RVA: 0x004133FC File Offset: 0x004115FC
	public override a3b bl(cnm A_0, efk A_1)
	{
		return new a3b
		{
			c = c0e.s,
			d = new int?(65),
			a = c0e.s,
			b = new int?(int.MaxValue)
		};
	}

	// Token: 0x0600BAA8 RID: 47784 RVA: 0x00413438 File Offset: 0x00411638
	public override string bm(cnm A_0)
	{
		return "Attacks.28";
	}

	// Token: 0x0600BAA9 RID: 47785 RVA: 0x00413440 File Offset: 0x00411640
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600BAAA RID: 47786 RVA: 0x00413444 File Offset: 0x00411644
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600BAAB RID: 47787 RVA: 0x00413450 File Offset: 0x00411650
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/SoldierExoskeletonWristbladeStab", new object[]
		{
			sy.a(A_0).a(true),
			sy.d.ToString("P0"),
			sy.e.ToString("P0"),
			sy.f,
			sy.g
		});
	}

	// Token: 0x0600BAAC RID: 47788 RVA: 0x004134C4 File Offset: 0x004116C4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.SoldierExoskeletonWristbladeStab", sy.b, false, false));
		return list;
	}

	// Token: 0x0600BAAD RID: 47789 RVA: 0x00413510 File Offset: 0x00411710
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null) && A_0.b8().Gear.l().Item.Battery >= (double)sy.g;
	}

	// Token: 0x0600BAAE RID: 47790 RVA: 0x00413580 File Offset: 0x00411780
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600BAAF RID: 47791 RVA: 0x00413584 File Offset: 0x00411784
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600BAB0 RID: 47792 RVA: 0x0041358C File Offset: 0x0041178C
	protected override int hi(cnm A_0)
	{
		return sy.c;
	}

	// Token: 0x0600BAB1 RID: 47793 RVA: 0x00413594 File Offset: 0x00411794
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600BAB2 RID: 47794 RVA: 0x004135A0 File Offset: 0x004117A0
	public static bke b(cnm A_0)
	{
		bke bke = new bke();
		bke.g("Wristblade");
		bke.a(sy.c);
		bke.f(0.1);
		bke.c(1.5);
		bke.c(as3.bk);
		bke.d(as3.bk);
		bke.b(1f);
		bke.a(btz.g);
		bke.a(ImpactSpeed.VeryLow);
		bke.a(esu.b);
		bke.a(bhx.b);
		bke.a(AmmoType.Knife);
		bke.g(true);
		bke.l().Add(new a1q(DamageType.Mechanical, 20, 40));
		return bke;
	}

	// Token: 0x0600BAB3 RID: 47795 RVA: 0x0041364C File Offset: 0x0041184C
	public new static a1q a(cnm A_0)
	{
		bke bke = sy.b(A_0);
		double a_ = euf.a(A_0.b8(), btz.g, false);
		a1q a1q = Enumerable.FirstOrDefault<a1q>(Enumerable.Where<a1q>(bke.l(), new Func<a1q, bool>(sy.a.a.a)));
		double num = qw.a(bke, a_);
		WeaponSubtype? a_2 = euf.d(bke);
		double num2 = qw.a(A_0.b8(), bke, a_2);
		return new a1q(DamageType.Mechanical, (int)((double)a1q.LowerBoundary * (1.0 + num2 + num)), (int)((double)a1q.UpperBoundary * (1.0 + num2 + num)));
	}

	// Token: 0x0600BAB4 RID: 47796 RVA: 0x004136F8 File Offset: 0x004118F8
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		cmn a_ = new cmn();
		cd1 a_2 = new cd1(new IndependentItemDefinitionProvider<bke>(sy.b(A_0)));
		return euf.a(A_0.b8(), A_1, a_, 1.0, a_2);
	}

	// Token: 0x040043C2 RID: 17346
	private new const string a = "SAt.SoldierExoskeletonWristbladeStab";

	// Token: 0x040043C3 RID: 17347
	public static readonly int b = d0u.b * 5;

	// Token: 0x040043C4 RID: 17348
	public static readonly int c = 10;

	// Token: 0x040043C5 RID: 17349
	public static readonly float d = 0.3f;

	// Token: 0x040043C6 RID: 17350
	public new static readonly float e = 2f;

	// Token: 0x040043C7 RID: 17351
	public static readonly int f = 3;

	// Token: 0x040043C8 RID: 17352
	public new static readonly int g = 10;

	// Token: 0x040043C9 RID: 17353
	private new List<string> h;

	// Token: 0x02001F46 RID: 8006
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600BAB8 RID: 47800 RVA: 0x00413780 File Offset: 0x00411980
		internal bool a(a1q A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x040043CA RID: 17354
		public static readonly sy.a a = new sy.a();

		// Token: 0x040043CB RID: 17355
		public static Func<a1q, bool> b;
	}
}
