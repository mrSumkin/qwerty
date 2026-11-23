using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BB7 RID: 7095
[dgg("incendiaryBullets")]
public sealed class eow : cwp
{
	// Token: 0x06009A38 RID: 39480 RVA: 0x003C0B80 File Offset: 0x003BED80
	public override string bt()
	{
		return "茵Патроны зажигательные";
	}

	// Token: 0x06009A39 RID: 39481 RVA: 0x003C0B88 File Offset: 0x003BED88
	public override string bu()
	{
		return "incendiaryBullets";
	}

	// Token: 0x06009A3A RID: 39482 RVA: 0x003C0B90 File Offset: 0x003BED90
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A3B RID: 39483 RVA: 0x003C0B94 File Offset: 0x003BED94
	public override int dq()
	{
		return 30;
	}

	// Token: 0x06009A3C RID: 39484 RVA: 0x003C0B98 File Offset: 0x003BED98
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009A3D RID: 39485 RVA: 0x003C0B9C File Offset: 0x003BED9C
	public eow()
	{
		base.Slots.Add(eow.a, new cgo(new eh0("case.Caliber_86", 84), "Гильза калибра 8,6 мм", false, 30, 0.1f, false, false, null));
		base.Slots.Add(eow.b, new cgo(new eh0("tnt", 11), "Тротил", false, 1, 0.1f, false, false, null));
		base.Slots.Add(eow.c, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(eow.d, new cgo(new eh0(new string[]
		{
			"Component.MagnesiumPowder",
			"Component.NapalmC"
		}, 55), "Мощное зажигательное вещество", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A3E RID: 39486 RVA: 0x003C0C80 File Offset: 0x003BEE80
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == eow.c)
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x06009A3F RID: 39487 RVA: 0x003C0CA8 File Offset: 0x003BEEA8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(eow.a, null);
		fv fv2 = A_1.SafeGet(eow.c, null);
		fv fv3 = A_1.SafeGet(eow.d, null);
		fv fv4 = A_1.SafeGet(eow.b, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null)
		{
			string path = "ammo\\Caliber_86_Inc";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}

	// Token: 0x04003AE6 RID: 15078
	public new static readonly string a = "bolt";

	// Token: 0x04003AE7 RID: 15079
	public new static readonly string b = "tnt";

	// Token: 0x04003AE8 RID: 15080
	public static readonly string c = "bat";

	// Token: 0x04003AE9 RID: 15081
	public new static readonly string d = "pd";
}
