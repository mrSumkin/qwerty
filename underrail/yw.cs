using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BAC RID: 7084
[dgg("stingballGrenade")]
public sealed class yw : cwp
{
	// Token: 0x060099E8 RID: 39400 RVA: 0x003BFA70 File Offset: 0x003BDC70
	public override string bt()
	{
		return "荧Шарикошипованая граната";
	}

	// Token: 0x060099E9 RID: 39401 RVA: 0x003BFA78 File Offset: 0x003BDC78
	public override string bu()
	{
		return "stingballGrenade";
	}

	// Token: 0x060099EA RID: 39402 RVA: 0x003BFA80 File Offset: 0x003BDC80
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x060099EB RID: 39403 RVA: 0x003BFA84 File Offset: 0x003BDC84
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Grenades;
	}

	// Token: 0x060099EC RID: 39404 RVA: 0x003BFA88 File Offset: 0x003BDC88
	public yw()
	{
		base.Slots.Add(yw.a, new cgo(new eh0("thinGrenadeCase", 36), "Тонкий корпус гранаты", false, 1, 0.1f, false, false, null));
		base.Slots.Add(yw.b, new cgo(new eh0(new string[]
		{
			"Component.StarterMixture"
		}, 77), "Запальный состав", false, 1, 0.1f, false, false, null));
		base.Slots.Add(yw.c, new cgo(new eh0(new string[]
		{
			"Component.RubberBalls"
		}, 88), "Резиновые шарики", false, 10, 0.1f, false, false, null));
	}

	// Token: 0x060099ED RID: 39405 RVA: 0x003BFB40 File Offset: 0x003BDD40
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			string path = "grenades\\xpbl\\stingballGrenade";
			ez2.GetItemDefinition<cdk>(path, true);
			return new acz(ez2.CreateDefinitonProvider<cdk>(path));
		}
		return null;
	}

	// Token: 0x04003AD7 RID: 15063
	public new static readonly string a = "case";

	// Token: 0x04003AD8 RID: 15064
	public new static readonly string b = "starterMixture";

	// Token: 0x04003AD9 RID: 15065
	public static readonly string c = "rubberBalls";
}
