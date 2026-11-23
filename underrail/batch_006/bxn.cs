using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BB9 RID: 7097
[dgg("gasGrenade")]
public sealed class bxn : cwp
{
	// Token: 0x06009A4A RID: 39498 RVA: 0x003C0F78 File Offset: 0x003BF178
	public override string bt()
	{
		return "荦Газовая граната";
	}

	// Token: 0x06009A4B RID: 39499 RVA: 0x003C0F80 File Offset: 0x003BF180
	public override string bu()
	{
		return "gasGrenade";
	}

	// Token: 0x06009A4C RID: 39500 RVA: 0x003C0F88 File Offset: 0x003BF188
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A4D RID: 39501 RVA: 0x003C0F8C File Offset: 0x003BF18C
	public override int dq()
	{
		return 3;
	}

	// Token: 0x06009A4E RID: 39502 RVA: 0x003C0F90 File Offset: 0x003BF190
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Grenades;
	}

	// Token: 0x06009A4F RID: 39503 RVA: 0x003C0F94 File Offset: 0x003BF194
	public bxn()
	{
		base.Slots.Add(bxn.a, new cgo(new eh0("thinGrenadeCase", 36), "Тонкий корпус гранаты", false, 3, 0.1f, false, false, null));
		base.Slots.Add(bxn.c, new cgo(new eh0(new string[]
		{
			"Component.StarterMixture"
		}, 77), "Запальный состав", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bxn.b, new cgo(new eh0(new string[]
		{
			"liquidNitrogen",
			"toxicSludge",
			"herbicide"
		}, 78), "Наполнитель", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A50 RID: 39504 RVA: 0x003C105C File Offset: 0x003BF25C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(bxn.a, null);
		fv fv2 = A_1.SafeGet(bxn.b, null);
		fv fv3 = A_1.SafeGet(bxn.c, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			string classPropertyValue = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("GasGrenade");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				string path = "grenades\\" + classPropertyValue;
				if (ez2.GetItemDefinition<cdk>(path, true) != null)
				{
					return new acz(ez2.CreateDefinitonProvider<cdk>(path));
				}
			}
		}
		return null;
	}

	// Token: 0x04003AEE RID: 15086
	public new static readonly string a = "grenadeCase";

	// Token: 0x04003AEF RID: 15087
	public new static readonly string b = "filler";

	// Token: 0x04003AF0 RID: 15088
	public static readonly string c = "starterMixture";
}
