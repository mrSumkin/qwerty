using System;

// Token: 0x02000EAB RID: 3755
[e79("Sgs_Intro")]
public sealed class a75 : dgy
{
	// Token: 0x06004D9A RID: 19866 RVA: 0x00226750 File Offset: 0x00224950
	public a75()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Zone != null)
			{
				c5x a_ = new ar7(new Guid("084a4433-8b2a-4b72-823e-c540086f8f24"), c5x.Area).ao() as c5x;
				btm[] array = new btm[1];
				int num = 0;
				d92 d = new d92();
				d.a("events\\intro1");
				d.b(new ar7(a_));
				d.a(new ar7(new Guid("94e5185a-506d-41ca-87c8-8595e7cd28fb"), c5x.Area));
				array[num] = d;
				base.a(array);
			}
		}
	}
}
