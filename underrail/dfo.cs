using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000DE4 RID: 3556
[e79("Dc_FacelessAfterTchortBattle")]
public sealed class dfo : dgy
{
	// Token: 0x06004BFF RID: 19455 RVA: 0x00211218 File Offset: 0x0020F418
	public dfo()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dfo.a a = new dfo.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				a.a.h.b.u();
				if (a.a.Area != null)
				{
					a.b = (new ar7(new Guid("0d58b6dc-792d-43a2-be71-85ff3a196699"), a.a.Area).ao() as c5x);
					if (a.b != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array = new btm[1];
						int num = 0;
						kw kw = new kw();
						kw.a(new bt4("dc-de2", new Vector3(11f, 5f, 0f)));
						kw.IsAsync = false;
						array[num] = kw;
						base.a(array);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						s5 s = new s5();
						s.a(new ar7(a.b));
						s.a(new bt4("Flcom_approach"));
						s.IsAsync = false;
						s.a(true);
						array2[num2] = s;
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
							new os(TimeSpan.FromSeconds(0.1))
						});
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000DE5 RID: 3557
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C01 RID: 19457 RVA: 0x00211450 File Offset: 0x0020F650
		internal bool a(e6d A_0)
		{
			this.b.GetAspect<j7>().a(this.a.GetAspect<j7>(), true, null, true);
			return true;
		}

		// Token: 0x04001EAE RID: 7854
		public c5x a;

		// Token: 0x04001EAF RID: 7855
		public c5x b;
	}
}
