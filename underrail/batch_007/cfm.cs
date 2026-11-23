using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BDE RID: 7134
[dgg("energyPistol")]
public sealed class cfm : c4r, bd3
{
	// Token: 0x06009B4F RID: 39759 RVA: 0x003CA560 File Offset: 0x003C8760
	public override string bt()
	{
		return "荈Энергетический пистолет";
	}

	// Token: 0x06009B50 RID: 39760 RVA: 0x003CA568 File Offset: 0x003C8768
	public override string bu()
	{
		return "energyPistol";
	}

	// Token: 0x06009B51 RID: 39761 RVA: 0x003CA570 File Offset: 0x003C8770
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009B52 RID: 39762 RVA: 0x003CA574 File Offset: 0x003C8774
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B53 RID: 39763 RVA: 0x003CA578 File Offset: 0x003C8778
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009B54 RID: 39764 RVA: 0x003CA57C File Offset: 0x003C877C
	public cfm()
	{
		string[] a_ = new string[]
		{
			"smartModule",
			"component.circularWaveAmplifier",
			"component.highEfficiencyEnergyConverter",
			"polarizer"
		};
		base.Slots.Add(cfm.a, new cgo(new c6s(ms.al, 30), "Рама", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cfm.b, new cgo(new eh0(new string[]
		{
			"laserEmitter",
			"plasmaDischarger",
			"electroshockGenerator"
		}, 31), "Излучатель", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cfm.c, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cfm.d, new cgo(new eh0(a_, 15), "Улучшение энергетического оружия", true, 1, 0f, false, false, null));
		base.Slots.Add(cfm.e, new cgo(new eh0(a_, 15), "Улучшение энергетического оружия", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009B55 RID: 39765 RVA: 0x003CA6B0 File Offset: 0x003C88B0
	public List<bj8> bz()
	{
		int num = 25;
		int num2 = 0;
		string a_ = "Weapons";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 1; i++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("energyPistol.{0}.frame", i + 1));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			for (int j = 0; j < 3; j++)
			{
				for (int k = 0; k < 1; k++)
				{
					for (int l = 0; l < 2; l++)
					{
						for (int m = 0; m < 2; m++)
						{
							for (int n = 0; n < 2; n++)
							{
								for (int num3 = 0; num3 < 2; num3++)
								{
									bj = new bj8();
									bj.a(string.Format("energyPistol.{0}.{1}.{2}", i + 1, j + 1, k + 1));
									bj.a().Add(new d8h(a_, new Point(num + 1 + j % 2, num2 + i + j / 2), 1f));
									bj.a().Add(new d8h(a_, new Point(num + k + 3, num2 + i), 1f));
									if (m == 1)
									{
										bj8 bj2 = bj;
										bj2.a(bj2.c() + ".amp");
										bj.a().Add(new d8h(a_, new Point(num + 1, num2 + 3), 1f));
									}
									if (n == 1)
									{
										bj8 bj3 = bj;
										bj3.a(bj3.c() + ".converter");
										bj.a().Add(new d8h(a_, new Point(num + 2, num2 + 3), 1f));
									}
									if (num3 == 1)
									{
										bj8 bj4 = bj;
										bj4.a(bj4.c() + ".polarizer");
										bj.a().Insert(0, new d8h(a_, new Point(num + 1, num2 + 4), 1f));
										bj.a().Insert(1, new d8h(a_, new Point(num + 2, num2 + 4), 0.4f));
									}
									if (l == 1)
									{
										bj8 bj5 = bj;
										bj5.a(bj5.c() + ".smart");
										bj.a().Add(new d8h(a_, new Point(num + 1, num2 + 2), 1f));
										bj.a().Add(new d8h(a_, new Point(num + 2, num2 + 2), 0.4f));
									}
									list.Add(bj);
								}
							}
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06009B56 RID: 39766 RVA: 0x003CA98C File Offset: 0x003C8B8C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(cfm.a, null);
		fv fv2 = A_1.SafeGet(cfm.b, null);
		fv fv3 = A_1.SafeGet(cfm.c, null);
		if (fv == null || fv.TypedDefinition == null || fv2 == null || fv2.TypedDefinition == null || fv3 == null || fv3.TypedDefinition == null)
		{
			return null;
		}
		double a_ = cwp.a(fv2);
		double value = fv2.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BaseEnergyUsage", new double?((double)1)).Value;
		double value2 = fv2.TypedDefinition.a7().GetPrimitivePropertyValue<double>("EnergyUsagePerQuality", new double?(0.1)).Value;
		int value3 = fv.TypedDefinition.a7().GetPrimitivePropertyValue<int>("EnergyPistolIndex", new int?(1)).Value;
		int value4 = fv2.TypedDefinition.a7().GetPrimitivePropertyValue<int>("EnergyPistolIndex", new int?(1)).Value;
		int value5 = fv3.TypedDefinition.a7().GetPrimitivePropertyValue<int>("EnergyPistolIndex", new int?(1)).Value;
		bke bke = new bke();
		bke.a(AmmoType.Energy);
		bke.d(value + value2 * (double)fv2.QualityLevel);
		bke.b(new double?((double)(fv.SingleItemValue + fv3.SingleItemValue + fv2.SingleItemValue)));
		bke.h(fv.SingleItemWeight + fv3.SingleItemWeight + fv2.SingleItemWeight);
		bke.g((int)Math.Ceiling(a_));
		bke.a(fv2.TypedDefinition.bc());
		bke.a(ItemStealingCategory.Weapon);
		bke.a(a0.f);
		WeaponSubtype weaponSubtype = this.a(value4);
		c4r.a(bke, btz.a, weaponSubtype, fv.TypedDefinition);
		if (A_0 != null && A_0.Feats.Contains<cnz>())
		{
			bke bke2 = bke;
			bke2.c(bke2.y() + (cnz.a + (double)A_0.GetSpecializationValue<ek8>(true) * ek8.a));
		}
		b1j b1j = c4r.a(A_0, weaponSubtype, a_, 1.0, null, null);
		if (weaponSubtype == WeaponSubtype.Pistol_Electro)
		{
			bke.a(bhx.p);
			bke.l().Add(new a1q(DamageType.Electricity, (int)b1j.b, (int)b1j.c));
			bke bke3 = bke;
			bke3.d(bke3.h() - 2f);
			bke bke4 = bke;
			bke4.c(bke4.ad() - 3f);
			bke.aa().Add(new edm("ElectroboltChain", 1.0, 3, true));
		}
		else if (weaponSubtype == WeaponSubtype.Pistol_Plasma)
		{
			bke.a(bhx.n);
			bke.l().Add(new a1q(DamageType.Energy, (int)(b1j.b / 2.0), (int)Math.Ceiling(b1j.c / 2.0)));
			bke.l().Add(new a1q(DamageType.Heat, (int)(b1j.b / 2.0), (int)Math.Ceiling(b1j.c / 2.0)));
			bke bke5 = bke;
			bke5.d(bke5.h() - 2f);
			bke bke6 = bke;
			bke6.c(bke6.ad() - 2f);
		}
		else
		{
			bke.g(0.05000000074505806);
			bke.a(bhx.q);
			bke.l().Add(new a1q(DamageType.Energy, (int)b1j.b, (int)b1j.c));
		}
		bke.g(fv2.TypedDefinition.a7().GetClassPropertyValue<string>("EnergyWeaponType") + " пистолет");
		bke.i(qv.a("Items\\Weapons/EnergyPistol", new object[]
		{
			bke.az().ToLowerInvariant(),
			fv3.TypedDefinition.az().ToLowerInvariant()
		}));
		fv3.TypedDefinition.a7().GetClassPropertyValue<string>("PowerSourcePrefix");
		bke.f(string.Format("energyPistol.{0}.{1}.{2}", value3, value4, value5));
		fv fv4 = A_1.SafeGet(cfm.d, null);
		fv fv5 = A_1.SafeGet(cfm.e, null);
		if (fv4 != null && fv5 != null && fv4.TypedDefinition.a5() != null && fv4.TypedDefinition.a5() == fv5.TypedDefinition.a5())
		{
			A_2 = "Нельзя установить два улучшения одного типа.";
			return null;
		}
		foreach (fv fv6 in Enumerable.OrderBy<fv, string>(new fv[]
		{
			fv4,
			fv5
		}, new Func<fv, string>(cfm.a.a.a)))
		{
			if (fv6 != null)
			{
				this.a(bke, fv6, weaponSubtype);
			}
		}
		bke bke7 = bke;
		bke7.b(bke7.bf() * (double)2);
		bke.a(ItemRepairCategory.Electronic);
		bke.b("ep");
		cd1 cd = new cd1(new IndependentItemDefinitionProvider<bke>(bke));
		this.a(cd, A_0);
		bke.c(new int?(c6o.a(fv3, A_0)));
		return cd;
	}

	// Token: 0x06009B57 RID: 39767 RVA: 0x003CAF4C File Offset: 0x003C914C
	private void a(cd1 A_0, efk A_1)
	{
		if (A_1 != null)
		{
			a7z microfeat = A_1.GetMicrofeat<a7z>();
			if (microfeat != null)
			{
				A_0.TypedDefinition.f(Math.Max(0.0, A_0.TypedDefinition.ai() + microfeat.a()));
			}
		}
	}

	// Token: 0x06009B58 RID: 39768 RVA: 0x003CAF98 File Offset: 0x003C9198
	private void a(bke A_0, fv A_1, WeaponSubtype A_2)
	{
		A_0.b(A_0.bf() + (double)A_1.SingleItemValue);
		A_0.h(A_0.a4() + A_1.SingleItemWeight);
		if (A_1.TypedDefinition.bc() > A_0.bc())
		{
			A_0.a(A_1.TypedDefinition.bc());
		}
		if (A_1.TypedDefinition.a5() == "smartModule")
		{
			A_0.ar().Add(new efx(0.15 + 0.003 * (double)A_1.QualityLevel, cs5.a));
			A_0.g("Умный " + A_0.az());
			A_0.i(A_0.a0() + " Имеет модуль с программой, облегчающей прицеливание, что повышает эффективность точных выстрелов.");
			A_0.d(A_0.k() + (1.0 + A_0.k() * 0.1));
			A_0.f(A_0.a3() + ".smart");
			return;
		}
		if (A_1.TypedDefinition.a5() == "component.circularWaveAmplifier")
		{
			A_0.c(Math.Round(A_0.y() + 0.35 + 0.01 * (double)A_1.QualityLevel, 2));
			A_0.g("Усиленный " + A_0.az());
			A_0.i(A_0.a0() + " Он оснащён кольцевым усилителем волны, который иногда повышает выходную мощность.");
			A_0.d(A_0.k() + (1.0 + A_0.k() * 0.1));
			A_0.f(A_0.a3() + ".amp");
			return;
		}
		if (A_1.TypedDefinition.a5() == "component.highEfficiencyEnergyConverter")
		{
			double num = Math.Max(0.2, 0.9 - 0.4 * ((double)A_1.QualityLevel / 100.0));
			A_0.g("Эффективный " + A_0.az());
			A_0.i(A_0.a0() + " Установленный конвертер энергии уменьшает потребление энергии на каждый выстрел.");
			A_0.d(A_0.k() * num);
			A_0.f(A_0.a3() + ".converter");
			return;
		}
		if (A_1.TypedDefinition.a5() == "polarizer")
		{
			Math.Max(0.2, 0.9 - 0.4 * ((double)A_1.QualityLevel / 100.0));
			A_0.g("Поляризаторн. " + A_0.az());
			A_0.i(A_0.a0() + " Поляризатор, прикреплённый под излучателем, позволяет энергетическому снаряду сделать объект более уязвимым для последующих атак.");
			A_0.d(A_0.k() * 1.2);
			A_0.f(A_0.a3() + ".polarizer");
			double num2 = Math.Round(0.02 * ((double)A_1.QualityLevel / 100.0) * (double)as3.af[A_2], 2);
			int num3 = (int)Math.Ceiling(num2);
			num2 = Math.Min(1.0, num2 * Math.Pow(0.8, (double)(num3 - 1)));
			A_0.aa().Add(new edm("polarize", num2, num3, true));
		}
	}

	// Token: 0x06009B59 RID: 39769 RVA: 0x003CB340 File Offset: 0x003C9540
	private WeaponSubtype a(int A_0)
	{
		if (A_0 > 2)
		{
			return WeaponSubtype.Pistol_Electro;
		}
		if (A_0 > 1)
		{
			return WeaponSubtype.Pistol_Plasma;
		}
		return WeaponSubtype.Pistol_Laser;
	}

	// Token: 0x04003B63 RID: 15203
	public new static readonly string a = "frame";

	// Token: 0x04003B64 RID: 15204
	public new static readonly string b = "projector";

	// Token: 0x04003B65 RID: 15205
	public static readonly string c = "energyCore";

	// Token: 0x04003B66 RID: 15206
	public new static readonly string d = "enhancement1";

	// Token: 0x04003B67 RID: 15207
	public static readonly string e = "enhancement2";

	// Token: 0x02001BDF RID: 7135
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009B5D RID: 39773 RVA: 0x003CB3A0 File Offset: 0x003C95A0
		internal string a(fv A_0)
		{
			if (A_0 == null)
			{
				return null;
			}
			return A_0.Definition.az();
		}

		// Token: 0x04003B68 RID: 15208
		public static readonly cfm.a a = new cfm.a();

		// Token: 0x04003B69 RID: 15209
		public static Func<fv, string> b;
	}
}
