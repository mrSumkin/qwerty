using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020010E1 RID: 4321
[eiz("RRZ")]
[Serializable]
public sealed class dat : cze
{
	// Token: 0x06005B24 RID: 23332 RVA: 0x002734CC File Offset: 0x002716CC
	private dat(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005B25 RID: 23333 RVA: 0x002734D8 File Offset: 0x002716D8
	public dat()
	{
	}

	// Token: 0x06005B26 RID: 23334 RVA: 0x002734E4 File Offset: 0x002716E4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c1a c1a = Enumerable.FirstOrDefault<c1a>(bpo.GetServiceOrThrow<b4b>().yn().Zones);
		if (c1a != null)
		{
			foreach (aud aud in c1a.Areas)
			{
				List<c5x> list = new List<c5x>();
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Layer == aju.x && c5x.GetAspect<c4k>() != null)
					{
						list.Add(c5x);
					}
				}
				foreach (c5x c5x2 in list)
				{
					c5x2.w();
					c5x2.an();
				}
			}
		}
	}
}
