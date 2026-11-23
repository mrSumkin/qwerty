using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000405 RID: 1029
[fe("jy_lennyTheCook")]
public sealed class c39 : b5g
{
	// Token: 0x06001B52 RID: 6994 RVA: 0x00095028 File Offset: 0x00093228
	public c39(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("OperateLock", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(c39.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001B53 RID: 6995 RVA: 0x000950A0 File Offset: 0x000932A0
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().h.b.aa().IsInControl && !this.Subject.a8().h.b.aa().IsInCombat && aw1.a(this.Subject.a8(), new bt4("5267404a-03e8-4f0f-9d76-65fe143794c5"), true) && bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("npc_jylenny_nextHack", null);
			return primitivePropertyValue == null || primitivePropertyValue.Value <= A_0;
		}
		return false;
	}

	// Token: 0x06001B54 RID: 6996 RVA: 0x00095160 File Offset: 0x00093360
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		int num = cuo.a.Next(2);
		string[] array = new string[]
		{
			"FleshStab2",
			"Rend"
		};
		awx awx = new awx();
		awx.a(awx.kh() | m7.b);
		List<auv> list = awx.ad();
		bfq bfq = new bfq(Guid.NewGuid().ToString(), "KnifeWhoosh");
		bfq.a(0.2f);
		list.Add(new a4s(bfq, null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new e4t(this.Subject.a8().h.b, (num == 0) ? CharacterState.Attack1 : CharacterState.Attack2, cux.m, 0, null, 1));
		List<auv> list2 = awx.ad();
		bfq bfq2 = new bfq(Guid.NewGuid().ToString(), array[num]);
		bfq2.a(0.2f);
		list2.Add(new a4s(bfq2, null, new ar7(this.Subject.a8()), null));
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			this.Subject.y6()["npc_jylenny_nextHack"] = A_0 + TimeSpan.FromSeconds((double)(cuo.a.Next(4) + 4));
		}
		return awx;
	}

	// Token: 0x02000406 RID: 1030
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B57 RID: 6999 RVA: 0x000952D4 File Offset: 0x000934D4
		internal float a(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x04000F2F RID: 3887
		public static readonly c39.a a = new c39.a();

		// Token: 0x04000F30 RID: 3888
		public static Func<bool, float> b;
	}
}
