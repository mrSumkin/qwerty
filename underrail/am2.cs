using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000386 RID: 902
[fe("soldierPatrol")]
public class am2 : bwv
{
	// Token: 0x060018EF RID: 6383 RVA: 0x00081890 File Offset: 0x0007FA90
	public am2(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new byh("AttackOnSight", new Func<TimeSpan, double, bool>(this.ad), new Func<TimeSpan, double, cst>(this.ac), new Func<bool, float>(am2.a.a.g), null)
		{
			e = true
		});
		list.Add(new byh("Escape fire", new Func<TimeSpan, double, bool>(this.ab), new Func<TimeSpan, double, cst>(this.z), new Func<bool, float>(am2.a.a.b), null)
		{
			e = false
		});
		string a_ = "Guarding";
		Func<bool> a_2 = new Func<bool>(this.e);
		Func<bool, float> a_3 = new Func<bool, float>(am2.a.a.l);
		List<c96> list2 = new List<c96>();
		list2.Add(new cm7("TrekToRightWaypoint", new Func<bool>(this.d), new Func<bool, float>(am2.a.a.k), new List<c96>
		{
			new cnp("TrekToWaypoint")
			{
				b = "GuardLoc",
				c = 0.9f,
				b = double.MaxValue,
				d = 1500
			}
		}));
		list2.Add(new b64("FaceCorrectWay or despawn", new Func<TimeSpan, double, bool>(this.y), new Func<TimeSpan, double, ej1>(this.x), new Func<bool, float>(am2.a.a.i), null));
		list2.Add(new byh("Animate while guarding", new Func<TimeSpan, double, bool>(this.w), new Func<TimeSpan, double, cst>(this.v), new Func<bool, float>(am2.a.a.f), new Func<cst>(this.c)));
		list2.Add(new b64("Custom Idle Anim", new Func<TimeSpan, double, bool>(this.u), new Func<TimeSpan, double, ej1>(this.t), new Func<bool, float>(am2.a.a.j), new Action(this.b)));
		list.Add(new cm7(a_, a_2, a_3, list2));
		list.Add(new b64("GuardHostage", new Func<TimeSpan, double, bool>(this.s), new Func<TimeSpan, double, ej1>(this.r), new Func<bool, float>(am2.a.a.n), new Action(this.a)));
		string a_4 = "Patrol";
		Func<TimeSpan, double, bool> a_5 = new Func<TimeSpan, double, bool>(this.q);
		Func<bool, float> a_6 = new Func<bool, float>(am2.a.a.m);
		List<c96> list3 = new List<c96>();
		list3.Add(new b64("DelayUntilNextWaypoint", new Func<TimeSpan, double, bool>(this.p), new Func<TimeSpan, double, ej1>(this.o), new Func<bool, float>(am2.a.a.o), new Action(am2.a.a.a)));
		list3.Add(new b64("SetFirstWaypointIndex", new Func<TimeSpan, double, bool>(this.n), new Func<TimeSpan, double, ej1>(this.m), new Func<bool, float>(am2.a.a.a), null));
		list3.Add(new ere("TrekToPatrolWaypoint", new Func<TimeSpan, double, bool>(this.l), new Func<bool, float>(am2.a.a.e), new List<c96>
		{
			new ceq("Trek", new Func<TimeSpan, double, ak1>(this.k))
			{
				c = 5,
				d = 1000,
				b = 3.0,
				c = new Action<TimeSpan, double>(this.j),
				b = new Action<TimeSpan, double>(this.i)
			}
		}));
		list.Add(new ere(a_4, a_5, a_6, list3));
		string a_7 = "FulfillBackupRequest";
		Func<TimeSpan, double, bool> a_8 = new Func<TimeSpan, double, bool>(this.h);
		Func<bool, float> a_9 = new Func<bool, float>(am2.a.a.h);
		List<c96> list4 = new List<c96>();
		list4.Add(new ere("RangedBackup", new Func<TimeSpan, double, bool>(this.g), new Func<bool, float>(am2.a.a.c), new List<c96>
		{
			new ceq("TrekToBackupLoc", new Func<TimeSpan, double, ak1>(this.f))
			{
				f = dnw.c,
				c = 5,
				d = 1000,
				b = double.MaxValue,
				c = new Action<TimeSpan, double>(this.e),
				b = new Action<TimeSpan, double>(this.d),
				e = 3000
			}
		}));
		list4.Add(new ere("MeleeBackup", new Func<TimeSpan, double, bool>(am2.a.a.a), new Func<bool, float>(am2.a.a.d), new List<c96>
		{
			new ceq("TrekToBackupLoc", new Func<TimeSpan, double, ak1>(this.c))
			{
				f = dnw.a,
				c = 5,
				d = 1000,
				b = double.MaxValue,
				c = new Action<TimeSpan, double>(this.b),
				b = new Action<TimeSpan, double>(this.a),
				e = 3000
			}
		}));
		list.Add(new ere(a_7, a_8, a_9, list4));
		base.a(list);
	}

	// Token: 0x060018F0 RID: 6384 RVA: 0x00081ECC File Offset: 0x000800CC
	[CompilerGenerated]
	private bool ad(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.ar, new bool?(false)).Value)
		{
			string classPropertyValue = this.Subject.y6().GetClassPropertyValue<string>(ddq.@as);
			if (!string.IsNullOrEmpty(classPropertyValue) && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(classPropertyValue, new bool?(false)).Value)
			{
				return false;
			}
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				if (blk != null && blk.b() && blk.f() != global::h.a && d3k.a(c5x.h.b.aa()))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060018F1 RID: 6385 RVA: 0x00081FFC File Offset: 0x000801FC
	[CompilerGenerated]
	private cst ac(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			return new a27(base.h(), c5x.h.b, false, false, false, true);
		}
		return null;
	}

	// Token: 0x060018F2 RID: 6386 RVA: 0x0008208C File Offset: 0x0008028C
	[CompilerGenerated]
	private bool ab(TimeSpan A_0, double A_1)
	{
		return dd5.a(base.h()) <= 4 && dd5.b(this.Subject.a8()) > 0;
	}

	// Token: 0x060018F3 RID: 6387 RVA: 0x000820B8 File Offset: 0x000802B8
	[CompilerGenerated]
	private cst z(TimeSpan A_0, double A_1)
	{
		ak1 ak = g8.b(this.Subject);
		if (ak != null)
		{
			return this.Subject.a8().k.b.a(ak, 0.0, 1, 0, true);
		}
		return null;
	}

	// Token: 0x060018F4 RID: 6388 RVA: 0x00082100 File Offset: 0x00080300
	[CompilerGenerated]
	private bool e()
	{
		return this.Subject.y6().GetClassPropertyValue<bt4>("GuardLoc") != null && this.Subject.a8().h.b.aa().IsInControl;
	}

	// Token: 0x060018F5 RID: 6389 RVA: 0x00082148 File Offset: 0x00080348
	[CompilerGenerated]
	private bool d()
	{
		bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>("GuardLoc");
		return !aw1.a(this.Subject.a8(), classPropertyValue, false);
	}

	// Token: 0x060018F6 RID: 6390 RVA: 0x00082180 File Offset: 0x00080380
	[CompilerGenerated]
	private bool y(TimeSpan A_0, double A_1)
	{
		bool value = this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.az, new bool?(true)).Value;
		if (!value)
		{
			return value;
		}
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.a2, null);
		if (primitivePropertyValue != null && primitivePropertyValue.Value > A_0)
		{
			return false;
		}
		bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>("GuardLoc");
		if (classPropertyValue != null)
		{
			aud aud;
			Vector3 vector;
			HorizontalDirection horizontalDirection;
			classPropertyValue.a(this.Subject.a8().Zone, out aud, out vector, out horizontalDirection);
			if (aw1.a(this.Subject.a8(), classPropertyValue, false))
			{
				return horizontalDirection != this.Subject.a8().VisualDirection || this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.bg, new bool?(false)).Value;
			}
		}
		return false;
	}

	// Token: 0x060018F7 RID: 6391 RVA: 0x0008228C File Offset: 0x0008048C
	[CompilerGenerated]
	private ej1 x(TimeSpan A_0, double A_1)
	{
		if (this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.bg, new bool?(false)).Value)
		{
			this.Subject.y6().RemoveProperty(ddq.bg);
			if (this.Subject.y6().GetClassPropertyValue<string>(ddq.bh) != null)
			{
				cxz cxz = new cxz();
				cxz.a(this.Subject.y6().GetClassPropertyValue<string>(ddq.bh));
				cxz.ym(null, this.Subject.a8(), null);
				this.Subject.y6().RemoveProperty(ddq.bh);
			}
			uk uk = new uk();
			uk.a(bvl.c);
			uk.c(true);
			uk.ym(null, this.Subject.a8(), null);
			return ej1.b;
		}
		bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>("GuardLoc");
		if (classPropertyValue != null)
		{
			aud aud;
			Vector3 vector;
			HorizontalDirection a_;
			classPropertyValue.a(this.Subject.a8().Zone, out aud, out vector, out a_);
			if (aud != null)
			{
				this.Subject.a8().VisualDirection = a_;
				return ej1.b;
			}
		}
		return ej1.c;
	}

	// Token: 0x060018F8 RID: 6392 RVA: 0x000823B4 File Offset: 0x000805B4
	[CompilerGenerated]
	private bool w(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<CharacterState>(ddq.w, null) != null;
	}

	// Token: 0x060018F9 RID: 6393 RVA: 0x000823F0 File Offset: 0x000805F0
	[CompilerGenerated]
	private cst v(TimeSpan A_0, double A_1)
	{
		CharacterState? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<CharacterState>(ddq.w, null);
		if (primitivePropertyValue != null)
		{
			int value = this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.x, new int?(cux.a)).Value;
			awx awx = new awx("GuardAnimation");
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			string classPropertyValue = this.Subject.y6().GetClassPropertyValue<string>(ddq.aa);
			float value2 = this.Subject.y6().GetPrimitivePropertyValue<float>(ddq.ab, new float?(1f)).Value;
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				List<auv> list = awx.ad();
				bfq bfq = new bfq("guardLoopSound", classPropertyValue);
				bfq.a(true);
				bfq.a(value2);
				bfq.d(true);
				list.Add(new a4s(bfq, new ar7(this.Subject.a8()), new ar7(this.Subject.a8()), null));
			}
			int value3 = this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.y, new int?(0)).Value;
			string classPropertyValue2 = this.Subject.y6().GetClassPropertyValue<string>(ddq.z);
			if (value3 > 0 || !string.IsNullOrEmpty(classPropertyValue2))
			{
				for (int i = 0; i < 20; i++)
				{
					if (!string.IsNullOrEmpty(classPropertyValue2))
					{
						awx.ad().Add(new a4s(new bfq(classPropertyValue2), new ar7(this.Subject.a8()), new ar7(this.Subject.a8()), null));
					}
					awx.ad().Add(new e4t(base.h(), primitivePropertyValue.Value, value, 0, null, 1));
					if (value3 > 0)
					{
						awx.ad().Add(new e4t(base.h(), base.h().ap.GetValueOrDefault(), 1, 0, null, 1));
						awx.ad().Add(new bm3(value3));
					}
				}
			}
			else
			{
				awx.ad().Add(new e4t(base.h(), primitivePropertyValue.Value, value, 0, null, int.MaxValue));
			}
			return awx;
		}
		return null;
	}

	// Token: 0x060018FA RID: 6394 RVA: 0x00082668 File Offset: 0x00080868
	[CompilerGenerated]
	private new cst c()
	{
		b18 b = new b18();
		b.b("guardLoopSound");
		return new a4s(b, new ar7(this.Subject.a8()), new ar7(this.Subject.a8()), null);
	}

	// Token: 0x060018FB RID: 6395 RVA: 0x000826AC File Offset: 0x000808AC
	[CompilerGenerated]
	private bool u(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<CharacterState>(ddq.ac, null) != null;
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x000826E0 File Offset: 0x000808E0
	[CompilerGenerated]
	private ej1 t(TimeSpan A_0, double A_1)
	{
		CharacterState? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<CharacterState>(ddq.ac, null);
		int? primitivePropertyValue2 = this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.ad, null);
		if (primitivePropertyValue != null)
		{
			this.Subject.a8().h.b.ap = new CharacterState?(primitivePropertyValue.Value);
		}
		if (primitivePropertyValue2 != null)
		{
			this.Subject.a8().h.b.aq = new int?(primitivePropertyValue2.Value);
		}
		return ej1.a;
	}

	// Token: 0x060018FD RID: 6397 RVA: 0x00082790 File Offset: 0x00080990
	[CompilerGenerated]
	private void b()
	{
		this.Subject.a8().h.b.ap = null;
		this.Subject.a8().h.b.aq = null;
	}

	// Token: 0x060018FE RID: 6398 RVA: 0x000827E0 File Offset: 0x000809E0
	[CompilerGenerated]
	private bool s(TimeSpan A_0, double A_1)
	{
		Guid? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<Guid>(ddq.aw, null);
		if (primitivePropertyValue != null)
		{
			blk blk = new bzv(this.Subject.y6()).c(primitivePropertyValue.Value);
			return blk != null && blk.b();
		}
		return false;
	}

	// Token: 0x060018FF RID: 6399 RVA: 0x00082848 File Offset: 0x00080A48
	[CompilerGenerated]
	private ej1 r(TimeSpan A_0, double A_1)
	{
		Guid? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<Guid>(ddq.aw, null);
		if (primitivePropertyValue != null)
		{
			ar7 ar = this.Subject.y6().GetClassPropertyValue<ar7>(ddq.ax);
			if (ar == null)
			{
				ar = new ar7(primitivePropertyValue.Value, this.Subject.a8().Area);
				this.Subject.y6()[ddq.ax] = ar;
			}
			if (ar.ao() != null)
			{
				this.Subject.a8().h.b.aq = new int?(0);
				this.Subject.a8().h.b.ap = new CharacterState?(CharacterState.Attack1);
				aw1.b(this.Subject.a8(), ar.ao(), true);
			}
		}
		return ej1.a;
	}

	// Token: 0x06001900 RID: 6400 RVA: 0x00082934 File Offset: 0x00080B34
	[CompilerGenerated]
	private void a()
	{
		if (this.Subject.a8().h.b.ap.GetValueOrDefault() == CharacterState.Attack1)
		{
			this.Subject.a8().h.b.aq = null;
			this.Subject.a8().h.b.ap = null;
		}
	}

	// Token: 0x06001901 RID: 6401 RVA: 0x000829A8 File Offset: 0x00080BA8
	[CompilerGenerated]
	private bool q(TimeSpan A_0, double A_1)
	{
		return eth.m(this.Subject);
	}

	// Token: 0x06001902 RID: 6402 RVA: 0x000829B8 File Offset: 0x00080BB8
	[CompilerGenerated]
	private bool p(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.m, null) != null;
	}

	// Token: 0x06001903 RID: 6403 RVA: 0x000829EC File Offset: 0x00080BEC
	[CompilerGenerated]
	private ej1 o(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.m, null);
		int? primitivePropertyValue2 = this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.l, null);
		if (primitivePropertyValue == null || primitivePropertyValue.Value < A_0)
		{
			this.Subject.y6().RemoveProperty(ddq.m);
			return ej1.b;
		}
		if (primitivePropertyValue != null && primitivePropertyValue2 != null && primitivePropertyValue.Value > A_0 + TimeSpan.FromMilliseconds((double)primitivePropertyValue2.Value))
		{
			primitivePropertyValue = new TimeSpan?(A_0 + TimeSpan.FromMilliseconds((double)primitivePropertyValue2.Value));
			this.Subject.y6()[ddq.m] = primitivePropertyValue;
		}
		if (this.Subject.a8().i.b != null)
		{
			if (this.Subject.a8().i.b.a() != null && this.Subject.a8().i.b.a().Name == "ClosingDoor")
			{
				return ej1.a;
			}
			if (this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.u, new bool?(false)).Value)
			{
				this.Subject.a8().Area.a(this.Subject.a8().aj().a());
				foreach (ak1 ak in aw1.a(this.Subject.a8(), true))
				{
					if (!aw1.a(null, ak, false, null))
					{
						foreach (b0b b0b in ak.c.Values)
						{
							c5x c5x = (c5x)b0b;
							cnb cnb = c5x.s.b as cnb;
							if (cnb != null && cnb.q())
							{
								awx awx = new awx("ClosingDoor");
								awx awx2 = awx;
								awx2.a(awx2.kh() | m7.b);
								List<auv> list = awx.ad();
								a4s a4s = new a4s(new akw(), null, null, null);
								a4s.a(new ar7(this.Subject.a8()));
								a4s.b(new ar7(c5x));
								list.Add(a4s);
								awx.ad().Add(new e4t(base.h(), CharacterState.OperateShort, cux.a, 0, null, 1));
								awx.ad().Add(new b9t(this.Subject.a8(), cnb, null));
								this.Subject.a8().i.b.b(awx, atp.a);
								return ej1.a;
							}
						}
					}
				}
			}
		}
		if (this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.n, new bool?(false)).Value)
		{
			int? primitivePropertyValue3 = this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.j, null);
			List<string> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<string>>(ddq.k);
			if (primitivePropertyValue3 != null && classPropertyValue != null && primitivePropertyValue3.Value < classPropertyValue.Count)
			{
				int num = primitivePropertyValue3.Value - 1;
				if (num < 0)
				{
					num = classPropertyValue.Count - 1;
				}
				aud aud;
				Vector3 vector;
				HorizontalDirection a_;
				new bt4(classPropertyValue[num]).a(this.Subject.a8().Zone, out aud, out vector, out a_);
				this.Subject.a8().VisualDirection = a_;
			}
		}
		CharacterState? primitivePropertyValue4 = this.Subject.y6().GetPrimitivePropertyValue<CharacterState>(ddq.o, null);
		if (primitivePropertyValue4 != null)
		{
			List<string> list2 = this.Subject.y6().GetPropertyValue(ddq.v) as List<string>;
			string text = eth.b(this.Subject);
			if ((list2 == null || (!string.IsNullOrEmpty(text) && list2.Contains(text))) && this.Subject.a8().i.b != null && (this.Subject.a8().i.b.a() == null || this.Subject.a8().i.b.a().Name != "PatrolDelayAnimation") && !this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.t, new bool?(false)).Value)
			{
				int value = this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.s, new int?(1)).Value;
				int value2 = this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.r, new int?(cux.a)).Value;
				string classPropertyValue2 = this.Subject.y6().GetClassPropertyValue<string>(ddq.p);
				float value3 = this.Subject.y6().GetPrimitivePropertyValue<float>(ddq.q, new float?((float)1)).Value;
				awx awx3 = new awx("PatrolDelayAnimation");
				awx awx4 = awx3;
				awx4.a(awx4.kh() | m7.b);
				if (!string.IsNullOrEmpty(classPropertyValue2) && value < 50)
				{
					for (int i = 0; i < value; i++)
					{
						List<auv> list3 = awx3.ad();
						bfq bfq = new bfq(classPropertyValue2);
						bfq.a(value3);
						list3.Add(new a4s(bfq, null, new ar7(this.Subject.a8()), null));
						awx3.ad().Add(new e4t(base.h(), primitivePropertyValue4.Value, value2, 0, null, 1));
					}
				}
				else
				{
					List<auv> list4 = awx3.ad();
					amc a_2 = base.h();
					CharacterState value4 = primitivePropertyValue4.Value;
					int a_3 = value2;
					int a_4 = 0;
					int a_5 = value;
					list4.Add(new e4t(a_2, value4, a_3, a_4, null, a_5));
				}
				this.Subject.a8().i.b.b(awx3, atp.a);
				this.Subject.y6()[ddq.t] = true;
			}
		}
		return ej1.a;
	}

	// Token: 0x06001904 RID: 6404 RVA: 0x000830D8 File Offset: 0x000812D8
	[CompilerGenerated]
	private bool n(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.j, null) == null;
	}

	// Token: 0x06001905 RID: 6405 RVA: 0x00083110 File Offset: 0x00081310
	[CompilerGenerated]
	private ej1 m(TimeSpan A_0, double A_1)
	{
		this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.j, null);
		List<string> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<string>>(ddq.k);
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			this.Subject.y6()[ddq.j] = 0;
			return ej1.b;
		}
		return ej1.c;
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x00083184 File Offset: 0x00081384
	[CompilerGenerated]
	private bool l(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.j, null) != null;
	}

	// Token: 0x06001907 RID: 6407 RVA: 0x000831B8 File Offset: 0x000813B8
	[CompilerGenerated]
	private ak1 k(TimeSpan A_0, double A_1)
	{
		return eth.l(this.Subject);
	}

	// Token: 0x06001908 RID: 6408 RVA: 0x000831C8 File Offset: 0x000813C8
	[CompilerGenerated]
	private void j(TimeSpan A_0, double A_1)
	{
		eth.k(this.Subject);
	}

	// Token: 0x06001909 RID: 6409 RVA: 0x000831D8 File Offset: 0x000813D8
	[CompilerGenerated]
	private void i(TimeSpan A_0, double A_1)
	{
		eth.k(this.Subject);
		int? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.l, null);
		if (primitivePropertyValue != null)
		{
			int? num = primitivePropertyValue;
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				this.Subject.y6()[ddq.m] = A_0 + TimeSpan.FromMilliseconds((double)primitivePropertyValue.Value);
				this.Subject.y6()[ddq.t] = false;
			}
		}
	}

	// Token: 0x0600190A RID: 6410 RVA: 0x00083280 File Offset: 0x00081480
	[CompilerGenerated]
	private bool h(TimeSpan A_0, double A_1)
	{
		return eth.j(this.Subject);
	}

	// Token: 0x0600190B RID: 6411 RVA: 0x00083290 File Offset: 0x00081490
	[CompilerGenerated]
	private bool g(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.aj, new bool?(false)).Value;
	}

	// Token: 0x0600190C RID: 6412 RVA: 0x000832C0 File Offset: 0x000814C0
	[CompilerGenerated]
	private ak1 f(TimeSpan A_0, double A_1)
	{
		return eth.i(this.Subject);
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x000832D0 File Offset: 0x000814D0
	[CompilerGenerated]
	private void e(TimeSpan A_0, double A_1)
	{
		eth.h(this.Subject);
	}

	// Token: 0x0600190E RID: 6414 RVA: 0x000832E0 File Offset: 0x000814E0
	[CompilerGenerated]
	private void d(TimeSpan A_0, double A_1)
	{
		eth.h(this.Subject);
	}

	// Token: 0x0600190F RID: 6415 RVA: 0x000832F0 File Offset: 0x000814F0
	[CompilerGenerated]
	private new ak1 c(TimeSpan A_0, double A_1)
	{
		return eth.i(this.Subject);
	}

	// Token: 0x06001910 RID: 6416 RVA: 0x00083300 File Offset: 0x00081500
	[CompilerGenerated]
	private void b(TimeSpan A_0, double A_1)
	{
		eth.h(this.Subject);
	}

	// Token: 0x06001911 RID: 6417 RVA: 0x00083310 File Offset: 0x00081510
	[CompilerGenerated]
	private void a(TimeSpan A_0, double A_1)
	{
		eth.h(this.Subject);
	}

	// Token: 0x0200042B RID: 1067
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001BED RID: 7149 RVA: 0x00098468 File Offset: 0x00096668
		internal float g(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00098470 File Offset: 0x00096670
		internal float b(bool A_0)
		{
			return 0.61f;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00098478 File Offset: 0x00096678
		internal float l(bool A_0)
		{
			return 0.58f;
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00098480 File Offset: 0x00096680
		internal float k(bool A_0)
		{
			return 1f;
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00098488 File Offset: 0x00096688
		internal float i(bool A_0)
		{
			return 0.75f;
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00098490 File Offset: 0x00096690
		internal float f(bool A_0)
		{
			return 0.74f;
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00098498 File Offset: 0x00096698
		internal float j(bool A_0)
		{
			return 0.73f;
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x000984A0 File Offset: 0x000966A0
		internal float n(bool A_0)
		{
			return 0.59f;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x000984A8 File Offset: 0x000966A8
		internal float m(bool A_0)
		{
			return 0.6f;
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000984B0 File Offset: 0x000966B0
		internal float o(bool A_0)
		{
			return 1f;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x000984B8 File Offset: 0x000966B8
		internal void a()
		{
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x000984BC File Offset: 0x000966BC
		internal float a(bool A_0)
		{
			return 0.5f;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x000984C4 File Offset: 0x000966C4
		internal float e(bool A_0)
		{
			return 0.4f;
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x000984CC File Offset: 0x000966CC
		internal float h(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x000984D4 File Offset: 0x000966D4
		internal float c(bool A_0)
		{
			return 1f;
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x000984DC File Offset: 0x000966DC
		internal bool a(TimeSpan A_0, double A_1)
		{
			return true;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x000984E0 File Offset: 0x000966E0
		internal float d(bool A_0)
		{
			return 0.5f;
		}

		// Token: 0x04000F76 RID: 3958
		public static readonly am2.a a = new am2.a();

		// Token: 0x04000F77 RID: 3959
		public static Func<bool, float> b;

		// Token: 0x04000F78 RID: 3960
		public static Func<bool, float> c;

		// Token: 0x04000F79 RID: 3961
		public static Func<bool, float> d;

		// Token: 0x04000F7A RID: 3962
		public static Func<bool, float> e;

		// Token: 0x04000F7B RID: 3963
		public static Func<bool, float> f;

		// Token: 0x04000F7C RID: 3964
		public static Func<bool, float> g;

		// Token: 0x04000F7D RID: 3965
		public static Func<bool, float> h;

		// Token: 0x04000F7E RID: 3966
		public static Func<bool, float> i;

		// Token: 0x04000F7F RID: 3967
		public static Func<bool, float> j;

		// Token: 0x04000F80 RID: 3968
		public static Func<bool, float> k;

		// Token: 0x04000F81 RID: 3969
		public static Action l;

		// Token: 0x04000F82 RID: 3970
		public static Func<bool, float> m;

		// Token: 0x04000F83 RID: 3971
		public static Func<bool, float> n;

		// Token: 0x04000F84 RID: 3972
		public static Func<bool, float> o;

		// Token: 0x04000F85 RID: 3973
		public static Func<bool, float> p;

		// Token: 0x04000F86 RID: 3974
		public static Func<TimeSpan, double, bool> q;

		// Token: 0x04000F87 RID: 3975
		public static Func<bool, float> r;
	}
}
