using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E7C RID: 3708
[e79("Rc_JaredWantsToTalk")]
public sealed class d45 : dgy
{
	// Token: 0x06004D37 RID: 19767 RVA: 0x00220828 File Offset: 0x0021EA28
	public d45()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			d45.a a = new d45.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("dca53356-09b6-432b-8089-13d47d34d6b4"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("98daddf0-d2dc-4ec6-8666-3fd223bd13c1"), a.a.Area).ao() as c5x);
				if (a.b != null && a.c != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Idle);
					bb.a(atp.a);
					bb.IsAsync = true;
					bb.a(new ar7(a.b));
					bb.b(1);
					array[num] = bb;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array2[num2] = dky;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array3[num3] = c8s;
					base.a(array3);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E7D RID: 3709
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D39 RID: 19769 RVA: 0x00220A20 File Offset: 0x0021EC20
		internal bool a(e6d A_0)
		{
			a0l.a(this.b, "jaredTalkToDoc", true);
			this.b.t.b.y6()[ddq.ay] = new bt4("jaredTalkToDoc");
			a0l.a(this.c, "e3c2b217-012d-4d5e-9339-2a3fea22b241", true);
			this.c.t.b.y6()[ddq.ay] = new bt4("e3c2b217-012d-4d5e-9339-2a3fea22b241");
			a0l.a(this.a, "playerTalkToDoc", true);
			this.a.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F85 RID: 8069
		public c5x a;

		// Token: 0x04001F86 RID: 8070
		public c5x b;

		// Token: 0x04001F87 RID: 8071
		public c5x c;
	}
}
