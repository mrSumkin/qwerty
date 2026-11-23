using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B9D RID: 7069
[dgg("shotgun")]
public sealed class dmq : c4r, bd3
{
	// Token: 0x0600997B RID: 39291 RVA: 0x003BC774 File Offset: 0x003BA974
	public override string bt()
	{
		return "茣Дробовик";
	}

	// Token: 0x0600997C RID: 39292 RVA: 0x003BC77C File Offset: 0x003BA97C
	public override string bu()
	{
		return "shotgun";
	}

	// Token: 0x0600997D RID: 39293 RVA: 0x003BC784 File Offset: 0x003BA984
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x0600997E RID: 39294 RVA: 0x003BC788 File Offset: 0x003BA988
	public override bool bw()
	{
		return true;
	}

	// Token: 0x0600997F RID: 39295 RVA: 0x003BC78C File Offset: 0x003BA98C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009980 RID: 39296 RVA: 0x003BC790 File Offset: 0x003BA990
	public dmq()
	{
		base.Slots.Add(dmq.a, new cgo(new c6s(ms.bo, 103), "Рама", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dmq.b, new cgo(new c6s(ms.bl, 17), "Ствол", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dmq.c, new cgo(new eh0(new string[]
		{
			"shotgunChoke",
			"shotgunTubeExtension",
			"forwardGrip"
		}, 15), "Улучшение дробовика", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009981 RID: 39297 RVA: 0x003BC848 File Offset: 0x003BAA48
	public List<bj8> bz()
	{
		int num = 21;
		int num2 = 0;
		int num3 = 6;
		string a_ = "xpbl_Weapons";
		List<bj8> list = new List<bj8>();
		foreach (string arg in new string[]
		{
			"shotgun",
			"combatShotgun"
		})
		{
			for (int j = 0; j < 3; j++)
			{
				bj8 bj = new bj8();
				bj.a(string.Format("{0}.{1}.frame", arg, j + 1));
				bj.a().Add(new d8h(a_, new Point(num, num2 + j * 2), 1f));
				list.Add(bj);
				for (int k = 0; k < 2; k++)
				{
					for (int l = 0; l < 2; l++)
					{
						for (int m = 0; m < 2; m++)
						{
							for (int n = 0; n < 2; n++)
							{
								bj = new bj8();
								bj.a(string.Format("{0}.{1}.{2}", arg, j + 1, k + 1));
								bj.a().Add(new d8h(a_, new Point(num + 1, num2 + j * 2 + k), 1f));
								bool flag = false;
								if (l == 1)
								{
									bj.a(c4r.a(bj.c(), "a", ref flag));
									bj.a().Add(new d8h(a_, new Point(num + 2, num2 + j * 2 + k), 1f));
								}
								if (m == 1)
								{
									bj.a(c4r.a(bj.c(), "b", ref flag));
									bj.a().Add(new d8h(a_, new Point(num + 3, num2 + j * 2 + k), 1f));
								}
								if (n == 1)
								{
									bj.a(c4r.a(bj.c(), "c", ref flag));
									bj.a().Add(new d8h(a_, new Point(num + 4, num2 + j * 2 + k), 1f));
								}
								list.Add(bj);
							}
						}
					}
				}
			}
			num += num3;
		}
		return list;
	}

	// Token: 0x06009982 RID: 39298 RVA: 0x003BCAA8 File Offset: 0x003BACA8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(dmq.a, null);
		fv fv2 = A_1.SafeGet(dmq.b, null);
		fv fv3 = A_1.SafeGet(dmq.c, null);
		if (fv != null && fv2 != null)
		{
			WeaponSubtype value = fv.TypedDefinition.a7().GetPrimitivePropertyValue<WeaponSubtype>("ShotgunType", new WeaponSubtype?(WeaponSubtype.Shotgun_Regular)).Value;
			double a_ = cwp.a(fv);
			bke bke = new bke();
			bke.a(AmmoType.ShotgunShell);
			bke.d(1.0);
			bke.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue)));
			bke.h(fv.SingleItemWeight + fv2.SingleItemWeight);
			bke.g((int)Math.Ceiling(a_));
			bke.a(fv.TypedDefinition.bc());
			bke.a2().Add(new aia("uwep"));
			bke.a(ItemStealingCategory.Weapon);
			bke.a(a0.e);
			bke.a(new int?(50));
			bke.c("shotgun");
			c4r.a(bke, btz.e, value, fv.TypedDefinition);
			if (value == WeaponSubtype.Shotgun_Combat)
			{
				bke.a(bhx.aa);
				bke.@as().Add(new aia(dgk.Get<bom>()));
				bke.b("xpblsa");
				bke.a(car.c);
			}
			else
			{
				bke.a(bhx.z);
				bke.b("xpblsg");
				bke.a(car.b);
			}
			b1j? primitivePropertyValue = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpread", null);
			b1j? primitivePropertyValue2 = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpreadModifier", null);
			double a_2 = 1.0;
			int num;
			if (fv2.TypedDefinition.a5() == "shortShotgunBarrel")
			{
				num = 2;
				a_2 = 1.2;
			}
			else
			{
				num = 1;
			}
			b1j b1j = c4r.a(A_0, value, a_, a_2, primitivePropertyValue, primitivePropertyValue2);
			bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
			string classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Name");
			bke.g((!string.IsNullOrEmpty(classPropertyValue)) ? classPropertyValue : "Дробовик");
			bke.f(fv.TypedDefinition.a3().Substring(0, fv.TypedDefinition.a3().Length - "frame".Length) + num.ToString());
			bke.i(qv.a("Items\\Weapons/Shotgun", new object[]
			{
				(!string.IsNullOrEmpty(classPropertyValue)) ? classPropertyValue : "unknown"
			}));
			if (fv2.TypedDefinition.a5() == "shortShotgunBarrel")
			{
				bke.g("Укороченный " + bke.az());
				bke bke2 = bke;
				bke2.i(bke2.a0() + " Его ствол укорочен.");
				bke bke3 = bke;
				bke3.g(bke3.ab() - 0.1);
				bke bke4 = bke;
				bke4.a(bke4.x() + 5);
			}
			List<string> list = new List<string>();
			foreach (fv fv4 in Enumerable.OrderBy<fv, string>(new fv[]
			{
				fv3
			}, new Func<fv, string>(dmq.a.a.a)))
			{
				if (fv4 != null)
				{
					this.a(bke, value, fv4, list);
				}
			}
			cwp.a(bke, list);
			bke bke5 = bke;
			bke5.b(bke5.bf() * (double)3);
			return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
		}
		return null;
	}

	// Token: 0x06009983 RID: 39299 RVA: 0x003BCF10 File Offset: 0x003BB110
	private void a(bke A_0, WeaponSubtype A_1, fv A_2, List<string> A_3)
	{
		if (!c4r.a(A_0, A_2, A_3))
		{
			if (A_2.TypedDefinition.i() == ms.bn)
			{
				A_3.Add("a");
				A_0.a(A_0.x() - 10);
				A_0.g("Точный " + A_0.az());
				A_0.i(A_0.a0() + " На срез ствола установлен чок, повышающий кучность выстрела за счёт наносимого урона.");
				for (int i = 0; i < A_0.l().Count; i++)
				{
					a1q value = A_0.l()[i];
					if (value.DamageType == DamageType.Mechanical)
					{
						value = new a1q(value.DamageType, Math.Max(1, value.LowerBoundary), (int)Math.Max(1.0, (double)value.UpperBoundary * 0.85));
						A_0.l()[i] = value;
					}
				}
			}
			else if (A_2.TypedDefinition.i() == ms.bm)
			{
				A_3.Add("b");
				A_0.g(A_0.az() + " XM");
				A_0.c(A_0.f() + 3);
				A_0.i(A_0.a0() + " Ёмкость магазина увеличена благодаря наращению.");
			}
			else if (A_2.TypedDefinition.i() == ms.af)
			{
				if (A_1 == WeaponSubtype.Shotgun_Combat)
				{
					double? primitivePropertyValue = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BurstPrecisionBonus", null);
					if (primitivePropertyValue != null)
					{
						A_0.e(A_0.s() + primitivePropertyValue.Value);
					}
					A_0.i(A_0.a0() + " Тактическая рукоятка повышает устойчивость оружия при стрельбе очередью.");
				}
				else
				{
					A_0.a(A_0.v() - 5);
					A_0.i(A_0.a0() + " Тактическая рукоять повышает устойчивость оружия.");
				}
				A_0.g("Тактическ. " + A_0.az());
				A_3.Add("c");
			}
		}
		int num = (int)Math.Min(A_0.bf().Value * 3.0, (double)A_2.SingleItemValue);
		A_0.b(A_0.bf() + (double)num);
		A_0.h(A_0.a4() + A_2.SingleItemWeight);
	}

	// Token: 0x04003AB7 RID: 15031
	public new static readonly string a = "frame";

	// Token: 0x04003AB8 RID: 15032
	public new static readonly string b = "barrel";

	// Token: 0x04003AB9 RID: 15033
	public static readonly string c = "enhancement1";

	// Token: 0x02001B9E RID: 7070
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009987 RID: 39303 RVA: 0x003BD1F0 File Offset: 0x003BB3F0
		internal string a(fv A_0)
		{
			if (A_0 == null)
			{
				return null;
			}
			return A_0.Definition.az();
		}

		// Token: 0x04003ABA RID: 15034
		public static readonly dmq.a a = new dmq.a();

		// Token: 0x04003ABB RID: 15035
		public static Func<fv, string> b;
	}
}
