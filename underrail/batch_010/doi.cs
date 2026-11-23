using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000BBC RID: 3004
[euj]
public class doi
{
	// Token: 0x060044A4 RID: 17572 RVA: 0x001B801C File Offset: 0x001B621C
	[ayh("LUWAJAPP")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["loc_lux_uwa_allowedEntry"] = true;
		}
	}

	// Token: 0x060044A5 RID: 17573 RVA: 0x001B805C File Offset: 0x001B625C
	[ayh("LUWAJROB")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v().b() is c5x && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_azif_ledYouInside", new bool?(false)).Value)
		{
			foreach (b0b b0b in serviceOrThrow.aqw().a().ab4(new string[]
			{
				"lux_uwa_oculus"
			}))
			{
				((c5x)b0b).ae = new float?((float)1);
			}
		}
	}

	// Token: 0x060044A6 RID: 17574 RVA: 0x001B8130 File Offset: 0x001B6330
	[ayh("LUWAJETR")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("71caa8ca-9af4-4eb5-afb0-da93ba11500c"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("1fe6221c-8d96-4487-9626-3a1387ab20ec"), c5x.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("7716efe2-600e-4a60-b662-5f4dc125866a"), c5x.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("f4eedc64-e18b-4aa7-b1ef-58ad8ba948b9"), c5x.Area).ao() as c5x;
				c5x c5x6 = new ar7(new Guid("cd23ba6c-95e4-4dc8-bbdc-05693531b7d7"), c5x.Area).ao() as c5x;
				c5x c5x7 = new ar7(new Guid("580c1c49-b9a9-432a-881a-0a0fb3cd3abd"), c5x.Area).ao() as c5x;
				if (c5x2 != null && c5x3 != null && c5x4 != null && c5x5 != null)
				{
					serviceOrThrow.aqu().r()["npc_lux_lunaticSynesthete_endRitual"] = true;
					c5x7.w();
					c5x7.an();
					a0l.a(c5x, "playerRitualEnd", true);
					c5x.ah();
					a0l.a(c5x2, "zealot_1_btm", true);
					c5x2.ah();
					a0l.a(c5x3, "p1", true);
					c5x3.ah();
					a0l.a(c5x4, "p3_1", true);
					c5x4.ah();
					a0l.a(c5x5, "syn_btm", true);
					c5x5.ah();
					c5x5.h.b.ap = null;
					c5x2.h.b.ap = null;
					c5x3.h.b.ap = null;
					c5x2.t.b.y6()["VigilanceSettings"] = new exw(d6n.b, 0.0, true, null);
					c5x3.t.b.y6()["VigilanceSettings"] = new exw(d6n.b, 0.0, true, null);
					c5x4.t.b.y6()["VigilanceSettings"] = new exw(d6n.b, 0.0, true, null);
					c5x5.t.b.y6()["VigilanceSettings"] = new exw(d6n.b, 0.0, true, null);
					c5x2.t.b.y6()[ddq.ay] = "zealot_1_btm";
					c5x3.t.b.y6()[ddq.ay] = "p1";
					c5x5.t.b.y6()[ddq.ay] = "syn_btm";
					c5x6.ae = new float?((float)1);
					c5x6.s.b.g(true);
				}
				ah7 ah = serviceOrThrow.aqw().i("ForceWallLantern");
				if (ah != null)
				{
					ah.Enabled = false;
					ah.d();
				}
				List<b0b> list = serviceOrThrow.aqw().a().ab4(new string[]
				{
					"lux-uwa_forceField"
				});
				foreach (b0b b0b in list)
				{
					c5x c5x8 = (c5x)b0b;
					c5x8.RemoveAspect<aru>();
					ad6 ad = new ad6(c5x8);
					ad.b(1.0);
					ad.c(0.0);
					ad.a(0.0005);
					ad6 a_ = ad;
					c5x8.Zone.ActionManager.g9(a_, atp.a);
				}
				list.Clear();
				list = serviceOrThrow.aqw().a().ab4(new string[]
				{
					"lux-uwa_usables"
				});
				foreach (b0b b0b2 in list)
				{
					((c5x)b0b2).an();
				}
				this.a();
			}
		}
	}

	// Token: 0x060044A7 RID: 17575 RVA: 0x001B85BC File Offset: 0x001B67BC
	[ayh("LUWAJRIAOA")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("71caa8ca-9af4-4eb5-afb0-da93ba11500c"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("1fe6221c-8d96-4487-9626-3a1387ab20ec"), c5x.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("f4eedc64-e18b-4aa7-b1ef-58ad8ba948b9"), c5x.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("7716efe2-600e-4a60-b662-5f4dc125866a"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					c5x2.h.b.ap = null;
				}
				if (c5x3 != null)
				{
					c5x3.h.b.ap = null;
				}
				if (c5x4 != null)
				{
					c5x4.h.b.ap = null;
				}
				if (c5x5 != null)
				{
					c5x5.h.b.ap = null;
				}
			}
		}
	}

	// Token: 0x060044A8 RID: 17576 RVA: 0x001B86F4 File Offset: 0x001B68F4
	[ayh("LUWAJLDD")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.h.b.aa().BaseAbilities.Agility <= 8)
			{
				cwt cwt = new cwt();
				cwt.l = true;
				cwt.p = true;
				cwt.y = "{2} получает ";
				cwt.b = true;
				if (c5x.h.b.aa().BaseAbilities.Agility <= 5)
				{
					cwt.e = true;
				}
				else
				{
					cwt.e = false;
				}
				cwt.w = false;
				a1q a_ = new a1q(DamageType.Mechanical, 75, 125);
				cwt.f.Add(euf.a(a_, 1.0));
				c5x.h.b.aa().Defense.a(cwt);
			}
		}
	}

	// Token: 0x060044A9 RID: 17577 RVA: 0x001B87F8 File Offset: 0x001B69F8
	[ayh("LUWAJDS")]
	public void h(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("f4eedc64-e18b-4aa7-b1ef-58ad8ba948b9"), c5x.Area).ao() as c5x;
				if (c5x2 != null && !c5x2.h.b.aa().d(CharacterImmunities.Daze))
				{
					eok eok = Enumerable.FirstOrDefault<eok>(c5x2.h.b.aa().StatusEffects.Get<eok>());
					if (eok == null)
					{
						c5x2.h.b.aa().StatusEffects.a(new eok(0), false, false, false);
						return;
					}
					eok.Duration = 0;
					eok.ad();
				}
			}
		}
	}

	// Token: 0x060044AA RID: 17578 RVA: 0x001B88D8 File Offset: 0x001B6AD8
	[ayh("LUWAJIPR")]
	public void g(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("45eb4468-54f6-4a9e-bcd2-6bd531bed10f"), c5x.Area).ao() as c5x;
				if (c5x2 != null && c5x2.t != null)
				{
					c5x2.t.b.y6()[ddq.k] = new List<string>
					{
						"p1_1",
						"p1_2",
						"p1_3"
					};
				}
			}
		}
	}

	// Token: 0x060044AB RID: 17579 RVA: 0x001B898C File Offset: 0x001B6B8C
	[ayh("LUWAJHSD")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["npc_lux_synesthete_dead"] = true;
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_lux_lunaticSynesthete_startRitual", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_lux_lunaticSynesthete_endRitual", new bool?(false)).Value)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null)
				{
					c5x c5x2 = new ar7(new Guid("71caa8ca-9af4-4eb5-afb0-da93ba11500c"), c5x.Area).ao() as c5x;
					c5x c5x3 = new ar7(new Guid("1fe6221c-8d96-4487-9626-3a1387ab20ec"), c5x.Area).ao() as c5x;
					if (c5x2 != null && c5x2.t.b != null && c5x2.h.b != null)
					{
						c5x2.t.b.y6()[ddq.ay] = "zealot_1_btm";
						c5x2.h.b.ap = null;
					}
					if (c5x3 != null && c5x3.t.b != null && c5x3.h.b != null)
					{
						c5x3.h.b.ap = null;
						c5x3.t.b.y6()[ddq.ay] = "p1";
					}
					ah7 ah = serviceOrThrow.aqw().i("ForceWallLantern");
					if (ah != null)
					{
						ah.Enabled = false;
						ah.d();
					}
					List<b0b> list = serviceOrThrow.aqw().a().ab4(new string[]
					{
						"lux-uwa_forceField"
					});
					foreach (b0b b0b in list)
					{
						c5x c5x4 = (c5x)b0b;
						c5x4.RemoveAspect<aru>();
						ad6 ad = new ad6(c5x4);
						ad.b(1.0);
						ad.c(0.0);
						ad.a(0.0005);
						ad6 a_ = ad;
						c5x4.Zone.ActionManager.g9(a_, atp.a);
					}
					list.Clear();
					list = serviceOrThrow.aqw().a().ab4(new string[]
					{
						"lux-uwa_usables"
					});
					foreach (b0b b0b2 in list)
					{
						((c5x)b0b2).an();
					}
					this.a();
				}
			}
		}
	}

	// Token: 0x060044AC RID: 17580 RVA: 0x001B8C84 File Offset: 0x001B6E84
	private void a()
	{
		c5x c5x = bpo.GetServiceOrThrow<cnk>().aqu().v().b() as c5x;
		if (c5x != null)
		{
			d02 service = bpo.GetService<d02>();
			c5x c5x2 = new ar7(new Guid("47bf7561-2221-4920-848e-6e4c0f4a32de"), c5x.Zone.Areas[1]).ao() as c5x;
			c7j c7j = c5x2.GetAspect<bim>() as c7j;
			if (service != null)
			{
				List<ya> list = new List<ya>();
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					foreach (ya ya in c5x.Zone.Areas[1].Triggers)
					{
						if (ya.Name.Contains("PlayerOnCliffTrigger") && d4n.b.a8().Location.X >= (float)ya.Location.X && d4n.b.a8().Location.Y >= (float)ya.Location.Y && d4n.b.a8().Location.X <= (float)(ya.Size.c + ya.Location.X) && d4n.b.a8().Location.Y <= (float)(ya.Size.d + ya.Location.Y))
						{
							a0l.a(d4n.b.a8(), "Fall", true);
							d4n.b.a8().ah();
						}
					}
				}
				foreach (ya ya2 in c5x.Zone.Areas[1].Triggers)
				{
					if (ya2.Name.Contains("ClimbNpc1") || ya2.Name.Contains("ClimbNpc2") || ya2.Layer == aju.x)
					{
						list.Add(ya2);
					}
				}
				if (c7j != null)
				{
					ya ya3 = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(c5x.Zone.Areas[1].Triggers, new Func<ya, bool>(doi.a.a.a)));
					bool flag = false;
					if (ya3 != null)
					{
						for (int i = ya3.Location.X; i <= ya3.Location.X + ya3.Size.c; i++)
						{
							for (int j = ya3.Location.Y; j <= ya3.Location.Y + ya3.Size.d; j++)
							{
								ak1 ak = c5x.Zone.Areas[1].b(i, j);
								if (ak != null)
								{
									foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
									{
										c5x c5x3 = (c5x)b0b;
										if (c5x3.s.b != null && c5x3 != c5x)
										{
											if (c5x3.s.b is c7j)
											{
												c7j c7j2 = c5x3.GetAspect<bim>() as c7j;
												using (List<coh>.Enumerator enumerator4 = Enumerable.ToList<coh>(c7j2.ItemContainer.z2()).GetEnumerator())
												{
													while (enumerator4.MoveNext())
													{
														coh coh = enumerator4.Current;
														if (coh.Definition is x2 || (coh.Lootable && coh.Stealable))
														{
															c7j2.ItemContainer.z5(coh);
															c7j.ItemContainer.z3(coh, true);
															flag = true;
														}
													}
													goto IL_469;
												}
												goto IL_403;
											}
											goto IL_403;
											IL_469:
											if (c5x3.Layer == aju.x && !c5x3.a("lux-uwa_forceField"))
											{
												c5x3.w();
												c5x3.an();
												continue;
											}
											continue;
											IL_403:
											if (!c5x3.a("thrownSpear") && !c5x3.a("thrownNet"))
											{
												goto IL_469;
											}
											mk mk = Enumerable.FirstOrDefault<mk>(Enumerable.OfType<mk>(c5x3.s.b.s()));
											if (mk != null)
											{
												c7j.ItemContainer.z3(Enumerable.FirstOrDefault<coh>(mk.StaticItems.z2()), true);
												flag = true;
												goto IL_469;
											}
											goto IL_469;
										}
									}
								}
							}
						}
						if (flag)
						{
							c5x2.ae = new float?((float)1);
							c7j.g(true);
						}
					}
				}
				foreach (ya ya4 in list)
				{
					ya4.o();
				}
			}
		}
	}

	// Token: 0x02000BBD RID: 3005
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060044B0 RID: 17584 RVA: 0x001B9298 File Offset: 0x001B7498
		internal bool a(ya A_0)
		{
			return A_0.Name == "PlayerOnCliffTrigger";
		}

		// Token: 0x04001C5D RID: 7261
		public static readonly doi.a a = new doi.a();

		// Token: 0x04001C5E RID: 7262
		public static Func<ya, bool> b;
	}
}
