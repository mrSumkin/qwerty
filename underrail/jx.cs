using System;

// Token: 0x02000C9C RID: 3228
[e79("GenericFadeAndDespawnInterlocutor")]
public sealed class jx : dgy
{
	// Token: 0x06004908 RID: 18696 RVA: 0x001DD630 File Offset: 0x001DB830
	public jx()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("cutsceneDespawneeId");
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					serviceOrThrow.aqu().r().RemoveProperty("cutsceneDespawneeId");
					Guid a_;
					if (Guid.TryParse(classPropertyValue, out a_))
					{
						c5x c5x2 = new ar7(a_, c5x.Area).ao() as c5x;
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
							a5 a = new a5();
							a.a(new ar7(c5x2));
							a.c(true);
							array2[num2] = a;
							base.a(array2);
							btm[] array3 = new btm[1];
							int num3 = 0;
							c8s c8s = new c8s();
							c8s.a(0.2f);
							c8s.IsAsync = false;
							array3[num3] = c8s;
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
	}
}
