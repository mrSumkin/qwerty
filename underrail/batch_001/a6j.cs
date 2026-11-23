using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000E9A RID: 3738
[e79("FacelessInvadeCoreCity")]
public sealed class a6j : dgy
{
	// Token: 0x06004D81 RID: 19841 RVA: 0x00224CFC File Offset: 0x00222EFC
	public a6j()
	{
		a6j.b b = new a6j.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			bool flag = b.a.aqu().v().b() is c5x;
			ar7 a_ = new ar7(new Guid("b89c9742-e809-4da6-83af-178641ad097f"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			ar7 a_2 = new ar7(new Guid("9f1cd3f1-cf9f-43b9-b221-a0a67990abea"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			b.a.aqu().r()["hidePlayer"] = true;
			if (flag)
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
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("lu-c1b", "entry"), false, new bool?(false), 0, null, true, false, false)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4("commanderPoint"));
				kw.a(true);
				array2[num2] = kw;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a6j.a.a.a));
				array3[num3] = dva;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(b.a));
				array4[num4] = dva2;
				base.a(array4);
				btm[] array5 = new btm[1];
				int num5 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(b.b));
				array5[num5] = dva3;
				base.a(array5);
				btm[] array6 = new btm[1];
				int num6 = 0;
				s5 s = new s5();
				s.a(a_);
				s.a(new bt4("reportPoint"));
				array6[num6] = s;
				base.a(array6);
				btm[] array7 = new btm[1];
				int num7 = 0;
				d92 d = new d92();
				d.a("events\\coreInvasion1");
				d.b(a_);
				d.a(a_2);
				array7[num7] = d;
				base.a(array7);
			}
		}
	}

	// Token: 0x02000E9B RID: 3739
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004D84 RID: 19844 RVA: 0x00224FD4 File Offset: 0x002231D4
		internal bool a(e6d A_0)
		{
			eta service = bpo.GetService<eta>();
			if (service != null)
			{
				ecs a_ = new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(b94.a(), adi.c), "...Окраины Кор-Сити", null)
					}),
					new dl6(new List<bph>
					{
						new bph(new d22(b94.a(), adi.c), "         двумя часами ранее...", null)
					})
				});
				service.ao6(new ky(a_, null));
			}
			return true;
		}

		// Token: 0x04001FB5 RID: 8117
		public static readonly a6j.a a = new a6j.a();

		// Token: 0x04001FB6 RID: 8118
		public static Func<e6d, bool> b;
	}

	// Token: 0x02000E9C RID: 3740
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004D86 RID: 19846 RVA: 0x0022507C File Offset: 0x0022327C
		internal bool a(e6d A_0)
		{
			new b1a(this.a.aqu().v().c()).be(new ar7(new Guid("ca6bd38c-dde1-4097-bb17-22517fc491b5"), new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a).ao());
			return true;
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x002250D8 File Offset: 0x002232D8
		internal bool b(e6d A_0)
		{
			e6z e6z = new e6z(new Guid("6772970e-ee9d-4281-8edc-9710ec13e547"), new Guid("593913b7-4d30-4b8d-8070-f4f0fcc46891"), bl1.a);
			if (e6z.ao() != null)
			{
				cno cno = e6z.ao().Divinations.a("station");
				if (cno != null)
				{
					cno.a(this.a.aqu().v().c());
					cno.g();
				}
			}
			return true;
		}

		// Token: 0x04001FB7 RID: 8119
		public cnk a;
	}
}
