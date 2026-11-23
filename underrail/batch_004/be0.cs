using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B6C RID: 7020
[dgg("fusionCannon")]
public sealed class be0 : c4r
{
	// Token: 0x0600980E RID: 38926 RVA: 0x003B3848 File Offset: 0x003B1A48
	public override string bt()
	{
		return "茨Термоядерная пушка";
	}

	// Token: 0x0600980F RID: 38927 RVA: 0x003B3850 File Offset: 0x003B1A50
	public override string bu()
	{
		return "fusionCannon";
	}

	// Token: 0x06009810 RID: 38928 RVA: 0x003B3858 File Offset: 0x003B1A58
	public override cr1 bv()
	{
		return cr1.e;
	}

	// Token: 0x06009811 RID: 38929 RVA: 0x003B385C File Offset: 0x003B1A5C
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009812 RID: 38930 RVA: 0x003B3860 File Offset: 0x003B1A60
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009813 RID: 38931 RVA: 0x003B3868 File Offset: 0x003B1A68
	public be0()
	{
		base.Slots.Add(be0.a, new cgo(new eh0("fusionCannonFrame", 134), "Рама термоядерной пушки", false, 1, 0.1f, false, false, null));
		base.Slots.Add(be0.b, new cgo(new eh0("fusionEmitter", 135), "Термоядерный излучатель", false, 1, 0.1f, false, false, null));
		base.Slots.Add(be0.c, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009814 RID: 38932 RVA: 0x003B390C File Offset: 0x003B1B0C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(be0.a, null);
		fv fv2 = A_1.SafeGet(be0.b, null);
		fv fv3 = A_1.SafeGet(be0.c, null);
		if (fv != null && fv2 != null && fv3 != null)
		{
			double a_ = cwp.a(fv2);
			double num = 20.0;
			double num2 = 0.1;
			bke bke = new bke();
			bke.a(AmmoType.Energy);
			bke.d(Math.Round(num + num2 * (double)fv2.QualityLevel, 1));
			bke.b(new double?((double)100000));
			bke.h(fv.SingleItemWeight + fv2.SingleItemWeight + fv3.SingleItemWeight);
			bke.g((int)Math.Ceiling(a_));
			bke.a(fv.TypedDefinition.bc());
			bke.a(bhx.o);
			bke.@as().Add(new aia("FusionCannonAttackGround"));
			bke.b(0.15000000596046448);
			bke.a(0.35f);
			bke.a(ItemStealingCategory.WeaponHeavy);
			bke.a(a0.f);
			bke.a(2.0);
			c4r.a(bke, btz.i, WeaponSubtype.FusionCannon, fv2.TypedDefinition);
			bke.c(0);
			bke.b(8);
			bke.c("humanFusionCannon");
			bke.a(ItemRepairCategory.Electronic);
			bke.b("xphwf");
			bke.g("Fusion Cannon");
			bke.i("Экспериментальная ручная термоядерная пушка, возможно, единственный представитель портативного типа. Работает за счёт имплозии магнито-управляемого плазмоцида с помощью лазерно-индуцированной кавитации и его ускорения к цели в момент начала ядерного синтеза между его сжатыми частицами. <br><br>Предупреждение: Небольшое излучение радиоактивных нейтронных частиц.");
			bke.f("&StatusIcons.2");
			bke.c(new int?(c6o.a(fv3, A_0) * 2));
			b1j b1j = c4r.a(A_0, WeaponSubtype.FusionCannon, a_, 1.0, null, null);
			bke.l().Add(new a1q(DamageType.Energy, Convert.ToInt32(b1j.b / 2.0), Convert.ToInt32(b1j.c / 2.0)));
			bke.l().Add(new a1q(DamageType.Electricity, Convert.ToInt32(b1j.b / 2.0), Convert.ToInt32(b1j.c / 2.0)));
			if (A_0 != null && A_0.Feats.Contains<cnz>())
			{
				bke bke2 = bke;
				bke2.c(bke2.y() + (cnz.a + (double)A_0.GetSpecializationValue<ek8>(true) * ek8.a));
			}
			return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
		}
		return null;
	}

	// Token: 0x06009815 RID: 38933 RVA: 0x003B3BAC File Offset: 0x003B1DAC
	public override string xi()
	{
		return "Вы раскрыли секреты термоядерного оружия.";
	}

	// Token: 0x04003A60 RID: 14944
	public new static readonly string a = "frame";

	// Token: 0x04003A61 RID: 14945
	public new static readonly string b = "emitter";

	// Token: 0x04003A62 RID: 14946
	public static readonly string c = "core";
}
