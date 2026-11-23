using System;

// Token: 0x02000E9D RID: 3741
[e79("Sgs_JunkyardConfictDisscusion2")]
public sealed class emd : dgy
{
	// Token: 0x06004D88 RID: 19848 RVA: 0x00225150 File Offset: 0x00223350
	public emd()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bool flag = serviceOrThrow.aqu().v().b() is c5x;
			ar7 ar = new ar7(new Guid("d551529d-7dba-4dc8-adf6-1e36587d65bf"), new Guid("0e791b1d-fd5d-4485-9cef-a8471a5ae6a6"), new Guid("3e000f9a-274e-4d85-8e7c-67c18b27f663"), bl1.a);
			c5x c5x = ar.ao() as c5x;
			if (c5x != null)
			{
				cgh.a(c5x, "global:vera");
			}
			if (flag)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
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
					new ace(new be6
					{
						DestinationWaypoint = "global:vera"
					})
					{
						InitiatorRef = ar
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("StationAlpha-Level5", "start"), false, null, 0, null, true, false, false)
				});
			}
		}
	}
}
