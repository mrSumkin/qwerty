using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000CD2 RID: 3282
[e79("Xpbl_As_ForceToddToPanel")]
public sealed class adh : dgy
{
	// Token: 0x060049A6 RID: 18854 RVA: 0x001EC150 File Offset: 0x001EA350
	public adh()
	{
		adh.b b = new adh.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			b.b = (b.a.aqu().v().b() as c5x);
			b.c = (new ar7(new Guid("8b993b71-2472-446c-a9ba-30099404c50d"), b.b.Area).ao() as c5x);
			c5x c5x = new ar7(new Guid("8ea35f6c-8bf0-4636-8a63-16cfb1e228ed"), b.b.Area).ao() as c5x;
			int num = b.b.h.b.aa().BaseAbilities.Strength * 10;
			b.d = b.b.Area;
			if (b.c != null && c5x != null)
			{
				adh.a a = new adh.a();
				a.d = b;
				bool value = a.d.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_as_todd_wrestledIntoOpeningGate", new bool?(false)).Value;
				bool value2 = a.d.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_as_todd_intimidatedIntoOpeningGate", new bool?(false)).Value;
				bool value3 = a.d.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_as_todd_dirtykickedIntoOpeningGate", new bool?(false)).Value;
				bool value4 = a.d.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_as_todd_unlockedWillingly", new bool?(false)).Value;
				a.a = false;
				if (value || value2 || value4)
				{
					a.a = true;
				}
				if (value3)
				{
					num *= 2;
					a.d.a.aqu().r()["npc_xpbl_as_todd_dirtykickedIntoOpeningGate"] = false;
				}
				if (!value4)
				{
					a.d.a.aqu().r()["npc_xpbl_as_todd_afraid"] = true;
					eaq eaq = new eaq();
					eaq.b(asp.f3);
					eaq.a(asp.a);
					eaq.a(h.b);
					eaq.a(true);
					eaq.ym(null, null, null);
				}
				a.d.c.z = null;
				a.d.c.ah();
				ak1 a_ = a.d.d.b(5, 25);
				ale aspect = a.d.b.GetAspect<ale>();
				a.c = new HashSet<ak1>();
				a.b = new List<yz>();
				if (aspect != null)
				{
					fk fk = new fk(aspect, a_, null, false, 0);
					fk.l();
					czp czp = fk.g();
					czp.n.a = false;
					czp.p = true;
					czp.q = true;
					d25 d = czp.l as d25;
					if (d == null)
					{
						d = new d25();
						czp.l = d;
					}
					if (d.h == null)
					{
						d25 d2 = d;
						HashSet<Guid> hashSet = new HashSet<Guid>();
						hashSet.Add(a.d.c.qe());
						d2.h = hashSet;
					}
					else
					{
						d.h.Add(a.d.b.qe());
					}
					d.b = true;
					d.c = true;
					c5w c5w = bpo.GetServiceOrThrow<wu>().aki(czp, aspect.a8().Playfield.PathProcessor, eso.d);
					c5w.au1();
					if (a.a)
					{
						a.b = c5w.aus();
					}
					else
					{
						int num2 = 0;
						int num3 = 0;
						while (num3 < c5w.aus().Count && num2 < num)
						{
							a.b.Add(c5w.aus()[num3]);
							num2++;
							num3++;
						}
					}
					if (!a.a && (int)a.b[a.b.Count - 1].a.a.X / 4 > 5 && (int)a.b[a.b.Count - 1].a.a.X / 4 < 7 && (int)a.b[a.b.Count - 1].a.a.Y / 4 > 21 && (int)a.b[a.b.Count - 1].a.a.Y / 4 < 27)
					{
						a.a = true;
					}
					foreach (yz yz in a.b)
					{
						int a_2 = (int)yz.a.a.X / 4;
						int a_3 = (int)yz.a.a.Y / 4;
						ak1 ak = a.d.d.b(a_2, a_3);
						a.c.Add(ak);
					}
				}
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array = new btm[1];
				int num4 = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array[num4] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				btm[] array2 = new btm[1];
				int num5 = 0;
				c6w c6w = new c6w();
				c6w.a(new ar7(a.d.c));
				c6w.IsAsync = false;
				c6w.a = new Func<auv>(a.a);
				array2[num5] = c6w;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num6 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array3[num6] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.d.a), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000CD3 RID: 3283
	[CompilerGenerated]
	[Serializable]
	private sealed class c
	{
		// Token: 0x060049A9 RID: 18857 RVA: 0x001EC864 File Offset: 0x001EAA64
		internal bool a(c5x A_0)
		{
			return A_0.s.b is cnb;
		}

		// Token: 0x04001D2E RID: 7470
		public static readonly adh.c a = new adh.c();

		// Token: 0x04001D2F RID: 7471
		public static Func<c5x, bool> b;
	}

	// Token: 0x02000CD4 RID: 3284
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x060049AB RID: 18859 RVA: 0x001EC888 File Offset: 0x001EAA88
		internal bool a(e6d A_0)
		{
			this.a.aqu().r()["npc_xpbl_as_todd_afterCutscene"] = true;
			this.b.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001D30 RID: 7472
		public cnk a;

		// Token: 0x04001D31 RID: 7473
		public c5x b;

		// Token: 0x04001D32 RID: 7474
		public c5x c;

		// Token: 0x04001D33 RID: 7475
		public aud d;
	}

	// Token: 0x02000CD5 RID: 3285
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049AD RID: 18861 RVA: 0x001EC8E4 File Offset: 0x001EAAE4
		internal bool a(e6d A_0)
		{
			if (this.a)
			{
				a0l.a(this.d.b, "playerMove", true);
				a0l.a(this.d.c, "RnDConsole", true);
			}
			else
			{
				float x = this.b[this.b.Count - 1].a.a.X / 4f;
				float y = this.b[this.b.Count - 1].a.a.Y / 4f;
				a0l.a(this.d.b, this.d.d, new Vector3(x, y, 0f), null, true);
				float x2 = this.b[this.b.Count - 5].a.a.X / 4f;
				float y2 = this.b[this.b.Count - 5].a.a.Y / 4f;
				a0l.a(this.d.c, this.d.d, new Vector3(x2, y2, 0f), null, true);
				aw1.b(this.d.c, this.d.b, false);
				aw1.b(this.d.b, this.d.b, false);
			}
			bpo.GetServiceOrThrow<ps>().amt(this.d.d, new Vector3(this.d.b.Location.X, this.d.b.Location.Y, 0f), true, null);
			this.d.c.z = new Vector2?(new Vector2(0.75f, 0.75f));
			return true;
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x001ECAFC File Offset: 0x001EACFC
		internal auv a()
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			foreach (ak1 ak in this.c)
			{
				if (ak != null)
				{
					if (Enumerable.FirstOrDefault<c5x>(Enumerable.Where<c5x>(Enumerable.OfType<c5x>(ak.c.Values), new Func<c5x, bool>(adh.c.a.a))) != null)
					{
						awx.ad().Add(new dnf(this.d.c, ak));
					}
				}
			}
			return awx;
		}

		// Token: 0x04001D34 RID: 7476
		public bool a;

		// Token: 0x04001D35 RID: 7477
		public List<yz> b;

		// Token: 0x04001D36 RID: 7478
		public HashSet<ak1> c;

		// Token: 0x04001D37 RID: 7479
		public adh.b d;
	}
}
