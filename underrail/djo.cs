using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F47 RID: 3911
[e79("Xpbl_Sc_ScanningInitiated")]
public sealed class djo : dgy
{
	// Token: 0x06004F2C RID: 20268 RVA: 0x0023B6F4 File Offset: 0x002398F4
	public djo()
	{
		djo.a a = new djo.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				new ar7(a.b);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num = 0;
				kw kw = new kw();
				kw.a(new bt4("playerScan"));
				array[num] = kw;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				s5 s = new s5();
				s.a(new ar7(a.b));
				s.a(new bt4("playerScan"));
				s.IsAsync = true;
				s.a(true);
				array2[num2] = s;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.d), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.c), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.g), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.f), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.e), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000F48 RID: 3912
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004F2E RID: 20270 RVA: 0x0023B9FC File Offset: 0x00239BFC
		internal bool d(e6d A_0)
		{
			awh awh = new awh();
			awh.b(this.b.Area.y8());
			awh.b(new Guid("b09452b5-0651-4d43-a39b-404d14e1c29c"));
			awh.a(new Guid("7e445ebf-dc0f-4659-b77b-b600ebc946cc"));
			awh.a(bbo.c);
			awh.ym(this.b, null, null);
			return true;
		}

		// Token: 0x06004F2F RID: 20271 RVA: 0x0023BA5C File Offset: 0x00239C5C
		internal bool c(e6d A_0)
		{
			bzm bzm = new bzm();
			bzm.a(true);
			bzm.a("RedLight");
			bzm.ym(this.b, null, null);
			return true;
		}

		// Token: 0x06004F30 RID: 20272 RVA: 0x0023BA90 File Offset: 0x00239C90
		internal bool b(e6d A_0)
		{
			bzm bzm = new bzm();
			bzm.a(false);
			bzm.a("RedLight");
			bzm.ym(this.b, null, null);
			return true;
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x0023BAC4 File Offset: 0x00239CC4
		internal bool a(e6d A_0)
		{
			bzm bzm = new bzm();
			bzm.a(true);
			bzm.a("YellowLight");
			bzm.ym(this.b, null, null);
			return true;
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x0023BAF8 File Offset: 0x00239CF8
		internal bool g(e6d A_0)
		{
			bzm bzm = new bzm();
			bzm.a(false);
			bzm.a("YellowLight");
			bzm.ym(this.b, null, null);
			return true;
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x0023BB2C File Offset: 0x00239D2C
		internal bool f(e6d A_0)
		{
			bzm bzm = new bzm();
			bzm.a(true);
			bzm.a("GreenLight");
			bzm.ym(this.b, null, null);
			return true;
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x0023BB60 File Offset: 0x00239D60
		internal bool e(e6d A_0)
		{
			bzm bzm = new bzm();
			bzm.a(false);
			bzm.a("GreenLight");
			bzm.ym(this.b, null, null);
			this.a.aqu().r()["loc_xpbl_sc_scanCompleted"] = true;
			this.a.aqu().r()["loc_xpbl_sc_scanStarted"] = false;
			this.a.aqu().r()["loc_xpbl_sc_scanPerformed"] = true;
			return true;
		}

		// Token: 0x0400207D RID: 8317
		public cnk a;

		// Token: 0x0400207E RID: 8318
		public c5x b;
	}
}
