using System;
using System.Collections.Generic;

// Token: 0x02001C9D RID: 7325
[d29("Eviscerate", "Eviscerate")]
public sealed class lx : ai8
{
	// Token: 0x0600A08F RID: 41103 RVA: 0x003E5BFC File Offset: 0x003E3DFC
	public lx() : base("膫Мясорубка")
	{
	}

	// Token: 0x0600A090 RID: 41104 RVA: 0x003E5C0C File Offset: 0x003E3E0C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A091 RID: 41105 RVA: 0x003E5C10 File Offset: 0x003E3E10
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<bhw>());
	}

	// Token: 0x0600A092 RID: 41106 RVA: 0x003E5C24 File Offset: 0x003E3E24
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<bhw>());
	}

	// Token: 0x0600A093 RID: 41107 RVA: 0x003E5C38 File Offset: 0x003E3E38
	public override object[] at()
	{
		return new object[]
		{
			(int)(bhw.b * 100.0),
			l4.a(bhw.c, false)
		};
	}

	// Token: 0x0600A094 RID: 41108 RVA: 0x003E5C68 File Offset: 0x003E3E68
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 8),
			new bap(80, new Type[]
			{
				typeof(jk)
			})
		};
	}
}
