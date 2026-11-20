using System;
using System.Runtime.Serialization;

// Token: 0x020016C9 RID: 5833
[eiz("T03")]
[Serializable]
public sealed class ex6 : cvd
{
	// Token: 0x06007F13 RID: 32531 RVA: 0x0035C4FC File Offset: 0x0035A6FC
	private ex6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F14 RID: 32532 RVA: 0x0035C508 File Offset: 0x0035A708
	public ex6()
	{
	}

	// Token: 0x06007F15 RID: 32533 RVA: 0x0035C510 File Offset: 0x0035A710
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.aig().f() != null && base.aig().f().Zone != null && base.aig().f().h.b != null)
		{
			if (base.aig().e() != null && base.aig().e().b8() != null)
			{
				coh coh = base.aig().e().b8().Gear.g().Item;
				if (coh != null)
				{
					base.aig().f().c().a(Guid.NewGuid().ToString(), "HeadlightActivate", 1f, c9z.a, false, false);
					double num = qa.d(base.aig().e());
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
