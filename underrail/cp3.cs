using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BEC RID: 7148
[dgg("ShieldRecharger")]
public sealed class cp3 : cwp
{
	// Token: 0x06009BBB RID: 39867 RVA: 0x003D0AB8 File Offset: 0x003CECB8
	public override string bt()
	{
		return "荋Зарядник щита";
	}

	// Token: 0x06009BBC RID: 39868 RVA: 0x003D0AC0 File Offset: 0x003CECC0
	public override string bu()
	{
		return "ShieldRecharger";
	}

	// Token: 0x06009BBD RID: 39869 RVA: 0x003D0AC8 File Offset: 0x003CECC8
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009BBE RID: 39870 RVA: 0x003D0ACC File Offset: 0x003CECCC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Devices;
	}

	// Token: 0x06009BBF RID: 39871 RVA: 0x003D0AD4 File Offset: 0x003CECD4
	public cp3()
	{
		base.Slots.Add(cp3.a, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cp3.b, new cgo(new c6s(ms.j, 8), "Электромагнитный излучатель", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cp3.c, new cgo(new c6s(ms.k, 9), "Модулятор", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009BC0 RID: 39872 RVA: 0x003D0B6C File Offset: 0x003CED6C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(cp3.a, null);
		fv fv2 = A_1.SafeGet(cp3.b, null);
		bit bit = ez2.CreateDefinitonProvider<cdk>("devices\\shieldRecharger");
		if (bit != null && bit.wl() != null && fv != null && fv2 != null)
		{
			fv fv3 = A_1.SafeGet(cp3.c, null);
			double num;
			double num2;
			if (fv3 != null && fv3.TypedDefinition != null)
			{
				num = Math.Max(0.35, (double)(1f + fv3.TypedDefinition.a7().GetPrimitivePropertyValue<float>(vo.e, null).GetValueOrDefault() * (float)fv3.QualityLevel));
				num2 = Math.Min(1.2, (double)(1f + fv3.TypedDefinition.a7().GetPrimitivePropertyValue<float>(vo.f, null).GetValueOrDefault() * (float)fv3.QualityLevel));
			}
			else
			{
				num = 1.0;
				num2 = 1.0;
			}
			acz acz = new acz(bit);
			double num3 = (double)((int)((double)(20 + fv.QualityLevel * 5) * num2));
			int num4 = Math.Max(cp3.f, cp3.g - fv2.QualityLevel / 15);
			int num5 = (int)((double)cp3.h * num);
			double num6 = num3 / (double)num4;
			acz.CustomProperties[vo.b] = num6;
			acz.CustomProperties[vo.a] = num4;
			acz.CustomProperties[vo.c] = num5;
			acz.CustomProperties[vo.d] = Math.Round(num / 2.0, 2);
			acz.MaxBatteryLegacy = Math.Max(10, fv.QualityLevel / 2);
			acz.Battery = (double)(acz.MaxBattery / 2);
			return acz;
		}
		return null;
	}

	// Token: 0x04003B93 RID: 15251
	public new static readonly string a = "core";

	// Token: 0x04003B94 RID: 15252
	public new static readonly string b = "emitter";

	// Token: 0x04003B95 RID: 15253
	public static readonly string c = "modulator";

	// Token: 0x04003B96 RID: 15254
	private new const int d = 20;

	// Token: 0x04003B97 RID: 15255
	private const int e = 5;

	// Token: 0x04003B98 RID: 15256
	public static readonly int f = 3;

	// Token: 0x04003B99 RID: 15257
	public static readonly int g = 13;

	// Token: 0x04003B9A RID: 15258
	public static readonly int h = 750;
}
