using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000DB4 RID: 3508
[e79("Sgs_EzraUnlocksTheDoors")]
public sealed class bj0 : dgy
{
	// Token: 0x06004B9A RID: 19354 RVA: 0x0020C064 File Offset: 0x0020A264
	public bj0()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bj0.a a = new bj0.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				aud aud = a.a.Area;
				if (aud != null)
				{
					a.d = (new ar7(new Guid("2f3fb273-71c3-473c-9342-55a51c11bc17"), a.a.Area).ao() as c5x);
					a.c = new EntityAspectReference<cnb, bim>(aud, new Guid("219d2d7e-f28a-4aa9-a313-4aae656fa4eb")).ao();
					a.b = new EntityAspectReference<d2b, d2b>(aud, new Guid("219d2d7e-f28a-4aa9-a313-4aae656fa4eb")).ao();
					if (a.d != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						btm[] array = new btm[1];
						int num = 0;
						s5 s = new s5();
						s.a(new ar7(a.d));
						s.a(new bt4("ezra_unlock"));
						s.IsAsync = false;
						s.a(true);
						array[num] = s;
						base.a(array);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						bb8 bb = new bb8();
						bb.a(CharacterState.Operating);
						bb.a(atp.a);
						bb.IsAsync = false;
						bb.a(new ar7(a.d));
						bb.b(2);
						array2[num2] = bb;
						base.a(array2);
						btm[] array3 = new btm[1];
						int num3 = 0;
						bb8 bb2 = new bb8();
						bb2.a(CharacterState.OperateShort);
						bb2.a(atp.a);
						bb2.IsAsync = false;
						bb2.a(new ar7(a.d));
						bb2.b(1);
						array3[num3] = bb2;
						base.a(array3);
						if (a.b != null)
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(a.c), null, null, null)
							});
						}
						if (a.c != null)
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(a.b), null, null, null)
							});
						}
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(a.d));
						s2.a(new bt4("global:ezra"));
						s2.IsAsync = false;
						s2.a(true);
						array4[num4] = s2;
						base.a(array4);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
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

	// Token: 0x02000DB5 RID: 3509
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B9C RID: 19356 RVA: 0x0020C364 File Offset: 0x0020A564
		internal bool c(e6d A_0)
		{
			this.b.a(true, true);
			return true;
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x0020C378 File Offset: 0x0020A578
		internal bool b(e6d A_0)
		{
			this.c.a(null, null, false, false);
			return true;
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x0020C38C File Offset: 0x0020A58C
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.d.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E69 RID: 7785
		public c5x a;

		// Token: 0x04001E6A RID: 7786
		public d2b b;

		// Token: 0x04001E6B RID: 7787
		public cnb c;

		// Token: 0x04001E6C RID: 7788
		public c5x d;
	}
}
