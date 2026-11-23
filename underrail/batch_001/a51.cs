using System;
using System.Runtime.Serialization;

// Token: 0x02001488 RID: 5256
[eiz("T01")]
[Serializable]
public sealed class a51 : cvd
{
	// Token: 0x0600767C RID: 30332 RVA: 0x003221E4 File Offset: 0x003203E4
	private a51(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600767D RID: 30333 RVA: 0x003221F0 File Offset: 0x003203F0
	public a51()
	{
	}

	// Token: 0x0600767E RID: 30334 RVA: 0x003221FC File Offset: 0x003203FC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.aig().f() != null && base.aig().f().Zone != null && base.aig().f().h.b != null)
		{
			if (base.aig().e() != null)
			{
				coh coh = base.aig().e().b9() as coh;
				if (coh != null)
				{
					double num = bzd.a(coh);
					if (num > 0.0)
					{
						if (coh.Battery < num)
						{
							coh.Battery = 0.0;
							return dc4.e;
						}
						coh.Battery -= num;
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
