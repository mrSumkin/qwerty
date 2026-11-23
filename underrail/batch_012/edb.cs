using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003E5 RID: 997
[fe("rc_buzzer")]
public sealed class edb : b5g
{
	// Token: 0x06001ABB RID: 6843 RVA: 0x00090840 File Offset: 0x0008EA40
	public edb(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new b64("ReactToBeingFreed", new Func<TimeSpan, double, bool>(this.f), new Func<TimeSpan, double, ej1>(this.e), new Func<bool, float>(edb.a.a.b), null));
		list.Add(new b64("WhisperPlayerToTurnOnTurrets", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, ej1>(this.c), new Func<bool, float>(edb.a.a.a), null));
		list.Add(new b64("ВыпустиМеня!", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(edb.a.a.c), null));
		base.a(a_, list);
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x00090950 File Offset: 0x0008EB50
	[CompilerGenerated]
	private bool f(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_rcshop_buzzerFreed", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rcbuzzer_reactedToBeingFreed", new bool?(false)).Value;
			return value && !value2;
		}
		return false;
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x00090A04 File Offset: 0x0008EC04
	[CompilerGenerated]
	private ej1 e(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rcmindreader_dead", new bool?(false)).Value;
		bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rcmindreader_removed", new bool?(false)).Value;
		h h = base.h().aa().a(serviceOrThrow.aqu().ac(), asp.a);
		if (h != global::h.a)
		{
			c0s aspect = this.Subject.a8().GetAspect<c0s>();
			if (aspect != null)
			{
				if (value || value2)
				{
					aspect.a("Спасибо. Я думал, мне конец.", true, null, null);
				}
				else
				{
					aspect.a("Быстрее, надо навалиться на него, пока он нам мозги не зажарил.", true, null, null);
				}
			}
		}
		this.Subject.y6()[ddq.ay] = new bt4("buzzer2");
		base.h().aa().FactionId = asp.co;
		base.h().aa().HostilityBroadcastMode = c2n.c;
		eaq eaq = new eaq();
		eaq.b(asp.cf);
		eaq.a(asp.a);
		eaq.a(global::h.a);
		eaq.a(true);
		eaq.ym(null, null, null);
		if (h != global::h.a)
		{
			eaq eaq2 = new eaq();
			eaq2.b(asp.co);
			eaq2.a(asp.a);
			eaq2.a(global::h.e);
			eaq2.a(true);
			eaq2.ym(null, null, null);
		}
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["npc_rcbuzzer_reactedToBeingFreed"] = true;
		}
		return ej1.b;
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x00090BC4 File Offset: 0x0008EDC4
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 5.0)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rcmindreader_dead", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rcmindreader_removed", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_rcshop_buzzerFreed", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bp5.f("rc_buzzerTurrets"), new bool?(false)).Value;
				TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("silentUntil", null);
				if ((primitivePropertyValue == null || primitivePropertyValue.Value < A_0) && !value && !value2 && !value4 && !value3)
				{
					blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
					return blk != null && blk.b() && blk.f() > global::h.a;
				}
			}
		}
		return false;
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x00090DCC File Offset: 0x0008EFCC
	[CompilerGenerated]
	private new ej1 c(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()["silentUntil"] = A_0 + TimeSpan.FromSeconds(20.0);
		c0s aspect = this.Subject.a8().GetAspect<c0s>();
		if (aspect != null)
		{
			aspect.a("::Он шепчет.:: Эй... там переключатель, который включает турели. Он за прилавком, на другом конце комнаты.", true, null, null);
		}
		return ej1.b;
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x00090E40 File Offset: 0x0008F040
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 5.0)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rcmindreader_dead", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rcmindreader_removed", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_rcshop_buzzerFreed", new bool?(false)).Value;
				TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("silentUntil", null);
				if ((primitivePropertyValue == null || primitivePropertyValue.Value < A_0) && (value || value2) && !value3)
				{
					blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
					return blk != null && blk.b() && blk.f() > global::h.a;
				}
			}
		}
		return false;
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x00091010 File Offset: 0x0008F210
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()["silentUntil"] = A_0 + TimeSpan.FromSeconds(20.0);
		c0s aspect = this.Subject.a8().GetAspect<c0s>();
		if (aspect != null)
		{
			aspect.a("Эй, выпустите меня отсюда, пожалуйста. У этого урода-телепата есть ключ.", true, null, null);
		}
		return ej1.b;
	}

	// Token: 0x020003E6 RID: 998
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001AC4 RID: 6852 RVA: 0x00091098 File Offset: 0x0008F298
		internal float b(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x000910A0 File Offset: 0x0008F2A0
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x000910A8 File Offset: 0x0008F2A8
		internal float c(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000EF7 RID: 3831
		public static readonly edb.a a = new edb.a();

		// Token: 0x04000EF8 RID: 3832
		public static Func<bool, float> b;

		// Token: 0x04000EF9 RID: 3833
		public static Func<bool, float> c;

		// Token: 0x04000EFA RID: 3834
		public static Func<bool, float> d;
	}
}
