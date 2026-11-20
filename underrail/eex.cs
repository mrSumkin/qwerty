using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001EE6 RID: 7910
[ayj("ShootDevastatorFusionCannon")]
public sealed class eex : elr, a5q
{
	// Token: 0x0600B41A RID: 46106 RVA: 0x00407A3C File Offset: 0x00405C3C
	public override string y8()
	{
		return "Выстрел из термоядерной пушки";
	}

	// Token: 0x0600B41B RID: 46107 RVA: 0x00407A44 File Offset: 0x00405C44
	public override string os()
	{
		return "ShootDevastatorFusionCannon";
	}

	// Token: 0x0600B41C RID: 46108 RVA: 0x00407A4C File Offset: 0x00405C4C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B41D RID: 46109 RVA: 0x00407A50 File Offset: 0x00405C50
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B41E RID: 46110 RVA: 0x00407A54 File Offset: 0x00405C54
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B41F RID: 46111 RVA: 0x00407A58 File Offset: 0x00405C58
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600B420 RID: 46112 RVA: 0x00407A64 File Offset: 0x00405C64
	public override IList<string> bi()
	{
		return this.h;
	}

	// Token: 0x0600B421 RID: 46113 RVA: 0x00407A6C File Offset: 0x00405C6C
	public eex()
	{
		this.h = new List<string>();
	}

	// Token: 0x0600B422 RID: 46114 RVA: 0x00407A80 File Offset: 0x00405C80
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.0";
	}

	// Token: 0x0600B423 RID: 46115 RVA: 0x00407A88 File Offset: 0x00405C88
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600B424 RID: 46116 RVA: 0x00407A90 File Offset: 0x00405C90
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/ShootDevastatorFusionCannon", new object[]
		{
			eex.c(1.0).a(true),
			eex.b(1.0).a(true),
			eex.g,
			eex.f
		});
	}

	// Token: 0x0600B425 RID: 46117 RVA: 0x00407AFC File Offset: 0x00405CFC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B426 RID: 46118 RVA: 0x00407B08 File Offset: 0x00405D08
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Vehicle != null && A_0.b8().Vehicle.g() >= (double)eex.f);
	}

	// Token: 0x0600B427 RID: 46119 RVA: 0x00407B64 File Offset: 0x00405D64
	public static a1q c(double A_0 = 1.0)
	{
		return new a1q(DamageType.Energy, eex.a, eex.b);
	}

	// Token: 0x0600B428 RID: 46120 RVA: 0x00407B78 File Offset: 0x00405D78
	public static a1q b(double A_0 = 1.0)
	{
		return new a1q(DamageType.Electricity, eex.c, eex.d);
	}

	// Token: 0x0600B429 RID: 46121 RVA: 0x00407B8C File Offset: 0x00405D8C
	public static List<csk> a(double A_0)
	{
		return new List<csk>
		{
			euf.a(eex.c(1.0), A_0),
			euf.a(eex.b(1.0), A_0)
		};
	}

	// Token: 0x0600B42A RID: 46122 RVA: 0x00407BCC File Offset: 0x00405DCC
	public double[] f2(cnm A_0, double A_1, bool A_2, cmn A_3)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			int a_ = euf.a(A_0.b8(), true);
			return euf.a(A_0.b8(), a_, A_1, 0.0);
		}
		return null;
	}

	// Token: 0x0600B42B RID: 46123 RVA: 0x00407C10 File Offset: 0x00405E10
	public static cd1 a()
	{
		bke bke = new bke();
		bke.a(btz.i);
		bke.a(new WeaponSubtype?(WeaponSubtype.FusionCannon));
		bke.g("Fusion Cannon");
		bke.a(AmmoType.Energy);
		bke.c(true);
		bke.g(true);
		bke.c((float)eex.e);
		bke.d((float)(eex.e - 3));
		bke.l().Add(eex.c(1.0));
		bke.l().Add(eex.b(1.0));
		bke.a(esu.l);
		bke.a(ImpactSpeed.VeryHigh);
		bke.g(0.08);
		bke.b(true);
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600B42C RID: 46124 RVA: 0x00407CD8 File Offset: 0x00405ED8
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B42D RID: 46125 RVA: 0x00407CDC File Offset: 0x00405EDC
	protected override float f0(cnm A_0)
	{
		return (float)eex.e;
	}

	// Token: 0x0600B42E RID: 46126 RVA: 0x00407CE4 File Offset: 0x00405EE4
	protected override int d2(cnm A_0)
	{
		return eex.g;
	}

	// Token: 0x0600B42F RID: 46127 RVA: 0x00407CEC File Offset: 0x00405EEC
	protected override int hi(cnm A_0)
	{
		return 50;
	}

	// Token: 0x040041BA RID: 16826
	private new static readonly int a = 150;

	// Token: 0x040041BB RID: 16827
	private static readonly int b = 275;

	// Token: 0x040041BC RID: 16828
	private static readonly int c = 150;

	// Token: 0x040041BD RID: 16829
	private static readonly int d = 275;

	// Token: 0x040041BE RID: 16830
	public new static readonly int e = 10;

	// Token: 0x040041BF RID: 16831
	public static readonly int f = 100;

	// Token: 0x040041C0 RID: 16832
	public new static readonly int g = 2;

	// Token: 0x040041C1 RID: 16833
	private new List<string> h;
}
