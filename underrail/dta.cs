using System;
using System.Collections.Generic;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200038A RID: 906
[fe("burrowerWarrior")]
public sealed class dta : ua
{
	// Token: 0x06001925 RID: 6437 RVA: 0x00083C20 File Offset: 0x00081E20
	public dta(bm6 A_0) : base("BurrowerWarriorBehavior", A_0)
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
					d = new CharacterState?(CharacterState.FinishPsi),
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
