using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DA0 RID: 3488
[e79("Dc_StartDialogWithCommander")]
public sealed class ac3 : dgy
{
	// Token: 0x06004B71 RID: 19313 RVA: 0x00209F50 File Offset: 0x00208150
	public ac3()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ac3.a a = new ac3.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("0d58b6dc-792d-43a2-be71-85ff3a196699"), a.a.Area).ao() as c5x);
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

	// Token: 0x02000DA1 RID: 3489
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B73 RID: 19315 RVA: 0x0020A00C File Offset: 0x0020820C
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E4E RID: 7758
		public c5x a;

		// Token: 0x04001E4F RID: 7759
		public c5x b;
	}
}
