using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DF0 RID: 3568
[e79("Dc_CytoseneBlockadeDialog")]
public sealed class cub : dgy
{
	// Token: 0x06004C15 RID: 19477 RVA: 0x002122D4 File Offset: 0x002104D4
	public cub()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			cub.a a = new cub.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.b = (new ar7(new Guid("90166989-e6e7-4c79-a77f-d318ac2635a6"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("d68c426b-4211-4327-b8a9-e6d25908a734"), a.a.Area).ao() as c5x);
				cky cky = (serviceOrThrow.aqu().ac() as bv9).abu(asp.a, asp.e4);
				if (a.b != null && cky != null && cky.a != h.a)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
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

	// Token: 0x02000DF1 RID: 3569
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C17 RID: 19479 RVA: 0x00212450 File Offset: 0x00210650
		internal bool b(e6d A_0)
		{
			aw1.b(this.b, this.a, false);
			aw1.b(this.c, this.a, false);
			return true;
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x0021247C File Offset: 0x0021067C
		internal bool a(e6d A_0)
		{
			this.c.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001EBA RID: 7866
		public c5x a;

		// Token: 0x04001EBB RID: 7867
		public c5x b;

		// Token: 0x04001EBC RID: 7868
		public c5x c;
	}
}
