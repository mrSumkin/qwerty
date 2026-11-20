using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x02001023 RID: 4131
[eiz("PTCSEEJ")]
[Serializable]
public sealed class c5f : cze, ISerializable
{
	// Token: 0x06005540 RID: 21824 RVA: 0x0025AC48 File Offset: 0x00258E48
	private c5f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005541 RID: 21825 RVA: 0x0025AC54 File Offset: 0x00258E54
	public c5f()
	{
	}

	// Token: 0x06005542 RID: 21826 RVA: 0x0025AC5C File Offset: 0x00258E5C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		try
		{
			object obj;
			if (A_2 != null && A_2.TryGetValue("StatusEffect", out obj))
			{
				c3k c3k = obj as c3k;
				if (c3k != null)
				{
					double num = c0o.a(c3k.b);
					if (cuo.a.NextDouble() < num)
					{
						c5x c5x = A_1 as c5x;
						if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead)
						{
							double num2 = 1.0 + 1.0 * cuo.a.NextDouble();
							double num3 = 0.5 + 0.5 * cuo.a.NextDouble();
							double num4 = 0.5 + 0.5 * cuo.a.NextDouble();
							int a_ = Convert.ToInt32((double)c3k.Duration * num2);
							int a_2 = Convert.ToInt32((double)Enumerable.First<d9>(Enumerable.OfType<d9>(c3k.StaticEffects)).Amount * num3);
							int num5 = Convert.ToInt32((double)Enumerable.First<ba>(Enumerable.OfType<ba>(c3k.StaticEffects)).Amount * num4);
							float a_3 = (float)num5 * 0.0075f;
							qy qy = new qy();
							qy.b(false);
							qy.c(false);
							bfq bfq = new bfq();
							bfq.b("xpbl_TemporalSlow" + Guid.NewGuid().ToString());
							bfq.c("xpbl_TemporalSlow");
							qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
							c5x a_4 = c5x;
							string a_5 = "Xpbl_TemporalSlow";
							int a_6 = 1;
							double maxValue = double.MaxValue;
							bool a_7 = false;
							bool a_8 = true;
							float? a_9 = dz6.b();
							a7j item = new a7j(a_4, a_5, a_6, maxValue, a_7, a_8, null, null, null, a_9, false, null);
							qy.ad().Add(item);
							bzq bzq = new bzq(a_, a_2, num5, a_3);
							qy.ad().Add(new amd(c5x.h.b, new els[]
							{
								bzq
							}));
							c5x.Zone.ActionManager.g9(qy, atp.a);
							dz6.a(qy);
						}
					}
				}
			}
		}
		catch (Exception a_10)
		{
			dux.a(LogSeverity.Error, a_10, "Ошибка произошла при попытке растянуть психовременное сокращение.", new object[0]);
		}
	}
}
