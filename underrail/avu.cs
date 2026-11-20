using System;

// Token: 0x02000CE6 RID: 3302
[e79("Ch_EdgarTeachesFeat")]
public sealed class avu : dgy
{
	// Token: 0x060049CF RID: 18895 RVA: 0x001EE40C File Offset: 0x001EC60C
	public avu()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("df4662a5-4c33-4820-9752-6a6de23792a4"), c5x.Area).ao() as c5x;
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
					btm[] array2 = new btm[1];
					int num2 = 0;
					c93 c = new c93();
					c.a("Hunter");
					c.a(true);
					array2[num2] = new ace(c);
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array3[num3] = c8s;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					egx egx = new egx();
					egx.a("Молодец, вы быстро учитесь. Пусть это знание хорошо вам послужит.");
					array4[num4] = new ace(egx)
					{
						TargetRef = new ar7(c5x2)
					};
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
