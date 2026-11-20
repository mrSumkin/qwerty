using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B88 RID: 7048
[dgg("contaminatedBullets")]
public sealed class bcs : cwp
{
	// Token: 0x060098E6 RID: 39142 RVA: 0x003BAEB4 File Offset: 0x003B90B4
	public override string bt()
	{
		return "茹Патроны заражённые";
	}

	// Token: 0x060098E7 RID: 39143 RVA: 0x003BAEBC File Offset: 0x003B90BC
	public override string bu()
	{
		return "contaminatedBullets";
	}

	// Token: 0x060098E8 RID: 39144 RVA: 0x003BAEC4 File Offset: 0x003B90C4
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060098E9 RID: 39145 RVA: 0x003BAEC8 File Offset: 0x003B90C8
	public override int dq()
	{
		return 15;
	}

	// Token: 0x060098EA RID: 39146 RVA: 0x003BAECC File Offset: 0x003B90CC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x060098EB RID: 39147 RVA: 0x003BAED0 File Offset: 0x003B90D0
	public bcs()
	{
		base.Slots.Add(bcs.a, new cgo(new eh0("case.Caliber_127", 85), "Гильза калибра 12,7 мм", false, 15, 0.1f, false, false, null));
		base.Slots.Add(bcs.b, new cgo(new eh0("tnt", 11), "Тротил", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bcs.c, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bcs.d, new cgo(new eh0(new string[]
		{
			"toxicSludge"
		}, 78), "Токсичные отходы", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060098EC RID: 39148 RVA: 0x003BAFAC File Offset: 0x003B91AC
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == bcs.c)
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x060098ED RID: 39149 RVA: 0x003BAFD4 File Offset: 0x003B91D4
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(bcs.a, null);
		fv fv2 = A_1.SafeGet(bcs.c, null);
		fv fv3 = A_1.SafeGet(bcs.d, null);
		fv fv4 = A_1.SafeGet(bcs.b, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null)
		{
			string path = "ammo\\Caliber_127_Cnt";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}

	// Token: 0x04003A9E RID: 15006
	public new static readonly string a = "bolt";

	// Token: 0x04003A9F RID: 15007
	public new static readonly string b = "tnt";

	// Token: 0x04003AA0 RID: 15008
	public static readonly string c = "bat";

	// Token: 0x04003AA1 RID: 15009
	public new static readonly string d = "pd";
}
