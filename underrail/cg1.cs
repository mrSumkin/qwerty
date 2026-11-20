using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A2C RID: 2604
[eiz("CCUTWOCPOB")]
[Serializable]
public sealed class cg1 : bdw, ISerializable
{
	// Token: 0x06003DE6 RID: 15846 RVA: 0x00175008 File Offset: 0x00173208
	private cg1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DE7 RID: 15847 RVA: 0x00175010 File Offset: 0x00173210
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DE8 RID: 15848 RVA: 0x00175014 File Offset: 0x00173214
	public cg1()
	{
	}

	// Token: 0x06003DE9 RID: 15849 RVA: 0x00175020 File Offset: 0x00173220
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("cc_utility2_upHideout");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("956436d5-0764-4a8d-b6cc-83659f196771"), aud).ao() as c5x;
				if (c5x != null && c5x.h.b != null && Enumerable.FirstOrDefault<coh>(c5x.h.b.aa().Bag.b("plot.orangeBox")) == null)
				{
					A_1.r()["npc_forger_orangeBoxStolen"] = true;
				}
			}
		}
	}
}
