using System;
using System.Runtime.Serialization;

// Token: 0x02001485 RID: 5253
[eiz("T11")]
[Serializable]
public sealed class sb : cvd
{
	// Token: 0x06007673 RID: 30323 RVA: 0x00321B28 File Offset: 0x0031FD28
	private sb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007674 RID: 30324 RVA: 0x00321B34 File Offset: 0x0031FD34
	public sb()
	{
	}

	// Token: 0x06007675 RID: 30325 RVA: 0x00321B40 File Offset: 0x0031FD40
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.aig().f() != null && base.aig().f().Zone != null && base.aig().f().h.b != null)
		{
			if (base.aig().e() != null)
			{
				coh coh = base.aig().e().b9() as coh;
				if (coh != null)
				{
					double num = sk.a(coh);
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
