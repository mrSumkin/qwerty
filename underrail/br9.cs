using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E8F RID: 3727
[e79("Rc_Mindreading")]
public sealed class br9 : dgy
{
	// Token: 0x06004D5C RID: 19804 RVA: 0x00222580 File Offset: 0x00220780
	public br9()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			br9.a a = new br9.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.h.b != null)
			{
				a.b = (new ar7(new Guid("75cf4d01-a0df-4270-ad6c-e73299db99e7"), a.a.Area).ao() as c5x);
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
					bb.a(CharacterState.Custom1);
					bb.a(cux.a);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(a.b));
					bb.b(1);
					array2[num2] = bb;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.Stunned);
					bb2.a(atp.a);
					bb2.IsAsync = true;
					bb2.a(new ar7(a.a));
					bb2.a(cux.a);
					bb2.b(4);
					array3[num3] = bb2;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					bb8 bb3 = new bb8();
					bb3.a(CharacterState.Custom2);
					bb3.a(cux.a);
					bb3.a(atp.a);
					bb3.IsAsync = false;
					bb3.a(new ar7(a.b));
					bb3.b(3);
					array4[num4] = bb3;
					base.a(array4);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
			}
		}
	}

	// Token: 0x02000E90 RID: 3728
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D5E RID: 19806 RVA: 0x002227B8 File Offset: 0x002209B8
		internal auv a()
		{
			return new fk(this.b.k.b, this.a, new List<HorizontalDirection>
			{
				this.a.VisualDirection
			}, true, 0);
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x002227F8 File Offset: 0x002209F8
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F9A RID: 8090
		public c5x a;

		// Token: 0x04001F9B RID: 8091
		public c5x b;
	}
}
