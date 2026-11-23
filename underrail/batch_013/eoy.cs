using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001834 RID: 6196
[ayj("ExoskeletonDrillAttack")]
public sealed class eoy : c0z
{
	// Token: 0x0600840E RID: 33806 RVA: 0x00370C40 File Offset: 0x0036EE40
	public override string y8()
	{
		return "Mounted Drill Attack";
	}

	// Token: 0x0600840F RID: 33807 RVA: 0x00370C48 File Offset: 0x0036EE48
	public override string os()
	{
		return "ExoskeletonDrillAttack";
	}

	// Token: 0x06008410 RID: 33808 RVA: 0x00370C50 File Offset: 0x0036EE50
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x06008411 RID: 33809 RVA: 0x00370C54 File Offset: 0x0036EE54
	public override int bh()
	{
		return 3392;
	}

	// Token: 0x06008412 RID: 33810 RVA: 0x00370C5C File Offset: 0x0036EE5C
	public override bool hl()
	{
		return false;
	}

	// Token: 0x06008413 RID: 33811 RVA: 0x00370C60 File Offset: 0x0036EE60
	public override a3b bl(cnm A_0, efk A_1)
	{
		return new a3b
		{
			c = c0e.p,
			d = new int?(65),
			a = c0e.p,
			b = new int?(int.MaxValue)
		};
	}

	// Token: 0x06008414 RID: 33812 RVA: 0x00370C9C File Offset: 0x0036EE9C
	public override string bm(cnm A_0)
	{
		return "Abilities.78";
	}

	// Token: 0x06008415 RID: 33813 RVA: 0x00370CA4 File Offset: 0x0036EEA4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x06008416 RID: 33814 RVA: 0x00370CAC File Offset: 0x0036EEAC
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/ExoskeletonDrillAttack", new object[]
		{
			eoy.b,
			eoy.a().a(true),
			eoy.a
		});
	}

	// Token: 0x06008417 RID: 33815 RVA: 0x00370CF4 File Offset: 0x0036EEF4
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x06008418 RID: 33816 RVA: 0x00370D00 File Offset: 0x0036EF00
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x06008419 RID: 33817 RVA: 0x00370D34 File Offset: 0x0036EF34
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(jg.a) && A_0.b8().Gear.l().Item != null && Enumerable.Any<aia>(A_0.b8().Gear.l().Item.fu().@as(), new Func<aia, bool>(this.b))) && A_0.b8().Gear.l().Item.Battery >= (double)eoy.a;
	}

	// Token: 0x0600841A RID: 33818 RVA: 0x00370DF0 File Offset: 0x0036EFF0
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null) && Enumerable.Any<aia>(A_0.b8().Gear.l().Item.fu().@as(), new Func<aia, bool>(this.a));
	}

	// Token: 0x0600841B RID: 33819 RVA: 0x00370E68 File Offset: 0x0036F068
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600841C RID: 33820 RVA: 0x00370E70 File Offset: 0x0036F070
	protected override int hi(cnm A_0)
	{
		return 35;
	}

	// Token: 0x0600841D RID: 33821 RVA: 0x00370E74 File Offset: 0x0036F074
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600841E RID: 33822 RVA: 0x00370E7C File Offset: 0x0036F07C
	public static a1q a()
	{
		return new a1q(DamageType.Mechanical, 25, 40);
	}

	// Token: 0x0600841F RID: 33823 RVA: 0x00370E8C File Offset: 0x0036F08C
	public new static bke a(cnm A_0)
	{
		bke bke = new bke();
		bke.g("Mounted Drill");
		bke.k("sp:ExoskeletonDrill");
		bke.a(35);
		bke.f(0.05);
		bke.c(as3.bk);
		bke.d(as3.bk);
		bke.b((float)bke.v() * d0u.c);
		bke.a(btz.g);
		bke.a(ImpactSpeed.VeryLow);
		bke.a(esu.b);
		bke.a(bhx.av);
		bke.a(AmmoType.Sledgehammer);
		bke.g(true);
		bke.aa().Add(new edm("destroyDestructableRocks", 1.0, 1, false));
		bke.b(true);
		a1q item = eoy.a();
		for (int i = 0; i < eoy.b; i++)
		{
			bke.l().Add(item);
		}
		return bke;
	}

	// Token: 0x06008422 RID: 33826 RVA: 0x00370F8C File Offset: 0x0036F18C
	[CompilerGenerated]
	private bool b(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x06008423 RID: 33827 RVA: 0x00370F98 File Offset: 0x0036F198
	[CompilerGenerated]
	private bool a(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x040032A8 RID: 12968
	public new static readonly int a = 20;

	// Token: 0x040032A9 RID: 12969
	public static readonly int b = 5;
}
