using System;
using System.Runtime.Serialization;

// Token: 0x0200183C RID: 6204
[eiz("INDEXAA")]
[Serializable]
public sealed class bwu : cvd
{
	// Token: 0x0600844F RID: 33871 RVA: 0x00371AE8 File Offset: 0x0036FCE8
	private bwu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008450 RID: 33872 RVA: 0x00371AF4 File Offset: 0x0036FCF4
	public bwu()
	{
	}

	// Token: 0x06008451 RID: 33873 RVA: 0x00371B00 File Offset: 0x0036FD00
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.aig().f() != null && base.aig().f().Zone != null && base.aig().f().h.b != null)
		{
			if (base.aig().e() != null && base.aig().e().b8() != null)
			{
				coh coh = base.aig().e().b8().Gear.l().Item;
				if (coh != null)
				{
					if (coh.Battery < (double)e6v.e)
					{
						coh.Battery = 0.0;
						return dc4.e;
					}
					coh.a((double)e6v.e, true);
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
