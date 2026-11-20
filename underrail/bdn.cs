using System;
using System.Collections.Generic;

// Token: 0x02001CC9 RID: 7369
[d29("Decapitate", "Decapitate")]
public sealed class bdn : ai8
{
	// Token: 0x0600A1AF RID: 41391 RVA: 0x003E7C74 File Offset: 0x003E5E74
	public bdn() : base("膥Обезглавливание")
	{
	}

	// Token: 0x0600A1B0 RID: 41392 RVA: 0x003E7C84 File Offset: 0x003E5E84
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1B1 RID: 41393 RVA: 0x003E7C8C File Offset: 0x003E5E8C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1B2 RID: 41394 RVA: 0x003E7C90 File Offset: 0x003E5E90
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<bwh>());
	}

	// Token: 0x0600A1B3 RID: 41395 RVA: 0x003E7CA4 File Offset: 0x003E5EA4
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<bwh>());
	}

	// Token: 0x0600A1B4 RID: 41396 RVA: 0x003E7CBC File Offset: 0x003E5EBC
	public override object[] at()
	{
		return new object[]
		{
			(int)(bwh.d * 100.0),
			(int)(bwh.c * 100.0),
			l4.a(bwh.b, false)
		};
	}

	// Token: 0x0600A1B5 RID: 41397 RVA: 0x003E7D10 File Offset: 0x003E5F10
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 7),
			new bap(40, new Type[]
			{
				typeof(jk)
			})
		};
	}
}
