using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001817 RID: 6167
[ayj("GrenadeLauncherAttackGround")]
public sealed class b4s : bon, a5q
{
	// Token: 0x06008333 RID: 33587 RVA: 0x0036E03C File Offset: 0x0036C23C
	public override string y8()
	{
		return "Атака по земле (гранатомёт)";
	}

	// Token: 0x06008334 RID: 33588 RVA: 0x0036E044 File Offset: 0x0036C244
	public override string os()
	{
		return "GrenadeLauncherAttackGround";
	}

	// Token: 0x06008335 RID: 33589 RVA: 0x0036E04C File Offset: 0x0036C24C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x06008336 RID: 33590 RVA: 0x0036E050 File Offset: 0x0036C250
	public override bool cs()
	{
		return false;
	}

	// Token: 0x06008337 RID: 33591 RVA: 0x0036E054 File Offset: 0x0036C254
	public override int ct()
	{
		return 1;
	}

	// Token: 0x06008338 RID: 33592 RVA: 0x0036E058 File Offset: 0x0036C258
	public override bool j7()
	{
		return true;
	}

	// Token: 0x06008339 RID: 33593 RVA: 0x0036E05C File Offset: 0x0036C25C
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600833A RID: 33594 RVA: 0x0036E060 File Offset: 0x0036C260
	public override bool i2()
	{
		return true;
	}

	// Token: 0x0600833B RID: 33595 RVA: 0x0036E064 File Offset: 0x0036C264
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600833C RID: 33596 RVA: 0x0036E068 File Offset: 0x0036C268
	public override string c1()
	{
		return "Стрелять";
	}

	// Token: 0x0600833E RID: 33598 RVA: 0x0036E078 File Offset: 0x0036C278
	public override string bm(cnm A_0)
	{
		return "Attacks.44";
	}

	// Token: 0x0600833F RID: 33599 RVA: 0x0036E080 File Offset: 0x0036C280
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x06008340 RID: 33600 RVA: 0x0036E084 File Offset: 0x0036C284
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAttacks/AttackGround");
	}

	// Token: 0x06008341 RID: 33601 RVA: 0x0036E090 File Offset: 0x0036C290
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x06008342 RID: 33602 RVA: 0x0036E09C File Offset: 0x0036C29C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x06008343 RID: 33603 RVA: 0x0036E0A4 File Offset: 0x0036C2A4
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x06008344 RID: 33604 RVA: 0x0036E0AC File Offset: 0x0036C2AC
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x06008345 RID: 33605 RVA: 0x0036E0B4 File Offset: 0x0036C2B4
	protected override int d2(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return euf.b(A_0.b8().Offense.u().CurrentBullet);
		}
		return 0;
	}

	// Token: 0x06008346 RID: 33606 RVA: 0x0036E0F0 File Offset: 0x0036C2F0
	public double[] f2(cnm A_0, double A_1, bool A_2, cmn A_3)
	{
		if (A_0 == null || A_0.b8() == null)
		{
			return null;
		}
		du8 du = ckf.a("grenadeLauncher") as du8;
		if (du != null)
		{
			bg3 bg = du.zj(A_0.b8(), null, A_1, A_2, 1.0, A_0.b8().Offense.u().CurrentBullet, A_3);
			return new double[]
			{
				bg.a
			};
		}
		return null;
	}
}
