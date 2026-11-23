using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BAA RID: 7082
[dgg("spyingEndoscope")]
public sealed class aol : cwp
{
	// Token: 0x060099DA RID: 39386 RVA: 0x003BF610 File Offset: 0x003BD810
	public override string bt()
	{
		return "荍Шпионский эндоскоп";
	}

	// Token: 0x060099DB RID: 39387 RVA: 0x003BF618 File Offset: 0x003BD818
	public override string bu()
	{
		return "spyingEndoscope";
	}

	// Token: 0x060099DC RID: 39388 RVA: 0x003BF620 File Offset: 0x003BD820
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060099DD RID: 39389 RVA: 0x003BF624 File Offset: 0x003BD824
	public override bool bw()
	{
		return true;
	}

	// Token: 0x060099DE RID: 39390 RVA: 0x003BF628 File Offset: 0x003BD828
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Devices;
	}

	// Token: 0x060099DF RID: 39391 RVA: 0x003BF630 File Offset: 0x003BD830
	public aol()
	{
		base.Slots.Add("lens", new cgo(new eh0("adaptiveLens", 41), "Адаптивные линзы", false, 1, 0.1f, false, false, null));
		base.Slots.Add("opticalFiber", new cgo(new eh0("opticalFiber", 90), "Оптическое волокно", false, 10, 0.1f, false, false, null));
		base.Slots.Add("eyepiece", new cgo(new eh0("endoscopeEyepiece", 91), "Окуляр эндоскопа", false, 1, 0.1f, false, false, null));
		base.Slots.Add("nightvision", new cgo(new eh0("imageIntesifierTube", 43), "Усилитель яркости изображения", true, 1, 0.1f, false, false, null));
		base.Slots.Add("energyCore", new cgo(new c6s(ms.i, 7), "Энергетическое ядро", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x060099E0 RID: 39392 RVA: 0x003BF730 File Offset: 0x003BD930
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		bool flag = A_1.SafeGet("lens", null) != null;
		fv fv = A_1.SafeGet("opticalFiber", null);
		fv fv2 = A_1.SafeGet("eyepiece", null);
		fv fv3 = A_1.SafeGet("nightvision", null);
		fv fv4 = A_1.SafeGet("energyCore", null);
		if (flag && fv != null && fv2 != null)
		{
			if (fv3 != null && fv4 == null)
			{
				A_2 = "Нужно добавить энергетическое ядро.";
			}
			if (fv3 == null && fv4 != null)
			{
				A_2 = "Энергетическое ядро ничего не питает.";
			}
			string path;
			if (fv3 != null && fv4 != null)
			{
				path = "devices\\xpbl\\nightVisionSpyingEndoscope";
			}
			else
			{
				path = "devices\\xpbl\\spyingEndoscope";
			}
			if (ez2.GetItemDefinition<ebz>(path, true) != null)
			{
				d48 d = new d48(ez2.CreateDefinitonProvider<ebz>(path));
				if (fv3 != null && fv4 != null)
				{
					d.MaxBatteryLegacy = c6o.a(fv4, A_0);
					int num = 5;
					num = Math.Min(d.MaxBattery, num);
					d.CustomProperties["EnergyCost"] = num;
				}
				return d;
			}
		}
		return null;
	}
}
