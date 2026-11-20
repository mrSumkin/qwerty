using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BA8 RID: 7080
[dgg("jhpBullets")]
public sealed class ema : cwp
{
	// Token: 0x060099C8 RID: 39368 RVA: 0x003BF1C4 File Offset: 0x003BD3C4
	public override string bt()
	{
		return "茱Патроны экспансивные";
	}

	// Token: 0x060099C9 RID: 39369 RVA: 0x003BF1CC File Offset: 0x003BD3CC
	public override string bu()
	{
		return "jhpBullets";
	}

	// Token: 0x060099CA RID: 39370 RVA: 0x003BF1D4 File Offset: 0x003BD3D4
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060099CB RID: 39371 RVA: 0x003BF1D8 File Offset: 0x003BD3D8
	public override int dq()
	{
		return 20;
	}

	// Token: 0x060099CC RID: 39372 RVA: 0x003BF1DC File Offset: 0x003BD3DC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x060099CD RID: 39373 RVA: 0x003BF1E4 File Offset: 0x003BD3E4
	public ema()
	{
		base.Slots.Add(ema.a, new cgo(new c6s(ms.bj, 92), "Любая гильза", false, 20, 0.1f, false, false, null));
		base.Slots.Add(ema.c, new cgo(new eh0("tnt", 11), "Тротил", false, 1, 0.1f, false, false, null));
		base.Slots.Add(ema.b, new cgo(new eh0("steel", 23), "Стальная пластина", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060099CE RID: 39374 RVA: 0x003BF288 File Offset: 0x003BD488
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == ema.b)
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x060099CF RID: 39375 RVA: 0x003BF2B0 File Offset: 0x003BD4B0
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(ema.a, null);
		fv fv2 = A_1.SafeGet(ema.b, null);
		fv fv3 = A_1.SafeGet(ema.c, null);
		if (fv != null && fv.TypedDefinition != null && fv.TypedDefinition.a5() != null && fv.TypedDefinition.a5().Length > 5 && fv.TypedDefinition.a5().StartsWith("case.") && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			string str = fv.Definition.a5().Substring(5);
			string path = "ammo\\" + str + "_JHP";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}

	// Token: 0x04003ACB RID: 15051
	public new static readonly string a = "case";

	// Token: 0x04003ACC RID: 15052
	public new static readonly string b = "metal";

	// Token: 0x04003ACD RID: 15053
	public static readonly string c = "tnt";
}
