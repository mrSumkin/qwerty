using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B44 RID: 2884
[eiz("S36")]
[Serializable]
public sealed class asc : cze, ISerializable
{
	// Token: 0x06004249 RID: 16969 RVA: 0x0019AE08 File Offset: 0x00199008
	private asc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600424A RID: 16970 RVA: 0x0019AE14 File Offset: 0x00199014
	public asc()
	{
	}

	// Token: 0x0600424B RID: 16971 RVA: 0x0019AE20 File Offset: 0x00199020
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			aud aud = A_0.Area;
			if (aud != null && aud.Zone != null)
			{
				EntityAspectReference<c0s, c0s> entityAspectReference = new EntityAspectReference<c0s, c0s>(aud, new Guid("097f123b-4124-4119-b359-3b420f12c7bf"));
				if (entityAspectReference.ao() != null)
				{
					entityAspectReference.ao().a("Вы оказываетесь на маленьком острове посреди озера и не помните, как вы здесь очутились.", true, null, null);
				}
				ay5 ay = new ay5();
				ay.b(true);
				ay.a("NeuralOverload");
				ay.a(true);
				ay.ym(null, null, null);
				csd csd = aud.Zone.g("ezraTrialBeetle");
				if (csd != null)
				{
					c5x c5x = vq.a("creatures\\YoungPsiBeetle", false);
					if (c5x != null)
					{
						c5x.Location = csd.Location;
						c5x.VisualDirection = csd.Direction;
						c5x.RemoveAspect<a6p>();
						List<cze> list = c5x.h.b.ay();
						dgq dgq = new dgq();
						dgq.a("Sgs_EzraTrialEnd");
						list.Add(dgq);
						aud.a(c5x);
					}
				}
			}
		}
	}
}
