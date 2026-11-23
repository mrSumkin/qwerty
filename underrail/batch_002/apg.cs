using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000E87 RID: 3719
[e79("Cv_CampHathorBurrowerRocksRemoved")]
public sealed class apg : dgy
{
	// Token: 0x06004D46 RID: 19782 RVA: 0x002218CC File Offset: 0x0021FACC
	public apg()
	{
		apg.c c = new apg.c();
		c.a = bpo.GetServiceOrThrow<cnk>();
		if (c.a != null && c.a.aqu() != null)
		{
			c5x c5x = c.a.aqu().v().b() as c5x;
			if (c5x != null && c5x.Zone != null)
			{
				c5x.i.b.a(true, false);
				c.c = c5x.Zone.n("cv18");
				c.b = c5x.Zone.n("cv18-a");
				if (c.c != null && c.b != null)
				{
					apg.d d = new apg.d();
					d.b = c;
					d.a = (new ar7(new Guid("c49f3b95-b8eb-4226-b7f0-7bf2f8c21826"), d.b.b).ao() as c5x);
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(d.b.d));
					array[num] = dva;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(d.a));
					array2[num2] = dva2;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					kw kw = new kw();
					kw.a(true);
					kw.a(new bt4(d.b.b.y8(), new Vector3(5f, 9f, 0f)));
					array3[num3] = kw;
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					for (int i = 2; i <= 5; i++)
					{
						apg.a a = new apg.a();
						a.b = d;
						a.a = i;
						btm[] array4 = new btm[1];
						int num4 = 0;
						dva dva3 = new dva(null, null, null, null, null);
						dva3.a(new Func<e6d, bool>(a.a));
						array4[num4] = dva3;
						base.a(array4);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					for (int j = 2; j <= 5; j++)
					{
						apg.b b = new apg.b();
						b.b = d;
						b.a = j;
						btm[] array5 = new btm[1];
						int num5 = 0;
						dva dva4 = new dva(null, null, null, null, null);
						dva4.a(new Func<e6d, bool>(b.a));
						array5[num5] = dva4;
						base.a(array5);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
					}
					btm[] array6 = new btm[1];
					int num6 = 0;
					dva dva5 = new dva(null, null, null, null, null);
					dva5.a(new Func<e6d, bool>(d.b.a));
					array6[num6] = dva5;
					base.a(array6);
					btm[] array7 = new btm[1];
					int num7 = 0;
					dva dva6 = new dva(null, null, null, null, null);
					dva6.a(new Func<e6d, bool>(d.b.e));
					array7[num7] = dva6;
					base.a(array7);
					btm[] array8 = new btm[1];
					int num8 = 0;
					dva dva7 = new dva(null, null, null, null, null);
					dva7.a(new Func<e6d, bool>(d.b.c));
					array8[num8] = dva7;
					base.a(array8);
					btm[] array9 = new btm[1];
					int num9 = 0;
					kw kw2 = new kw();
					kw2.a(true);
					kw2.a(new bt4(c5x.Area.y8(), c5x.Location));
					array9[num9] = kw2;
					base.a(array9);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					dva dva8 = new dva(null, null, null, null, null);
					dva8.a(new Func<e6d, bool>(d.b.b));
					array10[num10] = dva8;
					base.a(array10);
					btm[] array11 = new btm[1];
					int num11 = 0;
					dva dva9 = new dva(null, null, null, null, null);
					dva9.a(new Func<e6d, bool>(d.b));
					array11[num11] = dva9;
					base.a(array11);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E88 RID: 3720
	[CompilerGenerated]
	[Serializable]
	private new sealed class e
	{
		// Token: 0x06004D49 RID: 19785 RVA: 0x00221D68 File Offset: 0x0021FF68
		internal bool b(ya A_0)
		{
			return A_0.Name == "GoUp";
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x00221D7C File Offset: 0x0021FF7C
		internal bool a(ya A_0)
		{
			return A_0.Name == "GoDown";
		}

		// Token: 0x04001F8D RID: 8077
		public static readonly apg.e a = new apg.e();

		// Token: 0x04001F8E RID: 8078
		public static Func<ya, bool> b;

		// Token: 0x04001F8F RID: 8079
		public static Func<ya, bool> c;
	}

	// Token: 0x02000E89 RID: 3721
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004D4C RID: 19788 RVA: 0x00221D98 File Offset: 0x0021FF98
		internal bool d(e6d A_0)
		{
			cno cno = this.b.Divinations.a("upperArea");
			if (cno != null)
			{
				cno.a(this.a.aqu().v().c());
				cno.g();
			}
			return true;
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x00221DE4 File Offset: 0x0021FFE4
		internal bool a(e6d A_0)
		{
			ya ya = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(this.c.Triggers, new Func<ya, bool>(apg.e.a.b)));
			if (ya != null)
			{
				ya.o();
			}
			ya ya2 = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(this.c.Triggers, new Func<ya, bool>(apg.e.a.a)));
			if (ya2 != null)
			{
				ya2.o();
			}
			return true;
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x00221E7C File Offset: 0x0022007C
		internal bool e(e6d A_0)
		{
			cno cno = this.b.Divinations.a("upperArea");
			if (cno != null)
			{
				cno.b();
				cno.g();
			}
			return true;
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x00221EB4 File Offset: 0x002200B4
		internal bool c(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cv18_l6") + ".uzl");
			this.b.Zone.a(a_, 1, null);
			return true;
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x00221EF4 File Offset: 0x002200F4
		internal bool b(e6d A_0)
		{
			List<amc> list = new List<amc>();
			foreach (b0b b0b in this.c.Entities)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.Layer == 1 && c5x.h != null && c5x.h.b != null && c5x.l.Count > 0 && c5x.l[0].Formation.a(6))
				{
					list.Add(c5x.h.b);
				}
			}
			foreach (amc amc in list)
			{
				amc.a(null, false);
			}
			return true;
		}

		// Token: 0x04001F90 RID: 8080
		public cnk a;

		// Token: 0x04001F91 RID: 8081
		public aud b;

		// Token: 0x04001F92 RID: 8082
		public aud c;
	}

	// Token: 0x02000E8A RID: 3722
	[CompilerGenerated]
	private new sealed class d
	{
		// Token: 0x06004D52 RID: 19794 RVA: 0x00222008 File Offset: 0x00220208
		internal bool a(e6d A_0)
		{
			if (this.a != null)
			{
				new b1a(this.b.a.aqu().v().c()).be(this.a);
			}
			return true;
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x0022204C File Offset: 0x0022024C
		internal bool b(e6d A_0)
		{
			if (this.a != null)
			{
				this.a.w();
			}
			return true;
		}

		// Token: 0x04001F93 RID: 8083
		public c5x a;

		// Token: 0x04001F94 RID: 8084
		public apg.c b;
	}

	// Token: 0x02000E8B RID: 3723
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D55 RID: 19797 RVA: 0x00222070 File Offset: 0x00220270
		internal bool a(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cv18_l" + this.a.ToString()) + ".uzl");
			this.b.b.b.Zone.a(a_, this.a, null);
			return true;
		}

		// Token: 0x04001F95 RID: 8085
		public int a;

		// Token: 0x04001F96 RID: 8086
		public apg.d b;
	}

	// Token: 0x02000E8C RID: 3724
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004D57 RID: 19799 RVA: 0x002220DC File Offset: 0x002202DC
		internal bool a(e6d A_0)
		{
			List<b0b> list = new List<b0b>();
			foreach (b0b b0b in this.b.b.b.Entities)
			{
				if (b0b.Layer == this.a)
				{
					list.Add(b0b);
				}
			}
			foreach (b0b b0b2 in list)
			{
				b0b2.w();
				b0b2.an();
			}
			return true;
		}

		// Token: 0x04001F97 RID: 8087
		public int a;

		// Token: 0x04001F98 RID: 8088
		public apg.d b;
	}
}
