using System;
using System.Collections.Generic;

// Token: 0x02000BE0 RID: 3040
public sealed class aan : jn
{
	// Token: 0x06004571 RID: 17777 RVA: 0x001C3768 File Offset: 0x001C1968
	public aan() : base("tch_eidein", "creature\\characters\\tch_eidein")
	{
	}

	// Token: 0x06004572 RID: 17778 RVA: 0x001C377C File Offset: 0x001C197C
	public override string b1(cyt A_0)
	{
		string[] collection = new string[]
		{
			"tch-labpsy",
			"tch-labche",
			"tch-labgen",
			"tch-ew1",
			"tch-sq1",
			"tch-lib"
		};
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_tch_investigateFacelessCompleted", new bool?(false)).Value)
		{
			return "tch-rit";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_tch_eidein_playerSentToEidein", new bool?(false)).Value)
		{
			return "tch-loff";
		}
		string text = A_0.r().GetClassPropertyValue<string>("npc_tch_eidein_currentLocale");
		TimeSpan? primitivePropertyValue = A_0.r().GetPrimitivePropertyValue<TimeSpan>("npc_eidein_nextTravel", null);
		if (primitivePropertyValue == null || primitivePropertyValue.Value < A_0.p() || text == null)
		{
			List<string> list = new List<string>(collection);
			if (text != null)
			{
				list.Remove(text);
			}
			text = list[cuo.a.Next(list.Count)];
			primitivePropertyValue = new TimeSpan?(A_0.p() + TimeSpan.FromMinutes(25.0));
			A_0.r()["npc_eidein_nextTravel"] = primitivePropertyValue;
			A_0.r()["npc_tch_eidein_currentLocale"] = text;
		}
		return text;
	}

	// Token: 0x06004573 RID: 17779 RVA: 0x001C3904 File Offset: 0x001C1B04
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		TimeSpan? primitivePropertyValue = A_1.r().GetPrimitivePropertyValue<TimeSpan>("npc_eidein_nextTravel", null);
		if (primitivePropertyValue == null || primitivePropertyValue.Value < A_1.p() + TimeSpan.FromMinutes(5.0))
		{
			A_1.r()["npc_eidein_nextTravel"] = A_1.p() + TimeSpan.FromMinutes(10.0);
		}
	}
}
