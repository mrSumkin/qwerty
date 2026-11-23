using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D16 RID: 3350
[e79("Cc_OlaUnlocksTheDoors")]
public sealed class cp6 : dgy
{
	// Token: 0x06004A2B RID: 18987 RVA: 0x001F4440 File Offset: 0x001F2640
	public cp6()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				aud aud = c5x.Area;
				if (aud != null)
				{
					cp6.a a = new cp6.a();
					c5x c5x2 = new ar7(new Guid("0b777b0b-2bd1-426e-b10d-ca3791663b59"), c5x.Area).ao() as c5x;
					a.b = new EntityAspectReference<cnb, bim>(aud, new Guid("85d18426-74b7-4820-b7ab-076dd1241930")).ao();
					a.a = new EntityAspectReference<d2b, d2b>(aud, new Guid("85d18426-74b7-4820-b7ab-076dd1241930")).ao();
					if (c5x2 != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						btm[] array = new btm[1];
						int num = 0;
						s5 s = new s5();
						s.a(new ar7(c5x));
						s.a(new bt4("player_startWarehouse"));
						s.IsAsync = false;
						s.a(true);
						array[num] = s;
						base.a(array);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(c5x2));
						s2.a(new bt4("ola_unlock"));
						s2.IsAsync = false;
						s2.a(true);
						array2[num2] = s2;
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						bb8 bb = new bb8();
						bb.a(CharacterState.Operating);
						bb.a(atp.a);
						bb.IsAsync = true;
						bb.a(new ar7(c5x2));
						bb.b(1);
						array3[num3] = bb;
						base.a(array3);
						if (a.a != null)
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(a.b), null, null, null)
							});
						}
						if (a.b != null)
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(a.a), null, null, null)
							});
						}
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						s5 s3 = new s5();
						s3.a(new ar7(c5x2));
						s3.a(new bt4("global:cc_ola"));
						s3.IsAsync = false;
						s3.a(true);
						array4[num4] = s3;
						base.a(array4);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array5 = new btm[1];
						int num5 = 0;
						egx egx = new egx();
						egx.a("Путь свободен. Я возвращаюсь в КБР, встреть меня там, когда закончишь.");
						array5[num5] = new ace(egx)
						{
							TargetRef = new ar7(c5x2)
						};
						base.a(array5);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000D17 RID: 3351
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A2D RID: 18989 RVA: 0x001F4744 File Offset: 0x001F2944
		internal bool b(e6d A_0)
		{
			this.a.a(true, false);
			return true;
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x001F4758 File Offset: 0x001F2958
		internal bool a(e6d A_0)
		{
			this.b.d(true);
			return true;
		}

		// Token: 0x04001D8F RID: 7567
		public d2b a;

		// Token: 0x04001D90 RID: 7568
		public cnb b;
	}
}
