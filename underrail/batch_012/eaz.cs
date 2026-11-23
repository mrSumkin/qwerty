using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E32 RID: 3634
[e79("Up_RenegadeTalkToHolloway")]
public sealed class eaz : dgy
{
	// Token: 0x06004CA2 RID: 19618 RVA: 0x00218630 File Offset: 0x00216830
	public eaz()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			eaz.a a = new eaz.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("4e0c3db1-54a9-4680-9922-10721ca245b6"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("2cdae21b-ee0c-41a9-8f78-f9e2d0c37314"), a.a.Area).ao() as c5x);
				a.d = (new ar7(new Guid("2be59466-22b2-4ca9-9de9-1938cf6bb315"), a.a.Area).ao() as c5x);
				a.e = (new ar7(new Guid("d77ba025-1205-4b63-bf06-bbcc73ba2eb7"), a.a.Area).ao() as c5x);
				a.f = (new ar7(new Guid("83897682-5944-475a-b08b-9f82c0a7e36b"), a.a.Area).ao() as c5x);
				a.g = (new ar7(new Guid("0c2cc0fd-ff8a-461f-97b3-eb4c414f4869"), a.a.Area).ao() as c5x);
				a.h = (new ar7(new Guid("3d77a13d-a4e2-48ae-83fd-8c497eb0ef7f"), a.a.Area).ao() as c5x);
				a.i = (new ar7(new Guid("4ec19e85-a796-4d7d-b5bf-f0c56ef2dfb4"), a.a.Area).ao() as c5x);
				a.j = (new ar7(new Guid("595c1a37-0667-48b6-9f45-d108cd01c3b8"), a.a.Area).ao() as c5x);
				if (a.b != null)
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
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
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
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E33 RID: 3635
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CA4 RID: 19620 RVA: 0x00218940 File Offset: 0x00216B40
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "negotiate_player", true);
			a0l.a(this.b, "negotiate_holloway", true);
			if (this.c != null)
			{
				a0l.a(this.c, "renegade1_talk", true);
			}
			if (this.d != null)
			{
				a0l.a(this.d, "renegade2_talk", true);
			}
			if (this.e != null)
			{
				a0l.a(this.e, "renegade3_talk", true);
			}
			if (this.f != null)
			{
				a0l.a(this.f, "renegade4_talk", true);
			}
			if (this.g != null)
			{
				a0l.a(this.g, "renegade5_talk", true);
			}
			if (this.h != null)
			{
				a0l.a(this.h, "renegade6_talk", true);
			}
			if (this.i != null)
			{
				a0l.a(this.i, "renegade7_talk", true);
			}
			if (this.j != null)
			{
				a0l.a(this.j, "entranceGuard_negotiate", true);
			}
			return true;
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x00218A50 File Offset: 0x00216C50
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F16 RID: 7958
		public c5x a;

		// Token: 0x04001F17 RID: 7959
		public c5x b;

		// Token: 0x04001F18 RID: 7960
		public c5x c;

		// Token: 0x04001F19 RID: 7961
		public c5x d;

		// Token: 0x04001F1A RID: 7962
		public c5x e;

		// Token: 0x04001F1B RID: 7963
		public c5x f;

		// Token: 0x04001F1C RID: 7964
		public c5x g;

		// Token: 0x04001F1D RID: 7965
		public c5x h;

		// Token: 0x04001F1E RID: 7966
		public c5x i;

		// Token: 0x04001F1F RID: 7967
		public c5x j;
	}
}
