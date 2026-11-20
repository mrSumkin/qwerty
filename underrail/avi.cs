using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000DEE RID: 3566
[e79("Dc_Mindreading")]
public sealed class avi : dgy
{
	// Token: 0x06004C11 RID: 19473 RVA: 0x00212014 File Offset: 0x00210214
	public avi()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			avi.a a = new avi.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.h.b != null)
			{
				a.a.i.b.a(true, false);
				a.b = (new ar7(new Guid("e176369b-60d9-46a3-a8f5-53060f1c5fc1"), a.a.Area).ao() as c5x);
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

	// Token: 0x02000DEF RID: 3567
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C13 RID: 19475 RVA: 0x00212264 File Offset: 0x00210464
		internal auv a()
		{
			return new fk(this.b.k.b, this.a, new List<HorizontalDirection>
			{
				this.a.VisualDirection
			}, true, 0);
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x002122A4 File Offset: 0x002104A4
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001EB8 RID: 7864
		public c5x a;

		// Token: 0x04001EB9 RID: 7865
		public c5x b;
	}
}
