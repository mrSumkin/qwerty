using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EF7 RID: 7927
[ayj("ShootDreadnoughtRocket")]
public sealed class a40 : c0z, a5q
{
	// Token: 0x0600B535 RID: 46389 RVA: 0x004094AC File Offset: 0x004076AC
	public override string y8()
	{
		return "Запустить ракету";
	}

	// Token: 0x0600B536 RID: 46390 RVA: 0x004094B4 File Offset: 0x004076B4
	public override string os()
	{
		return "ShootDreadnoughtRocket";
	}

	// Token: 0x0600B537 RID: 46391 RVA: 0x004094BC File Offset: 0x004076BC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B538 RID: 46392 RVA: 0x004094C0 File Offset: 0x004076C0
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B539 RID: 46393 RVA: 0x004094C4 File Offset: 0x004076C4
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.a,
			c = c0e.g
		};
	}

	// Token: 0x0600B53A RID: 46394 RVA: 0x004094E4 File Offset: 0x004076E4
	public override bool j7()
	{
		return true;
	}

	// Token: 0x0600B53B RID: 46395 RVA: 0x004094E8 File Offset: 0x004076E8
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600B53C RID: 46396 RVA: 0x004094F4 File Offset: 0x004076F4
	public a40()
	{
		this.i = new List<string>();
		this.i.Add("SA.ShootDreadnoughtRocket");
	}

	// Token: 0x0600B53D RID: 46397 RVA: 0x00409518 File Offset: 0x00407718
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600B53E RID: 46398 RVA: 0x00409520 File Offset: 0x00407720
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600B53F RID: 46399 RVA: 0x00409528 File Offset: 0x00407728
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/ShootDreadnoughtRocket", new object[]
		{
			a40.c(1.0).a(true),
			a40.b(1.0).a(true),
			a40.g
		});
	}

	// Token: 0x0600B540 RID: 46400 RVA: 0x00409588 File Offset: 0x00407788
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B541 RID: 46401 RVA: 0x00409594 File Offset: 0x00407794
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.ShootDreadnoughtRocket", a40.b, false, false)
		};
	}

	// Token: 0x0600B542 RID: 46402 RVA: 0x004095B4 File Offset: 0x004077B4
	public override IList<string> bi()
	{
		return this.i;
	}

	// Token: 0x0600B543 RID: 46403 RVA: 0x004095BC File Offset: 0x004077BC
	public static a1q c(double A_0 = 1.0)
	{
		return new a1q(DamageType.Mechanical, a40.c, a40.d);
	}

	// Token: 0x0600B544 RID: 46404 RVA: 0x004095D0 File Offset: 0x004077D0
	public static a1q b(double A_0 = 1.0)
	{
		return new a1q(DamageType.Heat, a40.e, a40.f);
	}

	// Token: 0x0600B545 RID: 46405 RVA: 0x004095E4 File Offset: 0x004077E4
	public static List<csk> a(double A_0)
	{
		return new List<csk>
		{
			euf.a(a40.c(1.0), A_0),
			euf.a(a40.b(1.0), A_0)
		};
	}

	// Token: 0x0600B546 RID: 46406 RVA: 0x00409620 File Offset: 0x00407820
	public double[] f2(cnm A_0, double A_1, bool A_2, cmn A_3)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			int a_ = A_0.b8().Skills.Get<ct7>().g();
			return euf.a(A_0.b8(), a_, A_1, 0.0);
		}
		return null;
	}

	// Token: 0x0600B547 RID: 46407 RVA: 0x0040966C File Offset: 0x0040786C
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B548 RID: 46408 RVA: 0x00409674 File Offset: 0x00407874
	protected override float f0(cnm A_0)
	{
		return (float)a40.h;
	}

	// Token: 0x0600B549 RID: 46409 RVA: 0x0040967C File Offset: 0x0040787C
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x0600B54A RID: 46410 RVA: 0x00409680 File Offset: 0x00407880
	protected override int d2(cnm A_0)
	{
		return a40.g;
	}

	// Token: 0x04004206 RID: 16902
	private new const string a = "SA.ShootDreadnoughtRocket";

	// Token: 0x04004207 RID: 16903
	private static readonly int b = d0u.b * 3;

	// Token: 0x04004208 RID: 16904
	private static readonly int c = 150;

	// Token: 0x04004209 RID: 16905
	private static readonly int d = 250;

	// Token: 0x0400420A RID: 16906
	private new static readonly int e = 150;

	// Token: 0x0400420B RID: 16907
	private static readonly int f = 250;

	// Token: 0x0400420C RID: 16908
	public new static readonly int g = 2;

	// Token: 0x0400420D RID: 16909
	public new static readonly int h = 15;

	// Token: 0x0400420E RID: 16910
	private new List<string> i;
}
