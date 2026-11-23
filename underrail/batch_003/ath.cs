using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001826 RID: 6182
[ayj("HeadTrapAttack")]
public sealed class ath : m0, bix
{
	// Token: 0x060083A2 RID: 33698 RVA: 0x0036EFDC File Offset: 0x0036D1DC
	public override string y8()
	{
		return "Ошейник страданий";
	}

	// Token: 0x060083A3 RID: 33699 RVA: 0x0036EFE4 File Offset: 0x0036D1E4
	public override string os()
	{
		return "HeadTrapAttack";
	}

	// Token: 0x060083A4 RID: 33700 RVA: 0x0036EFEC File Offset: 0x0036D1EC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x060083A5 RID: 33701 RVA: 0x0036EFF0 File Offset: 0x0036D1F0
	public override int bh()
	{
		return 1;
	}

	// Token: 0x060083A6 RID: 33702 RVA: 0x0036EFF4 File Offset: 0x0036D1F4
	public override bool hl()
	{
		return true;
	}

	// Token: 0x060083A7 RID: 33703 RVA: 0x0036EFF8 File Offset: 0x0036D1F8
	public override IList<string> bi()
	{
		return new List<string>
		{
			ath.a
		};
	}

	// Token: 0x060083A8 RID: 33704 RVA: 0x0036F00C File Offset: 0x0036D20C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x060083A9 RID: 33705 RVA: 0x0036F018 File Offset: 0x0036D218
	public override a3b bl(cnm A_0, efk A_1)
	{
		return new a3b
		{
			c = c0e.j,
			d = new int?(65)
		};
	}

	// Token: 0x060083AA RID: 33706 RVA: 0x0036F038 File Offset: 0x0036D238
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x060083AB RID: 33707 RVA: 0x0036F040 File Offset: 0x0036D240
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.HumanoidNoVehicleNotSelf;
	}

	// Token: 0x060083AC RID: 33708 RVA: 0x0036F044 File Offset: 0x0036D244
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Utilities/HeadTrapAttack", new object[]
		{
			ath.c.a(true),
			l4.a(ath.d, false),
			ath.f,
			l4.a(ath.e, false)
		});
	}

	// Token: 0x060083AD RID: 33709 RVA: 0x0036F09C File Offset: 0x0036D29C
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x060083AE RID: 33710 RVA: 0x0036F0A8 File Offset: 0x0036D2A8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(ath.a, ath.b * d0u.b, false, false)
		};
	}

	// Token: 0x060083AF RID: 33711 RVA: 0x0036F0CC File Offset: 0x0036D2CC
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x060083B0 RID: 33712 RVA: 0x0036F0D4 File Offset: 0x0036D2D4
	protected override int hi(cnm A_0)
	{
		return ath.g;
	}

	// Token: 0x060083B1 RID: 33713 RVA: 0x0036F0DC File Offset: 0x0036D2DC
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x060083B2 RID: 33714 RVA: 0x0036F0E8 File Offset: 0x0036D2E8
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		cmn a_ = new cmn();
		return euf.a(A_0.b8(), A_1, a_, 1.0, null);
	}

	// Token: 0x060083B3 RID: 33715 RVA: 0x0036F114 File Offset: 0x0036D314
	public static cd1 a()
	{
		bke bke = new bke();
		bke.a(btz.g);
		bke.g("Ошейник страданий");
		bke.a(AmmoType.None);
		bke.c(true);
		bke.g(true);
		bke.c(0f);
		bke.d(0f);
		bke.a(esu.d);
		bke.a(ImpactSpeed.VeryLow);
		bke.g(-0.05);
		bke.a(bhx.a);
		bke.a(esu.a);
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0400328F RID: 12943
	public new static readonly string a = "HeadTrapAttack";

	// Token: 0x04003290 RID: 12944
	public static readonly int b = 5;

	// Token: 0x04003291 RID: 12945
	public static readonly a1q c = new a1q(DamageType.Mechanical, 100, 200);

	// Token: 0x04003292 RID: 12946
	public static readonly int d = 5;

	// Token: 0x04003293 RID: 12947
	public new static readonly int e = 3;

	// Token: 0x04003294 RID: 12948
	public static readonly int f = 5;

	// Token: 0x04003295 RID: 12949
	public new static readonly int g = 25;
}
