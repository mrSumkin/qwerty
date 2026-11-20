using System;
using System.Collections.Generic;

// Token: 0x02001F76 RID: 8054
[ayj("empGrenade")]
public sealed class v0 : ami
{
	// Token: 0x0600BC83 RID: 48259 RVA: 0x00416618 File Offset: 0x00414818
	public override string y8()
	{
		return "Бросок ЭМИ-гранаты";
	}

	// Token: 0x0600BC84 RID: 48260 RVA: 0x00416620 File Offset: 0x00414820
	public override string os()
	{
		return "empGrenade";
	}

	// Token: 0x0600BC85 RID: 48261 RVA: 0x00416628 File Offset: 0x00414828
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC86 RID: 48262 RVA: 0x00416630 File Offset: 0x00414830
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Grenades/EMP", new object[]
		{
			c18.n(a_).a(true),
			c18.m(a_),
			(int)(c18.a5 * 100.0)
		});
	}

	// Token: 0x0600BC87 RID: 48263 RVA: 0x0041668C File Offset: 0x0041488C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("grenade.emp", global::v0.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC88 RID: 48264 RVA: 0x004166AC File Offset: 0x004148AC
	public override IList<string> bi()
	{
		return new List<string>
		{
			"grenade.emp"
		};
	}

	// Token: 0x0600BC89 RID: 48265 RVA: 0x004166C0 File Offset: 0x004148C0
	protected override int d2(cnm A_0)
	{
		return c18.e();
	}

	// Token: 0x0600BC8A RID: 48266 RVA: 0x004166C8 File Offset: 0x004148C8
	private new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return c18.a(A_0.b8(), global::v0.b);
		}
		return global::v0.b * d0u.b;
	}

	// Token: 0x04004407 RID: 17415
	private new const string a = "grenade.emp";

	// Token: 0x04004408 RID: 17416
	private static readonly int b = 6;
}
