using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BC8 RID: 7112
[dgg("riotGear")]
public sealed class cz2 : cwp, bd3
{
	// Token: 0x06009AB0 RID: 39600 RVA: 0x003C3588 File Offset: 0x003C1788
	public override string bt()
	{
		return "茑Штурмовой бронежилет";
	}

	// Token: 0x06009AB1 RID: 39601 RVA: 0x003C3590 File Offset: 0x003C1790
	public override string bu()
	{
		return "RiotGear";
	}

	// Token: 0x06009AB2 RID: 39602 RVA: 0x003C3598 File Offset: 0x003C1798
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009AB3 RID: 39603 RVA: 0x003C359C File Offset: 0x003C179C
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009AB4 RID: 39604 RVA: 0x003C35A0 File Offset: 0x003C17A0
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Armor;
	}

	// Token: 0x06009AB5 RID: 39605 RVA: 0x003C35A8 File Offset: 0x003C17A8
	public cz2()
	{
		base.Slots.Add(cz2.a, new cgo(new c6s(ms.aa, 20), "Разгрузочный жилет", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cz2.b, new cgo(new c6s(ms.z, 21), "Баллистическая панель", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cz2.c, new cgo(new eh0(new string[]
		{
			"steel",
			"tungstenSteel",
			"triChrome",
			"supersteel",
			"psiBeetleCarapace",
			"burrowerCarapace",
			"giantCrabCarapace",
			"colossalCrabCarapace",
			"psiCrabCarapace"
		}, 62), "Пластина щита", true, 1, 0f, false, false, null));
		base.Slots.Add(cz2.d, new cgo(new c6s(ms.c, 3), "Ткань плаща", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009AB6 RID: 39606 RVA: 0x003C36BC File Offset: 0x003C18BC
	public List<bj8> bz()
	{
		int num = 0;
		int num2 = 14;
		string a_ = "Armors";
		List<bj8> list = new List<bj8>();
		for (int i = -1; i < 9; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				bj8 bj = new bj8();
				bj.a(string.Format("riotGearVest.{0}{1}", j, (i != -1) ? ("." + i.ToString()) : ""));
				bj.a().Add(new d8h(a_, new Point(num + j, num2), 1f));
				if (i != -1)
				{
					bj.a().Add(new d8h(a_, new Point(num + i, num2 + 2), 1f));
				}
				list.Add(bj);
			}
			for (int k = 0; k < 4; k++)
			{
				bj8 bj = new bj8();
				bj.a(string.Format("riotGearCoat.{0}{1}", k, (i != -1) ? ("." + i.ToString()) : ""));
				bj.a().Add(new d8h(a_, new Point(num + k, num2 + 1), 1f));
				if (i != -1)
				{
					bj.a().Add(new d8h(a_, new Point(num + i, num2 + 2), 1f));
				}
				list.Add(bj);
			}
		}
		return list;
	}

	// Token: 0x06009AB7 RID: 39607 RVA: 0x003C384C File Offset: 0x003C1A4C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(cz2.a, null);
		fv fv2 = A_1.SafeGet(cz2.b, null);
		if (fv != null && fv2 != null)
		{
			ett ett = fv.TypedDefinition as ett;
			ett ett2 = fv2.TypedDefinition as ett;
			if (ett != null && ett2 != null)
			{
				c43 c = new c43();
				c.a(ett.bc());
				c.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue)));
				c.h(fv.SingleItemWeight + fv2.SingleItemWeight);
				c.g((int)Math.Ceiling(cwp.a(fv)));
				c.a(ItemStealingCategory.Armor);
				c.a(a0.k);
				c8d c8d = new c8d(new IndependentItemDefinitionProvider<c43>(c));
				c6o.a(c, ett, fv.QualityLevel);
				c6o.a(A_0, c8d, ett, fv.QualityLevel, false, 1.0, true);
				c6o.a(c, ett2, fv2.QualityLevel);
				c6o.a(A_0, c8d, ett2, fv2.QualityLevel, false, 1.0, true);
				if (A_0 != null && A_0.Feats.Contains<e>())
				{
					c6o.a(c, new du2(DamageType.Mechanical, e.a + A_0.GetSpecializationValue<av3>(true) * av3.a, 0.0));
				}
				dwb dwb = Enumerable.FirstOrDefault<dwb>(Enumerable.OfType<dwb>(c.f()));
				if (dwb != null && dwb.Bonus > 0.0)
				{
					dwb.Bonus /= 2.0;
				}
				eey eey = Enumerable.FirstOrDefault<eey>(Enumerable.OfType<eey>(c.f()));
				if (eey != null)
				{
					eey.Bonus += 1.0;
				}
				else
				{
					eey = new eey();
					eey.Bonus = 1.0;
					c.f().Add(eey);
				}
				c.b(Math.Min(c.h() * 2.0, aiy.az));
				fv fv3 = A_1.SafeGet(cz2.d, null);
				fv fv4 = A_1.SafeGet(cz2.c, null);
				c.a("ri");
				c.i("Этот штурмовой бронежилет состоит из " + ett.a7().GetClassPropertyValue<string>("ArmorDescription3") + " " + ett2.a7().GetClassPropertyValue<string>("ArmorDescription"));
				string classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<string>("VestType");
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					c.g(classPropertyValue + " ");
				}
				else
				{
					c.g("");
				}
				int? num = null;
				if (fv3 != null)
				{
					ett ett3 = fv3.TypedDefinition as ett;
					if (ett3 != null)
					{
						int num2 = fv3.QualityLevel;
						if (A_0 != null && A_0.Feats.Contains<rh>())
						{
							num2 = (int)((double)num2 * (1.0 + rh.a(A_0)));
						}
						c43 c2 = c;
						c2.b(c2.bf() + (double)fv3.SingleItemValue);
						c43 c3 = c;
						c3.h(c3.a4() + fv3.SingleItemWeight);
						c6o.a(c, ett3, num2);
						c6o.a(A_0, c8d, ett3, num2, false, 1.0, true);
						if (ett3.a5() == "aluminizedCloth")
						{
							c.ar().Add(new awe(CharacterImmunities.Burning));
						}
						if (fv3.TypedDefinition.a5() == "kevlarCloth")
						{
							dwb dwb2 = Enumerable.FirstOrDefault<dwb>(Enumerable.OfType<dwb>(c.f()));
							if (dwb2 == null)
							{
								dwb2 = new dwb();
								c.f().Add(dwb2);
							}
							dwb2.Bonus += 0.1 + Math.Max(0.0, (double)(num2 - 15) * 0.005);
						}
						else if (fv3.TypedDefinition.a5() == "blastCloth")
						{
							double num3 = Math.Min(0.75, 0.15 + 0.005 * (double)num2);
							c.ar().Add(new dcp(-num3));
						}
						string classPropertyValue2 = ett3.a7().GetClassPropertyValue<string>("ArmorPrefix");
						if (!string.IsNullOrEmpty(classPropertyValue2))
						{
							c.g(classPropertyValue2 + " " + c.az());
						}
						num = ett3.a7().GetPrimitivePropertyValue<int>("MatIndex", null);
						string classPropertyValue3 = ett3.a7().GetClassPropertyValue<string>("ArmorDescription2");
						if (!string.IsNullOrEmpty(classPropertyValue3))
						{
							c43 c4 = c;
							c4.i(c4.a0() + " " + classPropertyValue3);
						}
						c43 c5 = c;
						c5.a(c5.e() + "_c");
					}
				}
				if (ett.a5() == "sturdyVest")
				{
					c6o.a(c, new dxd((int)((double)fv.QualityLevel * 0.7)));
				}
				if (num != null)
				{
					c43 c6 = c;
					c6.g(c6.az() + "штурмовой плащ");
					c.f("riotGearCoat." + num.Value.ToString());
				}
				else
				{
					int value = ett.a7().GetPrimitivePropertyValue<int>("MatIndex", new int?(0)).Value;
					c43 c7 = c;
					c7.g(c7.az() + "штурмовой доспех");
					c.f("riotGearVest." + value.ToString());
				}
				if (fv4 != null)
				{
					ett ett4 = fv4.TypedDefinition as ett;
					if (ett4 != null)
					{
						c6o.a(c, ett4, fv4.QualityLevel);
						c43 c8 = c;
						c8.b(c8.bf() + (double)fv4.SingleItemValue);
						c43 c9 = c;
						c9.h(c9.a4() + Math.Round(fv4.SingleItemWeight / 5.0, 2));
						if (Enumerable.Any<bt5>(ett4.d(), new Func<bt5, bool>(cz2.a.a.a)))
						{
							bt5 bt = Enumerable.First<bt5>(Enumerable.Where<bt5>(ett4.d(), new Func<bt5, bool>(cz2.a.a.b)));
							int num4 = (int)((double)((float)bt.BaseDamageThreshold + bt.DamageThresholdIncrement * (float)fv4.QualityLevel) * 2.25);
							if (ett4.a5() == "psiBeetleCarapace")
							{
								num4 = (int)((double)num4 * 1.5);
							}
							else if (ett4.a5() == "burrowerCarapace")
							{
								num4 = (int)((double)num4 * 1.5);
							}
							double num5 = 1.0;
							if (A_0 != null && A_0.Feats.Contains<dcs>() && ett4.i() == ms.ac)
							{
								num5 -= dcs.a + (double)A_0.GetSpecializationValue<b4e>(true) * b4e.a;
							}
							c.a(0.35);
							c.a(num4);
							c43 c10 = c;
							c10.b(c10.h() + ett4.f() * num5 * 0.35);
							c.b(Math.Max(c.g(), ett4.c() - 3));
						}
						int? primitivePropertyValue = ett4.a7().GetPrimitivePropertyValue<int>("ShieldMatIndex", null);
						if (primitivePropertyValue != null)
						{
							c43 c11 = c;
							c11.f(c11.a3() + "." + primitivePropertyValue.Value.ToString());
						}
						c43 c12 = c;
						c12.a(c12.e() + "_s");
						c.a(true);
						string classPropertyValue4 = ett4.a7().GetClassPropertyValue<string>("Material");
						string classPropertyValue5 = ett4.a7().GetClassPropertyValue<string>("ShieldShortName");
						if (!string.IsNullOrEmpty(classPropertyValue5))
						{
							c43 c13 = c;
							c13.g(c13.az() + string.Format(" с {0} щитом", classPropertyValue5));
						}
						if (!string.IsNullOrEmpty(classPropertyValue4))
						{
							if (string.IsNullOrEmpty(classPropertyValue5))
							{
								c43 c14 = c;
								c14.g(c14.az() + string.Format(" с {0} щитом", classPropertyValue4));
							}
							c43 c15 = c;
							c15.i(c15.a0() + string.Format(" С ним в комплекте так же идёт {0} щит, предоставляющий дополнительную защиту от атак в ближнем бою.", classPropertyValue4.ToLowerInvariant()));
						}
						else
						{
							if (string.IsNullOrEmpty(classPropertyValue5))
							{
								c43 c16 = c;
								c16.g(c16.az() + " с щитом");
							}
							c43 c17 = c;
							c17.i(c17.a0() + " С ним в комплекте так же идёт щит, предоставляющий дополнительную защиту от атак в ближнем бою.");
						}
						if (ett4.a5() == "psiBeetleCarapace" || ett4.a5() == "psiCrabCarapace")
						{
							int a_ = 2 + Math.Max(0, fv4.QualityLevel - 10) / 4;
							c6o.a(c, new bdz(new string[]
							{
								csn.a(typeof(rs)),
								csn.a(typeof(fd)),
								csn.a(typeof(dql)),
								csn.a(typeof(p5))
							}, a_, "Пси-навыки"));
						}
					}
				}
				c6o.a(c, new du2(DamageType.Mechanical, 2, 0.0));
				c.b(new double?(c.bf().Value * 3.0));
				if (fv3 != null && fv4 != null)
				{
					c.b(c.bf() * 1.2);
				}
				c.a(ItemRepairCategory.Fabric);
				if (c.h() >= 0.5)
				{
					c.a(ItemStealingCategory.ArmorHeavy);
				}
				return c8d;
			}
		}
		return null;
	}

	// Token: 0x04003B15 RID: 15125
	public new static readonly string a = "carrierVest";

	// Token: 0x04003B16 RID: 15126
	public new static readonly string b = "ballisticPanel";

	// Token: 0x04003B17 RID: 15127
	public static readonly string c = "shieldPlate";

	// Token: 0x04003B18 RID: 15128
	public new static readonly string d = "fabric";

	// Token: 0x02001BC9 RID: 7113
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009ABB RID: 39611 RVA: 0x003C4368 File Offset: 0x003C2568
		internal bool a(bt5 A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06009ABC RID: 39612 RVA: 0x003C4374 File Offset: 0x003C2574
		internal bool b(bt5 A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x04003B19 RID: 15129
		public static readonly cz2.a a = new cz2.a();

		// Token: 0x04003B1A RID: 15130
		public static Func<bt5, bool> b;

		// Token: 0x04003B1B RID: 15131
		public static Func<bt5, bool> c;
	}
}
