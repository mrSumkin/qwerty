using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DF2 RID: 3570
[e79("Dc_PlayerApproachesTchortists")]
public sealed class azn : dgy
{
	// Token: 0x06004C19 RID: 19481 RVA: 0x002124AC File Offset: 0x002106AC
	public azn()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			azn.a a = new azn.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.b = (new ar7(new Guid("90166989-e6e7-4c79-a77f-d318ac2635a6"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("d68c426b-4211-4327-b8a9-e6d25908a734"), a.a.Area).ao() as c5x);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(a.a));
					s.a(new bt4("playerApproach"));
					s.IsAsync = false;
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

	// Token: 0x02000DF3 RID: 3571
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C1B RID: 19483 RVA: 0x0021265C File Offset: 0x0021085C
		internal bool b(e6d A_0)
		{
			aw1.b(this.b, this.a, false);
			aw1.b(this.c, this.a, false);
			return true;
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x00212688 File Offset: 0x00210888
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001EBD RID: 7869
		public c5x a;

		// Token: 0x04001EBE RID: 7870
		public c5x b;

		// Token: 0x04001EBF RID: 7871
		public c5x c;
	}
}
