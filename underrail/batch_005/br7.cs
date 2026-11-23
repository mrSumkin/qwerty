using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000392 RID: 914
[fe("up_lunaticStairmaker")]
public sealed class br7 : b5g
{
	// Token: 0x06001945 RID: 6469 RVA: 0x00084AA0 File Offset: 0x00082CA0
	public br7(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("HitRocks", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(br7.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x00084B18 File Offset: 0x00082D18
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

	// Token: 0x06001947 RID: 6471 RVA: 0x00084BEC File Offset: 0x00082DEC
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("NextPsiInvocation", null);
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | m7.b);
		if (primitivePropertyValue != null && primitivePropertyValue.Value > A_0)
		{
			awx.ad().Add(new bm3(500));
		}
		else
		{
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.CastingPsi, cux.c, 0, null, 3));
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.FinishPsi, cux.j, 0, null, 1));
			List<Vector3> list = new List<Vector3>
			{
				new Vector3(3.5f, 10.8f, 0.5f),
				new Vector3(3.8f, 10.3f, 0.5f),
				new Vector3(4.1f, 11.4f, 0.5f)
			};
			Vector3 a_ = list[cuo.a.Next(0, list.Count)];
			qy qy = new qy();
			qy.ad().Add(new a6c(this.Subject.a8().Location + new Vector3(-0.5f, -0.5f, 0.5f), a_, this.Subject.a8().Area, "Psi", null));
			qy.ad().Add(new bm3(200));
			List<auv> list2 = qy.ad();
			a4s a4s = new a4s(new bfq(Guid.NewGuid().ToString(), "TelekineticPunchHit"), null, null, null);
			a4s.b(new ar7(this.Subject.a8()));
			list2.Add(a4s);
			qy.ad().Add(new au0(this.Subject.a8().Area, a_, "Psi", 1, double.MaxValue, null, null, null));
			awx.ad().Add(new ez4(new a55(this.Subject.a8().Zone), qy, atp.a));
			this.Subject.y6()["NextPsiInvocation"] = A_0 + TimeSpan.FromSeconds(3.0 + cuo.a.NextDouble() * 2.0);
		}
		return awx;
	}

	// Token: 0x02000394 RID: 916
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001962 RID: 6498 RVA: 0x00085E48 File Offset: 0x00084048
		internal float a(bool A_0)
		{
			return 1.1f;
		}

		// Token: 0x04000E7D RID: 3709
		public static readonly br7.a a = new br7.a();

		// Token: 0x04000E7E RID: 3710
		public static Func<bool, float> b;
	}
}
