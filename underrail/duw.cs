using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200040F RID: 1039
[fe("jy_elwood")]
public sealed class duw : b5g
{
	// Token: 0x06001B73 RID: 7027 RVA: 0x00095DC4 File Offset: 0x00093FC4
	public duw(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new b64("Roam", new Func<TimeSpan, double, bool>(duw.a.a.a), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(duw.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x00095E54 File Offset: 0x00094054
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string text = null;
			bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
			if (classPropertyValue != null)
			{
				text = classPropertyValue.b();
			}
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jyelwood_waitToReturnInside", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jyelwood_returnToGambling", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["npc_jyelwood_returnToGambling"] = true;
			}
			if (text == null || text == "elwood1")
			{
				this.Subject.y6()[ddq.ay] = new bt4("elwood2");
				serviceOrThrow.aqu().r()["npc_jyelwood_nextRotation"] = A_0 + TimeSpan.FromSeconds(45.0);
			}
			else if (text == "elwood3" && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jyelwood_returnToGambling", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["npc_jyelwood_nextRotation"] = A_0 + TimeSpan.FromSeconds(120.0);
				serviceOrThrow.aqu().r()["npc_jyelwood_waitToReturnInside"] = true;
			}
			else
			{
				this.Subject.y6()[ddq.ay] = new bt4("elwood1");
				serviceOrThrow.aqu().r()["npc_jyelwood_nextRotation"] = A_0 + TimeSpan.FromSeconds(45.0);
			}
		}
		return ej1.b;
	}

	// Token: 0x02000410 RID: 1040
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B77 RID: 7031 RVA: 0x00096058 File Offset: 0x00094258
		internal bool a(TimeSpan A_0, double A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("npc_jyelwood_nextRotation", null);
				return primitivePropertyValue == null || primitivePropertyValue.Value <= A_0;
			}
			return false;
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x000960B4 File Offset: 0x000942B4
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F3D RID: 3901
		public static readonly duw.a a = new duw.a();

		// Token: 0x04000F3E RID: 3902
		public static Func<TimeSpan, double, bool> b;

		// Token: 0x04000F3F RID: 3903
		public static Func<bool, float> c;
	}
}
