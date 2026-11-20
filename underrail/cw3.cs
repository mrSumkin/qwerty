using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000D62 RID: 3426
[e79("Xpbl_Ethan_TeachPsi")]
public sealed class cw3 : dgy
{
	// Token: 0x06004ADC RID: 19164 RVA: 0x00202388 File Offset: 0x00200588
	public cw3()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("c3523654-2a7d-4490-8c19-e56e53bc8971"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
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
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array2[num2] = c8s;
					base.a(array2);
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_ethan_deniedHandHolding", new bool?(false)).Value && c5x.h.b.aa().Gender == Gender.Female)
					{
						if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_xpbl_ethan_timesLeadToTrain", new int?(0)).Value >= 2)
						{
							btm[] array3 = new btm[1];
							int num3 = 0;
							egx egx = new egx();
							egx.a("Великолепная работа, дорогая! Должен сказать, что я чувствую себя... действительно измученным после этой сессии.");
							array3[num3] = new ace(egx)
							{
								TargetRef = new ar7(c5x2)
							};
							base.a(array3);
						}
						else
						{
							btm[] array4 = new btm[1];
							int num4 = 0;
							egx egx2 = new egx();
							egx2.a("Должен сказать, вы талантливы. Вам просто нужно научиться больше расслабляться и... не торопиться.");
							array4[num4] = new ace(egx2)
							{
								TargetRef = new ar7(c5x2)
							};
							base.a(array4);
						}
					}
					else
					{
						btm[] array5 = new btm[1];
						int num5 = 0;
						egx egx3 = new egx();
						egx3.a("...И это всё, что нужно. Не забудьте использовать его с умом.");
						array5[num5] = new ace(egx3)
						{
							TargetRef = new ar7(c5x2)
						};
						base.a(array5);
					}
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}
}
