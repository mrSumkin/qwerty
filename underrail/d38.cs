using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000E2D RID: 3629
[e79("Up_RenegadesLeave")]
public sealed class d38 : dgy
{
	// Token: 0x06004C9A RID: 19610 RVA: 0x00217FD4 File Offset: 0x002161D4
	public d38()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				d38.a a = new d38.a();
				a.a = bpo.GetService<d02>();
				if (new ar7(new Guid("4e0c3db1-54a9-4680-9922-10721ca245b6"), c5x.Area).ao() is c5x)
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
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
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

	// Token: 0x02000E2E RID: 3630
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C9C RID: 19612 RVA: 0x00218138 File Offset: 0x00216338
		internal bool a(e6d A_0)
		{
			if (this.a != null)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(this.a.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.br)
					{
						d4n.b.a8().w();
						d4n.b.a8().an();
					}
				}
			}
			return true;
		}

		// Token: 0x04001F0B RID: 7947
		public d02 a;
	}
}
