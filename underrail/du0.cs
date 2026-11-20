using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000981 RID: 2433
[eiz("TCHSTU")]
[Serializable]
public sealed class du0 : bdw, ISerializable
{
	// Token: 0x06003AFF RID: 15103 RVA: 0x0015E034 File Offset: 0x0015C234
	private du0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B00 RID: 15104 RVA: 0x0015E03C File Offset: 0x0015C23C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B01 RID: 15105 RVA: 0x0015E040 File Offset: 0x0015C240
	public du0()
	{
	}

	// Token: 0x06003B02 RID: 15106 RVA: 0x0015E04C File Offset: 0x0015C24C
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("tch-util2");
			if (aud != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_util2_spawnedTheresa", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_player_sentAway", new bool?(false)).Value)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "tch-util2_l" + 2.ToString()) + ".uzl");
				aud.Zone.a(a_, 1, null);
				serviceOrThrow.aqu().r()["loc_tch_util2_spawnedTheresa"] = true;
				serviceOrThrow.aqu().r()["npc_tch_utilGuard_met"] = true;
			}
		}
	}
}
