using System;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020016A6 RID: 5798
[d1q("FlashbangThrow")]
public sealed class c0v : as9
{
	// Token: 0x06007E9E RID: 32414 RVA: 0x00358430 File Offset: 0x00356630
	protected override string hq()
	{
		return "thinGrenade";
	}

	// Token: 0x06007E9F RID: 32415 RVA: 0x00358438 File Offset: 0x00356638
	protected override CombatSpeakEvent[] hr()
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Flashbang
		};
	}

	// Token: 0x06007EA0 RID: 32416 RVA: 0x00358448 File Offset: 0x00356648
	protected override double hs()
	{
		return (double)aju.ba;
	}

	// Token: 0x06007EA1 RID: 32417 RVA: 0x00358450 File Offset: 0x00356650
	protected override cuu ht()
	{
		return new dr7();
	}

	// Token: 0x06007EA2 RID: 32418 RVA: 0x00358458 File Offset: 0x00356658
	protected override blv hu()
	{
		return new blv
		{
			a = new ah7("fireballLantern", null),
			a = 
			{
				LightFadeRate = 0.2f,
				Range = 4f,
				Light = new ae8(Color.White, 1f, LightType.Increment)
			},
			b = 0.2f,
			c = 0.15f,
			d = 6f
		};
	}

	// Token: 0x06007EA3 RID: 32419 RVA: 0x003584D8 File Offset: 0x003566D8
	protected override int hv()
	{
		return 15;
	}

	// Token: 0x06007EA4 RID: 32420 RVA: 0x003584DC File Offset: 0x003566DC
	protected override string hw()
	{
		return "FlashbangExplode";
	}
}
