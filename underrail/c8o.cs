using System;
using System.Collections.Generic;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000382 RID: 898
[fe("AncientRathound")]
public sealed class c8o : ua
{
	// Token: 0x060018E9 RID: 6377 RVA: 0x000810EC File Offset: 0x0007F2EC
	public c8o(bm6 A_0) : base("RathoundBehavior", A_0)
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
				new c1j("Howl")
				{
					c = 1f,
					b = "AncientRathoundHowl",
					d = new CharacterState?(CharacterState.FinishPsi)
				},
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
