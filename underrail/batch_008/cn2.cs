using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000D22 RID: 3362
[e79("Cc_FixSecondPipe")]
public sealed class cn2 : dgy
{
	// Token: 0x06004A44 RID: 19012 RVA: 0x001F5CA4 File Offset: 0x001F3EA4
	public cn2()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				cn2.a a = new cn2.a();
				c5x c5x2 = new ar7(new Guid("c79d0b8c-0e2d-45bd-8b9f-82ca6bca9c0e"), c5x.Area).ao() as c5x;
				a.a = new Point(0, 0);
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

	// Token: 0x02000D23 RID: 3363
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A46 RID: 19014 RVA: 0x001F5E30 File Offset: 0x001F4030
		internal bool a(e6d A_0)
		{
			this.b.b = this.a;
			return true;
		}

		// Token: 0x04001D9F RID: 7583
		public Point a;

		// Token: 0x04001DA0 RID: 7584
		public cd0 b;
	}
}
