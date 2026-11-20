using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B69 RID: 7017
[dgg("Greaves")]
public sealed class aff : cwp
{
	// Token: 0x060097FB RID: 38907 RVA: 0x003B3034 File Offset: 0x003B1234
	public override string bt()
	{
		return "茜Поножи";
	}

	// Token: 0x060097FC RID: 38908 RVA: 0x003B303C File Offset: 0x003B123C
	public override string bu()
	{
		return "Greaves";
	}

	// Token: 0x060097FD RID: 38909 RVA: 0x003B3044 File Offset: 0x003B1244
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x060097FE RID: 38910 RVA: 0x003B3048 File Offset: 0x003B1248
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Armor;
	}

	// Token: 0x060097FF RID: 38911 RVA: 0x003B3050 File Offset: 0x003B1250
	public aff()
	{
		base.Slots.Add(aff.a, new cgo(new c6s(new ms[]
		{
			ms.ac
		}, 23), "Метал", false, 1, 0.1f, true, false, null));
		base.Slots.Add(aff.b, new cgo(new c6s(ms.e, 2), "Подкладка", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009800 RID: 38912 RVA: 0x003B30C4 File Offset: 0x003B12C4
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(aff.a, null);
		fv fv2 = A_1.SafeGet(aff.b, null);
		if (fv != null && fv2 != null)
		{
			ett ett = fv.TypedDefinition as ett;
			ett ett2 = fv2.TypedDefinition as ett;
			if (ett != null && ett2 != null)
			{
				int num = fv.QualityLevel;
				c5s c5s = new c5s();
				c5s.a(ett.bc());
				c5s.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue)));
				c5s.h(Math.Round(fv.SingleItemWeight / 3.0 + fv2.SingleItemWeight / 2.0, 2));
				c5s.g((int)Math.Ceiling(cwp.a(num)));
				c5s.g("");
				c5s.f("Greaves.");
				c5s.a(ItemStealingCategory.Armor);
				c5s.a(a0.n);
				a12 a = new a12(new IndependentItemDefinitionProvider<c5s>(c5s));
				c6o.a(c5s, ett, num);
				c6o.a(A_0, a, ett, num, true, 0.25, true);
				ett ett3 = ett2.tw() as ett;
				ett3.a().Clear();
				c6o.a(c5s, ett2, fv2.QualityLevel / 3);
				c6o.a(A_0, a, ett3, fv2.QualityLevel, false, 0.25, true);
				c5s c5s2 = c5s;
				c5s2.f(c5s2.a3() + "Metal");
				string classPropertyValue = ett.a7().GetClassPropertyValue<string>("Material");
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					c5s.g(classPropertyValue + " " + c5s.az());
					c5s.i(string.Format("Это {0} поножи.", classPropertyValue.ToLowerInvariant()));
					c5s c5s3 = c5s;
					c5s3.f(c5s3.a3() + "." + classPropertyValue.Replace(" ", ""));
				}
				else
				{
					c5s.i("Эти поножи сделаны из неизвестного сплава.");
				}
				c5s.a(ItemRepairCategory.Mechanical);
				string classPropertyValue2 = ett2.a7().GetClassPropertyValue<string>("BootsDesc");
				double value = ett2.a7().GetPrimitivePropertyValue<double>("MetalHelmetCritModifierBase", new double?((double)1)).Value;
				double value2 = ett2.a7().GetPrimitivePropertyValue<double>("MetalHelmetCritModifierPerQuality", new double?(0.0)).Value;
				double num2 = ett.a7().GetPrimitivePropertyValue<double>("HelmetCritModifier", new double?(0.0)).Value * (value + value2 * (double)fv2.QualityLevel) * 0.5;
				c6o.a(c5s, new awe(CharacterImmunities.KneecapShot));
				c6o.a(c5s, new arh(0.2f));
				c6o.a(c5s, new l5(-num2));
				if (!string.IsNullOrEmpty(classPropertyValue2))
				{
					c5s c5s4 = c5s;
					c5s4.i(c5s4.a0() + " " + classPropertyValue2);
				}
				string classPropertyValue3 = ett2.a7().GetClassPropertyValue<string>("BootsPrefix");
				if (!string.IsNullOrEmpty(classPropertyValue3))
				{
					c5s.g(classPropertyValue3 + " " + c5s.az());
				}
				c5s c5s5 = c5s;
				c5s5.b(c5s5.bf() * (double)2);
				foreach (c3e c3e in c5s.f())
				{
					ean ean = c3e as ean;
					if (ean != null)
					{
						ean.a(true);
					}
					dpx dpx = c3e as dpx;
					if (dpx != null)
					{
						dpx.a(true);
					}
				}
				if (ett.i() == ms.ac)
				{
					dpw dpw = Enumerable.FirstOrDefault<dpw>(Enumerable.Where<dpw>(Enumerable.OfType<dpw>(c5s.ar()), new Func<dpw, bool>(aff.a.a.a)));
					if (dpw != null && dpw.c() > 0)
					{
						c5s.ar().Remove(dpw);
					}
				}
				c5s.b(0);
				c5s c5s6 = c5s;
				c5s6.g(c5s6.az() + "поножи");
				c5s.b(Math.Round(c5s.h() * 0.6, 2));
				return a;
			}
		}
		return null;
	}

	// Token: 0x04003A57 RID: 14935
	public new static readonly string a = "material";

	// Token: 0x04003A58 RID: 14936
	public new static readonly string b = "padding";

	// Token: 0x02001B6A RID: 7018
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009804 RID: 38916 RVA: 0x003B3590 File Offset: 0x003B1790
		internal bool a(dpw A_0)
		{
			return string.Equals(A_0.SkillName, "stealth", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04003A59 RID: 14937
		public static readonly aff.a a = new aff.a();

		// Token: 0x04003A5A RID: 14938
		public static Func<dpw, bool> b;
	}
}
