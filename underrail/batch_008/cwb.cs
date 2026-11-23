using System;
using System.Runtime.Serialization;

// Token: 0x0200099B RID: 2459
[eiz("SGSME")]
[Serializable]
public sealed class cwb : bdw, ISerializable
{
	// Token: 0x06003B68 RID: 15208 RVA: 0x0015FCF8 File Offset: 0x0015DEF8
	private cwb(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B69 RID: 15209 RVA: 0x0015FD00 File Offset: 0x0015DF00
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B6A RID: 15210 RVA: 0x0015FD04 File Offset: 0x0015DF04
	public cwb()
	{
	}

	// Token: 0x06003B6B RID: 15211 RVA: 0x0015FD0C File Offset: 0x0015DF0C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("MushroomCoveNE");
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_mcne_removeMordre", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("watch_quest_sgsMurder_MordreConfessedMurder", new bool?(false)).Value)
			{
				c5x c5x = new ar7(new Guid("bad8f763-91ac-4ae0-9c9b-bfc937c5dff1"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
				serviceOrThrow.aqu().r()["loc_mcne_removeMordre"] = true;
			}
		}
	}
}
