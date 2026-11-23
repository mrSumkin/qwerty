using System;

// Token: 0x02000D96 RID: 3478
[e79("Xpbl_Mu_DoctorHealsWounds")]
public sealed class asq : dgy
{
	// Token: 0x06004B62 RID: 19298 RVA: 0x0020944C File Offset: 0x0020764C
	public asq()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("8a7c5aa6-3f8b-43fc-b0ef-49fb4eece7d0"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
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
						new ace(new eop())
					});
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
					btm[] array3 = new btm[1];
					int num3 = 0;
					egx egx = new egx();
					egx.a("Вот. ::хрипит:: Ты можешь приступать.");
					array3[num3] = new ace(egx)
					{
						TargetRef = new ar7(c5x2)
					};
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
