using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200180C RID: 6156
[ayj("RocketLauncherAttackGround")]
public sealed class aay : bon, a5q
{
	// Token: 0x060082D1 RID: 33489 RVA: 0x0036D5E0 File Offset: 0x0036B7E0
	public override string y8()
	{
		return "Атака по земле (ракетный комплекс)";
	}

	// Token: 0x060082D2 RID: 33490 RVA: 0x0036D5E8 File Offset: 0x0036B7E8
	public override string os()
	{
		return "RocketLauncherAttackGround";
	}

	// Token: 0x060082D3 RID: 33491 RVA: 0x0036D5F0 File Offset: 0x0036B7F0
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x060082D4 RID: 33492 RVA: 0x0036D5F4 File Offset: 0x0036B7F4
	public override bool cs()
	{
		return false;
	}

	// Token: 0x060082D5 RID: 33493 RVA: 0x0036D5F8 File Offset: 0x0036B7F8
	public override int ct()
	{
		return 1;
	}

	// Token: 0x060082D6 RID: 33494 RVA: 0x0036D5FC File Offset: 0x0036B7FC
	public override bool j7()
	{
		return true;
	}

	// Token: 0x060082D7 RID: 33495 RVA: 0x0036D600 File Offset: 0x0036B800
	public override bool bk()
	{
		return true;
	}

	// Token: 0x060082D8 RID: 33496 RVA: 0x0036D604 File Offset: 0x0036B804
	public override bool i2()
	{
		return true;
	}

	// Token: 0x060082D9 RID: 33497 RVA: 0x0036D608 File Offset: 0x0036B808
	public override bool ds()
	{
		return true;
	}

	// Token: 0x060082DA RID: 33498 RVA: 0x0036D60C File Offset: 0x0036B80C
	public override string c1()
	{
		return "Стрелять";
	}

	// Token: 0x060082DC RID: 33500 RVA: 0x0036D61C File Offset: 0x0036B81C
	public override string bm(cnm A_0)
	{
		return "Attacks.44";
	}

	// Token: 0x060082DD RID: 33501 RVA: 0x0036D624 File Offset: 0x0036B824
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x060082DE RID: 33502 RVA: 0x0036D628 File Offset: 0x0036B828
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAttacks/AttackGround");
	}

	// Token: 0x060082DF RID: 33503 RVA: 0x0036D634 File Offset: 0x0036B834
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x060082E0 RID: 33504 RVA: 0x0036D640 File Offset: 0x0036B840
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x060082E1 RID: 33505 RVA: 0x0036D648 File Offset: 0x0036B848
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x060082E2 RID: 33506 RVA: 0x0036D650 File Offset: 0x0036B850
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x060082E3 RID: 33507 RVA: 0x0036D65C File Offset: 0x0036B85C
	protected override int d2(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return euf.a(A_0.b8().Offense.u().CurrentBullet);
		}
		return 0;
	}

	// Token: 0x060082E4 RID: 33508 RVA: 0x0036D698 File Offset: 0x0036B898
	public double[] f2(cnm A_0, double A_1, bool A_2, cmn A_3)
	{
		if (A_0 == null || A_0.b8() == null)
		{
			return null;
		}
		ckp ckp = ckf.a("rocketLauncher") as ckp;
		if (ckp != null)
		{
			bg3 bg = ckp.zj(A_0.b8(), null, A_1, A_2, 1.0, A_0.b8().Offense.u().CurrentBullet, A_3);
			return new double[]
			{
				bg.a
			};
		}
		return null;
	}
}
