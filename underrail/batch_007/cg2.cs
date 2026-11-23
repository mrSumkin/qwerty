using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020017AE RID: 6062
internal class cg2 : ak9
{
	// Token: 0x0600819E RID: 33182 RVA: 0x00369124 File Offset: 0x00367324
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new List<d3e>
		{
			new ax6(BaseAbilityEnum.Will.ToString(), -1),
			new ciw(-100),
			new bi0(null, 0.05f),
			new dvq(0.05, cs5.a)
		}.ToArray();
		A_1 = null;
		A_2 = null;
	}

	// Token: 0x0600819F RID: 33183 RVA: 0x0036919C File Offset: 0x0036739C
	public override void pw(c5x A_0)
	{
		if (A_0 != null && A_0.IsPlayer && A_0.Zone != null)
		{
			dtb dtb = new dtb();
			dtb.ad().Add(new bm3(500));
			dtb.ad().Add(new b8p(A_0, new d53("На вкус странно знакомо...", adi.i, null, false)));
			A_0.Zone.ActionManager.g9(dtb, atp.a);
		}
	}
}
