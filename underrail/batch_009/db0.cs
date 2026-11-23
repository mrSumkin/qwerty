using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E6F RID: 3695
[e79("Fo_TalkToNicolas")]
public sealed class db0 : dgy
{
	// Token: 0x06004D21 RID: 19745 RVA: 0x0021F4F8 File Offset: 0x0021D6F8
	public db0()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			db0.a a = new db0.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("38995925-a866-45a3-87e2-e88388bfc4c2"), a.a.Area).ao() as c5x);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
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
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
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
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E70 RID: 3696
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D23 RID: 19747 RVA: 0x0021F678 File Offset: 0x0021D878
		internal bool a(e6d A_0)
		{
			a0l.a(this.b, "global:fo_nicolas:corner", true);
			a0l.a(this.a, "player_discussMurder", true);
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F74 RID: 8052
		public c5x a;

		// Token: 0x04001F75 RID: 8053
		public c5x b;
	}
}
