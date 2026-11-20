using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F3D RID: 3901
[e79("Xpbl_StartDialogWithMarcus")]
public sealed class ept : dgy
{
	// Token: 0x06004F11 RID: 20241 RVA: 0x00239D98 File Offset: 0x00237F98
	public ept()
	{
		ept.a a = new ept.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				a.c = (new ar7(new Guid("5e069237-f790-4a3d-a505-d667f88f2d83"), a.b.Area).ao() as c5x);
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

	// Token: 0x02000F3E RID: 3902
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004F13 RID: 20243 RVA: 0x00239E68 File Offset: 0x00238068
		internal bool a(e6d A_0)
		{
			this.b.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, false);
			this.a.aqu().r()["events_xpbl_tonyAndMarcus_startDialogFromEvent"] = true;
			return true;
		}

		// Token: 0x0400206C RID: 8300
		public cnk a;

		// Token: 0x0400206D RID: 8301
		public c5x b;

		// Token: 0x0400206E RID: 8302
		public c5x c;
	}
}
