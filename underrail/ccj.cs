using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B07 RID: 2823
[eiz("XPBLPZCJ")]
[Serializable]
public sealed class ccj : cze, ISerializable
{
	// Token: 0x06004159 RID: 16729 RVA: 0x0018FD68 File Offset: 0x0018DF68
	private ccj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600415A RID: 16730 RVA: 0x0018FD74 File Offset: 0x0018DF74
	public ccj()
	{
	}

	// Token: 0x0600415B RID: 16731 RVA: 0x0018FD80 File Offset: 0x0018DF80
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null)
		{
			string name = "loc_" + serviceOrThrow.aqw().y8() + "_piratesCleared";
			string name2 = "loc_" + serviceOrThrow.aqw().y8() + "_aegisCleared";
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value || (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_portCeto_underAttack", new bool?(false)).Value && (serviceOrThrow.aqw().y8().Contains("e3") || serviceOrThrow.aqw().y8().Contains("f3") || serviceOrThrow.aqw().y8().Contains("g3"))))
			{
				bool flag = false;
				bool flag2 = false;
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead)
					{
						if (d4n.b.aa().FactionId == asp.fr || d4n.b.aa().FactionId == asp.fs || d4n.b.aa().FactionId == asp.ft || d4n.b.aa().FactionId == asp.fu)
						{
							flag = true;
							if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_portCeto_underAttack", new bool?(false)).Value)
							{
								return;
							}
						}
						else if (d4n.b.aa().FactionId == asp.f5)
						{
							flag2 = true;
						}
					}
				}
				if (!flag && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value)
				{
					int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_pirates_zonesCleared", new int?(0)).Value;
					serviceOrThrow.aqu().r()[name] = true;
					serviceOrThrow.aqu().r()["faction_xpbl_pirates_zonesCleared"] = ++num;
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && num > 7)
					{
						serviceOrThrow.aqu().r()["faction_xpbl_pirates_defeated"] = true;
					}
				}
				if ((serviceOrThrow.aqw().y8().Contains("e3") || serviceOrThrow.aqw().y8().Contains("f3") || (serviceOrThrow.aqw().y8().Contains("g3") && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_portCeto_underAttack", new bool?(false)).Value)) && !flag2 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name2, new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()[name2] = true;
					int num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_portCeto_numberOfAegisAttackedZonesCleared", new int?(0)).Value;
					serviceOrThrow.aqu().r()["loc_xpbl_portCeto_numberOfAegisAttackedZonesCleared"] = ++num2;
					if (num2 >= 3)
					{
						serviceOrThrow.aqu().r()["loc_xpbl_portCeto_aegisAttackersCleared"] = true;
					}
				}
			}
		}
	}
}
