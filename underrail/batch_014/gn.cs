using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001802 RID: 6146
[ayj("CatLaser")]
public sealed class gn : c0z, bix
{
	// Token: 0x06008293 RID: 33427 RVA: 0x0036CA64 File Offset: 0x0036AC64
	public override string y8()
	{
		return "Лазерная кошка";
	}

	// Token: 0x06008294 RID: 33428 RVA: 0x0036CA6C File Offset: 0x0036AC6C
	public override string os()
	{
		return "CatLaser";
	}

	// Token: 0x06008295 RID: 33429 RVA: 0x0036CA74 File Offset: 0x0036AC74
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x06008296 RID: 33430 RVA: 0x0036CA78 File Offset: 0x0036AC78
	public override int bh()
	{
		return 1;
	}

	// Token: 0x06008297 RID: 33431 RVA: 0x0036CA7C File Offset: 0x0036AC7C
	public override bool hl()
	{
		return true;
	}

	// Token: 0x06008298 RID: 33432 RVA: 0x0036CA80 File Offset: 0x0036AC80
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x06008299 RID: 33433 RVA: 0x0036CA88 File Offset: 0x0036AC88
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600829A RID: 33434 RVA: 0x0036CA94 File Offset: 0x0036AC94
	public override bool bk()
	{
		return false;
	}

	// Token: 0x0600829B RID: 33435 RVA: 0x0036CA98 File Offset: 0x0036AC98
	public override a3b bl(cnm A_0, efk A_1)
	{
		return new a3b
		{
			c = c0e.j,
			d = new int?(65)
		};
	}

	// Token: 0x0600829C RID: 33436 RVA: 0x0036CAB8 File Offset: 0x0036ACB8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600829D RID: 33437 RVA: 0x0036CABC File Offset: 0x0036ACBC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600829E RID: 33438 RVA: 0x0036CAC0 File Offset: 0x0036ACC0
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/CatLaser", new object[]
		{
			gn.b.a(true),
			gn.a
		});
	}

	// Token: 0x0600829F RID: 33439 RVA: 0x0036CAFC File Offset: 0x0036ACFC
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x060082A0 RID: 33440 RVA: 0x0036CB08 File Offset: 0x0036AD08
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return this.e;
	}

	// Token: 0x060082A1 RID: 33441 RVA: 0x0036CB10 File Offset: 0x0036AD10
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		coh coh = (A_0 != null) ? (A_0.b9() as coh) : null;
		return coh != null && coh.Battery > (double)gn.a;
	}

	// Token: 0x060082A2 RID: 33442 RVA: 0x0036CB5C File Offset: 0x0036AD5C
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x060082A3 RID: 33443 RVA: 0x0036CB64 File Offset: 0x0036AD64
	protected override int hi(cnm A_0)
	{
		return gn.c;
	}

	// Token: 0x060082A4 RID: 33444 RVA: 0x0036CB6C File Offset: 0x0036AD6C
	protected override float f0(cnm A_0)
	{
		return 12f;
	}

	// Token: 0x060082A5 RID: 33445 RVA: 0x0036CB78 File Offset: 0x0036AD78
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		cmn a_ = new cmn();
		return euf.a(A_0.b8(), A_1, A_2, A_3, A_4, AmmoType.None, A_5, 1.0, a_, gn.a(), null);
	}

	// Token: 0x060082A6 RID: 33446 RVA: 0x0036CBB8 File Offset: 0x0036ADB8
	public static cd1 a()
	{
		bke bke = new bke();
		bke.a(btz.a);
		bke.g("Cat Laser");
		bke.a(AmmoType.Energy);
		bke.d(0.0);
		bke.c(true);
		bke.g(true);
		bke.c(12f);
		bke.d(10f);
		bke.l().Add(gn.b);
		bke.a(esu.g);
		bke.a(ImpactSpeed.VeryHigh);
		bke.g(-0.1);
		bke.b(true);
		bke.a(bhx.q);
		bke.a(esu.g);
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x04003262 RID: 12898
	public new static readonly int a = 10;

	// Token: 0x04003263 RID: 12899
	public static readonly a1q b = new a1q(DamageType.Energy, 15, 30);

	// Token: 0x04003264 RID: 12900
	public static readonly int c = 15;

	// Token: 0x04003265 RID: 12901
	private List<string> d = new List<string>();

	// Token: 0x04003266 RID: 12902
	private new List<cfd> e = new List<cfd>();
}
