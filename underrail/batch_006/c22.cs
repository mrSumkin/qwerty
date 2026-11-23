using System;
using System.Collections.Generic;

// Token: 0x02001DEB RID: 7659
[d29("LightningPunches", "Lightning Punches")]
public sealed class c22 : ai8
{
	// Token: 0x0600A97D RID: 43389 RVA: 0x003F1D18 File Offset: 0x003EFF18
	public c22() : base("臁Молниеносные удары")
	{
	}

	// Token: 0x0600A97E RID: 43390 RVA: 0x003F1D28 File Offset: 0x003EFF28
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A97F RID: 43391 RVA: 0x003F1D2C File Offset: 0x003EFF2C
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A980 RID: 43392 RVA: 0x003F1D30 File Offset: 0x003EFF30
	public override object[] at()
	{
		return new object[]
		{
			c22.b,
			(int)(c22.a * 100f)
		};
	}

	// Token: 0x0600A981 RID: 43393 RVA: 0x003F1D5C File Offset: 0x003EFF5C
	public override List<d3e> cy(efk A_0)
	{
		List<d3e> list = new List<d3e>();
		if (A_0 != null && (euf.o(A_0.Offense.u()) || euf.n(A_0.Offense.u())))
		{
			bjo bjo = new bjo((float)(-(float)c22.b) * d0u.c, -c22.b, new List<btz>
			{
				btz.g
			})
			{
				Priority = int.MaxValue
			};
			bjo.Condition = new cqk((double)c22.a + (double)A_0.GetSpecializationValue<e35>(true) * e35.a - 0.0010000000474974513);
			list.Add(bjo);
		}
		return list;
	}

	// Token: 0x0600A982 RID: 43394 RVA: 0x003F1E04 File Offset: 0x003F0004
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 8),
			new bap(25, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x04003F86 RID: 16262
	public new static readonly float a = 0.2f;

	// Token: 0x04003F87 RID: 16263
	public new static readonly int b = 2;
}
