using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BA9 RID: 7081
[dgg("w2cBullets")]
public sealed class cwj : cwp
{
	// Token: 0x060099D1 RID: 39377 RVA: 0x003BF3BC File Offset: 0x003BD5BC
	public override string bt()
	{
		return "茲Патроны бронебойные";
	}

	// Token: 0x060099D2 RID: 39378 RVA: 0x003BF3C4 File Offset: 0x003BD5C4
	public override string bu()
	{
		return "w2cBullets";
	}

	// Token: 0x060099D3 RID: 39379 RVA: 0x003BF3CC File Offset: 0x003BD5CC
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060099D4 RID: 39380 RVA: 0x003BF3D0 File Offset: 0x003BD5D0
	public override int dq()
	{
		return 20;
	}

	// Token: 0x060099D5 RID: 39381 RVA: 0x003BF3D4 File Offset: 0x003BD5D4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x060099D6 RID: 39382 RVA: 0x003BF3DC File Offset: 0x003BD5DC
	public cwj()
	{
		base.Slots.Add(cwj.a, new cgo(new c6s(ms.bj, 92), "Любая гильза", false, 20, 0.1f, false, false, null));
		base.Slots.Add(cwj.c, new cgo(new eh0("hexogen", 11), "Гексоген", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cwj.b, new cgo(new eh0("tungstenSteel", 93), "Вольфрамо-стальная пластина", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cwj.d, new cgo(new eh0("Component.Graphite", 94), "Графит", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060099D7 RID: 39383 RVA: 0x003BF4B0 File Offset: 0x003BD6B0
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == cwj.b)
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x060099D8 RID: 39384 RVA: 0x003BF4D8 File Offset: 0x003BD6D8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(cwj.a, null);
		fv fv2 = A_1.SafeGet(cwj.b, null);
		fv fv3 = A_1.SafeGet(cwj.c, null);
		fv fv4 = A_1.SafeGet(cwj.d, null);
		if (fv != null && fv.TypedDefinition != null && fv.TypedDefinition.a5() != null && fv.TypedDefinition.a5().Length > 5 && fv.TypedDefinition.a5().StartsWith("case.") && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null)
		{
			string str = fv.Definition.a5().Substring(5);
			string path = "ammo\\" + str + "_W2C";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}

	// Token: 0x04003ACE RID: 15054
	public new static readonly string a = "case";

	// Token: 0x04003ACF RID: 15055
	public new static readonly string b = "metal";

	// Token: 0x04003AD0 RID: 15056
	public static readonly string c = "hexogen";

	// Token: 0x04003AD1 RID: 15057
	public new static readonly string d = "graphite";
}
