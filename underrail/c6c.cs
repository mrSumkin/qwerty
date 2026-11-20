using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BC3 RID: 7107
[dgg("energyShieldEmitter")]
public sealed class c6c : cwp, bd3
{
	// Token: 0x06009A8E RID: 39566 RVA: 0x003C2594 File Offset: 0x003C0794
	public override string bt()
	{
		return "荊Энергетический щит";
	}

	// Token: 0x06009A8F RID: 39567 RVA: 0x003C259C File Offset: 0x003C079C
	public override string bu()
	{
		return "energyShieldEmitter";
	}

	// Token: 0x06009A90 RID: 39568 RVA: 0x003C25A4 File Offset: 0x003C07A4
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A91 RID: 39569 RVA: 0x003C25A8 File Offset: 0x003C07A8
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009A92 RID: 39570 RVA: 0x003C25AC File Offset: 0x003C07AC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Devices;
	}

	// Token: 0x06009A93 RID: 39571 RVA: 0x003C25B4 File Offset: 0x003C07B4
	public c6c()
	{
		base.Slots.Add(c6c.a, new cgo(new c6s(new ms[]
		{
			ms.bb
		}, 66), "Основа", false, 1, 0.1f, false, false, null));
		base.Slots.Add(c6c.b, new cgo(new c6s(ms.bc, 67), "Основной модулятор", false, 1, 0.1f, false, false, null));
		base.Slots.Add(c6c.c, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", false, 1, 0.1f, false, false, null));
		base.Slots.Add(c6c.d, new cgo(new c6s(ms.bc, 67), "Дополнительный модулятор", true, 1, 0.3f, false, false, null));
		base.Slots.Add(c6c.e, new cgo(new c6s(ms.bd, 15), "Улучшение", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009A94 RID: 39572 RVA: 0x003C26B0 File Offset: 0x003C08B0
	public List<bj8> bz()
	{
		int num = 0;
		int num2 = 17;
		string a_ = "Armors";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 3; i++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("shieldEmitter.p{0}", i));
			bj.a().Add(new d8h(a_, new Point(num + i, num2), 1f));
			list.Add(bj);
			for (int j = 0; j < 3; j++)
			{
				bj = new bj8();
				bj.a(string.Format("shieldEmitter.p{0}.s{1}", i, j));
				bj.a().Add(new d8h(a_, new Point(num + i, num2), 1f));
				bj.a().Add(new d8h(a_, new Point(num + j, num2 + 1), 1f));
				list.Add(bj);
				for (int k = 0; k < 3; k++)
				{
					bj = new bj8();
					bj.a(string.Format("shieldEmitter.p{0}.s{1}.e{2}", i, j, k));
					bj.a().Add(new d8h(a_, new Point(num + i, num2), 1f));
					bj.a().Add(new d8h(a_, new Point(num + j, num2 + 1), 1f));
					bj.a().Add(new d8h(a_, new Point(num + k, num2 + 2), 1f));
					list.Add(bj);
				}
			}
			for (int l = 0; l < 3; l++)
			{
				bj = new bj8();
				bj.a(string.Format("shieldEmitter.p{0}.e{1}", i, l));
				bj.a().Add(new d8h(a_, new Point(num + i, num2), 1f));
				bj.a().Add(new d8h(a_, new Point(num + l, num2 + 2), 1f));
				list.Add(bj);
			}
		}
		return list;
	}

	// Token: 0x06009A95 RID: 39573 RVA: 0x003C28EC File Offset: 0x003C0AEC
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(c6c.a, null);
		fv fv2 = A_1.SafeGet(c6c.b, null);
		fv fv3 = A_1.SafeGet(c6c.c, null);
		if (fv != null && fv2 != null && fv3 != null && fv.TypedDefinition != null && fv2.TypedDefinition != null && fv3.TypedDefinition != null)
		{
			b3n b3n = new b3n();
			b3n.g("энергетический щит");
			b3n.a(fv2.TypedDefinition.bc());
			b3n.a2().Add(new aia(typeof(d0i)));
			b3n.a(as3.g);
			b3n.b(as3.i);
			b3n.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue + fv3.SingleItemValue)));
			b3n.a(a0.aj);
			b3n.a(new Color(75, 75, 255));
			b3n.a(fv2.TypedDefinition.a7().GetClassPropertyValue<string>("ShieldVisualModel"));
			b3n.h(fv.SingleItemWeight + fv2.SingleItemWeight + fv3.SingleItemWeight);
			b3n.f(string.Format("shieldEmitter.p{0}", fv2.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ModulatorIndex", new int?(0)).Value));
			b3n.i(false);
			string classPropertyValue = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("Prefix");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				b3n.g(classPropertyValue + " " + b3n.az());
			}
			b3n.i(qv.a("Items\\ShieldEmitters/Base", new object[]
			{
				(!string.IsNullOrEmpty(classPropertyValue)) ? (" " + classPropertyValue.ToLowerInvariant()) : "неизвестный"
			}));
			foreach (object obj in Enum.GetValues(typeof(ImpactSpeed)))
			{
				ImpactSpeed a_ = (ImpactSpeed)obj;
				b3n.a().Add(new z3(a_, 0));
			}
			this.a(b3n, fv2, 1.0);
			fv fv4 = A_1.SafeGet(c6c.d, null);
			if (fv4 != null && fv4.TypedDefinition != null)
			{
				this.a(b3n, fv4, 0.5);
				b3n b3n2 = b3n;
				b3n2.b(b3n2.bf() + (double)fv4.SingleItemValue);
				b3n b3n3 = b3n;
				b3n3.h(b3n3.a4() + fv4.SingleItemWeight);
				b3n b3n4 = b3n;
				b3n4.f(b3n4.a3() + string.Format(".s{0}", fv4.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ModulatorIndex", new int?(0)).Value));
				string classPropertyValue2 = fv4.TypedDefinition.a7().GetClassPropertyValue<string>("Prefix");
				if (!string.IsNullOrEmpty(classPropertyValue2))
				{
					b3n b3n5 = b3n;
					b3n5.i(b3n5.a0() + " " + qv.a("Items\\ShieldEmitters/SecondaryModulator", new object[]
					{
						classPropertyValue2.ToLowerInvariant()
					}));
				}
			}
			fv fv5 = A_1.SafeGet(c6c.e, null);
			if (fv5 != null && fv5.TypedDefinition != null)
			{
				this.a(b3n, fv5);
			}
			b3n.b(b3n.f() * 0.9f);
			b3n.a(b3n.f() * 0.5f);
			b3n b3n6 = b3n;
			b3n6.b(b3n6.bf() * 1.5);
			coh result = new cgd(new IndependentItemDefinitionProvider<b3n>(b3n));
			b3n.c(new int?(c6o.a(fv3, A_0)));
			return result;
		}
		return null;
	}

	// Token: 0x06009A96 RID: 39574 RVA: 0x003C2D34 File Offset: 0x003C0F34
	private void a(b3n A_0, fv A_1, double A_2)
	{
		c51 c = A_1.Definition as c51;
		if (c != null)
		{
			using (List<f1>.Enumerator enumerator = c.a().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					c6c.a a = new c6c.a();
					a.a = enumerator.Current;
					int num = A_0.a().FindIndex(new Predicate<z3>(a.a));
					z3 z;
					if (num == -1)
					{
						z = default(z3);
					}
					else
					{
						z = A_0.a()[num];
					}
					z.ImpactSpeed = a.a.b();
					z.Value += (int)(((double)a.a.a() + a.a.c() * (double)A_1.QualityLevel) * A_2);
					if (num == -1)
					{
						A_0.a().Add(z);
					}
					else
					{
						A_0.a()[num] = z;
					}
				}
			}
		}
	}

	// Token: 0x06009A97 RID: 39575 RVA: 0x003C2E4C File Offset: 0x003C104C
	private void a(b3n A_0, fv A_1)
	{
		string classPropertyValue = A_1.TypedDefinition.a7().GetClassPropertyValue<string>("Prefix");
		if (!string.IsNullOrEmpty(classPropertyValue))
		{
			A_0.g(classPropertyValue + " " + A_0.az());
		}
		Color? primitivePropertyValue = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<Color>("ShieldColor", null);
		if (primitivePropertyValue != null)
		{
			A_0.a(primitivePropertyValue.Value);
		}
		A_0.b(A_0.bf() + (double)A_1.SingleItemValue);
		A_0.h(A_0.a4() + A_1.SingleItemWeight);
		A_0.f(A_0.a3() + string.Format(".e{0}", A_1.TypedDefinition.a7().GetPrimitivePropertyValue<int>("EnhancementIndex", new int?(0)).Value));
		string classPropertyValue2 = A_1.TypedDefinition.a7().GetClassPropertyValue<string>("Description");
		if (!string.IsNullOrEmpty(classPropertyValue2))
		{
			A_0.i(A_0.a0() + " " + classPropertyValue2);
		}
		if (A_1.TypedDefinition.bc() > A_0.bc())
		{
			A_0.a(A_1.TypedDefinition.bc());
		}
		double? primitivePropertyValue2 = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BaseShieldingModifier", null);
		double? primitivePropertyValue3 = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<double>("ShieldingModifierPerQuality", null);
		if (primitivePropertyValue2 != null && primitivePropertyValue3 != null)
		{
			double num = primitivePropertyValue2.Value + primitivePropertyValue3.Value * (double)A_1.QualityLevel;
			for (int i = 0; i < A_0.a().Count; i++)
			{
				z3 value = A_0.a()[i];
				value.Value = Math.Max(1, value.Value + (int)((double)value.Value * num));
				A_0.a()[i] = value;
			}
		}
		double? primitivePropertyValue4 = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BaseConversionRateModifier", null);
		double? primitivePropertyValue5 = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<double>("ConversionRateModifierPerQuality", null);
		if (primitivePropertyValue4 != null && primitivePropertyValue5 != null)
		{
			double num2 = primitivePropertyValue4.Value + primitivePropertyValue5.Value * (double)A_1.QualityLevel;
			A_0.a(Math.Max(as3.h, A_0.e() + num2));
		}
		double? primitivePropertyValue6 = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BaseDissipationRateModifier", null);
		double? primitivePropertyValue7 = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<double>("DissipationModifierPerQuality", null);
		if (primitivePropertyValue6 != null && primitivePropertyValue7 != null)
		{
			double num3 = primitivePropertyValue6.Value + primitivePropertyValue7.Value * (double)A_1.QualityLevel;
			A_0.b(d05.b(as3.j, A_0.b() + num3, as3.k));
		}
	}

	// Token: 0x04003B09 RID: 15113
	public new static readonly string a = "base";

	// Token: 0x04003B0A RID: 15114
	public new static readonly string b = "primaryModulator";

	// Token: 0x04003B0B RID: 15115
	public static readonly string c = "energyCore";

	// Token: 0x04003B0C RID: 15116
	public new static readonly string d = "secondaryModulator";

	// Token: 0x04003B0D RID: 15117
	public static readonly string e = "enhancement";

	// Token: 0x02001BC4 RID: 7108
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06009A9A RID: 39578 RVA: 0x003C31E4 File Offset: 0x003C13E4
		internal bool a(z3 A_0)
		{
			return A_0.ImpactSpeed == this.a.b();
		}

		// Token: 0x04003B0E RID: 15118
		public f1 a;
	}
}
