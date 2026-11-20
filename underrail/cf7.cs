using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D39 RID: 3385
[e79("Cc_VlatkoLeadsYouToCheckOutMonitor")]
public sealed class cf7 : dgy
{
	// Token: 0x06004A83 RID: 19075 RVA: 0x001FAC34 File Offset: 0x001F8E34
	public cf7()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			cf7.a a = new cf7.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("e5eb62cf-34f5-4aa7-89b6-e32fada5deb2"), a.a.Area).ao() as c5x);
				if (a.b != null)
				{
					if (a.b.t.b != null)
					{
						a.b.t.b.y6().RemoveProperty(ddq.ay);
						a.b.t.b.y6()[ddq.k] = new List<string>
						{
							"d1",
							"d2"
						};
						a.b.t.b.y6()[ddq.l] = 15000;
						a.b.t.b.y6()[ddq.n] = true;
					}
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

	// Token: 0x02000D3A RID: 3386
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A85 RID: 19077 RVA: 0x001FAEB4 File Offset: 0x001F90B4
		internal bool b(e6d A_0)
		{
			a0l.a(this.b, "guard_vlatkoHomeCinema", true);
			a0l.a(this.a, "player_homeCinema", true);
			return true;
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x001FAEDC File Offset: 0x001F90DC
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001DC7 RID: 7623
		public c5x a;

		// Token: 0x04001DC8 RID: 7624
		public c5x b;
	}
}
