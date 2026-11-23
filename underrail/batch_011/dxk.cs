using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D3E RID: 3390
[e79("Xpbl_Le_ChiefLeavesProfessorsTent")]
public sealed class dxk : dgy
{
	// Token: 0x06004A8F RID: 19087 RVA: 0x001FB604 File Offset: 0x001F9804
	public dxk()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dxk.a a = new dxk.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.b = (new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), a.a.Area).ao() as c5x);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(a.a));
					s.a(new bt4("player_oldTent"));
					s.IsAsync = false;
					s.a(true);
					array[num] = s;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(a.b));
					s2.a(new bt4("briggsTemp"));
					s2.IsAsync = false;
					s2.a(true);
					array2[num2] = s2;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D3F RID: 3391
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A91 RID: 19089 RVA: 0x001FB7F8 File Offset: 0x001F99F8
		internal bool b(e6d A_0)
		{
			this.b.t.b.y6()[ddq.ay] = new bt4("global:xpbl_briggs:brigTent");
			return true;
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x001FB828 File Offset: 0x001F9A28
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001DCE RID: 7630
		public c5x a;

		// Token: 0x04001DCF RID: 7631
		public c5x b;

		// Token: 0x04001DD0 RID: 7632
		public c5x c;
	}
}
