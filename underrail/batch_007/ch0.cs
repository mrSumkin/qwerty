using System;

// Token: 0x02000EB0 RID: 3760
[e79("FadeElapse")]
public sealed class ch0 : dgy
{
	// Token: 0x06004DA5 RID: 19877 RVA: 0x00227548 File Offset: 0x00225748
	public ch0()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
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
				new os(TimeSpan.FromSeconds(2.0))
			});
			btm[] array2 = new btm[1];
			int num2 = 0;
			c8s c8s = new c8s();
			c8s.a(0.2f);
			c8s.IsAsync = false;
			array2[num2] = c8s;
			base.a(array2);
			base.a(new btm[]
			{
				new ace(new e80(true))
			});
		}
	}
}
