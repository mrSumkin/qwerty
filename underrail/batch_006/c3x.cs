using System;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000EB7 RID: 3767
[e79("Sgs_PsiInhibitorPill")]
public sealed class c3x : dgy
{
	// Token: 0x06004DAD RID: 19885 RVA: 0x00228284 File Offset: 0x00226484
	public c3x()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x a_ = new ar7(new Guid("8fdc3e39-d1bd-409b-9e82-1fb459155f17"), c5x.Area).ao() as c5x;
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.Stunned)))
					{
						TargetRef = new ar7(c5x)
					}
				});
				btm[] array = new btm[1];
				int num = 0;
				egx egx = new egx();
				egx.a(serviceOrThrow.aqu().v().Name + ", вы в порядке? Вы меня слышите?");
				array[num] = new ace(egx)
				{
					TargetRef = new ar7(a_)
				};
				base.a(array);
				base.a(new btm[]
				{
					new am8()
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.Die);
				bb.a(atp.a);
				bb.IsAsync = true;
				bb.a(new ar7(c5x));
				bb.a(cux.h);
				array2[num2] = bb;
				base.a(array2);
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.Die)))
					{
						TargetRef = new ar7(c5x)
					}
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(7)))
					{
						TargetRef = new ar7(c5x)
					}
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array3[num3] = dky;
				base.a(array3);
				base.a(new btm[]
				{
					new ace(new epw(null))
					{
						TargetRef = new ar7(c5x)
					}
				});
				base.a(new btm[]
				{
					new cmc(null)
				});
				base.a(new btm[]
				{
					new ace(new dlt())
				});
				base.a(new btm[]
				{
					new ace(new epw(null))
					{
						TargetRef = new ar7(c5x)
					}
				});
				base.a(new btm[]
				{
					new ace(new b16(null))
					{
						TargetRef = new ar7(c5x)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array4[num4] = c8s;
				base.a(array4);
				btm[] array5 = new btm[1];
				int num5 = 0;
				cu4 cu = new cu4();
				cu.a(new Guid?(new Guid("8fdc3e39-d1bd-409b-9e82-1fb459155f17")));
				array5[num5] = new ace(cu);
				base.a(array5);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
