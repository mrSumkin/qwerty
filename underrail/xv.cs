using System;

// Token: 0x02000E07 RID: 3591
[e79("Tch_EideinTakesTheElevator")]
public sealed class xv : dgy
{
	// Token: 0x06004C4E RID: 19534 RVA: 0x00214B38 File Offset: 0x00212D38
	public xv()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				c5x c5x2 = new ar7(new Guid("fa4af03c-26e5-4107-93ea-bb94815b0be0"), c5x.Area).ao() as c5x;
				string[] array = new string[]
				{
					"4a5d0a00-1a9b-4f2a-94b3-f404ce7bc876",
					"b4f0dbe9-75bf-450a-93c0-ccab03722591",
					"2a650964-6bbf-4aad-adc8-f7a9aea7057a"
				};
				for (int i = 0; i < array.Length; i++)
				{
					c5x c5x3 = new ar7(new Guid(array[i]), c5x.Area).ao() as c5x;
					if (c5x3 != null)
					{
						c5x3.RemoveAspect<c3g>();
					}
				}
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (c5x2 != null)
				{
					btm[] array2 = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(c5x2));
					s.a(new bt4("EideinExit"));
					s.IsAsync = false;
					s.a(true);
					array2[num] = s;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num2 = 0;
					uk uk = new uk();
					uk.c(true);
					array3[num2] = new ace(uk)
					{
						TargetRef = new ar7(c5x2)
					};
					base.a(array3);
				}
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
