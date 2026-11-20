using System;

// Token: 0x02000EA2 RID: 3746
[e79("Jye_MauraRunsToFarVent")]
public sealed class dg6 : dgy
{
	// Token: 0x06004D8F RID: 19855 RVA: 0x00225924 File Offset: 0x00223B24
	public dg6()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("3339102b-fbeb-48af-a6db-4679d9387877"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("c231d478-d951-409a-abca-f6e1399f3863"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
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
						new os(TimeSpan.FromSeconds(1.0))
					});
					if (c5x3 != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jye2patrolGuard_dead", new bool?(false)).Value)
					{
						bool flag = c5x.Zone.g("GuardWhoKilledMaura") != null;
						csd csd = c5x.Zone.g("MaurasBody");
						if (c5x3.t.b != null)
						{
							c5x3.t.b.y6().RemoveProperty("PatrolRoute");
							c5x3.t.b.y6()["GuardLoc"] = new bt4("GuardWhoKilledMaura");
						}
						if (flag && csd != null)
						{
							base.a(new btm[]
							{
								new ace(new be6
								{
									DestinationWaypoint = "GuardWhoKilledMaura"
								})
								{
									InitiatorRef = new ar7(c5x3)
								}
							});
							base.a(new btm[]
							{
								new ace(new be6
								{
									DestinationWaypoint = "MaurasBody"
								})
								{
									InitiatorRef = new ar7(c5x2)
								}
							});
							btm[] array2 = new btm[1];
							int num2 = 0;
							nb nb = new nb();
							nb.a(bvl.c);
							array2[num2] = new ace(nb)
							{
								TargetRef = new ar7(c5x2)
							};
							base.a(array2);
							serviceOrThrow.aqu().r()["npc_maura_dead"] = true;
						}
					}
					else
					{
						btm[] array3 = new btm[1];
						int num3 = 0;
						a5 a = new a5();
						a.a(new ar7(c5x2));
						a.c(true);
						array3[num3] = a;
						base.a(array3);
						serviceOrThrow.aqu().r()["quest_jyrescueMission_mauraEscaped"] = true;
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array4[num4] = c8s;
					base.a(array4);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}
}
