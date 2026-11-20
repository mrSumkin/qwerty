using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CD6 RID: 3286
[e79("Xpbl_LowerSkerderGrave")]
public sealed class byi : dgy
{
	// Token: 0x060049AF RID: 18863 RVA: 0x001ECBC8 File Offset: 0x001EADC8
	public byi()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			byi.b b = new byi.b();
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("animatedSkerderGraveIndex", new int?(0)).Value;
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			b.a = (serviceOrThrow.aqw().a().ab5("GraveMechanism_" + value.ToString()) as c5x);
			b.b = (serviceOrThrow.aqw().a().ab5("GraveRope_" + value.ToString()) as c5x);
			if (c5x != null && b.a != null && b.b != null)
			{
				byi.a a = new byi.a();
				amc aspect = c5x.GetAspect<amc>();
				a.a = (b.a.s.b as bli);
				bool flag = c5x.Area != null;
				double num = 6.0 / (double)aspect.aa().BaseAbilities.Strength;
				if (flag && a.a != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b), null, null, null)
					});
					btm[] array = new btm[1];
					int num2 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Operating);
					bb.a(atp.a);
					bb.IsAsync = true;
					bb.a(new ar7(c5x));
					bb.b(7);
					bb.a(Convert.ToInt32((double)cux.a * num));
					array[num2] = bb;
					base.a(array);
					for (int i = 0; i < a.a.f(); i++)
					{
						btm[] array2 = new btm[1];
						int num3 = 0;
						Func<e6d, bool> a_ = null;
						Func<e6d, bool> a_2;
						if ((a_2 = a.b) == null)
						{
							a_2 = (a.b = new Func<e6d, bool>(a.a));
						}
						array2[num3] = new dva(a_, a_2, null, null, null);
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromMilliseconds((double)Convert.ToInt32(150.0 * num)))
						});
					}
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000CD7 RID: 3287
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x060049B1 RID: 18865 RVA: 0x001ECE68 File Offset: 0x001EB068
		internal bool b(e6d A_0)
		{
			this.a.c().a("mechanism", "Xpbl_SkerderGravePulley", 1f, c9z.a, true, false);
			return true;
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x001ECE94 File Offset: 0x001EB094
		internal bool a(e6d A_0)
		{
			if (this.b.s.b != null)
			{
				this.b.s.b.g(false);
			}
			this.a.c().a("mechanism", false);
			return true;
		}

		// Token: 0x04001D38 RID: 7480
		public c5x a;

		// Token: 0x04001D39 RID: 7481
		public c5x b;
	}

	// Token: 0x02000CD8 RID: 3288
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049B4 RID: 18868 RVA: 0x001ECEEC File Offset: 0x001EB0EC
		internal bool a(e6d A_0)
		{
			this.a.h();
			return true;
		}

		// Token: 0x04001D3A RID: 7482
		public bli a;

		// Token: 0x04001D3B RID: 7483
		public Func<e6d, bool> b;
	}
}
