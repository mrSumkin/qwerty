using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BB5 RID: 7093
[dgg("explosiveBullets")]
public sealed class c16 : cwp
{
	// Token: 0x06009A26 RID: 39462 RVA: 0x003C07E8 File Offset: 0x003BE9E8
	public override string bt()
	{
		return "茶Патроны разрывные";
	}

	// Token: 0x06009A27 RID: 39463 RVA: 0x003C07F0 File Offset: 0x003BE9F0
	public override string bu()
	{
		return "explosiveBullets";
	}

	// Token: 0x06009A28 RID: 39464 RVA: 0x003C07F8 File Offset: 0x003BE9F8
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A29 RID: 39465 RVA: 0x003C07FC File Offset: 0x003BE9FC
	public override int dq()
	{
		return 20;
	}

	// Token: 0x06009A2A RID: 39466 RVA: 0x003C0800 File Offset: 0x003BEA00
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009A2B RID: 39467 RVA: 0x003C0804 File Offset: 0x003BEA04
	public c16()
	{
		base.Slots.Add(c16.a, new cgo(new eh0("case.Caliber_44", 83), "Гильза калибра .44", false, 20, 0.1f, false, false, null));
		base.Slots.Add(c16.b, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(c16.c, new cgo(new eh0(new string[]
		{
			"hexogen"
		}, 11), "Гексоген", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A2C RID: 39468 RVA: 0x003C08B0 File Offset: 0x003BEAB0
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == c16.b)
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x06009A2D RID: 39469 RVA: 0x003C08D8 File Offset: 0x003BEAD8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(c16.a, null);
		fv fv2 = A_1.SafeGet(c16.b, null);
		fv fv3 = A_1.SafeGet(c16.c, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			string path = "ammo\\Caliber_44_Exp";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}

	// Token: 0x04003ADF RID: 15071
	public new static readonly string a = "bolt";

	// Token: 0x04003AE0 RID: 15072
	public new static readonly string b = "bat";

	// Token: 0x04003AE1 RID: 15073
	public static readonly string c = "pd";
}
