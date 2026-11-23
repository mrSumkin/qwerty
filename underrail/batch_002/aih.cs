using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001811 RID: 6161
[ayj("FusionCannonAttackGround")]
public sealed class aih : bon, a5q
{
	// Token: 0x060082FC RID: 33532 RVA: 0x0036D9BC File Offset: 0x0036BBBC
	public override string y8()
	{
		return "Атака по земле (термоядерная пушка)";
	}

	// Token: 0x060082FD RID: 33533 RVA: 0x0036D9C4 File Offset: 0x0036BBC4
	public override string os()
	{
		return "FusionCannonAttackGround";
	}

	// Token: 0x060082FE RID: 33534 RVA: 0x0036D9CC File Offset: 0x0036BBCC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x060082FF RID: 33535 RVA: 0x0036D9D0 File Offset: 0x0036BBD0
	public override bool cs()
	{
		return false;
	}

	// Token: 0x06008300 RID: 33536 RVA: 0x0036D9D4 File Offset: 0x0036BBD4
	public override int ct()
	{
		return 1;
	}

	// Token: 0x06008301 RID: 33537 RVA: 0x0036D9D8 File Offset: 0x0036BBD8
	public override bool j7()
	{
		return true;
	}

	// Token: 0x06008302 RID: 33538 RVA: 0x0036D9DC File Offset: 0x0036BBDC
	public override bool bk()
	{
		return true;
	}

	// Token: 0x06008303 RID: 33539 RVA: 0x0036D9E0 File Offset: 0x0036BBE0
	public override bool i2()
	{
		return true;
	}

	// Token: 0x06008304 RID: 33540 RVA: 0x0036D9E4 File Offset: 0x0036BBE4
	public override bool ds()
	{
		return true;
	}

	// Token: 0x06008305 RID: 33541 RVA: 0x0036D9E8 File Offset: 0x0036BBE8
	public override string c1()
	{
		return "Стрелять";
	}

	// Token: 0x06008307 RID: 33543 RVA: 0x0036D9F8 File Offset: 0x0036BBF8
	public override string bm(cnm A_0)
	{
		return "Attacks.44";
	}

	// Token: 0x06008308 RID: 33544 RVA: 0x0036DA00 File Offset: 0x0036BC00
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x06008309 RID: 33545 RVA: 0x0036DA04 File Offset: 0x0036BC04
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAttacks/AttackGround");
	}

	// Token: 0x0600830A RID: 33546 RVA: 0x0036DA10 File Offset: 0x0036BC10
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600830B RID: 33547 RVA: 0x0036DA1C File Offset: 0x0036BC1C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600830C RID: 33548 RVA: 0x0036DA24 File Offset: 0x0036BC24
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x0600830D RID: 33549 RVA: 0x0036DA2C File Offset: 0x0036BC2C
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600830E RID: 33550 RVA: 0x0036DA34 File Offset: 0x0036BC34
	protected override int d2(cnm A_0)
	{
		return 3;
	}

	// Token: 0x0600830F RID: 33551 RVA: 0x0036DA38 File Offset: 0x0036BC38
	public double[] f2(cnm A_0, double A_1, bool A_2, cmn A_3)
	{
		if (A_0 == null || A_0.b8() == null)
		{
			return null;
		}
		ewy ewy = ckf.a("humanFusionCannon") as ewy;
		if (ewy != null)
		{
			bg3 bg = ewy.zj(A_0.b8(), null, A_1, A_2, 1.0, A_0.b8().Offense.u().CurrentBullet, A_3);
			return new double[]
			{
				bg.a
			};
		}
		return null;
	}
}
