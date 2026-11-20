using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D48 RID: 3400
[e79("Cc_RudolphLeaves")]
public sealed class aua : dgy
{
	// Token: 0x06004AA2 RID: 19106 RVA: 0x001FD59C File Offset: 0x001FB79C
	public aua()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			aua.a a = new aua.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("e297ee1e-616e-41d9-bc73-d51ca207c19d"), a.a.Area).ao() as c5x);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rnd_cc_rudolph_arrested", new bool?(false)).Value)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					return;
				}
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				a5 a2 = new a5();
				a2.a(new ar7(a.b));
				a2.c(false);
				array2[num2] = a2;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D49 RID: 3401
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004AA4 RID: 19108 RVA: 0x001FD774 File Offset: 0x001FB974
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, new c2w("cc22", "outsidePraetorian"), 0, null);
			this.b.an();
			this.b.w();
			return true;
		}

		// Token: 0x04001DD7 RID: 7639
		public c5x a;

		// Token: 0x04001DD8 RID: 7640
		public c5x b;
	}
}
