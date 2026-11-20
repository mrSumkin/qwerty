using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BE4 RID: 7140
[dgg("tacticalVest")]
public sealed class dn8 : cwp
{
	// Token: 0x06009B7F RID: 39807 RVA: 0x003CD444 File Offset: 0x003CB644
	public override string bt()
	{
		return "茐Тактический жилет";
	}

	// Token: 0x06009B80 RID: 39808 RVA: 0x003CD44C File Offset: 0x003CB64C
	public override string bu()
	{
		return "TacticalVest";
	}

	// Token: 0x06009B81 RID: 39809 RVA: 0x003CD454 File Offset: 0x003CB654
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009B82 RID: 39810 RVA: 0x003CD458 File Offset: 0x003CB658
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B83 RID: 39811 RVA: 0x003CD45C File Offset: 0x003CB65C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Armor;
	}

	// Token: 0x06009B84 RID: 39812 RVA: 0x003CD464 File Offset: 0x003CB664
	public dn8()
	{
		base.Slots.Add(dn8.a, new cgo(new c6s(ms.aa, 20), "Разгрузочный жилет", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dn8.b, new cgo(new c6s(ms.z, 21), "Баллистическая панель", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dn8.c, new cgo(new c6s(ms.ab, 22), "Пластина брони", true, 1, 0f, false, false, null));
		base.Slots.Add(dn8.d, new cgo(new c6s(ms.c, 3), "Ткань плаща", true, 1, 0.1f, true, false, null));
	}

	// Token: 0x06009B85 RID: 39813 RVA: 0x003CD52C File Offset: 0x003CB72C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(dn8.a, null);
		fv fv2 = A_1.SafeGet(dn8.b, null);
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
				c.a(a0.j);
				c8d c8d = new c8d(new IndependentItemDefinitionProvider<c43>(c));
				c6o.a(c, ett, fv.QualityLevel);
				c6o.a(A_0, c8d, ett, fv.QualityLevel, false, 1.0, true);
				c6o.a(c, ett2, fv2.QualityLevel);
				c6o.a(A_0, c8d, ett2, fv2.QualityLevel, false, 1.0, true);
				if (A_0 != null && A_0.Feats.Contains<e>())
				{
					c6o.a(c, new du2(DamageType.Mechanical, e.a + A_0.GetSpecializationValue<av3>(true) * av3.a, 0.0));
				}
				fv fv3 = A_1.SafeGet(dn8.d, null);
				fv fv4 = A_1.SafeGet(dn8.c, null);
				if (fv3 != null)
				{
					c.g("плащ");
				}
				else
				{
					c.g("жилет");
				}
				c.a("blve");
				c.i(ett.a7().GetClassPropertyValue<string>("ArmorDescription") + " " + ett2.a7().GetClassPropertyValue<string>("ArmorDescription"));
				if (fv4 != null)
				{
					ett ett3 = fv4.TypedDefinition as ett;
					if (ett3 != null)
					{
						c43 c2 = c;
						c2.b(c2.bf() + Math.Min(c.bf().Value * 3.0, (double)fv4.SingleItemValue));
						c43 c3 = c;
						c3.h(c3.a4() + fv4.SingleItemWeight);
						c6o.a(c, ett3, fv4.QualityLevel);
						c6o.a(A_0, c8d, ett3, fv4.QualityLevel, false, 1.0, true);
						string classPropertyValue = ett3.a7().GetClassPropertyValue<string>("ArmorPrefix");
						if (!string.IsNullOrEmpty(classPropertyValue))
						{
							c.g(classPropertyValue + " " + c.az());
						}
						string classPropertyValue2 = ett3.a7().GetClassPropertyValue<string>("ArmorDescription");
						if (!string.IsNullOrEmpty(classPropertyValue2))
						{
							c43 c4 = c;
							c4.i(c4.a0() + " " + classPropertyValue2);
						}
						if (ett3.a5() == "psiBeetleCarapace" || ett3.a5() == "psiCrabCarapace")
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
				c.g((fv.TypedDefinition.a7().GetClassPropertyValue<string>("VestType") ?? "Тактическ.") + " " + c.az());
				string text = null;
				if (fv3 != null)
				{
					ett ett4 = fv3.TypedDefinition as ett;
					if (ett4 != null)
					{
						int num = fv3.QualityLevel;
						if (A_0 != null && A_0.Feats.Contains<rh>())
						{
							num = (int)((double)num * (1.0 + rh.a(A_0)));
						}
						c43 c5 = c;
						c5.b(c5.bf() + Math.Min(c.bf().Value * 3.0, (double)fv3.SingleItemValue));
						c43 c6 = c;
						c6.h(c6.a4() + fv3.SingleItemWeight);
						c6o.a(c, ett4, num);
						c6o.a(A_0, c8d, ett4, num, false, 1.0, true);
						string classPropertyValue3 = ett4.a7().GetClassPropertyValue<string>("ArmorPrefix");
						if (!string.IsNullOrEmpty(classPropertyValue3))
						{
							c.g(classPropertyValue3 + " " + c.az());
						}
						text = fv3.TypedDefinition.a7().GetClassPropertyValue<string>("OvercoatType");
						string classPropertyValue4 = ett4.a7().GetClassPropertyValue<string>("ArmorDescription2");
						if (!string.IsNullOrEmpty(classPropertyValue4))
						{
							c43 c7 = c;
							c7.i(c7.a0() + " " + classPropertyValue4);
						}
						string classPropertyValue5 = ett4.a7().GetClassPropertyValue<string>("TacticalVestVisualVariant");
						if (!string.IsNullOrEmpty(classPropertyValue5))
						{
							c.a(classPropertyValue5);
						}
						if (ett4.a5() == "aluminizedCloth")
						{
							c.ar().Add(new awe(CharacterImmunities.Burning));
						}
						if (fv3.TypedDefinition.a5() == "kevlarCloth")
						{
							dwb dwb = Enumerable.FirstOrDefault<dwb>(Enumerable.OfType<dwb>(c.f()));
							if (dwb == null)
							{
								dwb = new dwb();
								c.f().Add(dwb);
							}
							dwb.Bonus += 0.1 + Math.Max(0.0, (double)(num - 15) * 0.005);
						}
						else if (fv3.TypedDefinition.a5() == "blastCloth")
						{
							double num2 = Math.Min(0.75, 0.15 + 0.004 * (double)num);
							c.ar().Add(new dcp(-num2));
						}
					}
				}
				if (ett.a5() == "sturdyVest")
				{
					c6o.a(c, new dxd((int)((double)fv.QualityLevel * 0.5)));
				}
				c.b(new double?(c.bf().Value * 3.0));
				if (fv3 != null && fv4 != null)
				{
					c.b(c.bf() * 1.2);
				}
				if (!string.IsNullOrEmpty(text))
				{
					c.f("Armor.Vest.Overcoat." + text);
				}
				else
				{
					c.f("Armor.Vest." + fv.TypedDefinition.a7().GetClassPropertyValue<string>("VestType"));
				}
				c.a(ItemRepairCategory.Fabric);
				if (c.h() >= 0.5)
				{
					c.a(ItemStealingCategory.ArmorHeavy);
				}
				c.b(0);
				return c8d;
			}
		}
		return null;
	}

	// Token: 0x04003B79 RID: 15225
	public new static readonly string a = "carrierVest";

	// Token: 0x04003B7A RID: 15226
	public new static readonly string b = "ballisticPanel";

	// Token: 0x04003B7B RID: 15227
	public static readonly string c = "armorPlate";

	// Token: 0x04003B7C RID: 15228
	public new static readonly string d = "fabric";
}
