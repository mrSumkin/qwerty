using System;
using System.Collections.Generic;

// Token: 0x02001CBB RID: 7355
[d29("ShieldBash", "Shield Bash")]
public sealed class dtr : ai8
{
	// Token: 0x0600A13F RID: 41279 RVA: 0x003E72E0 File Offset: 0x003E54E0
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A140 RID: 41280 RVA: 0x003E72E8 File Offset: 0x003E54E8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A141 RID: 41281 RVA: 0x003E72EC File Offset: 0x003E54EC
	public dtr() : base("膻Удар щитом")
	{
	}

	// Token: 0x0600A142 RID: 41282 RVA: 0x003E72FC File Offset: 0x003E54FC
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<a5p>());
	}

	// Token: 0x0600A143 RID: 41283 RVA: 0x003E7310 File Offset: 0x003E5510
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<a5p>());
	}

	// Token: 0x0600A144 RID: 41284 RVA: 0x003E7324 File Offset: 0x003E5524
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(a5p.a * 100.0),
			Convert.ToInt32(a5p.b * 100.0),
			l4.a(a5p.e, false),
			l4.a(a5p.d, false)
		};
	}

	// Token: 0x0600A145 RID: 41285 RVA: 0x003E738C File Offset: 0x003E558C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 6),
			new bap(40, new Type[]
			{
				typeof(jk)
			})
		};
	}
}
