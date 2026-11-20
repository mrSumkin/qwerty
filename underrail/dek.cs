using System;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001698 RID: 5784
[d1q("chemhazeGrenadeThrow")]
public sealed class dek : as9
{
	// Token: 0x06007E3B RID: 32315 RVA: 0x00357E24 File Offset: 0x00356024
	protected override double hs()
	{
		return (double)aju.a8;
	}

	// Token: 0x06007E3C RID: 32316 RVA: 0x00357E2C File Offset: 0x0035602C
	protected override CombatSpeakEvent[] hr()
	{
		return new CombatSpeakEvent[0];
	}

	// Token: 0x06007E3D RID: 32317 RVA: 0x00357E34 File Offset: 0x00356034
	protected override cuu ht()
	{
		return new kx();
	}

	// Token: 0x06007E3E RID: 32318 RVA: 0x00357E40 File Offset: 0x00356040
	protected override blv hu()
	{
		return new blv
		{
			a = new ah7("chemhaze", null),
			a = 
			{
				LightFadeRate = 0.15f,
				Range = 3f,
				Light = new ae8(new Color(255, 180, 230), 0.5f, LightType.Increment)
			},
			b = 0.15f,
			c = 0.1f,
			d = 3f
		};
	}

	// Token: 0x06007E3F RID: 32319 RVA: 0x00357ED0 File Offset: 0x003560D0
	protected override int hv()
	{
		return 10;
	}

	// Token: 0x06007E40 RID: 32320 RVA: 0x00357ED4 File Offset: 0x003560D4
	protected override string hw()
	{
		return "ChemicalGrenadeExplosion";
	}
}
