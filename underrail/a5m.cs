using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001733 RID: 5939
[eiz("RACSA")]
[Serializable]
public sealed class a5m : a6k
{
	// Token: 0x0600802E RID: 32814 RVA: 0x00362660 File Offset: 0x00360860
	private a5m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600802F RID: 32815 RVA: 0x0036266C File Offset: 0x0036086C
	public a5m()
	{
	}

	// Token: 0x06008030 RID: 32816 RVA: 0x00362678 File Offset: 0x00360878
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() != null && base.vg().q().Zone != null && base.vg().q().h.b != null)
		{
			if (base.vg().e() != null && base.vg().e().b9() is coh)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					string text;
					if (base.vg().q().Area.y8() == "jye1v")
					{
						base.vg().e().a(true);
						text = "Вы выпускаете жучка, и он убегает во тьму.";
						serviceOrThrow.aqu().r()["quest_jypetDelivery_petDeliveredSafely"] = true;
					}
					else if (string.Equals(base.vg().q().Zone.y8(), "cc_tm"))
					{
						if (base.vg().q().Area.y8().EndsWith("_v", StringComparison.OrdinalIgnoreCase))
						{
							base.vg().e().a(true);
							text = "Вы выпускаете жучка, и он убегает во тьму.";
							serviceOrThrow.aqu().r()["loc_cc_tm_spawnPlanted"] = true;
						}
						else
						{
							bool flag = false;
							d02 service = bpo.GetService<d02>();
							if (service != null)
							{
								foreach (d4n d4n in service.ahl())
								{
									if (d4n.b != null && !d4n.b.aa().Passive && d4n.b.aa().FactionId == asp.eb && d4n.b.a8() != null && d4n.b.a8().t.b != null && d4n.b.a8().t.b.b(base.vg().q().h.b, false))
									{
										flag = true;
										awq.a(d4n.b.a8(), base.vg().q(), false, false, true, true, false, false);
									}
								}
							}
							if (flag)
							{
								text = "Вы выпускаете жучка на пол, но вас замечают. Напуганный неизбежным конфликтом, он бежит и исчезает в трещине стене.";
								a7v.a(new ehr("Ваши действия спровоцировали враждебность."));
								base.vg().e().a(true);
							}
							else
							{
								bool flag2 = false;
								Point point = base.vg().q().aj().a();
								for (int i = point.X - 1; i <= point.X + 1; i++)
								{
									for (int j = point.Y - 1; j <= point.Y + 1; j++)
									{
										ak1 ak = base.vg().q().Area.b(i, j);
										if (ak != null)
										{
											using (IEnumerator<b0b> enumerator2 = ak.c.Values.GetEnumerator())
											{
												while (enumerator2.MoveNext())
												{
													if (((c5x)enumerator2.Current).GetAspect<bim>() is pa)
													{
														flag2 = true;
														break;
													}
												}
											}
										}
									}
								}
								if (flag2)
								{
									text = "Вы поднимаете жучка к вентиляционной решётке, и он быстро цепляется за неё и протискивается внутрь.";
									serviceOrThrow.aqu().r()["loc_cc_tm_spawnPlanted"] = true;
									base.vg().e().a(true);
								}
								else
								{
									text = "Вы выпускаете жучка на пол, но не найдя вентиляционной решётки, он быстро забирается по вашей ноге обратно в оккупированный прежде карман.";
								}
							}
						}
					}
					else if (base.vg().q().Area.y8() == "jye1")
					{
						bool flag3 = false;
						d02 service2 = bpo.GetService<d02>();
						if (service2 != null)
						{
							foreach (d4n d4n2 in service2.ahl())
							{
								if (d4n2.b != null && !d4n2.b.aa().Passive && d4n2.b.aa().FactionId == asp.bh && d4n2.b.a8() != null && d4n2.b.a8().t.b != null && d4n2.b.a8().t.b.b(base.vg().q().h.b, false))
								{
									flag3 = true;
									awq.a(d4n2.b.a8(), base.vg().q(), false, false, true, true, false, false);
								}
							}
						}
						if (flag3)
						{
							text = "Вы выпускаете жучка на пол, но вас замечают. Напуганный неизбежным конфликтом, он бежит и исчезает в трещине стене.";
							serviceOrThrow.aqu().r()["quest_jypetDelivery_busted"] = true;
							a7v.a(new ehr("Ваши действия спровоцировали враждебность."));
							base.vg().e().a(true);
						}
						else
						{
							bool flag4 = false;
							Point point2 = base.vg().q().aj().a();
							for (int k = point2.X - 1; k <= point2.X + 1; k++)
							{
								for (int l = point2.Y - 1; l <= point2.Y + 1; l++)
								{
									ak1 ak2 = base.vg().q().Area.b(k, l);
									if (ak2 != null)
									{
										using (IEnumerator<b0b> enumerator2 = ak2.c.Values.GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												if (((c5x)enumerator2.Current).GetAspect<bim>() is pa)
												{
													flag4 = true;
													break;
												}
											}
										}
									}
								}
							}
							if (flag4)
							{
								text = "Вы поднимаете жучка к вентиляционной решётке, и он быстро цепляется за неё и протискивается внутрь.";
								serviceOrThrow.aqu().r()["quest_jypetDelivery_petDeliveredSafely"] = true;
								base.vg().e().a(true);
							}
							else
							{
								text = "Вы выпускаете жучка на пол, но не найдя вентиляционной решётки, он быстро забирается по вашей ноге обратно в оккупированный прежде карман.";
							}
						}
					}
					else
					{
						text = "Вы выпускаете жучка на пол, но он быстро забирается по вашей ноге обратно в оккупированный прежде карман. Кажется, ему здесь не нравится.";
					}
					if (!string.IsNullOrEmpty(text))
					{
						a7v.a(new h0(text, null));
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
