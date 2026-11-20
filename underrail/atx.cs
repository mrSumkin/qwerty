using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators.Items;

// Token: 0x020009D5 RID: 2517
[eiz("RCCFIS")]
[Serializable]
public sealed class atx : bdw, ISerializable
{
	// Token: 0x06003C4F RID: 15439 RVA: 0x0016488C File Offset: 0x00162A8C
	private atx(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C50 RID: 15440 RVA: 0x00164894 File Offset: 0x00162A94
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C51 RID: 15441 RVA: 0x00164898 File Offset: 0x00162A98
	public atx()
	{
	}

	// Token: 0x06003C52 RID: 15442 RVA: 0x001648A0 File Offset: 0x00162AA0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			bool flag = A_1.r().GetPrimitivePropertyValue<bool>("loc_rc_facelessProblemResolved", new bool?(false)).Value;
			bool value = A_1.r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value;
			int value2 = A_1.r().GetPrimitivePropertyValue<int>("loc_rcshop_deadfaceless", new int?(0)).Value;
			bool flag2 = A_1.r().GetPrimitivePropertyValue<bool>("loc_rc_facelessKilledBuzzerWhileRetreating", new bool?(false)).Value;
			bool value3 = A_1.r().GetPrimitivePropertyValue<bool>("npc_rcbuzzer_dead", new bool?(false)).Value;
			bool value4 = A_1.r().GetPrimitivePropertyValue<bool>("loc_rcshop_buzzerFreed", new bool?(false)).Value;
			TimeSpan? primitivePropertyValue = A_1.r().GetPrimitivePropertyValue<TimeSpan>("loc_rc_timeForCleanupAfterInvasion", null);
			bool value5 = A_1.r().GetPrimitivePropertyValue<bool>("loc_rc_cleanUpTimeSet", new bool?(false)).Value;
			bool value6 = A_1.r().GetPrimitivePropertyValue<bool>("loc_rc_rc1TidyUpDone", new bool?(false)).Value;
			bool value7 = A_1.r().GetPrimitivePropertyValue<bool>("loc_rc_rc2TidyUpDone", new bool?(false)).Value;
			bool value8 = A_1.r().GetPrimitivePropertyValue<bool>("loc_rc_rcShopTidyUpDone", new bool?(false)).Value;
			bool value9 = A_1.r().GetPrimitivePropertyValue<bool>("loc_rc_rc3TidyUpDone", new bool?(false)).Value;
			bool value10 = A_1.r().GetPrimitivePropertyValue<bool>("npc_rc_buzzer_movedToFrontDesk", new bool?(false)).Value;
			if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_rc_facelessMusicSet", new bool?(false)).Value)
			{
				if (!flag)
				{
					new dvn("RC2", "Faceless").ym(null, null, null);
					new dvn("RC3", "Faceless").ym(null, null, null);
					new dvn("RC_SHOP", "Faceless").ym(null, null, null);
					A_1.r()["loc_rc_facelessMusicSet"] = true;
				}
			}
			else if (flag)
			{
				new dvn("RC2", null).ym(null, null, null);
				new dvn("RC3", null).ym(null, null, null);
				new dvn("RC_SHOP", null).ym(null, null, null);
			}
			if (!flag && value2 < 3 && value)
			{
				A_1.r()["loc_rc_facelessProblemResolved"] = true;
				flag = true;
				A_1.r()["loc_rc_facelessKilledBuzzerWhileRetreating"] = true;
				flag2 = true;
			}
			if (flag || value2 >= 3)
			{
				if (!flag)
				{
					A_1.r()["loc_rc_facelessProblemResolved"] = true;
				}
				foreach (aud aud in A_0.Areas)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x = (c5x)b0b;
						if ((c5x.h.b != null && (c5x.h.b.aa().FactionId == asp.cc || c5x.h.b.aa().FactionId == asp.cf)) || (c5x.s.b is c7j && !string.IsNullOrEmpty(c5x.y8()) && c5x.y8().StartsWith("Faceless") && c5x.Layer == aju.x))
						{
							c5x.w();
							c5x.an();
						}
					}
					if (A_0.y8() == "rc2" && aud.y8() == "rc2")
					{
						c5x c5x2 = aud.a(new Guid("7b7e3822-d99f-49aa-8282-5e44f9e9006c")) as c5x;
						if (c5x2 != null && c5x2.j == cgy.b)
						{
							c5x2.w();
							c5x2.an();
							doq a_ = doq.a(Path.Combine(d5x.q(), "rc2_l2") + ".uzl");
							A_0.a(a_, 1, null);
						}
					}
				}
			}
			if (flag2 && !value3 && A_0.y8() == "rc_shop")
			{
				foreach (aud a_2 in A_0.Areas)
				{
					c5x c5x3 = new ar7(new Guid("500d552b-b2b0-4197-b08c-16b7b810d604"), a_2).ao() as c5x;
					if (c5x3 != null && c5x3.h.b != null && !c5x3.h.b.aa().Dead)
					{
						c5x3.h.b.aa().a(null, null, false);
					}
				}
			}
			if (flag && !value5)
			{
				A_1.r()["loc_rc_timeForCleanupAfterInvasion"] = A_1.p() + TimeSpan.FromMinutes(30.0);
				A_1.r()["loc_rc_cleanUpTimeSet"] = true;
			}
			if (flag && A_1.p() >= primitivePropertyValue)
			{
				if (!value10)
				{
					A_1.a(new bw0("rc_shop", new dq8(), 1));
					A_1.r()["npc_rc_buzzer_movedToFrontDesk"] = true;
				}
				foreach (aud aud2 in Enumerable.ToList<aud>(A_0.Areas))
				{
					e5g.a(aud2);
					foreach (b0b b0b2 in Enumerable.ToList<b0b>(aud2.Entities))
					{
						c5x c5x4 = (c5x)b0b2;
						if (c5x4.h.b != null && c5x4.h.b.aa().b(d8o.e))
						{
							if (!value3 && c5x4.h.b.aa().StatusEffects.a(clt.a))
							{
								clt clt = Enumerable.FirstOrDefault<clt>(c5x4.h.b.aa().StatusEffects.Get<clt>());
								if (clt != null && c5x4.y8() != "Kamikaze Bot")
								{
									c5x4.h.b.aa().StatusEffects.d(clt);
									c5x4.h.b.aa().c(asp.a);
									c5x4.h.b.aa().c(asp.co);
									c5x4.h.b.aa().c(asp.cl);
									c5x4.h.b.aa().FactionId = asp.co;
									c5x4.h.b.aa().HostilityBroadcastMode = c2n.c;
									if (c5x4.qe() == new Guid("845bc88c-b085-452c-af6f-27c35f013eee") && c5x4.t.b != null)
									{
										c5x4.t.b.y6()[ddq.ay] = new bt4("guard_entSentry");
									}
								}
								else if (c5x4.y8() == "Kamikaze Bot")
								{
									c5x4.w();
									c5x4.an();
								}
							}
							if (value3 && c5x4.h.b.aa().FactionId == asp.a3 && c5x4.h.b.aa().StatusEffects.a(clt.a))
							{
								c5x4.w();
								c5x4.an();
							}
						}
					}
				}
				if (A_0.y8() == "rc1" && !value6)
				{
					c5x c5x5 = new ar7(new Guid("84738ae3-9c07-4294-864d-181f60e0fd14"), A_0.n("rc1")).ao() as c5x;
					c5x c5x6 = new ar7(new Guid("bc4be459-f781-4e99-b91b-7a2e0147e953"), A_0.n("rc1")).ao() as c5x;
					c5x c5x7 = new ar7(new Guid("bc895f54-05e6-4747-ba29-ebe0ab36502a"), A_0.n("rc1")).ao() as c5x;
					c5x c5x8 = new ar7(new Guid("ba9e0fef-1881-40fa-bd15-632c7d57352a"), A_0.n("rc1")).ao() as c5x;
					if (c5x5 != null)
					{
						c5x5.w();
						c5x5.an();
					}
					if (c5x6 != null)
					{
						c5x6.w();
						c5x6.an();
					}
					if (c5x7 != null)
					{
						c5x7.w();
						c5x7.an();
					}
					if (c5x8 != null)
					{
						c5x8.w();
						c5x8.an();
					}
					A_1.r()["loc_rc_rc1TidyUpDone"] = true;
				}
				if (A_0.y8() == "rc2" && !value7)
				{
					c5x c5x9 = new ar7(new Guid("47520325-9253-4514-813d-5e07547463fc"), A_0.n("rc2")).ao() as c5x;
					c5x c5x10 = new ar7(new Guid("7beaf4b9-dc15-46e4-b9cc-428acd779330"), A_0.n("rc2")).ao() as c5x;
					c5x c5x11 = new ar7(new Guid("ebbb83cd-c1c4-48e5-85ad-dc72d94ba4e5"), A_0.n("rc2")).ao() as c5x;
					c5x c5x12 = new ar7(new Guid("3d03f261-e343-4f62-9091-29a57ef95825"), A_0.n("rc2")).ao() as c5x;
					c5x c5x13 = new ar7(new Guid("9fc2d403-c7a8-4cc5-9063-13e0558964b5"), A_0.n("rc2")).ao() as c5x;
					if (c5x9 != null)
					{
						c5x9.w();
						c5x9.an();
					}
					if (c5x10 != null)
					{
						c5x10.w();
						c5x10.an();
					}
					if (c5x11 != null)
					{
						c5x11.w();
						c5x11.an();
					}
					if (c5x12 != null)
					{
						c5x12.w();
						c5x12.an();
					}
					if (c5x13 != null)
					{
						c5x13.w();
						c5x13.an();
					}
					if (!value3)
					{
						doq a_3 = doq.a(Path.Combine(d5x.q(), "rc2_l" + 3.ToString()) + ".uzl");
						A_0.a(a_3, 1, null);
					}
					A_1.r()["loc_rc_rc2TidyUpDone"] = true;
				}
				if (A_0.y8() == "rc_shop" && !value8)
				{
					c5x c5x14 = new ar7(new Guid("54708ff6-5f69-4b3e-bde8-1dc3baaf61f6"), A_0.n("rc_shop2")).ao() as c5x;
					c5x c5x15 = new ar7(new Guid("4fd8cd3f-b24d-4572-b3c3-f1f2700093d6"), A_0.n("rc_shop2")).ao() as c5x;
					if (c5x14 != null)
					{
						c5x14.w();
						c5x14.an();
					}
					if (c5x15 != null)
					{
						c5x15.w();
						c5x15.an();
					}
					if (!value3)
					{
						doq a_4 = doq.a(Path.Combine(d5x.q(), "rc_shop_l" + 3.ToString()) + ".uzl");
						A_0.a(a_4, 1, null);
						(A_1.ac() as bv9).a(asp.cl, asp.co, h.e, new h?(h.a), true, false, false);
						foreach (c5x c5x16 in new List<c5x>
						{
							new ar7(new Guid("b62b99f5-d691-4cd2-b02d-2f1f077d1bd8"), A_0.n("rc_shop1")).ao() as c5x,
							new ar7(new Guid("14abf888-5b06-44bd-aa3d-3a42ad700693"), A_0.n("rc_shop1")).ao() as c5x,
							new ar7(new Guid("d517ae55-82d5-4a32-b2fe-f3b2b9f5c734"), A_0.n("rc_shop1")).ao() as c5x,
							new ar7(new Guid("a2e513dc-cf30-4ebd-8366-a9a461de2bb0"), A_0.n("rc_shop1")).ao() as c5x,
							new ar7(new Guid("9acb26ed-a145-41ab-baf0-eda6680c5052"), A_0.n("rc_shop1")).ao() as c5x,
							new ar7(new Guid("bd0af48a-fabe-41c2-81c3-84cb676b9600"), A_0.n("rc_shop1")).ao() as c5x,
							new ar7(new Guid("a8442537-6393-443e-8733-41d1be04df44"), A_0.n("rc_shop1")).ao() as c5x,
							new ar7(new Guid("581a6346-604c-4e2e-83e2-6a54566fe729"), A_0.n("rc_shop1")).ao() as c5x
						})
						{
							c3g c3g = c5x16.GetAspect<c3g>();
							if (c3g == null)
							{
								c3g = new c3g(c5x16);
								c5x16.SetAspect<c3g>(c3g);
							}
							c3g.d().Add(asp.co);
							c3g.d().Add(asp.cl);
							c7j c7j = c5x16.GetAspect<bim>() as c7j;
							if (c7j != null)
							{
								c7j.ContainerProtectionMode = ctz.d;
							}
							if (c5x16.GetAspect<ery>() == null)
							{
								ery aspect = new ery(c5x16);
								c5x16.SetAspect<ery>(aspect);
							}
							List<xs> list = new List<xs>();
							xs xs = new xs();
							df8 df = new df8(ItemRange.Component_Electronic);
							df.nc(15);
							df.na(10);
							xs.Generator = df;
							xs.Amount = cuo.a.Next(2, 5);
							xs.Chance = 0.6f;
							list.Add(xs);
							xs xs2 = new xs();
							df8 df2 = new df8(ItemRange.EnergyCells);
							df2.nc(8);
							df2.na(1);
							xs2.Generator = df2;
							xs2.Amount = cuo.a.Next(1, 3);
							xs2.Chance = 0.3f;
							list.Add(xs2);
							xs xs3 = new xs();
							df8 df3 = new df8(ItemRange.Blueprints_ElectronicUtility);
							df3.nc(12);
							df3.na(1);
							xs3.Generator = df3;
							xs3.Amount = 1;
							xs3.Chance = 0.2f;
							list.Add(xs3);
							foreach (xs xs4 in list)
							{
								List<bmd> list2 = xs4.a(null, null, null, null);
								if (list2 != null && Enumerable.Any<bmd>(list2))
								{
									c7j.ItemContainer.z2().AddRange(Enumerable.Select<bmd, coh>(Enumerable.Where<bmd>(list2, new Func<bmd, bool>(atx.a.a.b)), new Func<bmd, coh>(atx.a.a.a)));
								}
							}
						}
						c5x c5x17 = new ar7(new Guid("86a10d90-4d4d-4668-8856-5d92a884bcf3"), A_0.n("rc_shop1")).ao() as c5x;
						if (c5x17 != null && c5x17.GetAspect<c3g>() == null)
						{
							c3g aspect2 = new c3g(c5x17);
							c5x17.SetAspect<c3g>(aspect2);
						}
					}
					A_1.r()["loc_rc_rcShopTidyUpDone"] = true;
				}
				if (A_0.y8() == "rc3" && !value9)
				{
					A_1.r()["loc_rc_rc2TidyUpDone"] = true;
				}
			}
			if (A_1.r().GetPrimitivePropertyValue<bool>("npc_rc_herve_TrainHeistCompleted", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_rc_herve_toldNoTrainSearch", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("lo_lu-b29_trainBlewUp", new bool?(false)).Value)
			{
				TimeSpan? primitivePropertyValue2 = A_1.r().GetPrimitivePropertyValue<TimeSpan>("loc_rc1_trainSuppliesArrivalTime", null);
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_rc1_trainSupplies_timeSet", new bool?(false)).Value)
				{
					A_1.r()["loc_rc1_trainSuppliesArrivalTime"] = A_1.p() + TimeSpan.FromHours(10.0);
					A_1.r()["loc_rc1_trainSupplies_timeSet"] = true;
				}
				if (A_0.y8() == "rc1" && !A_1.r().GetPrimitivePropertyValue<bool>("loc_rc1_trainSupplies_arrived", new bool?(false)).Value && A_1.p() >= primitivePropertyValue2)
				{
					doq a_5 = doq.a(Path.Combine(d5x.q(), "rc1_l4") + ".uzl");
					A_0.a(a_5, 1, null);
					A_1.r()["loc_rc1_trainSupplies_arrived"] = true;
				}
			}
		}
	}

	// Token: 0x020009D6 RID: 2518
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003C55 RID: 15445 RVA: 0x00165BB4 File Offset: 0x00163DB4
		internal bool b(bmd A_0)
		{
			return A_0.Item != null;
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x00165BC0 File Offset: 0x00163DC0
		internal coh a(bmd A_0)
		{
			return A_0.Item;
		}

		// Token: 0x04001B98 RID: 7064
		public static readonly atx.a a = new atx.a();

		// Token: 0x04001B99 RID: 7065
		public static Func<bmd, bool> b;

		// Token: 0x04001B9A RID: 7066
		public static Func<bmd, coh> c;
	}
}
