using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D0B RID: 3339
[e79("Cc_GuardianLeaves")]
public sealed class ayf : dgy
{
	// Token: 0x06004A12 RID: 18962 RVA: 0x001F210C File Offset: 0x001F030C
	public ayf()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ayf.a a = new ayf.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				if (a.a.Area != null)
				{
					a.b = (new ar7(new Guid("9474a0f8-1e28-4780-997b-b565fe0c338e"), a.a.Area).ao() as c5x);
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
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
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
	}

	// Token: 0x02000D0C RID: 3340
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A14 RID: 18964 RVA: 0x001F22AC File Offset: 0x001F04AC
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001D7C RID: 7548
		public c5x a;

		// Token: 0x04001D7D RID: 7549
		public c5x b;
	}
}
