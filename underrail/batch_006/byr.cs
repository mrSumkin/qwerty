using System;
using System.Collections.Generic;

// Token: 0x02001F6C RID: 8044
[ayj("chemhazeGrenadeThrow")]
public sealed class byr : ami
{
	// Token: 0x0600BC19 RID: 48153 RVA: 0x00415A8C File Offset: 0x00413C8C
	public override string y8()
	{
		return "Бросок гранаты химическая мгла";
	}

	// Token: 0x0600BC1A RID: 48154 RVA: 0x00415A94 File Offset: 0x00413C94
	public override string os()
	{
		return "chemhazeGrenadeThrow";
	}

	// Token: 0x0600BC1B RID: 48155 RVA: 0x00415A9C File Offset: 0x00413C9C
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.n
		};
	}

	// Token: 0x0600BC1C RID: 48156 RVA: 0x00415AB0 File Offset: 0x00413CB0
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC1D RID: 48157 RVA: 0x00415ABC File Offset: 0x00413CBC
	public override string bp(cnm A_0)
	{
		c18.a(A_0);
		return qv.a("Grenades/Chemhaze", new object[]
		{
			Convert.ToInt32(dyv.c * (double)dyv.b * 100.0),
			Convert.ToInt32(dyv.d * (double)dyv.b * 100.0)
		});
	}

	// Token: 0x0600BC1E RID: 48158 RVA: 0x00415B28 File Offset: 0x00413D28
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.n, this.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC1F RID: 48159 RVA: 0x00415B54 File Offset: 0x00413D54
	protected override int d2(cnm A_0)
	{
		return 2;
	}

	// Token: 0x0600BC20 RID: 48160 RVA: 0x00415B58 File Offset: 0x00413D58
	private int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return c18.a(A_0.b8(), byr.a);
		}
		return byr.a * d0u.b;
	}

	// Token: 0x040043FA RID: 17402
	private new static readonly int a = 6;
}
