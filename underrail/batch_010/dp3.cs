using System;
using System.Collections.Generic;

// Token: 0x02001CA0 RID: 7328
[d29("QuickTinkering", "Quick Tinkering")]
public sealed class dp3 : ai8
{
	// Token: 0x0600A09F RID: 41119 RVA: 0x003E5E38 File Offset: 0x003E4038
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A0A0 RID: 41120 RVA: 0x003E5E3C File Offset: 0x003E403C
	public dp3() : base("膊Быстрый взвод")
	{
	}

	// Token: 0x0600A0A1 RID: 41121 RVA: 0x003E5E4C File Offset: 0x003E404C
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<dx0>());
	}

	// Token: 0x0600A0A2 RID: 41122 RVA: 0x003E5E60 File Offset: 0x003E4060
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<dx0>());
	}

	// Token: 0x0600A0A3 RID: 41123 RVA: 0x003E5E74 File Offset: 0x003E4074
	public override object[] at()
	{
		return new object[]
		{
			dg1.a,
			l4.a(dx0.b, false)
		};
	}

	// Token: 0x0600A0A4 RID: 41124 RVA: 0x003E5E98 File Offset: 0x003E4098
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 7),
			new bap(25, new Type[]
			{
				typeof(c0b)
			})
		};
	}

	// Token: 0x04003DDC RID: 15836
	public new static readonly int a = 2;
}
