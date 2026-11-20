using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E64 RID: 3684
[e79("Fo_PushNicolas")]
public sealed class dmr : dgy
{
	// Token: 0x06004D0E RID: 19726 RVA: 0x0021E7D0 File Offset: 0x0021C9D0
	public dmr()
	{
		dmr.a a = new dmr.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				ar7 ar = new ar7(new Guid("38995925-a866-45a3-87e2-e88388bfc4c2"), a.b.Area);
				if (ar.ao() is c5x)
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
					s5 s = new s5();
					s.a(new ar7(a.b));
					s.a(new bt4("pushPlace"));
					s.a(true);
					array[num] = s;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.35))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.OperateShort);
					bb.a(new ar7(a.b));
					array2[num2] = bb;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					uk uk = new uk();
					uk.c(true);
					uk.b(true);
					array3[num3] = new ace(uk)
					{
						TargetRef = ar
					};
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.a));
					array4[num4] = dva;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E65 RID: 3685
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D10 RID: 19728 RVA: 0x0021E9D0 File Offset: 0x0021CBD0
		internal bool a(e6d A_0)
		{
			csd csd = this.b.Zone.g("nicolasFall");
			if (csd != null)
			{
				this.b.c().a("FireballSpread");
				boj.a(csd.Area, csd.Location, null, "ScorchGround", 1, double.MaxValue, null, null, null, null);
			}
			this.a.aqz().atd("fo_tillDeathDoUsPartNicolas", true);
			return true;
		}

		// Token: 0x04001F67 RID: 8039
		public cnk a;

		// Token: 0x04001F68 RID: 8040
		public c5x b;
	}
}
