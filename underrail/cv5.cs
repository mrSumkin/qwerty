using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EFF RID: 7935
[ayj("Yell")]
public sealed class cv5 : c0z
{
	// Token: 0x0600B5BB RID: 46523 RVA: 0x00409EF4 File Offset: 0x004080F4
	public override string y8()
	{
		return "Крик";
	}

	// Token: 0x0600B5BC RID: 46524 RVA: 0x00409EFC File Offset: 0x004080FC
	public override string os()
	{
		return "Yell";
	}

	// Token: 0x0600B5BD RID: 46525 RVA: 0x00409F04 File Offset: 0x00408104
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B5BE RID: 46526 RVA: 0x00409F08 File Offset: 0x00408108
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B5BF RID: 46527 RVA: 0x00409F0C File Offset: 0x0040810C
	public cv5()
	{
		this.g = new List<string>();
		this.g.Add("SA.Yell");
	}

	// Token: 0x0600B5C0 RID: 46528 RVA: 0x00409F34 File Offset: 0x00408134
	public override a3b bl(cnm A_0, efk A_1)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().b(d8o.t))
		{
			return new a3b
			{
				c = c0e.q,
				d = new int?(80)
			};
		}
		return new a3b
		{
			c = c0e.g
		};
	}

	// Token: 0x0600B5C1 RID: 46529 RVA: 0x00409F98 File Offset: 0x00408198
	public override string bm(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dcv>())
		{
			return "MonstrousYell";
		}
		return "Yell";
	}

	// Token: 0x0600B5C2 RID: 46530 RVA: 0x00409FCC File Offset: 0x004081CC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B5C3 RID: 46531 RVA: 0x00409FD0 File Offset: 0x004081D0
	public override string bo(cnm A_0)
	{
		int num = cv5.a(A_0);
		string text = qv.a("SpecialAbilities/Yell", new object[]
		{
			num,
			l4.a((double)cv5.d, false)
		});
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dcv>())
		{
			text += "\r\n\r\n";
			text += qv.a("SpecialAbilities/YellMonstrous", new object[]
			{
				Convert.ToInt32(dcv.a * 100.0),
				l4.a(dcv.b, false)
			});
		}
		return text;
	}

	// Token: 0x0600B5C4 RID: 46532 RVA: 0x0040A084 File Offset: 0x00408284
	public new static int a(cnm A_0)
	{
		double num = 0.0;
		if (A_0 != null && A_0.b8() != null)
		{
			num = Math.Round(cv5.e + (double)A_0.b8().GetSpecializationValue<eim>(true) * eim.a, 2);
			ab7 microfeat = A_0.b8().GetMicrofeat<ab7>();
			if (microfeat != null)
			{
				num += microfeat.a();
			}
		}
		num = d05.b(0.0, num, 1.0);
		return Math.Max(0, (int)((double)A_0.b8().Skills.Get<bec>().g() * num));
	}

	// Token: 0x0600B5C5 RID: 46533 RVA: 0x0040A120 File Offset: 0x00408320
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.Yell", cv5.c, false, false)
		};
	}

	// Token: 0x0600B5C6 RID: 46534 RVA: 0x0040A140 File Offset: 0x00408340
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B5C7 RID: 46535 RVA: 0x0040A148 File Offset: 0x00408348
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600B5C8 RID: 46536 RVA: 0x0040A14C File Offset: 0x0040834C
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B5C9 RID: 46537 RVA: 0x0040A150 File Offset: 0x00408350
	protected override int d2(cnm A_0)
	{
		return cv5.f;
	}

	// Token: 0x0400422A RID: 16938
	private new const string a = "Yell";

	// Token: 0x0400422B RID: 16939
	private const string b = "SA.Yell";

	// Token: 0x0400422C RID: 16940
	public static readonly int c = 10 * d0u.b;

	// Token: 0x0400422D RID: 16941
	public static readonly int d = 3 * d0u.b;

	// Token: 0x0400422E RID: 16942
	public new static readonly double e = 0.35;

	// Token: 0x0400422F RID: 16943
	public static readonly int f = 8;

	// Token: 0x04004230 RID: 16944
	private new List<string> g;
}
