using System;

// Token: 0x02000C49 RID: 3145
public sealed class cgm : jn
{
	// Token: 0x060046CA RID: 18122 RVA: 0x001D31E4 File Offset: 0x001D13E4
	public cgm() : base("jackQuicksilver", "creature\\characters\\jackQuicksilver")
	{
	}

	// Token: 0x060046CB RID: 18123 RVA: 0x001D31F8 File Offset: 0x001D13F8
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("facelessInvaded", new bool?(false)).Value && (A_0.r().GetPrimitivePropertyValue<bool>("npc_jackQuicksilver_attacked", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("faction_watchers_noLongerWorking", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_jackQuicksilver_finalReport", new bool?(false)).Value))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("facelessInvaded", new bool?(false)).Value)
		{
			return "cc10";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_jqsDelivery_finished", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jackQuicksilver_deliveryTaskAccepted", new bool?(false)).Value)
		{
			return "WarehouseBlockAlpha1";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("facelessInvaded", new bool?(false)).Value)
		{
			return "StationAlpha-Level3";
		}
		return null;
	}

	// Token: 0x060046CC RID: 18124 RVA: 0x001D3334 File Offset: 0x001D1534
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		string text = "characters\\";
		if (string.Equals(A_2, "WarehouseBlockAlpha1"))
		{
			text += "jackQuicksilver2";
		}
		else if (string.Equals(A_2, "cc10"))
		{
			text += "jackQuicksilver1";
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null)
			{
				aspect.aa().FactionId = "coreCity";
			}
		}
		else
		{
			text += "jackQuicksilver1";
		}
		bn5 bn = A_0.GetAspect<j7>() as bn5;
		if (bn == null)
		{
			bn = new bn5(A_0 as c5x);
			A_0.SetAspect<j7>(bn);
		}
		bn.b(text);
	}
}
