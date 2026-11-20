using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E5A RID: 3674
[e79("Fo_RepairGloriaWithBernard")]
public sealed class d28 : dgy
{
	// Token: 0x06004CF9 RID: 19705 RVA: 0x0021D86C File Offset: 0x0021BA6C
	public d28()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			d28.a a = new d28.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("c6228b55-6682-4678-8234-6af11987a4d5"), a.a.Area).ao() as c5x);
				if (a.b != null)
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
					bb8 bb = new bb8();
					bb.a(CharacterState.Operating);
					bb.a(atp.a);
					bb.IsAsync = true;
					bb.a(new ar7(a.b));
					bb.b(6);
					array2[num2] = bb;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.Operating);
					bb2.a(atp.a);
					bb2.IsAsync = true;
					bb2.a(new ar7(a.a));
					bb2.b(6);
					array3[num3] = bb2;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array4[num4] = c8s;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					dky dky2 = new dky();
					dky2.a(0.2f);
					dky2.a(false);
					array5[num5] = dky2;
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					c8s c8s2 = new c8s();
					c8s2.a(0.2f);
					c8s2.IsAsync = false;
					array6[num6] = c8s2;
					base.a(array6);
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

	// Token: 0x02000E5B RID: 3675
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CFB RID: 19707 RVA: 0x0021DB20 File Offset: 0x0021BD20
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_repair", true);
			this.b.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x0021DB44 File Offset: 0x0021BD44
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F56 RID: 8022
		public c5x a;

		// Token: 0x04001F57 RID: 8023
		public c5x b;
	}
}
