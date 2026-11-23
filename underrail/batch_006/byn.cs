using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000BE3 RID: 3043
public sealed class byn : jn
{
	// Token: 0x0600457B RID: 17787 RVA: 0x001C3C00 File Offset: 0x001C1E00
	public byn() : base("sgs_svana", "creature\\characters\\sgs_svana")
	{
	}

	// Token: 0x0600457C RID: 17788 RVA: 0x001C3C14 File Offset: 0x001C1E14
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_sgs_svana_sailToForsakenIsland", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_sgs_svana_returnedFromForsakenIsland", new bool?(false)).Value)
		{
			return "jgi1";
		}
		return "StationAlpha-Level9b";
	}

	// Token: 0x0600457D RID: 17789 RVA: 0x001C3C74 File Offset: 0x001C1E74
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (A_2 == "jgi1")
			{
				aspect.aa().Offense.a(WeaponKey.Secondary);
				return;
			}
			aspect.aa().Offense.a(WeaponKey.Primary);
		}
	}
}
