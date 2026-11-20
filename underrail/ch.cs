using System;
using System.Collections.Generic;

// Token: 0x02001C98 RID: 7320
[d29("LastStand", "Last Stand")]
public sealed class ch : ai8
{
	// Token: 0x0600A070 RID: 41072 RVA: 0x003E5908 File Offset: 0x003E3B08
	public ch() : base("肴Последний рубеж")
	{
	}

	// Token: 0x0600A071 RID: 41073 RVA: 0x003E5918 File Offset: 0x003E3B18
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<hy>());
	}

	// Token: 0x0600A072 RID: 41074 RVA: 0x003E592C File Offset: 0x003E3B2C
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<hy>());
	}

	// Token: 0x0600A073 RID: 41075 RVA: 0x003E5940 File Offset: 0x003E3B40
	public override object[] at()
	{
		return new object[]
		{
			l4.a(hy.c, false),
			l4.a(hy.b, false)
		};
	}

	// Token: 0x0600A074 RID: 41076 RVA: 0x003E5964 File Offset: 0x003E3B64
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axa), 9),
			new azy(5)
		};
	}
}
