using System;
using System.Collections.Generic;

// Token: 0x02001C27 RID: 7207
[d29("Blitz", "Blitz")]
public sealed class bk8 : ai8
{
	// Token: 0x06009E4B RID: 40523 RVA: 0x003E1BEC File Offset: 0x003DFDEC
	public bk8() : base("胏Блиц")
	{
	}

	// Token: 0x06009E4C RID: 40524 RVA: 0x003E1BFC File Offset: 0x003DFDFC
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<cn3>());
	}

	// Token: 0x06009E4D RID: 40525 RVA: 0x003E1C10 File Offset: 0x003DFE10
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<cn3>());
	}

	// Token: 0x06009E4E RID: 40526 RVA: 0x003E1C24 File Offset: 0x003DFE24
	public override object[] at()
	{
		return new object[]
		{
			cn3.c,
			cn3.d,
			l4.a(cn3.b, false)
		};
	}

	// Token: 0x06009E4F RID: 40527 RVA: 0x003E1C54 File Offset: 0x003DFE54
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new azy(10),
			new awr(typeof(dqg), 10)
		};
	}
}
