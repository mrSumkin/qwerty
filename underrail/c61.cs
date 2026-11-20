using System;
using System.Collections.Generic;

// Token: 0x02001CCC RID: 7372
[d29("Flurry", "Flurry")]
public sealed class c61 : ai8
{
	// Token: 0x0600A1C2 RID: 41410 RVA: 0x003E7F3C File Offset: 0x003E613C
	public c61() : base("膤Шквал")
	{
	}

	// Token: 0x0600A1C3 RID: 41411 RVA: 0x003E7F4C File Offset: 0x003E614C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1C4 RID: 41412 RVA: 0x003E7F54 File Offset: 0x003E6154
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1C5 RID: 41413 RVA: 0x003E7F58 File Offset: 0x003E6158
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<b67>());
	}

	// Token: 0x0600A1C6 RID: 41414 RVA: 0x003E7F6C File Offset: 0x003E616C
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<b67>());
	}

	// Token: 0x0600A1C7 RID: 41415 RVA: 0x003E7F80 File Offset: 0x003E6180
	public override object[] at()
	{
		return new object[]
		{
			b67.a(null),
			b67.e,
			b67.f,
			l4.a(b67.b, false)
		};
	}

	// Token: 0x0600A1C8 RID: 41416 RVA: 0x003E7FC4 File Offset: 0x003E61C4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 6),
			new bap(30, new Type[]
			{
				typeof(jk)
			})
		};
	}
}
