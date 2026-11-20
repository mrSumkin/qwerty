using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000D20 RID: 3360
[e79("Cc_FixFirstPipe")]
public sealed class vv : dgy
{
	// Token: 0x06004A41 RID: 19009 RVA: 0x001F5B00 File Offset: 0x001F3D00
	public vv()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				vv.a a = new vv.a();
				c5x c5x2 = new ar7(new Guid("84f3083c-272e-413e-9cae-492cc2a884d4"), c5x.Area).ao() as c5x;
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

	// Token: 0x02000D21 RID: 3361
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A43 RID: 19011 RVA: 0x001F5C8C File Offset: 0x001F3E8C
		internal bool a(e6d A_0)
		{
			this.b.b = this.a;
			return true;
		}

		// Token: 0x04001D9D RID: 7581
		public Point a;

		// Token: 0x04001D9E RID: 7582
		public cd0 b;
	}
}
