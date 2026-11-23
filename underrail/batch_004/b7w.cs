using System;
using System.Runtime.Serialization;

// Token: 0x020009EB RID: 2539
[eiz("XPBLCVWSDND")]
[Serializable]
public sealed class b7w : bdw, ISerializable
{
	// Token: 0x06003CB4 RID: 15540 RVA: 0x001686B0 File Offset: 0x001668B0
	private b7w(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CB5 RID: 15541 RVA: 0x001686B8 File Offset: 0x001668B8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CB6 RID: 15542 RVA: 0x001686BC File Offset: 0x001668BC
	public b7w()
	{
	}

	// Token: 0x06003CB7 RID: 15543 RVA: 0x001686C8 File Offset: 0x001668C8
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			string classPropertyValue = A_1.r().GetClassPropertyValue<string>("frag_xpbl_ww_dragNDrop_location");
			if (classPropertyValue != null && classPropertyValue.Equals(A_0.y8()) && !A_1.r().GetPrimitivePropertyValue<bool>("cvw_dnd_spawned", new bool?(false)).Value)
			{
				d60 d = A_0.a();
				if (d != null)
				{
					foreach (b0b b0b in d.ab4(new string[]
					{
						"frag_dnd_clear"
					}))
					{
						if (b0b != null)
						{
							b0b.w();
							b0b.an();
						}
					}
				}
				erb.a(serviceOrThrow.aqu(), serviceOrThrow.aqw(), "Xpbl_WW_PARTY", serviceOrThrow.aqw().g("DnDSpawn"));
				A_1.r()["cvw_dnd_spawned"] = true;
			}
		}
	}
}
