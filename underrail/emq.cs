using System;
using System.Collections.Generic;

// Token: 0x02001C1E RID: 7198
[d29("CheapShots", "Cheap Shots")]
public sealed class emq : ai8
{
	// Token: 0x06009E15 RID: 40469 RVA: 0x003E1574 File Offset: 0x003DF774
	public emq() : base("膶Грязные приёмы")
	{
	}

	// Token: 0x06009E16 RID: 40470 RVA: 0x003E1584 File Offset: 0x003DF784
	public override object[] at()
	{
		return new object[]
		{
			(int)(emq.a * 100.0),
			(int)(emq.b * 100.0),
			l4.a(emq.c, false)
		};
	}

	// Token: 0x06009E17 RID: 40471 RVA: 0x003E15D8 File Offset: 0x003DF7D8
	public override List<d3e> cy(efk A_0)
	{
		if (A_0.Offense.u() != null && A_0.Offense.u().TypedDefinition != null && A_0.Offense.u().TypedDefinition.e() == btz.g)
		{
			return new List<d3e>
			{
				new cex((float)(emq.a + (double)A_0.GetSpecializationValue<d34>(true) * d34.a))
			};
		}
		return null;
	}

	// Token: 0x06009E18 RID: 40472 RVA: 0x003E164C File Offset: 0x003DF84C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 6),
			new awr(typeof(av8), 5),
			new bap(40, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x04003D51 RID: 15697
	public new static readonly double a = 0.5;

	// Token: 0x04003D52 RID: 15698
	public new static readonly double b = 0.08;

	// Token: 0x04003D53 RID: 15699
	public static readonly int c = 1;
}
