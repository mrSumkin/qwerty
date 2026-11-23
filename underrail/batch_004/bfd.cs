using System;
using System.Collections.Generic;

// Token: 0x020003A9 RID: 937
[fe("savageKingOnThrone")]
public class bfd : ua
{
	// Token: 0x060019CD RID: 6605 RVA: 0x0008A2F8 File Offset: 0x000884F8
	public bfd(bm6 A_0) : base("SavageKingOnThroneBehavior", A_0)
	{
		base.a(new List<c96>
		{
			new efs("CombatNearEnemies", new List<c96>
			{
				new e8n("FocusPrimaryTarget", new List<c96>
				{
					new cta("AutoAttackCurrentTarget"),
					new rv("GiveUpOnTarget", 180, 300000)
				}),
				new chi("ChangeTargetActivity")
			}),
			new aif("RestActivity")
		});
	}
}
