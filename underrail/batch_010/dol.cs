using System;
using System.Collections.Generic;

// Token: 0x02001CBA RID: 7354
[d29("Sweep", "Sweep")]
public sealed class dol : ai8
{
	// Token: 0x0600A138 RID: 41272 RVA: 0x003E720C File Offset: 0x003E540C
	public dol() : base("膛Подсечение")
	{
	}

	// Token: 0x0600A139 RID: 41273 RVA: 0x003E721C File Offset: 0x003E541C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A13A RID: 41274 RVA: 0x003E7224 File Offset: 0x003E5424
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A13B RID: 41275 RVA: 0x003E7228 File Offset: 0x003E5428
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<d2g>());
	}

	// Token: 0x0600A13C RID: 41276 RVA: 0x003E723C File Offset: 0x003E543C
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<d2g>());
	}

	// Token: 0x0600A13D RID: 41277 RVA: 0x003E7250 File Offset: 0x003E5450
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(d2g.d * 100.0),
			l4.a(d2g.b, false),
			l4.a(d2g.c, false)
		};
	}

	// Token: 0x0600A13E RID: 41278 RVA: 0x003E7294 File Offset: 0x003E5494
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(dqg), 6),
			new bap(55, new Type[]
			{
				typeof(jk)
			})
		};
	}
}
