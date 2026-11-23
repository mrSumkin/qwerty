using System;
using System.Collections.Generic;

// Token: 0x02001CB2 RID: 7346
[d29("Specialist", "Specialist")]
public sealed class a0v : ai8
{
	// Token: 0x0600A0FF RID: 41215 RVA: 0x003E6D1C File Offset: 0x003E4F1C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A100 RID: 41216 RVA: 0x003E6D24 File Offset: 0x003E4F24
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A101 RID: 41217 RVA: 0x003E6D28 File Offset: 0x003E4F28
	public a0v() : base("肉Специалист")
	{
	}

	// Token: 0x0600A102 RID: 41218 RVA: 0x003E6D38 File Offset: 0x003E4F38
	public override void ar(efk A_0)
	{
		e3q e3q = A_0 as e3q;
		if (e3q != null)
		{
			e3q e3q2 = e3q;
			e3q2.a(e3q2.f() + 1);
		}
	}

	// Token: 0x0600A103 RID: 41219 RVA: 0x003E6D60 File Offset: 0x003E4F60
	public override void @as(efk A_0)
	{
		e3q e3q = A_0 as e3q;
		if (e3q != null)
		{
			e3q e3q2 = e3q;
			e3q2.a(e3q2.f() - 1);
		}
	}

	// Token: 0x0600A104 RID: 41220 RVA: 0x003E6D88 File Offset: 0x003E4F88
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new azy(16),
			new awr(typeof(av8), 10)
		};
	}
}
