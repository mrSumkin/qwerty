using System;
using System.Collections.Generic;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000381 RID: 897
[fe("burrower")]
public sealed class akq : ua
{
	// Token: 0x060018E8 RID: 6376 RVA: 0x00080FC8 File Offset: 0x0007F1C8
	public akq(bm6 A_0) : base("BurrowerBehavior", A_0)
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
				new c1j("NoseScratch")
				{
					c = 1f,
					d = new CharacterState?(CharacterState.Custom2),
					a = 10000
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
