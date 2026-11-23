using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000A2A RID: 2602
[eiz("RNDEXPBLDADSEZT")]
[Serializable]
public sealed class bwz : bdw, ISerializable
{
	// Token: 0x06003DD2 RID: 15826 RVA: 0x001743C4 File Offset: 0x001725C4
	private bwz(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("RNDEXPBLDADSEZT:FD", typeof(c2w)) as c2w);
		this.b = A_0.GetString("RNDEXPBLDADSEZT:RC");
	}

	// Token: 0x06003DD3 RID: 15827 RVA: 0x00174400 File Offset: 0x00172600
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("RNDEXPBLDADSEZT:FD", this.a);
		info.AddValue("RNDEXPBLDADSEZT:RC", this.b);
	}

	// Token: 0x06003DD4 RID: 15828 RVA: 0x00174424 File Offset: 0x00172624
	public bwz()
	{
	}

	// Token: 0x06003DD5 RID: 15829 RVA: 0x0017442C File Offset: 0x0017262C
	public bwz(c2w A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06003DD6 RID: 15830 RVA: 0x00174444 File Offset: 0x00172644
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"xpbl_ww_DragNDrop_exit"
				})) as c5x;
				if (c5x != null && c5x.s.b != null && c5x.s.b.s().Count < 1)
				{
					A_1.r()["loc_cvw_dragAndDrop_exists"] = true;
					c5x.s.b.s().Add(new e68
					{
						Destination = new c2w(A_1.r().GetClassPropertyValue<string>("frag_xpbl_ww_dragNDrop_location"), "DnD_exit")
					});
				}
			}
			if ((A_1.ac() as bv9).abu(asp.a, asp.fk).a == h.a)
			{
				return;
			}
			TimeSpan? primitivePropertyValue = A_1.r().GetPrimitivePropertyValue<TimeSpan>("loc_xpbl_ww_dragNDropRandomEventTimer", null);
			DateTime t = new DateTime(DateTime.Now.Year, 9, 16);
			DateTime t2 = new DateTime(DateTime.Now.Year, 10, 7);
			if (primitivePropertyValue == null)
			{
				A_1.r()["loc_xpbl_ww_dragNDropRandomEventTimer"] = A_1.p() + TimeSpan.FromMinutes(15.0);
				if (DateTime.Today >= t && DateTime.Today <= t2 && cuo.a.Next(1, 10) > 3)
				{
					A_1.r()["loc_cvw_dragAndDrop_eventType"] = 8;
				}
				else
				{
					A_1.r()["loc_cvw_dragAndDrop_eventType"] = cuo.a.Next(1, 7);
					this.a(A_1);
				}
				A_1.r()["loc_cvw_dragAndDrop_shouldRefreshEvent"] = true;
				return;
			}
			if (primitivePropertyValue <= A_1.p() && dh7.a != null && dh7.a.b != null && !dh7.a.b.StartsWith("xpbl_ww_dragNDrop") && dh7.a.c != null && !dh7.a.c.StartsWith("xpbl_ww_dragNDrop"))
			{
				A_1.r()["loc_xpbl_ww_dragNDropRandomEventTimer"] = A_1.p() + TimeSpan.FromMinutes(15.0);
				A_1.r()["loc_cvw_dragAndDrop_eventType"] = cuo.a.Next(1, 7);
				A_1.r()["loc_cvw_dragAndDrop_shouldRefreshEvent"] = true;
				this.a(A_1);
				return;
			}
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null && serviceOrThrow.aqu() != null && A_0.y8() == "Xpbl_ww_DragNDrop" && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cvw_dragAndDrop_shouldRefreshEvent", new bool?(false)).Value)
			{
				this.b(d);
				this.a(serviceOrThrow);
				A_1.r()["loc_cvw_dragAndDrop_shouldRefreshEvent"] = false;
				int value = A_1.r().GetPrimitivePropertyValue<int>("loc_cvw_dragAndDrop_eventType", new int?(2)).Value;
				if (value > 1)
				{
					doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_ww_dragNDrop_l" + value.ToString()) + ".uzl");
					A_0.a(a_, 1, null);
					this.a(d);
				}
				d85 d2 = (Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"dnd_menu"
				})) as c5x).GetAspect<bim>() as d85;
				c5x a_2 = new ar7(new Guid("c33ecb4b-5215-4526-8645-75b46edb48fc"), A_0.n("xpbl_ww_dragNDrop")).ao() as c5x;
				if (d2 != null)
				{
					d2.a().Clear();
				}
				switch (value)
				{
				case 2:
					this.a(true, a_2);
					d2.a().Add("Тяни-Толкай - место для оттяга. Меню состоит как из крепких напитков, так и горячительных с кислинкой. Ну, по крайней мере, так написано.");
					return;
				case 3:
					this.a(true, a_2);
					d2.a().Add("Тяни-Толкай - верх силы. Коктейли с чисто крутыми названиями.");
					return;
				case 4:
					this.a(false, a_2);
					d2.a().Add("Тяни-Толкай - искусство выпивки. Простенькие названия варева, также могут накинуть.");
					return;
				case 5:
					this.a(true, a_2);
					this.a(d, "draganddrop_pirates");
					d2.a().Add("Тяни-Толка -> пати дло МЁР чирных у-у-угррей !!! всё бухло на Т меню !!!");
					return;
				case 6:
					this.a(true, a_2);
					this.a(d, "draganddrop_protectorate");
					d2.a().Add("Тяни-Толкай - стальное нутро. Меню содержит напитки, достойные тех, кто берёт на себя тяжёлую работу.");
					return;
				case 8:
				{
					this.a(true, a_2);
					string classPropertyValue = A_1.r().GetClassPropertyValue<string>("loc_cvw_dnd_newFestName");
					if (classPropertyValue == "Beer Fest")
					{
						d2.a().Add("Праздник самогона! Иногда нужно ценить то, откуда всё произошло - и это самогон, определённо!");
						return;
					}
					if (classPropertyValue == "Hardcore Drop")
					{
						d2.a().Add("Тяни-Толкай - Хардкор Пропасть! Думаете, у вас есть всё, что нужно? Попробуйте САМОГОН, которое мы только что привезли.");
						return;
					}
					if (classPropertyValue == "No Cocktails")
					{
						d2.a().Add("Тяни-Толкай - Нет Коктейлям. Вы правильно поняли, сегодня время самогона!");
						return;
					}
					if (!(classPropertyValue == "One Off Week"))
					{
						d2.a().Add("Тяни-Толкай - Водоварение! Мы мешаем это с САМОГОНОМ!");
						return;
					}
					d2.a().Add("Тяни-Толкай - Неделя Запоя! Сегодня вечером и надолго мы вносим в меню кое-что новое! Самогон, самогон, самогон и ещё раз самогон!");
					return;
				}
				}
				this.a(false, a_2);
				d2.a().Add("Тяни-Толкай - тащи их все. Меню наполнено всевозможными коктейлями.");
			}
		}
	}

	// Token: 0x06003DD7 RID: 15831 RVA: 0x00174A1C File Offset: 0x00172C1C
	private void a(bool A_0, c5x A_1)
	{
		if (A_1 != null)
		{
			t6 aspect = A_1.GetAspect<t6>();
			if (aspect != null)
			{
				if (A_0)
				{
					aspect.a(true);
					return;
				}
				aspect.a(false);
			}
		}
	}

	// Token: 0x06003DD8 RID: 15832 RVA: 0x00174A54 File Offset: 0x00172C54
	private void b(d60 A_0)
	{
		if (A_0 != null)
		{
			List<b0b> list = A_0.ab4(new string[]
			{
				"draganddrop_event"
			});
			if (list != null)
			{
				foreach (b0b b0b in list)
				{
					b0b.w();
					b0b.an();
				}
			}
		}
	}

	// Token: 0x06003DD9 RID: 15833 RVA: 0x00174AD0 File Offset: 0x00172CD0
	private void a(d60 A_0)
	{
		if (A_0 != null)
		{
			List<b0b> list = A_0.ab4(new string[]
			{
				"draganddrop_event"
			});
			if (list != null)
			{
				foreach (b0b b0b in list)
				{
					if (cuo.a.Next(0, 3) < 2)
					{
						bm6 aspect = b0b.GetAspect<bm6>();
						if (aspect != null)
						{
							aspect.y6()[ddq.b2] = true;
							aspect.y6()[ddq.b4] = cuo.a.Next(2000, 11000);
						}
					}
				}
			}
		}
	}

	// Token: 0x06003DDA RID: 15834 RVA: 0x00174B9C File Offset: 0x00172D9C
	private void a(cyt A_0)
	{
		int value = A_0.r().GetPrimitivePropertyValue<int>("loc_cvw_dragAndDrop_eventType", new int?(2)).Value;
		if (value != 5 && value != 6)
		{
			return;
		}
		if (value == 5 && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value && (A_0.r().GetClassPropertyValue<string>("frag_xpbl_ww_dragNDrop_location").Equals("cvw29") || A_0.r().GetClassPropertyValue<string>("frag_xpbl_ww_dragNDrop_location").Equals("cvw5")))
		{
			return;
		}
		if (value == 6 && !A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_pz2_wipedOut", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value && (A_0.r().GetClassPropertyValue<string>("frag_xpbl_ww_dragNDrop_location").Equals("cvw12") || A_0.r().GetClassPropertyValue<string>("frag_xpbl_ww_dragNDrop_location").Equals("cvw14")))
		{
			return;
		}
		A_0.r()["loc_cvw_dragAndDrop_eventType"] = cuo.a.Next(1, 5);
	}

	// Token: 0x06003DDB RID: 15835 RVA: 0x00174D7C File Offset: 0x00172F7C
	private void a(d60 A_0, string A_1)
	{
		if (A_0 != null)
		{
			foreach (b0b b0b in A_0.ab4(new string[]
			{
				A_1
			}))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null)
				{
					c5x.h.b.aa().Gear.j()[WeaponKey.Secondary].b(null);
					c5x.h.b.aa().Offense.a(WeaponKey.Secondary);
				}
			}
		}
	}

	// Token: 0x06003DDC RID: 15836 RVA: 0x00174E38 File Offset: 0x00173038
	private void a(cnk A_0)
	{
		if (A_0 != null && A_0.aqu() != null)
		{
			c5x c5x = A_0.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("da4ad34a-ac6f-450d-aee8-3a54ec2859fe"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					eiw eiw = new eiw();
					eiw.a(c5x2.Area.y8());
					eiw.a(new Guid?(c5x2.qe()));
					eiw.ym(c5x2, null, null);
				}
			}
		}
	}

	// Token: 0x04001BA7 RID: 7079
	private c2w a;

	// Token: 0x04001BA8 RID: 7080
	private string b;
}
