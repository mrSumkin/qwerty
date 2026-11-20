using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CE4 RID: 3300
[e79("Ch_FreddsTale")]
public sealed class bqg : dgy
{
	// Token: 0x060049CC RID: 18892 RVA: 0x001EE25C File Offset: 0x001EC45C
	public bqg()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bqg.a a = new bqg.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("fdcb5c4b-8737-4b4d-b9b8-1792c044f709"), a.a.Area).ao() as c5x);
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

	// Token: 0x02000CE5 RID: 3301
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049CE RID: 18894 RVA: 0x001EE3DC File Offset: 0x001EC5DC
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001D4C RID: 7500
		public c5x a;

		// Token: 0x04001D4D RID: 7501
		public c5x b;
	}
}
