using System;
using System.Runtime.Serialization;

// Token: 0x02000935 RID: 2357
[eiz("SGSSSL")]
[Serializable]
public sealed class cpv : bdw, ISerializable
{
	// Token: 0x060039CA RID: 14794 RVA: 0x00155C0C File Offset: 0x00153E0C
	private cpv(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039CB RID: 14795 RVA: 0x00155C14 File Offset: 0x00153E14
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039CC RID: 14796 RVA: 0x00155C18 File Offset: 0x00153E18
	public cpv()
	{
	}

	// Token: 0x060039CD RID: 14797 RVA: 0x00155C24 File Offset: 0x00153E24
	public void av(c1a A_0, cyt A_1)
	{
		string a_ = "SvanasFerry";
		string text = "sgs_svanasFerry";
		bool value = A_1.r().GetPrimitivePropertyValue<bool>("npc_sgs_svana_sailToForsakenIsland", new bool?(false)).Value;
		bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("npc_sgs_svana_returnedFromForsakenIsland", new bool?(false)).Value;
		bool value3 = A_1.r().GetPrimitivePropertyValue<bool>("npc_sgs_svana_ferryRemoveFromForsaken", new bool?(false)).Value;
		bool value4 = A_1.r().GetPrimitivePropertyValue<bool>("npc_sgs_svana_ferryRemoveFromSgs", new bool?(false)).Value;
		bool value5 = A_1.r().GetPrimitivePropertyValue<bool>("npc_sgs_svana_dead", new bool?(false)).Value;
		bool value6 = A_1.r().GetPrimitivePropertyValue<bool>("npc_sgs_svana_ferrySetStart", new bool?(false)).Value;
		bool value7 = A_1.r().GetPrimitivePropertyValue<bool>("npc_sgs_svana_ferryIsOnForsaken", new bool?(false)).Value;
		if (!value6 && A_0.y8() == "StationAlpha-Level9b")
		{
			erb.a(A_1, A_0, text, A_0.g(a_));
			A_1.r()["npc_sgs_svana_ferrySetStart"] = true;
		}
		if (A_0.y8() == "jgi1")
		{
			if (value3)
			{
				erb.a(text, A_0.g(a_));
				A_1.r()["npc_sgs_svana_ferryRemoveFromForsaken"] = false;
			}
			if (!value5 && value && !value7)
			{
				erb.a(A_1, A_0, text, A_0.g(a_));
				A_1.r()["npc_sgs_svana_ferryRemoveFromSgs"] = true;
				A_1.r()["npc_sgs_svana_ferryIsOnForsaken"] = true;
				return;
			}
		}
		else
		{
			if (value4)
			{
				erb.a(text, A_0.g(a_));
				A_1.r()["npc_sgs_svana_ferryRemoveFromSgs"] = false;
			}
			if (value7 && !value5 && value2)
			{
				erb.a(A_1, A_0, text, A_0.g(a_));
				A_1.r()["npc_sgs_svana_ferryRemoveFromForsaken"] = true;
				A_1.r()["npc_sgs_svana_ferryIsOnForsaken"] = false;
			}
		}
	}
}
