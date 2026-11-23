using System;
using System.Collections.Generic;

// Token: 0x02001F70 RID: 8048
[ayj("plasmaThrow")]
public sealed class dno : ami
{
	// Token: 0x0600BC44 RID: 48196 RVA: 0x00415F44 File Offset: 0x00414144
	public override string y8()
	{
		return "Бросок плазменной гранаты";
	}

	// Token: 0x0600BC45 RID: 48197 RVA: 0x00415F4C File Offset: 0x0041414C
	public override string os()
	{
		return "plasmaThrow";
	}

	// Token: 0x0600BC46 RID: 48198 RVA: 0x00415F54 File Offset: 0x00414154
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC47 RID: 48199 RVA: 0x00415F60 File Offset: 0x00414160
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Grenades/Plasma", new object[]
		{
			c18.o(a_).a(true),
			c18.p(a_).a(true)
		});
	}

	// Token: 0x0600BC48 RID: 48200 RVA: 0x00415FA8 File Offset: 0x004141A8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.l, ami.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC49 RID: 48201 RVA: 0x00415FC8 File Offset: 0x004141C8
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.l
		};
	}

	// Token: 0x0600BC4A RID: 48202 RVA: 0x00415FDC File Offset: 0x004141DC
	protected override int d2(cnm A_0)
	{
		return c18.h();
	}
}
