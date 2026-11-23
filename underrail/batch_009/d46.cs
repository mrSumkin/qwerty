using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BC1 RID: 7105
[dgg("TabiBoots")]
public sealed class d46 : cwp, bd3
{
	// Token: 0x06009A83 RID: 39555 RVA: 0x003C1B58 File Offset: 0x003BFD58
	public override string bt()
	{
		return "茚Таби";
	}

	// Token: 0x06009A84 RID: 39556 RVA: 0x003C1B60 File Offset: 0x003BFD60
	public override string bu()
	{
		return "TabiBoots";
	}

	// Token: 0x06009A85 RID: 39557 RVA: 0x003C1B68 File Offset: 0x003BFD68
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009A86 RID: 39558 RVA: 0x003C1B6C File Offset: 0x003BFD6C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Armor;
	}

	// Token: 0x06009A87 RID: 39559 RVA: 0x003C1B70 File Offset: 0x003BFD70
	public d46()
	{
		base.Slots.Add(d46.a, new cgo(new c6s(new ms[]
		{
			ms.c,
			ms.d
		}, 71), "Материал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(d46.b, new cgo(new eh0("rubberSole", 70), "Подошвы", false, 2, 0.1f, false, false, null));
	}

	// Token: 0x06009A88 RID: 39560 RVA: 0x003C1BEC File Offset: 0x003BFDEC
	public List<bj8> bz()
	{
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 11; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				bj8 bj = new bj8();
				bj.a(string.Format("TabiBoots.{0}.{1}", i, j));
				bj.a().Add(new d8h("Armors", new Point(i, 22 + j), 1f));
				list.Add(bj);
			}
		}
		return list;
	}

	// Token: 0x06009A89 RID: 39561 RVA: 0x003C1C6C File Offset: 0x003BFE6C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(d46.a, null);
		fv fv2 = A_1.SafeGet(d46.b, null);
		if (fv != null && fv2 != null && fv2.Stacks >= 2)
		{
			ett ett = fv.TypedDefinition as ett;
			if (ett != null)
			{
				int num = fv.QualityLevel;
				if (A_0 != null)
				{
					if (ett.i() == ms.d && A_0.Feats.Contains<uh>())
					{
						num = (int)((double)num * (1.0 + uh.a(A_0)));
					}
					else if (ett.i() == ms.c && A_0.Feats.Contains<rh>())
					{
						num = (int)((double)num * (1.0 + rh.a(A_0)));
					}
				}
				c5s c5s = new c5s();
				c5s.a(ett.bc());
				c5s.b(new double?((double)fv.SingleItemValue));
				c5s.h(Math.Round(fv.SingleItemWeight / 3.0, 2));
				c5s.g((int)Math.Ceiling(cwp.a(num)));
				c5s.g("таби");
				c5s.a(ItemStealingCategory.Armor);
				c5s.a(a0.n);
				c5s.a(ItemRepairCategory.Fabric);
				a12 a = new a12(new IndependentItemDefinitionProvider<c5s>(c5s));
				int a_ = (int)(5.0 + 0.2 * (double)num);
				double num2 = 0.07 + 0.0015 * (double)num;
				int a_2 = (int)(5.0 + 0.3 * (double)num);
				int a_3 = (int)(5.0 + 0.3 * (double)num);
				c6o.a(c5s, new ba(a_, false, true, false));
				c6o.a(c5s, new i0((float)num2, false, false, false));
				c6o.a(c5s, new bel(a_2));
				c6o.a(c5s, new a6z(a_3));
				c6o.a(c5s, new bjo(0f, -1, new btz[]
				{
					btz.g
				}));
				c6o.a(c5s, ett, num);
				c6o.a(A_0, a, ett, num, true, 1.0, false);
				int num3 = c5s.i().FindIndex(new Predicate<du2>(d46.a.a.a));
				if (num3 != -1)
				{
					c5s.i().RemoveAt(num3);
				}
				for (int i = c5s.f().Count - 1; i >= 0; i--)
				{
					if (c5s.f()[i] is eey)
					{
						c5s.f().RemoveAt(i);
					}
				}
				if (ett.i() == ms.d)
				{
					string classPropertyValue = ett.a7().GetClassPropertyValue<string>("SourceCreature");
					if (!string.IsNullOrEmpty(classPropertyValue))
					{
						string classPropertyValue2 = ett.a7().GetClassPropertyValue<string>("CustomInfusionLeatherType");
						c5s.g(string.Format("{0} {1} {2}", classPropertyValue, classPropertyValue2 ?? "кожан.", c5s.az()));
					}
					string classPropertyValue3 = ett.a7().GetClassPropertyValue<string>("ArmorDescriptionPlural");
					if (!string.IsNullOrEmpty(classPropertyValue3))
					{
						c5s.i(string.Format(classPropertyValue3, "таби"));
					}
					else
					{
						c5s.i("Эти тапочки таби сделаны из кожи.");
					}
					int value = ett.a7().GetPrimitivePropertyValue<int>("Infusion", new int?(0)).Value;
					int value2 = ett.a7().GetPrimitivePropertyValue<int>("MatIndex", new int?(0)).Value;
					c5s.f(string.Format("TabiBoots.{0}.{1}", value2, value));
					string text = ett.a5();
					if (text != null)
					{
						switch (text.Length)
						{
						case 27:
							if (!(text == "component.infusedPigLeather"))
							{
								goto IL_6AE;
							}
							c6o.a(c5s, new ddl(20 + num / 10));
							goto IL_6AE;
						case 28:
						case 31:
						case 35:
						case 36:
						case 37:
						case 38:
							goto IL_6AE;
						case 29:
							if (!(text == "component.infusedBisonLeather"))
							{
								goto IL_6AE;
							}
							c6o.a(c5s, new ddl(10 + num / 20));
							c6o.a(c5s, new du2(DamageType.Cold, 2, 0.0));
							goto IL_6AE;
						case 30:
						{
							if (!(text == "component.infusedSeaWyrmScales"))
							{
								goto IL_6AE;
							}
							int num4 = 5 + fv.QualityLevel / 20;
							a1q value3 = new a1q(DamageType.Mechanical, num4 / 2, num4);
							List<c3e> list = c5s.f();
							ean ean = new ean();
							ean.a(DamageType.Mechanical);
							ean.a(new a1q?(value3));
							list.Add(ean);
							goto IL_6AE;
						}
						case 32:
						{
							char c = text[17];
							if (c != 'R')
							{
								if (c != 'S')
								{
									goto IL_6AE;
								}
								if (!(text == "component.infusedSiphonerLeather"))
								{
									goto IL_6AE;
								}
							}
							else
							{
								if (!(text == "component.infusedRathoundLeather"))
								{
									goto IL_6AE;
								}
								c6o.a(c5s, new eox(CooldownCategory.DirtyKick, -2));
								goto IL_6AE;
							}
							break;
						}
						case 33:
							if (!(text == "component.infusedLeperSerpentSkin"))
							{
								goto IL_6AE;
							}
							c6o.a(c5s, new awe(CharacterImmunities.Unbalancing));
							goto IL_6AE;
						case 34:
						{
							char c = text[17];
							if (c != 'C')
							{
								if (c != 'M')
								{
									goto IL_6AE;
								}
								if (!(text == "component.infusedMutatedDogLeather"))
								{
									goto IL_6AE;
								}
								c6o.a(c5s, new awe(CharacterImmunities.AcidPuddles));
								goto IL_6AE;
							}
							else
							{
								if (!(text == "component.infusedCaveHopperLeather"))
								{
									goto IL_6AE;
								}
								c6o.a(c5s, new eox(CooldownCategory.Sprint, -5));
								goto IL_6AE;
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
									goto IL_6AE;
								}
								if (!(text == "component.infusedGreaterSiphonerLeather"))
								{
									goto IL_6AE;
								}
							}
							else
							{
								if (!(text == "component.infusedAncientRathoundLeather"))
								{
									goto IL_6AE;
								}
								c6o.a(c5s, new du2(DamageType.Cold, 2, 0.0));
								c6o.a(c5s, new du2(DamageType.Heat, 2, 0.0));
								goto IL_6AE;
							}
							break;
						}
						case 40:
							if (!(text == "component.infusedHeartbreakerSerpentSkin"))
							{
								goto IL_6AE;
							}
							c6o.a(c5s, new du2(DamageType.Bio, 2, 0.0));
							goto IL_6AE;
						default:
							goto IL_6AE;
						}
						c6o.a(c5s, new awe(CharacterImmunities.Slow));
					}
					IL_6AE:
					c6o.a(c5s, new l5(0.015));
				}
				else
				{
					string classPropertyValue4 = ett.a7().GetClassPropertyValue<string>("BootPrefix");
					if (!string.IsNullOrEmpty(classPropertyValue4))
					{
						c5s.g(classPropertyValue4 + " " + c5s.az());
					}
					c5s.i(ett.a7().GetClassPropertyValue<string>("TabiBootsDesc"));
					c5s.f("Armors." + (210 + ett.a7().GetPrimitivePropertyValue<int>("MatIndex", new int?(0)).Value).ToString());
					string text = ett.a5();
					if (!(text == "kevlarCloth"))
					{
						if (text == "blastCloth")
						{
							double num5 = Math.Min(0.75, 0.1 + 0.002 * (double)num);
							c6o.a(c5s, new dcp(-num5));
						}
					}
					else
					{
						c5s.i().Add(new du2(DamageType.Mechanical, 2, 0.0));
						dwb item = new dwb
						{
							Bonus = 2.0
						};
						c5s.f().Add(item);
					}
					c6o.a(c5s, new l5(0.03));
				}
				c5s c5s2 = c5s;
				c5s2.b(c5s2.bf() * (double)2);
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
				c5s.b(0.0);
				c5s.b(0);
				return a;
			}
		}
		return null;
	}

	// Token: 0x04003B05 RID: 15109
	public new static readonly string a = "material";

	// Token: 0x04003B06 RID: 15110
	public new static readonly string b = "soles";

	// Token: 0x02001BC2 RID: 7106
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009A8D RID: 39565 RVA: 0x003C2588 File Offset: 0x003C0788
		internal bool a(du2 A_0)
		{
			return A_0.b() == DamageType.Mechanical;
		}

		// Token: 0x04003B07 RID: 15111
		public static readonly d46.a a = new d46.a();

		// Token: 0x04003B08 RID: 15112
		public static Predicate<du2> b;
	}
}
