using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;

// Token: 0x020002A9 RID: 681
[apc("soldierPatrol")]
public class cqw : or
{
	// Token: 0x060013D7 RID: 5079 RVA: 0x00052730 File Offset: 0x00050930
	public virtual bool ef()
	{
		return true;
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x00052734 File Offset: 0x00050934
	public cqw()
	{
		this.a = new fh(new arr[0]);
		this.b = new bud();
		this.c = new ej0();
		this.e = new fh(new arr[0]);
		this.d = new ej0();
		this.f = new bud();
		this.g = new fh(new arr[0]);
		this.h = new ej0();
		this.i = new ej0();
		this.j = new ej0();
		this.k = new a6w(null);
		fh fh = this.a;
		arr[] array = new arr[9];
		array[0] = new arr(this.i, new Func<e1k, bool>(cqw.a.a.f));
		array[1] = new arr(this.k, new Func<e1k, bool>(this.d));
		array[2] = new arr(this.j, new Func<e1k, bool>(this.c));
		array[3] = new arr(this.f, new Func<e1k, bool>(cqw.a.a.h));
		array[4] = new arr(this.z, new Func<e1k, bool>(cqw.a.a.d));
		array[5] = new arr(this.b, new Func<e1k, bool>(this.b));
		array[6] = new arr(this.c, new Func<e1k, bool>(cqw.a.a.b));
		array[7] = new arr(this.ad, new Func<e1k, bool>(this.a));
		array[8] = new arr(this.c, null);
		fh.a(array);
		this.i.a = new Action<ej0>(cqw.a.a.b);
		this.i.a = this.i.a;
		this.j.a = new Action<ej0>(this.b);
		this.j.a = this.a;
		this.k.a = new Func<a6w, cst>(this.a);
		this.k.a = this.a;
		this.k.b = this.a;
		this.b.a.Add(this.c);
		this.b.a.Add(this.e);
		this.b.b = new Func<bud, int>(cqw.a.a.b);
		this.c.a = this.c;
		this.c.a = new Action<ej0>(cqw.a.a.c);
		this.f.a.Add(this.h);
		this.f.a.Add(this.g);
		this.f.b = new Func<bud, int>(cqw.a.a.a);
		fh fh2 = this.e;
		arr[] array2 = new arr[3];
		array2[0] = new arr(this.j, new Func<e1k, bool>(cqw.a.a.e));
		array2[1] = new arr(this.d, new Func<e1k, bool>(cqw.a.a.a));
		array2[2] = new arr(this.c, null);
		fh2.a(array2);
		this.h.a = new Action<ej0>(cqw.a.a.a);
		this.h.a = this.j;
		fh fh3 = this.g;
		arr[] array3 = new arr[3];
		array3[0] = new arr(this.j, new Func<e1k, bool>(cqw.a.a.g));
		array3[1] = new arr(this.h, new Func<e1k, bool>(cqw.a.a.c));
		array3[2] = new arr(this.c, null);
		fh3.a(array3);
		this.d.a = new Action<ej0>(this.a);
		this.d.a = this.j;
		this.i.a = this.a;
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x00052C28 File Offset: 0x00050E28
	public override void ag8()
	{
		base.ag8();
		this.l = null;
		if (base.c() != null && base.c().a8() != null && base.c().a8().Zone != null)
		{
			TimeSpan? primitivePropertyValue = base.c().y6().GetPrimitivePropertyValue<TimeSpan>(ddq.m, null);
			if (primitivePropertyValue != null && primitivePropertyValue > base.c().a8().Zone.ElapsedZoneTime)
			{
				this.l = primitivePropertyValue - base.c().a8().Zone.ElapsedZoneTime;
			}
		}
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x00052D28 File Offset: 0x00050F28
	public override void jm()
	{
		base.jm();
		if (this.l != null && base.c() != null && base.c().a8() != null && base.c().a8().Zone != null)
		{
			base.c().y6()[ddq.m] = base.c().a8().Zone.ElapsedZoneTime + this.l.Value;
		}
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x00052DBC File Offset: 0x00050FBC
	public override void ag9()
	{
		base.ag9();
		if (this.l != null && (this.l -= TimeSpan.FromMilliseconds((double)d0u.b)) <= TimeSpan.Zero)
		{
			this.l = null;
		}
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x00052E60 File Offset: 0x00051060
	[CompilerGenerated]
	private new bool d(e1k A_0)
	{
		if (!base.d().GetPrimitivePropertyValue<bool>("triedToThrowFlareAtPlayer", new bool?(false)).Value && ew0.b() && A_0.g().aa().b(d8o.b | d8o.c | d8o.d))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && c5x.h.b.aa().SpecialStates.g && A_0.g().a(c5x.h.b) == global::h.a)
				{
					erl erl = new bzv(A_0.c().y6()).d(c5x.qe());
					if (erl != null && erl.f() == cem.c && Enumerable.FirstOrDefault<coh>(A_0.g().aa().Bag.b("flare")) != null)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x00052FA4 File Offset: 0x000511A4
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		if (this.ef() && !base.d().GetPrimitivePropertyValue<bool>("setNoiseBackupToBumpPlayerOutOfStealth", new bool?(false)).Value && ew0.b() && !A_0.c().ad().GetPrimitivePropertyValue<bool>("Civilian", new bool?(false)).Value)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && A_0.g().a(c5x.h.b) == global::h.a)
				{
					erl erl = new bzv(A_0.c().y6()).d(c5x.qe());
					if (erl != null && erl.f() == cem.c)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x000530C0 File Offset: 0x000512C0
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		return this.l == null && eth.m(A_0.c());
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x000530E4 File Offset: 0x000512E4
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (A_0.c().a8().k == null || A_0.c().a8().k.b == null || A_0.d().GetPrimitivePropertyValue<bool>("attemptedToFollowTarget", new bool?(false)).Value)
		{
			return false;
		}
		if (!A_0.g().aa().IsInControl)
		{
			return false;
		}
		b0b b0b = base.cz(A_0);
		if (b0b == null || b0b.Area == null)
		{
			return false;
		}
		if (b0b.Area != A_0.c().a8().Area)
		{
		}
		bpo.GetServiceOrThrow<d02>();
		ak1 a_ = b0b.Area.a(b0b.aj().a());
		if (!A_0.c().a(a_))
		{
		}
		float num = (float)aw1.b(b0b, A_0.c().a8());
		base.c0(A_0);
		return base.c0(A_0) + 1f < num;
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x000531F8 File Offset: 0x000513F8
	[CompilerGenerated]
	private new void b(ej0 A_0)
	{
		base.d()["setNoiseBackupToBumpPlayerOutOfStealth"] = true;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null && c5x.h.b != null)
			{
				bt4 value = new bt4(c5x.Area.y8(), c5x.Location);
				A_0.b().c().y6()[ddq.an] = value;
			}
		}
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x000532BC File Offset: 0x000514BC
	[CompilerGenerated]
	private new cst a(a6w A_0)
	{
		base.d()["triedToThrowFlareAtPlayer"] = true;
		if (ew0.b())
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && A_0.b().g().a(c5x.h.b) == global::h.a)
				{
					erl erl = new bzv(A_0.b().c().y6()).d(c5x.qe());
					if (erl != null && erl.f() == cem.c)
					{
						coh coh = Enumerable.FirstOrDefault<coh>(A_0.b().g().aa().Bag.b("flare"));
						if (coh != null)
						{
							c3n c3n = dgk.Get<kh>();
							if (c3n != null)
							{
								ak1 ak = c5x.Area.a(c5x.aj().a());
								if (ak != null)
								{
									eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0.b().g())), coh) as eu7;
									if (eu != null && eu.yw())
									{
										bt4 value = new bt4(c5x.Area.y8(), c5x.Location);
										A_0.b().c().y6()[ddq.an] = value;
										return global::cp.b(eu, A_0.b().g().a8(), ak);
									}
								}
							}
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x0005347C File Offset: 0x0005167C
	[CompilerGenerated]
	private new void a(ej0 A_0)
	{
		int? primitivePropertyValue = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.l, null);
		if (primitivePropertyValue != null)
		{
			int? num = primitivePropertyValue;
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				int? primitivePropertyValue2 = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.j, null);
				List<string> classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<List<string>>(ddq.k);
				if (primitivePropertyValue2 != null && classPropertyValue != null && primitivePropertyValue2.Value < classPropertyValue.Count)
				{
					aud aud;
					Vector3 vector;
					HorizontalDirection a_;
					new bt4(classPropertyValue[primitivePropertyValue2.Value]).a(A_0.b().c().a8().Zone, out aud, out vector, out a_);
					A_0.b().c().a8().VisualDirection = a_;
				}
				this.l = new TimeSpan?(TimeSpan.FromMilliseconds((double)primitivePropertyValue.Value));
			}
		}
		eth.k(A_0.b().c());
	}

	// Token: 0x04000AAA RID: 2730
	protected new fh a;

	// Token: 0x04000AAB RID: 2731
	protected new bud b;

	// Token: 0x04000AAC RID: 2732
	protected new ej0 c;

	// Token: 0x04000AAD RID: 2733
	protected new ej0 d;

	// Token: 0x04000AAE RID: 2734
	protected new fh e;

	// Token: 0x04000AAF RID: 2735
	protected new bud f;

	// Token: 0x04000AB0 RID: 2736
	protected new fh g;

	// Token: 0x04000AB1 RID: 2737
	protected new ej0 h;

	// Token: 0x04000AB2 RID: 2738
	protected new ej0 i;

	// Token: 0x04000AB3 RID: 2739
	private new ej0 j;

	// Token: 0x04000AB4 RID: 2740
	private new a6w k;

	// Token: 0x04000AB5 RID: 2741
	private new TimeSpan? l;

	// Token: 0x02000320 RID: 800
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060016F6 RID: 5878 RVA: 0x00072478 File Offset: 0x00070678
		internal bool f(e1k A_0)
		{
			if (!A_0.g().aa().IsInCombat && A_0.g().aa().b(d8o.b | d8o.d | d8o.h))
			{
				int num = A_0.g().aa().Skills.Get<c0b>().g();
				if (num >= 5)
				{
					ed2 ed = A_0.c().b(num);
					if (ed != null && ed.f == asp.a && ed.d <= num)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0007250C File Offset: 0x0007070C
		internal bool h(e1k A_0)
		{
			return eth.j(A_0.c());
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0007251C File Offset: 0x0007071C
		internal bool d(e1k A_0)
		{
			bool flag = eth.g(A_0.c()) != null;
			ak1 ak = eth.f(A_0.c());
			return flag || ak != null;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x0007254C File Offset: 0x0007074C
		internal bool b(e1k A_0)
		{
			return eth.c(A_0.c()) && !eth.d(A_0.c());
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00072574 File Offset: 0x00070774
		internal void b(ej0 A_0)
		{
			int num = A_0.b().g().aa().Skills.Get<c0b>().g();
			if (num >= 5)
			{
				ed2 ed = A_0.b().c().b(num);
				if (ed != null && ed.f == asp.a)
				{
					c3n c3n = dgk.Get<bb3>();
					if (c3n != null)
					{
						eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0.b().g())), null) as eu7;
						if (eu != null && eu.yw())
						{
							global::cp.b(eu, A_0.b().g().a8(), ed.a8());
						}
					}
				}
			}
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00072634 File Offset: 0x00070834
		internal int b(bud A_0)
		{
			if (A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.j, null) == null)
			{
				eth.k(A_0.b().c());
			}
			ak1 ak = eth.l(A_0.b().c());
			if (ak != null)
			{
				ale ale = A_0.b().c().a8().k.b;
				if (ale != null)
				{
					ale.a(ak, 3.0, 1, 0, true);
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x000726D0 File Offset: 0x000708D0
		internal void c(ej0 A_0)
		{
			bt4 classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<bt4>("GuardLoc");
			if (classPropertyValue != null)
			{
				aud aud;
				Vector3 vector;
				HorizontalDirection a_;
				classPropertyValue.a(A_0.b().g().a8().Zone, out aud, out vector, out a_);
				if (aud == A_0.b().g().a8().Area)
				{
					if (A_0.b().g().a8().Location == vector)
					{
						if (A_0.b().c().y6().GetPrimitivePropertyValue<bool>(ddq.az, new bool?(true)).Value)
						{
							A_0.b().g().a8().VisualDirection = a_;
							return;
						}
					}
					else
					{
						ak1 ak = aud.a(vector.a());
						if (ak != null)
						{
							ale ale = A_0.b().c().a8().k.b;
							if (ale != null)
							{
								ale.a(ak, 0.0, 1, 0, true);
							}
						}
					}
				}
			}
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x000727F0 File Offset: 0x000709F0
		internal int a(bud A_0)
		{
			ak1 ak = eth.i(A_0.b().c());
			if (ak != null)
			{
				ale ale = A_0.b().c().a8().k.b;
				if (ale != null)
				{
					if (A_0.b().c().y6().GetPrimitivePropertyValue<bool>(ddq.aj, new bool?(false)).Value)
					{
						ale.a(ak, A_0.b().g().aa().SightRange, 1, 0);
					}
					else
					{
						ale.a(ak, double.MaxValue, 1, 0);
					}
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0007289C File Offset: 0x00070A9C
		internal bool e(e1k A_0)
		{
			return !A_0.g().aa().IsInControl;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x000728B4 File Offset: 0x00070AB4
		internal bool a(e1k A_0)
		{
			d4n d4n = A_0.e();
			return d4n != null && d4n.g();
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x000728D8 File Offset: 0x00070AD8
		internal void a(ej0 A_0)
		{
			eth.h(A_0.b().c());
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x000728EC File Offset: 0x00070AEC
		internal bool g(e1k A_0)
		{
			return !A_0.g().aa().IsInControl;
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00072904 File Offset: 0x00070B04
		internal bool c(e1k A_0)
		{
			d4n d4n = A_0.e();
			return d4n != null && d4n.g();
		}

		// Token: 0x04000D91 RID: 3473
		public static readonly cqw.a a = new cqw.a();

		// Token: 0x04000D92 RID: 3474
		public static Func<e1k, bool> b;

		// Token: 0x04000D93 RID: 3475
		public static Func<e1k, bool> c;

		// Token: 0x04000D94 RID: 3476
		public static Func<e1k, bool> d;

		// Token: 0x04000D95 RID: 3477
		public static Func<e1k, bool> e;

		// Token: 0x04000D96 RID: 3478
		public static Action<ej0> f;

		// Token: 0x04000D97 RID: 3479
		public static Func<bud, int> g;

		// Token: 0x04000D98 RID: 3480
		public static Action<ej0> h;

		// Token: 0x04000D99 RID: 3481
		public static Func<bud, int> i;

		// Token: 0x04000D9A RID: 3482
		public static Func<e1k, bool> j;

		// Token: 0x04000D9B RID: 3483
		public static Func<e1k, bool> k;

		// Token: 0x04000D9C RID: 3484
		public static Action<ej0> l;

		// Token: 0x04000D9D RID: 3485
		public static Func<e1k, bool> m;

		// Token: 0x04000D9E RID: 3486
		public static Func<e1k, bool> n;
	}
}
