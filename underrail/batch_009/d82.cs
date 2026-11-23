using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BEF RID: 7151
[dgg("LeatherArmor")]
public sealed class d82 : cwp
{
	// Token: 0x06009BCF RID: 39887 RVA: 0x003D0FCC File Offset: 0x003CF1CC
	public override string bt()
	{
		return "茘Кожаная броня";
	}

	// Token: 0x06009BD0 RID: 39888 RVA: 0x003D0FD4 File Offset: 0x003CF1D4
	public override string bu()
	{
		return "LeatherArmor";
	}

	// Token: 0x06009BD1 RID: 39889 RVA: 0x003D0FDC File Offset: 0x003CF1DC
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009BD2 RID: 39890 RVA: 0x003D0FE0 File Offset: 0x003CF1E0
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Armor;
	}

	// Token: 0x06009BD3 RID: 39891 RVA: 0x003D0FE8 File Offset: 0x003CF1E8
	public d82()
	{
		base.Slots.Add(d82.a, new cgo(new c6s(ms.d, 1), "Кожа", false, 1, 0.1f, false, false, null));
		base.Slots.Add(d82.b, new cgo(new c6s(ms.e, 2), "Подкладка", true, 1, 0.1f, false, false, null));
		base.Slots.Add(d82.c, new cgo(new c6s(ms.c, 3), "Ткань плаща", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009BD4 RID: 39892 RVA: 0x003D107C File Offset: 0x003CF27C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(d82.a, null);
		if (fv != null)
		{
			ett ett = fv.TypedDefinition as ett;
			if (ett != null)
			{
				int num = fv.QualityLevel;
				if (A_0 != null && A_0.Feats.Contains<uh>())
				{
					num = (int)((double)num * (1.0 + uh.a(A_0)));
				}
				c43 c = new c43();
				c.a(ett.bc());
				c.b(new double?((double)fv.SingleItemValue));
				c.h(fv.SingleItemWeight);
				c.g((int)Math.Ceiling(cwp.a(num)));
				c.a(ItemStealingCategory.Armor);
				c.a(a0.i);
				c8d c8d = new c8d(new IndependentItemDefinitionProvider<c43>(c));
				c6o.a(c, ett, num);
				c6o.a(A_0, c8d, ett, num, false, 1.0, true);
				fv fv2 = A_1.SafeGet(d82.c, null);
				string classPropertyValue = ett.a7().GetClassPropertyValue<string>("SourceCreature");
				string classPropertyValue2 = ett.a7().GetClassPropertyValue<string>("CustomLeatherArmorType");
				string text = ett.a5();
				if (text != null)
				{
					switch (text.Length)
					{
					case 27:
						if (!(text == "component.infusedPigLeather"))
						{
							goto IL_45F;
						}
						c6o.a(c, new dxd(25 + num / 2));
						goto IL_45F;
					case 28:
					case 31:
					case 35:
					case 36:
					case 37:
					case 38:
						goto IL_45F;
					case 29:
						if (!(text == "component.infusedBisonLeather"))
						{
							goto IL_45F;
						}
						c6o.a(c, new dxd((int)(20.0 + (double)num / 2.5)));
						c6o.a(c, new awe(CharacterImmunities.Chill));
						goto IL_45F;
					case 30:
					{
						if (!(text == "component.infusedSeaWyrmScales"))
						{
							goto IL_45F;
						}
						List<c3e> list = c.f();
						ctt ctt = new ctt();
						ctt.a(0.25);
						list.Add(ctt);
						goto IL_45F;
					}
					case 32:
					{
						char c2 = text[17];
						if (c2 != 'R')
						{
							if (c2 != 'S')
							{
								goto IL_45F;
							}
							if (!(text == "component.infusedSiphonerLeather"))
							{
								goto IL_45F;
							}
						}
						else
						{
							if (!(text == "component.infusedRathoundLeather"))
							{
								goto IL_45F;
							}
							double a_ = 0.01 + 0.00075 * (double)num;
							c6o.a(c, new dvq(a_, cs5.a));
							goto IL_45F;
						}
						break;
					}
					case 33:
						if (!(text == "component.infusedLeperSerpentSkin"))
						{
							goto IL_45F;
						}
						c6o.a(c, new e3r(DamageType.Bio, -0.2));
						goto IL_45F;
					case 34:
					{
						char c2 = text[17];
						if (c2 != 'C')
						{
							if (c2 != 'M')
							{
								goto IL_45F;
							}
							if (!(text == "component.infusedMutatedDogLeather"))
							{
								goto IL_45F;
							}
							c6o.a(c, new b2g(0.2 + 0.002 * (double)num));
							goto IL_45F;
						}
						else
						{
							if (!(text == "component.infusedCaveHopperLeather"))
							{
								goto IL_45F;
							}
							c6o.a(c, new i0(0.05f + 0.001f * (float)num, false, false, false));
							c6o.a(c, new ba((int)(5.0 + 0.2 * (double)num), false, true, false));
							goto IL_45F;
						}
						break;
					}
					case 39:
					{
						char c2 = text[17];
						if (c2 != 'A')
						{
							if (c2 != 'G')
							{
								goto IL_45F;
							}
							if (!(text == "component.infusedGreaterSiphonerLeather"))
							{
								goto IL_45F;
							}
						}
						else
						{
							if (!(text == "component.infusedAncientRathoundLeather"))
							{
								goto IL_45F;
							}
							c6o.a(c, new e3r(DamageType.Heat, -(0.01 + 0.001 * (double)num)));
							c6o.a(c, new e3r(DamageType.Cold, -(0.01 + 0.001 * (double)num)));
							goto IL_45F;
						}
						break;
					}
					case 40:
					{
						if (!(text == "component.infusedHeartbreakerSerpentSkin"))
						{
							goto IL_45F;
						}
						int a_2 = 2 + num / 33;
						c6o.a(c, new b5x(a_2));
						goto IL_45F;
					}
					default:
						goto IL_45F;
					}
					c6o.a(c, new bel(num / 3));
					c6o.a(c, new a6z(num / 3));
				}
				IL_45F:
				if (fv2 != null)
				{
					ett ett2 = fv2.TypedDefinition as ett;
					if (ett2 != null)
					{
						int num2 = fv2.QualityLevel;
						if (A_0 != null && A_0.Feats.Contains<rh>())
						{
							num2 = (int)((double)num2 * (1.0 + rh.a(A_0)));
						}
						c43 c3 = c;
						c3.b(c3.bf() + (double)fv2.SingleItemValue);
						c43 c4 = c;
						c4.h(c4.a4() + fv2.SingleItemWeight);
						c6o.a(c, ett2, num2);
						c6o.a(A_0, c8d, ett2, num2, false, 1.0, true);
						if (ett2.a5() == "aluminizedCloth")
						{
							c6o.a(c, new awe(CharacterImmunities.Burning));
						}
					}
				}
				fv fv3 = A_1.SafeGet(d82.b, null);
				if (fv3 != null)
				{
					ett ett3 = fv3.TypedDefinition as ett;
					if (ett3 != null)
					{
						c43 c5 = c;
						c5.b(c5.bf() + (double)fv3.SingleItemValue);
						c43 c6 = c;
						c6.h(c6.a4() + fv3.SingleItemWeight);
						c6o.a(c, ett3, fv3.QualityLevel);
						c6o.a(A_0, c8d, ett3, fv3.QualityLevel, false, 0.5, true);
						if (ett3.a5() == "insulatingFoamPadding")
						{
							c6o.a(c, new awe(CharacterImmunities.Freeze));
						}
						else if (ett3.a5() == "highDensityFoamPadding")
						{
							eey eey = Enumerable.FirstOrDefault<eey>(Enumerable.OfType<eey>(c.f()));
							if (eey == null)
							{
								eey = new eey();
								c.f().Add(eey);
							}
							eey.Bonus += 0.15 + Math.Max(0.0, (double)(fv3.QualityLevel - 15) * 0.0015);
						}
					}
				}
				if (fv2 != null && fv3 != null)
				{
					c.b(c.bf() * 2.5);
				}
				else
				{
					c.b(new double?(c.bf().Value * 2.25));
				}
				c.i("");
				string classPropertyValue3 = ett.a7().GetClassPropertyValue<string>("ArmorDescription");
				if (fv2 != null)
				{
					if (classPropertyValue3 != null)
					{
						c.i(string.Format(classPropertyValue3, "плащ"));
					}
					string classPropertyValue4 = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("OvercoatType");
					bool value = fv.TypedDefinition.a7().GetPrimitivePropertyValue<bool>("UsesDefaultOvercoat", new bool?(false)).Value;
					c.g("кожаный плащ");
					if (value)
					{
						c.f("Armor.Leather." + (classPropertyValue ?? "").Replace(" ", "") + ".DefaultOvercoat");
					}
					else if (!string.IsNullOrEmpty(classPropertyValue4))
					{
						c.f("Armor.Leather.Overcoat." + classPropertyValue4);
					}
					else
					{
						c.f("Armor.Leather." + (classPropertyValue ?? "").Replace(" ", ""));
					}
					string text2;
					if (value)
					{
						text2 = fv.TypedDefinition.a7().GetClassPropertyValue<string>("LeatherArmorVisualVariant") + "_c";
					}
					else
					{
						text2 = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("LeatherArmorVisualVariant");
					}
					if (text2 != null)
					{
						c.a(text2);
					}
					if (fv2.TypedDefinition.a5() == "kevlarCloth")
					{
						dwb dwb = Enumerable.FirstOrDefault<dwb>(Enumerable.OfType<dwb>(c.f()));
						if (dwb == null)
						{
							dwb = new dwb();
							c.f().Add(dwb);
						}
						dwb.Bonus += 0.1 + Math.Max(0.0, (double)(fv2.QualityLevel - 15) * 0.005);
					}
					else if (fv2.TypedDefinition.a5() == "blastCloth")
					{
						double num3 = Math.Min(0.75, 0.15 + 0.005 * (double)fv2.QualityLevel);
						c6o.a(c, new dcp(-num3));
					}
				}
				else
				{
					if (!string.IsNullOrEmpty(classPropertyValue2))
					{
						c.g(classPropertyValue2);
					}
					else
					{
						c.g("кожаная броня");
					}
					if (classPropertyValue3 != null)
					{
						if (!string.IsNullOrEmpty(classPropertyValue2))
						{
							c.i(string.Format(classPropertyValue3, classPropertyValue2.ToLowerInvariant()));
						}
						else
						{
							c.i(string.Format(classPropertyValue3, "доспех"));
						}
					}
					string classPropertyValue5 = fv.TypedDefinition.a7().GetClassPropertyValue<string>("LeatherArmorVisualVariant");
					c.f("Armor.Leather." + (classPropertyValue ?? "").Replace(" ", ""));
					c.a(classPropertyValue5 ?? "scavle");
				}
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					c.g(classPropertyValue + " " + c.az());
				}
				if (fv3 != null)
				{
					c.g("Подбит. " + c.az());
				}
				if (fv3 != null)
				{
					string classPropertyValue6 = fv3.TypedDefinition.a7().GetClassPropertyValue<string>("ArmorDescription");
					if (!string.IsNullOrEmpty(classPropertyValue6))
					{
						c43 c7 = c;
						c7.i(c7.a0() + " " + classPropertyValue6);
					}
				}
				if (fv2 != null)
				{
					string classPropertyValue7 = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("ArmorDescription");
					if (!string.IsNullOrEmpty(classPropertyValue7))
					{
						c43 c8 = c;
						c8.i(c8.a0() + " " + classPropertyValue7);
					}
					string classPropertyValue8 = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("ArmorPrefix");
					if (!string.IsNullOrEmpty(classPropertyValue8))
					{
						c.g(classPropertyValue8 + " " + c.az());
					}
				}
				c.a(ItemRepairCategory.Fabric);
				return c8d;
			}
		}
		return null;
	}

	// Token: 0x04003BA0 RID: 15264
	public new static readonly string a = "leather";

	// Token: 0x04003BA1 RID: 15265
	public new static readonly string b = "padding";

	// Token: 0x04003BA2 RID: 15266
	public static readonly string c = "fabric";
}
