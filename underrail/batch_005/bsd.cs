using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E71 RID: 3697
[e79("Fo_ChiefEvelyn")]
public sealed class bsd : dgy
{
	// Token: 0x06004D24 RID: 19748 RVA: 0x0021F6C8 File Offset: 0x0021D8C8
	public bsd()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bsd.a a = new bsd.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("f523f820-d063-4f3b-9229-c64fb2b69f83"), a.a.Area).ao() as c5x);
				if (a.b != null)
				{
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
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E72 RID: 3698
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D26 RID: 19750 RVA: 0x0021F848 File Offset: 0x0021DA48
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F76 RID: 8054
		public c5x a;

		// Token: 0x04001F77 RID: 8055
		public c5x b;
	}
}
