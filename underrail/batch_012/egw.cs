using System;
using System.Runtime.Serialization;

// Token: 0x0200092F RID: 2351
[eiz("CHDH")]
[Serializable]
public sealed class egw : bdw, ISerializable
{
	// Token: 0x060039B0 RID: 14768 RVA: 0x001550C8 File Offset: 0x001532C8
	private egw(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039B1 RID: 14769 RVA: 0x001550D0 File Offset: 0x001532D0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039B2 RID: 14770 RVA: 0x001550D4 File Offset: 0x001532D4
	public egw()
	{
	}

	// Token: 0x060039B3 RID: 14771 RVA: 0x001550E0 File Offset: 0x001532E0
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cv16");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (aud != null && serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_ch_hopsyDespawned", new bool?(false)).Value)
		{
			c5x c5x = new ar7(new Guid("dfb3dcd5-ef42-4f71-b575-1aa13ad6441f"), aud).ao() as c5x;
			if (c5x != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("HathorKingSituationResolved", new bool?(false)).Value)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_ch_sarine_captured", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_ch_beck_survivedTheBattle", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["loc_ch_hopsyDespawned"] = true;
					return;
				}
				c5x.w();
				c5x.an();
				serviceOrThrow.aqu().r()["loc_ch_hopsyDespawned"] = true;
			}
		}
	}
}
