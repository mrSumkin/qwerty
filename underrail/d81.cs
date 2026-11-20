using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BE1 RID: 7137
[dgg("smg")]
public sealed class d81 : c4r, bd3
{
	// Token: 0x06009B67 RID: 39783 RVA: 0x003CBDD8 File Offset: 0x003C9FD8
	public override string bt()
	{
		return "茤Пистолет-пулемёт";
	}

	// Token: 0x06009B68 RID: 39784 RVA: 0x003CBDE0 File Offset: 0x003C9FE0
	public override string bu()
	{
		return "smg";
	}

	// Token: 0x06009B69 RID: 39785 RVA: 0x003CBDE8 File Offset: 0x003C9FE8
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009B6A RID: 39786 RVA: 0x003CBDEC File Offset: 0x003C9FEC
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B6B RID: 39787 RVA: 0x003CBDF0 File Offset: 0x003C9FF0
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009B6C RID: 39788 RVA: 0x003CBDF8 File Offset: 0x003C9FF8
	public d81()
	{
		base.Slots.Add(d81.a, new cgo(new c6s(ms.ae, 25), "Рама", false, 1, 0.1f, false, false, null));
		base.Slots.Add(d81.b, new cgo(new c6s(ms.s, 17), "Ствол", false, 1, 0.1f, false, false, null));
		base.Slots.Add(d81.c, new cgo(new eh0(new string[]
		{
			"laserSight",
			"extendedPistolMagazine",
			"forwardGrip",
			"smartModule",
			"rapidReloader",
			"barrelCompensator",
			"muzzleBrake",
			"silencer"
		}, 15), "Улучшение пистолета-пулемёта", true, 1, 0f, false, false, null));
		base.Slots.Add(d81.d, new cgo(new eh0(new string[]
		{
			"laserSight",
			"extendedPistolMagazine",
			"forwardGrip",
			"smartModule",
			"rapidReloader",
			"barrelCompensator",
			"muzzleBrake",
			"silencer"
		}, 15), "Улучшение пистолета-пулемёта", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009B6D RID: 39789 RVA: 0x003CBF48 File Offset: 0x003CA148
	public List<bj8> bz()
	{
		int num = 9;
		int num2 = 0;
		string a_ = "Weapons";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 4; i++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("smg.{0}.frame", i + 1));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			for (int j = 0; j < 3; j++)
			{
				for (int k = 0; k < 2; k++)
				{
					for (int l = 0; l < 2; l++)
					{
						for (int m = 0; m < 2; m++)
						{
							bj = new bj8();
							bj.a(string.Format("smg.{0}.{1}", i + 1, j + 1));
							bj.a().Add(new d8h(a_, new Point(num + 1 + j, num2 + i), 1f));
							if (k == 1)
							{
								bj8 bj2 = bj;
								bj2.a(bj2.c() + "l");
								bj.a().Add(new d8h(a_, new Point(num + 4, num2 + i), 1f));
							}
							if (m == 1)
							{
								bj8 bj3 = bj;
								bj3.a(bj3.c() + "m");
								bj.a().Add(new d8h(a_, new Point(num + 5, num2 + i), 1f));
							}
							if (l == 1)
							{
								bj8 bj4 = bj;
								bj4.a(bj4.c() + "g");
								bj.a().Add(new d8h(a_, new Point(num + 6, num2 + i), 1f));
							}
							list.Add(bj);
						}
					}
				}
			}
		}
		for (int n = 0; n < 4; n++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("smg.{0}.frame", n + 1));
			bj.a().Add(new d8h(a_, new Point(num, num2 + n), 1f));
			list.Add(bj);
			for (int num3 = 0; num3 < 3; num3++)
			{
				for (int num4 = 0; num4 < 2; num4++)
				{
					for (int num5 = 0; num5 < 2; num5++)
					{
						for (int num6 = 0; num6 < 2; num6++)
						{
							for (int num7 = 0; num7 < 2; num7++)
							{
								for (int num8 = 0; num8 < 2; num8++)
								{
									for (int num9 = 0; num9 < 3; num9++)
									{
										for (int num10 = 0; num10 < 2; num10++)
										{
											bj = new bj8();
											bj.a(string.Format("smg.{0}.{1}", n + 1, num3 + 1));
											bj.a().Add(new d8h(a_, new Point(num + 1 + num3, num2 + n), 1f));
											bool flag = false;
											if (num9 == 1)
											{
												bj.a(c4r.a(bj.c(), "a", ref flag));
												bj.a().Add(new d8h(a_, new Point(2, 19 + n), 1f));
											}
											else if (num9 == 2)
											{
												bj.a(c4r.a(bj.c(), "b", ref flag));
												bj.a().Add(new d8h(a_, new Point(3, 19 + n), 1f));
											}
											if (num5 == 1)
											{
												bj.a(c4r.a(bj.c(), "g", ref flag));
												bj.a().Add(new d8h(a_, new Point(num + 6, num2 + n), 1f));
											}
											if (num4 == 1)
											{
												bj.a(c4r.a(bj.c(), "l", ref flag));
												bj.a().Add(new d8h(a_, new Point(num + 4, num2 + n), 1f));
											}
											if (num6 == 1)
											{
												bj.a(c4r.a(bj.c(), "m", ref flag));
												bj.a().Add(new d8h(a_, new Point(num + 5, num2 + n), 1f));
											}
											if (num8 == 1)
											{
												bj.a(c4r.a(bj.c(), "r", ref flag));
											}
											if (num7 == 1)
											{
												bj.a(c4r.a(bj.c(), "s", ref flag));
												bj.a().Add(new d8h(a_, new Point(0, 19 + n), 1f));
												bj.a().Add(new d8h(a_, new Point(1, 19 + n), 0.4f));
											}
											if (num10 == 1)
											{
												bj.a(c4r.a(bj.c(), "t", ref flag));
												bj.a().Add(new d8h(a_, new Point(num + 7, num2 + n), 1f));
											}
											list.Add(bj);
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06009B6E RID: 39790 RVA: 0x003CC4D4 File Offset: 0x003CA6D4
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(d81.a, null);
		fv fv2 = A_1.SafeGet(d81.b, null);
		fv fv3 = A_1.SafeGet(d81.c, null);
		fv fv4 = A_1.SafeGet(d81.d, null);
		if (fv != null && fv2 != null)
		{
			List<BarrelType> classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<List<BarrelType>>("SupportedBarrelTypes");
			if (classPropertyValue != null && classPropertyValue.Count > 0)
			{
				BarrelType? primitivePropertyValue = fv2.TypedDefinition.a7().GetPrimitivePropertyValue<BarrelType>("BarrelType", null);
				if (primitivePropertyValue != null)
				{
					if (!classPropertyValue.Contains(primitivePropertyValue.Value))
					{
						A_2 = "Несовместимый тип ствола.";
						return null;
					}
					if (fv3 != null && fv4 != null && fv3.TypedDefinition.i() == fv4.TypedDefinition.i())
					{
						A_2 = "Нельзя установить два улучшения одного типа.";
						return null;
					}
					double a_ = cwp.a(fv);
					bke bke = new bke();
					bke.a(c4r.a(primitivePropertyValue.Value));
					bke.d(1.0);
					bke.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue)));
					bke.h(fv.SingleItemWeight + fv2.SingleItemWeight);
					bke.g((int)Math.Ceiling(a_));
					bke.a(fv.TypedDefinition.bc());
					bke.a(c4r.a(primitivePropertyValue));
					bke.a2().Add(new aia("uwep"));
					bke.a(ItemStealingCategory.Weapon);
					bke.a(a0.e);
					bke.a(car.e);
					c4r.a(bke, btz.b, this.a(primitivePropertyValue.Value), fv.TypedDefinition);
					b1j? primitivePropertyValue2 = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpreadModifier", null);
					b1j b1j = c4r.a(A_0, this.a(primitivePropertyValue.Value), a_, 1.0, null, primitivePropertyValue2);
					bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
					string classPropertyValue2 = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Name");
					bke.g(c4r.a(bke.ak()) + ((!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "Пистолет-пулемёт"));
					bke.f(fv.TypedDefinition.a3().Substring(0, fv.TypedDefinition.a3().Length - "frame".Length) + this.b(primitivePropertyValue.Value).ToString());
					bke.i(qv.a("Items\\Weapons/SMG", new object[]
					{
						c4r.a(bke.ak()),
						(!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "unknown"
					}));
					List<string> list = new List<string>();
					foreach (fv fv5 in Enumerable.OrderBy<fv, string>(new fv[]
					{
						fv3,
						fv4
					}, new Func<fv, string>(d81.a.a.a)))
					{
						if (fv5 != null)
						{
							if (fv5.TypedDefinition.a5() == "silencer" && bke.ak() != AmmoType.Caliber_5)
							{
								A_2 = "Нельзя присоединить глушитель к этому стволу.";
								return null;
							}
							this.a(bke, fv5, list);
						}
					}
					cwp.a(bke, list);
					bke bke2 = bke;
					bke2.b(bke2.bf() * (double)3);
					if (fv3 != null && fv4 != null)
					{
						bke bke3 = bke;
						bke3.b(bke3.bf() * 1.2);
					}
					return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
				}
			}
		}
		return null;
	}

	// Token: 0x06009B6F RID: 39791 RVA: 0x003CC958 File Offset: 0x003CAB58
	private int b(BarrelType A_0)
	{
		switch (A_0)
		{
		default:
			return 1;
		case BarrelType.Caliber_762:
			return 2;
		case BarrelType.Caliber_86:
			return 3;
		}
	}

	// Token: 0x06009B70 RID: 39792 RVA: 0x003CC97C File Offset: 0x003CAB7C
	private WeaponSubtype a(BarrelType A_0)
	{
		switch (A_0)
		{
		default:
			return WeaponSubtype.Smg_5;
		case BarrelType.Caliber_762:
			return WeaponSubtype.Smg_762;
		case BarrelType.Caliber_86:
			return WeaponSubtype.Smg_86;
		}
	}

	// Token: 0x06009B71 RID: 39793 RVA: 0x003CC9A4 File Offset: 0x003CABA4
	private void a(bke A_0, fv A_1, List<string> A_2)
	{
		if (!c4r.a(A_0, A_1, A_2))
		{
			if (A_1.TypedDefinition.a5() == "silencer")
			{
				A_2.Add("t");
				A_0.a(bhx.y);
				A_0.g(A_0.ab() + 0.05);
				A_0.g("Бесшумн. " + A_0.az());
				A_0.i(A_0.a0() + " Глушитель почти полностью подавляет звук стрельбы, но снижает наносимый урон.");
			}
			else if (A_1.TypedDefinition.i() == ms.u)
			{
				e6l.a(A_1).a(A_0, 1.0);
				A_2.Add("l");
				A_0.g(A_0.az() + " LS");
				A_0.i(A_0.a0() + " Он оснащён лазерным прицелом, что повышает точность стрельбы.");
			}
			else if (A_1.TypedDefinition.i() == ms.t)
			{
				float? primitivePropertyValue = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<float>("MagazineCapacityModifier", null);
				if (primitivePropertyValue != null)
				{
					A_0.c((int)((float)A_0.f() * primitivePropertyValue.Value));
				}
				A_2.Add("m");
				A_0.g(A_0.az() + " XM");
				A_0.i(A_0.a0() + string.Format(" Он оснащён магазином повышенной ёмкости, вмещающим {0} патронов.", A_0.f()));
			}
			else if (A_1.TypedDefinition.i() == ms.af)
			{
				double? primitivePropertyValue2 = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BurstPrecisionBonus", null);
				if (primitivePropertyValue2 != null)
				{
					A_0.e(A_0.s() + primitivePropertyValue2.Value);
				}
				A_2.Add("g");
				A_0.g(A_0.az() + " тактики");
				A_0.i(A_0.a0() + " Тактическая рукоятка повышает устойчивость оружия при стрельбе очередью.");
			}
		}
		int num = (int)Math.Min(A_0.bf().Value * 2.0, (double)A_1.SingleItemValue);
		A_0.b(A_0.bf() + (double)num);
		A_0.h(A_0.a4() + A_1.SingleItemWeight);
	}

	// Token: 0x04003B6E RID: 15214
	public new static readonly string a = "frame";

	// Token: 0x04003B6F RID: 15215
	public new static readonly string b = "barrel";

	// Token: 0x04003B70 RID: 15216
	public static readonly string c = "enhancement1";

	// Token: 0x04003B71 RID: 15217
	public new static readonly string d = "enhancement2";

	// Token: 0x02001BE2 RID: 7138
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009B75 RID: 39797 RVA: 0x003CCC74 File Offset: 0x003CAE74
		internal string a(fv A_0)
		{
			if (A_0 == null)
			{
				return null;
			}
			return A_0.Definition.az();
		}

		// Token: 0x04003B72 RID: 15218
		public static readonly d81.a a = new d81.a();

		// Token: 0x04003B73 RID: 15219
		public static Func<fv, string> b;
	}
}
