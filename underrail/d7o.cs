using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.AI.Behaviors.Custom.Xphw;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200044E RID: 1102
public class d7o
{
	// Token: 0x06001CC7 RID: 7367 RVA: 0x0009E1EC File Offset: 0x0009C3EC
	public static void a(azm A_0, ad7 A_1, c5x A_2)
	{
		ax8 ax = Enumerable.FirstOrDefault<ax8>(Enumerable.Where<ax8>(A_0.a(), new Func<ax8, bool>(d7o.b.a.b)));
		ax8 ax2 = Enumerable.FirstOrDefault<ax8>(Enumerable.Where<ax8>(A_0.a(), new Func<ax8, bool>(d7o.b.a.a)));
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && ax != null && ax2 != null && A_1 != null)
		{
			A_1.f()["English"] = "Стреляй.";
			A_1.PossibleAnswers.Clear();
			List<coh> list = new List<coh>();
			List<coh> list2 = new List<coh>();
			List<coh> list3 = new List<coh>();
			List<coh> list4 = new List<coh>();
			List<coh> list5 = new List<coh>();
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			coh coh = null;
			coh coh2 = null;
			List<coh> list6 = new List<coh>();
			List<coh> list7 = new List<coh>();
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			bool flag9 = false;
			atr atr = new atr();
			atr.f()["English"] = "Если подумать, то, возможно, тебя заинтересует что-то другое.";
			atr.PossibleNextSteps.Add(A_1);
			atr atr2 = new atr();
			atr2.f()["English"] = "Если подумать, то оставь это. У меня есть кое-что другое на примете.";
			atr2.PossibleNextSteps.Add(A_1);
			atr atr3 = new atr();
			atr3.f()["English"] = "Это ещё не всё...";
			Collection<esc> collection = atr3.e();
			b6e b6e = new b6e();
			cxz cxz = new cxz();
			cxz.a("XPHWGJGDDT");
			b6e.a(cxz);
			collection.Add(b6e);
			atr3.PossibleNextSteps.Add(A_1);
			atr atr4 = new atr();
			atr4.f()["English"] = "Не бери в голову. Я хочу обсудить кое-что, не имеющее отношения к твоей экипировке.";
			atr4.PossibleNextSteps.Add(d7o.a(A_0));
			atr atr5 = new atr();
			atr5.f()["English"] = "Я хочу обсудить кое-что, не имеющее отношения к твоей экипировке.";
			atr5.PossibleNextSteps.Add(d7o.a(A_0));
			atr atr6 = new atr();
			atr6.f()["English"] = "На этом пока всё.";
			foreach (coh coh3 in serviceOrThrow.aqu().v().Bag.z2())
			{
				if (coh3 is cd1)
				{
					cd1 cd = coh3 as cd1;
					if (cd.TypedDefinition.ae() != null && euf.a(cd.TypedDefinition.ae().Value, WeaponAggregateSubtype.EnergyPistol))
					{
						flag2 = true;
						list2.Add(coh3);
					}
				}
				else if (coh3 is cgd)
				{
					flag = true;
					list.Add(coh3);
				}
				else if (coh3.Definition is dxw)
				{
					flag4 = true;
					list4.Add(coh3);
				}
				else if (coh3.Definition is dgn && d7o.a(coh3.Definition as dgn))
				{
					flag3 = true;
					list3.Add(coh3);
				}
				else if (coh3.Definition is a3e && d7o.a(coh3.Definition as a3e))
				{
					flag5 = true;
					list5.Add(coh3);
				}
			}
			if (A_2.h.b != null)
			{
				if (A_2.h.b.aa().Gear.j()[WeaponKey.Secondary].Item != null)
				{
					flag7 = true;
					coh = A_2.h.b.aa().Gear.j()[WeaponKey.Secondary].Item;
				}
				if (A_2.h.b.aa().Gear.h().Item != null && A_2.h.b.aa().Gear.h().Item.Stealable)
				{
					flag6 = true;
					coh2 = A_2.h.b.aa().Gear.h().Item;
				}
				foreach (coh coh4 in Enumerable.Concat<coh>(A_2.h.b.aa().Bag.z2(), A_2.h.b.aa().Gear.i()))
				{
					if (coh4.Stealable)
					{
						if (coh4.Definition is dxw)
						{
							flag9 = true;
							list7.Add(coh4);
						}
						else if (coh4.Definition is dgn)
						{
							flag8 = true;
							list6.Add(coh4);
						}
					}
				}
			}
			if (flag2)
			{
				list2 = Enumerable.ToList<coh>(Enumerable.OrderBy<coh, string>(list2, new Func<coh, string>(d7o.b.a.d)));
				atr atr7 = new atr();
				atr7.f()["English"] = "У меня есть для тебя подходящее оружие...";
				A_1.PossibleAnswers.Add(atr7);
				ad7 ad = new ad7();
				ad.f()["English"] = "Посмотрим. Покажи мне.";
				ad.Questioner = ax2;
				ad.Answerer = ax;
				atr7.PossibleNextSteps.Add(ad);
				foreach (coh coh5 in list2)
				{
					cd1 cd2 = (cd1)coh5;
					atr atr8 = new atr();
					atr8.f()["English"] = cd2.TypedDefinition.az();
					atr8.a(cd2);
					ad.PossibleAnswers.Add(atr8);
					ad7 ad2 = new ad7();
					ad2.f()["English"] = "Давай стреляй...";
					ad2.Questioner = ax2;
					ad2.Answerer = ax;
					ad2 = d7o.a(ad2, cd2, A_2, 1, false, false);
					if (flag7)
					{
						ad2 = d7o.a(ad2, coh, A_2, 1, true, false);
					}
					atr8.PossibleNextSteps.Add(ad2);
					ad2.PossibleAnswers.Add(atr3);
					ad2.PossibleAnswers.Add(atr5);
					ad2.PossibleAnswers.Add(atr6);
				}
				ad.PossibleAnswers.Add(atr);
				ad.PossibleAnswers.Add(atr4);
			}
			if (flag)
			{
				list = Enumerable.ToList<coh>(Enumerable.OrderBy<coh, string>(list, new Func<coh, string>(d7o.b.a.c)));
				atr atr9 = new atr();
				atr9.f()["English"] = "Интересует новый энергетический щит?";
				A_1.PossibleAnswers.Add(atr9);
				ad7 ad3 = new ad7();
				ad3.f()["English"] = "Возможно.";
				ad3.Questioner = ax2;
				ad3.Answerer = ax;
				atr9.PossibleNextSteps.Add(ad3);
				foreach (coh coh6 in list)
				{
					cgd cgd = (cgd)coh6;
					atr atr10 = new atr();
					atr10.f()["English"] = cgd.TypedDefinition.az();
					atr10.a(cgd);
					ad3.PossibleAnswers.Add(atr10);
					ad7 ad4 = new ad7();
					ad4.f()["English"] = "Дай мне минутку надеть его.";
					ad4.Questioner = ax2;
					ad4.Answerer = ax;
					ad4 = d7o.a(ad4, cgd, A_2, 1, false, false);
					if (flag6)
					{
						ad4 = d7o.a(ad4, coh2, A_2, 1, true, false);
					}
					atr10.PossibleNextSteps.Add(ad4);
					ad4.PossibleAnswers.Add(atr3);
					ad4.PossibleAnswers.Add(atr5);
					ad4.PossibleAnswers.Add(atr6);
				}
				ad3.PossibleAnswers.Add(atr);
				ad3.PossibleAnswers.Add(atr4);
			}
			if (flag4)
			{
				list4 = Enumerable.ToList<coh>(Enumerable.OrderBy<coh, string>(list4, new Func<coh, string>(d7o.b.a.a)));
				list4 = Enumerable.ToList<coh>(Enumerable.Select<IGrouping<string, coh>, coh>(Enumerable.GroupBy<coh, string>(list4, new Func<coh, string>(d7o.b.a.b)), new Func<IGrouping<string, coh>, coh>(d7o.b.a.a)));
				atr atr11 = new atr();
				atr11.f()["English"] = "У меня есть для тебя гранаты.";
				A_1.PossibleAnswers.Add(atr11);
				ad7 ad5 = new ad7();
				ad5.f()["English"] = "Что у тебя есть?";
				ad5.Questioner = ax2;
				ad5.Answerer = ax;
				atr11.PossibleNextSteps.Add(ad5);
				foreach (coh coh7 in list4)
				{
					atr atr12 = new atr();
					atr12.f()["English"] = "::" + coh7.Definition.az() + ".::";
					atr12.a(coh7);
					ad5.PossibleAnswers.Add(atr12);
					ad7 ad6 = new ad7();
					ad6.f()["English"] = "Неплохо. Передай мне.";
					ad6.Questioner = ax2;
					ad6.Answerer = ax;
					atr12.PossibleNextSteps.Add(ad6);
					int num = d7o.a(coh7, serviceOrThrow.aqu().v());
					int num2 = 1;
					while (num2 <= num && num2 < 100)
					{
						if (num2 > 50)
						{
							if (num2 + 9 > num)
							{
								break;
							}
							num2 += 9;
						}
						if (num2 > 5)
						{
							if (num2 + 4 > num)
							{
								break;
							}
							num2 += 4;
						}
						atr atr13 = new atr();
						atr13.f()["English"] = string.Concat(new string[]
						{
							"::Дать ему ",
							num2.ToString(),
							" ",
							coh7.Definition.az(),
							(num2 == 1) ? ".::" : ".::"
						});
						ad6.PossibleAnswers.Add(atr13);
						if (coh7.SingleItemWeight * (double)num2 + A_2.h.b.aa().bc >= 0.9 * (double)A_2.h.b.aa().CarryCapacity)
						{
							ad7 ad7 = new ad7();
							ad7.f()["English"] = "Невозможно нести столько.";
							ad7.Questioner = ax2;
							ad7.Answerer = ax;
							atr13.PossibleNextSteps.Add(ad7);
							ad7.PossibleAnswers.Add(atr);
							ad7.PossibleAnswers.Add(atr4);
						}
						else
						{
							ad7 ad8 = new ad7();
							ad8.f()["English"] = "Хорош.";
							ad8.Questioner = ax2;
							ad8.Answerer = ax;
							ad8 = d7o.a(ad8, coh7, A_2, num2, false, false);
							atr13.PossibleNextSteps.Add(ad8);
							ad8.PossibleAnswers.Add(atr3);
							ad8.PossibleAnswers.Add(atr5);
							ad8.PossibleAnswers.Add(atr6);
						}
						num2++;
					}
					ad6.PossibleAnswers.Add(atr);
					ad6.PossibleAnswers.Add(atr4);
				}
				ad5.PossibleAnswers.Add(atr);
				ad5.PossibleAnswers.Add(atr4);
			}
			if (flag3)
			{
				list3 = Enumerable.ToList<coh>(Enumerable.OrderBy<coh, string>(list3, new Func<coh, string>(d7o.b.a.e)));
				atr atr14 = new atr();
				atr14.f()["English"] = "Нужны лекарства?";
				A_1.PossibleAnswers.Add(atr14);
				ad7 ad9 = new ad7();
				ad9.f()["English"] = "Всегда пригодится. Только без галлюциногенных веществ.";
				ad9.Questioner = ax2;
				ad9.Answerer = ax;
				atr14.PossibleNextSteps.Add(ad9);
				foreach (coh coh8 in list3)
				{
					atr atr15 = new atr();
					atr15.f()["English"] = "::" + coh8.Definition.az() + ".::";
					atr15.a(coh8);
					ad9.PossibleAnswers.Add(atr15);
					ad7 ad10 = new ad7();
					ad10.f()["English"] = "Неплохо. Передай мне.";
					ad10.Questioner = ax2;
					ad10.Answerer = ax;
					atr15.PossibleNextSteps.Add(ad10);
					int num3 = 1;
					while (num3 <= coh8.Stacks && num3 < 100)
					{
						if (num3 > 50)
						{
							if (num3 + 9 > coh8.Stacks)
							{
								break;
							}
							num3 += 9;
						}
						else if (num3 > 5)
						{
							if (num3 + 4 > coh8.Stacks)
							{
								break;
							}
							num3 += 4;
						}
						atr atr16 = new atr();
						atr16.f()["English"] = string.Concat(new string[]
						{
							"::Дать ему ",
							num3.ToString(),
							" ",
							coh8.Definition.az(),
							(num3 == 1) ? ".::" : ".::"
						});
						ad10.PossibleAnswers.Add(atr16);
						if (coh8.SingleItemWeight * (double)num3 + A_2.h.b.aa().bc >= 0.9 * (double)A_2.h.b.aa().CarryCapacity)
						{
							ad7 ad11 = new ad7();
							ad11.f()["English"] = "Невозможно нести столько.";
							ad11.Questioner = ax2;
							ad11.Answerer = ax;
							atr16.PossibleNextSteps.Add(ad11);
							ad11.PossibleAnswers.Add(atr);
							ad11.PossibleAnswers.Add(atr4);
						}
						else
						{
							ad7 ad12 = new ad7();
							ad12.f()["English"] = "Хорош.";
							ad12.Questioner = ax2;
							ad12.Answerer = ax;
							ad12 = d7o.a(ad12, coh8, A_2, num3, false, false);
							atr16.PossibleNextSteps.Add(ad12);
							ad12.PossibleAnswers.Add(atr3);
							ad12.PossibleAnswers.Add(atr5);
							ad12.PossibleAnswers.Add(atr6);
						}
						num3++;
					}
					ad10.PossibleAnswers.Add(atr);
					ad10.PossibleAnswers.Add(atr4);
				}
				ad9.PossibleAnswers.Add(atr);
				ad9.PossibleAnswers.Add(atr4);
			}
			if (flag5)
			{
				list5 = Enumerable.ToList<coh>(Enumerable.OrderBy<coh, string>(list5, new Func<coh, string>(d7o.b.a.f)));
				atr atr17 = new atr();
				atr17.f()["English"] = "Хочешь жрать?";
				A_1.PossibleAnswers.Add(atr17);
				ad7 ad13 = new ad7();
				ad13.f()["English"] = "Никто ж не откажется от хорошей еды.";
				ad13.Questioner = ax2;
				ad13.Answerer = ax;
				atr17.PossibleNextSteps.Add(ad13);
				foreach (coh coh9 in list5)
				{
					atr atr18 = new atr();
					atr18.f()["English"] = "::" + coh9.Definition.az() + ".::";
					atr18.a(coh9);
					ad13.PossibleAnswers.Add(atr18);
					ad7 ad14 = new ad7();
					ad14.f()["English"] = "Смотри, как это исчезнет.";
					ad14.Questioner = ax2;
					ad14.Answerer = ax;
					ad14 = d7o.a(ad14, coh9, A_2, 1, false, false);
					atr18.PossibleNextSteps.Add(ad14);
					ad14.PossibleAnswers.Add(atr);
					ad14.PossibleAnswers.Add(atr4);
				}
				ad13.PossibleAnswers.Add(atr);
				ad13.PossibleAnswers.Add(atr4);
			}
			if (flag7 || flag6 || flag8 || flag9)
			{
				int num4 = 0;
				List<coh> list8 = new List<coh>();
				atr atr19 = new atr();
				atr19.f()["English"] = "Мне нужно вернуть кое-что...";
				A_1.PossibleAnswers.Add(atr19);
				ad7 ad15 = new ad7();
				ad15.f()["English"] = "Что ты имеешь в виду?";
				ad15.Questioner = ax2;
				ad15.Answerer = ax;
				atr19.PossibleNextSteps.Add(ad15);
				if (flag7)
				{
					list8.Add(coh);
					num4++;
					string text = coh.Definition.az();
					if (!coh.IsLibraryItem)
					{
						text = text.ToLowerInvariant();
					}
					atr atr20 = new atr();
					atr20.f()["English"] = "Мне понадобится " + text + ", дай мне.";
					ad15.PossibleAnswers.Add(atr20);
					ad7 ad16 = new ad7();
					ad16.f()["English"] = "Конечно. Вот, держи.";
					ad16.Questioner = ax2;
					ad16.Answerer = ax;
					ad16 = d7o.a(ad16, coh, A_2, 1, true, true);
					atr20.PossibleNextSteps.Add(ad16);
					ad16.PossibleAnswers.Add(atr3);
					ad16.PossibleAnswers.Add(atr5);
					ad16.PossibleAnswers.Add(atr6);
				}
				if (flag6)
				{
					list8.Add(coh2);
					num4++;
					string text2 = coh2.Definition.az();
					if (!coh2.IsLibraryItem)
					{
						text2 = text2.ToLowerInvariant();
					}
					atr atr21 = new atr();
					atr21.f()["English"] = "Мне понадобится " + text2 + ", дай мне.";
					ad15.PossibleAnswers.Add(atr21);
					ad7 ad17 = new ad7();
					ad17.f()["English"] = "Конечно. Вот, держи.";
					ad17.Questioner = ax2;
					ad17.Answerer = ax;
					ad17 = d7o.a(ad17, coh2, A_2, 1, true, true);
					atr21.PossibleNextSteps.Add(ad17);
					ad17.PossibleAnswers.Add(atr3);
					ad17.PossibleAnswers.Add(atr5);
					ad17.PossibleAnswers.Add(atr6);
				}
				if (flag9)
				{
					list8.AddRange(list7);
					num4++;
					atr atr22 = new atr();
					atr22.f()["English"] = "Мне нужно отдать тебе все эти гранаты.";
					ad15.PossibleAnswers.Add(atr22);
					ad7 ad18 = new ad7();
					ad18.f()["English"] = "Конечно. Вот, держи.";
					ad18.Questioner = ax2;
					ad18.Answerer = ax;
					foreach (coh coh10 in list7)
					{
						ad18 = d7o.a(ad18, coh10, A_2, coh10.Stacks, true, true);
					}
					atr22.PossibleNextSteps.Add(ad18);
					ad18.PossibleAnswers.Add(atr3);
					ad18.PossibleAnswers.Add(atr5);
					ad18.PossibleAnswers.Add(atr6);
				}
				if (flag8)
				{
					list6.AddRange(list6);
					num4++;
					atr atr23 = new atr();
					atr23.f()["English"] = "Мне нужно отдать тебе все эти лекарства.";
					ad15.PossibleAnswers.Add(atr23);
					ad7 ad19 = new ad7();
					ad19.f()["English"] = "Конечно. Вот, держи.";
					ad19.Questioner = ax2;
					ad19.Answerer = ax;
					foreach (coh coh11 in list6)
					{
						ad19 = d7o.a(ad19, coh11, A_2, coh11.Stacks, true, false);
					}
					atr23.PossibleNextSteps.Add(ad19);
					ad19.PossibleAnswers.Add(atr3);
					ad19.PossibleAnswers.Add(atr5);
					ad19.PossibleAnswers.Add(atr6);
				}
				if (num4 >= 2)
				{
					atr atr24 = new atr();
					atr24.f()["English"] = "Всё.";
					ad15.PossibleAnswers.Add(atr24);
					ad7 ad20 = new ad7();
					ad20.f()["English"] = "Конечно. Вот, держи.";
					ad20.Questioner = ax2;
					ad20.Answerer = ax;
					foreach (coh coh12 in list8)
					{
						ad20 = d7o.a(ad20, coh12, A_2, coh12.Stacks, true, true);
					}
					atr24.PossibleNextSteps.Add(ad20);
					ad20.PossibleAnswers.Add(atr3);
					ad20.PossibleAnswers.Add(atr5);
					ad20.PossibleAnswers.Add(atr6);
				}
				ad15.PossibleAnswers.Add(atr2);
				ad15.PossibleAnswers.Add(atr4);
			}
		}
		atr atr25 = new atr();
		atr25.f()["English"] = "Не бери в голову. У меня нет ничего полезного.";
		atr25.PossibleNextSteps.Add(d7o.a(A_0));
		A_1.PossibleAnswers.Add(atr25);
	}

	// Token: 0x06001CC8 RID: 7368 RVA: 0x0009F9A8 File Offset: 0x0009DBA8
	public static void a(string A_0, bool A_1 = false)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return;
		}
		Xphw_GunslingerCommentCodeEnum a_;
		if (Enum.TryParse<Xphw_GunslingerCommentCodeEnum>(A_0, out a_))
		{
			d7o.a(a_, true, false);
		}
	}

	// Token: 0x06001CC9 RID: 7369 RVA: 0x0009F9D8 File Offset: 0x0009DBD8
	public static bool a(Xphw_GunslingerCommentCodeEnum A_0, bool A_1 = false, bool A_2 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_teamUp", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_died", new bool?(false)).Value)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(c29.a, c5x.Area).ao() as c5x;
				if (c5x2 != null && c5x2.h.b != null && c5x2.t.b != null)
				{
					List<Xphw_GunslingerCommentCodeEnum> classPropertyValue = c5x2.t.b.y6().GetClassPropertyValue<List<Xphw_GunslingerCommentCodeEnum>>(c29.l);
					if (classPropertyValue != null && classPropertyValue.Contains(A_0))
					{
						return false;
					}
					bool g = c5x2.h.b.aa().SpecialStates.g;
					bool a_ = c5x2.h.b.aa().IsInCombat;
					if (c5x2.h.b.aa().IsInControl)
					{
						blk blk = new bzv(c5x.t.b.y6()).c(c5x2.qe());
						if (blk != null && (blk.b() || blk.a().f() >= cem.a) && c5x2.u.b != null)
						{
							string text = d7o.a(A_0, g, a_, c5x2.t.b);
							if (!string.IsNullOrEmpty(text))
							{
								if (!A_2)
								{
									c5x2.u.b.a(text, true, new Color?(adi.ad), null);
									c5x2.t.b.y6().RemoveProperty(c29.n + A_0.ToString());
									c5x2.t.b.y6().RemoveProperty(c29.o + A_0.ToString());
									c5x2.t.b.y6().RemoveProperty(c29.m);
								}
								return true;
							}
						}
					}
					if (A_1)
					{
						TimeSpan timeSpan = serviceOrThrow.aqu().o();
						TimeSpan? primitivePropertyValue = c5x2.t.b.y6().GetPrimitivePropertyValue<TimeSpan>(c29.o + A_0.ToString(), null);
						if (primitivePropertyValue == null || primitivePropertyValue.Value <= timeSpan)
						{
							if (primitivePropertyValue == null)
							{
								if (!A_2)
								{
									c5x2.t.b.y6()[c29.n + A_0.ToString()] = timeSpan;
								}
							}
							else if (c5x2.t.b.y6().GetPrimitivePropertyValue<TimeSpan>(c29.n + A_0.ToString(), null) + TimeSpan.FromSeconds(30.0) <= timeSpan)
							{
								if (!A_2)
								{
									c5x2.t.b.y6().RemoveProperty(c29.n + A_0.ToString());
									c5x2.t.b.y6().RemoveProperty(c29.o + A_0.ToString());
									c5x2.t.b.y6().RemoveProperty(c29.m);
								}
								return true;
							}
							if (!A_2)
							{
								c5x2.t.b.y6()[c29.o + A_0.ToString()] = timeSpan + TimeSpan.FromSeconds(5.0);
							}
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001CCA RID: 7370 RVA: 0x0009FE60 File Offset: 0x0009E060
	public static bool a()
	{
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			c5x c5x = new ar7(c29.a, service.aqu().v().b().Area).ao() as c5x;
			if (c5x != null && c5x.h.b != null && c5x.h.b.aa().IsInControl && !c5x.h.b.aa().IsInCombat && !c5x.h.b.aa().SpecialStates.b)
			{
				cky cky = (service.aqu().ac() as bv9).abu(asp.go, asp.a);
				if (cky != null && cky.a != h.a && aw1.b(service.aqu().v().b(), c5x) <= 10.0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001CCB RID: 7371 RVA: 0x0009FF6C File Offset: 0x0009E16C
	public static bool a(string A_0)
	{
		return !string.IsNullOrEmpty(A_0) && !A_0.ToLower().Contains("healthhypo") && !new List<string>
		{
			"med.bandage",
			"coagulationShot",
			"med.antidote"
		}.Contains(A_0);
	}

	// Token: 0x06001CCC RID: 7372 RVA: 0x0009FFD0 File Offset: 0x0009E1D0
	private static ad7 a(ad7 A_0, coh A_1, c5x A_2, int A_3 = 1, bool A_4 = false, bool A_5 = false)
	{
		if (A_0 != null && A_1 != null)
		{
			if (!string.IsNullOrWhiteSpace(A_1.Definition.a5()))
			{
				if (A_4)
				{
					Collection<esc> collection = A_0.e();
					a1g a1g = new a1g();
					a1g.a(A_1.Definition.a5());
					a1g.b(false);
					a1g.a(new Guid?(A_2.qe()));
					a1g.a(A_3);
					a1g.a(true);
					a1g.c(A_5);
					collection.Add(a1g);
				}
				else
				{
					Collection<esc> collection2 = A_0.e();
					a1g a1g2 = new a1g();
					a1g2.a(A_1.Definition.a5());
					a1g2.b(true);
					a1g2.a(new Guid?(A_2.qe()));
					a1g2.a(A_3);
					a1g2.a(true);
					a1g2.c(A_5);
					collection2.Add(a1g2);
				}
			}
			else
			{
				ekk ekk = new ekk();
				ekk.a()[c29.j] = A_1;
				if (A_4)
				{
					ekk.a()[c29.k] = true;
				}
				Collection<esc> collection3 = A_0.e();
				b6e b6e = new b6e();
				b6e.a(ekk);
				collection3.Add(b6e);
				Collection<esc> collection4 = A_0.e();
				b6e b6e2 = new b6e();
				cxz cxz = new cxz();
				cxz.a("XPHWGJCIT");
				b6e2.a(cxz);
				collection4.Add(b6e2);
			}
		}
		return A_0;
	}

	// Token: 0x06001CCD RID: 7373 RVA: 0x000A0120 File Offset: 0x0009E320
	private static bool a(dgn A_0)
	{
		return A_0 != null && !A_0.a7().GetPrimitivePropertyValue<bool>(dii.d, new bool?(false)).Value && !string.IsNullOrEmpty(A_0.a5()) && !new List<string>
		{
			"theJuice",
			"herculesDrug",
			"motion",
			"bioluminousSwampHoney",
			"hypercerebrix",
			"med.healingSalve",
			"med.vitalityPowder"
		}.Contains(A_0.a5());
	}

	// Token: 0x06001CCE RID: 7374 RVA: 0x000A01CC File Offset: 0x0009E3CC
	private static bool a(a3e A_0)
	{
		return A_0 != null && !A_0.a7().GetPrimitivePropertyValue<bool>(dii.c, new bool?(false)).Value && !string.IsNullOrEmpty(A_0.a5()) && A_0.a5() != "cigar";
	}

	// Token: 0x06001CCF RID: 7375 RVA: 0x000A022C File Offset: 0x0009E42C
	private static int a(coh A_0, efk A_1)
	{
		d7o.a a = new d7o.a();
		a.a = A_0;
		int num = 0;
		if (a.a != null)
		{
			foreach (coh coh in Enumerable.ToList<coh>(Enumerable.Where<coh>(A_1.Bag.z2(), new Func<coh, bool>(a.a))))
			{
				num += coh.Stacks;
			}
		}
		return num;
	}

	// Token: 0x06001CD0 RID: 7376 RVA: 0x000A02C0 File Offset: 0x0009E4C0
	private static string a(Xphw_GunslingerCommentCodeEnum A_0, bool A_1, bool A_2, bm6 A_3)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		List<string> list = null;
		string text = null;
		int item = (int)Enum.Parse(typeof(Xphw_GunslingerCommentCodeEnum), A_0.ToString());
		if (A_0 <= Xphw_GunslingerCommentCodeEnum.Event_CommanderSleeps)
		{
			switch (A_0)
			{
			case Xphw_GunslingerCommentCodeEnum.Combat_FirstFightEnded:
				text = "Неужели война началась, пока нас не было?";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Combat_GrenadeFreeze:
				text = "Что?!";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Combat_SuperSoldierEncounter:
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xphw_exoBase_knowDiscardedExoskeletons", new bool?(false)).Value)
				{
					text = "Видимо, не все из них были списаны в утиль.";
					goto IL_412;
				}
				text = "Их становится всё больше. Их становится всё больше и больше.";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Combat_CommanderDies:
				text = "Ну, вот и всё.";
				goto IL_412;
			default:
				switch (A_0)
				{
				case Xphw_GunslingerCommentCodeEnum.Food_Repeatable:
					list = new List<string>
					{
						"М-м-м...",
						"::Жуёт.::",
						null
					};
					goto IL_412;
				case Xphw_GunslingerCommentCodeEnum.Food_TooMuch:
					text = "Кажется, я перебрал. Уф...";
					goto IL_412;
				case Xphw_GunslingerCommentCodeEnum.Medicine_Repeatable:
					list = new List<string>
					{
						"Надо же...",
						null
					};
					goto IL_412;
				case Xphw_GunslingerCommentCodeEnum.Medicine_FirstBuff:
					text = "Мне не очень нравится принимать это... но ладно.";
					goto IL_412;
				case Xphw_GunslingerCommentCodeEnum.IdleComment_Repeatable:
					list = new List<string>
					{
						"Больше, чем штаб-квартира ДЕТеХ, это точно.",
						"Во что я ввязался?",
						"Всё это... может быть, это знак.",
						"::Вздыхает.:: Да.",
						"::Похоже, кто-то приближается.::",
						null
					};
					goto IL_412;
				case Xphw_GunslingerCommentCodeEnum.IdleCommentAnimated_Repeatable:
					list = new List<string>
					{
						"Интересно...",
						"Хм-м-м...",
						"Что это?",
						null
					};
					goto IL_412;
				case Xphw_GunslingerCommentCodeEnum.Wait_DefaultSpot_Repeatable:
					list = new List<string>
					{
						"Я буду здесь.",
						"Я никуда не уйду.",
						"Понятно, патрон.",
						null
					};
					goto IL_412;
				case Xphw_GunslingerCommentCodeEnum.Wait_CloseSpot_Repeatable:
					list = new List<string>
					{
						"Я буду здесь, патрон.",
						"Да. Я буду рядом.",
						"Я жду рядом.",
						null
					};
					goto IL_412;
				case Xphw_GunslingerCommentCodeEnum.Wait_FarSpot_Repeatable:
					list = new List<string>
					{
						"Я не уйду далеко.",
						"Не самое лучшее место. Я буду там.",
						"Я буду ждать там, патрон."
					};
					goto IL_412;
				case Xphw_GunslingerCommentCodeEnum.EnteringStealth_Repeatable:
					list = new List<string>
					{
						"Я выхожу из зоны видимости.",
						null
					};
					goto IL_412;
				default:
					switch (A_0)
					{
					case Xphw_GunslingerCommentCodeEnum.Event_PicksUpFusionCannon:
						text = "Это одна *большая* термоядерная пушка.";
						goto IL_412;
					case Xphw_GunslingerCommentCodeEnum.Event_ExoskeletonAssemblyScanning:
						text = "Этот сканер определённо пропускает через тебя много лучей, патрон.";
						goto IL_412;
					case Xphw_GunslingerCommentCodeEnum.Event_ExoskeletonAssemblyFinished:
						text = "Не могу сказать, что меня больше поражает - процесс cборки или то, что так сразу осмелится туда залезть.";
						goto IL_412;
					case Xphw_GunslingerCommentCodeEnum.Event_Rifted:
						list = new List<string>
						{
							"Эй, где ты?",
							"Ты прятался в хламе?"
						};
						goto IL_412;
					case Xphw_GunslingerCommentCodeEnum.Event_CommanderSleeps:
						text = "Сладких снов, наверное.";
						goto IL_412;
					}
					break;
				}
				break;
			}
		}
		else
		{
			switch (A_0)
			{
			case Xphw_GunslingerCommentCodeEnum.Location_MainGate:
				text = "Смотри там: Это, наверное, главный вход.";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Location_Lobby:
				text = "Впечатляет. Они знали, как нужно строить.";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Location_Armory:
				text = "Запасных частей здесь хватит на столетие. А стоимость этому, конечно, не малая.";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Location_FusionTesting:
				text = "Здесь видимо проходили многочисленные перестрелки. Чудо, что эта пещера ещё не обрушилась.";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Location_TrainingGrounds:
				text = "Посмотри на размеры этого места. ::Смотрит вверх.:: Нужно быть внимательными. Над нами какие-то дорожки.";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Location_Medical:
				text = "Думаю, мы находимся в каком-то медицинском отделе. Я чувствую запах спирта.";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Location_FusionLab:
				text = "Интересно, для чего нужна эта комната управления...";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Location_ExoSuitAssembly:
				text = "Вот-ж машина с нательной бронёй, что за...";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Location_Vents:
				text = "Ты, похоже, чувствуешь себя в вентиляции гораздо комфортнее, чем кто-либо.";
				goto IL_412;
			case Xphw_GunslingerCommentCodeEnum.Location_TunnelExit:
				text = "Если, что я запомнил обратную дорогу. Наверняка ты тоже.";
				goto IL_412;
			default:
				switch (A_0)
				{
				case Xphw_GunslingerCommentCodeEnum.Location_DarkTer3:
					text = "Я помню этот перекрёсток. Здесь мы свернули не туда.";
					goto IL_412;
				case Xphw_GunslingerCommentCodeEnum.Location_DarkTer2:
					text = "Помехи, они опять мешают моему оборудованию.";
					goto IL_412;
				case Xphw_GunslingerCommentCodeEnum.Location_DarkTer1:
					text = "Будь я проклят: это та самая станция отдыха, так ведь? Мы почти добрались.";
					goto IL_412;
				default:
					switch (A_0)
					{
					case Xphw_GunslingerCommentCodeEnum.Lore_Cloning:
						text = "От кроватки до силовой брони. Что за существование.";
						goto IL_412;
					case Xphw_GunslingerCommentCodeEnum.Lore_Cryochambers:
						list = new List<string>
						{
							"Значит, их держат во льду. Сколько им может быть лет?",
							"Представь себе, что ты спишь в хайтек холодильнике. Сколько им может быть лет?"
						};
						goto IL_412;
					case Xphw_GunslingerCommentCodeEnum.Lore_DeadSupersoldiers:
						text = "Походу, эти не прошли контроль качества.";
						goto IL_412;
					}
					break;
				}
				break;
			}
		}
		return null;
		IL_412:
		if (list != null && Enumerable.Any<string>(list))
		{
			text = list[cuo.a.Next(0, list.Count)];
		}
		if (!string.IsNullOrEmpty(text))
		{
			if (A_1 && !text.StartsWith("::"))
			{
				text = "::Шепчет.:: " + text;
			}
			List<Xphw_GunslingerCommentCodeEnum> list2 = A_3.y6().GetClassPropertyValue<List<Xphw_GunslingerCommentCodeEnum>>(c29.l);
			if (list2 == null)
			{
				list2 = new List<Xphw_GunslingerCommentCodeEnum>();
			}
			list2.Add((Xphw_GunslingerCommentCodeEnum)item);
			if (!A_0.ToString().EndsWith("_Repeatable"))
			{
				A_3.y6()[c29.l] = list2;
			}
		}
		return text;
	}

	// Token: 0x06001CD1 RID: 7377 RVA: 0x000A078C File Offset: 0x0009E98C
	private static d55 a(azm A_0)
	{
		foreach (d55 d in A_0.b().PossibleNextSteps)
		{
			if (Enumerable.Any<esc>((d as ad7).e()))
			{
				foreach (esc esc in (d as ad7).e())
				{
					if (esc is cje && string.Equals((esc as cje).b(), "tempcontext.MainMenuNode"))
					{
						return d;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0200044F RID: 1103
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x06001CD5 RID: 7381 RVA: 0x000A0888 File Offset: 0x0009EA88
		internal bool b(ax8 A_0)
		{
			return A_0.Name == "player";
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x000A089C File Offset: 0x0009EA9C
		internal bool a(ax8 A_0)
		{
			return A_0.Name == "gunslinger";
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x000A08B0 File Offset: 0x0009EAB0
		internal string d(coh A_0)
		{
			return A_0.Definition.az();
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x000A08C0 File Offset: 0x0009EAC0
		internal string c(coh A_0)
		{
			return A_0.Definition.az();
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x000A08D0 File Offset: 0x0009EAD0
		internal string a(coh A_0)
		{
			return A_0.Definition.az();
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x000A08E0 File Offset: 0x0009EAE0
		internal string b(coh A_0)
		{
			return A_0.Definition.a5();
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x000A08F0 File Offset: 0x0009EAF0
		internal coh a(IGrouping<string, coh> A_0)
		{
			return Enumerable.First<coh>(A_0);
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x000A08F8 File Offset: 0x0009EAF8
		internal string e(coh A_0)
		{
			return A_0.Definition.az();
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000A0908 File Offset: 0x0009EB08
		internal string f(coh A_0)
		{
			return A_0.Definition.az();
		}

		// Token: 0x04000FE3 RID: 4067
		public static readonly d7o.b a = new d7o.b();

		// Token: 0x04000FE4 RID: 4068
		public static Func<ax8, bool> b;

		// Token: 0x04000FE5 RID: 4069
		public static Func<ax8, bool> c;

		// Token: 0x04000FE6 RID: 4070
		public static Func<coh, string> d;

		// Token: 0x04000FE7 RID: 4071
		public static Func<coh, string> e;

		// Token: 0x04000FE8 RID: 4072
		public static Func<coh, string> f;

		// Token: 0x04000FE9 RID: 4073
		public static Func<coh, string> g;

		// Token: 0x04000FEA RID: 4074
		public static Func<IGrouping<string, coh>, coh> h;

		// Token: 0x04000FEB RID: 4075
		public static Func<coh, string> i;

		// Token: 0x04000FEC RID: 4076
		public static Func<coh, string> j;
	}

	// Token: 0x02000450 RID: 1104
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06001CDF RID: 7391 RVA: 0x000A0924 File Offset: 0x0009EB24
		internal bool a(coh A_0)
		{
			return A_0.Definition != null && A_0.Definition.a5() == this.a.Definition.a5();
		}

		// Token: 0x04000FED RID: 4077
		public coh a;
	}
}
