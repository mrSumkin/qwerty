using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E23 RID: 3619
[e79("Tch_DenzilLeaves")]
public sealed class a0n : dgy
{
	// Token: 0x06004C88 RID: 19592 RVA: 0x00217628 File Offset: 0x00215828
	public a0n()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			a0n.a a = new a0n.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.b = (new ar7(new Guid("34bad129-029c-4035-81ff-b53872584b91"), a.a.Area).ao() as c5x);
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
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array2[num2] = c8s;
				base.a(array2);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000E24 RID: 3620
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C8A RID: 19594 RVA: 0x00217790 File Offset: 0x00215990
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F01 RID: 7937
		public c5x a;

		// Token: 0x04001F02 RID: 7938
		public c5x b;
	}
}
