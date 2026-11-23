using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DDF RID: 3551
[e79("Dc_LeoLeadsYouToHoleOfReason")]
public sealed class dfh : dgy
{
	// Token: 0x06004BF4 RID: 19444 RVA: 0x00210C7C File Offset: 0x0020EE7C
	public dfh()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dfh.a a = new dfh.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("cba0cad3-b56c-4663-ac15-21f6d7cc68fe"), a.a.Area).ao() as c5x);
				if (a.b != null)
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
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
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

	// Token: 0x02000DE0 RID: 3552
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BF6 RID: 19446 RVA: 0x00210E1C File Offset: 0x0020F01C
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_hole", true);
			a0l.a(this.b, "leo_hole", true);
			return true;
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x00210E44 File Offset: 0x0020F044
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001EA8 RID: 7848
		public c5x a;

		// Token: 0x04001EA9 RID: 7849
		public c5x b;
	}
}
