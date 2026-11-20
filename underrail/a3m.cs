using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020008D9 RID: 2265
[eiz("AINPP")]
[Serializable]
public class a3m : c13, ISerializable
{
	// Token: 0x06003851 RID: 14417 RVA: 0x0014DF68 File Offset: 0x0014C168
	private a3m(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003852 RID: 14418 RVA: 0x0014DF70 File Offset: 0x0014C170
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003853 RID: 14419 RVA: 0x0014DF74 File Offset: 0x0014C174
	public List<c5x> ok(string A_0, IEnumerable<csd> A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
		{
			int? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0));
			int num = 10;
			if (primitivePropertyValue.GetValueOrDefault() >= num & primitivePropertyValue != null)
			{
				primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_jetSkiStrength", new int?(0));
				num = 2;
				if (primitivePropertyValue.GetValueOrDefault() > num & primitivePropertyValue != null)
				{
					List<c5x> list = new List<c5x>();
					if (A_1 != null)
					{
						gx gx = new gx();
						foreach (csd a_ in A_1)
						{
							c5x c5x = gx.a(a_, new int?(10), "Aegis_Jetski", null, asp.f7, null, "support\\xpbl\\le_aegis", false, null, false);
							if (c5x != null)
							{
								list.Add(c5x);
							}
						}
					}
					return list;
				}
			}
		}
		return null;
	}

	// Token: 0x06003854 RID: 14420 RVA: 0x0014E104 File Offset: 0x0014C304
	public a3m()
	{
	}
}
