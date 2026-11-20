using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E68 RID: 3688
[e79("Lu_FreeDroneRigsTrain")]
public sealed class b9u : dgy
{
	// Token: 0x06004D14 RID: 19732 RVA: 0x0021EC28 File Offset: 0x0021CE28
	public b9u()
	{
		b9u.c c = new b9u.c();
		c.a = bpo.GetServiceOrThrow<cnk>();
		if (c.a != null && c.a.aqu() != null)
		{
			c.b = (c.a.aqu().v().b() as c5x);
			if (c.b != null)
			{
				b9u.a a = new b9u.a();
				a.b = c;
				a.b.b.i.b.a(true, false);
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
				a.a = new ar7();
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.a));
				array2[num2] = dva;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				kw kw = new kw();
				kw.a(new bt4("lu-b29", new Vector3(16f, 25f, 0f)));
				kw.IsAsync = true;
				kw.a(true);
				array3[num3] = kw;
				base.a(array3);
				btm[] array4 = new btm[1];
				int num4 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(b9u.b.a.a));
				array4[num4] = dva2;
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array5[num5] = c8s;
				base.a(array5);
				btm[] array6 = new btm[1];
				int num6 = 0;
				s5 s = new s5();
				s.a(a.a);
				s.a(new bt4("rig_bomber_finish"));
				array6[num6] = s;
				base.a(array6);
				btm[] array7 = new btm[1];
				int num7 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.Operating);
				bb.b(3);
				bb.a(a.a);
				array7[num7] = bb;
				base.a(array7);
				base.a(new btm[]
				{
					new ace(new bfq("ArmTntCharge"))
					{
						TargetRef = a.a
					}
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(a.b.a));
				array8[num8] = dva3;
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(b9u.b.a.b));
				array9[num9] = dva4;
				base.a(array9);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000E69 RID: 3689
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x06004D17 RID: 19735 RVA: 0x0021EF64 File Offset: 0x0021D164
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x0021EF88 File Offset: 0x0021D188
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001F6B RID: 8043
		public static readonly b9u.b a = new b9u.b();

		// Token: 0x04001F6C RID: 8044
		public static Func<e6d, bool> b;

		// Token: 0x04001F6D RID: 8045
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000E6A RID: 3690
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004D1A RID: 19738 RVA: 0x0021EFB8 File Offset: 0x0021D1B8
		internal bool a(e6d A_0)
		{
			c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("Locale\\Objects\\Explosives\\TNT-active");
			if (c5k != null)
			{
				c5x c5x = c5k.a(new Guid?(new Guid("646766CB-7675-4567-B122-F58903C2DB81")), false) as c5x;
				if (c5x != null)
				{
					csd csd = this.b.Zone.g("rig_bomb");
					c5x.q("Бомба");
					c5x.Location = csd.Location;
					c5x.IsGround = true;
					c5x.VisualPriority = 2;
					c5x.TileFormationModifiers.s3(12);
					c5x.Layer = aju.x;
					cij cij = new cij(c5x);
					List<cze> list = cij.n();
					bfq bfq = new bfq("BigTntExplode");
					bfq.a(new Guid?(new Guid("9a4506f6-07a6-4cff-b4b3-f122089b0512")));
					bfq.a("lu-b29");
					list.Add(bfq);
					cij.n().Add(new a3q());
					cij.n().Add(new uk());
					c5x.SetAspect<cij>(cij);
					bim bim = new bim(c5x);
					bim.af2(false);
					bim.j(true);
					List<cze> list2 = bim.s();
					a72 a = new a72();
					a.b("interfacing\\lu_b29_bomb");
					list2.Add(a);
					c5x.SetAspect<bim>(bim);
					c3g c3g = new c3g(c5x);
					c3g.d().Add("neutral");
					c5x.SetAspect<c3g>(c3g);
					this.b.Area.a(c5x);
					int num = 0;
					if (this.a.aqu() != null)
					{
						num = this.a.aqu().r().GetPrimitivePropertyValue<int>("trainheist_bombDistract", new int?(0)).Value;
					}
					this.a.aqu().r()["lo_lu-b29_bombPlanted"] = true;
					cij.a(new int?(120000 - num * 5000));
				}
			}
			return true;
		}

		// Token: 0x04001F6E RID: 8046
		public cnk a;

		// Token: 0x04001F6F RID: 8047
		public c5x b;
	}

	// Token: 0x02000E6B RID: 3691
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D1C RID: 19740 RVA: 0x0021F1AC File Offset: 0x0021D3AC
		internal bool a(e6d A_0)
		{
			csd a_ = this.b.b.Zone.g("rig_bomber_start");
			c5x a_2 = vq.a("creature\\characters\\lu_freeDroneBomber", a_, true);
			this.a.a(a_2);
			return true;
		}

		// Token: 0x04001F70 RID: 8048
		public ar7 a;

		// Token: 0x04001F71 RID: 8049
		public b9u.c b;
	}
}
