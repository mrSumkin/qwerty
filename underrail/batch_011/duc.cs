using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F2B RID: 3883
[e79("Xpbl_Rig_DrunkGuardLeavesRoom")]
public sealed class duc : dgy
{
	// Token: 0x06004EF0 RID: 20208 RVA: 0x0023827C File Offset: 0x0023647C
	public duc()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				duc.a a = new duc.a();
				a.a = (new ar7(new Guid("4becdc55-f35c-4230-8f5f-87c7b3e10fd5"), c5x.Area).ao() as c5x);
				a.b = (new ar7(new Guid("a6ce68c0-537a-4706-8679-730b6c8ed56f"), c5x.Area).ao() as c5x);
				if (a.a != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
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
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
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

	// Token: 0x02000F2C RID: 3884
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EF2 RID: 20210 RVA: 0x002383F0 File Offset: 0x002365F0
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "drunkEel_bar", true);
			if (this.b != null)
			{
				cnb cnb = this.b.GetAspect<bim>() as cnb;
				if (cnb != null && !cnb.q())
				{
					cnb.d(true);
				}
			}
			return true;
		}

		// Token: 0x04002058 RID: 8280
		public c5x a;

		// Token: 0x04002059 RID: 8281
		public c5x b;
	}
}
