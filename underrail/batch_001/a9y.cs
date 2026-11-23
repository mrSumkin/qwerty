using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F15 RID: 7957
[ayj("Precognition")]
public sealed class a9y : aoc
{
	// Token: 0x0600B72E RID: 46894 RVA: 0x0040D10C File Offset: 0x0040B30C
	public override string y8()
	{
		return "Сверхчувственное предвидение";
	}

	// Token: 0x0600B72F RID: 46895 RVA: 0x0040D114 File Offset: 0x0040B314
	public override string os()
	{
		return "Precognition";
	}

	// Token: 0x0600B730 RID: 46896 RVA: 0x0040D11C File Offset: 0x0040B31C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B731 RID: 46897 RVA: 0x0040D120 File Offset: 0x0040B320
	public override IList<string> bi()
	{
		return new List<string>
		{
			a9y.b
		};
	}

	// Token: 0x0600B732 RID: 46898 RVA: 0x0040D134 File Offset: 0x0040B334
	public override PsiSchool ch()
	{
		return PsiSchool.TemporalManipulation;
	}

	// Token: 0x0600B733 RID: 46899 RVA: 0x0040D138 File Offset: 0x0040B338
	public override int ci()
	{
		return 7;
	}

	// Token: 0x0600B734 RID: 46900 RVA: 0x0040D13C File Offset: 0x0040B33C
	public override v5 c2()
	{
		return v5.a;
	}

	// Token: 0x0600B735 RID: 46901 RVA: 0x0040D140 File Offset: 0x0040B340
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new bap(65, new Type[]
			{
				typeof(p5)
			}),
			new b4k(new Type[]
			{
				typeof(c3v)
			})
		};
	}

	// Token: 0x0600B736 RID: 46902 RVA: 0x0040D194 File Offset: 0x0040B394
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/Precognition", new object[]
		{
			(A_0 != null) ? (a9y.a(A_0.b8()) * 100.0) : 0.0,
			this.a(A_0)
		});
	}

	// Token: 0x0600B737 RID: 46903 RVA: 0x0040D1F4 File Offset: 0x0040B3F4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		int num = a9y.a;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num = Math.Max(0, num - ank.b * d0u.b);
		}
		if (num > 0)
		{
			list.Add(new cfd(a9y.b, num, false, false));
		}
		return list;
	}

	// Token: 0x0600B738 RID: 46904 RVA: 0x0040D264 File Offset: 0x0040B464
	public override List<els> j8(cnm A_0)
	{
		return new List<els>
		{
			new doy()
		};
	}

	// Token: 0x0600B739 RID: 46905 RVA: 0x0040D278 File Offset: 0x0040B478
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null) && A_0.b8().Offense.aa().zo() >= (float)this.a(A_0);
	}

	// Token: 0x0600B73A RID: 46906 RVA: 0x0040D2C8 File Offset: 0x0040B4C8
	public static double a(efk A_0)
	{
		int num = 0;
		if (A_0 != null)
		{
			num = A_0.Skills.Get<p5>().g();
		}
		return Math.Round(a9y.d * (double)num, 3);
	}

	// Token: 0x0600B73B RID: 46907 RVA: 0x0040D2FC File Offset: 0x0040B4FC
	public int a(cnm A_0)
	{
		return Convert.ToInt32((float)a9y.c * this.c(A_0));
	}

	// Token: 0x0600B73C RID: 46908 RVA: 0x0040D314 File Offset: 0x0040B514
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004292 RID: 17042
	private new static readonly int a = 2 * d0u.b;

	// Token: 0x04004293 RID: 17043
	public new static readonly string b = "Psi.Precognition";

	// Token: 0x04004294 RID: 17044
	public new static readonly int c = 25;

	// Token: 0x04004295 RID: 17045
	public static readonly double d = 0.001;
}
