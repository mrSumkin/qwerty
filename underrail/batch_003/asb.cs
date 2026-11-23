using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CEA RID: 3306
[e79("Cc_MeetZaman")]
public sealed class asb : dgy
{
	// Token: 0x060049D3 RID: 18899 RVA: 0x001EEA78 File Offset: 0x001ECC78
	public asb()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			asb.b b = new asb.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null)
			{
				b.a.i.b.a(true, false);
				if (b.a.Area != null)
				{
					asb.a a = new asb.a();
					a.b = b;
					a.a = (new ar7(new Guid("70bb3004-9b67-4010-994e-cd449188bab3"), a.b.a.Area).ao() as c5x);
					if (a.a != null)
					{
						a.a.i.b.a(true, false);
						eth.e(a.a.t.b);
						c5x c5x = new ar7(new Guid("cb8d2faa-0f9e-4adc-8f7b-6f03cf8c4a45"), a.b.a.Area).ao() as c5x;
						if (c5x != null)
						{
							c5x.i.b.a(true, false);
							eth.e(c5x.t.b);
						}
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b.a), null, null, null)
						});
						btm[] array = new btm[1];
						int num = 0;
						kw kw = new kw();
						kw.a(new bt4("cc_zamansLair", new Vector3(11f, 20f, 0f)));
						kw.IsAsync = true;
						array[num] = kw;
						base.a(array);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						s5 s = new s5();
						s.a(new ar7(a.a));
						s.a(new bt4("zaman2"));
						s.IsAsync = true;
						s.a(true);
						array2[num2] = s;
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(7.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.c), null, null, null)
						});
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
						bb.a(new ar7(a.a));
						bb.b(2);
						array3[num3] = bb;
						base.a(array3);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b), null, null, null)
						});
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

	// Token: 0x02000CEB RID: 3307
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x060049D5 RID: 18901 RVA: 0x001EEDDC File Offset: 0x001ECFDC
		internal bool a(e6d A_0)
		{
			b6r b6r = new b6r();
			b6r.b(this.a.Area.y8());
			b6r.b(new Guid("3ce8d262-14ca-4553-9fb5-cf2722d6b5ec"));
			b6r.a(new Guid("53dce2da-a204-4e36-b68f-caa08493f5ee"));
			b6r.a(bbo.c);
			b6r.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001D4E RID: 7502
		public c5x a;
	}

	// Token: 0x02000CEC RID: 3308
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049D7 RID: 18903 RVA: 0x001EEE44 File Offset: 0x001ED044
		internal bool c(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x001EEE54 File Offset: 0x001ED054
		internal bool b(e6d A_0)
		{
			new eb7(new Guid?(new Guid("60a61a90-e578-4901-a7db-7fcb407fbed2")), true).ym(this.b.a, null, null);
			this.a.VisualDirection = HorizontalDirection.South;
			return true;
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x001EEE8C File Offset: 0x001ED08C
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.a.GetAspect<j7>(), false, null, true);
			return true;
		}

		// Token: 0x04001D4F RID: 7503
		public c5x a;

		// Token: 0x04001D50 RID: 7504
		public asb.b b;
	}
}
