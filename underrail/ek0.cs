using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E82 RID: 3714
[e79("Rc_JaredHelped")]
public sealed class ek0 : dgy
{
	// Token: 0x06004D40 RID: 19776 RVA: 0x0022113C File Offset: 0x0021F33C
	public ek0()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				ek0.a a = new ek0.a();
				a.a = (new ar7(new Guid("dca53356-09b6-432b-8089-13d47d34d6b4"), c5x.Area).ao() as c5x);
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
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array2[num2] = c8s;
					base.a(array2);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E83 RID: 3715
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D42 RID: 19778 RVA: 0x002212A8 File Offset: 0x0021F4A8
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "jaredBar", true);
			this.a.t.b.y6()[ddq.ay] = new bt4("jaredBar");
			return true;
		}

		// Token: 0x04001F8C RID: 8076
		public c5x a;
	}
}
