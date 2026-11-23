using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CF3 RID: 3315
[e79("Cc_DrunkGoesOffTheBridge")]
public sealed class a8y : dgy
{
	// Token: 0x060049E8 RID: 18920 RVA: 0x001EF6F4 File Offset: 0x001ED8F4
	public a8y()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			a8y.a a = new a8y.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				c5x c5x = new ar7(new Guid("eb8b12a3-4e1d-4d58-980a-a1ce956f028e"), a.a.Area).ao() as c5x;
				if (c5x != null)
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
					dky.IsAsync = false;
					dky.a(false);
					array[num] = dky;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					a5 a2 = new a5();
					a2.a(new ar7(c5x));
					array2[num2] = a2;
					base.a(array2);
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_bridgeDrunk_pushed", new bool?(false)).Value)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
					}
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
					egx.a("::Вы слышите, как он достигает очередного дна.::");
					array4[num4] = new ace(egx)
					{
						TargetRef = new ar7(a.a)
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

	// Token: 0x02000CF4 RID: 3316
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049EA RID: 18922 RVA: 0x001EF90C File Offset: 0x001EDB0C
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "pushDrunk", true);
			return true;
		}

		// Token: 0x04001D58 RID: 7512
		public c5x a;
	}
}
