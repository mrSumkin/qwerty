using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000AFB RID: 2811
[eiz("XPBLSJJ")]
[Serializable]
public sealed class d90 : cze, ISerializable
{
	// Token: 0x06004132 RID: 16690 RVA: 0x0018DFD0 File Offset: 0x0018C1D0
	private d90(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004133 RID: 16691 RVA: 0x0018DFDC File Offset: 0x0018C1DC
	public d90()
	{
	}

	// Token: 0x06004134 RID: 16692 RVA: 0x0018DFE8 File Offset: 0x0018C1E8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 is c5x && A_1 is c5x)
		{
			ak1 ak = Enumerable.FirstOrDefault<ak1>(A_1.l);
			if (ak != null)
			{
				if (!aw1.a(A_0, ak, false, null))
				{
					a0l.a((c5x)A_0, A_1.Area, A_1.Location, null, true);
					boj.c(A_1.Area, A_1.Location.a());
					(A_1 as c5x).c().a("SiphonerSplashOut");
					amc aspect = A_0.GetAspect<amc>();
					ny aspect2 = A_0.GetAspect<ny>();
					if (aspect != null && aspect2 != null)
					{
						e4t a_ = new e4t(aspect, CharacterState.Throw, dz6.b(70), 4, new int?(6), 1);
						aspect2.b(a_, atp.a);
						return;
					}
				}
				else
				{
					bmj.a(A_1, new d53("Нет места", adi.l, null, false));
				}
			}
		}
	}
}
