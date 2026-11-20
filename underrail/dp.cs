using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BD4 RID: 7124
[dgg("assaultRifle")]
public sealed class dp : c4r, bd3
{
	// Token: 0x06009B06 RID: 39686 RVA: 0x003C705C File Offset: 0x003C525C
	public override string bt()
	{
		return "茠Автомат";
	}

	// Token: 0x06009B07 RID: 39687 RVA: 0x003C7064 File Offset: 0x003C5264
	public override string bu()
	{
		return "assaultRifle";
	}

	// Token: 0x06009B08 RID: 39688 RVA: 0x003C706C File Offset: 0x003C526C
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009B09 RID: 39689 RVA: 0x003C7070 File Offset: 0x003C5270
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B0A RID: 39690 RVA: 0x003C7074 File Offset: 0x003C5274
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009B0B RID: 39691 RVA: 0x003C7078 File Offset: 0x003C5278
	public dp()
	{
		base.Slots.Add(dp.a, new cgo(new c6s(ms.ak, 29), "Рама", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dp.b, new cgo(new c6s(ms.s, 17), "Ствол", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dp.c, new cgo(new eh0(new string[]
		{
			"rifleBipod",
			"extendedRifleMagazine",
			"scope",
			"anatomicallyAwareScope",
			"highResolutionDigitalScope",
			"smartModule",
			"rapidReloader",
			"barrelCompensator",
			"muzzleBrake",
			"reflexSight"
		}, 15), "Улучшение для автомата", true, 1, 0f, false, false, null));
		base.Slots.Add(dp.d, new cgo(new eh0(new string[]
		{
			"rifleBipod",
			"extendedRifleMagazine",
			"scope",
			"anatomicallyAwareScope",
			"highResolutionDigitalScope",
			"smartModule",
			"rapidReloader",
			"barrelCompensator",
			"muzzleBrake",
			"reflexSight"
		}, 15), "Улучшение для автомата", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009B0C RID: 39692 RVA: 0x003C71EC File Offset: 0x003C53EC
	public List<bj8> bz()
	{
		int num = 18;
		int num2 = 9;
		string a_ = "Weapons";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 4; i++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("rifle.{0}.frame", i + 1));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			for (int j = 0; j < 3; j++)
			{
				for (int k = 0; k < 3; k++)
				{
					for (int l = 0; l < 2; l++)
					{
						for (int m = 0; m < 2; m++)
						{
							bj = new bj8();
							bj.a(string.Format("rifle.{0}.{1}", i + 1, j + 1));
							bj.a().Add(new d8h(a_, new Point(num + 1 + j, num2 + i), 1f));
							if (k > 0)
							{
								bj8 bj2 = bj;
								bj2.a(bj2.c() + "s" + k.ToString());
								bj.a().Add(new d8h(a_, new Point(num + 5 + k, num2 + i), 1f));
							}
							if (m == 1)
							{
								bj8 bj3 = bj;
								bj3.a(bj3.c() + "m");
								bj.a().Add(new d8h(a_, new Point(num + 4, num2 + i), 1f));
							}
							if (l == 1)
							{
								bj8 bj4 = bj;
								bj4.a(bj4.c() + "b");
								bj.a().Add(new d8h(a_, new Point(num + 5, num2 + i), 1f));
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
			bj.a(string.Format("rifle.{0}.frame", n + 1));
			bj.a().Add(new d8h(a_, new Point(num, num2 + n), 1f));
			list.Add(bj);
			for (int num3 = 0; num3 < 3; num3++)
			{
				for (int num4 = 0; num4 < 5; num4++)
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
										bj = new bj8();
										bj.a(string.Format("rifle.{0}.{1}", n + 1, num3 + 1));
										bj.a().Add(new d8h(a_, new Point(num + 1 + num3, num2 + n), 1f));
										bool flag = false;
										if (num9 == 1)
										{
											bj.a(c4r.a(bj.c(), "a", ref flag));
										}
										else if (num9 == 2)
										{
											bj.a(c4r.a(bj.c(), "b", ref flag));
										}
										if (num5 == 1)
										{
											bj.a(c4r.a(bj.c(), "i", ref flag));
											bj.a().Add(new d8h(a_, new Point(num + 5, num2 + n), 1f));
										}
										if (num6 == 1)
										{
											bj.a(c4r.a(bj.c(), "m", ref flag));
											bj.a().Add(new d8h(a_, new Point(num + 4, num2 + n), 1f));
										}
										if (num8 == 1)
										{
											bj.a(c4r.a(bj.c(), "r", ref flag));
										}
										if (num7 == 1)
										{
											bj.a(c4r.a(bj.c(), "s", ref flag));
											bj.a().Add(new d8h(a_, new Point(num + 10, num2 + n), 1f));
										}
										if (num4 > 0)
										{
											bj.a(c4r.a(bj.c(), "s" + num4.ToString(), ref flag));
											bj.a().Add(new d8h(a_, new Point(num + 5 + num4, num2 + n), 1f));
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
		return list;
	}

	// Token: 0x06009B0D RID: 39693 RVA: 0x003C76D0 File Offset: 0x003C58D0
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(dp.a, null);
		fv fv2 = A_1.SafeGet(dp.b, null);
		fv fv3 = A_1.SafeGet(dp.c, null);
		fv fv4 = A_1.SafeGet(dp.d, null);
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
					bke.b(0.05000000074505806);
					bke.a(ItemStealingCategory.WeaponHeavy);
					bke.a(a0.e);
					c4r.a(bke, btz.c, this.a(primitivePropertyValue.Value), fv.TypedDefinition);
					b1j? primitivePropertyValue2 = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpreadModifier", null);
					b1j b1j = c4r.a(A_0, this.a(primitivePropertyValue.Value), a_, 1.0, null, primitivePropertyValue2);
					bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
					string classPropertyValue2 = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Name");
					bke.g(c4r.a(bke.ak()) + ((!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "Автомат"));
					bke.f(fv.TypedDefinition.a3().Substring(0, fv.TypedDefinition.a3().Length - "frame".Length) + this.b(primitivePropertyValue.Value).ToString());
					bke.i(qv.a("Items\\Weapons/AssaultRifle", new object[]
					{
						c4r.a(bke.ak()),
						(!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "unknown"
					}));
					List<string> list = new List<string>();
					foreach (fv fv5 in Enumerable.OrderBy<fv, string>(new fv[]
					{
						fv3,
						fv4
					}, new Func<fv, string>(dp.a.a.a)))
					{
						if (fv5 != null)
						{
							this.a(bke, fv5, list, ref A_2);
							if (A_2 != null)
							{
								return null;
							}
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

	// Token: 0x06009B0E RID: 39694 RVA: 0x003C7B34 File Offset: 0x003C5D34
	private int b(BarrelType A_0)
	{
		switch (A_0)
		{
		default:
			return 1;
		case BarrelType.Caliber_9:
			return 3;
		case BarrelType.Caliber_86:
			return 2;
		}
	}

	// Token: 0x06009B0F RID: 39695 RVA: 0x003C7B54 File Offset: 0x003C5D54
	private WeaponSubtype a(BarrelType A_0)
	{
		switch (A_0)
		{
		default:
			return WeaponSubtype.AssaultRifle_762;
		case BarrelType.Caliber_9:
			return WeaponSubtype.AssaultRifle_9;
		case BarrelType.Caliber_86:
			return WeaponSubtype.AssaultRifle_86;
		}
	}

	// Token: 0x06009B10 RID: 39696 RVA: 0x003C7B7C File Offset: 0x003C5D7C
	private void a(bke A_0, fv A_1, List<string> A_2, ref string A_3)
	{
		if (!c4r.a(A_0, A_1, A_2))
		{
			if (A_1.TypedDefinition.i() == ms.x)
			{
				int num = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ApModifier", new int?(0)).Value / 2;
				float value = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<float>("PrecisionBonus", new float?(0f)).Value;
				A_0.g(A_0.ab() + (double)value);
				A_0.b(A_0.aj() + Math.Round((double)(value / 2f), 2));
				A_0.a(A_0.v() + num / 2);
				A_2.Add("i");
				A_0.g(A_0.az() + " с сошками");
				A_0.i(A_0.a0() + " Сошки повышают точность стрельбы, но замедляют прицеливание.");
			}
			else if (A_1.TypedDefinition.i() == ms.q)
			{
				if (A_1.TypedDefinition.a7().GetPrimitivePropertyValue<bool>("IsGrenadeLauncherScope", new bool?(false)).Value)
				{
					A_3 = "Несовместимый тип прицела.";
					return;
				}
				e6l e6l = e6l.a(A_1);
				e6l.a(A_0, 0.7);
				if (A_1.Definition.a5() == "reflexSight")
				{
					A_0.g("Тактическ. " + A_0.az());
				}
				else
				{
					A_0.g("Оснащённ. прицелом " + A_0.az());
				}
				A_2.Add("s" + (e6l.e + 1).ToString());
				if (A_1.TypedDefinition.a5() == "anatomicallyAwareScope")
				{
					A_0.i(A_0.a0() + " Прицел со встроенным компьютером способен распознавать анатомию млекопитающих и насекомых.");
				}
				else if (A_1.TypedDefinition.a5() == "highResolutionDigitalScope")
				{
					A_0.i(A_0.a0() + " Цифровой прицел облегчает точность стрельбы, благодаря захвату цели.");
				}
				else if (A_1.TypedDefinition.a5() == "reflexSight")
				{
					A_0.i(A_0.a0() + " Имеет коллиматорный прицел, позволяющий быстро захватывать цель.");
				}
				else
				{
					A_0.i(A_0.a0() + " Точность стрельбы повышена, благодаря установленному прицелу.");
				}
			}
			else if (A_1.TypedDefinition.i() == ms.y)
			{
				float? primitivePropertyValue = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<float>("MagazineCapacityModifier", null);
				if (primitivePropertyValue != null)
				{
					A_0.c((int)((float)A_0.f() * primitivePropertyValue.Value));
					A_2.Add("m");
					A_0.g(A_0.az() + " XM");
					A_0.i(A_0.a0() + string.Format(" Он оснащён магазином повышенной ёмкости, вмещающим {0} патронов.", A_0.f()));
				}
			}
		}
		int num2 = (int)Math.Min(A_0.bf().Value * 2.0, (double)A_1.SingleItemValue);
		A_0.b(A_0.bf() + (double)num2);
		A_0.h(A_0.a4() + A_1.SingleItemWeight);
	}

	// Token: 0x04003B41 RID: 15169
	public new static readonly string a = "frame";

	// Token: 0x04003B42 RID: 15170
	public new static readonly string b = "barrel";

	// Token: 0x04003B43 RID: 15171
	public static readonly string c = "enhancement1";

	// Token: 0x04003B44 RID: 15172
	public new static readonly string d = "enhancement2";

	// Token: 0x02001BD5 RID: 7125
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009B14 RID: 39700 RVA: 0x003C7F44 File Offset: 0x003C6144
		internal string a(fv A_0)
		{
			if (A_0 == null)
			{
				return null;
			}
			return A_0.Definition.az();
		}

		// Token: 0x04003B45 RID: 15173
		public static readonly dp.a a = new dp.a();

		// Token: 0x04003B46 RID: 15174
		public static Func<fv, string> b;
	}
}
