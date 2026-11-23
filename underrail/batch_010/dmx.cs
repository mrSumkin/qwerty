using System;
using System.Runtime.Serialization;

// Token: 0x02000959 RID: 2393
[eiz("PBRNU")]
[Serializable]
public sealed class dmx : bdw, ISerializable
{
	// Token: 0x06003A5E RID: 14942 RVA: 0x0015A1A4 File Offset: 0x001583A4
	private dmx(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A5F RID: 14943 RVA: 0x0015A1AC File Offset: 0x001583AC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A60 RID: 14944 RVA: 0x0015A1B0 File Offset: 0x001583B0
	public dmx()
	{
	}

	// Token: 0x06003A61 RID: 14945 RVA: 0x0015A1BC File Offset: 0x001583BC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0.n("pr-amb") != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null)
			{
				serviceOrThrow.aqu().r()["npc_pb_oliver_informPlayerWhatHappenedToRenegades"] = true;
			}
		}
	}
}
