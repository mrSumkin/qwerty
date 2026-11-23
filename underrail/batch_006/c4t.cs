using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BB8 RID: 7096
[dgg("shockBullets")]
public sealed class c4t : cwp
{
	// Token: 0x06009A41 RID: 39489 RVA: 0x003C0D80 File Offset: 0x003BEF80
	public override string bt()
	{
		return "茷Патроны электрошок";
	}

	// Token: 0x06009A42 RID: 39490 RVA: 0x003C0D88 File Offset: 0x003BEF88
	public override string bu()
	{
		return "shockBullets";
	}

	// Token: 0x06009A43 RID: 39491 RVA: 0x003C0D90 File Offset: 0x003BEF90
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A44 RID: 39492 RVA: 0x003C0D94 File Offset: 0x003BEF94
	public override int dq()
	{
		return 40;
	}

	// Token: 0x06009A45 RID: 39493 RVA: 0x003C0D98 File Offset: 0x003BEF98
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009A46 RID: 39494 RVA: 0x003C0D9C File Offset: 0x003BEF9C
	public c4t()
	{
		base.Slots.Add(c4t.a, new cgo(new eh0("case.Caliber_5", 80), "Гильза калибра 5 мм", false, 40, 0.1f, false, false, null));
		base.Slots.Add(c4t.b, new cgo(new eh0("tnt", 11), "Тротил", false, 1, 0.1f, false, false, null));
		base.Slots.Add(c4t.c, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(c4t.d, new cgo(new eh0(new string[]
		{
			"microElectroshockDischarger"
		}, 47), "Микроразрядник", false, 3, 0.1f, false, false, null));
	}

	// Token: 0x06009A47 RID: 39495 RVA: 0x003C0E78 File Offset: 0x003BF078
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == c4t.c)
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x06009A48 RID: 39496 RVA: 0x003C0EA0 File Offset: 0x003BF0A0
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(c4t.a, null);
		fv fv2 = A_1.SafeGet(c4t.c, null);
		fv fv3 = A_1.SafeGet(c4t.d, null);
		fv fv4 = A_1.SafeGet(c4t.b, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null)
		{
			string path = "ammo\\Caliber_5_Shock";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}

	// Token: 0x04003AEA RID: 15082
	public new static readonly string a = "bolt";

	// Token: 0x04003AEB RID: 15083
	public new static readonly string b = "tnt";

	// Token: 0x04003AEC RID: 15084
	public static readonly string c = "bat";

	// Token: 0x04003AED RID: 15085
	public new static readonly string d = "pd";
}
