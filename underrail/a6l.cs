using System;
using System.Runtime.Serialization;

// Token: 0x020009B6 RID: 2486
[eiz("LUHRMWTTF")]
[Serializable]
public sealed class a6l : bdw, ISerializable
{
	// Token: 0x06003BD4 RID: 15316 RVA: 0x00161F84 File Offset: 0x00160184
	private a6l(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BD5 RID: 15317 RVA: 0x00161F8C File Offset: 0x0016018C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BD6 RID: 15318 RVA: 0x00161F90 File Offset: 0x00160190
	public a6l()
	{
	}

	// Token: 0x06003BD7 RID: 15319 RVA: 0x00161F9C File Offset: 0x0016019C
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && serviceOrThrow.aqu() != null)
		{
			aud aud = A_0.n("lux-b11");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("2b696b3c-8dca-4d6e-ab33-8283cf60c8b6"), aud).ao() as c5x;
				if (c5x != null)
				{
					bm6 aspect = c5x.GetAspect<bm6>();
					if (aspect != null)
					{
						if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_lux-b11_depressedMan_walkingToFence", new int?(0)).Value == 2)
						{
							aspect.y6()[ddq.ay] = new bt4("depressed4");
							serviceOrThrow.aqu().r()["npc_lux-b11_depressedMan_walkingToFence"] = 3;
						}
						if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_lux-b11_depressedMan_walkingToFence", new int?(0)).Value == 1)
						{
							aspect.y6()[ddq.ay] = new bt4("depressed3");
							serviceOrThrow.aqu().r()["npc_lux-b11_depressedMan_walkingToFence"] = 2;
						}
						if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_lux-b11_depressedMan_walkingToFence", new int?(0)).Value == 0)
						{
							aspect.y6()[ddq.ay] = new bt4("depressed2");
							serviceOrThrow.aqu().r()["npc_lux-b11_depressedMan_walkingToFence"] = 1;
						}
					}
				}
			}
		}
	}
}
