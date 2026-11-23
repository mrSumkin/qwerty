using System;

// Token: 0x02000DB3 RID: 3507
[e79("Jy_FordTeachesFishing")]
public sealed class e8h : dgy
{
	// Token: 0x06004B99 RID: 19353 RVA: 0x0020BF04 File Offset: 0x0020A104
	public e8h()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("dd16c89e-9cc6-4568-abfd-75d1e1892f6f"), c5x.Area).ao() as c5x;
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
					egx.a("Понятно? Хорошо. Теперь оставь меня в покое.");
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
