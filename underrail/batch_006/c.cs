using System;
using System.Collections.Generic;

// Token: 0x02001CD5 RID: 7381
[d29("Hemopsychosis", "Hemopsychosis")]
public sealed class c : ai8
{
	// Token: 0x0600A1FD RID: 41469 RVA: 0x003E85E0 File Offset: 0x003E67E0
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1FE RID: 41470 RVA: 0x003E85E8 File Offset: 0x003E67E8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1FF RID: 41471 RVA: 0x003E85EC File Offset: 0x003E67EC
	public c() : base("臗Гемопсихоз")
	{
	}

	// Token: 0x0600A200 RID: 41472 RVA: 0x003E85FC File Offset: 0x003E67FC
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<cpn>());
	}

	// Token: 0x0600A201 RID: 41473 RVA: 0x003E8610 File Offset: 0x003E6810
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<cpn>());
	}

	// Token: 0x0600A202 RID: 41474 RVA: 0x003E8624 File Offset: 0x003E6824
	public override object[] at()
	{
		return new object[]
		{
			l4.a(global::c.a, false)
		};
	}

	// Token: 0x0600A203 RID: 41475 RVA: 0x003E863C File Offset: 0x003E683C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axr), 9),
			new awr(typeof(axa), 7),
			new db7(75),
			new b4k(new Type[]
			{
				typeof(c3v)
			})
		};
	}

	// Token: 0x04003E20 RID: 15904
	public new static readonly int a = 5;
}
