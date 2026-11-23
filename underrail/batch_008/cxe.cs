using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000922 RID: 2338
[eiz("CCTALM")]
[Serializable]
public sealed class cxe : bdw, ISerializable
{
	// Token: 0x06003977 RID: 14711 RVA: 0x001538E8 File Offset: 0x00151AE8
	private cxe(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003978 RID: 14712 RVA: 0x001538F0 File Offset: 0x00151AF0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003979 RID: 14713 RVA: 0x001538F4 File Offset: 0x00151AF4
	public cxe()
	{
	}

	// Token: 0x0600397A RID: 14714 RVA: 0x00153900 File Offset: 0x00151B00
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null && A_1.r().GetPrimitivePropertyValue<bool>("npc_cc_vlatko_payedRepairs", new bool?(false)).Value)
		{
			A_1.r()["npc_cc_vlatko_allowSecondFloorPass"] = false;
		}
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_tm1");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("fa38132c-d916-4037-95a4-8a57c12bf85d")).ao();
				d2b d2b2 = new EntityAspectReference<d2b, d2b>(aud, new Guid("838d0181-f00e-4063-9779-f0d102c3465d")).ao();
				if (d2b != null && d2b2 != null)
				{
					bool value = A_1.r().GetPrimitivePropertyValue<bool>("loc_tm_sideEntranceUnlocked", new bool?(false)).Value;
					d2b.e(!value);
					d2b2.e(!value);
				}
			}
		}
	}
}
