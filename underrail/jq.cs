using System;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200169E RID: 5790
[d1q("stingballGrenadeThrow")]
public sealed class jq : as9
{
	// Token: 0x06007E6C RID: 32364 RVA: 0x00358208 File Offset: 0x00356408
	protected override string hq()
	{
		return "thinGrenade";
	}

	// Token: 0x06007E6D RID: 32365 RVA: 0x00358210 File Offset: 0x00356410
	protected override CombatSpeakEvent[] hr()
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Flashbang
		};
	}

	// Token: 0x06007E6E RID: 32366 RVA: 0x00358220 File Offset: 0x00356420
	protected override double hs()
	{
		return (double)aju.bc;
	}

	// Token: 0x06007E6F RID: 32367 RVA: 0x00358228 File Offset: 0x00356428
	protected override cuu ht()
	{
		return new blo();
	}

	// Token: 0x06007E70 RID: 32368 RVA: 0x00358230 File Offset: 0x00356430
	protected override blv hu()
	{
		return new blv
		{
			a = new ah7("stringBallGrenadeLantern", null),
			a = 
			{
				LightFadeRate = 0.04f,
				Range = 3f,
				Light = new ae8(Color.White, 0.2f, LightType.Increment)
			},
			b = 0.04f,
			c = 0.03f,
			d = 6f
		};
	}

	// Token: 0x06007E71 RID: 32369 RVA: 0x003582B0 File Offset: 0x003564B0
	protected override int hv()
	{
		return 15;
	}

	// Token: 0x06007E72 RID: 32370 RVA: 0x003582B4 File Offset: 0x003564B4
	protected override string hw()
	{
		return "xpbl_StingballGrenadeExplode";
	}
}
