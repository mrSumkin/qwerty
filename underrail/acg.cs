using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E08 RID: 3592
[e79("Tch_OutOfTchortists")]
public sealed class acg : dgy
{
	// Token: 0x06004C4F RID: 19535 RVA: 0x00214CD8 File Offset: 0x00212ED8
	public acg()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			acg.a a = new acg.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				if (a.a.Area != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
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
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					kw kw = new kw();
					kw.a(new bt4("tch-entry", a.a.Location));
					kw.IsAsync = false;
					kw.a(true);
					array2[num2] = kw;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
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

	// Token: 0x02000E09 RID: 3593
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C51 RID: 19537 RVA: 0x00214E60 File Offset: 0x00213060
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "player_outsideGate", true);
			return true;
		}

		// Token: 0x04001EDE RID: 7902
		public c5x a;
	}
}
