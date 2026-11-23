using System;
using System.Runtime.Serialization;

// Token: 0x02001470 RID: 5232
[eiz("T02")]
[Serializable]
public sealed class eam : cvd
{
	// Token: 0x06007623 RID: 30243 RVA: 0x0031EA38 File Offset: 0x0031CC38
	private eam(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007624 RID: 30244 RVA: 0x0031EA44 File Offset: 0x0031CC44
	public eam()
	{
	}

	// Token: 0x06007625 RID: 30245 RVA: 0x0031EA50 File Offset: 0x0031CC50
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.aig().f() != null && base.aig().f().Zone != null && base.aig().f().h.b != null)
		{
			if (base.aig().e() != null)
			{
				coh coh = base.aig().e().b9() as coh;
				if (coh != null)
				{
					base.aig().f().c().a(Guid.NewGuid().ToString(), "ElectricTorchActivate", 1f, c9z.a, false, false);
					double c = c5c.c;
					if (c > 0.0)
					{
						if (coh.Battery < c)
						{
							coh.Battery = 0.0;
							return dc4.e;
						}
						coh.Battery -= c;
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
