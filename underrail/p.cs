using System;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000EB1 RID: 3761
[e79("Sgs_EzraTrialEnd")]
public sealed class p : dgy
{
	// Token: 0x06004DA6 RID: 19878 RVA: 0x00227638 File Offset: 0x00225838
	public p()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
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
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				egx egx = new egx();
				egx.a("Уф... опять это...");
				array[num] = new ace(egx)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array2[num2] = dky;
				base.a(array2);
				base.a(new btm[]
				{
					new ace(new e80(true))
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
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new di4(new c2w("StationAlpha-Level5", "start"), false, null, 0, null, true, false, false)
				});
			}
		}
	}
}
