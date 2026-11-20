using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000969 RID: 2409
[eiz("DCSD")]
[Serializable]
public sealed class evq : bdw, ISerializable
{
	// Token: 0x06003A9E RID: 15006 RVA: 0x0015B7CC File Offset: 0x001599CC
	private evq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A9F RID: 15007 RVA: 0x0015B7D4 File Offset: 0x001599D4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AA0 RID: 15008 RVA: 0x0015B7D8 File Offset: 0x001599D8
	public evq()
	{
	}

	// Token: 0x06003AA1 RID: 15009 RVA: 0x0015B7E4 File Offset: 0x001599E4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null && A_0 != null)
		{
			aud aud = A_0.n("dc-mut3");
			if (aud != null)
			{
				bool value = A_1.r().GetPrimitivePropertyValue<bool>("npc_up_detritus_died", new bool?(false)).Value;
				bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("npc_up_detrius_convinceHimToJoin", new bool?(false)).Value;
				bool value3 = A_1.r().GetPrimitivePropertyValue<bool>("npc_up_detritus_spawnedDC", new bool?(false)).Value;
				bool value4 = A_1.r().GetPrimitivePropertyValue<bool>("quests_tch_rista_findHealthCompleted", new bool?(false)).Value;
				if (!value3 && (!value && value2 && value4))
				{
					doq a_ = doq.a(Path.Combine(d5x.q(), "dc-mut3_l2") + ".uzl");
					aud.Zone.a(a_, 1, null);
					A_1.r()["npc_up_detritus_spawnedDC"] = true;
				}
			}
		}
	}
}
