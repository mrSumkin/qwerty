using System;
using System.Collections.Generic;

// Token: 0x02001CE7 RID: 7399
[d29("SpecialTactics", "Special Tactics")]
public sealed class y6 : ai8
{
	// Token: 0x0600A283 RID: 41603 RVA: 0x003E95F8 File Offset: 0x003E77F8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A284 RID: 41604 RVA: 0x003E95FC File Offset: 0x003E77FC
	public y6() : base("膇Особая тактика")
	{
	}

	// Token: 0x0600A285 RID: 41605 RVA: 0x003E960C File Offset: 0x003E780C
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<ezf>());
	}

	// Token: 0x0600A286 RID: 41606 RVA: 0x003E9620 File Offset: 0x003E7820
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<ezf>());
	}

	// Token: 0x0600A287 RID: 41607 RVA: 0x003E9638 File Offset: 0x003E7838
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 6),
			new bap(50, new Type[]
			{
				typeof(e5n)
			})
		};
	}

	// Token: 0x0600A288 RID: 41608 RVA: 0x003E9684 File Offset: 0x003E7884
	public override object[] at()
	{
		return new object[]
		{
			y6.a / 1000
		};
	}

	// Token: 0x04003E3D RID: 15933
	public new static readonly int a = d0u.b * 6;

	// Token: 0x04003E3E RID: 15934
	public new static readonly int b = d0u.b * 3;
}
