using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000419 RID: 1049
[fe("lu_sgsn_psionic")]
public sealed class b9b : b5g
{
	// Token: 0x06001B91 RID: 7057 RVA: 0x00096998 File Offset: 0x00094B98
	public b9b(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("HitRocks", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(b9b.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001B92 RID: 7058 RVA: 0x00096A10 File Offset: 0x00094C10
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

	// Token: 0x06001B93 RID: 7059 RVA: 0x00096AE4 File Offset: 0x00094CE4
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
			foreach (Vector3 a_ in new List<Vector3>
			{
				new Vector3(3f, 2f, 0.7f),
				new Vector3(5f, 2f, 0.7f),
				new Vector3(6f, 1f, 1.5f)
			})
			{
				qy qy = new qy();
				qy.ad().Add(new a6c(this.Subject.a8().Location + new Vector3(-0.5f, -0.5f, 0.5f), a_, this.Subject.a8().Area, "Psi", null));
				qy.ad().Add(new bm3(200));
				List<auv> list = qy.ad();
				a4s a4s = new a4s(new bfq(Guid.NewGuid().ToString(), "TelekineticPunchHit"), null, null, null);
				a4s.b(new ar7(this.Subject.a8()));
				list.Add(a4s);
				qy.ad().Add(new au0(this.Subject.a8().Area, a_, "Psi", 1, double.MaxValue, null, null, null));
				awx.ad().Add(new ez4(new a55(this.Subject.a8().Zone), qy, atp.a));
			}
			this.Subject.y6()["NextPsiInvocation"] = A_0 + TimeSpan.FromSeconds(3.0 + cuo.a.NextDouble() * 2.0);
		}
		return awx;
	}

	// Token: 0x0200041A RID: 1050
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B96 RID: 7062 RVA: 0x00096DF4 File Offset: 0x00094FF4
		internal float a(bool A_0)
		{
			return 1.1f;
		}

		// Token: 0x04000F48 RID: 3912
		public static readonly b9b.a a = new b9b.a();

		// Token: 0x04000F49 RID: 3913
		public static Func<bool, float> b;
	}
}
