using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E55 RID: 3669
[e79("Fo_PlacePsiAmplifier")]
public sealed class aks : dgy
{
	// Token: 0x06004CF1 RID: 19697 RVA: 0x0021D3E4 File Offset: 0x0021B5E4
	public aks()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			aks.a a = new aks.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				if (a.a.Area != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
				}
				btm[] array = new btm[1];
				int num = 0;
				s5 s = new s5();
				s.a(new ar7(a.a));
				s.a(new bt4("psiEmitterAccess"));
				s.IsAsync = false;
				s.a(true);
				array[num] = s;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.OperateShort);
				bb.a(new ar7(a.a));
				array2[num2] = bb;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.a));
				array3[num3] = dva;
				base.a(array3);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000E56 RID: 3670
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CF3 RID: 19699 RVA: 0x0021D528 File Offset: 0x0021B728
		internal bool a(e6d A_0)
		{
			csd csd = this.a.Zone.g("psiEmitter");
			if (csd != null)
			{
				c5x c5x = vq.a("object\\plot\\Fo_PsiAmplifier", csd, true);
				if (c5x != null)
				{
					dm dm = new dm(c5x);
					dm.d().Add(new e4n());
					c5x.SetAspect<dm>(dm);
				}
			}
			return true;
		}

		// Token: 0x04001F4F RID: 8015
		public c5x a;
	}
}
