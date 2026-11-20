using System;
using System.Collections.Generic;

// Token: 0x02001F79 RID: 8057
[ayj("FlashbangThrow")]
public sealed class c0p : ami
{
	// Token: 0x0600BC9D RID: 48285 RVA: 0x00416888 File Offset: 0x00414A88
	public override string y8()
	{
		return "Бросок светошумовой гранаты";
	}

	// Token: 0x0600BC9E RID: 48286 RVA: 0x00416890 File Offset: 0x00414A90
	public override string os()
	{
		return "FlashbangThrow";
	}

	// Token: 0x0600BC9F RID: 48287 RVA: 0x00416898 File Offset: 0x00414A98
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BCA0 RID: 48288 RVA: 0x004168A0 File Offset: 0x00414AA0
	public override string bp(cnm A_0)
	{
		return qv.a("Grenades/Flashbang", new object[]
		{
			l4.a((double)c0p.b(), false)
		});
	}

	// Token: 0x0600BCA1 RID: 48289 RVA: 0x004168C4 File Offset: 0x00414AC4
	public static int c()
	{
		return c2h.a(14, 10, 5.0);
	}

	// Token: 0x0600BCA2 RID: 48290 RVA: 0x004168D8 File Offset: 0x00414AD8
	public static int b()
	{
		return 2 * d0u.b;
	}

	// Token: 0x0600BCA3 RID: 48291 RVA: 0x004168E4 File Offset: 0x00414AE4
	public static int a()
	{
		return 5 * d0u.b;
	}

	// Token: 0x0600BCA4 RID: 48292 RVA: 0x004168F0 File Offset: 0x00414AF0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.n, c0p.a(A_0), false, false),
			new cfd("grenade.flashbang", c0p.a(A_0), false, false)
		};
	}

	// Token: 0x0600BCA5 RID: 48293 RVA: 0x00416934 File Offset: 0x00414B34
	public override IList<string> bi()
	{
		return new List<string>
		{
			"grenade.flashbang",
			d7f.n
		};
	}

	// Token: 0x0600BCA6 RID: 48294 RVA: 0x00416954 File Offset: 0x00414B54
	protected override int d2(cnm A_0)
	{
		return 3;
	}

	// Token: 0x0600BCA7 RID: 48295 RVA: 0x0041695C File Offset: 0x00414B5C
	private new static int a(cnm A_0)
	{
		int num;
		if (A_0 != null && A_0.b8() != null)
		{
			num = c18.a(A_0.b8(), c0p.b);
		}
		else
		{
			num = c0p.b * d0u.b;
		}
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<m6>())
		{
			num -= (int)(((double)m6.b + (double)A_0.b8().GetSpecializationValue<ajw>(true) * ajw.a) * (double)d0u.b);
		}
		return num;
	}

	// Token: 0x04004409 RID: 17417
	private new const string a = "grenade.flashbang";

	// Token: 0x0400440A RID: 17418
	private static readonly int b = 8;
}
