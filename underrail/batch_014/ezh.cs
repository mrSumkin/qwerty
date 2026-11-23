using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BE7 RID: 7143
[dgg("pistol")]
public sealed class ezh : c4r, bd3
{
	// Token: 0x06009B96 RID: 39830 RVA: 0x003CECA0 File Offset: 0x003CCEA0
	public override string bt()
	{
		return "茥Пистолет";
	}

	// Token: 0x06009B97 RID: 39831 RVA: 0x003CECA8 File Offset: 0x003CCEA8
	public override string bu()
	{
		return "pistol";
	}

	// Token: 0x06009B98 RID: 39832 RVA: 0x003CECB0 File Offset: 0x003CCEB0
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009B99 RID: 39833 RVA: 0x003CECB4 File Offset: 0x003CCEB4
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B9A RID: 39834 RVA: 0x003CECB8 File Offset: 0x003CCEB8
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009B9B RID: 39835 RVA: 0x003CECC0 File Offset: 0x003CCEC0
	public ezh()
	{
		string[] a_ = new string[]
		{
			"laserSight",
			"extendedPistolMagazine",
			"smartModule",
			"rapidReloader",
			"silencer"
		};
		base.Slots.Add(ezh.a, new cgo(new c6s(ms.r, 16), "Рама", false, 1, 0.1f, false, false, null));
		base.Slots.Add(ezh.b, new cgo(new c6s(ms.s, 17), "Ствол", false, 1, 0.1f, false, false, null));
		base.Slots.Add(ezh.c, new cgo(new eh0(a_, 15), "Улучшение пистолета", true, 1, 0f, false, false, null));
		base.Slots.Add(ezh.d, new cgo(new eh0(a_, 15), "Улучшение пистолета", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009B9C RID: 39836 RVA: 0x003CEDB4 File Offset: 0x003CCFB4
	public List<bj8> bz()
	{
		int num = 1;
		int num2 = 0;
		string a_ = "Weapons";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 4; i++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("pistol.{0}.frame", i + 1));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			for (int j = 0; j < 4; j++)
			{
				bj = new bj8();
				bj.a(string.Format("pistol.{0}.{1}", i + 1, j + 1));
				bj.a().Add(new d8h(a_, new Point(num + j + 1, num2 + i), 1f));
				list.Add(bj);
				bj = new bj8();
				bj.a(string.Format("pistol.{0}.{1}.l", i + 1, j + 1));
				bj.a().Add(new d8h(a_, new Point(num + 5, num2 + i), 1f));
				bj.a().Add(new d8h(a_, new Point(num + j + 1, num2 + i), 1f));
				list.Add(bj);
				bj = new bj8();
				bj.a(string.Format("pistol.{0}.{1}.e", i + 1, j + 1));
				bj.a().Add(new d8h(a_, new Point(num + 6, num2 + i), 1f));
				bj.a().Add(new d8h(a_, new Point(num + j + 1, num2 + i), 1f));
				list.Add(bj);
				bj = new bj8();
				bj.a(string.Format("pistol.{0}.{1}.le", i + 1, j + 1));
				bj.a().Add(new d8h(a_, new Point(num + 5, num2 + i), 1f));
				bj.a().Add(new d8h(a_, new Point(num + 6, num2 + i), 1f));
				bj.a().Add(new d8h(a_, new Point(num + j + 1, num2 + i), 1f));
				list.Add(bj);
			}
			for (int k = 0; k < 4; k++)
			{
				for (int l = 0; l < 2; l++)
				{
					for (int m = 0; m < 2; m++)
					{
						for (int n = 0; n < 2; n++)
						{
							for (int num3 = 0; num3 < 2; num3++)
							{
								for (int num4 = 0; num4 < 2; num4++)
								{
									bj = new bj8();
									bj.a(string.Format("pistol.{0}.{1}", i + 1, k + 1));
									bj.a().Add(new d8h(a_, new Point(num + k + 1, num2 + i), 1f));
									bool flag = false;
									if (m == 1)
									{
										bj.a(c4r.a(bj.c(), "e", ref flag));
										bj.a().Add(new d8h(a_, new Point(num + 6, num2 + i), 1f));
									}
									if (l == 1)
									{
										bj.a(c4r.a(bj.c(), "l", ref flag));
										bj.a().Add(new d8h(a_, new Point(num + 5, num2 + i), 1f));
									}
									if (num3 == 1)
									{
										bj.a(c4r.a(bj.c(), "r", ref flag));
									}
									if (n == 1)
									{
										bj.a(c4r.a(bj.c(), "s", ref flag));
										bj.a().Add(new d8h(a_, new Point(0, 15 + i), 1f));
										bj.a().Add(new d8h(a_, new Point(1, 15 + i), 0.4f));
									}
									if (num4 == 1)
									{
										bj.a(c4r.a(bj.c(), "t", ref flag));
										bj.a().Add(new d8h(a_, new Point(num + 7, num2 + i), 1f));
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

	// Token: 0x06009B9D RID: 39837 RVA: 0x003CF26C File Offset: 0x003CD46C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(ezh.a, null);
		fv fv2 = A_1.SafeGet(ezh.b, null);
		fv fv3 = A_1.SafeGet(ezh.c, null);
		fv fv4 = A_1.SafeGet(ezh.d, null);
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
					fv[] array = new fv[]
					{
						fv3,
						fv4
					};
					if (this.a(array[0], array[1]))
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
					bke.a(car.d);
					c4r.a(bke, btz.a, this.a(primitivePropertyValue.Value), fv.TypedDefinition);
					b1j? primitivePropertyValue2 = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpread", null);
					b1j? primitivePropertyValue3 = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpreadModifier", null);
					b1j b1j = c4r.a(A_0, this.a(primitivePropertyValue.Value), a_, 1.0, primitivePropertyValue2, primitivePropertyValue3);
					bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
					string classPropertyValue2 = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Name");
					bke.g(c4r.a(bke.ak()) + ((!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "Пистолет"));
					bke.f(fv.TypedDefinition.a3().Substring(0, fv.TypedDefinition.a3().Length - "frame".Length) + ((int)(primitivePropertyValue.Value + 1)).ToString());
					bke.i(qv.a("Items\\Weapons/Pistol", new object[]
					{
						c4r.a(bke.ak()),
						(!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "unknown"
					}));
					List<string> list = new List<string>();
					foreach (fv fv5 in Enumerable.OrderBy<fv, string>(array, new Func<fv, string>(ezh.a.a.a)))
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

	// Token: 0x06009B9E RID: 39838 RVA: 0x003CF6FC File Offset: 0x003CD8FC
	private bool a(fv A_0, fv A_1)
	{
		return A_0 != null && A_1 != null && A_0.TypedDefinition.i() == A_1.TypedDefinition.i();
	}

	// Token: 0x06009B9F RID: 39839 RVA: 0x003CF730 File Offset: 0x003CD930
	private WeaponSubtype a(BarrelType A_0)
	{
		switch (A_0)
		{
		default:
			return WeaponSubtype.Pistol_5;
		case BarrelType.Caliber_762:
			return WeaponSubtype.Pistol_762;
		case BarrelType.Caliber_9:
			return WeaponSubtype.Pistol_9;
		case BarrelType.Caliber_44:
			return WeaponSubtype.Pistol_44;
		}
	}

	// Token: 0x06009BA0 RID: 39840 RVA: 0x003CF754 File Offset: 0x003CD954
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
				A_0.i(A_0.a0() + " Глушитель почти полностью подавляет звук стрельбы.");
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
				A_2.Add("e");
				A_0.g(A_0.az() + " XM");
				A_0.i(A_0.a0() + string.Format(" Он оснащён магазином повышенной ёмкости, вмещающим {0} патронов.", A_0.f()));
			}
		}
		int num = (int)Math.Min(A_0.bf().Value * 3.0, (double)A_1.SingleItemValue);
		A_0.b(A_0.bf() + (double)num);
		A_0.h(A_0.a4() + A_1.SingleItemWeight);
	}

	// Token: 0x04003B84 RID: 15236
	public new static readonly string a = "frame";

	// Token: 0x04003B85 RID: 15237
	public new static readonly string b = "barrel";

	// Token: 0x04003B86 RID: 15238
	public static readonly string c = "enhancement1";

	// Token: 0x04003B87 RID: 15239
	public new static readonly string d = "enhancement2";

	// Token: 0x02001BE8 RID: 7144
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009BA4 RID: 39844 RVA: 0x003CF994 File Offset: 0x003CDB94
		internal string a(fv A_0)
		{
			if (A_0 == null)
			{
				return null;
			}
			return A_0.Definition.az();
		}

		// Token: 0x04003B88 RID: 15240
		public static readonly ezh.a a = new ezh.a();

		// Token: 0x04003B89 RID: 15241
		public static Func<fv, string> b;
	}
}
