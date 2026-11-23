using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E62 RID: 3682
[e79("Fo_RunOverOlivia")]
public sealed class cs3 : dgy
{
	// Token: 0x06004D0A RID: 19722 RVA: 0x0021E180 File Offset: 0x0021C380
	public cs3()
	{
		cs3.a a = new cs3.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				a.f = new ar7(new Guid("19303c84-3ea3-452c-ac3a-ffc7884bd402"), a.b.Area);
				a.d = new ar7(new Guid("e6395629-ff35-41aa-980f-15598616c99c"), a.b.Area);
				a.e = (a.f.ao() as c5x);
				a.c = (a.d.ao() as c5x);
				if (a.c != null)
				{
					a.c.VisualPriority = 90;
					a.c.x = true;
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
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array[num] = dky;
					base.a(array);
					base.a(new btm[]
					{
						new ace(new be6
						{
							DestinationWaypoint = "olivia_patrol1"
						})
						{
							InitiatorRef = a.f
						}
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					kw kw = new kw();
					kw.a(new bt4("roadkill"));
					kw.a(true);
					array2[num2] = kw;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array3[num3] = c8s;
					base.a(array3);
					if (a.e != null)
					{
						btm[] array4 = new btm[1];
						int num4 = 0;
						s5 s = new s5();
						s.a(a.f);
						s.a(new bt4("roadkill"));
						s.a(true);
						array4[num4] = s;
						base.a(array4);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array5 = new btm[1];
						int num5 = 0;
						egx egx = new egx();
						egx.a("Что вы делаете с этой вагонеткой?");
						array5[num5] = new ace(egx)
						{
							TargetRef = a.f
						};
						base.a(array5);
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.OperateShort);
					bb.a(new ar7(a.b));
					array6[num6] = bb;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.35))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.b));
					array7[num7] = dva;
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.2))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(a.a));
					array8[num8] = dva2;
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E63 RID: 3683
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D0C RID: 19724 RVA: 0x0021E540 File Offset: 0x0021C740
		internal bool b(e6d A_0)
		{
			etz etz = this.c.o.b as etz;
			if (etz != null)
			{
				etz.b(1);
			}
			csd csd = this.b.Zone.g("cartEnd");
			awx awx = new awx();
			List<auv> list = awx.ad();
			e2d e2d = new e2d();
			e2d.a(false);
			a4s a4s = new a4s(e2d, null, null, null);
			a4s.b(this.d);
			list.Add(a4s);
			awx.ad().Add(new bpr(this.c.j.b, csd.Location));
			List<auv> list2 = awx.ad();
			bfq bfq = new bfq();
			bfq.c("CameraExplosion");
			a4s a4s2 = new a4s(bfq, null, null, null);
			a4s2.b(this.d);
			list2.Add(a4s2);
			List<auv> list3 = awx.ad();
			e01 e = new e01();
			e.a("ExplosionSmall");
			a4s a4s3 = new a4s(e, null, null, null);
			a4s3.b(this.d);
			list3.Add(a4s3);
			this.c.i.b.b(awx, atp.a);
			if (this.e != null)
			{
				this.a.aqu().r()["npc_fo_olivia_murdered"] = true;
				this.a.aqu().r()["npc_fo_olivia_ranOver"] = true;
				qy qy = new qy();
				qy.ad().Add(new bm3(700));
				List<auv> list4 = qy.ad();
				bfq bfq2 = new bfq();
				bfq2.c("CarcassOpen");
				a4s a4s4 = new a4s(bfq2, null, null, null);
				a4s4.b(this.f);
				list4.Add(a4s4);
				List<auv> list5 = qy.ad();
				nb nb = new nb();
				nb.a(bvl.c);
				a4s a4s5 = new a4s(nb, null, null, null);
				a4s5.b(this.f);
				list5.Add(a4s5);
				qy.ad().Add(new a4s(new ezd("locale\\floor\\bloodPuddle", new bt4(this.e.Area.y8(), this.e.Location), null, null, null, null, null), null, null, null));
				this.e.Zone.ActionManager.g9(qy, atp.a);
			}
			return true;
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x0021E790 File Offset: 0x0021C990
		internal bool a(e6d A_0)
		{
			etz etz = this.c.o.b as etz;
			if (etz != null)
			{
				etz.b(0);
				etz.b = new Point(0, 1);
			}
			return true;
		}

		// Token: 0x04001F61 RID: 8033
		public cnk a;

		// Token: 0x04001F62 RID: 8034
		public c5x b;

		// Token: 0x04001F63 RID: 8035
		public c5x c;

		// Token: 0x04001F64 RID: 8036
		public ar7 d;

		// Token: 0x04001F65 RID: 8037
		public c5x e;

		// Token: 0x04001F66 RID: 8038
		public ar7 f;
	}
}
