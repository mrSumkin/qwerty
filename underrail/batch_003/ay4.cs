using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F39 RID: 3897
[e79("Xpbl_StartDialogWithCaptain")]
public sealed class ay4 : dgy
{
	// Token: 0x06004F0B RID: 20235 RVA: 0x00239B8C File Offset: 0x00237D8C
	public ay4()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ay4.a a = new ay4.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("eeeb3815-98da-4fc1-8d8c-29204bc22801"), a.a.Area).ao() as c5x);
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

	// Token: 0x02000F3A RID: 3898
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004F0D RID: 20237 RVA: 0x00239C48 File Offset: 0x00237E48
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04002067 RID: 8295
		public c5x a;

		// Token: 0x04002068 RID: 8296
		public c5x b;
	}
}
