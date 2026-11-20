using System;
using System.Linq;

// Token: 0x02000E86 RID: 3718
[e79("Mc_NewtonLeaves")]
public sealed class bwd : dgy
{
	// Token: 0x06004D45 RID: 19781 RVA: 0x002215BC File Offset: 0x0021F7BC
	public bwd()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("a91f12ff-7bcf-4adf-b709-1a7079025846"), c5x.Area).ao() as c5x;
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
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_mushroomCoveBase_deadPsiBugs", new int?(0)).Value >= 3 || serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_mushroomCoveBase_killedAllBugs", new bool?(false)).Value)
					{
						btm[] array2 = new btm[1];
						int num2 = 0;
						a5 a = new a5();
						a.c(true);
						a.a(new ar7(c5x2));
						array2[num2] = a;
						base.a(array2);
						serviceOrThrow.aqu().r()["npc_newton_survives"] = true;
					}
					else
					{
						d02 service = bpo.GetService<d02>();
						int num3 = 1;
						foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
						{
							if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.ax)
							{
								base.a(new btm[]
								{
									new ace(new be6
									{
										DestinationWaypoint = "bug" + num3++.ToString()
									})
									{
										InitiatorRef = new ar7(d4n.b.a8())
									}
								});
							}
						}
						base.a(new btm[]
						{
							new ace(new be6
							{
								DestinationWaypoint = "newtonDies"
							})
							{
								InitiatorRef = new ar7(c5x2)
							}
						});
						base.a(new btm[]
						{
							new ace(new nb())
							{
								TargetRef = new ar7(c5x2)
							}
						});
						serviceOrThrow.aqu().r()["newton_killedbyfaction"] = "psiBeetles";
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array3 = new btm[1];
					int num4 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array3[num4] = c8s;
					base.a(array3);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}
}
