using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B6B RID: 7019
[dgg("fusionEmitter")]
public sealed class coe : cwp
{
	// Token: 0x06009805 RID: 38917 RVA: 0x003B35A4 File Offset: 0x003B17A4
	public override string bt()
	{
		return "茧Термоядерный излучатель";
	}

	// Token: 0x06009806 RID: 38918 RVA: 0x003B35AC File Offset: 0x003B17AC
	public override string bu()
	{
		return "fusionEmitter";
	}

	// Token: 0x06009807 RID: 38919 RVA: 0x003B35B4 File Offset: 0x003B17B4
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x06009808 RID: 38920 RVA: 0x003B35B8 File Offset: 0x003B17B8
	public override bool bw()
	{
		return false;
	}

	// Token: 0x06009809 RID: 38921 RVA: 0x003B35BC File Offset: 0x003B17BC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Processing;
	}

	// Token: 0x0600980A RID: 38922 RVA: 0x003B35C0 File Offset: 0x003B17C0
	public coe()
	{
		base.Slots.Add(coe.a, new cgo(new eh0("laserEmitter", 31), "Лазерный излучатель", false, 1, 0.1f, false, false, null));
		base.Slots.Add(coe.b, new cgo(new eh0("electroshockGenerator", 72), "Генератор электрошока", false, 1, 0.1f, false, false, null));
		base.Slots.Add(coe.c, new cgo(new eh0("component.circularWaveAmplifier", 125), "Kольцевой усилитель волны", false, 1, 0.1f, false, false, null));
		base.Slots.Add(coe.d, new cgo(new eh0("emfStabilizer", 38), "Стабилизатор электромагнитного поля", false, 1, 0.1f, false, false, null));
		base.Slots.Add(coe.e, new cgo(new eh0("component.highEfficiencyEnergyConverter", 126), "Высокоэффективный преобразователь энергии", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x0600980B RID: 38923 RVA: 0x003B36C4 File Offset: 0x003B18C4
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		int num = int.MaxValue;
		int num2 = 0;
		double num3 = 0.0;
		foreach (coh coh in A_1.Values)
		{
			fv fv = coh as fv;
			if (fv != null)
			{
				num = Math.Min(fv.QualityLevel, num);
			}
			num3 += coh.SingleItemWeight;
			num2 += coh.SingleItemValue;
		}
		num2 *= 2;
		a1k a1k = new a1k();
		a1k.b(50.0);
		a1k.b(new double?((double)(2000 + num2)));
		a1k.k("fusionEmitter");
		a1k.a(ms.a);
		a1k.i("Создаётся исходная низкоплотная лазерно-индуцированная плазма, которая затем подвергается сильному сжатию для увеличения плотности и инициирования ядерного синтеза. Для нормальной работы требуется соответствующая магнито-инерциальная система удержания и ускорения.");
		a1k.f("&StatusIcons.4");
		a1k.g("Термоядерный излучатель");
		a1k.a(cr1.d);
		a1k.g().Add(new b8w(SkillEnum.Electronics.ToString(), 1.5f));
		a1k.a(a0.aw);
		a1k.h(num3);
		return new fv(new IndependentItemDefinitionProvider<a1k>(a1k))
		{
			QualityLevel = num
		};
	}

	// Token: 0x0600980C RID: 38924 RVA: 0x003B380C File Offset: 0x003B1A0C
	public override string xi()
	{
		return "Термоядерный излучатель является венцом энергетического оружия и требует тщательной сборки множества электронных компонентов.";
	}

	// Token: 0x04003A5B RID: 14939
	public new static readonly string a = "laserEmitter";

	// Token: 0x04003A5C RID: 14940
	public new static readonly string b = "electroshockEmitter";

	// Token: 0x04003A5D RID: 14941
	public static readonly string c = "circularWaveAmplifier";

	// Token: 0x04003A5E RID: 14942
	public new static readonly string d = "electromagneticFieldStabilizer";

	// Token: 0x04003A5F RID: 14943
	public static readonly string e = "highEfficiencyEnergyConverter";
}
