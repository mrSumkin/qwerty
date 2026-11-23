using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;

// Token: 0x02000E20 RID: 3616
[e79("Tch_PsychoIsOnTheLoose")]
public sealed class euu : dgy
{
	// Token: 0x06004C83 RID: 19587 RVA: 0x00217130 File Offset: 0x00215330
	public euu()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			euu.a a = new euu.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				bool flag = a.a.Area != null;
				aud aud = a.a.Zone.n("tch-wh");
				if (flag && aud != null)
				{
					a.c = (new ar7(new Guid("450078dc-e826-491a-bcea-a99ee7caf9c2"), a.a.Area).ao() as c5x);
					a.b = (new ar7(new Guid("c7a02deb-b9f6-4aef-853c-9b11e36b549e"), a.a.Area).ao() as c5x);
					a.d = (new ar7(new Guid("ce0e3d10-9834-43aa-a207-9a70aa12f779"), aud).ao() as c5x);
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
						c8s.IsAsync = false;
						array2[num2] = c8s;
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						s5 s = new s5();
						s.a(new ar7(a.b));
						s.a(new bt4("caretaker_end"));
						s.IsAsync = false;
						s.a(true);
						array3[num3] = s;
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.5))
						});
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
	}

	// Token: 0x02000E21 RID: 3617
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C85 RID: 19589 RVA: 0x002173E8 File Offset: 0x002155E8
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_cutscene", true);
			a0l.a(this.b, "caretaker_start", true);
			this.c.VisualDirection = HorizontalDirection.East;
			if (this.d != null)
			{
				a0l.a(this.d, "psycho_move", true);
			}
			return true;
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x00217440 File Offset: 0x00215640
		internal bool a(e6d A_0)
		{
			this.b.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, true);
			return true;
		}

		// Token: 0x04001EFD RID: 7933
		public c5x a;

		// Token: 0x04001EFE RID: 7934
		public c5x b;

		// Token: 0x04001EFF RID: 7935
		public c5x c;

		// Token: 0x04001F00 RID: 7936
		public c5x d;
	}
}
