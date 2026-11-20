using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000E35 RID: 3637
[e79("Pb_BiohazardTeamArrives")]
public sealed class azx : dgy
{
	// Token: 0x06004CA7 RID: 19623 RVA: 0x00218CC0 File Offset: 0x00216EC0
	public azx()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			azx.a a = new azx.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				if (a.a.Area != null)
				{
					a.g = (new ar7(new Guid("f9f17efb-8940-45a5-ac5f-9a99c5c5e480"), a.a.Area).ao() as c5x);
					a.b = (new ar7(new Guid("8cf6fced-8d88-4c89-ab91-cdbec36847d2"), a.a.Area).ao() as c5x);
					a.c = (new ar7(new Guid("cf94f20a-95fd-4a56-b773-9f1fc7e52c7a"), a.a.Area).ao() as c5x);
					a.d = (new ar7(new Guid("06b7c193-a583-4152-85c0-b9ae228d6413"), a.a.Area).ao() as c5x);
					a.f = (new ar7(new Guid("1f581427-2bb0-4c47-9cf6-b57558158a04"), a.a.Area).ao() as c5x);
					a.e = (new ar7(new Guid("0cb91089-301a-49c3-9329-a9cca493d2fe"), a.a.Area).ao() as c5x);
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
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(azx.b.a.b));
					array3[num3] = dva;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					kw kw = new kw();
					kw.a(new bt4("pr-amb", new Vector3(11f, 14f, 0f)));
					kw.IsAsync = true;
					array4[num4] = kw;
					base.a(array4);
					btm[] array5 = new btm[1];
					int num5 = 0;
					s5 s = new s5();
					s.a(new ar7(a.d));
					s.a(new bt4("guard_mareth_office"));
					s.IsAsync = true;
					s.a(true);
					array5[num5] = s;
					base.a(array5);
					btm[] array6 = new btm[1];
					int num6 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(a.e));
					s2.a(new bt4("dess_stopToLook"));
					s2.IsAsync = true;
					s2.a(true);
					array6[num6] = s2;
					base.a(array6);
					btm[] array7 = new btm[1];
					int num7 = 0;
					s5 s3 = new s5();
					s3.a(new ar7(a.f));
					s3.a(new bt4("guard_void_office"));
					s3.IsAsync = true;
					s3.a(true);
					array7[num7] = s3;
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					egx egx = new egx();
					egx.a("Извините, вам туда нельзя.");
					array8[num8] = new ace(egx)
					{
						TargetRef = new ar7(a.g)
					};
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					egx egx2 = new egx();
					egx2.a("Извините!");
					array9[num9] = new ace(egx2)
					{
						TargetRef = new ar7(a.g)
					};
					base.a(array9);
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
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					s5 s4 = new s5();
					s4.a(new ar7(a.e));
					s4.a(new bt4("guard_dess_office"));
					s4.IsAsync = true;
					s4.a(true);
					array10[num10] = s4;
					base.a(array10);
					btm[] array11 = new btm[1];
					int num11 = 0;
					kw kw2 = new kw();
					kw2.a(new bt4("pr-amb", new Vector3(8f, 8f, 0f)));
					kw2.IsAsync = true;
					array11[num11] = kw2;
					base.a(array11);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(5.0))
					});
					btm[] array12 = new btm[1];
					int num12 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(azx.b.a.a));
					array12[num12] = dva2;
					base.a(array12);
					btm[] array13 = new btm[1];
					int num13 = 0;
					d92 d = new d92();
					d.a("events\\pb_biohazardArrive");
					d.b(new ar7(a.d));
					d.a(new ar7(a.b));
					array13[num13] = d;
					base.a(array13);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E36 RID: 3638
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x06004CAA RID: 19626 RVA: 0x002192DC File Offset: 0x002174DC
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x00219300 File Offset: 0x00217500
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001F20 RID: 7968
		public static readonly azx.b a = new azx.b();

		// Token: 0x04001F21 RID: 7969
		public static Func<e6d, bool> b;

		// Token: 0x04001F22 RID: 7970
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000E37 RID: 3639
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CAD RID: 19629 RVA: 0x00219330 File Offset: 0x00217530
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_biohazardArrive", true);
			a0l.a(this.b, "colonel_consulsOffice", true);
			a0l.a(this.c, "guard_consul", true);
			a0l.a(this.d, "guard_mareth_startWalk", true);
			a0l.a(this.e, "guard_dess_startWalk", true);
			a0l.a(this.f, "guard_void_startWalk", true);
			return true;
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x002193A4 File Offset: 0x002175A4
		internal bool a(e6d A_0)
		{
			this.g.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x04001F23 RID: 7971
		public c5x a;

		// Token: 0x04001F24 RID: 7972
		public c5x b;

		// Token: 0x04001F25 RID: 7973
		public c5x c;

		// Token: 0x04001F26 RID: 7974
		public c5x d;

		// Token: 0x04001F27 RID: 7975
		public c5x e;

		// Token: 0x04001F28 RID: 7976
		public c5x f;

		// Token: 0x04001F29 RID: 7977
		public c5x g;
	}
}
