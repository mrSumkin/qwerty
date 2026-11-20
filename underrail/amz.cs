using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000B06 RID: 2822
[eiz("XPBLSZCJ")]
[Serializable]
public sealed class amz : cze, ISerializable
{
	// Token: 0x06004156 RID: 16726 RVA: 0x0018FAA4 File Offset: 0x0018DCA4
	private amz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004157 RID: 16727 RVA: 0x0018FAB0 File Offset: 0x0018DCB0
	public amz()
	{
	}

	// Token: 0x06004158 RID: 16728 RVA: 0x0018FABC File Offset: 0x0018DCBC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_sormirbaren_king_dead", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_sormirbaren_fireChieftain_dead", new bool?(false)).Value;
			bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_sormirbaren_boneChieftain_dead", new bool?(false)).Value;
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_b12_temple_shadowlithFragmentDestroyed", new bool?(false)).Value || (value && value2 && value3))
			{
				serviceOrThrow.aqu().r()["faction_xpbl_sormirbaren_defeated"] = true;
			}
			string name = "loc_" + serviceOrThrow.aqw().y8() + "_sormirbarenCleared";
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.fx)
					{
						return;
					}
				}
				int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_sormirbaren_zonesCleared", new int?(0)).Value;
				serviceOrThrow.aqu().r()[name] = true;
				serviceOrThrow.aqu().r()["faction_xpbl_sormirbaren_zonesCleared"] = ++num;
				bu6 service2 = bpo.GetService<bu6>();
				int num2 = 7;
				if (service2 != null)
				{
					if (service2.aq2() >= GameDifficulty.Hard)
					{
						num2 = 8;
					}
					else if (service2.aq2() == GameDifficulty.Easy)
					{
						num2 = 6;
					}
				}
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_sormirbaren_defeated", new bool?(false)).Value && num >= num2)
				{
					serviceOrThrow.aqu().r()["faction_xpbl_sormirbaren_defeated"] = true;
				}
			}
		}
	}
}
