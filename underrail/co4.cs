using System;
using System.Collections.Generic;

// Token: 0x02001E06 RID: 7686
[d29("CI", "Cryogenic Induction")]
public sealed class co4 : ai8
{
	// Token: 0x0600AA31 RID: 43569 RVA: 0x003F3698 File Offset: 0x003F1898
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600AA32 RID: 43570 RVA: 0x003F369C File Offset: 0x003F189C
	public co4() : base("至Криогенная индукция")
	{
	}

	// Token: 0x0600AA33 RID: 43571 RVA: 0x003F36AC File Offset: 0x003F18AC
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600AA34 RID: 43572 RVA: 0x003F36B0 File Offset: 0x003F18B0
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600AA35 RID: 43573 RVA: 0x003F36B4 File Offset: 0x003F18B4
	public override object[] at()
	{
		return new object[]
		{
			l4.a(co4.a, false),
			Convert.ToInt32(co4.b * 100.0),
			Convert.ToInt32(co4.c * 100.0)
		};
	}

	// Token: 0x0600AA36 RID: 43574 RVA: 0x003F3710 File Offset: 0x003F1910
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(50, new Type[]
			{
				typeof(rs)
			}),
			new b6h(new Type[]
			{
				typeof(cmp),
				typeof(e7j)
			})
		};
	}

	// Token: 0x04003FB7 RID: 16311
	public new static readonly int a = 1;

	// Token: 0x04003FB8 RID: 16312
	public new static readonly double b = 0.5;

	// Token: 0x04003FB9 RID: 16313
	public static readonly double c = 0.3;
}
