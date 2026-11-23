using System;
using System.Runtime.Serialization;

// Token: 0x020009CC RID: 2508
[eiz("FOAJIB")]
[Serializable]
public sealed class dhq : bdw, ISerializable
{
	// Token: 0x06003C2B RID: 15403 RVA: 0x001637C4 File Offset: 0x001619C4
	private dhq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C2C RID: 15404 RVA: 0x001637CC File Offset: 0x001619CC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C2D RID: 15405 RVA: 0x001637D0 File Offset: 0x001619D0
	public dhq()
	{
	}

	// Token: 0x06003C2E RID: 15406 RVA: 0x001637DC File Offset: 0x001619DC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null && A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_evelyn_seducedYa", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_evelyn_dies", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_evelyn_yellsThroughChute", new bool?(false)).Value)
		{
			if (A_0 != null)
			{
				aud aud = A_0.n("fo-bunker");
				if (aud != null)
				{
					c5x c5x = new ar7(new Guid("5a7fbbb5-a95f-4edd-891d-33ad3838dffc"), aud).ao() as c5x;
					if (c5x != null)
					{
						c0s aspect = c5x.GetAspect<c0s>();
						if (aspect != null)
						{
							aspect.a("Никуда не уходи, сладенький. Я скоро подойду.", true, null, null);
						}
					}
				}
			}
			A_1.r()["npc_fo_evelyn_yellsThroughChute"] = true;
		}
	}
}
