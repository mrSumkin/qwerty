using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000C46 RID: 3142
public sealed class u5 : jn
{
	// Token: 0x060046C2 RID: 18114 RVA: 0x001D2F80 File Offset: 0x001D1180
	public u5() : base("broderick", "creature\\characters\\broderick")
	{
	}

	// Token: 0x060046C3 RID: 18115 RVA: 0x001D2F94 File Offset: 0x001D1194
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_broderick_isOnSilentIsle", new bool?(false)).Value)
		{
			return "si1";
		}
		return "jy5";
	}

	// Token: 0x060046C4 RID: 18116 RVA: 0x001D2FD0 File Offset: 0x001D11D0
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		((c5x)A_0).b(bp5.k + "jy_broderickFerry");
		if (aspect != null)
		{
			if (A_2 == "si1")
			{
				aspect.aa().Offense.a(WeaponKey.Secondary);
				return;
			}
			aspect.aa().Offense.a(WeaponKey.Primary);
		}
	}
}
