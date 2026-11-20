using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BB6 RID: 7094
[dgg("microShrapnelBullets")]
public sealed class egh : cwp
{
	// Token: 0x06009A2F RID: 39471 RVA: 0x003C0984 File Offset: 0x003BEB84
	public override string bt()
	{
		return "茳Патроны микрошрапнель";
	}

	// Token: 0x06009A30 RID: 39472 RVA: 0x003C098C File Offset: 0x003BEB8C
	public override string bu()
	{
		return "microShrapnelBullets";
	}

	// Token: 0x06009A31 RID: 39473 RVA: 0x003C0994 File Offset: 0x003BEB94
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A32 RID: 39474 RVA: 0x003C0998 File Offset: 0x003BEB98
	public override int dq()
	{
		return 35;
	}

	// Token: 0x06009A33 RID: 39475 RVA: 0x003C099C File Offset: 0x003BEB9C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009A34 RID: 39476 RVA: 0x003C09A4 File Offset: 0x003BEBA4
	public egh()
	{
		base.Slots.Add(egh.a, new cgo(new eh0("case.Caliber_762", 81), "Гильза калибра 7,62 мм", false, 35, 0.1f, false, false, null));
		base.Slots.Add(egh.b, new cgo(new eh0("tnt", 11), "Тротил", false, 1, 0.1f, false, false, null));
		base.Slots.Add(egh.c, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(egh.d, new cgo(new eh0(new string[]
		{
			"metalScraps"
		}, 86), "Металлолом", false, 80, 0.1f, false, false, null));
	}

	// Token: 0x06009A35 RID: 39477 RVA: 0x003C0A80 File Offset: 0x003BEC80
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == egh.c)
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x06009A36 RID: 39478 RVA: 0x003C0AA8 File Offset: 0x003BECA8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(egh.a, null);
		fv fv2 = A_1.SafeGet(egh.c, null);
		fv fv3 = A_1.SafeGet(egh.d, null);
		fv fv4 = A_1.SafeGet(egh.b, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null)
		{
			string path = "ammo\\Caliber_762_MS";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}

	// Token: 0x04003AE2 RID: 15074
	public new static readonly string a = "bolt";

	// Token: 0x04003AE3 RID: 15075
	public new static readonly string b = "tnt";

	// Token: 0x04003AE4 RID: 15076
	public static readonly string c = "bat";

	// Token: 0x04003AE5 RID: 15077
	public new static readonly string d = "pd";
}
