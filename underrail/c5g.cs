using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E5C RID: 3676
[e79("Sgs_EzraGivesThePsiAmplifier")]
public sealed class c5g : dgy
{
	// Token: 0x06004CFD RID: 19709 RVA: 0x0021DB74 File Offset: 0x0021BD74
	public c5g()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5g.a a = new c5g.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("2f3fb273-71c3-473c-9342-55a51c11bc17"), a.a.Area).ao() as c5x);
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

	// Token: 0x02000E5D RID: 3677
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CFF RID: 19711 RVA: 0x0021DCF4 File Offset: 0x0021BEF4
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F58 RID: 8024
		public c5x a;

		// Token: 0x04001F59 RID: 8025
		public c5x b;
	}
}
