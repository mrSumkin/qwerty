using System;
using System.Collections.Generic;

// Token: 0x02001CAA RID: 7338
[d29("UncannyDodge", "Uncanny Dodge")]
public sealed class bov : ai8
{
	// Token: 0x0600A0D3 RID: 41171 RVA: 0x003E66B0 File Offset: 0x003E48B0
	public bov() : base("胀Невероятное уклонение")
	{
	}

	// Token: 0x0600A0D4 RID: 41172 RVA: 0x003E66C0 File Offset: 0x003E48C0
	public override object[] at()
	{
		return new object[]
		{
			bov.a,
			bov.b,
			l4.a(amv.b, false)
		};
	}

	// Token: 0x0600A0D5 RID: 41173 RVA: 0x003E66F0 File Offset: 0x003E48F0
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<amv>());
	}

	// Token: 0x0600A0D6 RID: 41174 RVA: 0x003E6704 File Offset: 0x003E4904
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<amv>());
	}

	// Token: 0x0600A0D7 RID: 41175 RVA: 0x003E671C File Offset: 0x003E491C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(40, new Type[]
			{
				typeof(e74)
			}),
			new awr(typeof(dqg), 8)
		};
	}

	// Token: 0x04003DEF RID: 15855
	public new static readonly int a = 2;

	// Token: 0x04003DF0 RID: 15856
	public new static readonly int b = 30;

	// Token: 0x04003DF1 RID: 15857
	public static readonly int c = 2;
}
