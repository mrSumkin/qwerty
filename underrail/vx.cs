using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000DA2 RID: 3490
[e79("TchortDeath")]
public sealed class vx : dgy
{
	// Token: 0x06004B74 RID: 19316 RVA: 0x0020A03C File Offset: 0x0020823C
	public vx()
	{
		vx.e e = new vx.e();
		e.a = bpo.GetServiceOrThrow<cnk>();
		if (e.a != null && e.a.aqu() != null)
		{
			vx.d d = new vx.d();
			bool value = e.a.aqu().r().GetPrimitivePropertyValue<bool>("dc_tchortPoisoned", new bool?(false)).Value;
			d.a = (e.a.aqu().v().b() as c5x);
			if (d.a != null && d.a.Zone != null)
			{
				vx.c c = new vx.c();
				e.a.aqu().r()["global_TchortDefeated"] = true;
				e.a.aqu().r()["loc_cc_facelessRetreated"] = true;
				new gc().ym(null, null, null);
				cxc.c(eyy.a2);
				e.a.aqu().a(new bw0("dc-de2", new bow(), 1));
				e.a.aqu().a(new bw0("dc-tch", new eb3(), 1));
				e.a.aqu().a(new bw0("dc-flo", new dbk(), 1));
				e.a.aqu().a(new bw0("lu-c5", new di5(), 1));
				c.f = d.a.Zone.a();
				c.g = (new ar7(new Guid("24146c99-969c-4e34-a3f8-783684060623"), d.a.Area).ao() as c5x);
				c.d = (new ar7(new Guid("66db6432-bd33-48fc-8418-f6ccfe7f683a"), d.a.Area).ao() as c5x);
				c.c = (new ar7(new Guid("b8b4f4b9-644a-4269-a47f-b44799583ca0"), d.a.Area).ao() as c5x);
				c.b = (new ar7(new Guid("8c54569e-d4a4-43ac-bd20-0105f9fc41d4"), d.a.Area).ao() as c5x);
				c.a = (new ar7(new Guid("2db0a8b4-438a-47fd-b94b-5ed620c4cd09"), d.a.Area).ao() as c5x);
				c.e = (new ar7(new Guid("6633060b-43cd-4f22-b8e9-4d59546cd817"), d.a.Area).ao() as c5x);
				List<b0b> list = new List<b0b>();
				List<b0b> collection = c.f.ab4(new string[]
				{
					"primeTentacle"
				});
				list.AddRange(collection);
				List<b0b> collection2 = c.f.ab4(new string[]
				{
					"tentacleTumor"
				});
				list.AddRange(collection2);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				if (c.a != null)
				{
					if (c.e.s.b != null)
					{
						c.e.s.b.g(true);
					}
					if (c.a.o.b != null)
					{
						c.a.o.b.b = new Point(3, 0);
					}
					c.a.RemoveAspect<b6v>();
					btm[] array = new btm[1];
					int num = 0;
					c6w c6w = new c6w();
					c6w.a = new Func<auv>(c.a);
					c6w.a(atp.a);
					c6w.a(new ar7(c.a));
					c6w.IsAsync = true;
					array[num] = c6w;
					base.a(array);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.3))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(d.a));
				array2[num2] = dva;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				kw kw = new kw();
				kw.a(new bt4("tchortCam"));
				kw.a(false);
				kw.IsAsync = true;
				kw.a(new float?(6f));
				array3[num3] = kw;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					vx.b b = new vx.b();
					int index = cuo.a.Next(list.Count);
					b.a = (list[index] as c5x);
					list.RemoveAt(index);
					btm[] array4 = new btm[1];
					int num4 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(b.a));
					array4[num4] = dva2;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.2 + cuo.a.NextDouble() * 0.2))
					});
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(c.a));
				array5[num5] = dva3;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(c.c));
				array6[num6] = dva4;
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				dva dva5 = new dva(null, null, null, null, null);
				dva5.a(new Func<e6d, bool>(d.b));
				array7[num7] = dva5;
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				dva dva6 = new dva(null, null, null, null, null);
				dva6.a(new Func<e6d, bool>(e.a));
				array8[num8] = dva6;
				base.a(array8);
				btm[] array9 = new btm[1];
				int num9 = 0;
				dva dva7 = new dva(null, null, null, null, null);
				dva7.a(new Func<e6d, bool>(c.b));
				array9[num9] = dva7;
				base.a(array9);
				base.a(new btm[]
				{
					new ace(new dvn("dc-tchb", "MutagenTanks"))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000DA3 RID: 3491
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004B77 RID: 19319 RVA: 0x0020A714 File Offset: 0x00208914
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04001E50 RID: 7760
		public static readonly vx.a a = new vx.a();

		// Token: 0x04001E51 RID: 7761
		public static Func<b0b, bool> b;
	}

	// Token: 0x02000DA4 RID: 3492
	[CompilerGenerated]
	private new sealed class e
	{
		// Token: 0x06004B79 RID: 19321 RVA: 0x0020A728 File Offset: 0x00208928
		internal bool a(e6d A_0)
		{
			this.a.aqz().atc("dc_killTchort", true);
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x04001E52 RID: 7762
		public cnk a;
	}

	// Token: 0x02000DA5 RID: 3493
	[CompilerGenerated]
	private new sealed class d
	{
		// Token: 0x06004B7B RID: 19323 RVA: 0x0020A768 File Offset: 0x00208968
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.ane(100000, new int?(3), new int?(6), new int?(3), new int?(6), new int?(15));
			}
			this.a.c().a("earthquake", "Earthquake", 1f, c9z.a, true, false);
			return true;
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x0020A7D0 File Offset: 0x002089D0
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.ane(0, null, null, null, null, null);
			}
			this.a.c().a("earthquake", false);
			return true;
		}

		// Token: 0x04001E53 RID: 7763
		public c5x a;
	}

	// Token: 0x02000DA6 RID: 3494
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004B7E RID: 19326 RVA: 0x0020A844 File Offset: 0x00208A44
		internal auv a()
		{
			dtb dtb = new dtb();
			int num = 100;
			for (int i = 0; i < num; i++)
			{
				Vector3 a_ = new Vector3(30f + (float)(-1.5 + cuo.a.NextDouble() * 3.0), 4f, 0.3f + (float)(cuo.a.NextDouble() * 1.5));
				dtb.ad().Add(new au0(this.a.Area, a_, "TchortBlood" + (cuo.a.Next(3) + 1).ToString(), 1, double.MaxValue, null, null, null));
				dtb.ad().Add(new bm3(50 + cuo.a.Next(25)));
				if (i % 6 == 0)
				{
					dtb.ad().Add(new a4s(new bfq("TentacleTumorBurst"), null, new ar7(this.a), null));
				}
			}
			return dtb;
		}

		// Token: 0x06004B7F RID: 19327 RVA: 0x0020A96C File Offset: 0x00208B6C
		internal bool a(e6d A_0)
		{
			if (this.b != null)
			{
				boj.a(this.b, "TchortEyeExplode", 1, double.MaxValue, true, true, null, null, null, null, false);
				this.b.c().a("TentacleTumorBurst");
				if (this.b.o.b != null)
				{
					this.b.o.b.b = new Point(1, 0);
				}
			}
			List<c5x> list = new List<c5x>();
			if (this.c != null)
			{
				list.Add(this.c);
			}
			if (this.d != null)
			{
				list.Add(this.d);
			}
			foreach (c5x c5x in list)
			{
				if (c5x.s.b != null)
				{
					c5x.s.b.g(true);
				}
				if (c5x.o.b != null)
				{
					c5x.o.b.d = null;
				}
			}
			return true;
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x0020AAD0 File Offset: 0x00208CD0
		internal bool c(e6d A_0)
		{
			if (this.a != null)
			{
				this.a.o.b.d = new float?(0f);
				boj.a(this.a, "TchortEyeExplode", 1, double.MaxValue, true, true, null, null, null, null, false);
				this.a.c().a("TentacleTumorBurst");
			}
			if (this.e != null)
			{
				this.e.o.b.d = null;
			}
			return true;
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x0020AB88 File Offset: 0x00208D88
		internal bool b(e6d A_0)
		{
			foreach (b0b b0b in this.f.ab4(new string[]
			{
				"tchortlingSurger"
			}))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && !c5x.h.b.aa().Dead)
				{
					bv0 a_ = new bv0(0);
					c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
				}
			}
			if (this.g != null && this.g.h.b != null && !this.g.h.b.aa().Dead)
			{
				bv0 a_2 = new bv0(0);
				this.g.h.b.aa().StatusEffects.a(a_2, false, false, false);
			}
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001E54 RID: 7764
		public c5x a;

		// Token: 0x04001E55 RID: 7765
		public c5x b;

		// Token: 0x04001E56 RID: 7766
		public c5x c;

		// Token: 0x04001E57 RID: 7767
		public c5x d;

		// Token: 0x04001E58 RID: 7768
		public c5x e;

		// Token: 0x04001E59 RID: 7769
		public d60 f;

		// Token: 0x04001E5A RID: 7770
		public c5x g;
	}

	// Token: 0x02000DA7 RID: 3495
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004B83 RID: 19331 RVA: 0x0020ACCC File Offset: 0x00208ECC
		internal bool a(e6d A_0)
		{
			if (this.a != null && this.a.Area != null && this.a.j == cgy.b)
			{
				if (this.a.h.b != null)
				{
					if (!this.a.h.b.aa().Dead)
					{
						this.a.h.b.aa().a(null, null, false);
					}
				}
				else
				{
					boj.a(this.a.Area, this.a.Location, null, "TentacleTumorBurst", 1, double.MaxValue, null, null, null, null);
					c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.FirstOrDefault<ak1>(this.a.l).c.Values, new Func<b0b, bool>(vx.a.a.a))) as c5x;
					if (c5x != null)
					{
						c5x.c().a("TentacleTumorBurst");
					}
					this.a.w();
					this.a.an();
				}
			}
			return true;
		}

		// Token: 0x04001E5B RID: 7771
		public c5x a;
	}
}
