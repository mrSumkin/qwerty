using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E96 RID: 3734
[e79("FacelessInvadeCoreCity2")]
public sealed class evx : dgy
{
	// Token: 0x06004D69 RID: 19817 RVA: 0x00222E38 File Offset: 0x00221038
	public evx()
	{
		evx.a a = new evx.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			evx.b b = new evx.b();
			b.p = a;
			bool flag = b.p.a.aqu().v().b() is c5x;
			b.g = new ar7(new Guid("48746f76-04e5-45f7-9df9-a26491198a0e"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.f = new ar7(new Guid("ca6bd38c-dde1-4097-bb17-22517fc491b5"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.a = new ar7(new Guid("b89c9742-e809-4da6-83af-178641ad097f"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.b = new ar7(new Guid("9f1cd3f1-cf9f-43b9-b221-a0a67990abea"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.c = new ar7(new Guid("be4c16c1-5461-44e1-9c81-4a943db39ffc"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.d = new ar7(new Guid("841edf45-b2c2-4719-972a-76ecba2648b1"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.e = new ar7(new Guid("bd0ffcd3-fdb0-4827-82a3-c433b387896f"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.l = new ar7(new Guid("9b9b7686-7254-444d-b456-5fbfa6f05d02"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.h = new ar7(new Guid("678fcd80-20cd-4a2f-8d70-0860927bd395"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.n = new ar7(new Guid("5947b750-4ca4-4545-9984-b0deeae58d69"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.i = new ar7(new Guid("0de97e75-1c0c-434e-8e0d-949c5dd9aef3"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.m = new ar7(new Guid("58137ae7-522a-4492-8194-2e32ba42663b"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.j = new ar7(new Guid("77aeca4e-66c7-4d30-87f1-57d272a36f39"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.k = new ar7(new Guid("e043263b-b8ba-4911-a79e-2d947cbbbf78"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.o = new ar7(new Guid("2156a6df-825c-46cf-959a-ea48ccda4a1a"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			if (flag)
			{
				btm[] array = new btm[1];
				int num = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(b.h));
				array[num] = dva;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(b.g));
				array2[num2] = dva2;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				kw kw = new kw();
				kw.a(new bt4("focus1"));
				kw.a(false);
				array3[num3] = kw;
				base.a(array3);
				btm[] array4 = new btm[1];
				int num4 = 0;
				cw8 cw = new cw8();
				cw.a(TimeSpan.FromSeconds(1.0));
				array4[num4] = cw;
				base.a(array4);
				btm[] array5 = new btm[1];
				int num5 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(b.m));
				array5[num5] = dva3;
				base.a(array5);
				btm[] array6 = new btm[1];
				int num6 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(b.l));
				array6[num6] = dva4;
				base.a(array6);
				btm[] array7 = new btm[1];
				int num7 = 0;
				dva dva5 = new dva(null, null, null, null, null);
				dva5.a(new Func<e6d, bool>(b.k));
				array7[num7] = dva5;
				base.a(array7);
				btm[] array8 = new btm[1];
				int num8 = 0;
				bzm bzm = new bzm();
				bzm.a("tunneller");
				bzm.a(true);
				array8[num8] = new ace(bzm)
				{
					TargetRef = b.b
				};
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				dva dva6 = new dva(null, null, null, null, null);
				dva6.a(new Func<e6d, bool>(evx.c.a.b));
				array9[num9] = dva6;
				base.a(array9);
				btm[] array10 = new btm[1];
				int num10 = 0;
				dva dva7 = new dva(null, null, null, null, null);
				dva7.a(new Func<e6d, bool>(b.p.b));
				array10[num10] = dva7;
				base.a(array10);
				btm[] array11 = new btm[1];
				int num11 = 0;
				dva dva8 = new dva(null, null, null, null, null);
				dva8.a(new Func<e6d, bool>(b.f));
				array11[num11] = dva8;
				base.a(array11);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.j), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array12 = new btm[1];
				int num12 = 0;
				b18 b2 = new b18();
				b2.b("earthquake");
				array12[num12] = new ace(b2)
				{
					TargetRef = b.f
				};
				base.a(array12);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array13 = new btm[1];
				int num13 = 0;
				dva dva9 = new dva(null, null, null, null, null);
				dva9.a(new Func<e6d, bool>(b.o));
				array13[num13] = dva9;
				base.a(array13);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array14 = new btm[1];
				int num14 = 0;
				dva dva10 = new dva(null, null, null, null, null);
				dva10.a(new Func<e6d, bool>(b.e));
				array14[num14] = dva10;
				base.a(array14);
				btm[] array15 = new btm[1];
				int num15 = 0;
				dva dva11 = new dva(null, null, null, null, null);
				dva11.a(new Func<e6d, bool>(b.n));
				array15[num15] = dva11;
				base.a(array15);
				btm[] array16 = new btm[1];
				int num16 = 0;
				bzm bzm2 = new bzm();
				bzm2.a("tunneller2");
				bzm2.a(true);
				array16[num16] = new ace(bzm2)
				{
					TargetRef = b.b
				};
				base.a(array16);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				btm[] array17 = new btm[1];
				int num17 = 0;
				dva dva12 = new dva(null, null, null, null, null);
				dva12.a(new Func<e6d, bool>(evx.c.a.a));
				array17[num17] = dva12;
				base.a(array17);
				btm[] array18 = new btm[1];
				int num18 = 0;
				dva dva13 = new dva(null, null, null, null, null);
				dva13.a(new Func<e6d, bool>(b.p.a));
				array18[num18] = dva13;
				base.a(array18);
				btm[] array19 = new btm[1];
				int num19 = 0;
				dva dva14 = new dva(null, null, null, null, null);
				dva14.a(new Func<e6d, bool>(b.a));
				array19[num19] = dva14;
				base.a(array19);
				btm[] array20 = new btm[1];
				int num20 = 0;
				dva dva15 = new dva(null, null, null, null, null);
				dva15.a(new Func<e6d, bool>(b.c));
				array20[num20] = dva15;
				base.a(array20);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array21 = new btm[1];
				int num21 = 0;
				dva dva16 = new dva(null, null, null, null, null);
				dva16.a(new Func<e6d, bool>(b.d));
				array21[num21] = dva16;
				base.a(array21);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array22 = new btm[1];
				int num22 = 0;
				dva dva17 = new dva(null, null, null, null, null);
				dva17.a(new Func<e6d, bool>(b.b));
				array22[num22] = dva17;
				base.a(array22);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(10.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.i), null, null, null)
				});
				btm[] array23 = new btm[1];
				int num23 = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array23[num23] = dky;
				base.a(array23);
				base.a(new btm[]
				{
					new di4(new c2w("StationAlpha-Level5", "start"), false, null, 0, null, true, false, false)
				});
			}
		}
	}

	// Token: 0x02000E97 RID: 3735
	[CompilerGenerated]
	[Serializable]
	private sealed class c
	{
		// Token: 0x06004D6C RID: 19820 RVA: 0x00223728 File Offset: 0x00221928
		internal bool b(e6d A_0)
		{
			TypedObjectReference<aud> typedObjectReference = new e6z(new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			doq a_ = doq.a(Path.Combine(d5x.q(), "lu-c1b_l2") + ".uzl");
			typedObjectReference.ao().Zone.a(a_, 1, null);
			return true;
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x00223788 File Offset: 0x00221988
		internal bool a(e6d A_0)
		{
			TypedObjectReference<aud> typedObjectReference = new e6z(new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			doq a_ = doq.a(Path.Combine(d5x.q(), "lu-c1b_l3") + ".uzl");
			typedObjectReference.ao().Zone.a(a_, 1, null);
			return true;
		}

		// Token: 0x04001FA1 RID: 8097
		public static readonly evx.c a = new evx.c();

		// Token: 0x04001FA2 RID: 8098
		public static Func<e6d, bool> b;

		// Token: 0x04001FA3 RID: 8099
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000E98 RID: 3736
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D6F RID: 19823 RVA: 0x002237F4 File Offset: 0x002219F4
		internal bool b(e6d A_0)
		{
			e6z e6z = new e6z(new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			if (e6z.ao() != null)
			{
				cno cno = e6z.ao().Divinations.a("cave1");
				if (cno != null)
				{
					cno.a(this.a.aqu().v().c());
					cno.g();
				}
			}
			return true;
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x0022386C File Offset: 0x00221A6C
		internal bool a(e6d A_0)
		{
			e6z e6z = new e6z(new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			if (e6z.ao() != null)
			{
				cno cno = e6z.ao().Divinations.a("cave2");
				if (cno != null)
				{
					cno.a(this.a.aqu().v().c());
					cno.g();
				}
			}
			return true;
		}

		// Token: 0x04001FA4 RID: 8100
		public cnk a;
	}

	// Token: 0x02000E99 RID: 3737
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004D72 RID: 19826 RVA: 0x002238F0 File Offset: 0x00221AF0
		internal bool h(e6d A_0)
		{
			if (this.a.ao() != null)
			{
				this.a.ao().VisualDirection = HorizontalDirection.Northwest;
			}
			if (this.b.ao() != null)
			{
				this.b.ao().VisualDirection = HorizontalDirection.Northwest;
			}
			if (this.c.ao() != null)
			{
				this.c.ao().VisualDirection = HorizontalDirection.Northwest;
			}
			if (this.d.ao() != null)
			{
				this.d.ao().VisualDirection = HorizontalDirection.North;
			}
			return true;
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x00223984 File Offset: 0x00221B84
		internal bool g(e6d A_0)
		{
			(this.e.ao() as c5x).c().a("engine", "TunnellerEngineLoop", 0.5f, c9z.a, true, false);
			return true;
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x002239C0 File Offset: 0x00221BC0
		internal bool m(e6d A_0)
		{
			(this.e.ao() as c5x).c().a("engine", "TunnellerEngineLoop", 1f, c9z.a, true, false);
			return true;
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x002239FC File Offset: 0x00221BFC
		internal bool l(e6d A_0)
		{
			e6z e6z = new e6z(new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			if (e6z.ao() != null)
			{
				(this.f.ao() as c5x).c().a("DestructableRocksDestroyed");
				int a_ = 8;
				for (int i = 4; i <= 10; i++)
				{
					ak1 ak = e6z.ao().b(a_, i);
					if (ak != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
						{
							if (b0b.Layer == aju.x)
							{
								b0b.w();
								b0b.an();
							}
						}
						for (int j = 0; j <= cuo.a.Next(3); j++)
						{
							Vector3 a_2 = ak.Location.a() + new Vector3(-0.3f + (float)cuo.a.NextDouble() * 0.6f, -0.3f + (float)cuo.a.NextDouble() * 0.6f, 0.3f + (float)cuo.a.NextDouble() * 0.4f);
							no no = new no();
							no.a(e6z);
							no.a("Smoke");
							no.a(a_2);
							no.a(1);
							no.a(2147483647.0);
							no.ym(null, null, null);
							no no2 = new no();
							no2.a(e6z);
							no2.a("DestructableRocksExplosion");
							no2.a(a_2);
							no2.a(1);
							no2.a(2147483647.0);
							no2.ym(null, null, null);
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00223BE0 File Offset: 0x00221DE0
		internal bool k(e6d A_0)
		{
			this.g.ao().GetAspect<axh>().a(null, false, null);
			return true;
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x00223C10 File Offset: 0x00221E10
		internal bool f(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.ane(1000, null, null, null, null, null);
			}
			e6z e6z = new e6z(new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			if (e6z.ao() != null && this.e != null)
			{
				ka ka = (this.e.ao() as c5x).q.b;
				if (ka != null)
				{
					int a_ = 50;
					ka.b("mv 2");
					qy qy = new qy();
					qy.ad().Add(new bpr((this.e.ao() as c5x).j.b, new Vector3(9f, 5f, 0f)));
					qy.ad().Add(new a4s(new nb(), null, new ar7(new Guid("7ed4a5fc-3399-4935-9e8f-dc0f7c92e96d"), e6z.ao()), null));
					e6z.ao().Zone.ActionManager.g9(qy, atp.a);
					qy qy2 = new qy();
					qy2.ad().Add(new c6y(ka, a_, 0, 11, 5));
					qy2.ad().Add(new a4s(new afy(ka, true, 0, true, "tr 6"), null, null, null));
					qy2.ad().Add(new c6y(ka, a_, 0, 12, 1));
					List<auv> list = qy2.ad();
					b18 b = new b18();
					b.b("engine");
					list.Add(new a4s(b, null, this.e, null));
					qy2.ad().Add(new bm3(700));
					qy2.ad().Add(new a4s(new afy(ka, true, 0, true, "tr 1"), null, null, null));
					qy2.ad().Add(new c6y(ka, 100, 0, 8, 1));
					qy2.ad().Add(new bm3(800));
					qy2.ad().Add(new a4s(new afy(ka, true, 0, true, "tr 2"), null, null, null));
					qy2.ad().Add(new a4s(new bfq("TunnellerDoorOpen"), null, this.e, null));
					qy2.ad().Add(new c6y(ka, 180, 0, 11, 1));
					qy2.ad().Add(new bm3(500));
					awx awx = new awx();
					awx.a(m7.b);
					awx.ad().Add(new a8v(this.h.ao(), e6z.ao().Zone.g("tun1exit").Location));
					awx.ad().Add(new bm3(250));
					awx.ad().Add(new djk(this.h.ao().GetAspect<ale>(), e6z.ao().a(e6z.ao().Zone.g("tun1pos1").Location.a())));
					List<auv> list2 = awx.ad();
					dve dve = new dve();
					dve.a(asp.ce);
					list2.Add(new a4s(dve, null, this.h, null));
					awx awx2 = new awx();
					awx2.a(m7.b);
					awx2.ad().Add(new a8v(this.i.ao(), e6z.ao().Zone.g("tun1exit").Location));
					awx2.ad().Add(new bm3(250));
					awx2.ad().Add(new djk(this.i.ao().GetAspect<ale>(), e6z.ao().a(e6z.ao().Zone.g("tun1pos2").Location.a())));
					awx2.ad().Add(new bm3(100));
					List<auv> list3 = awx2.ad();
					dve dve2 = new dve();
					dve2.a(asp.ce);
					list3.Add(new a4s(dve2, null, this.i, null));
					qy2.ad().Add(new g1(this.h.ao().GetAspect<ny>(), awx, atp.a, false));
					qy2.ad().Add(new bm3(500));
					qy2.ad().Add(new g1(this.i.ao().GetAspect<ny>(), awx2, atp.a, false));
					qy2.ad().Add(new bm3(2000));
					qy2.ad().Add(new a8v(this.j.ao(), e6z.ao().Zone.g("tun1exit").Location));
					qy2.ad().Add(new bm3(400));
					qy2.ad().Add(new a8v(this.k.ao(), e6z.ao().Zone.g("tun1exitb").Location));
					e6z.ao().Zone.ActionManager.g9(qy2, atp.a);
				}
			}
			return true;
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x00224170 File Offset: 0x00222370
		internal bool j(e6d A_0)
		{
			if (this.b.ao() != null && (this.b.ao() as c5x).h.b != null)
			{
				(this.b.ao() as c5x).h.b.ap = new CharacterState?(CharacterState.Attack1);
				(this.b.ao() as c5x).h.b.aq = new int?(0);
			}
			if (this.a.ao() != null && (this.a.ao() as c5x).h.b != null)
			{
				(this.a.ao() as c5x).h.b.ap = new CharacterState?(CharacterState.Attack1);
				(this.a.ao() as c5x).h.b.aq = new int?(0);
			}
			if (this.c.ao() != null && (this.c.ao() as c5x).h.b != null)
			{
				(this.c.ao() as c5x).h.b.ap = new CharacterState?(CharacterState.Attack1);
				(this.c.ao() as c5x).h.b.aq = new int?(0);
			}
			if (this.d.ao() != null && (this.d.ao() as c5x).h.b != null)
			{
				(this.d.ao() as c5x).h.b.ap = new CharacterState?(CharacterState.Attack1);
				(this.d.ao() as c5x).h.b.aq = new int?(0);
			}
			return true;
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x00224364 File Offset: 0x00222564
		internal bool o(e6d A_0)
		{
			(this.l.ao() as c5x).c().a("engine", "TunnellerEngineLoop", 0.5f, c9z.a, true, false);
			return true;
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x002243A0 File Offset: 0x002225A0
		internal bool e(e6d A_0)
		{
			(this.l.ao() as c5x).c().a("engine", "TunnellerEngineLoop", 1f, c9z.a, true, false);
			return true;
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x002243DC File Offset: 0x002225DC
		internal bool n(e6d A_0)
		{
			e6z e6z = new e6z(new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			if (e6z.ao() != null)
			{
				int a_ = 8;
				(this.f.ao() as c5x).c().a("DestructableRocksDestroyed");
				for (int i = 12; i <= 18; i++)
				{
					ak1 ak = e6z.ao().b(a_, i);
					if (ak != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
						{
							if (b0b.Layer == aju.x)
							{
								b0b.w();
								b0b.an();
							}
						}
						for (int j = 0; j <= cuo.a.Next(3); j++)
						{
							Vector3 a_2 = ak.Location.a() + new Vector3(-0.3f + (float)cuo.a.NextDouble() * 0.6f, -0.3f + (float)cuo.a.NextDouble() * 0.6f, 0.3f + (float)cuo.a.NextDouble() * 0.4f);
							no no = new no();
							no.a(e6z);
							no.a("Smoke");
							no.a(a_2);
							no.a(1);
							no.a(2147483647.0);
							no.ym(null, null, null);
							no no2 = new no();
							no2.a(e6z);
							no2.a("DestructableRocksExplosion");
							no2.a(a_2);
							no2.a(1);
							no2.a(2147483647.0);
							no2.ym(null, null, null);
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x002245C0 File Offset: 0x002227C0
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.ane(1500, null, null, null, null, null);
			}
			(this.f.ao() as c5x).c().a("earthquake", "EarthquakeShort", 1f, c9z.a, false, false);
			e6z e6z = new e6z(new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			if (e6z.ao() != null && this.l != null)
			{
				ka ka = (this.l.ao() as c5x).q.b;
				if (ka != null)
				{
					int a_ = 50;
					ka.b("mv 2");
					e6z.ao().Zone.ActionManager.g9(new bpr((this.l.ao() as c5x).j.b, new Vector3(7f, 14f, 0f)), atp.a);
					qy qy = new qy();
					qy.ad().Add(new c6y(ka, a_, 0, 11, 4));
					qy.ad().Add(new a4s(new afy(ka, true, 0, true, "tr 6"), null, null, null));
					qy.ad().Add(new c6y(ka, a_, 0, 12, 1));
					List<auv> list = qy.ad();
					b18 b = new b18();
					b.b("engine");
					list.Add(new a4s(b, null, this.l, null));
					List<auv> list2 = qy.ad();
					bfq bfq = new bfq("engine", "TunnellerEngineIdleLoop");
					bfq.a(0.75f);
					list2.Add(new a4s(bfq, null, this.l, null));
					qy.ad().Add(new bm3(700));
					qy.ad().Add(new a4s(new afy(ka, true, 0, true, "tr 1"), null, null, null));
					qy.ad().Add(new c6y(ka, 100, 0, 8, 1));
					qy.ad().Add(new bm3(800));
					qy.ad().Add(new a4s(new afy(ka, true, 0, true, "tr 2"), null, null, null));
					qy.ad().Add(new a4s(new bfq("TunnellerDoorOpen"), null, this.l, null));
					qy.ad().Add(new c6y(ka, 180, 0, 11, 1));
					qy.ad().Add(new bm3(500));
					awx awx = new awx();
					awx.a(m7.b);
					awx.ad().Add(new a8v(this.m.ao(), e6z.ao().Zone.g("tun2exit").Location));
					awx.ad().Add(new bm3(250));
					awx.ad().Add(new djk(this.m.ao().GetAspect<ale>(), e6z.ao().a(e6z.ao().Zone.g("tun2pos1").Location.a())));
					List<auv> list3 = awx.ad();
					dve dve = new dve();
					dve.a(asp.ce);
					list3.Add(new a4s(dve, null, this.m, null));
					awx awx2 = new awx();
					awx2.a(m7.b);
					awx2.ad().Add(new a8v(this.n.ao(), e6z.ao().Zone.g("tun2exit").Location));
					awx2.ad().Add(new bm3(250));
					awx2.ad().Add(new djk(this.n.ao().GetAspect<ale>(), e6z.ao().a(e6z.ao().Zone.g("tun2pos2").Location.a())));
					awx2.ad().Add(new bm3(100));
					List<auv> list4 = awx2.ad();
					dve dve2 = new dve();
					dve2.a(asp.ce);
					list4.Add(new a4s(dve2, null, this.n, null));
					qy.ad().Add(new g1(this.m.ao().GetAspect<ny>(), awx, atp.a, false));
					qy.ad().Add(new bm3(500));
					qy.ad().Add(new g1(this.n.ao().GetAspect<ny>(), awx2, atp.a, false));
					qy.ad().Add(new bm3(2000));
					qy.ad().Add(new a8v(this.o.ao(), e6z.ao().Zone.g("tun2exit").Location));
					e6z.ao().Zone.ActionManager.g9(qy, atp.a);
				}
			}
			return true;
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x00224AF4 File Offset: 0x00222CF4
		internal bool c(e6d A_0)
		{
			if (this.b.ao() != null)
			{
				this.b.ao().VisualDirection = HorizontalDirection.West;
			}
			return true;
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00224B1C File Offset: 0x00222D1C
		internal bool d(e6d A_0)
		{
			if (this.b.ao() != null)
			{
				c0s aspect = (this.b.ao() as c5x).GetAspect<c0s>();
				if (aspect != null)
				{
					aspect.a("На нас напали! Тревога!", true, null, null);
				}
			}
			return true;
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x00224B78 File Offset: 0x00222D78
		internal bool b(e6d A_0)
		{
			if (this.a.ao() != null)
			{
				c0s aspect = (this.a.ao() as c5x).GetAspect<c0s>();
				if (aspect != null)
				{
					aspect.a("Это безликие!", true, null, null);
				}
			}
			return true;
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x00224BD4 File Offset: 0x00222DD4
		internal bool i(e6d A_0)
		{
			this.p.a.aqu().r()["hidePlayer"] = false;
			if (this.b.ao() != null && (this.b.ao() as c5x).h.b != null)
			{
				(this.b.ao() as c5x).h.b.ap = null;
				(this.b.ao() as c5x).h.b.aq = null;
			}
			if (this.a.ao() != null && (this.a.ao() as c5x).h.b != null)
			{
				(this.a.ao() as c5x).h.b.ap = null;
				(this.a.ao() as c5x).h.b.aq = null;
			}
			return true;
		}

		// Token: 0x04001FA5 RID: 8101
		public ar7 a;

		// Token: 0x04001FA6 RID: 8102
		public ar7 b;

		// Token: 0x04001FA7 RID: 8103
		public ar7 c;

		// Token: 0x04001FA8 RID: 8104
		public ar7 d;

		// Token: 0x04001FA9 RID: 8105
		public ar7 e;

		// Token: 0x04001FAA RID: 8106
		public ar7 f;

		// Token: 0x04001FAB RID: 8107
		public ar7 g;

		// Token: 0x04001FAC RID: 8108
		public ar7 h;

		// Token: 0x04001FAD RID: 8109
		public ar7 i;

		// Token: 0x04001FAE RID: 8110
		public ar7 j;

		// Token: 0x04001FAF RID: 8111
		public ar7 k;

		// Token: 0x04001FB0 RID: 8112
		public ar7 l;

		// Token: 0x04001FB1 RID: 8113
		public ar7 m;

		// Token: 0x04001FB2 RID: 8114
		public ar7 n;

		// Token: 0x04001FB3 RID: 8115
		public ar7 o;

		// Token: 0x04001FB4 RID: 8116
		public evx.a p;
	}
}
