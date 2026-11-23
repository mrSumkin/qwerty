using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020009A4 RID: 2468
[eiz("LUPCIFDEIC")]
[Serializable]
public sealed class ai0 : bdw, ISerializable
{
	// Token: 0x06003B8C RID: 15244 RVA: 0x0016091C File Offset: 0x0015EB1C
	private ai0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B8D RID: 15245 RVA: 0x00160924 File Offset: 0x0015EB24
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B8E RID: 15246 RVA: 0x00160928 File Offset: 0x0015EB28
	public ai0()
	{
	}

	// Token: 0x06003B8F RID: 15247 RVA: 0x00160934 File Offset: 0x0015EB34
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lup-b3");
			if (aud != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interface_lup_freeDroneIntercom_enter", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_prmutation_mutagenPlaced", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_fd_trenton_dead", new bool?(false)).Value)
				{
					cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("9694fc15-760f-471a-8e70-77429b1ccaf3")).ao();
					if (cnb != null && cnb.q())
					{
						cnb.d(false);
					}
				}
			}
		}
	}
}
