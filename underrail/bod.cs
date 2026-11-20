using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200040B RID: 1035
[fe("jy_gamblingHouseBarman")]
public sealed class bod : b5g
{
	// Token: 0x06001B67 RID: 7015 RVA: 0x00095A0C File Offset: 0x00093C0C
	public bod(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new b64("Roam", new Func<TimeSpan, double, bool>(bod.a.a.a), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(bod.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001B68 RID: 7016 RVA: 0x00095A9C File Offset: 0x00093C9C
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
			if (text == null || text == "barman2")
			{
				this.Subject.y6()[ddq.ay] = new bt4("barman1");
			}
			else
			{
				this.Subject.y6()[ddq.ay] = new bt4("barman2");
			}
			serviceOrThrow.aqu().r()["npc_jy8barman_nextRotation"] = A_0 + TimeSpan.FromSeconds(60.0);
		}
		return ej1.b;
	}

	// Token: 0x0200040C RID: 1036
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B6B RID: 7019 RVA: 0x00095B80 File Offset: 0x00093D80
		internal bool a(TimeSpan A_0, double A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("npc_jy8barman_nextRotation", null);
				return primitivePropertyValue == null || primitivePropertyValue.Value <= A_0;
			}
			return false;
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x00095BDC File Offset: 0x00093DDC
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F37 RID: 3895
		public static readonly bod.a a = new bod.a();

		// Token: 0x04000F38 RID: 3896
		public static Func<TimeSpan, double, bool> b;

		// Token: 0x04000F39 RID: 3897
		public static Func<bool, float> c;
	}
}
