using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000D98 RID: 3480
[e79("Lu_BanditsLeavePersuasion")]
public sealed class ec2 : dgy
{
	// Token: 0x06004B64 RID: 19300 RVA: 0x00209724 File Offset: 0x00207924
	public ec2()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ec2.a a = new ec2.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
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
				dky.IsAsync = false;
				dky.a(false);
				array[num] = dky;
				base.a(array);
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

	// Token: 0x02000D99 RID: 3481
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B66 RID: 19302 RVA: 0x00209878 File Offset: 0x00207A78
		internal bool a(e6d A_0)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(this.a.Area.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId == asp.dc)
				{
					c5x.w();
					c5x.an();
				}
			}
			return true;
		}

		// Token: 0x04001E49 RID: 7753
		public c5x a;
	}
}
