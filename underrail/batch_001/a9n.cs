using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F3B RID: 3899
[e79("Xpbl_StartDialogWithLadelman")]
public sealed class a9n : dgy
{
	// Token: 0x06004F0E RID: 20238 RVA: 0x00239C78 File Offset: 0x00237E78
	public a9n()
	{
		a9n.a a = new a9n.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				a.c = (new ar7(new Guid("9a9e435f-ea2b-46f9-94bd-13cf592b262d"), a.b.Area).ao() as c5x);
				if (a.c != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
			}
		}
	}

	// Token: 0x02000F3C RID: 3900
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004F10 RID: 20240 RVA: 0x00239D48 File Offset: 0x00237F48
		internal bool a(e6d A_0)
		{
			this.b.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, false);
			this.a.aqu().r()["events_xpbl_tonyAndMarcus_startDialogFromEvent"] = true;
			return true;
		}

		// Token: 0x04002069 RID: 8297
		public cnk a;

		// Token: 0x0400206A RID: 8298
		public c5x b;

		// Token: 0x0400206B RID: 8299
		public c5x c;
	}
}
