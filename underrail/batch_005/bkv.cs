using System;
using System.Collections.Generic;

// Token: 0x02001C2D RID: 7213
[d29("CookedShot", "Cooked Shot")]
public sealed class bkv : ai8
{
	// Token: 0x06009E70 RID: 40560 RVA: 0x003E1F2C File Offset: 0x003E012C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E71 RID: 40561 RVA: 0x003E1F30 File Offset: 0x003E0130
	public bkv() : base("胹Подготовленный выстрел")
	{
	}

	// Token: 0x06009E72 RID: 40562 RVA: 0x003E1F40 File Offset: 0x003E0140
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<cks>());
	}

	// Token: 0x06009E73 RID: 40563 RVA: 0x003E1F54 File Offset: 0x003E0154
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<cks>());
	}

	// Token: 0x06009E74 RID: 40564 RVA: 0x003E1F68 File Offset: 0x003E0168
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 5),
			new bap(35, new Type[]
			{
				typeof(ct7)
			}),
			new bap(25, new Type[]
			{
				typeof(ii)
			})
		};
	}

	// Token: 0x06009E75 RID: 40565 RVA: 0x003E1FD4 File Offset: 0x003E01D4
	public override object[] at()
	{
		return new object[]
		{
			(int)(bkv.b * 100.0),
			l4.a(bkv.a, false)
		};
	}

	// Token: 0x04003D6A RID: 15722
	public new static readonly int a = 2;

	// Token: 0x04003D6B RID: 15723
	public new static readonly double b = 1.5;
}
