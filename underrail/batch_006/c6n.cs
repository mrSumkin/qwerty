using System;
using System.Collections.Generic;

// Token: 0x020003B6 RID: 950
[fe("hermitCrab")]
public sealed class c6n : ua
{
	// Token: 0x060019F3 RID: 6643 RVA: 0x0008B3D8 File Offset: 0x000895D8
	public c6n(bm6 A_0) : base("CrabBehavior", A_0)
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
			new e1y("IdleMovement", new List<c96>
			{
				new e7y("IdleMoveToTile")
				{
					c = 0.75f,
					b = 5,
					c = 3
				},
				new aif("RestActivity")
			})
			{
				c = 0.75f
			},
			new aif("RestActivity")
		});
	}
}
