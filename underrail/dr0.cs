using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B98 RID: 2968
[eiz("XPBLAASITZ")]
[Serializable]
public sealed class dr0 : cze, ISerializable
{
	// Token: 0x0600438E RID: 17294 RVA: 0x001A7A40 File Offset: 0x001A5C40
	private dr0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600438F RID: 17295 RVA: 0x001A7A4C File Offset: 0x001A5C4C
	public dr0()
	{
	}

	// Token: 0x06004390 RID: 17296 RVA: 0x001A7A58 File Offset: 0x001A5C58
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			foreach (aud aud in Enumerable.ToList<aud>(serviceOrThrow.aqw().Areas))
			{
				dqs dqs = new dqs();
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.y8() == "Statue" && c5x.GetAspect<dg2>() != null)
					{
						dqs.a(aud.y8());
						dqs.a(new Guid?(c5x.qe()));
						dqs.ym(A_0, A_1, null);
					}
				}
			}
		}
	}
}
