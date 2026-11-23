using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000DB1 RID: 3505
[e79("Dc_FacelessSearchesYou")]
public sealed class dgf : dgy
{
	// Token: 0x06004B95 RID: 19349 RVA: 0x0020BCB0 File Offset: 0x00209EB0
	public dgf()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dgf.a a = new dgf.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.h.b != null)
			{
				a.b = (new ar7(new Guid("ba5c8dc7-9683-4777-a1a8-e1f77916b767"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("0d58b6dc-792d-43a2-be71-85ff3a196699"), a.a.Area).ao() as c5x);
				if (a.b != null && a.b.h.b != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					c6w c6w = new c6w();
					c6w.a = new Func<auv>(a.a);
					c6w.a(new ar7(a.b));
					array[num] = c6w;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Operating);
					bb.a(cux.a);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(a.b));
					bb.b(2);
					array2[num2] = bb;
					base.a(array2);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.1))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000DB2 RID: 3506
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B97 RID: 19351 RVA: 0x0020BE94 File Offset: 0x0020A094
		internal auv a()
		{
			return new fk(this.b.k.b, this.a, new List<HorizontalDirection>
			{
				this.a.VisualDirection
			}, true, 0);
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x0020BED4 File Offset: 0x0020A0D4
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, true);
			return true;
		}

		// Token: 0x04001E66 RID: 7782
		public c5x a;

		// Token: 0x04001E67 RID: 7783
		public c5x b;

		// Token: 0x04001E68 RID: 7784
		public c5x c;
	}
}
