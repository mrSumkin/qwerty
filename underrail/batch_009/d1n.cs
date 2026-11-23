using System;
using System.Collections.Generic;

// Token: 0x02001F78 RID: 8056
[ayj("fragT")]
public sealed class d1n : ami
{
	// Token: 0x0600BC95 RID: 48277 RVA: 0x004167C4 File Offset: 0x004149C4
	public override string y8()
	{
		return "Бросок осколочной гранаты";
	}

	// Token: 0x0600BC96 RID: 48278 RVA: 0x004167CC File Offset: 0x004149CC
	public override string os()
	{
		return "fragT";
	}

	// Token: 0x0600BC97 RID: 48279 RVA: 0x004167D4 File Offset: 0x004149D4
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC98 RID: 48280 RVA: 0x004167E0 File Offset: 0x004149E0
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Grenades/Frag", new object[]
		{
			c18.s(a_).a(true),
			c18.ar,
			c18.@as,
			c18.t(a_).a(true)
		});
	}

	// Token: 0x0600BC99 RID: 48281 RVA: 0x00416844 File Offset: 0x00414A44
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.l, ami.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC9A RID: 48282 RVA: 0x00416864 File Offset: 0x00414A64
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.l
		};
	}

	// Token: 0x0600BC9B RID: 48283 RVA: 0x00416878 File Offset: 0x00414A78
	protected override int d2(cnm A_0)
	{
		return c18.j();
	}
}
