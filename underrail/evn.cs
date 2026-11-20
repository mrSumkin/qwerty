using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000D84 RID: 3460
[e79("Xpbl_DudeInUpperUnderrail")]
public sealed class evn : dgy
{
	// Token: 0x06004B3C RID: 19260 RVA: 0x0020707C File Offset: 0x0020527C
	public evn()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			evn.a a = new evn.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.b = (new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), a.a.Area).ao() as c5x);
				eyj a_ = Enumerable.FirstOrDefault<eyj>(a.a.h.b.aa().StatusEffects.Get<eyj>());
				a.a.h.b.aa().StatusEffects.d(a_);
				a.a.h.b.aa().StatusEffects.a(new eyj(0, -2), false, false, false);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
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

	// Token: 0x02000D85 RID: 3461
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B3E RID: 19262 RVA: 0x002071EC File Offset: 0x002053EC
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E2B RID: 7723
		public c5x a;

		// Token: 0x04001E2C RID: 7724
		public c5x b;
	}
}
