using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E6C RID: 3692
[e79("Fo_ChiefArrestOlivia")]
public sealed class a59 : dgy
{
	// Token: 0x06004D1D RID: 19741 RVA: 0x0021F1F0 File Offset: 0x0021D3F0
	public a59()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			a59.a a = new a59.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("f523f820-d063-4f3b-9229-c64fb2b69f83"), a.a.Area).ao() as c5x);
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

	// Token: 0x02000E6D RID: 3693
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D1F RID: 19743 RVA: 0x0021F370 File Offset: 0x0021D570
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F72 RID: 8050
		public c5x a;

		// Token: 0x04001F73 RID: 8051
		public c5x b;
	}
}
