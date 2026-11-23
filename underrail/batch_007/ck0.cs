using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D7A RID: 3450
[e79("Xpbl_DudeHidesUpperUnderrail")]
public sealed class ck0 : dgy
{
	// Token: 0x06004B1F RID: 19231 RVA: 0x00205A2C File Offset: 0x00203C2C
	public ck0()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				c5x c5x2 = new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("b45fb78a-ab31-4364-abd2-fce8442dcc9c"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(c5x2));
					s.a(new bt4("dude_openDoor"));
					s.IsAsync = true;
					s.a(true);
					array[num] = s;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(5.0))
					});
					if (c5x3 != null)
					{
						ck0.a a = new ck0.a();
						a.a = (c5x3.GetAspect<bim>() as cnb);
						if (a.a != null)
						{
							btm[] array2 = new btm[1];
							int num2 = 0;
							bb8 bb = new bb8();
							bb.a(CharacterState.OperateShort);
							bb.a(atp.a);
							bb.IsAsync = false;
							bb.a(new ar7(c5x2));
							bb.b(1);
							array2[num2] = bb;
							base.a(array2);
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(a.a), null, null, null)
							});
						}
					}
					btm[] array3 = new btm[1];
					int num3 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(c5x2));
					s2.a(new bt4("global:rc_dude:exit"));
					s2.IsAsync = true;
					s2.a(true);
					array3[num3] = s2;
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D7B RID: 3451
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B21 RID: 19233 RVA: 0x00205C70 File Offset: 0x00203E70
		internal bool a(e6d A_0)
		{
			this.a.d(false);
			return true;
		}

		// Token: 0x04001E1D RID: 7709
		public cnb a;
	}
}
