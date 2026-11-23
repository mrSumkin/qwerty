using System;
using System.Collections.Generic;

// Token: 0x02001C63 RID: 7267
[d29("PsionicMania", "Psionic Mania")]
public sealed class d11 : ai8
{
	// Token: 0x06009F56 RID: 40790 RVA: 0x003E3898 File Offset: 0x003E1A98
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009F57 RID: 40791 RVA: 0x003E389C File Offset: 0x003E1A9C
	public d11() : base("臒Пси-мания")
	{
	}

	// Token: 0x06009F58 RID: 40792 RVA: 0x003E38AC File Offset: 0x003E1AAC
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<e67>());
	}

	// Token: 0x06009F59 RID: 40793 RVA: 0x003E38C0 File Offset: 0x003E1AC0
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<e67>());
	}

	// Token: 0x06009F5A RID: 40794 RVA: 0x003E38D4 File Offset: 0x003E1AD4
	public override object[] at()
	{
		return new object[]
		{
			(int)(d11.b * 100.0),
			l4.a(d11.c, false)
		};
	}

	// Token: 0x06009F5B RID: 40795 RVA: 0x003E3904 File Offset: 0x003E1B04
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axr), 8),
			new db7(50),
			new b4k(new Type[]
			{
				typeof(c80)
			})
		};
	}

	// Token: 0x04003D9B RID: 15771
	public new static readonly int a = 1;

	// Token: 0x04003D9C RID: 15772
	public new static readonly double b = 0.15;

	// Token: 0x04003D9D RID: 15773
	public static readonly int c = 5;
}
