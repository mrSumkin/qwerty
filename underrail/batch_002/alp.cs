using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E66 RID: 3686
[e79("Sgs_QuintonInspectLarva")]
public sealed class alp : dgy
{
	// Token: 0x06004D11 RID: 19729 RVA: 0x0021EA78 File Offset: 0x0021CC78
	public alp()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			alp.a a = new alp.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("2de12727-1d51-4dac-bc30-d3de2edb70a0"), a.a.Area).ao() as c5x);
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

	// Token: 0x02000E67 RID: 3687
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D13 RID: 19731 RVA: 0x0021EBF8 File Offset: 0x0021CDF8
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F69 RID: 8041
		public c5x a;

		// Token: 0x04001F6A RID: 8042
		public c5x b;
	}
}
