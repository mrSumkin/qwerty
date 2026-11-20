using System;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200169A RID: 5786
[d1q("NailBombThrow")]
public sealed class e0a : as9
{
	// Token: 0x06007E51 RID: 32337 RVA: 0x00358000 File Offset: 0x00356200
	protected override CombatSpeakEvent[] hr()
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_StandardGrenade
		};
	}

	// Token: 0x06007E52 RID: 32338 RVA: 0x00358010 File Offset: 0x00356210
	protected override double hs()
	{
		return (double)aju.a7;
	}

	// Token: 0x06007E53 RID: 32339 RVA: 0x00358018 File Offset: 0x00356218
	protected override cuu ht()
	{
		return new bwg();
	}

	// Token: 0x06007E54 RID: 32340 RVA: 0x00358024 File Offset: 0x00356224
	protected override blv hu()
	{
		return new blv
		{
			a = new ah7("nailBomb", null),
			a = 
			{
				LightFadeRate = 0.1f,
				Range = 5f,
				Light = new ae8(new Color(255, 200, 200), 0.7f, LightType.Increment)
			},
			b = 0.15f,
			c = 0.1f,
			d = 7f
		};
	}

	// Token: 0x06007E55 RID: 32341 RVA: 0x003580B4 File Offset: 0x003562B4
	protected override int hv()
	{
		return 10;
	}

	// Token: 0x06007E56 RID: 32342 RVA: 0x003580B8 File Offset: 0x003562B8
	protected override string hw()
	{
		return "NailBomb";
	}
}
