using System;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001344 RID: 4932
[d50(car.b)]
public sealed class eer : e19
{
	// Token: 0x06006FB5 RID: 28597 RVA: 0x002ED8F0 File Offset: 0x002EBAF0
	protected override string[] ic()
	{
		return new string[]
		{
			"SG_muzzle_Smoke",
			"SG_muzzle_Fire"
		};
	}

	// Token: 0x06006FB6 RID: 28598 RVA: 0x002ED90C File Offset: 0x002EBB0C
	protected override ah7 asp(string A_0, AmmoType A_1)
	{
		return new ah7("ShotgunMuzzle", null)
		{
			LightFadeRate = 0.3f,
			Range = 2f,
			Light = new ae8(Color.White, 0.5f, LightType.Increment)
		};
	}
}
