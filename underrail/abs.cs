using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B05 RID: 2821
[eiz("XPBLKADBBJ")]
[Serializable]
public sealed class abs : cze, ISerializable
{
	// Token: 0x06004153 RID: 16723 RVA: 0x0018F804 File Offset: 0x0018DA04
	private abs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004154 RID: 16724 RVA: 0x0018F810 File Offset: 0x0018DA10
	public abs()
	{
	}

	// Token: 0x06004155 RID: 16725 RVA: 0x0018F818 File Offset: 0x0018DA18
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value;
			foreach (d4n d4n in bpo.GetServiceOrThrow<d02>().ahl())
			{
				if (d4n.b != null && (d4n.b.aa().FactionId == asp.f5 || d4n.b.aa().FactionId == asp.f6) && d4n.b.a8() != null)
				{
					if (value)
					{
						if (d4n.b.a8().t.b.y6().GetClassPropertyValue<string>(ddq.bv) != "defensePerimeter")
						{
							bool flag = true;
							foreach (ak1 ak in d4n.b.a8().l)
							{
								List<ya> list = ak.a(typeof(a41));
								bool flag2 = false;
								if (list != null)
								{
									foreach (ya ya in list)
									{
										a41 a = ya as a41;
										if (a != null && a.MarkerCode == "defensePerimeter")
										{
											flag2 = true;
											break;
										}
									}
								}
								if (!flag2)
								{
									flag = false;
									break;
								}
							}
							if (flag)
							{
								d4n.b.a8().t.b.y6()[ddq.bv] = "defensePerimeter";
							}
						}
					}
					else
					{
						d4n.b.a8().t.b.y6().RemoveProperty(ddq.bv);
					}
				}
			}
		}
	}
}
