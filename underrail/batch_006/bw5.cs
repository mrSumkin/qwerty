using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000D24 RID: 3364
[e79("Cc_FixThirdPipe")]
public sealed class bw5 : dgy
{
	// Token: 0x06004A47 RID: 19015 RVA: 0x001F5E48 File Offset: 0x001F4048
	public bw5()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				bw5.a a = new bw5.a();
				c5x c5x2 = new ar7(new Guid("6258c5c8-fa64-4a9c-b123-2507882c37ad"), c5x.Area).ao() as c5x;
				a.a = new Point(1, 0);
				if (c5x2 != null)
				{
					a.b = c5x2.GetAspect<cd0>();
					if (a.b != null)
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
							new os(TimeSpan.FromSeconds(0.5))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
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
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000D25 RID: 3365
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A49 RID: 19017 RVA: 0x001F5FD4 File Offset: 0x001F41D4
		internal bool a(e6d A_0)
		{
			this.b.b = this.a;
			return true;
		}

		// Token: 0x04001DA1 RID: 7585
		public Point a;

		// Token: 0x04001DA2 RID: 7586
		public cd0 b;
	}
}
