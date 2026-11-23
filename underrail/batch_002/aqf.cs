using System;
using System.Runtime.Serialization;

// Token: 0x02000A39 RID: 2617
[eiz("XPBLMUMAWLI")]
[Serializable]
public sealed class aqf : bdw, ISerializable
{
	// Token: 0x06003E17 RID: 15895 RVA: 0x00176064 File Offset: 0x00174264
	private aqf(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E18 RID: 15896 RVA: 0x0017606C File Offset: 0x0017426C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E19 RID: 15897 RVA: 0x00176070 File Offset: 0x00174270
	public aqf()
	{
	}

	// Token: 0x06003E1A RID: 15898 RVA: 0x0017607C File Offset: 0x0017427C
	public void av(c1a A_0, cyt A_1)
	{
		if ((A_1.r().GetPrimitivePropertyValue<bool>("npc_mu_wesley_passIntimidate", new bool?(false)).Value || A_1.r().GetPrimitivePropertyValue<bool>("loc_mu_pissedOff", new bool?(false)).Value || (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_mu_promiseToBringMedSupplies", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_md_foundPhilsBody", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_mu_gaveMedicine", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_mu_neverBroughMedSupplies", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_mu_repairedGenerator", new bool?(false)).Value)) && dh7.a != null && dh7.a.c != null && !dh7.a.c.StartsWith("xpbl_md"))
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("npc_mu_wesley_passIntimidate", new bool?(false)).Value || A_1.r().GetPrimitivePropertyValue<bool>("loc_mu_pissedOff", new bool?(false)).Value)
			{
				A_1.r()["loc_xpbl_mu_passIntimidate_expired"] = true;
			}
			else
			{
				A_1.r()["loc_xpbl_mu_neverBroughMedSupplies"] = true;
			}
			A_1.r()["npc_mu_wesley_passIntimidate"] = true;
			A_1.r()["loc_mu_allowedInside"] = false;
			A_1.r()["npc_mu_entrance_met"] = false;
		}
	}
}
