using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F12 RID: 3858
[e79("Xpbl_Le_FinalReport")]
public sealed class dcg : dgy
{
	// Token: 0x06004EC5 RID: 20165 RVA: 0x00235C80 File Offset: 0x00233E80
	public dcg()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dcg.b b = new dcg.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			new ar7(b.a);
			if (b.a != null && b.a.Area != null)
			{
				dcg.a a = new dcg.a();
				a.b = b;
				a.a = (new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), a.b.a.Area).ao() as c5x);
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
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b.a), null, null, null)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.a(false);
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

	// Token: 0x02000F13 RID: 3859
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004EC7 RID: 20167 RVA: 0x00235E2C File Offset: 0x0023402C
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "player_oldTent", true);
			c5x c5x = new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), this.a.Area).ao() as c5x;
			if (c5x != null)
			{
				a0l.a(c5x, "global:xpbl_briggs:oldTent", true);
			}
			return true;
		}

		// Token: 0x0400203C RID: 8252
		public c5x a;
	}

	// Token: 0x02000F14 RID: 3860
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EC9 RID: 20169 RVA: 0x00235E90 File Offset: 0x00234090
		internal bool a(e6d A_0)
		{
			this.b.a.GetAspect<j7>().a(this.a.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x0400203D RID: 8253
		public c5x a;

		// Token: 0x0400203E RID: 8254
		public dcg.b b;
	}
}
