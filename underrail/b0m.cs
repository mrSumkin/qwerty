using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A28 RID: 2600
[eiz("DUNWWECR")]
[Serializable]
public sealed class b0m : bdw, ISerializable
{
	// Token: 0x06003DC5 RID: 15813 RVA: 0x00172E64 File Offset: 0x00171064
	private b0m(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DC6 RID: 15814 RVA: 0x00172E6C File Offset: 0x0017106C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DC7 RID: 15815 RVA: 0x00172E70 File Offset: 0x00171070
	public b0m()
	{
	}

	// Token: 0x06003DC8 RID: 15816 RVA: 0x00172E7C File Offset: 0x0017107C
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetClassPropertyValue<string>("frag_dun_wasteWater_type") != null && serviceOrThrow.aqu().r().GetClassPropertyValue<string>("frag_dun_wasteWater_type") == "edison")
		{
			foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.y8() == "electrocutionEffect")
					{
						bkt.a(c5x);
						ak1 ak = Enumerable.FirstOrDefault<ak1>(c5x.l);
						if (ak != null)
						{
							foreach (bqt bqt in Enumerable.ToList<bqt>(ak.TriggerProxies))
							{
								if (bqt.Trigger is a7c)
								{
									bqt.Trigger.o();
								}
							}
						}
						c5x.w();
						c5x.an();
					}
				}
			}
		}
	}
}
