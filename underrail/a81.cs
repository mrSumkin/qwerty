using System;
using System.Runtime.Serialization;

// Token: 0x0200180B RID: 6155
[eiz("CODEXAA")]
[Serializable]
public sealed class a81 : cvd
{
	// Token: 0x060082CE RID: 33486 RVA: 0x0036D500 File Offset: 0x0036B700
	private a81(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060082CF RID: 33487 RVA: 0x0036D50C File Offset: 0x0036B70C
	public a81()
	{
	}

	// Token: 0x060082D0 RID: 33488 RVA: 0x0036D514 File Offset: 0x0036B714
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.aig().f() != null && base.aig().f().Zone != null && base.aig().f().h.b != null)
		{
			if (base.aig().e() != null && base.aig().e().b8() != null)
			{
				coh coh = base.aig().e().b8().Gear.l().Item;
				if (coh != null)
				{
					if (coh.Battery < (double)bem.e)
					{
						coh.Battery = 0.0;
						return dc4.e;
					}
					coh.a((double)bem.e, true);
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
