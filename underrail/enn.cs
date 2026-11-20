using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B87 RID: 7047
[dgg("acidBullets")]
public sealed class enn : cwp
{
	// Token: 0x060098DD RID: 39133 RVA: 0x003BACBC File Offset: 0x003B8EBC
	public override string bt()
	{
		return "茸Патроны кислотные";
	}

	// Token: 0x060098DE RID: 39134 RVA: 0x003BACC4 File Offset: 0x003B8EC4
	public override string bu()
	{
		return "acidBullets";
	}

	// Token: 0x060098DF RID: 39135 RVA: 0x003BACCC File Offset: 0x003B8ECC
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060098E0 RID: 39136 RVA: 0x003BACD0 File Offset: 0x003B8ED0
	public override int dq()
	{
		return 25;
	}

	// Token: 0x060098E1 RID: 39137 RVA: 0x003BACD4 File Offset: 0x003B8ED4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x060098E2 RID: 39138 RVA: 0x003BACD8 File Offset: 0x003B8ED8
	public enn()
	{
		base.Slots.Add(enn.a, new cgo(new eh0("case.Caliber_9", 82), "Гильза калибра 9 мм", false, 25, 0.1f, false, false, null));
		base.Slots.Add(enn.b, new cgo(new eh0("tnt", 11), "Тротил", false, 1, 0.1f, false, false, null));
		base.Slots.Add(enn.c, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(enn.d, new cgo(new eh0(new string[]
		{
			"acid.regular"
		}, 55), "Обычная кислота", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060098E3 RID: 39139 RVA: 0x003BADB4 File Offset: 0x003B8FB4
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == enn.c)
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x060098E4 RID: 39140 RVA: 0x003BADDC File Offset: 0x003B8FDC
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(enn.a, null);
		fv fv2 = A_1.SafeGet(enn.c, null);
		fv fv3 = A_1.SafeGet(enn.d, null);
		fv fv4 = A_1.SafeGet(enn.b, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null)
		{
			string path = "ammo\\Caliber_9_Acid";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}

	// Token: 0x04003A9A RID: 15002
	public new static readonly string a = "case";

	// Token: 0x04003A9B RID: 15003
	public new static readonly string b = "tnt";

	// Token: 0x04003A9C RID: 15004
	public static readonly string c = "plates";

	// Token: 0x04003A9D RID: 15005
	public new static readonly string d = "incendiary";
}
