using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000953 RID: 2387
[eiz("LUSGAIH")]
[Serializable]
public sealed class bgw : bdw, ISerializable
{
	// Token: 0x06003A46 RID: 14918 RVA: 0x00159498 File Offset: 0x00157698
	private bgw(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A47 RID: 14919 RVA: 0x001594A0 File Offset: 0x001576A0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A48 RID: 14920 RVA: 0x001594A4 File Offset: 0x001576A4
	public bgw()
	{
	}

	// Token: 0x06003A49 RID: 14921 RVA: 0x001594B0 File Offset: 0x001576B0
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("lu-c6");
			if (aud != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu-c6_canSpawnGangstersAndIronheads", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu-c6_gangstersAndIronheadsSpawned", new bool?(false)).Value)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "lu-c6_l" + 2.ToString()) + ".uzl");
				aud.Zone.a(a_, 1, null);
				serviceOrThrow.aqu().r()["loc_lu-c6_gangstersAndIronheadsSpawned"] = true;
			}
		}
	}
}
