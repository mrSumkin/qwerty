using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F10 RID: 3856
[e79("Xpbl_KirillStartsDialogWithMuties")]
public sealed class a8h : dgy
{
	// Token: 0x06004EC2 RID: 20162 RVA: 0x00235B94 File Offset: 0x00233D94
	public a8h()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			a8h.a a = new a8h.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("5530751e-3a9a-4d30-8988-514fd9c18ef2"), a.a.Area).ao() as c5x);
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

	// Token: 0x02000F11 RID: 3857
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EC4 RID: 20164 RVA: 0x00235C50 File Offset: 0x00233E50
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x0400203A RID: 8250
		public c5x a;

		// Token: 0x0400203B RID: 8251
		public c5x b;
	}
}
