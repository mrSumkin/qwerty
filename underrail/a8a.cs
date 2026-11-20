using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x02000CF5 RID: 3317
[e79("Cc_LubenLeaves")]
public sealed class a8a : dgy
{
	// Token: 0x060049EB RID: 18923 RVA: 0x001EF924 File Offset: 0x001EDB24
	public a8a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				aud aud = c5x.Area;
				if (aud != null)
				{
					a8a.a a = new a8a.a();
					c5x c5x2 = new ar7(new Guid("86a33617-b046-4818-93df-07ba6549cb7f"), c5x.Area).ao() as c5x;
					a.a = new EntityAspectReference<cnb, bim>(aud, new Guid("6775f109-9ce6-4c97-bfb3-afa651bca913")).ao();
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
						new os(TimeSpan.FromSeconds(0.5))
					});
					if (c5x2 != null)
					{
						btm[] array2 = new btm[1];
						int num2 = 0;
						a5 a2 = new a5();
						a2.a(new ar7(c5x2));
						a2.c(true);
						array2[num2] = a2;
						base.a(array2);
					}
					if (a.a != null)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
					}
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
	}

	// Token: 0x02000CF6 RID: 3318
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049ED RID: 18925 RVA: 0x001EFADC File Offset: 0x001EDCDC
		internal bool a(e6d A_0)
		{
			this.a.d(true);
			return true;
		}

		// Token: 0x04001D59 RID: 7513
		public cnb a;
	}
}
