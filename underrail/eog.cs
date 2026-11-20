using System;
using System.Collections.Generic;

// Token: 0x02001CAE RID: 7342
[d29("DirtyKick", "Dirty Kick")]
public sealed class eog : ai8
{
	// Token: 0x0600A0E8 RID: 41192 RVA: 0x003E6A64 File Offset: 0x003E4C64
	public eog() : base("臂Низкий удар")
	{
	}

	// Token: 0x0600A0E9 RID: 41193 RVA: 0x003E6A74 File Offset: 0x003E4C74
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<czi>());
	}

	// Token: 0x0600A0EA RID: 41194 RVA: 0x003E6A88 File Offset: 0x003E4C88
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<czi>());
	}

	// Token: 0x0600A0EB RID: 41195 RVA: 0x003E6A9C File Offset: 0x003E4C9C
	public override object[] at()
	{
		return new object[]
		{
			l4.a((double)czi.c, false),
			l4.a((double)czi.d, false),
			l4.a((double)czi.b, false),
			czi.e
		};
	}

	// Token: 0x0600A0EC RID: 41196 RVA: 0x003E6AEC File Offset: 0x003E4CEC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(25, new Type[]
			{
				typeof(jk)
			})
		};
	}
}
