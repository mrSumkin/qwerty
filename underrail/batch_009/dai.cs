using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CC6 RID: 3270
[e79("Xpbl_Rig_KayaKromVisit")]
public sealed class dai : dgy
{
	// Token: 0x0600498D RID: 18829 RVA: 0x001EA81C File Offset: 0x001E8A1C
	public dai()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			dai.a a = new dai.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				a.c = (new ar7(new Guid("b46e4f1c-afaa-454c-9421-5910388dcd8a"), a.a.Area).ao() as c5x);
				a.b = (new ar7(new Guid("651d60c3-82e8-4fe7-ad15-366a3c96f058"), a.a.Area).ao() as c5x);
				if (a.c != null && a.b != null)
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
						new os(TimeSpan.FromSeconds(1.0))
					});
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
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array2[num2] = c8s;
					base.a(array2);
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

	// Token: 0x02000CC7 RID: 3271
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600498F RID: 18831 RVA: 0x001EAA14 File Offset: 0x001E8C14
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "playerVisitKayaSpot", true);
			a0l.a(this.b, "boss2", true);
			return true;
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x001EAA3C File Offset: 0x001E8C3C
		internal bool a(e6d A_0)
		{
			this.c.GetAspect<j7>().a(this.a.GetAspect<j7>(), true, null, false);
			return true;
		}

		// Token: 0x04001D20 RID: 7456
		public c5x a;

		// Token: 0x04001D21 RID: 7457
		public c5x b;

		// Token: 0x04001D22 RID: 7458
		public c5x c;
	}
}
