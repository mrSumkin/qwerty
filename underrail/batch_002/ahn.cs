using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E2F RID: 3631
[e79("Up_RenegadeDoneNegotiatingWithHolloway")]
public sealed class ahn : dgy
{
	// Token: 0x06004C9D RID: 19613 RVA: 0x00218214 File Offset: 0x00216414
	public ahn()
	{
		ahn.a a = new ahn.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			ahn.b b = new ahn.b();
			b.a = (a.a.aqu().v().b() as c5x);
			if (b.a != null)
			{
				b.b = (new ar7(new Guid("4e0c3db1-54a9-4680-9922-10721ca245b6"), b.a.Area).ao() as c5x);
				b.c = (new ar7(new Guid("2cdae21b-ee0c-41a9-8f78-f9e2d0c37314"), b.a.Area).ao() as c5x);
				b.d = (new ar7(new Guid("2be59466-22b2-4ca9-9de9-1938cf6bb315"), b.a.Area).ao() as c5x);
				b.e = (new ar7(new Guid("d77ba025-1205-4b63-bf06-bbcc73ba2eb7"), b.a.Area).ao() as c5x);
				b.f = (new ar7(new Guid("83897682-5944-475a-b08b-9f82c0a7e36b"), b.a.Area).ao() as c5x);
				new ar7(new Guid("0c2cc0fd-ff8a-461f-97b3-eb4c414f4869"), b.a.Area).ao();
				b.g = (new ar7(new Guid("3d77a13d-a4e2-48ae-83fd-8c497eb0ef7f"), b.a.Area).ao() as c5x);
				b.h = (new ar7(new Guid("4ec19e85-a796-4d7d-b5bf-f0c56ef2dfb4"), b.a.Area).ao() as c5x);
				b.i = (new ar7(new Guid("595c1a37-0667-48b6-9f45-d108cd01c3b8"), b.a.Area).ao() as c5x);
				if (b.b != null)
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
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array2[num2] = c8s;
					base.a(array2);
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

	// Token: 0x02000E30 RID: 3632
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C9F RID: 19615 RVA: 0x0021850C File Offset: 0x0021670C
		internal bool a(e6d A_0)
		{
			this.a.aqu().r()["loc_up_renegade_pass"] = false;
			return true;
		}

		// Token: 0x04001F0C RID: 7948
		public cnk a;
	}

	// Token: 0x02000E31 RID: 3633
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004CA1 RID: 19617 RVA: 0x0021853C File Offset: 0x0021673C
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "player_out", true);
			a0l.a(this.b, "guard_holloway", true);
			if (this.c != null)
			{
				a0l.a(this.c, "renegade1_back", true);
			}
			if (this.d != null)
			{
				a0l.a(this.d, "renegade2_back", true);
			}
			if (this.e != null)
			{
				a0l.a(this.e, "renegade3_back", true);
			}
			if (this.f != null)
			{
				a0l.a(this.f, "renegade4_back", true);
			}
			if (this.g != null)
			{
				a0l.a(this.g, "renegade6_talk", true);
			}
			if (this.h != null)
			{
				a0l.a(this.h, "renegade7_talk", true);
			}
			if (this.i != null)
			{
				a0l.a(this.i, "entranceGuard", true);
			}
			return true;
		}

		// Token: 0x04001F0D RID: 7949
		public c5x a;

		// Token: 0x04001F0E RID: 7950
		public c5x b;

		// Token: 0x04001F0F RID: 7951
		public c5x c;

		// Token: 0x04001F10 RID: 7952
		public c5x d;

		// Token: 0x04001F11 RID: 7953
		public c5x e;

		// Token: 0x04001F12 RID: 7954
		public c5x f;

		// Token: 0x04001F13 RID: 7955
		public c5x g;

		// Token: 0x04001F14 RID: 7956
		public c5x h;

		// Token: 0x04001F15 RID: 7957
		public c5x i;
	}
}
