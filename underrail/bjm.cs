using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200098B RID: 2443
[eiz("UPDRSIHD")]
[Serializable]
public sealed class bjm : bdw, ISerializable
{
	// Token: 0x06003B28 RID: 15144 RVA: 0x0015EEE8 File Offset: 0x0015D0E8
	private bjm(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B29 RID: 15145 RVA: 0x0015EEF0 File Offset: 0x0015D0F0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B2A RID: 15146 RVA: 0x0015EEF4 File Offset: 0x0015D0F4
	public bjm()
	{
	}

	// Token: 0x06003B2B RID: 15147 RVA: 0x0015EF00 File Offset: 0x0015D100
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (A_0.n("up10") != null && (serviceOrThrow != null & serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_up10_renegade_killed", new int?(0)).Value < 2) && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_up_holloway_dead", new bool?(false)).Value)
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
					{
						if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.br)
						{
							d4n.b.a8().w();
							d4n.b.a8().an();
						}
					}
				}
			}
		}
	}
}
