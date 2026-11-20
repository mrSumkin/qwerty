using System;
using System.Collections.Generic;

// Token: 0x02001F77 RID: 8055
[ayj("heGrT")]
public sealed class d6z : ami
{
	// Token: 0x0600BC8D RID: 48269 RVA: 0x00416708 File Offset: 0x00414908
	public override string y8()
	{
		return "Бросок фугасной гранаты";
	}

	// Token: 0x0600BC8E RID: 48270 RVA: 0x00416710 File Offset: 0x00414910
	public override string os()
	{
		return "heGrT";
	}

	// Token: 0x0600BC8F RID: 48271 RVA: 0x00416718 File Offset: 0x00414918
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC90 RID: 48272 RVA: 0x00416720 File Offset: 0x00414920
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Grenades/HE", new object[]
		{
			c18.r(a_).a(true),
			c18.q(a_).a(true),
			(int)(c18.g * 100.0)
		});
	}

	// Token: 0x0600BC91 RID: 48273 RVA: 0x00416780 File Offset: 0x00414980
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.l, ami.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC92 RID: 48274 RVA: 0x004167A0 File Offset: 0x004149A0
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.l
		};
	}

	// Token: 0x0600BC93 RID: 48275 RVA: 0x004167B4 File Offset: 0x004149B4
	protected override int d2(cnm A_0)
	{
		return c18.i();
	}
}
