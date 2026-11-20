using System;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000C20 RID: 3104
public sealed class ebr : jn
{
	// Token: 0x06004651 RID: 18001 RVA: 0x001CF718 File Offset: 0x001CD918
	public ebr() : base("cc_hobo", "creature\\characters\\support\\cc_hobo")
	{
	}

	// Token: 0x06004652 RID: 18002 RVA: 0x001CF72C File Offset: 0x001CD92C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_coreCity_playerReceivedHouseKeys", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_hobo_leavesForGood", new bool?(false)).Value)
		{
			return "cc-res";
		}
		return null;
	}

	// Token: 0x06004653 RID: 18003 RVA: 0x001CF788 File Offset: 0x001CD988
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			aspect.y6()[ddq.ay] = new bt4("global:cc_hobo");
			if (string.Equals(A_2, "cc-res", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.s] = 1000;
				aspect.y6()[ddq.w] = CharacterState.Operating;
				return;
			}
			aspect.y6().RemoveProperty(ddq.s);
			aspect.y6().RemoveProperty(ddq.w);
		}
	}
}
