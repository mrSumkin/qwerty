using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000C73 RID: 3187
[eiz("CCBDEDE")]
[Serializable]
public sealed class c8g : cd2
{
	// Token: 0x060047CF RID: 18383 RVA: 0x001D7E38 File Offset: 0x001D6038
	private c8g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060047D0 RID: 18384 RVA: 0x001D7E44 File Offset: 0x001D6044
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060047D1 RID: 18385 RVA: 0x001D7E50 File Offset: 0x001D6050
	public override TimeSpan ge()
	{
		return TimeSpan.FromHours(20.0);
	}

	// Token: 0x060047D2 RID: 18386 RVA: 0x001D7E60 File Offset: 0x001D6060
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047D3 RID: 18387 RVA: 0x001D7E70 File Offset: 0x001D6070
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047D4 RID: 18388 RVA: 0x001D7E80 File Offset: 0x001D6080
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047D5 RID: 18389 RVA: 0x001D7E90 File Offset: 0x001D6090
	public c8g() : base(c8g.a)
	{
	}

	// Token: 0x060047D6 RID: 18390 RVA: 0x001D7EA0 File Offset: 0x001D60A0
	public c8g(bool A_0) : base(c8g.a)
	{
	}

	// Token: 0x060047D7 RID: 18391 RVA: 0x001D7EB0 File Offset: 0x001D60B0
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0) && A_0.v().b().Zone != null && (A_0.v().b().Zone.y8().StartsWith("cc") || A_0.c().b().StartsWith("xpbl_cc") || A_0.c().b().StartsWith("dun_cc")) && !A_0.c().b().Equals("dun_cc_sBombers") && !A_0.c().b().Equals("cc_arena");
	}

	// Token: 0x060047D8 RID: 18392 RVA: 0x001D7F70 File Offset: 0x001D6170
	protected override void gg(cyt A_0)
	{
		int? primitivePropertyValue = A_0.r().GetPrimitivePropertyValue<int>("dun_cc_sBombersKilled", new int?(0));
		if (primitivePropertyValue == null)
		{
			primitivePropertyValue = new int?(0);
		}
		if (A_0.r().GetClassPropertyValue<string>("dun_cc_sBombers_eventStatus").Equals("started"))
		{
			int? num = primitivePropertyValue;
			int num2 = 3;
			if (num.GetValueOrDefault() < num2 & num != null)
			{
				c5x c5x = A_0.v().b() as c5x;
				if (c5x != null)
				{
					A_0.r()["dun_cc_sBombers_eventStatus"] = "triggered";
					cav cav = new cav();
					cav.a(cuo.a.Next(2500, 4200));
					cav.a(new int?(2));
					cav.d(new int?(2));
					cav.e(new int?(2));
					cav.c(new int?(2));
					cav.b(new int?(15));
					bfq bfq = new bfq();
					bfq.c("EarthquakeShort");
					dtb dtb = new dtb();
					d9m d9m = new d9m();
					d9m.a(cuo.a.Next(1150, 2250));
					d9m.c().Add(cav);
					d9m.c().Add(bfq);
					amc aspect = c5x.GetAspect<amc>();
					if (aspect != null && !aspect.aa().IsInCombat)
					{
						List<string> a_ = new List<string>
						{
							"Найти укрытие!",
							"::Прикрывает голову.::",
							"Что за?..",
							"Что здесь происходит?",
							"Землетрясение, ЗЕМЛЕТРЯСЕНИЕ!",
							"Ой, ой, ой!",
							"Безликие?! Опять?",
							"Хватайтесь за что-нибудь!",
							"Берегите головы!",
							"А?!",
							"Сохраняйте спокойствие.",
							"Скоро всё закончится.",
							"Мы проходили и через худшее.",
							"::Разводит руками.::",
							"::Падает на колени.::",
							"::Смотрит вверх.::",
							"::Садится на корточки.::",
							"Это был взрыв или что?",
							"Какого чёрта?!",
							"Предвестие!"
						};
						List<string> a_2 = new List<string>
						{
							"Уф-ф! Уф-ф!",
							"::Визжит.::",
							"::Отскакивает в сторону.::",
							"ГР-Р-Р!"
						};
						List<string> a_3 = new List<string>
						{
							"::Шипит.::",
							"МЯ-Я-ЯУ!",
							"::Подскакивает от земли.::"
						};
						List<string> a_4 = new List<string>
						{
							"Вау... Куда ты пошёл, потолок?",
							"Земля... разверзлась и трещит.",
							"Те-хе-хе, он снова вращается!",
							"Я... лечу-у-у...",
							"::Пытается ухватиться за потолок.::",
							"Ха, земля дрожит... от меня."
						};
						List<string> a_5 = new List<string>
						{
							"Стоять на земле.",
							"Не паниковать.",
							"::Поднимает оружие.::",
							"Это снова *они*?",
							"Сохранять спокойствие, это всего лишь предвестие."
						};
						foreach (b0b b0b in c5x.Area.Entities)
						{
							c5x c5x2 = (c5x)b0b;
							amc aspect2 = c5x2.GetAspect<amc>();
							if (aspect2 != null && !c5x2.IsPlayer)
							{
								if (aspect2.aa().b(d8o.b))
								{
									if (aspect2.aa().Name != null)
									{
										if (aspect2.aa().Name.Contains("Подвижник"))
										{
											this.a(a_4, c5x2, d9m, true);
										}
										else if (aspect2.aa().Name.Contains("Чортист"))
										{
											List<string> a_6 = new List<string>
											{
												"::Скрещивает руки.::",
												"::Хватается за робу.::",
												"::Держится за одежду.::",
												"::Опускает капюшон.::",
												"Чорт защитит нас."
											};
											this.a(a_6, c5x2, d9m, true);
										}
										else if (aspect2.aa().Name.Contains("утант") || aspect2.aa().Name.Equals("Бут") || aspect2.aa().Name.Equals("Даблклик") || aspect2.aa().Name.Equals("Жук"))
										{
											List<string> a_7 = new List<string>
											{
												"Это ::хрипит:: снова...",
												"::Сохраняет спокойствие.::",
												"::Приседает.::",
												"Ещё одно? ::хрипит::",
												"Не рассыпайся.",
												"Добраться до ::хрипит:: угла.",
												"::Хватается за голову.::",
												"::Дрожит.::",
												"::Блюёт.::",
												"::Тихо бормочет.::"
											};
											this.a(a_7, c5x2, d9m, false);
										}
										else if (aspect2.aa().Name.Contains("КБР") || aspect2.aa().Name.Contains("Преториан") || aspect2.aa().Name.Contains("Протекторат") || aspect2.aa().Name.Contains("КорТех"))
										{
											this.a(a_5, c5x2, d9m, false);
										}
										else if (c5x2.qe() == new Guid("d01832b1-2414-48ae-b1e5-a3eb75bde115"))
										{
											List<string> a_8 = new List<string>
											{
												"Уф...",
												"Что тут."
											};
											this.a(a_8, c5x2, d9m, true);
										}
										else if (c5x2.qe() == new Guid("bf8a6e19-0de1-434c-87a7-6bd8f29cba69"))
										{
											this.a(new List<string>
											{
												"Давай-давай мне что-нибудь!"
											}, c5x2, d9m, true);
										}
										else if (c5x2.qe() == new Guid("f60bcb64-b4a1-4306-8212-c44bf085c794"))
										{
											this.a(new List<string>
											{
												"Эм... Что..."
											}, c5x2, d9m, true);
										}
										else if (c5x2.qe() == new Guid("62c31dd8-e1bc-42ff-8f99-a4bd23742cbf"))
										{
											this.a(new List<string>
											{
												"Это большое движение."
											}, c5x2, d9m, true);
										}
										else if (c5x2.qe() == new Guid("a0735df6-b749-42fc-9fe6-fa1c592c3b6f"))
										{
											this.a(new List<string>
											{
												"::Оглядывается по сторонам.:: Эй. Стоп. *Стоп*!"
											}, c5x2, d9m, true);
										}
										else if (c5x2.qe() == new Guid("ae9a9089-e9d6-4416-9b34-6ca5851683e3"))
										{
											this.a(new List<string>
											{
												"Чёрт! Берегите башку!"
											}, c5x2, d9m, true);
										}
										else if (c5x2.qe() == new Guid("c350d75b-2530-418b-9feb-01a5a96425de") || c5x2.qe() == new Guid("36d241af-3297-485f-b731-9729f0c19580") || c5x2.qe() == new Guid("e2660957-9277-4c02-90c9-1c03aaabd324") || c5x2.qe() == new Guid("3f43136e-0df0-48ce-a7db-eeb09711a49c") || c5x2.qe() == new Guid("f663a964-8fa3-4315-b0d6-4b8c76555be8") || c5x2.qe() == new Guid("d427212e-aadf-4415-92d2-0cefd611924e"))
										{
											List<string> a_9 = new List<string>
											{
												"Эй, брэ!",
												"Не, не, не!",
												"Уф!"
											};
											this.a(a_9, c5x2, d9m, true);
										}
										else if (c5x2 == new ar7(new Guid("0bd75ab3-f566-4b64-bd6a-161c8e7f63b1"), c5x.Area).ao() as c5x)
										{
											List<string> a_10 = new List<string>
											{
												"Что п-п-происходит?",
												"Что за п-пекло, это т-т-такое?",
												"М-м-моя лачуга! Н-нееет..."
											};
											this.a(a_10, c5x2, d9m, true);
										}
										else if (c5x2 == new ar7(new Guid("72c394b8-dfe9-463c-9cd0-29f83eac7aea"), c5x.Area).ao() as c5x)
										{
											List<string> a_11 = new List<string>
											{
												"::Прикусывает сигару и оглядывается по сторонам.::",
												"Что за...? Что это?"
											};
											this.a(a_11, c5x2, d9m, true);
										}
										else if (c5x2 == new ar7(new Guid("591601a6-8a3a-4f07-8aee-667f9c25464f"), c5x.Area).ao() as c5x)
										{
											List<string> a_12 = new List<string>
											{
												"::Занимает более устойчивую позицию.::",
												"::Сканирует область через окно.::"
											};
											this.a(a_12, c5x2, d9m, true);
										}
										else if (c5x2 == new ar7(new Guid("b92ca778-f933-4f0d-b030-e7ac09fbd8b9"), c5x.Area).ao() as c5x)
										{
											List<string> a_13 = new List<string>
											{
												"::Спокойно смотрит через окно.::",
												"Это... это пришло снизу."
											};
											this.a(a_13, c5x2, d9m, true);
										}
										else if (c5x2.qe() == new Guid("e8c45dd1-1257-47b0-8fe9-5687a70ad86e"))
										{
											this.a(new List<string>
											{
												"::Вздрагивает.::"
											}, c5x2, d9m, true);
										}
										else
										{
											this.a(a_, c5x2, d9m, false);
										}
									}
								}
								else if (c5x2.qe() == new Guid("2ea8386a-44a0-4546-90b8-5f8b1e8de4ad"))
								{
									List<string> list = new List<string>();
									if (A_0.c().b() == "cc14")
									{
										list.Add("::Фыркает.::");
									}
									else
									{
										list.Add("Ё-моё!");
										list.Add("Ну! ::Фыркает.::");
									}
									this.a(list, c5x2, d9m, true);
								}
								else if (aspect2.aa().Name.Contains("обака") && !aspect2.aa().b(d8o.b))
								{
									this.a(a_2, c5x2, d9m, true);
								}
								else if (aspect2.aa().Name.Contains("Кошка") && !aspect2.aa().b(d8o.b))
								{
									this.a(a_3, c5x2, d9m, true);
								}
								else if (aspect2.aa().Name.Contains("орбатый") || aspect2.aa().Name.Contains("утант"))
								{
									List<string> a_14 = new List<string>
									{
										"Хр-р-м-н...",
										"Р-р-а-а-а!",
										"::Защищает голову.:: Н-н-не..."
									};
									this.a(a_14, c5x2, d9m, false);
								}
							}
						}
					}
					dtb.ad().Add(new a4s(d9m, new ar7(c5x), new ar7(c5x), null));
					A_0.v().b().Zone.ActionManager.g9(dtb, atp.a);
					A_0.a(new bw0("dun_cc_sBombers", new euq(), 1));
				}
				return;
			}
		}
		A_0.r()["dun_cc_sBombers_eventStatus"] = "canceled";
	}

	// Token: 0x060047D9 RID: 18393 RVA: 0x001D8B1C File Offset: 0x001D6D1C
	private void a(List<string> A_0, c5x A_1, d9m A_2, bool A_3 = false)
	{
		if (A_3 || cuo.a.Next(0, 3) < 2)
		{
			us us = new us();
			us.a(A_0[cuo.a.Next(0, Enumerable.Count<string>(A_0))]);
			us.a(bvl.e);
			us.a(new Guid?(A_1.qe()));
			A_2.c().Add(us);
		}
	}

	// Token: 0x04001CA5 RID: 7333
	public new static readonly string a = "CCBombersDetonateExplosion";
}
