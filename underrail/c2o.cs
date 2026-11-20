using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D5E RID: 3422
[e79("Xpbl_E3_FlingerApproaches")]
public sealed class c2o : dgy
{
	// Token: 0x06004AD5 RID: 19157 RVA: 0x00201AC8 File Offset: 0x001FFCC8
	public c2o()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c2o.a a = new c2o.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.b = (new ar7(new Guid("ddcf0026-3691-4d73-b3df-ed96068b2654"), a.a.Area).ao() as c5x);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(a.b));
					s.a(new bt4("flinger_close"));
					s.IsAsync = true;
					s.a(true);
					array[num] = s;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
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

	// Token: 0x02000D5F RID: 3423
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004AD7 RID: 19159 RVA: 0x00201C28 File Offset: 0x001FFE28
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001DFE RID: 7678
		public c5x a;

		// Token: 0x04001DFF RID: 7679
		public c5x b;
	}
}
