using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A36 RID: 2614
[eiz("XPHWEXOBVE")]
[Serializable]
public sealed class dju : bdw, ISerializable
{
	// Token: 0x06003E0B RID: 15883 RVA: 0x0017593C File Offset: 0x00173B3C
	private dju(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E0C RID: 15884 RVA: 0x00175944 File Offset: 0x00173B44
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E0D RID: 15885 RVA: 0x00175948 File Offset: 0x00173B48
	public dju()
	{
	}

	// Token: 0x06003E0E RID: 15886 RVA: 0x00175954 File Offset: 0x00173B54
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				bdm bdm = Enumerable.FirstOrDefault<bdm>(c5x.h.b.aa().StatusEffects.Get<bdm>());
				if (bdm != null)
				{
					c5x.h.b.aa().StatusEffects.d(bdm);
				}
				cwy cwy = Enumerable.FirstOrDefault<cwy>(c5x.h.b.aa().StatusEffects.Get<cwy>());
				if (cwy != null)
				{
					c5x.h.b.aa().StatusEffects.d(cwy);
				}
				c5x.h.b.aa().az();
				List<coh> classPropertyValue = c5x.h.b.aa().CustomProperties.GetClassPropertyValue<List<coh>>("VoidBag");
				if (classPropertyValue != null)
				{
					c5x.h.b.aa().Bag.z2().AddRange(classPropertyValue);
				}
			}
		}
	}
}
