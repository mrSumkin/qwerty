using System;
using System.Collections.Generic;

// Token: 0x02001CCF RID: 7375
[d29("Fend", "Fend")]
public sealed class dos : ai8
{
	// Token: 0x0600A1D6 RID: 41430 RVA: 0x003E816C File Offset: 0x003E636C
	public dos() : base("膘Отражение")
	{
	}

	// Token: 0x0600A1D7 RID: 41431 RVA: 0x003E817C File Offset: 0x003E637C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1D8 RID: 41432 RVA: 0x003E8184 File Offset: 0x003E6384
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1D9 RID: 41433 RVA: 0x003E8188 File Offset: 0x003E6388
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<b84>());
	}

	// Token: 0x0600A1DA RID: 41434 RVA: 0x003E819C File Offset: 0x003E639C
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<b84>());
	}

	// Token: 0x0600A1DB RID: 41435 RVA: 0x003E81B4 File Offset: 0x003E63B4
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(b84.c * 100.0),
			Convert.ToInt32(b84.d * 100.0),
			l4.a(b84.b, false)
		};
	}

	// Token: 0x0600A1DC RID: 41436 RVA: 0x003E8210 File Offset: 0x003E6410
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(dqg), 5),
			new bap(30, new Type[]
			{
				typeof(jk)
			})
		};
	}
}
