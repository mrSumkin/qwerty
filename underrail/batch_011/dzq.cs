using System;
using System.Collections.Generic;

// Token: 0x02001DFC RID: 7676
[d29("A", "Assassinate")]
public sealed class dzq : ai8
{
	// Token: 0x0600A9ED RID: 43501 RVA: 0x003F2BF4 File Offset: 0x003F0DF4
	public dzq() : base("Ассасинатор")
	{
	}

	// Token: 0x0600A9EE RID: 43502 RVA: 0x003F2C04 File Offset: 0x003F0E04
	public override bool ae6()
	{
		return false;
	}

	// Token: 0x0600A9EF RID: 43503 RVA: 0x003F2C08 File Offset: 0x003F0E08
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A9F0 RID: 43504 RVA: 0x003F2C0C File Offset: 0x003F0E0C
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A9F1 RID: 43505 RVA: 0x003F2C10 File Offset: 0x003F0E10
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600A9F2 RID: 43506 RVA: 0x003F2C18 File Offset: 0x003F0E18
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 9),
			new bap(45, new Type[]
			{
				typeof(ct7),
				typeof(e5n)
			}),
			new b4k(new Type[]
			{
				typeof(bbn)
			})
		};
	}

	// Token: 0x0600A9F3 RID: 43507 RVA: 0x003F2C90 File Offset: 0x003F0E90
	public override object[] at()
	{
		return new object[]
		{
			(int)(dzq.a * 100.0)
		};
	}

	// Token: 0x04003FA6 RID: 16294
	public new static readonly double a = 0.5;
}
