using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020015DC RID: 5596
[eiz("TKGA")]
[Serializable]
public sealed class i4 : a6k, ISerializable
{
	// Token: 0x06007B66 RID: 31590 RVA: 0x003391BC File Offset: 0x003373BC
	private i4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B67 RID: 31591 RVA: 0x003391C8 File Offset: 0x003373C8
	public i4()
	{
	}

	// Token: 0x06007B68 RID: 31592 RVA: 0x003391D4 File Offset: 0x003373D4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if ((base.vg().q() != null && base.vg().q().h.b != null && c5x == null) || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		int a_ = base.vg().e().b8().Offense.ag()[PsiSchool.Psychokinesis].b();
		aw1.b(base.vg().q().h.b.a8(), c5x, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		awq.a(qy, base.vg().q(), c5x, true, true);
		qy.ad().Add(new a4s(new bfq("TelekineticGroundingApply"), null, new ar7(c5x), null));
		qy.ad().Add(new bm3(dz6.b(150)));
		qy.ad().Add(new amd(c5x.h.b, new els[]
		{
			new ro(bfk.a(base.vg().e()), a_)
		}));
		c5x.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		Vector3 a_2 = c5x.aj() - new Vector3(0.5f, 0.5f, 0f);
		a_2.Z = c5x.Location.Z;
		dv1.a(new List<string>
		{
			"Projectiles\\PsiFlake"
		}, c5x.Area, a_2, 25, 200, 2f, 6f, true, true, false, new Action<c5x>(cv.a), true);
		return dc4.c;
	}
}
