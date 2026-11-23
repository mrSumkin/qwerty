using System;
using System.Collections.Generic;

// Token: 0x02001CA3 RID: 7331
[d29("SteadfastAim", "Steadfast Aim")]
public sealed class dnd : ai8
{
	// Token: 0x0600A0B0 RID: 41136 RVA: 0x003E60A0 File Offset: 0x003E42A0
	public dnd() : base("胶Уверенный прицел")
	{
	}

	// Token: 0x0600A0B1 RID: 41137 RVA: 0x003E60B0 File Offset: 0x003E42B0
	public override object[] at()
	{
		return new object[]
		{
			Math.Round(dnd.b * 100.0, 1),
			dnd.a
		};
	}

	// Token: 0x0600A0B2 RID: 41138 RVA: 0x003E60E4 File Offset: 0x003E42E4
	public override List<d3e> cy(efk A_0)
	{
		List<d3e> list = new List<d3e>();
		if (A_0 != null && A_0.Offense.u().TypedDefinition.e() == btz.a && A_0.Offense.u().TypedDefinition.v() > dnd.a)
		{
			int num = A_0.Offense.u().TypedDefinition.v() - dnd.a;
			double num2 = dnd.b + (double)A_0.GetSpecializationValue<d2z>(true) * d2z.a;
			list.Add(new dvq((double)num * num2, cs5.a));
		}
		return list;
	}

	// Token: 0x0600A0B3 RID: 41139 RVA: 0x003E6178 File Offset: 0x003E4378
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 5),
			new awr(typeof(cwu), 6),
			new bap(25, new Type[]
			{
				typeof(ct7)
			})
		};
	}

	// Token: 0x04003DE3 RID: 15843
	public new static readonly int a = 10;

	// Token: 0x04003DE4 RID: 15844
	public new static readonly double b = 0.005;
}
