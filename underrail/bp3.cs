using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000C95 RID: 3221
[e79("Gms_Vault1_PlayerPushRock")]
public sealed class bp3 : dgy
{
	// Token: 0x060048F6 RID: 18678 RVA: 0x001DC82C File Offset: 0x001DAA2C
	public bp3()
	{
		bp3.b b = new bp3.b();
		base..ctor();
		b.a = this;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			b.b = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.b != null)
			{
				b.b.i.b.a(true, false);
				b.c = b.b.Area;
				if (b.c != null)
				{
					if (b.b.Location.X >= 9f && b.b.Location.X <= 10f && (double)b.b.Location.Y >= 2.5 && b.b.Location.Y <= 4f)
					{
						bp3.a a = new bp3.a();
						a.b = b;
						a.a = (new ar7(new Guid("c3c00b07-6a16-4e02-b9b5-3205208ebe28"), a.b.b.Area).ao() as c5x);
						if (a.a != null)
						{
							base.a(new btm[]
							{
								new ace(new e80(false))
							});
							btm[] array = new btm[1];
							int num = 0;
							dky dky = new dky();
							dky.a(0.2f);
							dky.a(false);
							array[num] = dky;
							base.a(array);
							base.a(new btm[]
							{
								new os(TimeSpan.FromSeconds(1.0))
							});
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(a.a), null, null, null)
							});
							this.a(a.b.b);
							return;
						}
					}
					else if (b.b.Location.X >= 31f && b.b.Location.X <= 33f && b.b.Location.Y >= 19f && b.b.Location.Y <= 21f)
					{
						bp3.d d = new bp3.d();
						d.b = b;
						d.a = (new ar7(new Guid("38d853fd-778e-49cc-8d86-71ef08ceb3af"), d.b.b.Area).ao() as c5x);
						if (d.a != null)
						{
							base.a(new btm[]
							{
								new ace(new e80(false))
							});
							btm[] array2 = new btm[1];
							int num2 = 0;
							dky dky2 = new dky();
							dky2.a(0.2f);
							dky2.a(false);
							array2[num2] = dky2;
							base.a(array2);
							base.a(new btm[]
							{
								new os(TimeSpan.FromSeconds(1.0))
							});
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(d.a), null, null, null)
							});
							this.a(d.b.b);
						}
					}
				}
			}
		}
	}

	// Token: 0x060048F7 RID: 18679 RVA: 0x001DCB5C File Offset: 0x001DAD5C
	public void a(aud A_0, int A_1, int A_2, int A_3, int A_4)
	{
		for (int i = A_1; i <= A_2; i++)
		{
			for (int j = A_3; j <= A_4; j++)
			{
				ak1 ak = A_0.b(i, j);
				if (ak != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
					{
						c5x c5x = (c5x)b0b;
						if (c5x.Layer == aju.x && c5x.h.b != null && !c5x.h.b.aa().Dead)
						{
							c5x.h.b.a(null, false);
						}
					}
				}
			}
		}
	}

	// Token: 0x060048F8 RID: 18680 RVA: 0x001DCC44 File Offset: 0x001DAE44
	public void a(aud A_0, int A_1)
	{
		if (A_1 == 2)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "gms_vault1_l2") + ".uzl");
			A_0.Zone.a(a_, 1, null);
			return;
		}
		if (A_1 == 3)
		{
			doq a_2 = doq.a(Path.Combine(d5x.q(), "gms_vault1_l3") + ".uzl");
			A_0.Zone.a(a_2, 1, null);
		}
	}

	// Token: 0x060048F9 RID: 18681 RVA: 0x001DCCBC File Offset: 0x001DAEBC
	public void a(c5x A_0)
	{
		bp3.c c = new bp3.c();
		c.a = A_0.c();
		base.a(new btm[]
		{
			new os(TimeSpan.FromSeconds(1.0))
		});
		base.a(new btm[]
		{
			new dva(null, new Func<e6d, bool>(c.c), null, null, null)
		});
		base.a(new btm[]
		{
			new os(TimeSpan.FromSeconds(1.1))
		});
		base.a(new btm[]
		{
			new dva(null, new Func<e6d, bool>(c.a), null, null, null)
		});
		base.a(new btm[]
		{
			new os(TimeSpan.FromSeconds(0.75))
		});
		base.a(new btm[]
		{
			new dva(null, new Func<e6d, bool>(c.b), null, null, null)
		});
		btm[] array = new btm[1];
		int num = 0;
		c8s c8s = new c8s();
		c8s.a(0.2f);
		c8s.IsAsync = false;
		array[num] = c8s;
		base.a(array);
		base.a(new btm[]
		{
			new os(TimeSpan.FromSeconds(2.0))
		});
		base.a(new btm[]
		{
			new ace(new e80(true))
		});
	}

	// Token: 0x02000C96 RID: 3222
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x04001CCE RID: 7374
		public bp3 a;

		// Token: 0x04001CCF RID: 7375
		public c5x b;

		// Token: 0x04001CD0 RID: 7376
		public aud c;
	}

	// Token: 0x02000C97 RID: 3223
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060048FC RID: 18684 RVA: 0x001DCE24 File Offset: 0x001DB024
		internal bool a(e6d A_0)
		{
			this.b.a.a(this.b.c, 10, 35, 2, 9);
			this.b.a.a(this.b.c, 2);
			c5x c5x = new ar7(new Guid("cbd03b71-4a57-49f0-a704-b8c40c980a38"), this.b.b.Area).ao() as c5x;
			if (c5x != null)
			{
				this.a.an();
				c5x.an();
			}
			return true;
		}

		// Token: 0x04001CD1 RID: 7377
		public c5x a;

		// Token: 0x04001CD2 RID: 7378
		public bp3.b b;
	}

	// Token: 0x02000C98 RID: 3224
	[CompilerGenerated]
	private new sealed class d
	{
		// Token: 0x060048FE RID: 18686 RVA: 0x001DCEC0 File Offset: 0x001DB0C0
		internal bool a(e6d A_0)
		{
			this.b.a.a(this.b.c, 32, 36, 22, 37);
			this.b.a.a(this.b.c, 3);
			c5x c5x = new ar7(new Guid("747b13d6-cb80-4ac3-88ac-2d57f97d0fae"), this.b.b.Area).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("d9910739-ba7c-4322-9e23-3237a455ea3a"), this.b.b.Area).ao() as c5x;
			if (c5x != null && c5x2 != null)
			{
				this.a.an();
				c5x.an();
				c5x2.an();
			}
			return true;
		}

		// Token: 0x04001CD3 RID: 7379
		public c5x a;

		// Token: 0x04001CD4 RID: 7380
		public bp3.b b;
	}

	// Token: 0x02000C99 RID: 3225
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004900 RID: 18688 RVA: 0x001DCF90 File Offset: 0x001DB190
		internal bool c(e6d A_0)
		{
			this.a.a("rock", "RockCrash", 1f, c9z.a, false, false);
			return true;
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x001DCFB4 File Offset: 0x001DB1B4
		internal bool a(e6d A_0)
		{
			this.a.a("rock1", "DestructableRocksDestroyed", 0.75f, c9z.a, false, false);
			return true;
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x001DCFD8 File Offset: 0x001DB1D8
		internal bool b(e6d A_0)
		{
			this.a.a("rock2", "RockCrash", 0.35f, c9z.a, false, false);
			return true;
		}

		// Token: 0x04001CD5 RID: 7381
		public aru a;
	}
}
