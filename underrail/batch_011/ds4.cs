using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules;

// Token: 0x02000B19 RID: 2841
[eiz("XPBLSCSJ")]
[Serializable]
public sealed class ds4 : cze, ISerializable
{
	// Token: 0x060041A8 RID: 16808 RVA: 0x00194364 File Offset: 0x00192564
	private ds4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041A9 RID: 16809 RVA: 0x00194370 File Offset: 0x00192570
	public ds4()
	{
	}

	// Token: 0x060041AA RID: 16810 RVA: 0x0019437C File Offset: 0x0019257C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow2 != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_finishedScanningSuccessfully", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_scanStarted", new bool?(false)).Value;
			if (c5x != null && !value && !value2 && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_insideScanArea", new bool?(false)).Value)
			{
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_accessDenied", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_implantedChip_PhilBridges", new bool?(false)).Value;
				bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_scanCompleted", new bool?(false)).Value;
				bool value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_waitingForItems", new bool?(false)).Value;
				bool value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_waitingToLeave", new bool?(false)).Value;
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("loc_xpbl_sc_waitingTime", null);
				TimeSpan? primitivePropertyValue2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("loc_xpbl_sc_putAwayItemsTime", null);
				coh coh = Enumerable.FirstOrDefault<coh>(c5x.h.b.aa().Bag.b("plot.xpbl_philsArm"));
				using (List<coh>.Enumerator enumerator = c5x.h.b.aa().Bag.z2().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Definition.a7().GetPrimitivePropertyValue<bool>(dii.f, new bool?(false)).Value)
						{
							flag2 = true;
							break;
						}
					}
				}
				if (coh != null)
				{
					flag = true;
				}
				if (primitivePropertyValue == null)
				{
					serviceOrThrow.aqu().r()["loc_xpbl_sc_waitingTime"] = serviceOrThrow.aqu().p() + TimeSpan.FromSeconds(6.0);
					primitivePropertyValue = new TimeSpan?(serviceOrThrow.aqu().p() + TimeSpan.FromSeconds(6.0));
				}
				c5x c5x2 = new ar7(new Guid("5e177c71-5e72-4eb5-9ab6-a678e87007e4"), c5x.Area).ao() as c5x;
				bu6 service = bpo.GetService<bu6>();
				if (c5x2 != null)
				{
					us us = new us();
					us.a(new Guid?(c5x2.qe()));
					us.a("Пожалуйста, стойте вас сканирует биосканер...");
					us us2 = us;
					us us3 = new us();
					us3.a(new Guid?(c5x2.qe()));
					us3.a("Не удалось идентифицировать субъект. Доступ закрыт. Служба безопасности уведомлена.");
					us us4 = us3;
					us us5 = new us();
					us5.a(new Guid?(c5x2.qe()));
					us5.a("Не обнаружено никаких патогенов или опасных веществ. Доступ разрешён.");
					us us6 = us5;
					us us7 = new us();
					us7.a(new Guid?(c5x2.qe()));
					us7.a("Не обнаружено никаких патогенов или опасных веществ. Доступ разрешён. Ваши вещи были отправлены в дезактивационный отсек.");
					us us8 = us7;
					us us9 = new us();
					us9.a(new Guid?(c5x2.qe()));
					us9.a("Обнаружено опасное вещество. Пожалуйста, положите ваши вещи в ближайший контейнер и снова встаньте под биосканер.");
					us us10 = us9;
					us us11 = new us();
					us11.a(new Guid?(c5x2.qe()));
					us11.a("Обнаружены следы опасного вещества. Пожалуйста, положите ваши вещи в ближайший контейнер и снова встаньте под биосканер.");
					us us12 = us11;
					us us13 = new us();
					us13.a(new Guid?(c5x2.qe()));
					us13.a("Пожалуйста, покиньте отсек биосканирования.");
					us us14 = us13;
					if (value7)
					{
						if (serviceOrThrow.aqu().p() >= primitivePropertyValue)
						{
							us14.ym(c5x, null, null);
							serviceOrThrow.aqu().r()["loc_xpbl_sc_waitingTime"] = serviceOrThrow.aqu().p() + TimeSpan.FromSeconds(6.0);
							return;
						}
					}
					else if (value6)
					{
						int num = 10;
						while (num <= 14 && !flag3)
						{
							int num2 = 29;
							while (num2 <= 33 && !flag3)
							{
								ak1 ak = c5x.Area.b(num, num2);
								if (ak != null)
								{
									foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
									{
										c5x c5x3 = (c5x)b0b;
										if (c5x3.qe() != new Guid("3a4d1993-4217-4ae6-9e53-132a6dcbb50d") && c5x3.GetAspect<bim>() is c7j)
										{
											c7j c7j = c5x3.GetAspect<bim>() as c7j;
											if (c7j != null && Enumerable.Any<coh>(c7j.ItemContainer.z2()))
											{
												flag3 = true;
												break;
											}
										}
									}
								}
								num2++;
							}
							num++;
						}
						if (!Enumerable.Any<coh>(c5x.h.b.aa().Bag.z2()) && !Enumerable.Any<coh>(c5x.h.b.aa().Gear.i()) && !flag3)
						{
							us2.ym(c5x, null, null);
							serviceOrThrow2.am3("Xpbl_Sc_ScanningInitiated");
							serviceOrThrow.aqu().r()["loc_xpbl_sc_waitingForItems"] = false;
							serviceOrThrow.aqu().r()["loc_xpbl_sc_scanStarted"] = true;
							return;
						}
						if (serviceOrThrow.aqu().p() >= primitivePropertyValue2 || primitivePropertyValue2 == null)
						{
							if (service != null && service.aq2() >= GameDifficulty.Hard)
							{
								us12.ym(c5x, null, null);
							}
							else
							{
								us10.ym(c5x, null, null);
							}
							serviceOrThrow.aqu().r()["loc_xpbl_sc_putAwayItemsTime"] = serviceOrThrow.aqu().p() + TimeSpan.FromSeconds(20.0);
							return;
						}
					}
					else if (value5)
					{
						serviceOrThrow.aqu().r()["loc_xpbl_sc_scanCompleted"] = false;
						if (service != null && service.aq2() >= GameDifficulty.Hard && (Enumerable.Any<coh>(c5x.h.b.aa().Bag.z2()) || Enumerable.Any<coh>(c5x.h.b.aa().Gear.i()) || flag3))
						{
							serviceOrThrow.aqu().r()["loc_xpbl_sc_waitingForItems"] = true;
							return;
						}
						if (value4 && !flag2)
						{
							bool flag4 = false;
							c7j c7j2 = new EntityAspectReference<c7j, bim>(c5x.Area, new Guid("3a4d1993-4217-4ae6-9e53-132a6dcbb50d")).ao();
							using (List<coh>.Enumerator enumerator = Enumerable.ToList<coh>(c7j2.ItemContainer.z2()).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									if (enumerator.Current.Definition.a7().GetPrimitivePropertyValue<bool>(dii.f, new bool?(false)).Value)
									{
										flag4 = true;
										break;
									}
								}
							}
							if (!flag4 && service != null)
							{
								Random random = new Random(serviceOrThrow.aqu().l());
								int num3 = 0;
								if (service.aq2() == GameDifficulty.Hard)
								{
									num3 = 70;
								}
								else if (service.aq2() == GameDifficulty.Dominating)
								{
									num3 = 100;
								}
								if (random.Next(0, 101) < num3)
								{
									flag4 = true;
								}
							}
							if (flag4)
							{
								c7j c7j3 = new EntityAspectReference<c7j, bim>(c5x.Area, new Guid("4b51fc41-e987-453e-bd16-81c7f8543264")).ao();
								if (c7j3 != null)
								{
									foreach (coh coh2 in Enumerable.ToList<coh>(c7j2.ItemContainer.z2()))
									{
										c7j2.ItemContainer.z5(coh2);
										coh2.Lootable = true;
										coh2.Stealable = true;
										c7j3.ItemContainer.z3(coh2, true);
									}
									b3x b3x = new b3x();
									b3x.ym(null, new ar7(new Guid("3a4d1993-4217-4ae6-9e53-132a6dcbb50d"), c5x.Area).ao(), null);
									b3x.ym(null, new ar7(new Guid("4b51fc41-e987-453e-bd16-81c7f8543264"), c5x.Area).ao(), null);
									d2b d2b = new EntityAspectReference<d2b, d2b>(c5x.Area, new Guid("6edf22ac-4c31-460f-a89e-c6ff09733c92")).ao();
									if (d2b != null)
									{
										d2b.e(false);
									}
									serviceOrThrow.aqu().r()["loc_xpbl_sc_itemsTakenDuringScanning"] = true;
									us8.ym(c5x, null, null);
									serviceOrThrow.aqz().atb("xpbl_sc_getGearBack", true);
								}
								else
								{
									us6.ym(c5x, null, null);
								}
							}
							else
							{
								us6.ym(c5x, null, null);
							}
							awh awh = new awh();
							awh.b(c5x.Area.y8());
							awh.b(new Guid("a20db704-dd42-4a8d-8a32-32ff06a0f2aa"));
							awh.a(new Guid("32422f50-0b10-418f-9c90-9f4e1b884495"));
							awh.a(bbo.b);
							awh.ym(c5x, null, null);
							new bu0("cp_expedition_passedJSHQScan").ym(c5x, null, null);
							serviceOrThrow.aqu().r()["loc_xpbl_sc_finishedScanningSuccessfully"] = true;
							serviceOrThrow.aqz().atc("xpbl_sc_scanning", true);
							return;
						}
						if (flag2 || flag)
						{
							serviceOrThrow.aqu().r()["loc_xpbl_sc_waitingForItems"] = true;
							return;
						}
						us4.ym(c5x, null, null);
						serviceOrThrow.aqz().atb("xpbl_sc_scanning", true);
						awh awh2 = new awh();
						awh2.b(c5x.Area.y8());
						awh2.b(new Guid("b09452b5-0651-4d43-a39b-404d14e1c29c"));
						awh2.a(new Guid("7e445ebf-dc0f-4659-b77b-b600ebc946cc"));
						awh2.a(bbo.b);
						awh2.ym(c5x, null, null);
						c5x c5x4 = new ar7(new Guid("e85ac6e5-5d4f-4212-9489-8437f6c5bf09"), c5x.Area).ao() as c5x;
						if (c5x4 != null && service != null && service.aq2() >= GameDifficulty.Dominating)
						{
							dqs dqs = new dqs();
							if (dqs != null)
							{
								dqs.a(c5x.Area.y8());
								dqs.a(new Guid?(c5x4.qe()));
								dqs.ym(c5x, null, null);
							}
						}
						serviceOrThrow.aqu().r()["loc_xpbl_sc_scanCompleted"] = false;
						serviceOrThrow.aqu().r()["loc_xpbl_sc_waitingForItems"] = false;
						serviceOrThrow.aqu().r()["loc_xpbl_sc_waitingToLeave"] = true;
						return;
					}
					else
					{
						if (value4 || flag2 || flag)
						{
							us2.ym(c5x, null, null);
							serviceOrThrow.aqu().r()["loc_xpbl_sc_scanStarted"] = true;
							serviceOrThrow2.am3("Xpbl_Sc_ScanningInitiated");
							return;
						}
						us4.ym(c5x, null, null);
						awh awh3 = new awh();
						awh3.b(c5x.Area.y8());
						awh3.b(new Guid("b09452b5-0651-4d43-a39b-404d14e1c29c"));
						awh3.a(new Guid("7e445ebf-dc0f-4659-b77b-b600ebc946cc"));
						awh3.a(bbo.b);
						awh3.ym(c5x, null, null);
						serviceOrThrow.aqu().r()["loc_xpbl_sc_scanCompleted"] = false;
						serviceOrThrow.aqu().r()["loc_xpbl_sc_waitingForItems"] = false;
						serviceOrThrow.aqu().r()["loc_xpbl_sc_waitingToLeave"] = true;
					}
				}
			}
		}
	}
}
