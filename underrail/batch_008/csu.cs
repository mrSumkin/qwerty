using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B8A RID: 7050
[dgg("bullets")]
public sealed class csu : cwp
{
	// Token: 0x060098F6 RID: 39158 RVA: 0x003BB240 File Offset: 0x003B9440
	public override string bt()
	{
		return "茰Патроны";
	}

	// Token: 0x060098F7 RID: 39159 RVA: 0x003BB248 File Offset: 0x003B9448
	public override string bu()
	{
		return "bullets";
	}

	// Token: 0x060098F8 RID: 39160 RVA: 0x003BB250 File Offset: 0x003B9450
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x060098F9 RID: 39161 RVA: 0x003BB254 File Offset: 0x003B9454
	public override int dq()
	{
		return 30;
	}

	// Token: 0x060098FA RID: 39162 RVA: 0x003BB258 File Offset: 0x003B9458
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x060098FB RID: 39163 RVA: 0x003BB25C File Offset: 0x003B945C
	public csu()
	{
		base.Slots.Add(csu.a, new cgo(new c6s(ms.bj, 92), "Любая гильза", false, 30, 0.1f, false, false, null));
		base.Slots.Add(csu.c, new cgo(new eh0("tnt", 11), "Тротил", false, 1, 0.1f, false, false, null));
		base.Slots.Add(csu.b, new cgo(new eh0("steel", 23), "Стальная пластина", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060098FC RID: 39164 RVA: 0x003BB300 File Offset: 0x003B9500
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == csu.b)
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x060098FD RID: 39165 RVA: 0x003BB328 File Offset: 0x003B9528
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(csu.a, null);
		fv fv2 = A_1.SafeGet(csu.b, null);
		fv fv3 = A_1.SafeGet(csu.c, null);
		if (fv != null && fv.TypedDefinition != null && fv.TypedDefinition.a5() != null && fv.TypedDefinition.a5().Length > 5 && fv.TypedDefinition.a5().StartsWith("case.") && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			string str = fv.Definition.a5().Substring(5);
			string path = "ammo\\" + str + "_Std";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}

	// Token: 0x04003AA6 RID: 15014
	public new static readonly string a = "case";

	// Token: 0x04003AA7 RID: 15015
	public new static readonly string b = "metal";

	// Token: 0x04003AA8 RID: 15016
	public static readonly string c = "tnt";
}
