using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000442 RID: 1090
[fe("rockDiggers")]
public sealed class bb5 : b5g
{
	// Token: 0x06001C6D RID: 7277 RVA: 0x0009ABF0 File Offset: 0x00098DF0
	public bb5(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("RockDigger", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(bb5.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001C6E RID: 7278 RVA: 0x0009AC68 File Offset: 0x00098E68
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
		if (classPropertyValue != null && this.Subject.a8().h.b.aa().IsInControl && !this.Subject.a8().h.b.aa().IsInCombat && aw1.a(this.Subject.a8(), classPropertyValue, true) && bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("nextHack", null);
			return primitivePropertyValue == null || primitivePropertyValue.Value <= A_0;
		}
		return false;
	}

	// Token: 0x06001C6F RID: 7279 RVA: 0x0009AD3C File Offset: 0x00098F3C
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		int num = cuo.a.Next(2);
		string[] array = new string[]
		{
			"RockCrash",
			"RockHitHeavy"
		};
		awx awx = new awx();
		awx.a(awx.kh() | m7.b);
		List<auv> list = awx.ad();
		bfq bfq = new bfq(Guid.NewGuid().ToString(), "SledgehammerWoosh");
		bfq.a(0.2f);
		list.Add(new a4s(bfq, null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new e4t(this.Subject.a8().h.b, (num == 0) ? CharacterState.Attack1 : CharacterState.Attack2, 65, 0, new int?(3), 1));
		List<auv> list2 = awx.ad();
		bfq bfq2 = new bfq(Guid.NewGuid().ToString(), array[num]);
		bfq2.a(0.2f);
		list2.Add(new a4s(bfq2, null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new e4t(this.Subject.a8().h.b, (num == 0) ? CharacterState.Attack1 : CharacterState.Attack2, 65, 4, null, 1));
		awx.ad().Add(new bm3(dz6.b(1000)));
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			this.Subject.y6()["nextHack"] = A_0 + TimeSpan.FromSeconds((double)(1 + cuo.a.Next(3)));
		}
		return awx;
	}

	// Token: 0x02000443 RID: 1091
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C72 RID: 7282 RVA: 0x0009AF04 File Offset: 0x00099104
		internal float a(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x04000FC3 RID: 4035
		public static readonly bb5.a a = new bb5.a();

		// Token: 0x04000FC4 RID: 4036
		public static Func<bool, float> b;
	}
}
