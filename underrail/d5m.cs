using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003F3 RID: 1011
[fe("jy_abramsMessenger2")]
public sealed class d5m : b5g
{
	// Token: 0x06001AF8 RID: 6904 RVA: 0x00092720 File Offset: 0x00090920
	public d5m(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(d5m.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x000927A0 File Offset: 0x000909A0
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 5.0)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("quest_jypetDelivery_petDeliveryTime", null);
				if (primitivePropertyValue != null && serviceOrThrow.aqu().p() >= primitivePropertyValue.Value + TimeSpan.FromHours(1.0))
				{
					int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jyambramsmessenger2_talkedToPlayer", new bool?(false)).Value ? 1 : 0;
					bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_jypetDelivery_petDeliveredSafely", new bool?(false)).Value;
					bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_abram_dead", new bool?(false)).Value;
					bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_maura_dead", new bool?(false)).Value;
					bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_abram_startedRescueMissionTalk", new bool?(false)).Value;
					if (value == 0 && value2 && !value3 && !value5 && !value4)
					{
						blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
						return blk != null && blk.b() && blk.f() > global::h.a;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x000929EC File Offset: 0x00090BEC
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			j7 aspect = (serviceOrThrow.aqu().v().b() as c5x).GetAspect<j7>();
			j7 aspect2 = this.Subject.a8().GetAspect<j7>();
			if (aspect2 != null && aspect != null)
			{
				return aspect2.a(aspect, false, "support\\jy_abramsMessenger2", false);
			}
		}
		return null;
	}

	// Token: 0x020003F4 RID: 1012
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001AFD RID: 6909 RVA: 0x00092AA8 File Offset: 0x00090CA8
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F0F RID: 3855
		public static readonly d5m.a a = new d5m.a();

		// Token: 0x04000F10 RID: 3856
		public static Func<bool, float> b;
	}
}
