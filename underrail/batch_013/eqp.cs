using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CE2 RID: 3298
[e79("Cc_StartPercivalLecture")]
public sealed class eqp : dgy
{
	// Token: 0x060049C9 RID: 18889 RVA: 0x001EDF74 File Offset: 0x001EC174
	public eqp()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			eqp.a a = new eqp.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				c5x c5x = new ar7(new Guid("f0bda668-46fd-41fc-805d-1535132b9460"), a.a.Area).ao() as c5x;
				if (c5x != null)
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
						new ace(new be6
						{
							DestinationWaypoint = "lecture0"
						})
						{
							InitiatorRef = new ar7(a.a)
						}
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
					c8s.IsAsync = false;
					array2[num2] = c8s;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					d92 d = new d92();
					d.a("events\\cc_tchortismLecture");
					d.b(new ar7(c5x));
					d.a(new ar7(a.a));
					array3[num3] = d;
					base.a(array3);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000CE3 RID: 3299
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049CB RID: 18891 RVA: 0x001EE184 File Offset: 0x001EC384
		internal bool a(e6d A_0)
		{
			string[] array = new string[]
			{
				"punk1",
				"og1",
				"drifter",
				"gr2",
				"wrk1",
				"punk_f1"
			};
			for (int i = 1; i <= 6; i++)
			{
				csd a_ = this.a.Zone.g("lecture" + i.ToString());
				c5x c5x = vq.a("creatures\\generichumans\\commoner", a_, false);
				if (c5x != null && c5x.h.b != null)
				{
					c5x.h.b.a(array[i - 1]);
					c5x.SetAspect<e3l>(new e3l(c5x)
					{
						a = 
						{
							"lectureAttendant"
						}
					});
				}
			}
			return true;
		}

		// Token: 0x04001D4B RID: 7499
		public c5x a;
	}
}
