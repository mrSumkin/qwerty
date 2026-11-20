using System;
using System.Runtime.Serialization;

// Token: 0x02000978 RID: 2424
[eiz("PBRCAUA")]
[Serializable]
public sealed class aka : bdw, ISerializable
{
	// Token: 0x06003ADB RID: 15067 RVA: 0x0015D528 File Offset: 0x0015B728
	private aka(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003ADC RID: 15068 RVA: 0x0015D530 File Offset: 0x0015B730
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003ADD RID: 15069 RVA: 0x0015D534 File Offset: 0x0015B734
	public aka()
	{
	}

	// Token: 0x06003ADE RID: 15070 RVA: 0x0015D540 File Offset: 0x0015B740
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (A_0.n("pb-mainhall") != null)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("faction_pr_armorArrivalWorldTime", null);
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_pr_gasFreeDronesComplete", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_pr_armorArrivalTimeSet", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["faction_pr_armorArrivalWorldTime"] = serviceOrThrow.aqu().p() + TimeSpan.FromMinutes(30.0);
					serviceOrThrow.aqu().r()["faction_pr_armorArrivalTimeSet"] = true;
				}
				if (serviceOrThrow.aqu().p() >= primitivePropertyValue && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_pr_CAUArmorHasArrived", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["faction_pr_CAUArmorHasArrived"] = true;
				}
			}
		}
	}
}
