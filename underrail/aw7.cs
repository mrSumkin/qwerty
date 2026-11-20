using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BD8 RID: 7128
[dgg("Boots")]
public sealed class aw7 : cwp
{
	// Token: 0x06009B25 RID: 39717 RVA: 0x003C844C File Offset: 0x003C664C
	public override string bt()
	{
		return "茛Ботинки";
	}

	// Token: 0x06009B26 RID: 39718 RVA: 0x003C8454 File Offset: 0x003C6654
	public override string bu()
	{
		return "Boots";
	}

	// Token: 0x06009B27 RID: 39719 RVA: 0x003C845C File Offset: 0x003C665C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009B28 RID: 39720 RVA: 0x003C8460 File Offset: 0x003C6660
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Armor;
	}

	// Token: 0x06009B29 RID: 39721 RVA: 0x003C8464 File Offset: 0x003C6664
	public aw7()
	{
		base.Slots.Add(aw7.a, new cgo(new c6s(new ms[]
		{
			ms.ac,
			ms.d
		}, 44), "Материал", false, 1, 0.1f, true, false, null));
		base.Slots.Add(aw7.b, new cgo(new c6s(ms.e, 2), "Подкладка", false, 1, 0.1f, false, false, null));
		base.Slots.Add(aw7.c, new cgo(new eh0("rubberSole", 70), "Подошвы", false, 2, 0.1f, false, false, null));
		base.Slots.Add(aw7.d, new cgo(new c6s(new ms[]
		{
			ms.ad,
			ms.ay,
			ms.ac
		}, 24), "Улучшение", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009B2A RID: 39722 RVA: 0x003C854C File Offset: 0x003C674C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(aw7.a, null);
		fv fv2 = A_1.SafeGet(aw7.b, null);
		fv fv3 = A_1.SafeGet(aw7.c, null);
		if (fv != null && fv2 != null && fv3 != null && fv3.Stacks >= 2)
		{
			ett ett = fv.TypedDefinition as ett;
			ett ett2 = fv2.TypedDefinition as ett;
			if (ett != null && ett2 != null)
			{
				int num = fv.QualityLevel;
				if (A_0 != null && ett.i() == ms.d)
				{
					double num2 = 1.0;
					if (A_0.Feats.Contains<uh>())
					{
						num2 += uh.a(A_0);
					}
					if (A_0.Feats.Contains<eck>())
					{
						num2 += eck.a;
					}
					num = (int)((double)num * num2);
				}
				c5s c5s = new c5s();
				c5s.a(ett.bc());
				c5s.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue + fv3.SingleItemValue * 2)));
				c5s.h(Math.Round(fv.SingleItemWeight / 3.0 + fv2.SingleItemWeight / 2.0 + fv3.SingleItemWeight * 2.0, 2));
				c5s.g((int)Math.Ceiling(cwp.a(num)));
				c5s.g("");
				c5s.f("Boots.");
				c5s.a(ItemStealingCategory.Armor);
				c5s.a(a0.n);
				a12 a = new a12(new IndependentItemDefinitionProvider<c5s>(c5s));
				c6o.a(c5s, ett, num);
				c6o.a(A_0, a, ett, num, true, 0.35, true);
				ett ett3 = ett2.tw() as ett;
				ett3.a().Clear();
				c6o.a(c5s, ett2, fv2.QualityLevel / 3);
				c6o.a(A_0, a, ett3, fv2.QualityLevel, false, 0.3499999940395355, true);
				if (ett.i() == ms.d)
				{
					c5s c5s2 = c5s;
					c5s2.f(c5s2.a3() + "Leather");
					string classPropertyValue = ett.a7().GetClassPropertyValue<string>("SourceCreature");
					if (!string.IsNullOrEmpty(classPropertyValue))
					{
						string classPropertyValue2 = ett.a7().GetClassPropertyValue<string>("CustomInfusionLeatherType");
						c5s.g(string.Format("{0} {1} {2}", classPropertyValue, classPropertyValue2 ?? "кожан.", c5s.az()));
						c5s c5s3 = c5s;
						c5s3.f(c5s3.a3() + "." + classPropertyValue.Replace(" ", ""));
					}
					string classPropertyValue3 = ett.a7().GetClassPropertyValue<string>("ArmorDescriptionPlural");
					if (!string.IsNullOrEmpty(classPropertyValue3))
					{
						c5s.i(string.Format(classPropertyValue3, "ботинки"));
					}
					else
					{
						c5s.i("Эти ботинки сделаны из кожи");
					}
					c5s.a(ItemRepairCategory.Fabric);
					string text = ett.a5();
					if (text != null)
					{
						switch (text.Length)
						{
						case 27:
							if (!(text == "component.infusedPigLeather"))
							{
								goto IL_6AB;
							}
							c6o.a(c5s, new bgl(30));
							goto IL_6AB;
						case 28:
						case 31:
						case 35:
						case 36:
						case 37:
						case 38:
							goto IL_6AB;
						case 29:
							if (!(text == "component.infusedBisonLeather"))
							{
								goto IL_6AB;
							}
							c6o.a(c5s, new ddl(5 + num / 10));
							c6o.a(c5s, new du2(DamageType.Cold, 4, 0.0));
							goto IL_6AB;
						case 30:
						{
							if (!(text == "component.infusedSeaWyrmScales"))
							{
								goto IL_6AB;
							}
							int num3 = 7 + fv.QualityLevel / 15;
							a1q value = new a1q(DamageType.Mechanical, num3 / 2, num3);
							List<c3e> list = c5s.f();
							ean ean = new ean();
							ean.a(DamageType.Mechanical);
							ean.a(new a1q?(value));
							list.Add(ean);
							goto IL_6AB;
						}
						case 32:
						{
							char c = text[17];
							if (c != 'R')
							{
								if (c != 'S')
								{
									goto IL_6AB;
								}
								if (!(text == "component.infusedSiphonerLeather"))
								{
									goto IL_6AB;
								}
							}
							else
							{
								if (!(text == "component.infusedRathoundLeather"))
								{
									goto IL_6AB;
								}
								c6o.a(c5s, new dvq(0.02, cs5.d));
								goto IL_6AB;
							}
							break;
						}
						case 33:
							if (!(text == "component.infusedLeperSerpentSkin"))
							{
								goto IL_6AB;
							}
							c6o.a(c5s, new awe(CharacterImmunities.Unbalancing));
							goto IL_6AB;
						case 34:
						{
							char c = text[17];
							if (c != 'C')
							{
								if (c != 'M')
								{
									goto IL_6AB;
								}
								if (!(text == "component.infusedMutatedDogLeather"))
								{
									goto IL_6AB;
								}
								c6o.a(c5s, new awe(CharacterImmunities.AcidPuddles));
								goto IL_6AB;
							}
							else
							{
								if (!(text == "component.infusedCaveHopperLeather"))
								{
									goto IL_6AB;
								}
								c6o.a(c5s, new eox(CooldownCategory.Sprint, -3));
								goto IL_6AB;
							}
							break;
						}
						case 39:
						{
							char c = text[17];
							if (c != 'A')
							{
								if (c != 'G')
								{
									goto IL_6AB;
								}
								if (!(text == "component.infusedGreaterSiphonerLeather"))
								{
									goto IL_6AB;
								}
							}
							else
							{
								if (!(text == "component.infusedAncientRathoundLeather"))
								{
									goto IL_6AB;
								}
								c6o.a(c5s, new bhi(0.2, cs5.d));
								goto IL_6AB;
							}
							break;
						}
						case 40:
							if (!(text == "component.infusedHeartbreakerSerpentSkin"))
							{
								goto IL_6AB;
							}
							c6o.a(c5s, new du2(DamageType.Bio, 2, 0.0));
							goto IL_6AB;
						default:
							goto IL_6AB;
						}
						c6o.a(c5s, new awe(CharacterImmunities.Slow));
					}
				}
				else if (ett.i() == ms.ac)
				{
					c5s c5s4 = c5s;
					c5s4.f(c5s4.a3() + "Metal");
					string classPropertyValue4 = ett.a7().GetClassPropertyValue<string>("Material");
					if (!string.IsNullOrEmpty(classPropertyValue4))
					{
						c5s.g(classPropertyValue4 + " " + c5s.az());
						c5s.i(string.Format("Это {0} ботинки.", classPropertyValue4.ToLowerInvariant()));
						c5s c5s5 = c5s;
						c5s5.f(c5s5.a3() + "." + classPropertyValue4.Replace(" ", ""));
					}
					else
					{
						c5s.i("Эти ботинки сделаны из неизвестного сплава.");
					}
					c5s.a(ItemRepairCategory.Mechanical);
					c6o.a(c5s, new awe(CharacterImmunities.Caltrops));
					c6o.a(c5s, new ekr(SpecialCategory.DirtyKick, 1.0));
				}
				IL_6AB:
				string classPropertyValue5 = ett2.a7().GetClassPropertyValue<string>("BootsDesc");
				if (!string.IsNullOrEmpty(classPropertyValue5))
				{
					c5s c5s6 = c5s;
					c5s6.i(c5s6.a0() + " " + classPropertyValue5);
				}
				string classPropertyValue6 = ett2.a7().GetClassPropertyValue<string>("BootsPrefix");
				if (!string.IsNullOrEmpty(classPropertyValue6))
				{
					c5s.g(classPropertyValue6 + " " + c5s.az());
				}
				fv a_ = A_1.SafeGet(aw7.d, null);
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				string text2 = null;
				this.a(A_0, a_, a, ref flag, ref flag2, ref flag3, ref text2);
				c5s c5s7 = c5s;
				c5s7.b(c5s7.bf() * (double)2);
				foreach (c3e c3e in c5s.f())
				{
					ean ean2 = c3e as ean;
					if (ean2 != null)
					{
						ean2.a(true);
					}
					dpx dpx = c3e as dpx;
					if (dpx != null)
					{
						dpx.a(true);
					}
				}
				if (ett.i() == ms.ac)
				{
					dpw dpw = Enumerable.FirstOrDefault<dpw>(Enumerable.Where<dpw>(Enumerable.OfType<dpw>(c5s.ar()), new Func<dpw, bool>(aw7.a.a.a)));
					if (dpw != null && dpw.c() > 0)
					{
						c5s.ar().Remove(dpw);
					}
				}
				c5s.b(0);
				if (flag2)
				{
					c5s.g("Покрытые лезвиями " + c5s.az());
					c5s c5s8 = c5s;
					c5s8.f(c5s8.a3() + ".Blade");
				}
				else if (flag)
				{
					c5s.g("Шипованные " + c5s.az());
					c5s c5s9 = c5s;
					c5s9.f(c5s9.a3() + ".Spike");
				}
				else if (flag3)
				{
					c5s.g("Укреплённые " + c5s.az());
					c5s c5s10 = c5s;
					c5s10.f(c5s10.a3() + ".Reinforced");
				}
				if (!string.IsNullOrEmpty(text2))
				{
					c5s c5s11 = c5s;
					c5s11.g(c5s11.az() + text2);
				}
				else
				{
					c5s c5s12 = c5s;
					c5s12.g(c5s12.az() + "ботинки");
				}
				if (flag3)
				{
					c5s c5s13 = c5s;
					c5s13.i(c5s13.a0() + string.Format(" Они также усилены {0}металлическими пластинами.", (ett.i() == ms.ac) ? "дополнительно " : ""));
				}
				else if (flag2)
				{
					c5s c5s14 = c5s;
					c5s14.i(c5s14.a0() + " Они также имеют опасные зазубренные лезвиями, наносящими дополнительный урон вашим оппонентам в рукопашной.");
				}
				else if (flag)
				{
					c5s c5s15 = c5s;
					c5s15.i(c5s15.a0() + " Они также имеют опасные зазубренные шипы на носках, способные наносить дополнительный урон вашим врагам в рукопашной.");
				}
				c5s.b(Math.Round(c5s.h() * 0.6, 2));
				return a;
			}
		}
		return null;
	}

	// Token: 0x06009B2B RID: 39723 RVA: 0x003C8F54 File Offset: 0x003C7154
	private void a(efk A_0, fv A_1, a12 A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref string A_6)
	{
		double num = 1.0;
		if (A_1 != null)
		{
			ett ett = A_1.TypedDefinition as ett;
			if (ett != null)
			{
				if (!A_3)
				{
					A_3 = ett.a7().GetPrimitivePropertyValue<bool>("IsSpike", new bool?(false)).Value;
				}
				if (!A_4)
				{
					A_4 = ett.a7().GetPrimitivePropertyValue<bool>("IsBlade", new bool?(false)).Value;
				}
				bool value = ett.a7().GetPrimitivePropertyValue<bool>("IsMetalPlate", new bool?(false)).Value;
				if (value)
				{
					num = 0.2;
				}
				if (!A_5)
				{
					A_5 = value;
				}
				c6o.a(A_0, A_2, ett, A_1.QualityLevel, value, value ? 0.25 : 1.0, false);
			}
			else
			{
				a1k a1k = A_1.TypedDefinition;
				if (A_1 != null)
				{
					int value2 = a1k.a7().GetPrimitivePropertyValue<int>("BaseMovementPointsMod", new int?(0)).Value;
					double value3 = a1k.a7().GetPrimitivePropertyValue<double>("MovementPointsPerQualityMod", new double?(0.0)).Value;
					double value4 = a1k.a7().GetPrimitivePropertyValue<double>("BaseMovementSpeedMod", new double?(0.0)).Value;
					double value5 = a1k.a7().GetPrimitivePropertyValue<double>("MovementSpeedPerQualityMod", new double?(0.0)).Value;
					int num2 = (int)((double)value2 + value3 * (double)A_1.QualityLevel);
					double num3 = value4 + value5 * (double)A_1.QualityLevel;
					A_6 = a1k.a7().GetClassPropertyValue<string>("CustomBootsName");
					if (num2 != 0)
					{
						c6o.a(A_2.fu(), new ba(num2, true, true, false));
					}
					if (num3 != 0.0)
					{
						c6o.a(A_2.fu(), new i0((float)num3, true, false, false));
					}
					string classPropertyValue = a1k.a7().GetClassPropertyValue<string>("BootsDesc");
					if (!string.IsNullOrEmpty(classPropertyValue))
					{
						c5s c5s = A_2.fu();
						c5s.i(c5s.a0() + " " + classPropertyValue);
					}
					string classPropertyValue2 = a1k.a7().GetClassPropertyValue<string>("IconParam");
					if (!string.IsNullOrEmpty(classPropertyValue2))
					{
						c5s c5s2 = A_2.fu();
						c5s2.f(c5s2.a3() + "." + classPropertyValue2);
					}
				}
			}
			c6o.a(A_2.fu(), A_1.TypedDefinition, A_1.QualityLevel);
			c5s c5s3 = A_2.fu();
			c5s3.b(c5s3.bf() + (double)A_1.SingleItemValue);
			c5s c5s4 = A_2.fu();
			c5s4.h(c5s4.a4() + A_1.SingleItemWeight * num);
		}
	}

	// Token: 0x04003B4D RID: 15181
	public new static readonly string a = "material";

	// Token: 0x04003B4E RID: 15182
	public new static readonly string b = "padding";

	// Token: 0x04003B4F RID: 15183
	public static readonly string c = "soles";

	// Token: 0x04003B50 RID: 15184
	public new static readonly string d = "enhancement";

	// Token: 0x02001BD9 RID: 7129
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009B2F RID: 39727 RVA: 0x003C9294 File Offset: 0x003C7494
		internal bool a(dpw A_0)
		{
			return string.Equals(A_0.SkillName, "stealth", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04003B51 RID: 15185
		public static readonly aw7.a a = new aw7.a();

		// Token: 0x04003B52 RID: 15186
		public static Func<dpw, bool> b;
	}
}
