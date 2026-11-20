using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003F5 RID: 1013
[fe("jy_abramsMessenger")]
public sealed class eqi : b5g
{
	// Token: 0x06001AFE RID: 6910 RVA: 0x00092AB0 File Offset: 0x00090CB0
	public eqi(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(eqi.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x00092B30 File Offset: 0x00090D30
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 5.0)
			{
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jyambramsmessenger_saidToMeetAtBar", new bool?(false)).Value ? 1 : 0;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("area_jyembassy_visited", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_abram_dead", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_abram_startedBusinessTalks", new bool?(false)).Value;
				if (value == 0 && value2 && !value3 && !value4)
				{
					blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
					return blk != null && blk.b() && blk.f() > global::h.a;
				}
			}
		}
		return false;
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x00092CEC File Offset: 0x00090EEC
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
				return aspect2.a(aspect, true, null, false);
			}
		}
		return null;
	}

	// Token: 0x020003F6 RID: 1014
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B03 RID: 6915 RVA: 0x00092DA4 File Offset: 0x00090FA4
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F11 RID: 3857
		public static readonly eqi.a a = new eqi.a();

		// Token: 0x04000F12 RID: 3858
		public static Func<bool, float> b;
	}
}
