using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B61 RID: 2913
[eiz("RKL0")]
[Serializable]
public sealed class abc : cze, ISerializable
{
	// Token: 0x060042AD RID: 17069 RVA: 0x0019DE50 File Offset: 0x0019C050
	private abc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042AE RID: 17070 RVA: 0x0019DE5C File Offset: 0x0019C05C
	public abc()
	{
	}

	// Token: 0x060042AF RID: 17071 RVA: 0x0019DE68 File Offset: 0x0019C068
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			aud aud = serviceOrThrow.aqw().n("rkl1-a");
			if (aud != null)
			{
				for (int i = 14; i <= 23; i++)
				{
					for (int j = 12; j <= 22; j++)
					{
						ak1 ak = aud.b(i, j);
						if (ak != null)
						{
							foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
							{
								c5x c5x = (c5x)b0b;
								if (c5x.h.b != null && c5x.y8() == "Груда камней" && c5x.h.b.aa().Passive)
								{
									c5x.h.b.a(null, false);
								}
							}
						}
					}
				}
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("0ba9490f-9f8a-4529-9b04-88851f062030")).ao();
				cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("0ba9490f-9f8a-4529-9b04-88851f062030")).ao();
				if (d2b != null && cnb != null)
				{
					if (cnb.q())
					{
						cnb.a(null, null, false, false);
					}
					d2b.b(true, true);
				}
			}
		}
	}
}
