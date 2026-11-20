using System;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000EB2 RID: 3762
[e79("Sgs_EzraTrialBegin")]
public sealed class a7r : dgy
{
	// Token: 0x06004DA7 RID: 19879 RVA: 0x00227834 File Offset: 0x00225A34
	public a7r()
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
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new ace(new dnc())
					{
						InitiatorRef = new ar7(c5x)
					}
				});
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
					new di4(new c2w("MushroomCoveS", "ezraTrial"), false, null, 0, null, true, false, false)
				});
			}
		}
	}
}
