using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CFC RID: 3324
[e79("Cc_DuffFistFightPreparation")]
public sealed class a38 : dgy
{
	// Token: 0x060049F9 RID: 18937 RVA: 0x001F0798 File Offset: 0x001EE998
	public a38()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			a38.a a = new a38.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("0d8f27d6-203e-4118-b504-e32590b565fa"), a.a.Area).ao() as c5x);
				a.e = (new ar7(new Guid("d427212e-aadf-4415-92d2-0cefd611924e"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("e8c45dd1-1257-47b0-8fe9-5687a70ad86e"), a.a.Area).ao() as c5x);
				a.d = (new ar7(new Guid("c199ca2e-443d-4da3-a98d-bbc703c63930"), a.a.Area).ao() as c5x);
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
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
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
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000CFD RID: 3325
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049FB RID: 18939 RVA: 0x001F0990 File Offset: 0x001EEB90
		internal bool a(e6d A_0)
		{
			this.b.h.b.aa().FactionId = asp.d2;
			this.b.t.b.c("cc_duff");
			awq.a(this.b.h.b, this.a.h.b, true, true, null, true, true, true, false);
			a0l.a(this.a, "player_talkDuff", true);
			if (this.c != null)
			{
				a0l.a(this.c, "tina_surround", true);
				if (this.c.t.b != null)
				{
					this.c.t.b.y6()[ddq.ay] = new bt4("tina_surround");
				}
			}
			if (this.d != null)
			{
				a0l.a(this.d, "priscilla_surround", true);
				if (this.d.t.b != null)
				{
					this.d.t.b.y6()[ddq.ay] = new bt4("priscilla_surround");
				}
			}
			if (this.e != null)
			{
				a0l.a(this.e, "svetlana_surround", true);
				if (this.e.t.b != null)
				{
					this.e.t.b.y6()[ddq.ay] = new bt4("svetlana_surround");
				}
			}
			ke.a(this.a.h.b.aa(), false);
			return true;
		}

		// Token: 0x04001D66 RID: 7526
		public c5x a;

		// Token: 0x04001D67 RID: 7527
		public c5x b;

		// Token: 0x04001D68 RID: 7528
		public c5x c;

		// Token: 0x04001D69 RID: 7529
		public c5x d;

		// Token: 0x04001D6A RID: 7530
		public c5x e;
	}
}
