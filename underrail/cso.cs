using System;
using System.Collections.Generic;

// Token: 0x02001CCD RID: 7373
[d29("Impale", "Impale")]
public sealed class cso : ai8
{
	// Token: 0x0600A1C9 RID: 41417 RVA: 0x003E8010 File Offset: 0x003E6210
	public cso() : base("膚Пронзение")
	{
	}

	// Token: 0x0600A1CA RID: 41418 RVA: 0x003E8020 File Offset: 0x003E6220
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1CB RID: 41419 RVA: 0x003E8028 File Offset: 0x003E6228
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1CC RID: 41420 RVA: 0x003E802C File Offset: 0x003E622C
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<e21>());
	}

	// Token: 0x0600A1CD RID: 41421 RVA: 0x003E8040 File Offset: 0x003E6240
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<e21>());
	}

	// Token: 0x0600A1CE RID: 41422 RVA: 0x003E8054 File Offset: 0x003E6254
	public override object[] at()
	{
		return new object[]
		{
			l4.a(e21.b, false)
		};
	}

	// Token: 0x0600A1CF RID: 41423 RVA: 0x003E8070 File Offset: 0x003E6270
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
