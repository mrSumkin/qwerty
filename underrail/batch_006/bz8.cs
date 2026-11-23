using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000DAD RID: 3501
[e79("Sgs_FinalCouncil")]
public sealed class bz8 : dgy
{
	// Token: 0x06004B8F RID: 19343 RVA: 0x0020B6B8 File Offset: 0x002098B8
	public bz8()
	{
		bz8.a a = new bz8.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			bool flag = a.a.aqu().v().b() is c5x;
			ar7 a_ = new ar7(new Guid("d551529d-7dba-4dc8-adf6-1e36587d65bf"), new Guid("0e791b1d-fd5d-4485-9cef-a8471a5ae6a6"), new Guid("3e000f9a-274e-4d85-8e7c-67c18b27f663"), bl1.a);
			if (flag)
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
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("StationAlpha-Level4", "playerOnCouncil"), false, new bool?(false), 0, null, true, false, false)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.a));
				array2[num2] = dva;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new ace(new be6
					{
						DestinationWaypoint = "global:vera:council"
					})
					{
						InitiatorRef = a_
					}
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				cid cid = new cid();
				cid.a("l4");
				cid.a(new Guid?(new Guid("b9df0de3-c0bf-487f-b607-84482d883398")));
				cid.c(false);
				cid.b(false);
				cid.d(false);
				array3[num3] = new ace(cid);
				base.a(array3);
				btm[] array4 = new btm[1];
				int num4 = 0;
				cid cid2 = new cid();
				cid2.a("l4");
				cid2.a(new Guid?(new Guid("0ad0f8cb-7e5f-431d-a39d-69e27b095277")));
				cid2.c(false);
				cid2.b(false);
				cid2.d(false);
				array4[num4] = new ace(cid2);
				base.a(array4);
				btm[] array5 = new btm[1];
				int num5 = 0;
				cid cid3 = new cid();
				cid3.a("l4");
				cid3.a(new Guid?(new Guid("f43c3a1c-572a-4c31-af69-21cd486cc5e1")));
				cid3.c(false);
				cid3.b(false);
				cid3.d(false);
				array5[num5] = new ace(cid3);
				base.a(array5);
				btm[] array6 = new btm[1];
				int num6 = 0;
				d92 d = new d92();
				d.a("events\\finalCouncil");
				d.b(a_);
				d.a(new ar7(new Guid("94e5185a-506d-41ca-87c8-8595e7cd28fb"), new Guid("0e791b1d-fd5d-4485-9cef-a8471a5ae6a6"), new Guid("3e000f9a-274e-4d85-8e7c-67c18b27f663"), bl1.a));
				array6[num6] = d;
				base.a(array6);
			}
		}
	}

	// Token: 0x02000DAE RID: 3502
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B91 RID: 19345 RVA: 0x0020B9B0 File Offset: 0x00209BB0
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("422e95d7-8a42-453f-8f63-e3f5ef63c268"), Enumerable.FirstOrDefault<aud>(this.a.aqw().Areas)).ao() as c5x;
			if (c5x != null)
			{
				axh aspect = c5x.GetAspect<axh>();
				bim aspect2 = c5x.GetAspect<bim>();
				if (aspect != null && !aspect.i() && aspect2 != null)
				{
					aspect2.a(null, null, false, false);
				}
			}
			return true;
		}

		// Token: 0x04001E63 RID: 7779
		public cnk a;
	}
}
