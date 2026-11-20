using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D6C RID: 3436
[e79("Xpbl_Up_Dh_DudeInterruptsConsole")]
public sealed class b8r : dgy
{
	// Token: 0x06004AEE RID: 19182 RVA: 0x00203260 File Offset: 0x00201460
	public b8r()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			b8r.a a = new b8r.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), a.a.Area).ao() as c5x);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
			}
		}
	}

	// Token: 0x02000D6D RID: 3437
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004AF0 RID: 19184 RVA: 0x0020331C File Offset: 0x0020151C
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E0B RID: 7691
		public c5x a;

		// Token: 0x04001E0C RID: 7692
		public c5x b;
	}
}
