using System;

// Token: 0x02000E42 RID: 3650
[e79("Lux_MarcellaLeaves")]
public sealed class na : dgy
{
	// Token: 0x06004CC2 RID: 19650 RVA: 0x0021A974 File Offset: 0x00218B74
	public na()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				c5x a_ = new ar7(new Guid("4acec479-8d23-4759-93e9-f950cfc9079d"), c5x.Area).ao() as c5x;
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_fd_marcella_goTogetherToMeetBate", new bool?(false)).Value)
				{
					base.a(new btm[]
					{
						new di4(new c2w("lup_freeDroneBase", "player_freeDroneBase"), true, new bool?(true), 0, null, true, false, false)
					});
				}
				else
				{
					btm[] array = new btm[1];
					int num = 0;
					dky dky = new dky();
					dky.a(0.2f);
					array[num] = dky;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					a5 a = new a5();
					a.a(new ar7(a_));
					a.c(true);
					array2[num2] = a;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array3[num3] = c8s;
					base.a(array3);
				}
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
