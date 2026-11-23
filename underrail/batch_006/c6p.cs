using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000E28 RID: 3624
[e79("Tch_DenzilMeetsRassophores")]
public sealed class c6p : dgy
{
	// Token: 0x06004C91 RID: 19601 RVA: 0x00217B10 File Offset: 0x00215D10
	public c6p()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c6p.c c = new c6p.c();
			c.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (c.a != null)
			{
				c.a.i.b.a(true, false);
				if (c.a.Area != null)
				{
					c6p.b b = new c6p.b();
					b.b = (new ar7(new Guid("34bad129-029c-4035-81ff-b53872584b91"), c.a.Area).ao() as c5x);
					b.a = (new ar7(new Guid("df2440be-6fd1-4bf4-9ebb-5992151c997a"), c.a.Area).ao() as c5x);
					if (b.b != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array = new btm[1];
						int num = 0;
						dva dva = new dva(null, null, null, null, null);
						dva.a(new Func<e6d, bool>(c6p.a.a.a));
						array[num] = dva;
						base.a(array);
						btm[] array2 = new btm[1];
						int num2 = 0;
						kw kw = new kw();
						kw.a(new bt4("tch-entry", new Vector3(19f, 25f, 0f)));
						kw.IsAsync = false;
						array2[num2] = kw;
						base.a(array2);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(c.a), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(4.0))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						s5 s = new s5();
						s.a(new ar7(b.b));
						s.a(new bt4("global:tch_denzil:front"));
						s.IsAsync = false;
						s.a(true);
						array3[num3] = s;
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.a), null, null, null)
						});
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000E29 RID: 3625
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004C94 RID: 19604 RVA: 0x00217DB0 File Offset: 0x00215FB0
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x04001F06 RID: 7942
		public static readonly c6p.a a = new c6p.a();

		// Token: 0x04001F07 RID: 7943
		public static Func<e6d, bool> b;
	}

	// Token: 0x02000E2A RID: 3626
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004C96 RID: 19606 RVA: 0x00217DE0 File Offset: 0x00215FE0
		internal bool a(e6d A_0)
		{
			a9d a9d = new a9d();
			a9d.a(this.a.Area.y8());
			a9d.b(new Guid("63bd9c04-2b65-4217-9efb-908a62413b49"));
			a9d.a(new Guid("026e0861-7347-45ff-9729-d9dbd1fef40c"));
			a9d.a(bbo.b);
			a9d.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001F08 RID: 7944
		public c5x a;
	}

	// Token: 0x02000E2B RID: 3627
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004C98 RID: 19608 RVA: 0x00217E4C File Offset: 0x0021604C
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F09 RID: 7945
		public c5x a;

		// Token: 0x04001F0A RID: 7946
		public c5x b;
	}
}
