using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A05 RID: 2565
[eiz("XPBLG2MPSTAPDC")]
[Serializable]
public sealed class @do : bdw, ISerializable
{
	// Token: 0x06003D29 RID: 15657 RVA: 0x0016BD7C File Offset: 0x00169F7C
	private @do(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D2A RID: 15658 RVA: 0x0016BD84 File Offset: 0x00169F84
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D2B RID: 15659 RVA: 0x0016BD88 File Offset: 0x00169F88
	public @do()
	{
	}

	// Token: 0x06003D2C RID: 15660 RVA: 0x0016BD94 File Offset: 0x00169F94
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("xpbl_g2");
			if (aud != null)
			{
				List<coh> classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<List<coh>>("global_xpbl_playersItemsFromCampLocker");
				if (Enumerable.Any<coh>(classPropertyValue))
				{
					c5x c5x = new ar7(new Guid("082a4b25-d166-4e50-9421-b997501117c2"), aud).ao() as c5x;
					if (c5x != null)
					{
						c7j c7j = c5x.GetAspect<bim>() as c7j;
						if (c7j != null)
						{
							c7j.ItemContainer.z2().AddRange(classPropertyValue);
							serviceOrThrow.aqu().r().RemoveProperty("global_xpbl_playersItemsFromCampLocker");
						}
					}
				}
			}
		}
	}
}
