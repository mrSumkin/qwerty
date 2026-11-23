using System;
using System.Collections.Generic;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020003CB RID: 971
[fe("cuttlesnail")]
public sealed class aqx : ua
{
	// Token: 0x06001A42 RID: 6722 RVA: 0x0008D964 File Offset: 0x0008BB64
	public aqx(bm6 A_0) : base("Cuttlesnail", A_0)
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
					b = null,
					d = new CharacterState?(CharacterState.FinishPsi),
					a = 15000
				},
				new e7y("IdleMoveToTile")
				{
					c = 0.75f,
					b = 10,
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
