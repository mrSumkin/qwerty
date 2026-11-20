using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CD9 RID: 3289
[e79("Xpbl_RaiseSkerderGrave")]
public sealed class ab9 : dgy
{
	// Token: 0x060049B5 RID: 18869 RVA: 0x001ECEFC File Offset: 0x001EB0FC
	public ab9()
	{
		ab9.a a = new ab9.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			int value = a.a.aqu().r().GetPrimitivePropertyValue<int>("animatedSkerderGraveIndex", new int?(0)).Value;
			c5x c5x = a.a.aqu().v().b() as c5x;
			a.b = (a.a.aqw().a().ab5("GraveMechanism_" + value.ToString()) as c5x);
			a.c = (a.a.aqw().a().ab5("GraveRope_" + value.ToString()) as c5x);
			if (c5x != null && a.b != null && a.c != null)
			{
				ab9.b b = new ab9.b();
				b.b = a;
				amc aspect = c5x.GetAspect<amc>();
				b.a = (b.b.b.s.b as bli);
				bool flag = c5x.Area != null;
				double num = 6.0 / (double)aspect.aa().BaseAbilities.Strength;
				if (flag && b.a != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.b), null, null, null)
					});
					btm[] array = new btm[1];
					int num2 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Operating);
					bb.a(atp.a);
					bb.IsAsync = true;
					bb.a(new ar7(c5x));
					bb.b(9);
					bb.a(Convert.ToInt32((double)cux.a * num));
					array[num2] = bb;
					base.a(array);
					for (int i = 0; i < 39 - b.a.f(); i++)
					{
						btm[] array2 = new btm[1];
						int num3 = 0;
						Func<e6d, bool> a_ = null;
						Func<e6d, bool> a_2;
						if ((a_2 = b.c) == null)
						{
							a_2 = (b.c = new Func<e6d, bool>(b.a));
						}
						array2[num3] = new dva(a_, a_2, null, null, null);
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromMilliseconds((double)Convert.ToInt32(200.0 * num)))
						});
					}
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000CDA RID: 3290
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049B7 RID: 18871 RVA: 0x001ED1DC File Offset: 0x001EB3DC
		internal bool b(e6d A_0)
		{
			this.b.c().a("mechanism", "Xpbl_SkerderGravePulley", 1f, c9z.a, true, false);
			return true;
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x001ED204 File Offset: 0x001EB404
		internal bool a(e6d A_0)
		{
			if (this.c.s.b != null)
			{
				this.c.s.b.g(true);
			}
			this.b.c().a("mechanism", false);
			return true;
		}

		// Token: 0x04001D3C RID: 7484
		public cnk a;

		// Token: 0x04001D3D RID: 7485
		public c5x b;

		// Token: 0x04001D3E RID: 7486
		public c5x c;
	}

	// Token: 0x02000CDB RID: 3291
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x060049BA RID: 18874 RVA: 0x001ED25C File Offset: 0x001EB45C
		internal bool a(e6d A_0)
		{
			double num = this.b.a.aqu().r().GetPrimitivePropertyValue<double>(dzd.a, new double?(0.0)).Value;
			num = d05.b(0.0, num + 0.5, 100.0);
			this.b.a.aqu().r()[dzd.a] = num;
			this.a.e();
			return true;
		}

		// Token: 0x04001D3F RID: 7487
		public bli a;

		// Token: 0x04001D40 RID: 7488
		public ab9.a b;

		// Token: 0x04001D41 RID: 7489
		public Func<e6d, bool> c;
	}
}
