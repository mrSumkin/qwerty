using System;
using System.Collections.Generic;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000384 RID: 900
[fe("bladeBeast")]
public sealed class crw : ua
{
	// Token: 0x060018EB RID: 6379 RVA: 0x00081334 File Offset: 0x0007F534
	public crw(bm6 A_0) : base("BladeBeastBehavior", A_0)
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
					b = "BladelingRoars",
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
