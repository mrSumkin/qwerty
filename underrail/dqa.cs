using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B96 RID: 2966
[eiz("XPBLSCAFFSJ")]
[Serializable]
public sealed class dqa : cze, ISerializable
{
	// Token: 0x06004386 RID: 17286 RVA: 0x001A7338 File Offset: 0x001A5538
	private dqa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004387 RID: 17287 RVA: 0x001A7344 File Offset: 0x001A5544
	public dqa()
	{
	}

	// Token: 0x06004388 RID: 17288 RVA: 0x001A7350 File Offset: 0x001A5550
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			aud aud = serviceOrThrow.aqw().n("xpbl_sc");
			if (aud != null)
			{
				dqs dqs = new dqs();
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.y8() == "Statue" && !c5x.a("noCameraActivation") && c5x.GetAspect<dg2>() != null)
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
