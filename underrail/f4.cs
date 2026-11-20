using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001ED0 RID: 7888
[ayj("ShootPlasmaFlare")]
public sealed class f4 : c0z, a5q
{
	// Token: 0x0600B29C RID: 45724 RVA: 0x004051C8 File Offset: 0x004033C8
	public override string y8()
	{
		return "Выстрел плазменной вспышкой";
	}

	// Token: 0x0600B29D RID: 45725 RVA: 0x004051D0 File Offset: 0x004033D0
	public override string os()
	{
		return "ShootPlasmaFlare";
	}

	// Token: 0x0600B29E RID: 45726 RVA: 0x004051D8 File Offset: 0x004033D8
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B29F RID: 45727 RVA: 0x004051DC File Offset: 0x004033DC
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B2A0 RID: 45728 RVA: 0x004051E0 File Offset: 0x004033E0
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.c
		};
	}

	// Token: 0x0600B2A1 RID: 45729 RVA: 0x004051F4 File Offset: 0x004033F4
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B2A2 RID: 45730 RVA: 0x004051F8 File Offset: 0x004033F8
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.GroundAttack);
	}

	// Token: 0x0600B2A3 RID: 45731 RVA: 0x00405204 File Offset: 0x00403404
	public override IList<string> bi()
	{
		return this.i;
	}

	// Token: 0x0600B2A4 RID: 45732 RVA: 0x0040520C File Offset: 0x0040340C
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600B2A5 RID: 45733 RVA: 0x00405210 File Offset: 0x00403410
	public f4()
	{
		this.i = new List<string>();
		this.i.Add(f4.g);
	}

	// Token: 0x0600B2A6 RID: 45734 RVA: 0x00405234 File Offset: 0x00403434
	public override string bm(cnm A_0)
	{
		return "Xpbl_Abilities.32";
	}

	// Token: 0x0600B2A7 RID: 45735 RVA: 0x0040523C File Offset: 0x0040343C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredTraversableSpot;
	}

	// Token: 0x0600B2A8 RID: 45736 RVA: 0x00405240 File Offset: 0x00403440
	public override string bo(cnm A_0)
	{
		string text;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<n4>())
		{
			text = qv.b("SpecialAbilities/ShootPlasmaFlare_HT");
		}
		else
		{
			text = qv.b("SpecialAbilities/ShootPlasmaFlare");
		}
		if (text != null)
		{
			return string.Format(text, new object[]
			{
				f4.c(A_0, 1.0).a(true),
				f4.b(A_0, 1.0).a(true),
				f4.f,
				kh.c / 1000
			});
		}
		return "";
	}

	// Token: 0x0600B2A9 RID: 45737 RVA: 0x004052FC File Offset: 0x004034FC
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B2AA RID: 45738 RVA: 0x00405308 File Offset: 0x00403508
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(f4.g, f4.h, false, false)
		};
	}

	// Token: 0x0600B2AB RID: 45739 RVA: 0x00405328 File Offset: 0x00403528
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().Battery >= (double)f4.f && A_0.b8().Offense.u().TypedDefinition.e(this.TechnicalName);
	}

	// Token: 0x0600B2AC RID: 45740 RVA: 0x004053C4 File Offset: 0x004035C4
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().Battery >= (double)f4.f && A_0.b8().Offense.u().TypedDefinition.e(this.TechnicalName);
	}

	// Token: 0x0600B2AD RID: 45741 RVA: 0x00405454 File Offset: 0x00403654
	public static a1q c(cnm A_0, double A_1 = 1.0)
	{
		a1q result = new a1q(DamageType.Energy, f4.a, f4.b);
		f4.a(A_0, ref result);
		return result;
	}

	// Token: 0x0600B2AE RID: 45742 RVA: 0x0040547C File Offset: 0x0040367C
	public static a1q b(cnm A_0, double A_1 = 1.0)
	{
		a1q result = new a1q(DamageType.Heat, f4.c, f4.d);
		f4.a(A_0, ref result);
		return result;
	}

	// Token: 0x0600B2AF RID: 45743 RVA: 0x004054A4 File Offset: 0x004036A4
	private static void a(cnm A_0, ref a1q A_1)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<n4>())
		{
			double num = n4.a(A_0.b8());
			A_1 = a1q.a(A_1, 1.0 + num);
		}
	}

	// Token: 0x0600B2B0 RID: 45744 RVA: 0x00405500 File Offset: 0x00403700
	public static List<csk> a(cnm A_0, double A_1)
	{
		return new List<csk>
		{
			euf.a(f4.c(A_0, 1.0), A_1),
			euf.a(f4.b(A_0, 1.0), A_1)
		};
	}

	// Token: 0x0600B2B1 RID: 45745 RVA: 0x00405540 File Offset: 0x00403740
	public double[] f2(cnm A_0, double A_1, bool A_2, cmn A_3)
	{
		return euf.a(A_0.b8(), f4.a(A_0), A_1, 0.0);
	}

	// Token: 0x0600B2B2 RID: 45746 RVA: 0x00405560 File Offset: 0x00403760
	public new static int a(cnm A_0)
	{
		int result = 50;
		if (A_0 != null && A_0.b8() != null)
		{
			result = A_0.b8().Skills.Get<ct7>().g();
		}
		return result;
	}

	// Token: 0x0600B2B3 RID: 45747 RVA: 0x00405598 File Offset: 0x00403798
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B2B4 RID: 45748 RVA: 0x0040559C File Offset: 0x0040379C
	protected override float f0(cnm A_0)
	{
		return (float)f4.e;
	}

	// Token: 0x0600B2B5 RID: 45749 RVA: 0x004055A8 File Offset: 0x004037A8
	protected override int hi(cnm A_0)
	{
		int num = 15;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Offense.av() < num)
		{
			num = A_0.b8().Offense.av();
		}
		return num;
	}

	// Token: 0x04004161 RID: 16737
	private new static readonly int a = 30;

	// Token: 0x04004162 RID: 16738
	private static readonly int b = 60;

	// Token: 0x04004163 RID: 16739
	private static readonly int c = 30;

	// Token: 0x04004164 RID: 16740
	private static readonly int d = 60;

	// Token: 0x04004165 RID: 16741
	public new static readonly int e = 12;

	// Token: 0x04004166 RID: 16742
	public static readonly int f = 15;

	// Token: 0x04004167 RID: 16743
	private new static readonly string g = "shootPlasmaFlare";

	// Token: 0x04004168 RID: 16744
	private new static readonly int h = 3 * d0u.b;

	// Token: 0x04004169 RID: 16745
	private new List<string> i;
}
