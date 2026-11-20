using System;
using System.Collections.Generic;

// Token: 0x02001DFB RID: 7675
[d29("AS", "Aimed Shot")]
public sealed class avk : ai8
{
	// Token: 0x0600A9E7 RID: 43495 RVA: 0x003F2B48 File Offset: 0x003F0D48
	public avk() : base("膀Прицельный выстрел")
	{
	}

	// Token: 0x0600A9E8 RID: 43496 RVA: 0x003F2B58 File Offset: 0x003F0D58
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A9E9 RID: 43497 RVA: 0x003F2B5C File Offset: 0x003F0D5C
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<e77>());
	}

	// Token: 0x0600A9EA RID: 43498 RVA: 0x003F2B70 File Offset: 0x003F0D70
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<e77>());
	}

	// Token: 0x0600A9EB RID: 43499 RVA: 0x003F2B84 File Offset: 0x003F0D84
	public override object[] at()
	{
		return new object[]
		{
			l4.a((double)e77.b, false)
		};
	}

	// Token: 0x0600A9EC RID: 43500 RVA: 0x003F2B9C File Offset: 0x003F0D9C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 6),
			new bap(10, new Type[]
			{
				typeof(ct7),
				typeof(e5n)
			})
		};
	}
}
