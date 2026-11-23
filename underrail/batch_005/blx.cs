using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000448 RID: 1096
[fe("butchers")]
public sealed class blx : b5g
{
	// Token: 0x06001C80 RID: 7296 RVA: 0x0009B7DC File Offset: 0x000999DC
	public blx(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("Butcher", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(blx.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001C81 RID: 7297 RVA: 0x0009B854 File Offset: 0x00099A54
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

	// Token: 0x06001C82 RID: 7298 RVA: 0x0009B928 File Offset: 0x00099B28
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
			this.Subject.y6()["nextHack"] = A_0 + TimeSpan.FromSeconds((double)cuo.a.Next(4));
		}
		return awx;
	}

	// Token: 0x02000449 RID: 1097
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C85 RID: 7301 RVA: 0x0009BA98 File Offset: 0x00099C98
		internal float a(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x04000FC9 RID: 4041
		public static readonly blx.a a = new blx.a();

		// Token: 0x04000FCA RID: 4042
		public static Func<bool, float> b;
	}
}
