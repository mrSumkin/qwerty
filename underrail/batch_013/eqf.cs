using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000401 RID: 1025
[fe("dog")]
public sealed class eqf : ua
{
	// Token: 0x06001B27 RID: 6951 RVA: 0x00093E30 File Offset: 0x00092030
	public eqf(bm6 A_0) : base("RathoundBehavior", A_0)
	{
		List<c96> list = new List<c96>();
		List<c96> list2 = list;
		string a_ = "CombatNearEnemies";
		List<c96> list3 = new List<c96>();
		list3.Add(new b64("InstantStandUp", new Func<TimeSpan, double, bool>(this.v), new Func<TimeSpan, double, ej1>(this.u), new Func<bool, float>(eqf.a.a.g), null));
		list3.Add(new e8n("FocusPrimaryTarget", new List<c96>
		{
			new cta("AutoAttackCurrentTarget"),
			new rv("GiveUpOnTarget", 180, 300000)
		}));
		list3.Add(new chi("ChangeTargetActivity"));
		list2.Add(new efs(a_, list3));
		list.Add(new byh("Init dialog", new Func<TimeSpan, double, bool>(this.t), new Func<TimeSpan, double, cst>(this.s), new Func<bool, float>(eqf.a.a.k), null)
		{
			e = false
		});
		List<c96> list4 = list;
		string a_2 = "FulfillNoiseBackupRequest";
		Func<TimeSpan, double, bool> a_3 = new Func<TimeSpan, double, bool>(this.r);
		Func<bool, float> a_4 = new Func<bool, float>(eqf.a.a.e);
		List<c96> list5 = new List<c96>();
		list5.Add(new b64("ChangeBackupLocation", new Func<TimeSpan, double, bool>(this.q), new Func<TimeSpan, double, ej1>(this.p), new Func<bool, float>(eqf.a.a.a), null));
		list5.Add(new ere("RangedBackup", new Func<TimeSpan, double, bool>(this.o), new Func<bool, float>(eqf.a.a.f), new List<c96>
		{
			new ceq("TrekToBackupLoc", new Func<TimeSpan, double, ak1>(this.n))
			{
				f = dnw.c,
				c = 5,
				d = 1000,
				b = double.MaxValue,
				c = new Action<TimeSpan, double>(this.m),
				b = new Action<TimeSpan, double>(this.l),
				e = 3000
			}
		}));
		list5.Add(new ere("MeleeBackup", new Func<TimeSpan, double, bool>(eqf.a.a.a), new Func<bool, float>(eqf.a.a.j), new List<c96>
		{
			new ceq("TrekToBackupLoc", new Func<TimeSpan, double, ak1>(this.k))
			{
				f = dnw.b,
				c = 5,
				d = 1000,
				b = double.MaxValue,
				c = new Action<TimeSpan, double>(this.j),
				b = new Action<TimeSpan, double>(this.i),
				e = 3000
			}
		}));
		list4.Add(new ere(a_2, a_3, a_4, list5));
		list.Add(new b64("ReactToBeingAlertedToPlayerStealthing", new Func<TimeSpan, double, bool>(this.h), new Func<TimeSpan, double, ej1>(this.g), new Func<bool, float>(eqf.a.a.c), null));
		List<c96> list6 = list;
		string a_5 = "Standing";
		Func<TimeSpan, double, bool> a_6 = new Func<TimeSpan, double, bool>(this.f);
		Func<bool, float> a_7 = new Func<bool, float>(eqf.a.a.h);
		c96[] array = new c96[2];
		array[0] = new e1y("IdleMovement", new List<c96>
		{
			new e7y("IdleMoveToTile")
			{
				c = 0.75f,
				b = 5,
				c = 3
			},
			new aif("RestActivity")
		})
		{
			c = 0.75f
		};
		array[1] = new byh("Sit-or-Bark", new Func<TimeSpan, double, bool>(this.e), new Func<TimeSpan, double, cst>(this.d), new Func<bool, float>(eqf.a.a.b), null)
		{
			f = false
		};
		list6.Add(new ere(a_5, a_6, a_7, array));
		List<c96> list7 = list;
		string a_8 = "Sitting";
		Func<TimeSpan, double, bool> a_9 = new Func<TimeSpan, double, bool>(this.c);
		Func<bool, float> a_10 = new Func<bool, float>(eqf.a.a.d);
		c96[] array2 = new c96[1];
		array2[0] = new byh("Stand-or-Scratch", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(eqf.a.a.i), null)
		{
			f = false
		};
		list7.Add(new ere(a_8, a_9, a_10, array2));
		list.Add(new aif("RestActivity"));
		base.a(list);
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x00094340 File Offset: 0x00092540
	[CompilerGenerated]
	private bool v(TimeSpan A_0, double A_1)
	{
		return this.Subject.a8().h.b.ap.GetValueOrDefault() == CharacterState.Custom3;
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x00094368 File Offset: 0x00092568
	[CompilerGenerated]
	private ej1 u(TimeSpan A_0, double A_1)
	{
		this.Subject.a8().h.b.ap = null;
		this.Subject.a8().h.b.aq = null;
		return ej1.b;
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x000943B8 File Offset: 0x000925B8
	[CompilerGenerated]
	private bool t(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		string classPropertyValue = this.Subject.y6().GetClassPropertyValue<string>(ddq.bc);
		bool value = this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.be, new bool?(false)).Value;
		string classPropertyValue2 = this.Subject.y6().GetClassPropertyValue<string>(ddq.bf);
		if (!string.IsNullOrEmpty(classPropertyValue) && !base.h().aa().IsInCombat && this.Subject.a8().GetAspect<j7>() != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			double value2 = this.Subject.y6().GetPrimitivePropertyValue<double>(ddq.bd, new double?((double)5)).Value;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= value2 && (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(classPropertyValue, new bool?(false)).Value || value))
			{
				if (!string.IsNullOrEmpty(classPropertyValue2))
				{
					TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>(classPropertyValue2, null);
					if (primitivePropertyValue != null && primitivePropertyValue.Value > serviceOrThrow.aqu().o())
					{
						return false;
					}
				}
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x000945D8 File Offset: 0x000927D8
	[CompilerGenerated]
	private cst s(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			j7 aspect = (serviceOrThrow.aqu().v().b() as c5x).GetAspect<j7>();
			j7 aspect2 = this.Subject.a8().GetAspect<j7>();
			if (aspect2 != null && aspect != null)
			{
				this.Subject.a8().h.b.ap = null;
				this.Subject.a8().h.b.aq = null;
				return aspect2.a(aspect, true, null, false);
			}
		}
		return null;
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x000946A0 File Offset: 0x000928A0
	[CompilerGenerated]
	private bool r(TimeSpan A_0, double A_1)
	{
		return eth.f(this.Subject) != null || eth.g(this.Subject) != null;
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x000946C8 File Offset: 0x000928C8
	[CompilerGenerated]
	private bool q(TimeSpan A_0, double A_1)
	{
		ak1 ak = eth.g(this.Subject);
		ak1 ak2 = eth.f(this.Subject);
		return ak2 != null && ak != ak2;
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x00094700 File Offset: 0x00092900
	[CompilerGenerated]
	private ej1 p(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[ddq.am] = this.Subject.y6()[ddq.an];
		this.Subject.y6().RemoveProperty(ddq.an);
		return ej1.b;
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x00094750 File Offset: 0x00092950
	[CompilerGenerated]
	private bool o(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.aj, new bool?(false)).Value;
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x00094780 File Offset: 0x00092980
	[CompilerGenerated]
	private ak1 n(TimeSpan A_0, double A_1)
	{
		return eth.g(this.Subject);
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x00094790 File Offset: 0x00092990
	[CompilerGenerated]
	private void m(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x000947A0 File Offset: 0x000929A0
	[CompilerGenerated]
	private void l(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x000947B0 File Offset: 0x000929B0
	[CompilerGenerated]
	private ak1 k(TimeSpan A_0, double A_1)
	{
		return eth.g(this.Subject);
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x000947C0 File Offset: 0x000929C0
	[CompilerGenerated]
	private void j(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x000947D0 File Offset: 0x000929D0
	[CompilerGenerated]
	private void i(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x000947E0 File Offset: 0x000929E0
	[CompilerGenerated]
	private bool h(TimeSpan A_0, double A_1)
	{
		if (ew0.b())
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && base.h().a(c5x.h.b) == global::h.a)
				{
					erl erl = new bzv(this.Subject.y6()).d(c5x.qe());
					if (erl != null && erl.f() == cem.c)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x000948A8 File Offset: 0x00092AA8
	[CompilerGenerated]
	private ej1 g(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null && c5x.h.b != null)
			{
				this.Subject.a8().h.b.ap = null;
				this.Subject.a8().h.b.aq = null;
				this.Subject.y6().RemoveProperty("DogState");
				bt4 value = new bt4(c5x.Area.y8(), c5x.Location);
				this.Subject.y6()[ddq.an] = value;
			}
		}
		return ej1.b;
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x000949A8 File Offset: 0x00092BA8
	[CompilerGenerated]
	private bool f(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetClassPropertyValue<string>("DogState") != "sit";
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x000949CC File Offset: 0x00092BCC
	[CompilerGenerated]
	private bool e(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("NextDogStateChangeTime", null);
		if (primitivePropertyValue == null)
		{
			this.Subject.y6()["NextDogStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
			return false;
		}
		return primitivePropertyValue.Value <= A_0;
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x00094A50 File Offset: 0x00092C50
	[CompilerGenerated]
	private cst d(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()["NextDogStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | m7.b);
		if (cuo.a.NextDouble() < 0.3)
		{
			int num = 3 + cuo.a.Next(3);
			for (int i = 0; i < num; i++)
			{
				awx.ad().Add(new a4s(new bfq("bark", "DogBark"), null, new ar7(this.Subject.a8()), null));
				awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom1, 100, 0, null, 1));
			}
		}
		else
		{
			this.Subject.y6()["DogState"] = "sit";
			this.Subject.a8().h.b.ap = new CharacterState?(CharacterState.Custom3);
			this.Subject.a8().h.b.aq = new int?(5);
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom3, 100, 0, null, 1));
		}
		return awx;
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x00094BD4 File Offset: 0x00092DD4
	[CompilerGenerated]
	private new bool c(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetClassPropertyValue<string>("DogState") == "sit";
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x00094BF8 File Offset: 0x00092DF8
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (this.Subject.y6().GetPrimitivePropertyValue<bool>("DogForceStand", new bool?(false)).Value)
		{
			return true;
		}
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("NextDogStateChangeTime", null);
		if (primitivePropertyValue == null)
		{
			this.Subject.y6()["NextDogStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
			return false;
		}
		return primitivePropertyValue.Value <= A_0;
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x00094CA4 File Offset: 0x00092EA4
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()["NextDogStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
		awx awx = new awx();
		if (!this.Subject.y6().GetPrimitivePropertyValue<bool>("DogForceStand", new bool?(false)).Value && cuo.a.NextDouble() < 0.7)
		{
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom2, 100, 0, null, 1));
		}
		else
		{
			this.Subject.y6()["DogState"] = "stand";
			this.Subject.y6()["InheritNextIdleMoveTime"] = true;
			this.Subject.y6()["NextIdleMoveTime"] = A_0;
			this.Subject.a8().h.b.ap = null;
			this.Subject.a8().h.b.aq = null;
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom4, 100, 0, null, 1));
		}
		this.Subject.y6()["DogForceStand"] = null;
		return awx;
	}

	// Token: 0x02000402 RID: 1026
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B40 RID: 6976 RVA: 0x00094E54 File Offset: 0x00093054
		internal float g(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00094E5C File Offset: 0x0009305C
		internal float k(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00094E64 File Offset: 0x00093064
		internal float e(bool A_0)
		{
			return 0.65f;
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00094E6C File Offset: 0x0009306C
		internal float a(bool A_0)
		{
			return 2f;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00094E74 File Offset: 0x00093074
		internal float f(bool A_0)
		{
			return 1f;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00094E7C File Offset: 0x0009307C
		internal bool a(TimeSpan A_0, double A_1)
		{
			return true;
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00094E80 File Offset: 0x00093080
		internal float j(bool A_0)
		{
			return 0.5f;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00094E88 File Offset: 0x00093088
		internal float c(bool A_0)
		{
			return 0.64f;
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00094E90 File Offset: 0x00093090
		internal float h(bool A_0)
		{
			return 0.6f;
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00094E98 File Offset: 0x00093098
		internal float b(bool A_0)
		{
			if (!A_0)
			{
				return 1f;
			}
			return 100f;
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00094EAC File Offset: 0x000930AC
		internal float d(bool A_0)
		{
			return 0.6f;
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00094EB4 File Offset: 0x000930B4
		internal float i(bool A_0)
		{
			if (!A_0)
			{
				return 1f;
			}
			return 100f;
		}

		// Token: 0x04000F20 RID: 3872
		public static readonly eqf.a a = new eqf.a();

		// Token: 0x04000F21 RID: 3873
		public static Func<bool, float> b;

		// Token: 0x04000F22 RID: 3874
		public static Func<bool, float> c;

		// Token: 0x04000F23 RID: 3875
		public static Func<bool, float> d;

		// Token: 0x04000F24 RID: 3876
		public static Func<bool, float> e;

		// Token: 0x04000F25 RID: 3877
		public static Func<bool, float> f;

		// Token: 0x04000F26 RID: 3878
		public static Func<TimeSpan, double, bool> g;

		// Token: 0x04000F27 RID: 3879
		public static Func<bool, float> h;

		// Token: 0x04000F28 RID: 3880
		public static Func<bool, float> i;

		// Token: 0x04000F29 RID: 3881
		public static Func<bool, float> j;

		// Token: 0x04000F2A RID: 3882
		public static Func<bool, float> k;

		// Token: 0x04000F2B RID: 3883
		public static Func<bool, float> l;

		// Token: 0x04000F2C RID: 3884
		public static Func<bool, float> m;
	}
}
