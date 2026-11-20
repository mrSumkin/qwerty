using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000A29 RID: 2601
[eiz("RNDEXPBLDCHEIH")]
[Serializable]
public sealed class bj3 : bdw, ISerializable
{
	// Token: 0x06003DC9 RID: 15817 RVA: 0x00173014 File Offset: 0x00171214
	private bj3(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DCA RID: 15818 RVA: 0x0017301C File Offset: 0x0017121C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DCB RID: 15819 RVA: 0x00173020 File Offset: 0x00171220
	public bj3()
	{
	}

	// Token: 0x06003DCC RID: 15820 RVA: 0x0017302C File Offset: 0x0017122C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			d60 d = A_0.a();
			if (d != null && A_1.r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus") == null)
			{
				A_1.r()["loc_xpbl_dun_cvw_hr_raceStatus"] = "initial";
				A_1.r()["loc_xpbl_dun_cvw_hr_aliveHoppers"] = 4;
				List<b0b> list = d.ab4(new string[]
				{
					"xpbl_dun_cvw_hr_hopper"
				});
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"raceData"
				})) as c5x;
				if (c5x != null)
				{
					a3f aspect = c5x.GetAspect<a3f>();
					if (aspect != null)
					{
						Dictionary<string, int> dictionary = aspect.a().GetClassPropertyValue<Dictionary<string, int>>("HopperRaceStats");
						Dictionary<string, Guid> dictionary2 = aspect.a().GetClassPropertyValue<Dictionary<string, Guid>>("HopperRaceContenders");
						if (dictionary == null && dictionary2 == null)
						{
							dictionary = new Dictionary<string, int>();
							dictionary2 = new Dictionary<string, Guid>();
						}
						int num = 0;
						foreach (b0b b0b in list)
						{
							c5x c5x2 = (c5x)b0b;
							if (c5x2.h.b != null)
							{
								c5x2.q(this.a(c5x2, ++num));
								c5x2.h.b.aa().Name = c5x2.y8();
								dictionary.Add(c5x2.y8(), 0);
								dictionary2.Add(c5x2.y8(), c5x2.qe());
								string a_;
								this.a(A_1, c5x2.y8(), num, aspect, out a_);
								this.a(c5x2, a_);
							}
						}
						aspect.a()["HopperRaceStats"] = dictionary;
						aspect.a()["HopperRaceContenders"] = dictionary2;
						this.a(A_1, A_0, aspect);
					}
				}
			}
		}
	}

	// Token: 0x06003DCD RID: 15821 RVA: 0x00173214 File Offset: 0x00171414
	private string a(c5x A_0, int A_1)
	{
		List<string> list = new List<string>();
		string result;
		switch (A_1)
		{
		case 1:
		{
			list.AddRange(new List<string>
			{
				"Пуля",
				"Мелок",
				"Монета",
				"Шквал",
				"Отрада",
				"Синий"
			});
			int index = cuo.a.Next(Enumerable.Count<string>(list));
			result = list[index];
			break;
		}
		case 2:
		{
			list.AddRange(new List<string>
			{
				"Вспышка",
				"ДлинноНогий",
				"Быстрый",
				"Зум",
				"Удача",
				"Шанс"
			});
			int index = cuo.a.Next(Enumerable.Count<string>(list));
			result = list[index];
			break;
		}
		case 3:
		{
			list.AddRange(new List<string>
			{
				"Кваки",
				"Скорый",
				"Салат",
				"Кама",
				"Магма",
				"Зола"
			});
			int index = cuo.a.Next(Enumerable.Count<string>(list));
			result = list[index];
			break;
		}
		case 4:
		{
			list.AddRange(new List<string>
			{
				"Макс",
				"Крошка",
				"Скоростной",
				"Фанат",
				"Рогатка",
				"Попрыгунчик"
			});
			int index = cuo.a.Next(Enumerable.Count<string>(list));
			result = list[index];
			break;
		}
		default:
		{
			list.AddRange(new List<string>
			{
				"Ножик",
				"Джек",
				"Пещеран",
				"Вой",
				"Бегунец",
				"Легавый"
			});
			int index = cuo.a.Next(Enumerable.Count<string>(list));
			result = list[index];
			break;
		}
		}
		return result;
	}

	// Token: 0x06003DCE RID: 15822 RVA: 0x00173460 File Offset: 0x00171660
	private void a(c5x A_0, string A_1)
	{
		a3f a3f = A_0.GetAspect<a3f>();
		if (a3f == null)
		{
			a3f = new a3f(A_0);
			A_0.SetAspect<a3f>(a3f);
		}
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (!(A_1 == "Грибная бухта"))
			{
				if (!(A_1 == "Кольцо Кор"))
				{
					if (!(A_1 == "Пещеры нижней подземки"))
					{
						if (!(A_1 == "Север подземки"))
						{
							aspect.al = (float)cuo.a.Next(7, 13) * 0.1f;
							aspect.am = aspect.al;
							aspect.ao = new Color?(new Color(cuo.a.Next(155, 255), cuo.a.Next(155, 255), cuo.a.Next(155, 255), 255));
						}
						else
						{
							aspect.al = (float)cuo.a.Next(9, 11) * 0.1f;
							aspect.am = aspect.al;
							aspect.ao = new Color?(new Color(255, 175, 175, 255));
						}
					}
					else
					{
						aspect.al = (float)cuo.a.Next(5, 8) * 0.1f;
						aspect.am = aspect.al;
						aspect.ao = new Color?(new Color(255, 255, 255, 255));
					}
				}
				else
				{
					aspect.al = (float)cuo.a.Next(8, 12) * 0.1f;
					aspect.am = aspect.al;
					aspect.ao = new Color?(new Color(200, 255, 200, 255));
				}
			}
			else
			{
				aspect.al = (float)cuo.a.Next(5, 9) * 0.1f;
				aspect.am = aspect.al;
			}
		}
		List<string> list = new List<string>();
		int num = 0;
		switch (cuo.a.Next(0, 3))
		{
		case 0:
			list.Add("GoodGuts");
			num = 3;
			break;
		case 1:
			list.Add("NeutralGuts");
			num = 2;
			break;
		case 2:
			list.Add("BadGuts");
			num = 1;
			break;
		}
		a3f.a()["GutsCapacity"] = num;
		switch (cuo.a.Next(0, 3))
		{
		case 0:
			list.Add("GoodMind");
			num = 3 + ((a3f.a().GetPrimitivePropertyValue<int>("GutsCapacity", new int?(0)).GetValueOrDefault() == 2) ? 1 : 0);
			break;
		case 1:
			list.Add("NeutralMind");
			num = 2 + ((a3f.a().GetPrimitivePropertyValue<int>("GutsCapacity", new int?(0)).GetValueOrDefault() == 2) ? 1 : 0);
			break;
		case 2:
			list.Add("BadMind");
			num = ((true + (a3f.a().GetPrimitivePropertyValue<int>("GutsCapacity", new int?(0)).GetValueOrDefault() == 2)) ? 1 : 0);
			break;
		}
		a3f.a()["MindCapacity"] = num;
		switch (cuo.a.Next(0, 3))
		{
		case 0:
			list.Add("GoodHeart");
			num = 3 + ((a3f.a().GetPrimitivePropertyValue<int>("GutsCapacity", new int?(0)).GetValueOrDefault() == 2) ? 1 : 0);
			break;
		case 1:
			list.Add("NeutralHeart");
			num = 2 + ((a3f.a().GetPrimitivePropertyValue<int>("GutsCapacity", new int?(0)).GetValueOrDefault() == 2) ? 1 : 0);
			break;
		case 2:
			list.Add("BadHeart");
			num = ((a3f.a().GetPrimitivePropertyValue<int>("GutsCapacity", new int?(0)).GetValueOrDefault() == 2) ? 1 : 0);
			break;
		}
		a3f.a()["HeartCapacity"] = num;
		a3f.a()["Characteristics"] = list;
		this.a(A_0);
	}

	// Token: 0x06003DCF RID: 15823 RVA: 0x001738A0 File Offset: 0x00171AA0
	private void a(c5x A_0)
	{
		a3f aspect = A_0.GetAspect<a3f>();
		if (aspect != null)
		{
			List<string> classPropertyValue = aspect.a().GetClassPropertyValue<List<string>>("Characteristics");
			string a = classPropertyValue[1];
			if (!(a == "GoodMind"))
			{
				if (!(a == "NeutralMind"))
				{
					if (!(a == "BadMind"))
					{
						aspect.a()["NegativeTriggerModifier"] = 65;
						aspect.a()["StunModifier"] = 85;
					}
					else
					{
						aspect.a()["NegativeTriggerModifier"] = 70;
						aspect.a()["StunModifier"] = 85;
					}
				}
				else
				{
					aspect.a()["NegativeTriggerModifier"] = 78;
					aspect.a()["StunModifier"] = 90;
				}
			}
			else
			{
				aspect.a()["NegativeTriggerModifier"] = 90;
				aspect.a()["StunModifier"] = 95;
			}
			a = classPropertyValue[2];
			if (!(a == "GoodHeart"))
			{
				if (!(a == "NeutralHeart"))
				{
					if (!(a == "BadHeart"))
					{
						dqg dqg = A_0.h.b.aa().BaseAbilities.Get<dqg>();
						dqg.a(dqg.f() - 2);
						aspect.a()["SpeedModifier"] = -3;
						aspect.a()["HealChanceModifier"] = 77;
					}
					else
					{
						dqg dqg2 = A_0.h.b.aa().BaseAbilities.Get<dqg>();
						dqg2.a(dqg2.f() - 2);
						aspect.a()["SpeedModifier"] = -3;
						aspect.a()["HealChanceModifier"] = 77;
					}
				}
				else
				{
					aspect.a()["SpeedModifier"] = 5;
					aspect.a()["HealChanceModifier"] = 68;
				}
			}
			else
			{
				axa axa = A_0.h.b.aa().BaseAbilities.Get<axa>();
				axa.a(axa.f() + 1);
				aspect.a()["SpeedModifier"] = 7;
				aspect.a()["HealChanceModifier"] = 57;
			}
			a = classPropertyValue[0];
			if (!(a == "GoodGuts"))
			{
				if (!(a == "NeutralGuts"))
				{
					if (!(a == "BadGuts"))
					{
						axa axa2 = A_0.h.b.aa().BaseAbilities.Get<axa>();
						axa2.a(axa2.f() - 1);
						aspect.a()["DamageResistModifier"] = -3;
						aspect.a()["HealValueModifier"] = -3;
						aspect.a()["DamageChanceModifier"] = 70;
					}
					else
					{
						axa axa3 = A_0.h.b.aa().BaseAbilities.Get<axa>();
						axa3.a(axa3.f() - 1);
						aspect.a()["DamageResistModifier"] = -3;
						aspect.a()["HealValueModifier"] = -3;
						aspect.a()["DamageChanceModifier"] = 70;
					}
				}
				else
				{
					aspect.a()["DamageResistModifier"] = 3;
					aspect.a()["HealValueModifier"] = 5;
					aspect.a()["DamageChanceModifier"] = 80;
				}
			}
			else
			{
				axa axa4 = A_0.h.b.aa().BaseAbilities.Get<axa>();
				axa4.a(axa4.f() + 2);
				aspect.a()["DamageResistModifier"] = 6;
				aspect.a()["HealValueModifier"] = 10;
				aspect.a()["DamageChanceModifier"] = 87;
			}
			aspect.a()["JuiceTeleportChance"] = 0;
			aspect.a()["LapStatus"] = "endinglap";
		}
	}

	// Token: 0x06003DD0 RID: 15824 RVA: 0x00173D44 File Offset: 0x00171F44
	private void a(cyt A_0, string A_1, int A_2, a3f A_3, out string A_4)
	{
		List<string> list = new List<string>
		{
			"Грибная бухта",
			"Грибная бухта",
			"Грибная бухта",
			"Кольцо Кор",
			"Кольцо Кор",
			"Кольцо Кор",
			"Кольцо Кор",
			"Пещеры нижней подземки",
			"Пещеры нижней подземки",
			"Пещеры нижней подземки",
			"Река Исаака",
			"Река Исаака",
			"Река Исаака",
			"Свалка",
			"Неизвестно",
			"Север подземки"
		};
		string text = list[cuo.a.Next(0, list.Count)];
		List<string> list2 = new List<string>();
		list2.Add("Пещерник: " + A_1);
		list2.Add("Происхождение: " + text);
		list2.Add(string.Concat(new string[]
		{
			"История гонок: 1 место - ",
			cuo.a.Next(0, 4).ToString(),
			"; 2 место - ",
			cuo.a.Next(0, 5).ToString(),
			"; 3 место - ",
			cuo.a.Next(0, 6).ToString()
		}));
		A_0.r()["interfacing_xpbl_hopperRacing_hopper" + A_2.ToString() + "info"] = string.Join(Environment.NewLine + "        ", list2);
		List<string> list3 = new List<string>();
		float value = 1f + (float)cuo.a.Next(70, 201) / 100f;
		float value2 = 1f + (float)cuo.a.Next(60, 181) / 100f;
		float value3 = 1f + (float)cuo.a.Next(50, 161) / 100f;
		float value4 = 1f + (float)cuo.a.Next(20, 60) / 100f;
		list3.Add(string.Concat(new string[]
		{
			A_1,
			" шансы: ",
			value.ToString(),
			" - ",
			value2.ToString(),
			" - ",
			value3.ToString(),
			" - ",
			value4.ToString()
		}));
		A_0.r()["interfacing_xpbl_hopperRacing_hopper" + A_2.ToString() + "quotas"] = string.Join(Environment.NewLine + "        ", list3);
		Dictionary<string, float> dictionary = new Dictionary<string, float>();
		dictionary.Add("на носу", value);
		dictionary.Add("на хвосте", value2);
		dictionary.Add("еле-еле душа в теле", value3);
		dictionary.Add("или или", value4);
		A_3.a()["RacingQuotasFor" + A_1] = dictionary;
		A_4 = text;
	}

	// Token: 0x06003DD1 RID: 15825 RVA: 0x00174064 File Offset: 0x00172264
	private void a(cyt A_0, c1a A_1, a3f A_2)
	{
		d60 d = A_1.a();
		if (d != null)
		{
			List<b0b> list = d.ab4(new string[]
			{
				"wageringTicketOwner"
			});
			int num = 1;
			foreach (b0b b0b in list)
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.h.b != null)
				{
					d48 d2 = new d48(new LibraryItemDefinitionProvider<dj3>("Plot\\Xpbl\\HopperRacingBettingTicketBase"));
					if (d2 != null)
					{
						string text = null;
						Guid? guid = null;
						float num2 = 2f;
						int num3 = cuo.a.Next(1, 6) * 50;
						string text2;
						switch (cuo.a.Next(0, 4))
						{
						case 0:
							text2 = "на носу";
							break;
						case 1:
							text2 = "на хвосте";
							break;
						case 2:
							text2 = "еле-еле душа в теле";
							break;
						default:
							text2 = "или или";
							break;
						}
						Dictionary<string, Guid> classPropertyValue = A_2.a().GetClassPropertyValue<Dictionary<string, Guid>>("HopperRaceContenders");
						if (classPropertyValue != null)
						{
							text = Enumerable.ElementAt<KeyValuePair<string, Guid>>(classPropertyValue, cuo.a.Next(0, classPropertyValue.Count)).Key;
							guid = new Guid?(classPropertyValue[text]);
						}
						Dictionary<string, float> classPropertyValue2 = A_2.a().GetClassPropertyValue<Dictionary<string, float>>("RacingQuotasFor" + text);
						if (classPropertyValue2 != null)
						{
							num2 = classPropertyValue2[text2];
						}
						dj3 dj = new dj3();
						dj.a7()["BetType"] = text2;
						dj.a7()["HopperId"] = guid;
						dj.a7()["Quota"] = num2;
						dj.a7()["BetAmount"] = num3;
						dj.g(d2.Definition.az());
						dj.f(d2.Definition.a3());
						dj.a(d2.Definition.bi());
						dj.k("plot.xpbl_hopperRacing_ticket" + num.ToString());
						dj.i(string.Concat(new string[]
						{
							d2.Definition.a0(),
							"<br><br>Пещерник - ",
							text,
							"<br>Тип - ",
							text2,
							"<br>Шансы - ",
							num2.ToString(),
							"<br>Ставка - ",
							num3.ToString(),
							" харонов"
						}));
						c5x.h.b.aa().Bag.z3(new d48(new IndependentItemDefinitionProvider<dj3>(dj)), true);
						c5x c5x2 = new ar7(new Guid("044ef863-0786-4349-bed1-1a2882bcf17e"), c5x.Area).ao() as c5x;
						if (c5x2 != null && c5x2.s.b is c7j)
						{
							c7j c7j = c5x2.GetAspect<bim>() as c7j;
							if (c7j != null)
							{
								c7j.ItemContainer.z3(new d48(ez2.CreateDefinitonProvider<a54>("currency\\StygianCoin"))
								{
									Stacks = num3
								}, true);
							}
						}
						num++;
					}
				}
			}
		}
	}
}
