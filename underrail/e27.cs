using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000444 RID: 1092
[fe("rathoundEating")]
public sealed class e27 : b5g
{
	// Token: 0x06001C73 RID: 7283 RVA: 0x0009AF10 File Offset: 0x00099110
	public e27(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("Rathound", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(e27.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001C74 RID: 7284 RVA: 0x0009AF88 File Offset: 0x00099188
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
		if (classPropertyValue != null && this.Subject.a8().h.b.aa().IsInControl && !this.Subject.a8().h.b.aa().IsInCombat && aw1.a(this.Subject.a8(), classPropertyValue, true) && bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("nextBite", null);
			return primitivePropertyValue == null || primitivePropertyValue.Value <= A_0;
		}
		return false;
	}

	// Token: 0x06001C75 RID: 7285 RVA: 0x0009B05C File Offset: 0x0009925C
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		string[] array = new string[]
		{
			"Rend",
			"CarcassOpen"
		};
		int num = cuo.a.Next(0, 2);
		awx awx = new awx();
		awx.a(awx.kh() | m7.b);
		awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Attack1, cux.m, 0, null, 1));
		List<auv> list = awx.ad();
		bfq bfq = new bfq(Guid.NewGuid().ToString(), array[num]);
		bfq.a(0.2f);
		list.Add(new a4s(bfq, null, new ar7(this.Subject.a8()), null));
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			this.Subject.y6()["nextBite"] = A_0 + TimeSpan.FromSeconds((double)cuo.a.Next(2, 5));
		}
		return awx;
	}

	// Token: 0x02000445 RID: 1093
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C78 RID: 7288 RVA: 0x0009B178 File Offset: 0x00099378
		internal float a(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x04000FC5 RID: 4037
		public static readonly e27.a a = new e27.a();

		// Token: 0x04000FC6 RID: 4038
		public static Func<bool, float> b;
	}
}
