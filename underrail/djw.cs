using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000CE0 RID: 3296
[e79("Cc_EndPercivalLecture")]
public sealed class djw : dgy
{
	// Token: 0x060049C6 RID: 18886 RVA: 0x001EDD94 File Offset: 0x001EBF94
	public djw()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			djw.a a = new djw.a();
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

	// Token: 0x02000CE1 RID: 3297
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049C8 RID: 18888 RVA: 0x001EDEE8 File Offset: 0x001EC0E8
		internal bool a(e6d A_0)
		{
			d60 d = this.a.Zone.a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"lectureAttendant"
				});
				if (list != null)
				{
					foreach (b0b b0b in list)
					{
						b0b.w();
						b0b.an();
					}
				}
			}
			return true;
		}

		// Token: 0x04001D4A RID: 7498
		public c5x a;
	}
}
