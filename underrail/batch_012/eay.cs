using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;

// Token: 0x02000D66 RID: 3430
[e79("Xpbl_YahotaArrives")]
public sealed class eay : dgy
{
	// Token: 0x06004AE4 RID: 19172 RVA: 0x00202A08 File Offset: 0x00200C08
	public eay()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			eay.a a = new eay.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				eay.b b = new eay.b();
				b.d = a;
				b.a = (new ar7(new Guid("bc450e1a-e9ae-40f3-8094-21f77abe1bc1"), b.d.a.Area).ao() as c5x);
				b.c = (new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), b.d.a.Area).ao() as c5x);
				b.b = (new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), b.d.a.Area).ao() as c5x);
				if (b.a != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.a), null, null, null)
					});
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(b.d.a));
					s.a(new bt4("player_oldTent"));
					s.IsAsync = false;
					s.a(true);
					array[num] = s;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(b.a));
					s2.a(new bt4("yahota_oldTent"));
					s2.IsAsync = false;
					s2.a(true);
					array2[num2] = s2;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.d.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D67 RID: 3431
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004AE6 RID: 19174 RVA: 0x00202C90 File Offset: 0x00200E90
		internal bool a(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.Northeast;
			return true;
		}

		// Token: 0x04001E04 RID: 7684
		public c5x a;
	}

	// Token: 0x02000D68 RID: 3432
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004AE8 RID: 19176 RVA: 0x00202CA8 File Offset: 0x00200EA8
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "spawnYahota", true);
			this.b.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x00202CCC File Offset: 0x00200ECC
		internal bool b(e6d A_0)
		{
			this.d.a.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, false);
			gb gb = new gb();
			if (gb != null)
			{
				gb.ym(this.d.a, null, null);
			}
			return true;
		}

		// Token: 0x04001E05 RID: 7685
		public c5x a;

		// Token: 0x04001E06 RID: 7686
		public c5x b;

		// Token: 0x04001E07 RID: 7687
		public c5x c;

		// Token: 0x04001E08 RID: 7688
		public eay.a d;
	}
}
