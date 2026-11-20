using System;
using System.Collections.Generic;

// Token: 0x02001C28 RID: 7208
[d29("ArmorSloping", "Armor Sloping")]
public sealed class dcs : ai8
{
	// Token: 0x06009E50 RID: 40528 RVA: 0x003E1C80 File Offset: 0x003DFE80
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E51 RID: 40529 RVA: 0x003E1C84 File Offset: 0x003DFE84
	public dcs() : base("股Наклонная броня")
	{
	}

	// Token: 0x06009E52 RID: 40530 RVA: 0x003E1C94 File Offset: 0x003DFE94
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009E53 RID: 40531 RVA: 0x003E1C98 File Offset: 0x003DFE98
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009E54 RID: 40532 RVA: 0x003E1C9C File Offset: 0x003DFE9C
	public override object[] at()
	{
		return new object[]
		{
			(int)(dcs.a * 100.0)
		};
	}

	// Token: 0x06009E55 RID: 40533 RVA: 0x003E1CC0 File Offset: 0x003DFEC0
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 6),
			new bap(15, new Type[]
			{
				typeof(eq1)
			})
		};
	}

	// Token: 0x04003D65 RID: 15717
	public new static readonly double a = 0.35;
}
