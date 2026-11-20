using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000BBE RID: 3006
[euj]
public class e4g
{
	// Token: 0x060044B1 RID: 17585 RVA: 0x001B92AC File Offset: 0x001B74AC
	[ayh("DCVWHRHRT")]
	public void h(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("ongoing"))
			{
				this.b(A_0, 1);
				this.c(A_0);
				this.b(10);
			}
			return;
		}
	}

	// Token: 0x060044B2 RID: 17586 RVA: 0x001B930C File Offset: 0x001B750C
	[ayh("DCVWHRELF")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("ended"))
			{
				a3f aspect = A_0.GetAspect<a3f>();
				if (aspect != null)
				{
					string classPropertyValue = aspect.a().GetClassPropertyValue<string>("LapStatus");
					if (classPropertyValue != null && classPropertyValue.Equals("newlap"))
					{
						this.b(A_0, 1);
						aspect.a()["LapStatus"] = "endinglap";
					}
				}
			}
		}
	}

	// Token: 0x060044B3 RID: 17587 RVA: 0x001B93A8 File Offset: 0x001B75A8
	[ayh("DCVWHRKILLHD")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			d60 d = A_0.Zone.a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"xpbl_dun_cvw_hr_hopper"
				});
				if (list != null && list.Count > 0)
				{
					nb nb = new nb();
					nb.a(new Guid?(list[cuo.a.Next(0, list.Count)].qe()));
					nb.a(bvl.e);
					dtb dtb = new dtb();
					dtb.ad().Add(new a4s(nb, new ar7(A_0), null, null));
					A_0.Zone.ActionManager.g9(dtb, atp.a);
				}
			}
		}
	}

	// Token: 0x060044B4 RID: 17588 RVA: 0x001B9468 File Offset: 0x001B7668
	[ayh("DCVWHRPLN")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("ended"))
			{
				a3f aspect = A_0.GetAspect<a3f>();
				if (aspect != null)
				{
					string classPropertyValue = aspect.a().GetClassPropertyValue<string>("LapStatus");
					if (classPropertyValue != null & classPropertyValue.Equals("endlap"))
					{
						aspect.a()["LapStatus"] = "newlap";
						this.b(A_0, 1);
						return;
					}
					if (classPropertyValue != null & classPropertyValue.Equals("backwardsfromnewlap"))
					{
						aspect.a()["LapStatus"] = "newlap";
						return;
					}
				}
			}
		}
	}

	// Token: 0x060044B5 RID: 17589 RVA: 0x001B952C File Offset: 0x001B772C
	[ayh("DCVWHRCLN")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("ended"))
			{
				a3f aspect = A_0.GetAspect<a3f>();
				if (aspect != null)
				{
					string classPropertyValue = aspect.a().GetClassPropertyValue<string>("LapStatus");
					if (classPropertyValue != null & classPropertyValue.Equals("endinglap"))
					{
						aspect.a()["LapStatus"] = "endlap";
						this.b(A_0, 1);
						this.a(A_0, false);
						this.b(80);
						this.b(45);
						this.b(15);
					}
					if (aspect.a().GetClassPropertyValue<string>("LapStatus").Equals("newlap"))
					{
						aspect.a()["LapStatus"] = "backwardsfromnewlap";
						this.a(new List<string>
						{
							"У-ё! " + A_0.y8() + " идёт не в ту сторону!"
						}, false, 100, true);
					}
				}
			}
		}
	}

	// Token: 0x060044B6 RID: 17590 RVA: 0x001B9644 File Offset: 0x001B7844
	[ayh("DCVWHRHDE")]
	public void i(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 == null && A_1 != null)
		{
			A_0 = A_1;
		}
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null && serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus") != null && serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("ongoing"))
			{
				this.a(new List<string>
				{
					"ФАТАЛЬНУЮ травму получает " + A_0.y8() + "! Как это повлияет на ход гонки?",
					string.Concat(new string[]
					{
						"",
						A_0.y8(),
						"совершает РОКОВУЮ ОШИБКУ! Это печальный день для поклонников... ПЕЩЕРНИКОДРОМ приглашает ещё одного участника в свой славный зал павших прыгунов, поскольку ",
						A_0.y8(),
						" погибает от ран! Трагически и героически."
					}),
					"Сегодня последний прыжок совершает " + A_0.y8() + " падает на землю! Гонка уносит с собой ещё одного великого соперника. Отправляйся на заслуженный отдых.",
					"Трепещите перед трагедией и славой, пещерникодрома, " + A_0.y8() + " уже скачет в мир иной! Мы не забудем тебя дружище, прощай.",
					"" + A_0.y8() + " доминирует в гонке, но его сердце подвело его. Гордитесь своим чемпионом, дорогие болельщики, он отдал все свои силы за победу для вас.",
					"В такую гонку можно умереть! Как и поступает " + A_0.y8() + ", упав замертво во имя высшего блага. Но его имя будет жить вечно. В ИСТОРИИ ПЕЩЕРНИКОДРОМА!"
				}, true, 100, true);
			}
			return;
		}
	}

	// Token: 0x060044B7 RID: 17591 RVA: 0x001B9784 File Offset: 0x001B7984
	[ayh("DCVWHRTFR")]
	public void j(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 == null && A_1 != null)
		{
			A_0 = A_1;
		}
		if (A_0 != null && A_0.GetAspect<a3f>() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus") != null && serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("canceled"))
				{
					return;
				}
				if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus") != null && serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("initial"))
				{
					serviceOrThrow.aqu().r()["loc_xpbl_dun_cvw_hr_raceStatus"] = "canceled";
				}
				if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus") != null && serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("ongoing"))
				{
					if ((serviceOrThrow.aqu().ac() as bv9).abu(asp.a, asp.fl).a == global::h.a)
					{
						serviceOrThrow.aqu().r()["loc_xpbl_dun_cvw_hr_raceStatus"] = "canceled";
						return;
					}
					d60 d = serviceOrThrow.aqw().a();
					List<b0b> list = d.ab4(new string[]
					{
						"xpbl_dun_cvw_hr_hopper"
					});
					if (list != null)
					{
						int? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_dun_cvw_hr_aliveHoppers", new int?(0));
						if (primitivePropertyValue == null)
						{
							primitivePropertyValue = new int?(0);
						}
						List<Guid> list2 = serviceOrThrow.aqu().r().GetClassPropertyValue<List<Guid>>("HopperPlacements");
						if (list2 == null)
						{
							list2 = new List<Guid>();
						}
						c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
						{
							"raceData"
						})) as c5x;
						if (c5x == null)
						{
							return;
						}
						a3f aspect = c5x.GetAspect<a3f>();
						if (aspect != null)
						{
							Dictionary<string, int> classPropertyValue = aspect.a().GetClassPropertyValue<Dictionary<string, int>>("HopperRaceStats");
							Dictionary<string, Guid> classPropertyValue2 = aspect.a().GetClassPropertyValue<Dictionary<string, Guid>>("HopperRaceContenders");
							int? num = primitivePropertyValue;
							int num2 = 0;
							if ((num.GetValueOrDefault() == num2 & num != null) && list2.Count == 0)
							{
								this.a(serviceOrThrow);
								this.a(list2, classPropertyValue, classPropertyValue2, serviceOrThrow);
								serviceOrThrow.aqu().r()["loc_xpbl_dun_cvw_hr_raceStatus"] = "ended";
								this.a(new List<string>
								{
									"Ух ты! Это вообще возможно?! Все пещерники исчезли!? Гонка окончена, дамы и господа! ::Бросает микрофон, который издаёт визжащие звуки.::"
								}, false, 100, true);
								return;
							}
							if ((primitivePropertyValue - list2.Count).GetValueOrDefault() == 1)
							{
								c5x c5x2 = this.a(list2, list);
								if (c5x2 != null)
								{
									this.a(c5x2, true);
								}
								this.a(serviceOrThrow);
								serviceOrThrow.aqu().r()["loc_xpbl_dun_cvw_hr_raceStatus"] = "ended";
								this.a(list2, classPropertyValue, classPropertyValue2, serviceOrThrow);
								this.a(new List<string>
								{
									"Дамы и господа, финал завершён! Смелые рисковые игроки, обратитесь к букмекеру, чтобы получить свой заслуженный приз."
								}, false, 100, true);
								return;
							}
							int count = list2.Count;
							num = primitivePropertyValue;
							if (count == num.GetValueOrDefault() & num != null)
							{
								this.a(list2, classPropertyValue, classPropertyValue2, serviceOrThrow);
								serviceOrThrow.aqu().r()["loc_xpbl_dun_cvw_hr_raceStatus"] = "ended";
								this.a(serviceOrThrow);
								this.a(new List<string>
								{
									"Дамы и господа, финал завершён! Смелые рисковые игроки, обратитесь к букмекеру, чтобы получить свой заслуженный приз."
								}, false, 100, true);
								return;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060044B8 RID: 17592 RVA: 0x001B9B3C File Offset: 0x001B7D3C
	[ayh("DCVWHRBDM")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_1 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
				{
					"raceData"
				})) as c5x;
				if (c5x == null)
				{
					return;
				}
				d85 d = A_1.GetAspect<bim>() as d85;
				if (d != null)
				{
					d.a().Clear();
				}
				if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("ongoing"))
				{
					Dictionary<string, int> classPropertyValue = c5x.GetAspect<a3f>().a().GetClassPropertyValue<Dictionary<string, int>>("HopperRaceStats");
					d.a().Add(string.Concat(new string[]
					{
						"Гонка продолжается!",
						Environment.NewLine,
						"Первое место: ",
						Enumerable.ElementAt<KeyValuePair<string, int>>(classPropertyValue, 0).Key,
						".",
						Environment.NewLine,
						"Второе место: ",
						Enumerable.ElementAt<KeyValuePair<string, int>>(classPropertyValue, 1).Key,
						".",
						Environment.NewLine,
						"Третье место: ",
						Enumerable.ElementAt<KeyValuePair<string, int>>(classPropertyValue, 2).Key,
						".",
						Environment.NewLine,
						"Четвёртое место: ",
						Enumerable.ElementAt<KeyValuePair<string, int>>(classPropertyValue, 3).Key,
						"."
					}));
					return;
				}
				if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("ended"))
				{
					e4g.a a = new e4g.a();
					a3f aspect = c5x.GetAspect<a3f>();
					Dictionary<string, Guid> classPropertyValue2 = aspect.a().GetClassPropertyValue<Dictionary<string, Guid>>("HopperRaceContenders");
					a.a = serviceOrThrow.aqu().r().GetClassPropertyValue<List<Guid>>("HopperPlacements");
					if (a.a.Count < 4)
					{
						Dictionary<string, int> classPropertyValue3 = aspect.a().GetClassPropertyValue<Dictionary<string, int>>("HopperRaceStats");
						this.a(a.a, classPropertyValue3, classPropertyValue2, serviceOrThrow);
					}
					d.a().Add(string.Concat(new string[]
					{
						"Гонка завершена!",
						Environment.NewLine,
						"Первое место: ",
						Enumerable.FirstOrDefault<KeyValuePair<string, Guid>>(classPropertyValue2, new Func<KeyValuePair<string, Guid>, bool>(a.d)).Key,
						".",
						Environment.NewLine,
						"Второе место: ",
						Enumerable.FirstOrDefault<KeyValuePair<string, Guid>>(classPropertyValue2, new Func<KeyValuePair<string, Guid>, bool>(a.a)).Key,
						".",
						Environment.NewLine,
						"Третье место: ",
						Enumerable.FirstOrDefault<KeyValuePair<string, Guid>>(classPropertyValue2, new Func<KeyValuePair<string, Guid>, bool>(a.b)).Key,
						".",
						Environment.NewLine,
						"Четвёртое место: ",
						Enumerable.FirstOrDefault<KeyValuePair<string, Guid>>(classPropertyValue2, new Func<KeyValuePair<string, Guid>, bool>(a.c)).Key,
						"."
					}));
					return;
				}
				if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("canceled"))
				{
					d.a().Add("Дорогие посетители, гонка была отменена из-за непредвиденных обстоятельств.");
					return;
				}
				if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("initial"))
				{
					d.a().Add("Дорогие посетители, гонка начнётся в ближайшее время.");
				}
			}
		}
	}

	// Token: 0x060044B9 RID: 17593 RVA: 0x001B9ECC File Offset: 0x001B80CC
	private c5x a(List<Guid> A_0, List<b0b> A_1)
	{
		foreach (b0b b0b in A_1)
		{
			c5x c5x = (c5x)b0b;
			bool flag = false;
			foreach (Guid b in A_0)
			{
				if (c5x.qe() == b)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				return c5x;
			}
		}
		return null;
	}

	// Token: 0x060044BA RID: 17594 RVA: 0x001B9F84 File Offset: 0x001B8184
	private void a(List<Guid> A_0, Dictionary<string, int> A_1, Dictionary<string, Guid> A_2, cnk A_3)
	{
		if (A_0.Count >= 4)
		{
			return;
		}
		int num = A_2.Count - A_0.Count;
		for (int i = 0; i < 4; i++)
		{
			c5x c5x = new ar7(A_2[Enumerable.ElementAt<KeyValuePair<string, int>>(A_1, i).Key], A_3.aqu().v().b().Area).ao() as c5x;
			if (c5x != null && !A_0.Contains(A_2[Enumerable.ElementAt<KeyValuePair<string, int>>(A_1, i).Key]))
			{
				A_0.Add(c5x.qe());
				num--;
			}
		}
		if (num == 0 || A_0.Count >= 4)
		{
			return;
		}
		for (int j = 0; j < 4; j++)
		{
			if (!A_0.Contains(A_2[Enumerable.ElementAt<KeyValuePair<string, int>>(A_1, j).Key]))
			{
				A_0.Add(A_2[Enumerable.ElementAt<KeyValuePair<string, int>>(A_1, j).Key]);
			}
		}
	}

	// Token: 0x060044BB RID: 17595 RVA: 0x001BA090 File Offset: 0x001B8290
	private void b(int A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null && cuo.a.Next(0, 100) < A_0)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"commoner"
				});
				if (list != null)
				{
					c5x c5x = list[cuo.a.Next(0, Enumerable.Count<b0b>(list) - 1)] as c5x;
					if (c5x != null)
					{
						List<string> list2 = new List<string>
						{
							"::Поднимает кулак вверх.::",
							"::Аплодирует.::",
							"У тебя получится!",
							"Да-а-а!",
							"Это безумие!",
							"Не туда!",
							"::Радостно машет руками.::",
							"::Свистит.::",
							"::Кричит от восторга.::",
							"Ура!",
							"::Рукоплещет.::",
							"У-у-у...",
							"Это невозможно!",
							"Я не могу смотреть на это ::Закрывает глаза.::",
							"Доминируй!",
							"Эти пещерники чокнутые!",
							"Берегись!",
							"Беги на этой чёртовой трассе!",
							"Это меня уже бесит!",
							"Ва-а-ау!",
							"Мелкий квакер!",
							"Я так и знал!",
							"Это мне нравится!",
							"Ещё есть шанс!",
							"Жестоко.",
							"::Грызёт ногти.::",
							"::Прыгает на месте.::",
							"::Кричит матом.::",
							"Шутка! Это просто плохая шутка!",
							"Печаль...",
							"Да ладно, ты же сбился с пути?!",
							"Хватит спать!",
							"Моя мама бы бежала быстрее!",
							"Никогда не везло...",
							"Хардкор!",
							"Арена - это шутка по сравнению с этим!"
						};
						dtb dtb = new dtb();
						d9m d9m = new d9m();
						us us = new us();
						us.a(list2[cuo.a.Next(0, Enumerable.Count<string>(list2) - 1)]);
						us.a(bvl.e);
						us.a(new Guid?(c5x.qe()));
						d9m.a(cuo.a.Next(750, 2550));
						d9m.c().Add(us);
						dtb.ad().Add(new a4s(d9m, new ar7(c5x), new ar7(c5x), null));
						c5x.Zone.ActionManager.g9(dtb, atp.a);
						c5x.u.b.a(list2[cuo.a.Next(0, Enumerable.Count<string>(list2) - 1)], true, null, null);
					}
				}
			}
		}
	}

	// Token: 0x060044BC RID: 17596 RVA: 0x001BA394 File Offset: 0x001B8594
	private void a(List<string> A_0, bool A_1 = false, int A_2 = 100, bool A_3 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_2 >= cuo.a.Next(0, 100))
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"xpbl_dun_cvw_hr_speaker"
				});
				if (list != null)
				{
					TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("loc_xpbl_dun_hr_speecCooldown", null);
					if (A_3 || primitivePropertyValue == null || primitivePropertyValue < serviceOrThrow.aqu().p())
					{
						string a_;
						if (A_1)
						{
							a_ = this.a(A_0);
						}
						else
						{
							a_ = A_0[0];
						}
						foreach (b0b b0b in list)
						{
							c5x c5x = (c5x)b0b;
							if (c5x.u.b != null)
							{
								c5x.u.b.a(a_, true, null, null);
							}
						}
						this.b(100);
						this.b(75);
						this.b(50);
						primitivePropertyValue = new TimeSpan?(TimeSpan.FromMilliseconds((double)cuo.a.Next(1200, 2100)));
						serviceOrThrow.aqu().r()["loc_xpbl_dun_hr_speecCooldown"] = primitivePropertyValue;
					}
				}
			}
		}
	}

	// Token: 0x060044BD RID: 17597 RVA: 0x001BA554 File Offset: 0x001B8754
	private string a(List<string> A_0)
	{
		return A_0[cuo.a.Next(0, A_0.Count - 1)];
	}

	// Token: 0x060044BE RID: 17598 RVA: 0x001BA57C File Offset: 0x001B877C
	private void a(cnk A_0)
	{
		c5x c5x = A_0.aqu().v().b() as c5x;
		if (c5x != null)
		{
			c5x.i.b.a(true, false);
			A_0.aqw().a();
			c5x c5x2 = new ar7(new Guid("c72c2337-980a-4109-8030-d86c7f5f9342"), c5x.Area).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("7a22d4a1-0b24-4c40-9f62-2176e70e7591"), c5x.Area).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("35c35884-c90e-43c0-b135-dd0d31984882"), c5x.Area).ao() as c5x;
			if (c5x2 != null && c5x2.t.b != null)
			{
				c5x2.t.b.y6()[ddq.ay] = new bt4("99a77a56-5127-4bbd-9f7d-43642db65f0f");
			}
			if (c5x3 != null && c5x3.t.b != null)
			{
				c5x3.t.b.y6()[ddq.ay] = new bt4("90189bf0-d3bb-4f04-8d1a-c1ef38275637");
			}
			if (c5x4 != null && c5x4.t.b != null)
			{
				c5x4.t.b.y6()[ddq.ay] = new bt4("37e13f80-794b-4ff5-b7f7-f5a8f1e08785");
			}
		}
	}

	// Token: 0x060044BF RID: 17599 RVA: 0x001BA6D4 File Offset: 0x001B88D4
	private void b(c5x A_0, int A_1 = 1)
	{
		a3f aspect = A_0.GetAspect<a3f>();
		if (aspect != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				d60 d = serviceOrThrow.aqw().a();
				if (d != null)
				{
					int num = aspect.a().GetPrimitivePropertyValue<int>("WaypointsCompleted", new int?(0)).Value + A_1;
					aspect.a()["WaypointsCompleted"] = num;
					c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
					{
						"raceData"
					})) as c5x;
					if (c5x != null)
					{
						a3f aspect2 = c5x.GetAspect<a3f>();
						if (aspect2 != null)
						{
							Dictionary<string, int> classPropertyValue = aspect2.a().GetClassPropertyValue<Dictionary<string, int>>("HopperRaceStats");
							if (classPropertyValue != null)
							{
								classPropertyValue[A_0.y8()] = num;
							}
							Dictionary<string, int> value = Enumerable.ToDictionary<KeyValuePair<string, int>, string, int>(Enumerable.OrderByDescending<KeyValuePair<string, int>, int>(classPropertyValue, new Func<KeyValuePair<string, int>, int>(e4g.b.a.b)), new Func<KeyValuePair<string, int>, string>(e4g.b.a.c), new Func<KeyValuePair<string, int>, int>(e4g.b.a.a));
							aspect2.a()["HopperRaceStats"] = value;
						}
					}
				}
			}
		}
	}

	// Token: 0x060044C0 RID: 17600 RVA: 0x001BA834 File Offset: 0x001B8A34
	private void a(c5x A_0, bool A_1 = false)
	{
		a3f aspect = A_0.GetAspect<a3f>();
		if (aspect != null)
		{
			int num = aspect.a().GetPrimitivePropertyValue<int>("LapsCompleted", new int?(0)).Value + 1;
			aspect.a()["LapsCompleted"] = num;
			if (num == 11 || A_1)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					List<Guid> list = serviceOrThrow.aqu().r().GetClassPropertyValue<List<Guid>>("HopperPlacements");
					if (list == null)
					{
						list = new List<Guid>();
					}
					if (list != null && serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus").Equals("ongoing"))
					{
						list.Add(A_0.qe());
						serviceOrThrow.aqu().r()["HopperPlacements"] = list;
						switch (Enumerable.Count<Guid>(list))
						{
						case 1:
							this.a(A_0, "firstPlace");
							this.a(new List<string>
							{
								"ПОБЕДИТЕЛЬ * " + A_0.y8() + "*! Чёрт, это было быстро!",
								"И победителем станови-и-ится *" + A_0.y8() + "*! Вот что такое Пещерникодром!"
							}, true, 100, false);
							this.j(A_0, A_0, null);
							return;
						case 2:
							this.a(A_0, "secondPlace");
							this.a(new List<string>
							{
								"Второе место занимает: *" + A_0.y8() + "*!",
								"Победитель второго места, ЕДИНСТВЕННЫЙ и НЕПОВТОРИМЫЙ пещерник: *" + A_0.y8() + "*!"
							}, true, 100, false);
							this.j(A_0, A_0, null);
							return;
						case 3:
							this.a(A_0, "thirdPlace");
							this.a(new List<string>
							{
								"Третье место занимает: *" + A_0.y8() + "*!",
								"Третье место зани-и-имает *" + A_0.y8() + "*!"
							}, true, 100, false);
							this.j(A_0, A_0, null);
							return;
						default:
							this.a(A_0, "fourthPlace");
							this.a(new List<string>
							{
								"И на последнем месте: *" + A_0.y8() + "*. Ну что ж.",
								"*" + A_0.y8() + "* приходит последним. Тому кто сделал такую ставку не повезло."
							}, true, 100, false);
							this.j(A_0, A_0, null);
							break;
						}
					}
					return;
				}
			}
			if (!A_1 && num > 1 && num < 11)
			{
				List<string> list2 = new List<string>();
				if (num < 10)
				{
					list2.AddRange(new List<string>
					{
						string.Concat(new string[]
						{
							"",
							this.a(num - 1),
							" круг проходит *",
							A_0.y8(),
							"*! Продолжит ли в том же духе?"
						}),
						string.Concat(new string[]
						{
							"Невероятно* ",
							A_0.y8(),
							"* завершает свой ",
							this.a(num - 1),
							" круг!"
						}),
						string.Concat(new string[]
						{
							"Впечатляюще проходит *",
							(num - 1).ToString(),
							"* круг очаровашка *",
							A_0.y8(),
							"*!"
						}),
						string.Concat(new string[]
						{
							"Воздух содрогается после того как *",
							A_0.y8(),
							"* завершает свой ",
							this.a(num - 1),
							" круг!"
						}),
						string.Concat(new string[]
						{
							"Великолепно проходит *",
							(num - 1).ToString(),
							"* круг, молодчина *",
							A_0.y8(),
							"*!"
						}),
						string.Concat(new string[]
						{
							"Смотрите, *",
							A_0.y8(),
							"* заканчивает ",
							this.a(num - 1),
							" круг!"
						}),
						string.Concat(new string[]
						{
							"И вот оно, леди и джентльмены, *",
							A_0.y8(),
							"* завершает круг эм-м под номером *",
							(num - 1).ToString(),
							"*!"
						}),
						string.Concat(new string[]
						{
							"Оу-у-у! *",
							A_0.y8(),
							"* во вседвижении! Завершает ",
							this.a(num - 1),
							" круг!"
						}),
						string.Concat(new string[]
						{
							"Битва по истинному хороша, и она не была бы такой без того как *",
							A_0.y8(),
							"* завершает ",
							this.a(num - 1),
							" круг!"
						}),
						string.Concat(new string[]
						{
							"Если я не очень сильно ошибаюсь, *",
							A_0.y8(),
							"* просто проносится вырывая ",
							this.a(num - 1),
							" круг! Это полный хардкор!"
						}),
						string.Concat(new string[]
						{
							"Мой секундомер пылает! Вместе с тем как *",
							A_0.y8(),
							"* прошныривает ",
							this.a(num - 1),
							" круг!"
						}),
						string.Concat(new string[]
						{
							"Стрелка часов просто не поспевает за тем как *",
							A_0.y8(),
							"* проносится сквозь ",
							this.a(num - 1),
							" круг!"
						}),
						string.Concat(new string[]
						{
							"Неужели мои глаза мне врут? *",
							A_0.y8(),
							"* чертовски быстро завершает ",
							this.a(num - 1),
							" круг!"
						}),
						string.Concat(new string[]
						{
							"Только посмотрите на эти длинные прыжки! *",
							A_0.y8(),
							"* завершает свой ",
							this.a(num - 1),
							" круг!"
						}),
						string.Concat(new string[]
						{
							"Фу-у я еле успел остановить секундомер, после того как *",
							A_0.y8(),
							"* завершает свой ",
							this.a(num - 1),
							" круг!"
						}),
						string.Concat(new string[]
						{
							"Как считаете? *",
							A_0.y8(),
							"* \u0097 медленный камень или быстрая пуля, но как видно ",
							(num - 1).ToString(),
							" круг уже остался позади!"
						}),
						string.Concat(new string[]
						{
							"Одну минутку, дамы и господа, *",
							A_0.y8(),
							"* пересекает финишную черту, завершая свой ",
							this.a(num - 1),
							" круг!"
						}),
						string.Concat(new string[]
						{
							"Это был *",
							(num - 1).ToString(),
							"* круг и *",
							A_0.y8(),
							"* просто вырывает его с корнем!"
						}),
						string.Concat(new string[]
						{
							"Какое движение, что даже за счётчиком круга едва уследишь: *",
							(num - 1).ToString(),
							"* завершает *",
							A_0.y8(),
							"*!"
						}),
						string.Concat(new string[]
						{
							"Пещерникодром запомнит как *",
							A_0.y8(),
							"* пропрыгивает свой ",
							this.a(num - 1),
							" круг! Как удивительно?!"
						}),
						string.Concat(new string[]
						{
							"*",
							A_0.y8(),
							"* перескакивает свой ",
							this.a(num - 1),
							" круг! Выдающаяся производительность!"
						}),
						string.Concat(new string[]
						{
							"Часы, часы, ЧАСЫ! Какой круг проходит *",
							A_0.y8(),
							"*. ",
							this.a(num - 1),
							" круг, а он всегда напряжённый!"
						}),
						string.Concat(new string[]
						{
							"*",
							A_0.y8(),
							"*, тебе жарко, но осталось всего *",
							(11 - num).ToString(),
							"* пробежать!"
						}),
						string.Concat(new string[]
						{
							"Ну же *",
							A_0.y8(),
							"* дружище, всего *",
							(11 - num).ToString(),
							"* осталось пойти!"
						}),
						string.Concat(new string[]
						{
							"Леди и джентльмены, вознадейтесь как *",
							A_0.y8(),
							"* допрыгает, осталось всего *",
							(11 - num).ToString(),
							"*!"
						}),
						string.Concat(new string[]
						{
							"*",
							(11 - num).ToString(),
							"* всего до финиша. *",
							A_0.y8(),
							"*, у тебя остались ещё силы?! Вперёд!"
						}),
						string.Concat(new string[]
						{
							"*",
							(num - 1).ToString(),
							"* круг и *",
							(11 - num).ToString(),
							"* остаётся проскакать! Бросай всё и вперёд!"
						})
					});
				}
				else if (num == 10)
				{
					list2.AddRange(new List<string>
					{
						"*" + A_0.y8() + "*, это твой последний круг! Чёрт возьми, да, ты сможешь это сделать!",
						"Ну же *" + A_0.y8() + "*, у тебя остался всего один круг! Игроки взбодритесь, ДА, ДА, ДА!",
						"*" + A_0.y8() + "* проходит предпоследний круг, выкладывайся по полной, дружище!",
						"Вы только что стали свидетелями как *" + A_0.y8() + "* проходит предпоследний круг. Держись за своё место!",
						"*" + A_0.y8() + "*, похоже, в предвкушении финиша! Сможет ли этот пещерник сделать это?"
					});
				}
				this.a(list2, true, 100, true);
			}
		}
	}

	// Token: 0x060044C1 RID: 17601 RVA: 0x001BB258 File Offset: 0x001B9458
	private void a(c5x A_0, string A_1)
	{
		if (A_0 != null)
		{
			A_0.t.b.y6()[ddq.k] = new List<string>
			{
				A_1
			};
			a3f aspect = A_0.GetAspect<a3f>();
			if (!(A_1 == "firstPlace"))
			{
				if (!(A_1 == "secondPlace"))
				{
					if (!(A_1 == "thirdPlace"))
					{
						if (!(A_1 == "fourthPlace"))
						{
						}
					}
					else
					{
						this.b(A_0, 1500);
					}
				}
				else
				{
					this.b(A_0, 5000);
				}
			}
			else
			{
				this.b(A_0, 10000);
			}
			if (aspect != null)
			{
				aspect.a()["ImmuneStacks"] = 9999;
			}
		}
	}

	// Token: 0x060044C2 RID: 17602 RVA: 0x001BB32C File Offset: 0x001B952C
	private string a(int A_0)
	{
		string text = "";
		int num = A_0 % 10;
		int num2 = A_0 / 10 % 10;
		string text2 = "";
		if (num2 == 1)
		{
			text2 = "";
		}
		else
		{
			switch (num)
			{
			case 1:
				text = "st";
				break;
			case 2:
				text = "";
				break;
			case 3:
				text = "";
				break;
			default:
				text = "";
				break;
			}
		}
		return string.Concat(new string[]
		{
			"*",
			A_0.ToString(),
			text,
			text2,
			"*"
		});
	}

	// Token: 0x060044C3 RID: 17603 RVA: 0x001BB3D0 File Offset: 0x001B95D0
	private void c(c5x A_0)
	{
		a3f aspect = A_0.GetAspect<a3f>();
		if (aspect != null)
		{
			int value = aspect.a().GetPrimitivePropertyValue<int>("NegativeTriggerModifier", new int?(0)).Value;
			int value2 = aspect.a().GetPrimitivePropertyValue<int>("StunModifier", new int?(0)).Value;
			int value3 = aspect.a().GetPrimitivePropertyValue<int>("SpeedModifier", new int?(0)).Value;
			int value4 = aspect.a().GetPrimitivePropertyValue<int>("HealChanceModifier", new int?(0)).Value;
			int value5 = aspect.a().GetPrimitivePropertyValue<int>("DmgResistModifier", new int?(0)).Value;
			int value6 = aspect.a().GetPrimitivePropertyValue<int>("HealValueModifier", new int?(0)).Value;
			int value7 = aspect.a().GetPrimitivePropertyValue<int>("DamageChanceModifier", new int?(0)).Value;
			int value8 = aspect.a().GetPrimitivePropertyValue<int>("JuiceTeleportChance", new int?(0)).Value;
			if (100 - value > cuo.a.Next(0, 101) && this.b(A_0))
			{
				if (100 - value2 < cuo.a.Next(0, 101))
				{
					this.a(A_0, 1, 5);
				}
				if (100 - value4 < cuo.a.Next(0, 101))
				{
					A_0.h.b.aa().Defense.a(cuo.a.Next(7, 10) + value6, A_0.h.b.aa(), null, true, false, false, null);
				}
				if (100 - value7 < cuo.a.Next(0, 101))
				{
					this.a(A_0, cuo.a.Next(4, 8) - value5);
				}
				if (50 < cuo.a.Next(0, 100))
				{
					this.a(A_0, value3, -0.6f, 0.4f);
				}
				if (value8 > cuo.a.Next(0, 101))
				{
					this.a(A_0);
				}
			}
		}
	}

	// Token: 0x060044C4 RID: 17604 RVA: 0x001BB5F8 File Offset: 0x001B97F8
	private bool b(c5x A_0)
	{
		a3f aspect = A_0.GetAspect<a3f>();
		if (aspect != null)
		{
			int value = aspect.a().GetPrimitivePropertyValue<int>("ImmuneStacks", new int?(0)).Value;
			aspect.a()["ImmuneStacks"] = value - 1;
			return value - 1 <= 0;
		}
		return true;
	}

	// Token: 0x060044C5 RID: 17605 RVA: 0x001BB658 File Offset: 0x001B9858
	private void a(c5x A_0)
	{
		a3f aspect = A_0.GetAspect<a3f>();
		if (aspect != null)
		{
			aspect.a()["ImmuneStacks"] = 999;
			e4o e4o = new e4o(A_0);
			e4o.a(0.05);
			e4o.a((A_0.ae != null) ? ((byte)(Math.Min(1f, A_0.ae.Value) * 255f)) : byte.MaxValue);
			e4o.b(0);
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			qy.ad().Add(e4o);
			qy.ad().Add(new c7(A_0, false, false, true, false));
			A_0.Zone.ActionManager.g9(qy, atp.a);
			this.a(new List<string>
			{
				"Ох, мой! *" + A_0.y8() + "* это... это... ИСЧЕЗНОВЕНИЕ?!",
				string.Concat(new string[]
				{
					"Эм-м. Что?! *",
					A_0.y8(),
					"*? *",
					A_0.y8(),
					"* куда-то пропадает?"
				}),
				"А? Неужели *" + A_0.y8() + "* просто исчезает у меня на глазах?",
				"Игроки, вы это видели? *" + A_0.y8() + "*, эм-м... этот пещерник просто исчез?!"
			}, true, 100, true);
		}
	}

	// Token: 0x060044C6 RID: 17606 RVA: 0x001BB7CC File Offset: 0x001B99CC
	private void a(c5x A_0, int A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.p = true;
			cwt.l = true;
			cwt.f.Add(new csk(DamageType.Mechanical, A_1));
			cwt.y = "{2} получает ";
			akg a_ = new akg(null, A_0.h.b, cwt, null, false);
			A_0.Zone.ActionManager.g9(a_, atp.a);
			this.a(new List<string>
			{
				"*" + A_0.y8() + "* сталкивается с трудностями!",
				"Неужели *" + A_0.y8() + "* сейчас просто подохнет?",
				"О нет, *" + A_0.y8() + "*, похоже, без сил.",
				string.Concat(new string[]
				{
					"И тут *",
					A_0.y8(),
					"* терпит неудачу. Ну же ",
					A_0.y8(),
					" ради твоих поклонников."
				}),
				"Во это да, *" + A_0.y8() + "*! Что там случилось?!",
				"А вот и получает свои неприятности *" + A_0.y8() + "*!",
				"*" + A_0.y8() + "* ударяется головой! Надеюсь, там не совсем всё плохо.",
				"Осторожно *" + A_0.y8() + "*! О нет...",
				"*" + A_0.y8() + "*, это же не конец для тебя, я прав?",
				"Это жесткая гонка для тебя, *" + A_0.y8() + "*. Или так кажется.",
				"Ох, *" + A_0.y8() + "*! Это плохо.",
				"*" + A_0.y8() + "* дрожит от боли.",
				"*" + A_0.y8() + "* хромает от боли. Ах!",
				"Кому-то это не понравится, но *" + A_0.y8() + "* во что-то вляпывается!",
				"Смотрите, *" + A_0.y8() + "*! С трудом держится на ногах!",
				"*" + A_0.y8() + "*! Только не сейчас нет-нет!",
				"*" + A_0.y8() + "* получает травму, ай!",
				"*" + A_0.y8() + "* подворачивает лапку! Должно быть это больно.",
				"Ой ай ах *" + A_0.y8() + "*! Тебе нужен перерыв!",
				"Что с тобой *" + A_0.y8() + "*?! О, это выглядит плохо!",
				"О как, *" + A_0.y8() + "*! Это было грубо!",
				"Все смотрите туда где *" + A_0.y8() + "*! Кровь хлещет по всей трассе после этой травмы!",
				"Ну же *" + A_0.y8() + "*! Не сдавайся сейчас!",
				"*" + A_0.y8() + "* уви-и-и! Давай, давай!"
			}, true, 50, false);
		}
	}

	// Token: 0x060044C7 RID: 17607 RVA: 0x001BBB08 File Offset: 0x001B9D08
	private void a(c5x A_0, int A_1, float A_2, float A_3)
	{
		float num = A_0.h.b.aa().BaseMovementSpeed;
		num = ((num / 2f > 1f) ? (num / 2f) : 1f) + (float)cuo.a.NextDouble() * (A_3 - A_2) + A_2 + (float)A_1 / 100f;
		if (num < 0.3f)
		{
			num = 0.3f;
		}
		A_0.h.b.aa().BaseMovementSpeed = num;
		A_0.h.b.aa().bl();
	}

	// Token: 0x060044C8 RID: 17608 RVA: 0x001BBBA8 File Offset: 0x001B9DA8
	private void a(c5x A_0, int A_1, int A_2)
	{
		adn adn = new adn();
		adn.a(cuo.a.Next(A_1, A_2) * 1000);
		adn.a(new Guid?(A_0.qe()));
		adn.a(false);
		dtb dtb = new dtb();
		d9m d9m = new d9m();
		int maxValue = 3000;
		if (cuo.a.Next(0, 100) == 1)
		{
			d9m.c().Add(new ezd(null, new bt4(A_0.Area.y8(), A_0.Location), null, null, new CharacterState?(CharacterState.Idle), null, "Locale\\Floor\\Poop"));
			bfq bfq = new bfq();
			bfq.c("CaveHopperAttack");
			d9m.c().Add(bfq);
			maxValue = 1;
		}
		d9m.a(cuo.a.Next(0, maxValue));
		d9m.c().Add(adn);
		dtb.ad().Add(new a4s(d9m, null, new ar7(A_0), null));
		A_0.Zone.ActionManager.g9(dtb, atp.a);
		this.a(new List<string>
		{
			"*" + A_0.y8() + "* теряет сознание!",
			"*" + A_0.y8() + "* ты в порядке? Ты выглядишь не очень хорошо!",
			"О нет, *" + A_0.y8() + "* почему ты лежишь?!",
			"Вставай *" + A_0.y8() + "*!",
			"Вай, *" + A_0.y8() + "*! Ты же не спишь?! Давай, давай!",
			"Ой *" + A_0.y8() + "*!"
		}, true, 25, false);
	}

	// Token: 0x060044C9 RID: 17609 RVA: 0x001BBD7C File Offset: 0x001B9F7C
	[ayh("DCVWHRTHRCR")]
	public void l(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				string classPropertyValue = bq.GetClassPropertyValue<string>("TicketCode");
				coh coh = serviceOrThrow.aqu().v().a(classPropertyValue, false);
				if (coh != null)
				{
					string classPropertyValue2 = coh.Definition.a7().GetClassPropertyValue<string>("BetType");
					List<Guid> classPropertyValue3 = serviceOrThrow.aqu().r().GetClassPropertyValue<List<Guid>>("HopperPlacements");
					Guid? primitivePropertyValue = coh.Definition.a7().GetPrimitivePropertyValue<Guid>("HopperId", null);
					float value = coh.Definition.a7().GetPrimitivePropertyValue<float>("Quota", new float?(0f)).Value;
					int value2 = coh.Definition.a7().GetPrimitivePropertyValue<int>("BetAmount", new int?(0)).Value;
					int num = 0;
					string classPropertyValue4 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_dun_cvw_hr_raceStatus");
					if (classPropertyValue4 != null && classPropertyValue4 == "canceled")
					{
						num = value2;
						bq.set_Item("Refund", true);
					}
					else if (classPropertyValue2 != null && Enumerable.Any<Guid>(classPropertyValue3))
					{
						if (classPropertyValue2 == "на носу" && classPropertyValue3[0] == primitivePropertyValue)
						{
							num = (int)((float)value2 * value);
						}
						else
						{
							if (classPropertyValue2 == "на хвосте")
							{
								Guid guid = classPropertyValue3[1];
								if (classPropertyValue3[1] == primitivePropertyValue)
								{
									num = (int)((float)value2 * value);
									goto IL_313;
								}
							}
							if (classPropertyValue2 == "еле-еле душа в теле")
							{
								Guid guid2 = classPropertyValue3[2];
								if (classPropertyValue3[2] == primitivePropertyValue)
								{
									num = (int)((float)value2 * value);
									goto IL_313;
								}
							}
							if (classPropertyValue2 == "или или")
							{
								float num2 = value;
								Guid guid3 = classPropertyValue3[0];
								if (classPropertyValue3[0] == primitivePropertyValue)
								{
									num2 = 0f;
								}
								else
								{
									Guid guid4 = classPropertyValue3[1];
									if (classPropertyValue3[1] == primitivePropertyValue)
									{
										num2 = 0.3f;
									}
								}
								num = (int)((float)value2 * (value - num2));
							}
						}
					}
					IL_313:
					bq.set_Item("BetWinnings", num);
					serviceOrThrow.aqu().v().Bag.z5(coh);
					if (num > 0)
					{
						serviceOrThrow.aqu().v().Bag.z3(new d48(ez2.CreateDefinitonProvider<a54>("currency\\StygianCoin"))
						{
							Stacks = num
						}, true);
					}
				}
			}
		}
	}

	// Token: 0x060044CA RID: 17610 RVA: 0x001BC0FC File Offset: 0x001BA2FC
	[ayh("DCVWHRTHRIT")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				d48 d = new d48(ez2.CreateDefinitonProvider<dj3>("Plot\\Xpbl\\HopperRacingBettingTicketBase"));
				if (d != null)
				{
					dj3 dj = new dj3();
					string classPropertyValue = bq.GetClassPropertyValue<string>("BetType");
					Guid value = bq.GetPrimitivePropertyValue<Guid>("HopperId", null).Value;
					float value2 = bq.GetPrimitivePropertyValue<float>("Quota", new float?(0f)).Value;
					int value3 = bq.GetPrimitivePropertyValue<int>("BetAmount", new int?(0)).Value;
					c5x c5x = new ar7(value, serviceOrThrow.aqw().n("xpbl_dun_cvw_hr")).ao() as c5x;
					if (c5x != null)
					{
						dj.a7()["BetType"] = classPropertyValue;
						dj.a7()["HopperId"] = value;
						dj.a7()["Quota"] = value2;
						dj.a7()["BetAmount"] = value3;
						dj.g(d.Definition.az());
						dj.f(d.Definition.a3());
						dj.a(d.Definition.bi());
						dj.k("plot.xpbl_hopperRacing_playersTicket");
						dj.i(string.Concat(new string[]
						{
							d.Definition.a0(),
							"<br><br>Пещерник - ",
							c5x.y8(),
							"<br>Тип - ",
							classPropertyValue,
							"<br>Шансы - ",
							value2.ToString(),
							"<br>Ставка - ",
							value3.ToString(),
							" харонов"
						}));
						serviceOrThrow.aqu().v().Bag.z3(new d48(new IndependentItemDefinitionProvider<dj3>(dj)), true);
						a7v.a(new bou(new d48(new IndependentItemDefinitionProvider<dj3>(dj))));
						coh a_ = serviceOrThrow.aqu().v().Bag.a("currency.sc", value3);
						c5x c5x2 = new ar7(new Guid("044ef863-0786-4349-bed1-1a2882bcf17e"), serviceOrThrow.aqu().v().b().Area).ao() as c5x;
						if (c5x2 != null && c5x2.s.b is c7j)
						{
							c7j c7j = c5x2.GetAspect<bim>() as c7j;
							if (c7j != null)
							{
								c7j.ItemContainer.z3(a_, true);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060044CB RID: 17611 RVA: 0x001BC3C0 File Offset: 0x001BA5C0
	[ayh("DCVWHRTHRBGHN")]
	public void g(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				c5x c5x = new ar7(new Guid("19849dfb-02b1-406c-9c39-688442bacc38"), serviceOrThrow.aqw().n("xpbl_dun_cvw_hr")).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("e1c834ce-327b-4a3f-b058-ff159fb458b5"), serviceOrThrow.aqw().n("xpbl_dun_cvw_hr")).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("35b9590b-24e4-4d3f-adfb-80c82ce53497"), serviceOrThrow.aqw().n("xpbl_dun_cvw_hr")).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("a3a467be-22ae-4d22-85d7-6542b86cd451"), serviceOrThrow.aqw().n("xpbl_dun_cvw_hr")).ao() as c5x;
				if (c5x != null)
				{
					bq.set_Item("Hopper1Name", c5x.y8());
				}
				if (c5x2 != null)
				{
					bq.set_Item("Hopper2Name", c5x2.y8());
				}
				if (c5x3 != null)
				{
					bq.set_Item("Hopper3Name", c5x3.y8());
				}
				if (c5x4 != null)
				{
					bq.set_Item("Hopper4Name", c5x4.y8());
				}
			}
		}
	}

	// Token: 0x060044CC RID: 17612 RVA: 0x001BC510 File Offset: 0x001BA710
	[ayh("DCVWHRTHRBGHQ")]
	public void k(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				d60 d = serviceOrThrow.aqw().a();
				if (d != null)
				{
					c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
					{
						"raceData"
					})) as c5x;
					if (c5x != null)
					{
						a3f aspect = c5x.GetAspect<a3f>();
						if (aspect != null)
						{
							string classPropertyValue = bq.GetClassPropertyValue<string>("BetType");
							int value = bq.GetPrimitivePropertyValue<int>("SelectedNameIndex", new int?(0)).Value;
							Dictionary<string, float> classPropertyValue2 = aspect.a().GetClassPropertyValue<Dictionary<string, float>>("RacingQuotasFor" + bq.GetClassPropertyValue<string>("Hopper" + value.ToString() + "Name"));
							bq.set_Item("Quota", classPropertyValue2[classPropertyValue]);
						}
					}
				}
			}
		}
	}

	// Token: 0x02000BBF RID: 3007
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x060044D0 RID: 17616 RVA: 0x001BC630 File Offset: 0x001BA830
		internal int b(KeyValuePair<string, int> A_0)
		{
			return A_0.Value;
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x001BC63C File Offset: 0x001BA83C
		internal string c(KeyValuePair<string, int> A_0)
		{
			return A_0.Key;
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x001BC648 File Offset: 0x001BA848
		internal int a(KeyValuePair<string, int> A_0)
		{
			return A_0.Value;
		}

		// Token: 0x04001C5F RID: 7263
		public static readonly e4g.b a = new e4g.b();

		// Token: 0x04001C60 RID: 7264
		public static Func<KeyValuePair<string, int>, int> b;

		// Token: 0x04001C61 RID: 7265
		public static Func<KeyValuePair<string, int>, string> c;

		// Token: 0x04001C62 RID: 7266
		public static Func<KeyValuePair<string, int>, int> d;
	}

	// Token: 0x02000BC0 RID: 3008
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x060044D4 RID: 17620 RVA: 0x001BC65C File Offset: 0x001BA85C
		internal bool d(KeyValuePair<string, Guid> A_0)
		{
			return A_0.Value == this.a[0];
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x001BC678 File Offset: 0x001BA878
		internal bool a(KeyValuePair<string, Guid> A_0)
		{
			return A_0.Value == this.a[1];
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x001BC694 File Offset: 0x001BA894
		internal bool b(KeyValuePair<string, Guid> A_0)
		{
			return A_0.Value == this.a[2];
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x001BC6B0 File Offset: 0x001BA8B0
		internal bool c(KeyValuePair<string, Guid> A_0)
		{
			return A_0.Value == this.a[3];
		}

		// Token: 0x04001C63 RID: 7267
		public List<Guid> a;
	}
}
