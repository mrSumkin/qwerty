using System;

// Token: 0x02000BD1 RID: 3025
public sealed class c5u : jn
{
	// Token: 0x06004544 RID: 17732 RVA: 0x001C2748 File Offset: 0x001C0948
	public c5u() : base("cc_duff", "creature\\characters\\cc_duff")
	{
	}

	// Token: 0x06004545 RID: 17733 RVA: 0x001C2760 File Offset: 0x001C0960
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_duff_hasEnoughMoney", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_duff_metAfterGivingMoney", new bool?(false)).Value)
		{
			return "cc1";
		}
		return null;
	}
}
