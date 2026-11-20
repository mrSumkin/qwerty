using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B95 RID: 2965
[eiz("XPBLHCDSFHJ")]
[Serializable]
public sealed class ele : cze, ISerializable
{
	// Token: 0x06004383 RID: 17283 RVA: 0x001A720C File Offset: 0x001A540C
	private ele(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004384 RID: 17284 RVA: 0x001A7218 File Offset: 0x001A5418
	public ele()
	{
	}

	// Token: 0x06004385 RID: 17285 RVA: 0x001A7224 File Offset: 0x001A5424
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.ge)
					{
						cya aspect = d4n.b.a8().GetAspect<cya>();
						if (aspect != null && aspect.s() != "hive1")
						{
							aspect.p();
						}
					}
				}
			}
		}
	}
}
