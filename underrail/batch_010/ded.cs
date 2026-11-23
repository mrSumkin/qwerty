using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A2E RID: 2606
[eiz("SGSPQF")]
[Serializable]
public sealed class ded : bdw, ISerializable
{
	// Token: 0x06003DEE RID: 15854 RVA: 0x00175138 File Offset: 0x00173338
	private ded(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DEF RID: 15855 RVA: 0x00175140 File Offset: 0x00173340
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DF0 RID: 15856 RVA: 0x00175144 File Offset: 0x00173344
	public ded()
	{
	}

	// Token: 0x06003DF1 RID: 15857 RVA: 0x00175150 File Offset: 0x00173350
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && am9.d() && !A_1.r().GetPrimitivePropertyValue<bool>("npc_cc_jyles_movedFromSGSToCC", new bool?(false)).Value)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(A_0.n("StationAlpha-Level5").Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.Location.X >= 28f && c5x.Location.X <= 34f && c5x.Location.Y >= 18f && c5x.Location.Y <= 24f)
				{
					c7j c7j = c5x.GetAspect<bim>() as c7j;
					if (c7j != null && Enumerable.Any<coh>(c7j.ItemContainer.z2()))
					{
						A_1.r()["loc_sgs_playerRoom_hasItems"] = true;
						return;
					}
				}
			}
			A_1.r()["loc_sgs_playerRoom_hasItems"] = false;
		}
	}
}
