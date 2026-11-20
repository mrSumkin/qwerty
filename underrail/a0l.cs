using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Common;

// Token: 0x02001011 RID: 4113
public static class a0l
{
	// Token: 0x060054D8 RID: 21720 RVA: 0x00258338 File Offset: 0x00256538
	public static void a(c5x A_0, bool A_1 = true)
	{
		if (A_0 != null)
		{
			if (A_0.h.b != null)
			{
				A_0.h.b.aa().Cooldowns.a(new cfd[]
				{
					new cfd(e5b.d, 5000, false, false)
				});
			}
			if (A_0.h.b != null && A_0.h.b.aa() is e3q)
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					service.ahk(Math.Max(service.ahj(), 3000.0));
					if (A_1)
					{
						service.ah3(-10);
						cnk service2 = bpo.GetService<cnk>();
						if (service2.aqu() != null)
						{
							bfc bfc = service2.ar0(service2.aqu().c().b(), service2.aqu());
							if (bfc != null)
							{
								alg alg = service2.aqu().a(bfc.Id, false);
								if (alg != null && alg.d != null && alg.d.Value + TimeSpan.FromHours(3.0) > service2.aqu().o())
								{
									service.ah3(-1000);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060054D9 RID: 21721 RVA: 0x00258488 File Offset: 0x00256688
	public static void a(c5x A_0, string A_1, bool A_2 = true)
	{
		if (A_0 != null)
		{
			csd csd = A_0.Zone.g(A_1);
			if (csd != null)
			{
				if (csd.Area == null)
				{
					csd.e();
					if (csd.Area == null)
					{
						return;
					}
				}
				a0l.a(A_0, csd.Area, csd.Location, new HorizontalDirection?(csd.Direction), A_2);
			}
		}
	}

	// Token: 0x060054DA RID: 21722 RVA: 0x002584EC File Offset: 0x002566EC
	public static void a(c5x A_0, aud A_1, Vector3 A_2, HorizontalDirection? A_3 = null, bool A_4 = true)
	{
		if (A_1 != null)
		{
			aud a_ = A_0.Area;
			Vector3 a_2 = a0l.a(A_1, A_2, A_0, null);
			if (A_1 != A_0.Area)
			{
				d02 service = bpo.GetService<d02>();
				if (service != null && service.ahg() && service.ahe() != null)
				{
					amc aspect = A_0.GetAspect<amc>();
					if (aspect != null && service.ahe().b == aspect)
					{
						service.ah4();
					}
				}
				A_0.an();
				A_0.Location = a_2;
				A_1.a(A_0);
			}
			else
			{
				if (A_4)
				{
					ny b = A_0.i.b;
					if (b != null)
					{
						b.a(m7.b, true, false);
					}
				}
				A_0.Location = a_2;
				A_0.ah();
			}
			if (A_3 != null)
			{
				A_0.VisualDirection = A_3.Value;
			}
			a0l.a(A_0, true);
			amc b2 = A_0.h.b;
			if (b2 != null)
			{
				a7v.a(new dwq(new ap9(b2.aa()), A_0, a_, A_0.Area));
			}
		}
	}

	// Token: 0x060054DB RID: 21723 RVA: 0x0025860C File Offset: 0x0025680C
	public static void a(c5x A_0, c2w A_1, int A_2 = 0, Point? A_3 = null)
	{
		c2w c2w = A_1.a();
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null)
		{
			c2w.a(service.aqu());
		}
		if (A_0 != null && c2w != null && !string.IsNullOrEmpty(c2w.b()) && !string.IsNullOrEmpty(c2w.c()))
		{
			if (A_0.IsPlayer && A_0.h.b != null)
			{
				d02 service2 = bpo.GetService<d02>();
				if (service2 != null)
				{
					foreach (d4n d4n in service2.ahl())
					{
						if (d4n.b != null && !d4n.b.a8().IsPlayer && d4n.b.a8().t.b != null && d4n.b.a(A_0.h.b) != h.a)
						{
							d4n.b.a8().t.b.a(A_0);
						}
					}
				}
				alg alg = null;
				if (service.aqu() != null)
				{
					bfc bfc = service.ar0(service.aqu().c().b(), service.aqu());
					if (bfc != null)
					{
						alg = service.aqu().a(bfc.Id, false);
					}
				}
				if (A_0.h.b != null && A_0.h.b.aa().IsInCombat)
				{
					cxc.c(eyy.ao);
					if (alg != null && service.aqu() != null)
					{
						alg.d = new TimeSpan?(service.aqu().o());
					}
				}
				else if (alg != null)
				{
					alg.d = null;
				}
			}
			a0l.a(A_0);
			bool? flag = null;
			if (service != null && service.aqw() != null && service.aqw().CustomProperties.GetPrimitivePropertyValue<bool>("SavingDisabled", new bool?(false)).Value)
			{
				flag = new bool?(false);
			}
			d4m serviceOrThrow = bpo.GetServiceOrThrow<d4m>();
			btm a_ = dla.a(TimelapseWorkflows.ChangeZone, new object[]
			{
				c2w,
				true,
				flag,
				A_2,
				A_3,
				true,
				true,
				false
			});
			serviceOrThrow.avp(a_);
			if (service.aqu() != null && service.aqu().c() != null)
			{
				service.aqu().b(service.aqu().c().b(), c2w.b());
			}
		}
	}

	// Token: 0x060054DC RID: 21724 RVA: 0x00258900 File Offset: 0x00256B00
	public static void a(c2w A_0)
	{
		if (A_0 == null)
		{
			return;
		}
		c2w c2w = A_0.a();
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null)
		{
			c2w.a(service.aqu());
		}
		if (c2w != null && !string.IsNullOrEmpty(c2w.b()))
		{
			d4m serviceOrThrow = bpo.GetServiceOrThrow<d4m>();
			btm a_ = dla.a(TimelapseWorkflows.ChangeZone, new object[]
			{
				c2w,
				true,
				null,
				0,
				null,
				true,
				true,
				false
			});
			serviceOrThrow.avp(a_);
			if (service.aqu() != null && service.aqu().c() != null)
			{
				service.aqu().b(service.aqu().c().b(), c2w.b());
			}
		}
	}

	// Token: 0x060054DD RID: 21725 RVA: 0x002589DC File Offset: 0x00256BDC
	public static Vector3 a(aud A_0, Vector3 A_1, c5x A_2, l9? A_3 = null)
	{
		Point a_ = A_1.a();
		ak1 ak = A_0.a(a_);
		if (a_.a() == A_1 && aw1.a(A_2, ak, false, A_2))
		{
			List<ak1> list = a0l.a(ak);
			foreach (ak1 ak2 in Enumerable.ToList<ak1>(list))
			{
				bool flag;
				if (A_3 != null)
				{
					flag = aw1.a(ak2, true, A_2, A_3.Value);
				}
				else
				{
					flag = aw1.a(A_2, ak2, true, A_2);
				}
				if (flag)
				{
					list.AddRange(a0l.a(ak2));
				}
			}
			foreach (ak1 ak3 in list)
			{
				if (ak3.c.Count > 0)
				{
					if (A_3 != null)
					{
						if (!aw1.a(ak3, false, A_2, A_3.Value))
						{
							return ak3.Location.a();
						}
					}
					else if (!aw1.a(A_2, ak3, false, A_2))
					{
						return ak3.Location.a();
					}
				}
			}
			return A_1;
		}
		return A_1;
	}

	// Token: 0x060054DE RID: 21726 RVA: 0x00258B50 File Offset: 0x00256D50
	private static List<ak1> a(ak1 A_0)
	{
		List<ak1> list = new List<ak1>();
		ak1 ak = A_0.Area.a(new Point(A_0.Location.X, A_0.Location.Y - 1));
		ak1 ak2 = A_0.Area.a(new Point(A_0.Location.X, A_0.Location.Y + 1));
		ak1 ak3 = A_0.Area.a(new Point(A_0.Location.X - 1, A_0.Location.Y));
		ak1 ak4 = A_0.Area.a(new Point(A_0.Location.X + 1, A_0.Location.Y));
		if (ak != null)
		{
			list.Add(ak);
		}
		if (ak2 != null)
		{
			list.Add(ak2);
		}
		if (ak3 != null)
		{
			list.Add(ak3);
		}
		if (ak4 != null)
		{
			list.Add(ak4);
		}
		return list;
	}

	// Token: 0x060054DF RID: 21727 RVA: 0x00258C40 File Offset: 0x00256E40
	private static void a(c5x A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null && A_0.t.b != null && A_0.h.b != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in service.ahl())
				{
					if (d4n.b != null && d4n.b.a8() != null && d4n.b.a8() != A_0 && d4n.b.a8().t.b != null && d4n.b.aa().a(serviceOrThrow.aqu().ac(), A_0.h.b.aa().FactionId) != h.a)
					{
						erl erl = d4n.b.a8().t.b.c(A_0.h.b);
						erl erl2 = A_0.t.b.c(d4n.b);
						if (erl != null)
						{
							erl.a(cem.a);
							erl.a(0.0);
						}
						if (erl2 != null)
						{
							erl2.a(cem.a);
							erl2.a(0.0);
						}
					}
				}
			}
		}
	}
}
