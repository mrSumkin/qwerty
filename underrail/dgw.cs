using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D4D RID: 3405
[e79("Xpbl_Pir_MeetingTheCaptain")]
public sealed class dgw : dgy
{
	// Token: 0x06004AA8 RID: 19112 RVA: 0x001FF060 File Offset: 0x001FD260
	public dgw()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dgw.b b = new dgw.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null)
			{
				ar7 a_ = new ar7(b.a);
				aud aud = b.a.Zone.n("xpbl_g2_darkness");
				aud aud2 = b.a.Zone.n("xpbl_g2_cabine");
				if (aud != null && aud2 != null)
				{
					dgw.a a = new dgw.a();
					c5x c5x = new ar7(new Guid("eeeb3815-98da-4fc1-8d8c-29204bc22801"), aud2).ao() as c5x;
					a.a = (new ar7(new Guid("0f53f89f-6d8e-4e59-b1f7-a6c8c897f8b2"), aud2).ao() as c5x);
					c5x a_2 = new ar7(new Guid("4c606066-dd6b-43df-b756-03d095040e5d"), aud).ao() as c5x;
					if (c5x != null)
					{
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array = new btm[1];
						int num = 0;
						egx egx = new egx();
						egx.a("Эй ты, стоять.");
						array[num] = new ace(egx)
						{
							TargetRef = new ar7(a_2)
						};
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
						bfq bfq = new bfq();
						bfq.c("BedMake");
						array2[num2] = new ace(bfq)
						{
							TargetRef = a_
						};
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						bb8 bb = new bb8();
						bb.a(CharacterState.OperateShort);
						bb.a(atp.a);
						bb.IsAsync = false;
						bb.a(new ar7(a.a));
						bb.b(1);
						array3[num3] = bb;
						base.a(array3);
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
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.a), null, null, null)
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						d92 d = new d92();
						d.a("events\\xpbl\\pir_meetingCaptain");
						d.b(new ar7(c5x));
						d.a(new ar7(b.a));
						array4[num4] = d;
						base.a(array4);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000D4E RID: 3406
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004AAA RID: 19114 RVA: 0x001FF37C File Offset: 0x001FD57C
		internal bool a(e6d A_0)
		{
			this.a.ae = new float?((float)1);
			a0l.a(this.a, "player_meeting", true);
			return true;
		}

		// Token: 0x04001DD9 RID: 7641
		public c5x a;
	}

	// Token: 0x02000D4F RID: 3407
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004AAC RID: 19116 RVA: 0x001FF3AC File Offset: 0x001FD5AC
		internal bool b(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x001FF3BC File Offset: 0x001FD5BC
		internal bool a(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x04001DDA RID: 7642
		public c5x a;
	}
}
