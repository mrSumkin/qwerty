using System;

// Token: 0x02000BD8 RID: 3032
public sealed class ban : jn
{
	// Token: 0x06004556 RID: 17750 RVA: 0x001C2ED4 File Offset: 0x001C10D4
	public ban() : base("cc_morgan", "creature\\characters\\cc_morgan")
	{
	}

	// Token: 0x06004557 RID: 17751 RVA: 0x001C2EEC File Offset: 0x001C10EC
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_morgan_getInHouse", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_coreCity_playerReceivedHouseKeys", new bool?(false)).Value)
		{
			return "cc_ph";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_coreCity_sentToSeeHouse", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_coreCity_playerReceivedHouseKeys", new bool?(false)).Value)
		{
			return "cc-res";
		}
		return null;
	}

	// Token: 0x06004558 RID: 17752 RVA: 0x001C2F94 File Offset: 0x001C1194
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null && string.Equals(A_2, "cc_ph", StringComparison.OrdinalIgnoreCase))
		{
			aspect.y6().RemoveProperty(ddq.bg);
		}
	}
}
