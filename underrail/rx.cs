using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000DF4 RID: 3572
[e79("Tch_DenzilLeadsYouIn")]
public sealed class rx : dgy
{
	// Token: 0x06004C1D RID: 19485 RVA: 0x002126B8 File Offset: 0x002108B8
	public rx()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			rx.a a = new rx.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				if (a.a.Area != null)
				{
					c5x c5x = new ar7(new Guid("34bad129-029c-4035-81ff-b53872584b91"), a.a.Area).ao() as c5x;
					if (c5x != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array = new btm[1];
						int num = 0;
						kw kw = new kw();
						kw.a(new bt4("tch-entry", new Vector3(18f, 13f, 0f)));
						kw.IsAsync = true;
						array[num] = kw;
						base.a(array);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(4.0))
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						s5 s = new s5();
						s.a(new ar7(c5x));
						s.a(new bt4("guard_denzilLeadInside"));
						s.IsAsync = true;
						s.a(true);
						array2[num2] = s;
						base.a(array2);
						btm[] array3 = new btm[1];
						int num3 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(a.a));
						s2.a(new bt4("player_ledInside"));
						s2.IsAsync = true;
						s2.a(true);
						array3[num3] = s2;
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(4.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						egx egx = new egx();
						egx.a("Следуйте за мной.");
						array4[num4] = new ace(egx)
						{
							TargetRef = new ar7(c5x)
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

	// Token: 0x02000DF5 RID: 3573
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C1F RID: 19487 RVA: 0x0021295C File Offset: 0x00210B5C
		internal bool b(e6d A_0)
		{
			a9d a9d = new a9d();
			a9d.a(this.a.Area.y8());
			a9d.b(new Guid("63bd9c04-2b65-4217-9efb-908a62413b49"));
			a9d.a(new Guid("026e0861-7347-45ff-9729-d9dbd1fef40c"));
			a9d.a(bbo.b);
			a9d.ym(this.a, null, null);
			return true;
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x002129BC File Offset: 0x00210BBC
		internal bool a(e6d A_0)
		{
			a9d a9d = new a9d();
			a9d.a(this.a.Area.y8());
			a9d.b(new Guid("63bd9c04-2b65-4217-9efb-908a62413b49"));
			a9d.a(new Guid("026e0861-7347-45ff-9729-d9dbd1fef40c"));
			a9d.a(bbo.c);
			a9d.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001EC0 RID: 7872
		public c5x a;
	}
}
