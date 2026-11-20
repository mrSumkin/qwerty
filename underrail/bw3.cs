using System;
using System.Collections.Generic;

// Token: 0x02001CA4 RID: 7332
[d29("ExposeWeakness", "Expose Weakness")]
public sealed class bw3 : ai8
{
	// Token: 0x0600A0B5 RID: 41141 RVA: 0x003E61F0 File Offset: 0x003E43F0
	public bw3() : base("膸Раскрыть уязвимость")
	{
	}

	// Token: 0x0600A0B6 RID: 41142 RVA: 0x003E6200 File Offset: 0x003E4400
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<csr>());
	}

	// Token: 0x0600A0B7 RID: 41143 RVA: 0x003E6214 File Offset: 0x003E4414
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<csr>());
	}

	// Token: 0x0600A0B8 RID: 41144 RVA: 0x003E622C File Offset: 0x003E442C
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(csr.b * 100.0),
			Convert.ToInt32(csr.c * 100.0),
			l4.a(csr.d, false),
			l4.a(csr.e, false)
		};
	}

	// Token: 0x0600A0B9 RID: 41145 RVA: 0x003E6294 File Offset: 0x003E4494
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(40, new Type[]
			{
				typeof(jk)
			}),
			new awr(typeof(av8), 5)
		};
	}
}
