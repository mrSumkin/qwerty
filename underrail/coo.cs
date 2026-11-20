using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BE5 RID: 7141
[dgg("sniper")]
public sealed class coo : c4r, bd3
{
	// Token: 0x06009B87 RID: 39815 RVA: 0x003CDD0C File Offset: 0x003CBF0C
	public override string bt()
	{
		return "茦Снайперская винтовка";
	}

	// Token: 0x06009B88 RID: 39816 RVA: 0x003CDD14 File Offset: 0x003CBF14
	public override string bu()
	{
		return "sniper";
	}

	// Token: 0x06009B89 RID: 39817 RVA: 0x003CDD1C File Offset: 0x003CBF1C
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009B8A RID: 39818 RVA: 0x003CDD20 File Offset: 0x003CBF20
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B8B RID: 39819 RVA: 0x003CDD24 File Offset: 0x003CBF24
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009B8C RID: 39820 RVA: 0x003CDD2C File Offset: 0x003CBF2C
	public coo()
	{
		base.Slots.Add(coo.a, new cgo(new c6s(ms.v, 18), "Рама", false, 1, 0.1f, false, false, null));
		base.Slots.Add(coo.b, new cgo(new c6s(ms.s, 17), "Ствол", false, 1, 0.1f, false, false, null));
		base.Slots.Add(coo.c, new cgo(new eh0(new string[]
		{
			"scope",
			"anatomicallyAwareScope",
			"highResolutionDigitalScope"
		}, 19), "Прицел", false, 1, 0.1f, false, false, null));
		base.Slots.Add(coo.d, new cgo(new eh0(new string[]
		{
			"rifleBipod",
			"extendedRifleMagazine",
			"rifleBarrelRetractor",
			"smartModule",
			"rapidReloader"
		}, 15), "Улучшение снайперской винтовки", true, 1, 0f, false, false, null));
		base.Slots.Add(coo.e, new cgo(new eh0(new string[]
		{
			"rifleBipod",
			"extendedRifleMagazine",
			"rifleBarrelRetractor",
			"smartModule",
			"rapidReloader"
		}, 15), "Улучшение снайперской винтовки", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009B8D RID: 39821 RVA: 0x003CDE94 File Offset: 0x003CC094
	public List<bj8> bz()
	{
		int num = 1;
		int num2 = 9;
		string a_ = "Weapons";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 4; i++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("sniper.{0}.frame", i + 1));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			for (int j = 0; j < 3; j++)
			{
				for (int k = 0; k < 4; k++)
				{
					for (int l = 0; l < 2; l++)
					{
						for (int m = 0; m < 2; m++)
						{
							for (int n = 0; n < 2; n++)
							{
								bj = new bj8();
								bj.a(string.Format("sniper.{0}.{1}.{2}", i + 1, j + 1, k + 1));
								bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
								bj.a().Add(new d8h(a_, new Point(num + 11 + j, num2 + i), 1f));
								bj.a().Add(new d8h(a_, new Point(num + 2 + k, num2 + i), 1f));
								if (l == 1)
								{
									bj8 bj2 = bj;
									bj2.a(bj2.c() + "r");
									bj.a().Add(new d8h(a_, new Point(num + 14, num2 + i), 1f));
								}
								if (n == 1)
								{
									bj8 bj3 = bj;
									bj3.a(bj3.c() + "m");
									bj.a().Add(new d8h(a_, new Point(num + 15, num2 + i), 1f));
								}
								if (m == 1)
								{
									bj8 bj4 = bj;
									bj4.a(bj4.c() + "b");
									bj.a().Add(new d8h(a_, new Point(num + 16, num2 + i), 1f));
								}
								list.Add(bj);
							}
						}
					}
				}
			}
		}
		for (int num3 = 0; num3 < 4; num3++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("sniper.{0}.frame", num3 + 1));
			bj.a().Add(new d8h(a_, new Point(num, num2 + num3), 1f));
			list.Add(bj);
			for (int num4 = 0; num4 < 3; num4++)
			{
				for (int num5 = 0; num5 < 4; num5++)
				{
					for (int num6 = 0; num6 < 2; num6++)
					{
						for (int num7 = 0; num7 < 2; num7++)
						{
							for (int num8 = 0; num8 < 2; num8++)
							{
								for (int num9 = 0; num9 < 2; num9++)
								{
									for (int num10 = 0; num10 < 2; num10++)
									{
										bj = new bj8();
										bj.a(string.Format("sniper.{0}.{1}.{2}", num3 + 1, num4 + 1, num5 + 1));
										bj.a().Add(new d8h(a_, new Point(num + 1, num2 + num3), 1f));
										bj.a().Add(new d8h(a_, new Point(num + 11 + num4, num2 + num3), 1f));
										bj.a().Add(new d8h(a_, new Point(num + 2 + num5, num2 + num3), 1f));
										bool flag = false;
										if (num7 == 1)
										{
											bj.a(c4r.a(bj.c(), "i", ref flag));
											bj.a().Add(new d8h(a_, new Point(num + 16, num2 + num3), 1f));
										}
										if (num8 == 1)
										{
											bj.a(c4r.a(bj.c(), "m", ref flag));
											bj.a().Add(new d8h(a_, new Point(num + 15, num2 + num3), 1f));
										}
										if (num10 == 1)
										{
											bj.a(c4r.a(bj.c(), "r", ref flag));
										}
										if (num9 == 1)
										{
											bj.a(c4r.a(bj.c(), "s", ref flag));
											bj.a().Add(new d8h(a_, new Point(num + 5, num2 + num3), 1f));
										}
										if (num6 == 1)
										{
											bj.a(c4r.a(bj.c(), "t", ref flag));
											bj.a().Add(new d8h(a_, new Point(num + 14, num2 + num3), 1f));
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

	// Token: 0x06009B8E RID: 39822 RVA: 0x003CE3D8 File Offset: 0x003CC5D8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(coo.a, null);
		fv fv2 = A_1.SafeGet(coo.b, null);
		fv fv3 = A_1.SafeGet(coo.c, null);
		fv fv4 = A_1.SafeGet(coo.d, null);
		fv fv5 = A_1.SafeGet(coo.e, null);
		if (fv != null && fv3 != null && fv2 != null)
		{
			if (fv3.TypedDefinition.a7().GetPrimitivePropertyValue<bool>("IsGrenadeLauncherScope", new bool?(false)).Value)
			{
				A_2 = "Несовместимый тип прицела.";
				return null;
			}
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
					if (fv4 != null && fv5 != null && fv4.TypedDefinition.i() == fv5.TypedDefinition.i())
					{
						A_2 = "Нельзя установить два улучшения одного типа.";
						return null;
					}
					double a_ = cwp.a(fv);
					bke bke = new bke();
					bke.a(c4r.a(primitivePropertyValue.Value));
					bke.d(1.0);
					bke.b(new double?((double)(fv.SingleItemValue + fv3.SingleItemValue + fv2.SingleItemValue)));
					bke.h(fv.SingleItemWeight + fv3.SingleItemWeight + fv2.SingleItemWeight);
					bke.g((int)Math.Ceiling(a_));
					bke.a(fv.TypedDefinition.bc());
					bke.a(c4r.a(primitivePropertyValue));
					bke.a2().Add(new aia("uwep"));
					bke.a(0.4f);
					bke.b(0.30000001192092896);
					bke.a(ItemStealingCategory.WeaponHeavy);
					bke.a(a0.e);
					c4r.a(bke, btz.d, this.a(primitivePropertyValue.Value), fv.TypedDefinition);
					b1j? primitivePropertyValue2 = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpreadModifier", null);
					b1j b1j = c4r.a(A_0, this.a(primitivePropertyValue.Value), a_, 1.0, null, primitivePropertyValue2);
					e6l e6l = e6l.a(fv3);
					e6l.a(bke, 1.0);
					bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
					string classPropertyValue2 = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Name");
					bke.g(c4r.a(bke.ak()) + ((!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "Снайперская винтовка"));
					bke.f(fv.TypedDefinition.a3().Substring(0, fv.TypedDefinition.a3().Length - "frame".Length) + this.b(primitivePropertyValue.Value).ToString() + "." + (e6l.e + 1).ToString());
					bke.i(qv.a("Items\\Weapons/Sniper", new object[]
					{
						c4r.a(bke.ak()),
						(!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "unknown"
					}));
					if (fv3.TypedDefinition.a5() == "anatomicallyAwareScope")
					{
						bke bke2 = bke;
						bke2.i(bke2.a0() + " Прицел со встроенным компьютером способен распознавать анатомию млекопитающих и насекомых.");
					}
					else if (fv3.TypedDefinition.a5() == "highResolutionDigitalScope")
					{
						bke bke3 = bke;
						bke3.i(bke3.a0() + " Цифровой прицел облегчает точность стрельбы, благодаря захвату цели.");
					}
					if (fv4 != null && fv5 != null && fv4.TypedDefinition.i() == fv5.TypedDefinition.i())
					{
						A_2 = "Нельзя установить два улучшения одного типа.";
						return null;
					}
					List<string> list = new List<string>();
					foreach (fv fv6 in Enumerable.OrderBy<fv, string>(new fv[]
					{
						fv4,
						fv5
					}, new Func<fv, string>(coo.a.a.a)))
					{
						if (fv6 != null)
						{
							this.a(bke, fv.TypedDefinition, fv6, list, ref A_2);
						}
					}
					cwp.a(bke, list);
					if (A_2 != null)
					{
						return null;
					}
					bke bke4 = bke;
					bke4.b(bke4.bf() * (double)3);
					if (fv4 != null && fv5 != null)
					{
						bke bke5 = bke;
						bke5.b(bke5.bf() * 1.2);
					}
					return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
				}
			}
		}
		return null;
	}

	// Token: 0x06009B8F RID: 39823 RVA: 0x003CE968 File Offset: 0x003CCB68
	private int b(BarrelType A_0)
	{
		switch (A_0)
		{
		default:
			return 1;
		case BarrelType.Caliber_86:
			return 2;
		case BarrelType.Caliber_127:
			return 3;
		}
	}

	// Token: 0x06009B90 RID: 39824 RVA: 0x003CE98C File Offset: 0x003CCB8C
	private WeaponSubtype a(BarrelType A_0)
	{
		switch (A_0)
		{
		default:
			return WeaponSubtype.Sniper_762;
		case BarrelType.Caliber_86:
			return WeaponSubtype.Sniper_86;
		case BarrelType.Caliber_127:
			return WeaponSubtype.Sniper_127;
		}
	}

	// Token: 0x06009B91 RID: 39825 RVA: 0x003CE9B4 File Offset: 0x003CCBB4
	private void a(bke A_0, a1k A_1, fv A_2, List<string> A_3, ref string A_4)
	{
		if (!c4r.a(A_0, A_2, A_3))
		{
			if (A_2.TypedDefinition.i() == ms.x)
			{
				if (A_1.a7().GetPrimitivePropertyValue<bool>("CannotAttachBipod", new bool?(false)).Value)
				{
					A_4 = "Нельзя установить сошку на это ружьё";
				}
				else
				{
					int value = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ApModifier", new int?(0)).Value;
					float value2 = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<float>("PrecisionBonus", new float?(0f)).Value;
					A_0.g(A_0.ab() + (double)value2);
					A_0.b(A_0.aj() + (double)value2);
					A_0.a(A_0.v() + value);
					A_3.Add("i");
					A_0.g(A_0.az() + " с сошками");
					A_0.i(A_0.a0() + " Сошки повышают точность стрельбы, но замедляют прицеливание.");
				}
			}
			else if (A_2.TypedDefinition.i() == ms.w)
			{
				A_0.a(A_0.z() / 2f);
				A_3.Add("t");
				A_0.g(A_0.az() + " коммандо");
				A_0.i(A_0.a0() + " Установленный пневматический ретрактор ствола облегчает её использование в ближнем бою.");
			}
			else if (A_2.TypedDefinition.i() == ms.y)
			{
				float? primitivePropertyValue = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<float>("MagazineCapacityModifier", null);
				if (primitivePropertyValue != null)
				{
					A_0.c((int)((float)A_0.f() * primitivePropertyValue.Value));
				}
				A_3.Add("m");
				A_0.g(A_0.az() + " XM");
				A_0.i(A_0.a0() + string.Format(" Он оснащён магазином повышенной ёмкости, вмещающим {0} патронов.", A_0.f()));
			}
		}
		int num = (int)Math.Min(A_0.bf().Value * 0.5, (double)A_2.SingleItemValue);
		A_0.b(A_0.bf() + (double)num);
		A_0.h(A_0.a4() + A_2.SingleItemWeight);
	}

	// Token: 0x04003B7D RID: 15229
	public new static readonly string a = "frame";

	// Token: 0x04003B7E RID: 15230
	public new static readonly string b = "barrel";

	// Token: 0x04003B7F RID: 15231
	public static readonly string c = "scope";

	// Token: 0x04003B80 RID: 15232
	public new static readonly string d = "enhancement1";

	// Token: 0x04003B81 RID: 15233
	public static readonly string e = "enhancement2";

	// Token: 0x02001BE6 RID: 7142
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009B95 RID: 39829 RVA: 0x003CEC88 File Offset: 0x003CCE88
		internal string a(fv A_0)
		{
			if (A_0 == null)
			{
				return null;
			}
			return A_0.Definition.az();
		}

		// Token: 0x04003B82 RID: 15234
		public static readonly coo.a a = new coo.a();

		// Token: 0x04003B83 RID: 15235
		public static Func<fv, string> b;
	}
}
