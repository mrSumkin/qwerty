using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020016CC RID: 5836
[eiz("A38")]
[Serializable]
public sealed class eli : a6k, ISerializable
{
	// Token: 0x06007F1D RID: 32541 RVA: 0x0035C8B0 File Offset: 0x0035AAB0
	private eli(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F1E RID: 32542 RVA: 0x0035C8BC File Offset: 0x0035AABC
	public eli()
	{
	}

	// Token: 0x06007F1F RID: 32543 RVA: 0x0035C8C4 File Offset: 0x0035AAC4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				int num = Convert.ToInt32((double)b.aa().Defense.q().zm() * e67.a(base.vg().e()));
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				if (num > 0)
				{
					c5x a_ = c5x;
					string a_2 = "NeuralOverload";
					int a_3 = 1;
					double maxValue = double.MaxValue;
					bool a_4 = true;
					bool a_5 = true;
					Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, c5x.Size.Z / 2f));
					float? a_7 = dz6.b();
					a7j item = new a7j(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false, null);
					qy.ad().Add(item);
					bfq bfq = new bfq();
					bfq.b("NeuralOverload" + Guid.NewGuid().ToString());
					bfq.c("NeuralOverloadHit");
					bfq.a(bvl.c);
					akg item2 = new akg(b, b, new cwt
					{
						l = true,
						p = true,
						i = new ap9(b.aa()),
						j = new ap9(b.aa()),
						b = true,
						e = false,
						q = false,
						ah = true,
						f = 
						{
							new csk(DamageType.Electricity, num)
						}
					}, null, false);
					qy.ad().Add(item2);
					qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
				}
				b0c b0c = new b0c(d11.a * d0u.b);
				qy.ad().Add(new amd(b, new els[]
				{
					b0c
				}));
				c5x.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
