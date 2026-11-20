using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E0D RID: 3597
[e79("Tch_AmeliaArrives")]
public sealed class edp : dgy
{
	// Token: 0x06004C56 RID: 19542 RVA: 0x00215164 File Offset: 0x00213364
	public edp()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			edp.a a = new edp.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				aud aud = a.a.Area;
				if (aud != null)
				{
					c5x c5x = new ar7(new Guid("34bad129-029c-4035-81ff-b53872584b91"), a.a.Area).ao() as c5x;
					a.b = new EntityAspectReference<cnb, bim>(aud, new Guid("ecab973a-2609-419b-9ad0-36e4032d554f")).ao();
					a.c = (new ar7(new Guid("849a5ff2-d4d0-4327-8a3d-660a7e5b7edf"), a.a.Area).ao() as c5x);
					if (a.c != null)
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
						if (a.b != null)
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(a.d), null, null, null)
							});
						}
						if (c5x != null)
						{
							btm[] array2 = new btm[1];
							int num2 = 0;
							a5 a2 = new a5();
							a2.c(true);
							a2.a(new ar7(c5x));
							array2[num2] = a2;
							base.a(array2);
						}
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.c), null, null, null)
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						kw kw = new kw();
						kw.a(new bt4("tch-entry", a.a.Location));
						kw.IsAsync = false;
						kw.a(true);
						array3[num3] = kw;
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
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
						s5 s = new s5();
						s.a(new ar7(a.c));
						s.a(new bt4("ameliaDoor"));
						s.IsAsync = false;
						s.a(true);
						array5[num5] = s;
						base.a(array5);
						btm[] array6 = new btm[1];
						int num6 = 0;
						bb8 bb = new bb8();
						bb.a(CharacterState.OperateShort);
						bb.a(atp.a);
						bb.IsAsync = false;
						bb.a(new ar7(a.c));
						bb.b(1);
						array6[num6] = bb;
						base.a(array6);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array7 = new btm[1];
						int num7 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(a.c));
						s2.a(new bt4("global:tch_amelia:interview"));
						s2.IsAsync = false;
						s2.a(true);
						array7[num7] = s2;
						base.a(array7);
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
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000E0E RID: 3598
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C58 RID: 19544 RVA: 0x00215538 File Offset: 0x00213738
		internal bool d(e6d A_0)
		{
			if (this.b.q())
			{
				this.b.d(false);
			}
			return true;
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x00215558 File Offset: 0x00213758
		internal bool c(e6d A_0)
		{
			a0l.a(this.a, "player_waitAmelia", true);
			a0l.a(this.c, "global:tch_amelia:entry", true);
			return true;
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x00215580 File Offset: 0x00213780
		internal bool b(e6d A_0)
		{
			this.b.d(false);
			return true;
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x00215590 File Offset: 0x00213790
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001EE1 RID: 7905
		public c5x a;

		// Token: 0x04001EE2 RID: 7906
		public cnb b;

		// Token: 0x04001EE3 RID: 7907
		public c5x c;
	}
}
