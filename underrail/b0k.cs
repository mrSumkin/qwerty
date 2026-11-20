using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000F01 RID: 3841
[e79("Xphw_ExoBase_Trg2_VoidBattleIntro")]
public sealed class b0k : dgy
{
	// Token: 0x06004E99 RID: 20121 RVA: 0x0023300C File Offset: 0x0023120C
	public b0k()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			b0k.a a = new b0k.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			d60 d = serviceOrThrow.aqw().a();
			if (a.a != null && serviceOrThrow != null && d != null)
			{
				a.b = (Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"psiCommander"
				})) as c5x);
				if (a.b != null)
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
					kw kw = new kw();
					kw.a(new bt4("west1_1"));
					kw.a(false);
					array[num] = kw;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					egx egx = new egx();
					egx.a("Открой глаза. Мы прибыли.");
					array2[num2] = new ace(egx)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					egx egx2 = new egx();
					egx2.a("Следуй за мной.");
					array3[num3] = new ace(egx2)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					s5 s = new s5();
					s.a(new ar7(a.a));
					s.a(new bt4("p2"));
					s.IsAsync = true;
					s.a(true);
					array4[num4] = s;
					base.a(array4);
					btm[] array5 = new btm[1];
					int num5 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(a.b));
					s2.a(new bt4("cmd2"));
					s2.IsAsync = true;
					s2.a(true);
					array5[num5] = s2;
					base.a(array5);
					btm[] array6 = new btm[1];
					int num6 = 0;
					kw kw2 = new kw();
					kw2.a(new bt4("cmd2"));
					kw2.a(false);
					array6[num6] = kw2;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.66))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
			}
		}
	}

	// Token: 0x02000F02 RID: 3842
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E9B RID: 20123 RVA: 0x00233300 File Offset: 0x00231500
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x0400201C RID: 8220
		public c5x a;

		// Token: 0x0400201D RID: 8221
		public c5x b;
	}
}
