using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200041B RID: 1051
[fe("lu_sgsn_worker")]
public sealed class auh : b5g
{
	// Token: 0x06001B97 RID: 7063 RVA: 0x00096DFC File Offset: 0x00094FFC
	public auh(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("HitRocks", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(auh.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x00096E74 File Offset: 0x00095074
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().h.b == null || this.Subject.a8().h.b.aa().IsInCombat)
		{
			return false;
		}
		bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>("GuardLoc");
		if (classPropertyValue != null)
		{
			aud aud;
			Vector3 value;
			HorizontalDirection horizontalDirection;
			classPropertyValue.a(this.Subject.a8().Zone, out aud, out value, out horizontalDirection);
			return aud == this.Subject.a8().Area && value == this.Subject.a8().Location && horizontalDirection == this.Subject.a8().VisualDirection;
		}
		return false;
	}

	// Token: 0x06001B99 RID: 7065 RVA: 0x00096F48 File Offset: 0x00095148
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("WorkerNextSwing", null);
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | m7.b);
		if (primitivePropertyValue != null && primitivePropertyValue.Value > A_0)
		{
			awx.ad().Add(new bm3(500));
		}
		else
		{
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq(Guid.NewGuid().ToString(), "SledgehammerWoosh"), null, null, null);
			a4s.b(new ar7(this.Subject.a8()));
			list.Add(a4s);
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Attack1, cux.m, 0, null, 1));
			qy qy = new qy();
			qy.ad().Add(new bm3(320));
			List<auv> list2 = qy.ad();
			a4s a4s2 = new a4s(new bfq(Guid.NewGuid().ToString(), "RockHitHeavy"), null, null, null);
			a4s2.b(new ar7(this.Subject.a8()));
			list2.Add(a4s2);
			qy.ad().Add(new au0(this.Subject.a8().Area, this.Subject.a8().Location + new Vector3(0f, -1f, 0.5f), "RockChipImpact", 1, double.MaxValue, null, null, null));
			this.Subject.a8().Zone.ActionManager.g9(qy, atp.a);
			this.Subject.y6()["WorkerNextSwing"] = A_0 + TimeSpan.FromSeconds(1.5 + cuo.a.NextDouble() * 1.5);
		}
		return awx;
	}

	// Token: 0x0200041C RID: 1052
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B9C RID: 7068 RVA: 0x00097190 File Offset: 0x00095390
		internal float a(bool A_0)
		{
			return 1.1f;
		}

		// Token: 0x04000F4A RID: 3914
		public static readonly auh.a a = new auh.a();

		// Token: 0x04000F4B RID: 3915
		public static Func<bool, float> b;
	}
}
