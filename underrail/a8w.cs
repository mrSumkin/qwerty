using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000BA8 RID: 2984
[euj]
public sealed class a8w
{
	// Token: 0x060043E4 RID: 17380 RVA: 0x001AB9A8 File Offset: 0x001A9BA8
	[ayh("DUNLUPBLJCB")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				dgn dgn = new dgn();
				string classPropertyValue = bq.GetClassPropertyValue<string>("StatToBoost");
				int num = bq.GetPrimitivePropertyValue<int>("SideEffectValue", new int?(0)).Value;
				string classPropertyValue2 = bq.GetClassPropertyValue<string>("StateOfMatter");
				if (string.IsNullOrEmpty(classPropertyValue) && string.IsNullOrEmpty(classPropertyValue2))
				{
					return;
				}
				if (classPropertyValue2.Contains("solid"))
				{
					dgn.i("Эта таблетка");
				}
				else if (classPropertyValue2.Contains("liquid"))
				{
					dgn.i("Этот шприц");
				}
				else
				{
					dgn.i("Этот ингалятор");
				}
				dgn.f("StatBooster." + classPropertyValue);
				dgn dgn2 = dgn;
				dgn2.i(dgn2.a0() + " содержит мутагенное вещество, которое по информации, улучшает параметр " + classPropertyValue.ToLower() + ". Есть только один способ узнать, сработает ли это.");
				dgn.a2().Add(new aia(new d7d()));
				dgn.g(classPropertyValue + " усилитель");
				dgn.a(a0.x);
				dgn.b(new double?((double)5000));
				dgn.k("statBooster");
				dgn.h(0.2);
				dgn.a(ItemStealingCategory.Default);
				dgn.f(true);
				dgn.b(true);
				dgn.i(true);
				dgn.g(true);
				dgn.g(1);
				dgn.f(1);
				dgn.a(cr1.e);
				dgn.a7()[dii.f] = true;
				dgn.a7()["StatToBoost"] = classPropertyValue;
				dgn.a7()["StateOfMatter"] = classPropertyValue2;
				int num2 = serviceOrThrow.aqu().v().Skills.Get<ii>().g();
				if (num2 >= 50)
				{
					if (num < -3)
					{
						num++;
					}
					else
					{
						num += Math.Min(num2 / 50, 6);
					}
				}
				if (num != 0)
				{
					dgn.a7()["SideEffectValue"] = Math.Min(num, 5);
				}
				serviceOrThrow.aqu().v().Bag.z3(new d48(new IndependentItemDefinitionProvider<dgn>(dgn)), true);
				a7v.a(new bou(new d48(new IndependentItemDefinitionProvider<dgn>(dgn))));
			}
		}
	}

	// Token: 0x060043E5 RID: 17381 RVA: 0x001ABC34 File Offset: 0x001A9E34
	[ayh("DUNLUPBLJFromTempToReg")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				c5x c5x = new ar7(new Guid("ab9389e0-55ac-400b-981c-587b1b2ae648"), serviceOrThrow.aqu().v().b().Area).ao() as c5x;
				if (c5x != null)
				{
					e3l aspect = c5x.GetAspect<e3l>();
					if (aspect != null)
					{
						aspect.a.Clear();
					}
					string classPropertyValue = bq.GetClassPropertyValue<string>("StatToBoost");
					int value = bq.GetPrimitivePropertyValue<int>("SideEffectValue", new int?(0)).Value;
					string classPropertyValue2 = bq.GetClassPropertyValue<string>("StateOfMatter");
					c5x.b("SimulatedProcedure");
					c5x.b(classPropertyValue);
					c5x.b(value.ToString());
					c5x.b(classPropertyValue2);
				}
			}
		}
	}

	// Token: 0x060043E6 RID: 17382 RVA: 0x001ABD28 File Offset: 0x001A9F28
	[ayh("DUNLUPBLJFromRegToTemp")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				c5x c5x = new ar7(new Guid("ab9389e0-55ac-400b-981c-587b1b2ae648"), serviceOrThrow.aqu().v().b().Area).ao() as c5x;
				if (c5x != null)
				{
					e3l aspect = c5x.GetAspect<e3l>();
					if (aspect != null && aspect.a.Count > 0)
					{
						bq.set_Item("StatToBoost", aspect.a[1]);
						bq.set_Item("SideEffectValue", int.Parse(aspect.a[2]));
						bq.set_Item("StateOfMatter", aspect.a[3]);
					}
				}
			}
		}
	}

	// Token: 0x060043E7 RID: 17383 RVA: 0x001ABE14 File Offset: 0x001AA014
	[ayh("DUNLUPBLJDistillation")]
	public void g(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				int value = bq.GetPrimitivePropertyValue<int>("Temperature", new int?(0)).Value;
				int[] array = this.a(serviceOrThrow);
				if (value == 0)
				{
					return;
				}
				string value2;
				string value3;
				if (value >= 145)
				{
					value2 = "crystalline solid";
					int num = Math.Abs(array[0] - value);
					int num2 = Math.Abs(array[1] - value);
					if (num == 0 || num < num2)
					{
						value3 = BaseAbilityEnum.Strength.ToString();
					}
					else
					{
						value3 = BaseAbilityEnum.Constitution.ToString();
					}
				}
				else if (value >= 95)
				{
					value2 = "liquid";
					int num3 = Math.Abs(array[2] - value);
					int num4 = Math.Abs(array[3] - value);
					if (num3 == 0 || num3 < num4)
					{
						value3 = BaseAbilityEnum.Agility.ToString();
					}
					else
					{
						value3 = BaseAbilityEnum.Dexterity.ToString();
					}
				}
				else
				{
					value2 = "gas";
					int num5 = Math.Abs(array[4] - value);
					int num6 = Math.Abs(array[5] - value);
					int num7 = Math.Abs(array[6] - value);
					int num8 = Enumerable.Min(new int[]
					{
						num5,
						num6,
						num7
					});
					if (num8 == num5)
					{
						value3 = BaseAbilityEnum.Perception.ToString();
					}
					else if (num8 == num6)
					{
						value3 = BaseAbilityEnum.Intelligence.ToString();
					}
					else
					{
						value3 = BaseAbilityEnum.Will.ToString();
					}
				}
				bq.set_Item("StatToBoost", value3);
				bq.set_Item("StateOfMatter", value2);
				for (int i = 1; i <= 5; i++)
				{
					bq.set_Item("RedistillationOption" + i.ToString(), value + i);
				}
			}
		}
	}

	// Token: 0x060043E8 RID: 17384 RVA: 0x001AC048 File Offset: 0x001AA248
	[ayh("DUNLUPBLJCSE")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				string classPropertyValue = bq.GetClassPropertyValue<string>("ReductionMethod");
				string classPropertyValue2 = bq.GetClassPropertyValue<string>("StatToBoost");
				string classPropertyValue3 = bq.GetClassPropertyValue<string>("StateOfMatter");
				int value = bq.GetPrimitivePropertyValue<int>("PurificationStage1Value", new int?(0)).Value;
				int value2 = bq.GetPrimitivePropertyValue<int>("PurificationStage2Value", new int?(0)).Value;
				int num = bq.GetPrimitivePropertyValue<int>("SideEffectValue", new int?(0)).Value;
				int value3 = bq.GetPrimitivePropertyValue<int>("Temperature", new int?(0)).Value;
				int[] array = this.a(serviceOrThrow);
				int[] array2 = this.b(serviceOrThrow);
				if (string.IsNullOrEmpty(classPropertyValue) || string.IsNullOrEmpty(classPropertyValue3) || string.IsNullOrEmpty(classPropertyValue2))
				{
					return;
				}
				if (classPropertyValue2 != null)
				{
					switch (classPropertyValue2.Length)
					{
					case 4:
						if (classPropertyValue2 == "Will")
						{
							if (value < 10)
							{
								num -= 3;
							}
							if (value != array2[6])
							{
								num--;
							}
							if (value2 == 0)
							{
								num -= 2;
							}
							else if ((value + array2[0] + value2) % 15 == array2[6])
							{
								num += 2;
							}
							else
							{
								num -= Math.Min(5, Math.Abs(array2[6] - (value + array2[0] + value2) % 15));
							}
							num -= Math.Min(3, Math.Abs(array[6] - value3) / 5);
							goto IL_61F;
						}
						break;
					case 7:
						if (classPropertyValue2 == "Agility")
						{
							if (value < 6 && value > 10)
							{
								num -= 3;
							}
							if (value != array2[2])
							{
								num--;
							}
							if (value2 == 0)
							{
								num -= 2;
							}
							else if ((value + array2[3] + value2) % 15 == array2[2])
							{
								num += 2;
							}
							else
							{
								num -= Math.Min(5, Math.Abs(array2[2] - (value + array2[3] + value2) % 15));
							}
							num -= Math.Min(3, Math.Abs(array[2] - value3) / 5);
							goto IL_61F;
						}
						break;
					case 8:
						if (classPropertyValue2 == "Strength")
						{
							if (value > 5)
							{
								num -= 3;
							}
							if (value != array2[0])
							{
								num--;
							}
							if (value2 == 0)
							{
								num -= 2;
							}
							else if (value2 != 0 && (value + array2[6] + value2) % 15 == array2[0])
							{
								num += 2;
							}
							else
							{
								num -= Math.Min(5, Math.Abs(array2[0] - (value + array2[6] + value2) % 15));
							}
							num -= Math.Min(3, Math.Abs(array[0] - value3) / 5);
							goto IL_61F;
						}
						break;
					case 9:
						if (classPropertyValue2 == "Dexterity")
						{
							if (value < 6 && value > 10)
							{
								num -= 3;
							}
							if (value != array2[3])
							{
								num--;
							}
							if (value2 == 0)
							{
								num -= 2;
							}
							else if ((value + array2[4] + value2) % 15 == array2[3])
							{
								num += 2;
							}
							else
							{
								num -= Math.Min(5, Math.Abs(array2[3] - (value + array2[4] + value2) % 15));
							}
							num -= Math.Min(3, Math.Abs(array[3] - value3) / 5);
							goto IL_61F;
						}
						break;
					case 10:
						if (classPropertyValue2 == "Perception")
						{
							if (value < 10)
							{
								num -= 3;
							}
							if (value != array2[4])
							{
								num--;
							}
							if (value2 == 0)
							{
								num -= 2;
							}
							else if ((value + array2[2] + value2) % 15 == array2[4])
							{
								num += 2;
							}
							else
							{
								num -= Math.Min(5, Math.Abs(array2[4] - (value + array2[2] + value2) % 15));
							}
							num -= Math.Min(3, Math.Abs(array[4] - value3) / 5);
							goto IL_61F;
						}
						break;
					case 12:
					{
						char c = classPropertyValue2[0];
						if (c != 'C')
						{
							if (c == 'I')
							{
								if (classPropertyValue2 == "Intelligence")
								{
									if (value < 10)
									{
										num -= 3;
									}
									if (value != array2[5])
									{
										num--;
									}
									if (value2 == 0)
									{
										num -= 2;
									}
									else if ((value + array2[1] + value2) % 15 == array2[5])
									{
										num += 2;
									}
									else
									{
										num -= Math.Min(5, Math.Abs(array2[5] - (value + array2[1] + value2) % 15));
									}
									num -= Math.Min(3, Math.Abs(array[5] - value3) / 5);
									goto IL_61F;
								}
							}
						}
						else if (classPropertyValue2 == "Constitution")
						{
							if (value > 5)
							{
								num -= 3;
							}
							if (value != array2[1])
							{
								num--;
							}
							if (value2 == 0)
							{
								num -= 2;
							}
							else if ((value + array2[5] + value2) % 15 == array2[1])
							{
								num += 2;
							}
							else
							{
								num -= Math.Min(5, Math.Abs(array2[1] - (value + array2[5] + value2) % 15));
							}
							num -= Math.Min(3, Math.Abs(array[1] - value3) / 5);
							goto IL_61F;
						}
						break;
					}
					}
				}
				num -= 4;
				IL_61F:
				if (string.Equals(classPropertyValue, "stirring"))
				{
					if (!(classPropertyValue3 == "gas"))
					{
						if (!(classPropertyValue3 == "liquid"))
						{
							if (classPropertyValue3 == "crystalline solid")
							{
								num--;
							}
						}
					}
					else
					{
						num--;
					}
				}
				else if (string.Equals(classPropertyValue, "dehydration"))
				{
					if (!(classPropertyValue3 == "gas"))
					{
						if (!(classPropertyValue3 == "liquid"))
						{
							if (!(classPropertyValue3 == "crystalline solid"))
							{
							}
						}
						else
						{
							num--;
						}
					}
					else
					{
						num--;
					}
				}
				else if (!(classPropertyValue3 == "gas"))
				{
					if (!(classPropertyValue3 == "liquid"))
					{
						if (classPropertyValue3 == "crystalline solid")
						{
							num--;
						}
					}
					else
					{
						num--;
					}
				}
				bq.set_Item("SideEffectValue", Math.Min(num, 0));
			}
		}
	}

	// Token: 0x060043E9 RID: 17385 RVA: 0x001AC794 File Offset: 0x001AA994
	[ayh("DUNLUPBLJPurificationProps")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		object obj;
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				int value = bq.GetPrimitivePropertyValue<int>("Temperature", new int?(0)).Value;
				int value2 = bq.GetPrimitivePropertyValue<int>("PurificationStage1Value", new int?(0)).Value;
				int value3 = bq.GetPrimitivePropertyValue<int>("PurificationStage2Value", new int?(0)).Value;
				string value4 = "none";
				string value5 = "none";
				switch (value2)
				{
				case 1:
					value4 = "Растворитель - 2mg MHMPA";
					break;
				case 2:
					value4 = "Растворитель - 2.5mg MHMPA";
					break;
				case 3:
					value4 = "Растворитель - 3mg MHMPA";
					break;
				case 4:
					value4 = "Растворитель - 3.5mg MHMPA";
					break;
				case 5:
					value4 = "Растворитель - 4mg MHMPA";
					break;
				case 6:
					value4 = "Фильтрация - стекловолокно, размер пор 0.22µm";
					break;
				case 7:
					value4 = "Фильтрация - стекловолокно, размер пор 0.45µm";
					break;
				case 8:
					value4 = "Фильтрация - стекловолокно, размер пор 0.66µm";
					break;
				case 9:
					value4 = "Фильтрация - стекловолокно, размер пор 0.8µm";
					break;
				case 10:
					value4 = "Фильтрация - стекловолокно, размер пор 0.94µm";
					break;
				case 11:
					value4 = "Хроматография - паковка оксида алюминия, размер частиц 10µm";
					break;
				case 12:
					value4 = "Chromatography - паковка оксида алюминия, размер частиц 12µm";
					break;
				case 13:
					value4 = "Chromatography - паковка оксида алюминия, размер частиц 14µm";
					break;
				case 14:
					value4 = "Chromatography - паковка оксида алюминия, размер частиц 16µm";
					break;
				case 15:
					value4 = "Chromatography - паковка оксида алюминия, размер частиц 18µm";
					break;
				}
				int num = value3;
				switch (num)
				{
				case 1:
					value5 = "Растворитель - 4mg CC-14";
					break;
				case 2:
					value5 = "Растворитель - 6mg CC-14";
					break;
				case 3:
					value5 = "Растворитель - 8mg CC-14";
					break;
				case 4:
					value5 = "Растворитель - 10mg CC-14";
					break;
				case 5:
					value5 = "Растворитель - 12mg CC-14";
					break;
				case 6:
					value5 = "Центрифугирование - 500 RPM";
					break;
				case 7:
					value5 = "Центрифугирование - 550 RPM";
					break;
				case 8:
					value5 = "Центрифугирование - 600 RPM";
					break;
				case 9:
					value5 = "Центрифугирование - 650 RPM";
					break;
				case 10:
					value5 = "Центрифугирование - 700 RPM";
					break;
				default:
					if (num > 10 && num <= 15)
					{
						value5 = "Повторная перегонка - " + (value + value3 % 5).ToString() + "°C";
					}
					break;
				}
				bq.set_Item("PurificationStage1DisplayText", value4);
				bq.set_Item("PurificationStage2DisplayText", value5);
			}
		}
	}

	// Token: 0x060043EA RID: 17386 RVA: 0x001ACA2C File Offset: 0x001AAC2C
	[ayh("DUNLUPBLJMIST")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				double a_ = 0.0002;
				int a_2 = 3600 + cuo.a.Next(0, 5) * 100;
				int a_3 = 9300 + cuo.a.Next(0, 5) * 100;
				int a_4 = 14200 + cuo.a.Next(0, 5) * 100;
				foreach (b0b b0b in d.ab4(new string[]
				{
					"mist1"
				}))
				{
					c5x c5x = (c5x)b0b;
					dtb dtb = new dtb();
					dtb dtb2 = dtb;
					dtb2.a(dtb2.kh() | m7.b);
					dtb.ad().Add(new bm3(a_2));
					ad6 ad = new ad6(c5x);
					ad.b((double)c5x.ae.GetValueOrDefault(1f));
					ad.c(0.0);
					ad.a(a_);
					ad6 item = ad;
					dtb.ad().Add(item);
					List<auv> list = dtb.ad();
					uk uk = new uk();
					uk.a(new Guid?(c5x.qe()));
					uk.a(bvl.e);
					list.Add(new a4s(uk, null, null, null));
					serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
				}
				foreach (b0b b0b2 in d.ab4(new string[]
				{
					"mist2"
				}))
				{
					c5x c5x2 = (c5x)b0b2;
					dtb dtb3 = new dtb();
					dtb dtb4 = dtb3;
					dtb4.a(dtb4.kh() | m7.b);
					dtb3.ad().Add(new bm3(a_3));
					ad6 ad2 = new ad6(c5x2);
					ad2.b((double)c5x2.ae.GetValueOrDefault(1f));
					ad2.c(0.0);
					ad2.a(a_);
					ad6 item2 = ad2;
					dtb3.ad().Add(item2);
					List<auv> list2 = dtb3.ad();
					uk uk2 = new uk();
					uk2.a(new Guid?(c5x2.qe()));
					uk2.a(bvl.e);
					list2.Add(new a4s(uk2, null, null, null));
					serviceOrThrow.aqw().ActionManager.g9(dtb3, atp.a);
				}
				foreach (b0b b0b3 in d.ab4(new string[]
				{
					"mist3"
				}))
				{
					c5x c5x3 = (c5x)b0b3;
					dtb dtb5 = new dtb();
					dtb dtb6 = dtb5;
					dtb6.a(dtb6.kh() | m7.b);
					dtb5.ad().Add(new bm3(a_4));
					ad6 ad3 = new ad6(c5x3);
					ad3.b((double)c5x3.ae.GetValueOrDefault(1f));
					ad3.c(0.0);
					ad3.a(a_);
					ad6 item3 = ad3;
					dtb5.ad().Add(item3);
					List<auv> list3 = dtb5.ad();
					uk uk3 = new uk();
					uk3.a(new Guid?(c5x3.qe()));
					uk3.a(bvl.e);
					list3.Add(new a4s(uk3, null, null, null));
					serviceOrThrow.aqw().ActionManager.g9(dtb5, atp.a);
				}
			}
		}
	}

	// Token: 0x060043EB RID: 17387 RVA: 0x001ACDD4 File Offset: 0x001AAFD4
	private int[] b(cnk A_0)
	{
		if (A_0.aqu() != null)
		{
			a8w.b b = new a8w.b();
			b.a = new Random(A_0.aqu().l());
			int[] array = new int[7];
			int[] array2 = Enumerable.ToArray<int>(Enumerable.OrderBy<int, int>(Enumerable.Range(1, 5), new Func<int, int>(b.a)));
			int[] array3 = Enumerable.ToArray<int>(Enumerable.OrderBy<int, int>(Enumerable.Range(6, 5), new Func<int, int>(b.c)));
			int[] array4 = Enumerable.ToArray<int>(Enumerable.OrderBy<int, int>(Enumerable.Range(10, 5), new Func<int, int>(b.b)));
			array[0] = array2[0];
			array[1] = array2[1];
			array[2] = array3[0];
			array[3] = array3[1];
			array[4] = array4[0];
			array[5] = array4[1];
			array[6] = array4[2];
			return array;
		}
		return new int[]
		{
			5,
			3,
			8,
			6,
			11,
			13,
			15
		};
	}

	// Token: 0x060043EC RID: 17388 RVA: 0x001ACEA8 File Offset: 0x001AB0A8
	private int[] a(cnk A_0)
	{
		if (A_0.aqu() != null)
		{
			a8w.c c = new a8w.c();
			c.a = new Random(A_0.aqu().l());
			int[] array = new int[7];
			int[] array2 = Enumerable.ToArray<int>(Enumerable.OrderBy<int, int>(Enumerable.Where<int>(Enumerable.Range(145, 45), new Func<int, bool>(a8w.a.a.c)), new Func<int, int>(c.c)));
			int[] array3 = Enumerable.ToArray<int>(Enumerable.OrderBy<int, int>(Enumerable.Where<int>(Enumerable.Range(95, 45), new Func<int, bool>(a8w.a.a.b)), new Func<int, int>(c.b)));
			int[] array4 = Enumerable.ToArray<int>(Enumerable.OrderBy<int, int>(Enumerable.Where<int>(Enumerable.Range(40, 50), new Func<int, bool>(a8w.a.a.a)), new Func<int, int>(c.a)));
			array[0] = array2[0];
			array[1] = array2[1];
			array[2] = array3[0];
			array[3] = array3[1];
			array[4] = array4[0];
			array[5] = array4[1];
			array[6] = array4[2];
			return array;
		}
		return new int[]
		{
			180,
			165,
			140,
			115,
			50,
			85,
			60
		};
	}

	// Token: 0x02000BA9 RID: 2985
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060043F0 RID: 17392 RVA: 0x001AD014 File Offset: 0x001AB214
		internal bool c(int A_0)
		{
			return A_0 % 5 == 0;
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x001AD01C File Offset: 0x001AB21C
		internal bool b(int A_0)
		{
			return A_0 % 5 == 0;
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x001AD024 File Offset: 0x001AB224
		internal bool a(int A_0)
		{
			return A_0 % 5 == 0;
		}

		// Token: 0x04001C46 RID: 7238
		public static readonly a8w.a a = new a8w.a();

		// Token: 0x04001C47 RID: 7239
		public static Func<int, bool> b;

		// Token: 0x04001C48 RID: 7240
		public static Func<int, bool> c;

		// Token: 0x04001C49 RID: 7241
		public static Func<int, bool> d;
	}

	// Token: 0x02000BAA RID: 2986
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x060043F4 RID: 17396 RVA: 0x001AD034 File Offset: 0x001AB234
		internal int a(int A_0)
		{
			return this.a.Next();
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x001AD044 File Offset: 0x001AB244
		internal int c(int A_0)
		{
			return this.a.Next();
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x001AD054 File Offset: 0x001AB254
		internal int b(int A_0)
		{
			return this.a.Next();
		}

		// Token: 0x04001C4A RID: 7242
		public Random a;
	}

	// Token: 0x02000BAB RID: 2987
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x060043F8 RID: 17400 RVA: 0x001AD06C File Offset: 0x001AB26C
		internal int c(int A_0)
		{
			return this.a.Next();
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x001AD07C File Offset: 0x001AB27C
		internal int b(int A_0)
		{
			return this.a.Next();
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x001AD08C File Offset: 0x001AB28C
		internal int a(int A_0)
		{
			return this.a.Next();
		}

		// Token: 0x04001C4B RID: 7243
		public Random a;
	}
}
