using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BCA RID: 7114
[dgg("psionicHeadband")]
public sealed class b8h : cwp, bd3
{
	// Token: 0x06009ABD RID: 39613 RVA: 0x003C4380 File Offset: 0x003C2580
	public override string bt()
	{
		return "茖Псионический обруч";
	}

	// Token: 0x06009ABE RID: 39614 RVA: 0x003C4388 File Offset: 0x003C2588
	public override string bu()
	{
		return "psionicHeadband";
	}

	// Token: 0x06009ABF RID: 39615 RVA: 0x003C4390 File Offset: 0x003C2590
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009AC0 RID: 39616 RVA: 0x003C4394 File Offset: 0x003C2594
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009AC1 RID: 39617 RVA: 0x003C4398 File Offset: 0x003C2598
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Armor;
	}

	// Token: 0x06009AC2 RID: 39618 RVA: 0x003C43A0 File Offset: 0x003C25A0
	public b8h()
	{
		base.Slots.Add(b8h.d, new cgo(new c6s(ms.a6, 60), "Рама псионического обруча", false, 1, 0.1f, false, false, null));
		base.Slots.Add(b8h.e, new cgo(new c6s(ms.a7, 61), "Псионический модулятор", false, 1, 0.1f, false, false, null));
		base.Slots.Add(b8h.f, new cgo(new c6s(new ms[]
		{
			ms.a8,
			ms.ba,
			ms.a9,
			ms.bp
		}, 15), "Псионическое улучшение", true, 1, 0f, false, false, null));
		base.Slots.Add(b8h.g, new cgo(new c6s(new ms[]
		{
			ms.a8,
			ms.ba,
			ms.a9,
			ms.bp
		}, 15), "Псионическое улучшение", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009AC3 RID: 39619 RVA: 0x003C4498 File Offset: 0x003C2698
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(b8h.d, null);
		fv fv2 = A_1.SafeGet(b8h.e, null);
		if (fv2 != null && fv != null)
		{
			a1k a1k = fv.TypedDefinition;
			a1k a1k2 = fv2.TypedDefinition;
			if (a1k2 != null && a1k != null)
			{
				fv fv3 = A_1.SafeGet(b8h.f, null);
				fv fv4 = A_1.SafeGet(b8h.g, null);
				if (fv3 == null || fv4 == null || fv3.TypedDefinition.i() != fv4.TypedDefinition.i())
				{
					double value = a1k2.a7().GetPrimitivePropertyValue<double>("BonusEfficiency", new double?((double)1)).Value;
					double num = cwp.a(fv2);
					bqu bqu = new bqu();
					bqu.g(false);
					bqu.a(ItemRepairCategory.Electronic);
					bqu.a(a1k2.bc());
					bqu.g((int)Math.Ceiling(num));
					bqu.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue)));
					bqu.h(fv.SingleItemWeight + fv2.SingleItemWeight);
					bqu.a(a0.@as);
					bqu.g("Псионический обруч");
					if (A_0 != null && A_0.Feats.Contains<cvu>())
					{
						bqu.ar().Add(new d72(cvu.a + A_0.GetSpecializationValue<e7g>(true) * e7g.a));
					}
					PsiSchool? primitivePropertyValue = a1k2.a7().GetPrimitivePropertyValue<PsiSchool>("PsiSchool", null);
					string[] a_;
					if (primitivePropertyValue == null)
					{
						a_ = new string[]
						{
							"Metathermics",
							"Psychokinesis",
							"Thought Control",
							"Temporal Manipulation"
						};
						bqu.f("PsionicHeadband.U");
					}
					else
					{
						PsiSchool? psiSchool = primitivePropertyValue;
						PsiSchool psiSchool2 = PsiSchool.Metathermics;
						if (psiSchool.GetValueOrDefault() == psiSchool2 & psiSchool != null)
						{
							a_ = new string[]
							{
								"Metathermics"
							};
							bqu.f("PsionicHeadband.M");
						}
						else if (primitivePropertyValue.GetValueOrDefault() == PsiSchool.Psychokinesis)
						{
							a_ = new string[]
							{
								"Psychokinesis"
							};
							bqu.f("PsionicHeadband.P");
						}
						else if (primitivePropertyValue.GetValueOrDefault() == PsiSchool.TemporalManipulation)
						{
							a_ = new string[]
							{
								"Temporal Manipulation"
							};
							bqu.f("PsionicHeadband.E");
						}
						else
						{
							a_ = new string[]
							{
								"Thought Control"
							};
							bqu.f("PsionicHeadband.T");
						}
					}
					double? primitivePropertyValue2 = a1k2.a7().GetPrimitivePropertyValue<double>("BaseSkillBonus", null);
					double? primitivePropertyValue3 = a1k2.a7().GetPrimitivePropertyValue<double>("SkillBonusPerQuality", null);
					int num2 = (int)(((primitivePropertyValue2 != null) ? primitivePropertyValue2.Value : 0.0) + ((primitivePropertyValue3 != null) ? primitivePropertyValue3.Value : 0.0) * (double)Math.Max(1, fv2.QualityLevel));
					if (num2 != 0)
					{
						bqu.ar().Add(new bdz(a_, num2, (primitivePropertyValue == null) ? "Пси-навыки" : null));
					}
					SortedList<string, fv> sortedList = new SortedList<string, fv>();
					foreach (fv fv5 in new fv[]
					{
						fv3,
						fv4
					})
					{
						if (fv5 != null && fv5.TypedDefinition != null)
						{
							string classPropertyValue = fv5.TypedDefinition.a7().GetClassPropertyValue<string>("EnhancementCode");
							if (!string.IsNullOrEmpty(classPropertyValue))
							{
								sortedList.Add(classPropertyValue, fv5);
							}
						}
					}
					List<d3e> list = new List<d3e>();
					List<d3e> list2 = new List<d3e>();
					string text = null;
					bqu.g("");
					string text2 = "";
					foreach (KeyValuePair<string, fv> keyValuePair in sortedList)
					{
						bqu bqu2 = bqu;
						bqu2.f(bqu2.a3() + "." + keyValuePair.Key);
						string classPropertyValue2 = keyValuePair.Value.TypedDefinition.a7().GetClassPropertyValue<string>("PsionicHeadbandNameSub");
						if (!string.IsNullOrEmpty(classPropertyValue2))
						{
							text = classPropertyValue2;
						}
						string classPropertyValue3 = keyValuePair.Value.TypedDefinition.a7().GetClassPropertyValue<string>("PsionicHeadbandPrefix");
						if (!string.IsNullOrEmpty(classPropertyValue3))
						{
							bqu bqu3 = bqu;
							bqu3.g(bqu3.az() + classPropertyValue3 + " ");
						}
						this.a(bqu, primitivePropertyValue, keyValuePair.Value, list, list2, ref text2, value);
					}
					bqu.i(qv.a("Items\\Armors/PsionicHeadband", new object[]
					{
						(primitivePropertyValue != null) ? primitivePropertyValue.Value.ToString().a().ToLowerInvariant() : "универсальный псионический",
						(text != null) ? text.ToLowerInvariant() : "обруч",
						text2
					}));
					foreach (d3e item in list)
					{
						bqu.ar().Add(item);
					}
					foreach (d3e item2 in list2)
					{
						bqu.ar().Add(item2);
					}
					bqu bqu4 = bqu;
					bqu4.g(bqu4.az() + ((primitivePropertyValue != null) ? primitivePropertyValue.Value.ToString().a() : "Уни-пси") + " " + ((text != null) ? text : "обруч"));
					bqu bqu5 = bqu;
					bqu5.b(bqu5.bf() * (double)2);
					return new k7(new IndependentItemDefinitionProvider<bqu>(bqu));
				}
				A_2 = "Нельзя использовать два улучшения того же типа.";
			}
		}
		return null;
	}

	// Token: 0x06009AC4 RID: 39620 RVA: 0x003C4B30 File Offset: 0x003C2D30
	private void a(bqu A_0, PsiSchool? A_1, fv A_2, List<d3e> A_3, List<d3e> A_4, ref string A_5, double A_6)
	{
		b8h.a a = new b8h.a();
		a.a = A_1;
		object[] args = new object[0];
		double value = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BaseCritChanceBonus", new double?(0.0)).Value;
		double value2 = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<double>("CritChanceBonusPerQuality", new double?(0.0)).Value;
		double num = value + value2 * (double)A_2.QualityLevel;
		if (num > 0.0)
		{
			num *= A_6;
		}
		if (num != 0.0)
		{
			List<d3e> list;
			if (num > 0.0)
			{
				list = A_3;
			}
			else
			{
				list = A_4;
			}
			bi0 bi = Enumerable.FirstOrDefault<bi0>(Enumerable.Where<bi0>(Enumerable.OfType<bi0>(list), new Func<bi0, bool>(a.a)));
			if (bi == null)
			{
				bi = new bi0(a.a, (float)num);
				list.Add(bi);
			}
			else
			{
				bi0 bi2 = bi;
				bi2.a(bi2.c() + (float)num);
			}
		}
		double value3 = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BaseCritModifierBonus", new double?(0.0)).Value;
		double value4 = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<double>("CritModifierBonusPerQuality", new double?(0.0)).Value;
		double num2 = value3 + value4 * (double)A_2.QualityLevel;
		if (num2 > 0.0)
		{
			num2 *= A_6;
		}
		if (num2 != 0.0)
		{
			List<d3e> list2;
			if (num2 > 0.0)
			{
				list2 = A_3;
			}
			else
			{
				list2 = A_4;
			}
			db db = Enumerable.FirstOrDefault<db>(Enumerable.Where<db>(Enumerable.OfType<db>(list2), new Func<db, bool>(a.a)));
			if (db == null)
			{
				db = new db(a.a, (float)num2);
				list2.Add(db);
			}
			else
			{
				db db2 = db;
				db2.a(db2.c() + (float)num2);
			}
		}
		double value5 = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BasePsiCostModifier", new double?(0.0)).Value;
		double value6 = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<double>("PsiCostModifierPerQuality", new double?(0.0)).Value;
		double value7 = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<double>("MaxPsiCostModifier", new double?(double.MaxValue)).Value;
		double num3 = value5 + value6 * (double)A_2.QualityLevel;
		if (num3 < 0.0)
		{
			num3 *= A_6;
		}
		if (num3 != 0.0)
		{
			if (Math.Abs(num3) > Math.Abs(value7))
			{
				num3 = (double)Math.Sign(num3) * Math.Abs(value7);
			}
			List<d3e> list3;
			if (num3 < 0.0)
			{
				list3 = A_3;
			}
			else
			{
				list3 = A_4;
			}
			ato ato = Enumerable.FirstOrDefault<ato>(Enumerable.Where<ato>(Enumerable.OfType<ato>(list3), new Func<ato, bool>(a.a)));
			if (ato == null)
			{
				ato = new ato(a.a, (float)num3);
				list3.Add(ato);
			}
			else
			{
				ato ato2 = ato;
				ato2.a(ato2.c() + (float)num2);
			}
		}
		double value8 = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<double>("DodgeModifier", new double?(0.0)).Value;
		if (value8 != 0.0)
		{
			List<d3e> list4;
			if (value8 > 0.0)
			{
				list4 = A_3;
			}
			else
			{
				list4 = A_4;
			}
			d19 d = Enumerable.FirstOrDefault<d19>(Enumerable.OfType<d19>(list4));
			if (d == null)
			{
				d = new d19((float)value8);
				list4.Add(d);
			}
			else
			{
				d.a((float)d05.b(-1.0, (double)(d.c() + (float)value8), double.MaxValue));
			}
		}
		string classPropertyValue = A_2.TypedDefinition.a7().GetClassPropertyValue<string>("CapabilityDamageModified");
		if (classPropertyValue != null)
		{
			c3n c3n = dgk.a(classPropertyValue);
			if (c3n != null)
			{
				args = new object[]
				{
					c3n.Name
				};
				double a_ = 0.1 + (double)A_2.QualityLevel * 0.0025;
				A_3.Add(new c35(classPropertyValue, a_));
			}
		}
		int value9 = A_2.TypedDefinition.a7().GetPrimitivePropertyValue<int>("PsiSlotModifier", new int?(0)).Value;
		if (value9 != 0)
		{
			A_3.Add(new n8(value9));
		}
		string classPropertyValue2 = A_2.TypedDefinition.a7().GetClassPropertyValue<string>("PsionicHeadbandDesc");
		if (!string.IsNullOrEmpty(classPropertyValue2))
		{
			if (!string.IsNullOrEmpty(A_5))
			{
				A_5 += " ";
			}
			A_5 += string.Format(classPropertyValue2, args);
		}
		A_0.b(A_0.bf() + (double)A_2.SingleItemValue);
		A_0.h(A_0.a4() + A_2.SingleItemWeight);
		if (A_2.TypedDefinition.bc() > A_0.bc())
		{
			A_0.a(A_2.TypedDefinition.bc());
		}
	}

	// Token: 0x06009AC5 RID: 39621 RVA: 0x003C50C4 File Offset: 0x003C32C4
	public List<bj8> bz()
	{
		List<bj8> list = new List<bj8>();
		int num = 0;
		foreach (string text in new string[]
		{
			"U",
			"M",
			"P",
			"T",
			"E"
		})
		{
			bj8 bj = new bj8();
			bj.a(string.Format("PsionicHeadband.{0}", text));
			bj.a().Add(new d8h("Armors", new Point(num, 13), 1f));
			list.Add(bj);
			string[][] array2 = new string[][]
			{
				new string[]
				{
					"ProximalNeuroscopicFilter",
					"MagnifyingNeuroscopicFilterCryokinesis",
					"MagnifyingNeuroscopicFilterCryokineticOrb",
					"MagnifyingNeuroscopicFilterPyrokinesis",
					"MagnifyingNeuroscopicFilterPyrokineticStream",
					"MagnifyingNeuroscopicFilterElectrokinesis",
					"MagnifyingNeuroscopicFilterTelekineticPunch",
					"MagnifyingNeuroscopicFilterNeuralOverload",
					"MagnifyingNeuroscopicFilterTemporalDistorsion",
					"MagnifyingNeuroscopicFilterPlasmaBeam",
					"MagnifyingNeuroscopicFilterCryogenicBarrier"
				},
				new string[]
				{
					"StableNeuralAmplifier"
				},
				new string[]
				{
					"PsionicMufflers"
				},
				new string[]
				{
					"PsiCircuitExtension"
				}
			};
			for (int j = 0; j < 4; j++)
			{
				for (int k = j; k < 4; k++)
				{
					if (j != k)
					{
						for (int l = 0; l < array2[j].Length; l++)
						{
							for (int m = 0; m < array2[k].Length; m++)
							{
								bj = new bj8();
								bj.a(string.Format("PsionicHeadband.{0}.{1}{2}.{3}{4}", new object[]
								{
									text,
									j + 1,
									array2[j][l],
									k + 1,
									array2[k][m]
								}));
								bj.a().Add(new d8h("Armors", new Point(num, 13), 1f));
								this.a(bj, j + 1, array2[j][l]);
								this.a(bj, k + 1, array2[k][m]);
								list.Add(bj);
							}
						}
					}
					else
					{
						for (int n = 0; n < array2[j].Length; n++)
						{
							bj = new bj8();
							bj.a(string.Format("PsionicHeadband.{0}.{1}{2}", text, j + 1, array2[j][n]));
							bj.a().Add(new d8h("Armors", new Point(num, 13), 1f));
							this.a(bj, j + 1, array2[j][n]);
							list.Add(bj);
						}
					}
				}
			}
			num++;
		}
		return list;
	}

	// Token: 0x06009AC6 RID: 39622 RVA: 0x003C53E8 File Offset: 0x003C35E8
	private void a(bj8 A_0, int A_1, string A_2)
	{
		switch (A_1)
		{
		case 1:
			if (A_2 != null)
			{
				int length = A_2.Length;
				if (length != 25)
				{
					switch (length)
					{
					case 37:
						if (!(A_2 == "MagnifyingNeuroscopicFilterPlasmaBeam"))
						{
							return;
						}
						A_0.a().Add(new d8h("Armors", new Point(16, 13), 1f));
						return;
					case 38:
					{
						char c = A_2[27];
						if (c != 'C')
						{
							if (c != 'P')
							{
								return;
							}
							if (!(A_2 == "MagnifyingNeuroscopicFilterPyrokinesis"))
							{
								return;
							}
							goto IL_1D6;
						}
						else if (!(A_2 == "MagnifyingNeuroscopicFilterCryokinesis"))
						{
							return;
						}
						break;
					}
					case 39:
					case 40:
					case 42:
						return;
					case 41:
					{
						char c = A_2[27];
						if (c != 'C')
						{
							if (c != 'E')
							{
								if (c != 'N')
								{
									return;
								}
								if (!(A_2 == "MagnifyingNeuroscopicFilterNeuralOverload"))
								{
									return;
								}
								A_0.a().Add(new d8h("Armors", new Point(13, 13), 1f));
								return;
							}
							else
							{
								if (!(A_2 == "MagnifyingNeuroscopicFilterElectrokinesis"))
								{
									return;
								}
								A_0.a().Add(new d8h("Armors", new Point(11, 13), 1f));
								return;
							}
						}
						else if (!(A_2 == "MagnifyingNeuroscopicFilterCryokineticOrb"))
						{
							return;
						}
						break;
					}
					case 43:
					{
						char c = A_2[27];
						if (c != 'C')
						{
							if (c != 'T')
							{
								return;
							}
							if (!(A_2 == "MagnifyingNeuroscopicFilterTelekineticPunch"))
							{
								return;
							}
							A_0.a().Add(new d8h("Armors", new Point(12, 13), 1f));
							return;
						}
						else if (!(A_2 == "MagnifyingNeuroscopicFilterCryogenicBarrier"))
						{
							return;
						}
						break;
					}
					case 44:
						if (!(A_2 == "MagnifyingNeuroscopicFilterPyrokineticStream"))
						{
							return;
						}
						goto IL_1D6;
					case 45:
						if (!(A_2 == "MagnifyingNeuroscopicFilterTemporalDistorsion"))
						{
							return;
						}
						A_0.a().Add(new d8h("Armors", new Point(14, 13), 1f));
						return;
					default:
						return;
					}
					A_0.a().Add(new d8h("Armors", new Point(9, 13), 1f));
					return;
					IL_1D6:
					A_0.a().Add(new d8h("Armors", new Point(10, 13), 1f));
					return;
				}
				if (!(A_2 == "ProximalNeuroscopicFilter"))
				{
					return;
				}
				A_0.a().Add(new d8h("Armors", new Point(5, 13), 1f));
				A_0.a().Add(new d8h("Armors", new Point(6, 13), 0.55f));
				return;
			}
			break;
		case 2:
			if (A_2 == "StableNeuralAmplifier")
			{
				A_0.a().Add(new d8h("Armors", new Point(7, 13), 1f));
				return;
			}
			break;
		case 3:
			if (A_2 == "PsionicMufflers")
			{
				A_0.a().Add(new d8h("Armors", new Point(8, 13), 1f));
				return;
			}
			break;
		case 4:
			if (A_2 == "PsiCircuitExtension")
			{
				A_0.a().Insert(0, new d8h("Armors", new Point(15, 13), 1f));
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x04003B1C RID: 15132
	private new const int a = 0;

	// Token: 0x04003B1D RID: 15133
	private new const int b = 13;

	// Token: 0x04003B1E RID: 15134
	private const string c = "Armors";

	// Token: 0x04003B1F RID: 15135
	public new static readonly string d = "frame";

	// Token: 0x04003B20 RID: 15136
	public static readonly string e = "modulator";

	// Token: 0x04003B21 RID: 15137
	public static readonly string f = "enhancement1";

	// Token: 0x04003B22 RID: 15138
	public static readonly string g = "enhancement2";

	// Token: 0x02001BCB RID: 7115
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06009AC9 RID: 39625 RVA: 0x003C5778 File Offset: 0x003C3978
		internal bool a(bi0 A_0)
		{
			PsiSchool? psiSchool = A_0.PsiSchool;
			PsiSchool? psiSchool2 = this.a;
			return psiSchool.GetValueOrDefault() == psiSchool2.GetValueOrDefault() & psiSchool != null == (psiSchool2 != null);
		}

		// Token: 0x06009ACA RID: 39626 RVA: 0x003C57B4 File Offset: 0x003C39B4
		internal bool a(db A_0)
		{
			PsiSchool? psiSchool = A_0.PsiSchool;
			PsiSchool? psiSchool2 = this.a;
			return psiSchool.GetValueOrDefault() == psiSchool2.GetValueOrDefault() & psiSchool != null == (psiSchool2 != null);
		}

		// Token: 0x06009ACB RID: 39627 RVA: 0x003C57F0 File Offset: 0x003C39F0
		internal bool a(ato A_0)
		{
			PsiSchool? psiSchool = A_0.PsiSchool;
			PsiSchool? psiSchool2 = this.a;
			return psiSchool.GetValueOrDefault() == psiSchool2.GetValueOrDefault() & psiSchool != null == (psiSchool2 != null);
		}

		// Token: 0x04003B23 RID: 15139
		public PsiSchool? a;
	}
}
