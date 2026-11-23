using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E47 RID: 3655
[e79("Fo_VisitTodor")]
public sealed class d8t : dgy
{
	// Token: 0x06004CC8 RID: 19656 RVA: 0x0021AF54 File Offset: 0x00219154
	public d8t()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			d8t.a a = new d8t.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("f6667db1-2de2-4330-b37e-ffb7a6c35df0"), a.a.Area).ao() as c5x);
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
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E48 RID: 3656
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CCA RID: 19658 RVA: 0x0021B0EC File Offset: 0x002192EC
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_meeting", true);
			a0l.a(this.b, "todor_meeting", true);
			if (this.b.h.b != null)
			{
				c4f c4f = new c4f();
				c4f.Properties["loc_fo_prison_MeetingRoomPass"] = false;
				this.b.h.b.ay().Add(c4f);
			}
			return true;
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x0021B168 File Offset: 0x00219368
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F37 RID: 7991
		public c5x a;

		// Token: 0x04001F38 RID: 7992
		public c5x b;
	}
}
