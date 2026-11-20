using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000E25 RID: 3621
[e79("Tch_DenzilSendsRassosInside")]
public sealed class m1 : dgy
{
	// Token: 0x06004C8B RID: 19595 RVA: 0x002177C0 File Offset: 0x002159C0
	public m1()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			m1.b b = new m1.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null && b.a.Area != null)
			{
				c5x a_ = new ar7(new Guid("c020d889-a56e-4f8e-b307-2c2b2ca319cb"), b.a.Area).ao() as c5x;
				c5x a_2 = new ar7(new Guid("7a3ad5f1-b703-437a-bea3-19ef6b934b81"), b.a.Area).ao() as c5x;
				c5x a_3 = new ar7(new Guid("df2440be-6fd1-4bf4-9ebb-5992151c997a"), b.a.Area).ao() as c5x;
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				a5 a = new a5();
				a.a(new ar7(a_));
				array2[num2] = a;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				a5 a2 = new a5();
				a2.a(new ar7(a_2));
				array3[num3] = a2;
				base.a(array3);
				btm[] array4 = new btm[1];
				int num4 = 0;
				a5 a3 = new a5();
				a3.a(new ar7(a_3));
				array4[num4] = a3;
				base.a(array4);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				kw kw = new kw();
				kw.a(new bt4("tch-entry", new Vector3(20f, 39f, 0f)));
				kw.IsAsync = true;
				kw.a(true);
				array5[num5] = kw;
				base.a(array5);
				btm[] array6 = new btm[1];
				int num6 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(m1.a.a.a));
				array6[num6] = dva;
				base.a(array6);
				btm[] array7 = new btm[1];
				int num7 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array7[num7] = c8s;
				base.a(array7);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000E26 RID: 3622
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004C8E RID: 19598 RVA: 0x00217A80 File Offset: 0x00215C80
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001F03 RID: 7939
		public static readonly m1.a a = new m1.a();

		// Token: 0x04001F04 RID: 7940
		public static Func<e6d, bool> b;
	}

	// Token: 0x02000E27 RID: 3623
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004C90 RID: 19600 RVA: 0x00217AB0 File Offset: 0x00215CB0
		internal bool a(e6d A_0)
		{
			a9d a9d = new a9d();
			a9d.a(this.a.Area.y8());
			a9d.b(new Guid("63bd9c04-2b65-4217-9efb-908a62413b49"));
			a9d.a(new Guid("026e0861-7347-45ff-9729-d9dbd1fef40c"));
			a9d.a(bbo.c);
			a9d.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001F05 RID: 7941
		public c5x a;
	}
}
