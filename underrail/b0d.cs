using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E1E RID: 3614
[e79("Tch_DenzilLeavesForGood")]
public sealed class b0d : dgy
{
	// Token: 0x06004C80 RID: 19584 RVA: 0x00216F30 File Offset: 0x00215130
	public b0d()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			b0d.a a = new b0d.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				if (a.a.Area != null)
				{
					c5x c5x = new ar7(new Guid("34bad129-029c-4035-81ff-b53872584b91"), a.a.Area).ao() as c5x;
					a.b = (new ar7(new Guid("7efeaf99-d1a0-413e-a115-936d59db4bbb"), a.a.Area).ao() as c5x);
					if (c5x != null)
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
						btm[] array2 = new btm[1];
						int num2 = 0;
						a5 a2 = new a5();
						a2.a(new ar7(c5x));
						a2.c(true);
						array2[num2] = a2;
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						array3[num3] = c8s;
						base.a(array3);
						if (a.b != null)
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(a.a), null, null, null)
							});
						}
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000E1F RID: 3615
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C82 RID: 19586 RVA: 0x00217100 File Offset: 0x00215300
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001EFB RID: 7931
		public c5x a;

		// Token: 0x04001EFC RID: 7932
		public c5x b;
	}
}
