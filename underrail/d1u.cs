using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CF7 RID: 3319
[e79("Cc_DuffsGangInPosition")]
public sealed class d1u : dgy
{
	// Token: 0x060049EE RID: 18926 RVA: 0x001EFAEC File Offset: 0x001EDCEC
	public d1u()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			d1u.a a = new d1u.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				a.e = (new ar7(new Guid("0d8f27d6-203e-4118-b504-e32590b565fa"), a.a.Area).ao() as c5x);
				a.d = (new ar7(new Guid("d427212e-aadf-4415-92d2-0cefd611924e"), a.a.Area).ao() as c5x);
				a.b = (new ar7(new Guid("e8c45dd1-1257-47b0-8fe9-5687a70ad86e"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("c199ca2e-443d-4da3-a98d-bbc703c63930"), a.a.Area).ao() as c5x);
				if (a.e != null)
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
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array[num] = dky;
					base.a(array);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
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

	// Token: 0x02000CF8 RID: 3320
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049F0 RID: 18928 RVA: 0x001EFD20 File Offset: 0x001EDF20
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_talkDuff", true);
			if (this.b != null)
			{
				a0l.a(this.b, "tina_surround", true);
			}
			if (this.c != null)
			{
				a0l.a(this.c, "priscilla_surround", true);
			}
			if (this.d != null)
			{
				a0l.a(this.d, "svetlana_surround", true);
			}
			return true;
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x001EFD94 File Offset: 0x001EDF94
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.e.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001D5A RID: 7514
		public c5x a;

		// Token: 0x04001D5B RID: 7515
		public c5x b;

		// Token: 0x04001D5C RID: 7516
		public c5x c;

		// Token: 0x04001D5D RID: 7517
		public c5x d;

		// Token: 0x04001D5E RID: 7518
		public c5x e;
	}
}
